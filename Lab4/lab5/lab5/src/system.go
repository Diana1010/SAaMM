package src

import (
	"fmt"
	"log"
	"math/rand"
)

const (
	Debug = false
	MinutesToHours = 60.0
)

type System struct {
	Handlers       []*Handler
	Generators     []*Generator
	ProcessedItems []*Item
}

func (s *System) Tick() {

	//s.shuffleGenerators()
	//s.shuffleHandlers()
	s.generateNewItems()

	s.processHandlersItems()

	s.assignHandlersToGeneratedItems()

	s.incrementWaitingCounters()

	s.State()
}

func (s *System) processHandlersItems() {
	for _, handler := range s.Handlers {
		item := handler.CurrentItem
		if item != nil && handler.MaybeHandle() {
			s.ProcessedItems = append(s.ProcessedItems, item)
		}
	}
}

func (s *System) generateNewItems() {
	for _, gen := range s.Generators {
		if !gen.IsBlocked() {
			gen.MaybeGenerate()
		}
	}
}

func (s *System) shuffleGenerators() {
	dest := make([]*Generator, len(s.Generators))
	perm := rand.Perm(len(s.Generators))
	for i, v := range perm {
		dest[v] = s.Generators[i]
	}
	s.Generators = dest
}
func (s *System) shuffleHandlers() {
	dest := make([]*Handler, len(s.Handlers))
	perm := rand.Perm(len(s.Handlers))
	for i, v := range perm {
		dest[v] = s.Handlers[i]
	}
	s.Handlers = dest
}

func (s *System) assignHandlersToGeneratedItems() {
	for _, gen := range s.Generators {
		item := gen.CurrentItem
		if item != nil && item.Handler == nil {
			for _, handler := range s.Handlers {
				if !handler.HasItem() {
					item.Handler = handler
					handler.SetItem(item)
					break
				}
			}
		}
	}
}

func (s *System) incrementWaitingCounters() {
	for _, gen := range s.Generators {
		if gen.HasItem() {
			gen.CurrentItem.Waiting += 1
		}
	}
}

func (s *System) TotalGeneratorsWaitingResponse() int {
	w := 0
	for _, gen := range s.Generators {
		//if gen.HasItem() && gen.CurrentItem.Handler != nil {
		if gen.HasItem() {
			w++
		}
	}

	return w
}

func (s *System) State() {
	if !Debug {
		return
	}

	state := ""

	for _, generator := range s.Generators {
		if generator.HasItem() {
			if generator.CurrentItem.Handler == nil {
				state += "W"
			} else {
				state += "H"
			}
		} else {
			state += "N"
		}
	}
	state += "|"

	for _, handler := range s.Handlers {
		if handler.HasItem() {
			if handler.CurrentItem == nil {
				state += "W"
			} else {
				state += "P"
			}
		}
	}

	log.Print(state)
}

func (s *System) Stats() {
	generatorsStat := ""
	consumersStat := ""

	for _, gen := range s.Generators {
		generatorsStat = fmt.Sprintf("%s\t%d", generatorsStat, gen.Generated)
	}

	for _, h := range s.Handlers {
		consumersStat = fmt.Sprintf("%s\t%d", consumersStat, h.Processed)
	}

	fmt.Println(generatorsStat)
	fmt.Println(consumersStat)
}
