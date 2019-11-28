package src

const (
	ProcessingRequired = 10
)

type Item struct {
	ID                 int
	ProcessingTime     int
	ProcessingRequired int
	Waiting            int
	Parent             *Generator
	Handler            *Handler
}


func (i *Item) Processed() {
	i.Handler = nil
	i.Parent.CurrentItem = nil
}