package src

import (
	"math/rand"
)

type Generator struct {
	Generated   int
	Attempted   int
	chance      float64
	CurrentItem *Item
}

func NewGenerator(lambda float64) *Generator {
	return &Generator{
		Generated: 0,
		chance:    lambda / 60,
	}
}

func (g *Generator) MaybeGenerate() *Item {
	g.Attempted += 1
	attempt := rand.Float64()
	if g.chance > attempt {
		g.Generated += 1
		g.CurrentItem = &Item{
			ID:                 g.Generated,
			ProcessingTime:     0,
			Parent:             g,
			ProcessingRequired: ProcessingRequired,
			Waiting:            1,
		}

		return g.CurrentItem
	}
	return nil
}

func (g *Generator) HasItem() bool {
	return g.CurrentItem != nil
}

func (g *Generator) IsBlocked() bool {
	return g.HasItem()
}
