package main

import (
	"fmt"
	"math/rand"
	"time"

	"./src"
)

var (
	ticks            = 100000 * 60
	simulations      = 10
	generatorsLambda = 2.5
	generatorsCount  = 6
	handlersCount    = 1
)

func main() {

	//for simulation := 0; simulation <= simulations; simulation++ {

	rand.Seed(time.Now().UTC().UnixNano())

	generators := make([]*src.Generator, 0)
	for i := 0; i < generatorsCount; i++ {
		generators = append(generators, src.NewGenerator(generatorsLambda))
	}

	handlers := make([]*src.Handler, 0)
	for i := 0; i < handlersCount; i++ {
		handlers = append(handlers, &src.Handler{
			ID:          i,
			CurrentItem: nil,
		})
	}

	system := &src.System{
		Handlers:       handlers,
		Generators:     generators,
		ProcessedItems: make([]*src.Item, 0),
	}

	generatorsWaitingTotal := 0

	for i := 0; i <= ticks; i++ {
		system.Tick()
		generatorsWaitingTotal += system.TotalGeneratorsWaitingResponse()
	}

	responseWaitingTotal := 0
	asd := make([]int, 0, len(system.ProcessedItems)-1)
	for _, item := range system.ProcessedItems {
		responseWaitingTotal += item.Waiting
		asd = append(asd, item.Waiting)
	}

	noQueue := 0
	for _, it := range asd {
		if it == 10 {
			noQueue++
		}
	}

	fmt.Printf("Lc: %f\tWc: %f\tA: %f\n",
		float64(float64(generatorsWaitingTotal)/float64(ticks)),
		float64(float64(responseWaitingTotal)/src.MinutesToHours/float64(len(system.ProcessedItems))),
		float64(float64(len(system.ProcessedItems))/(float64(ticks/src.MinutesToHours))),
	)

	//	}

}
