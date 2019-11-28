package src

import "math/rand"

type Handler struct {
	ID          int
	CurrentItem *Item
	Processed   int
	Attempted   int
	chance      float64
}

func (h *Handler) MaybeHandle() bool {
	h.CurrentItem.ProcessingTime++

	attem := rand.Float64()
	if attem < 0.3 {

		h.Processed++
		h.GetItem().Processed()
		h.SetItem(nil)
		return true

	}

	return false
}

func (h *Handler) SetItem(item *Item) *Handler {
	h.CurrentItem = item
	return h
}

func (h *Handler) GetItem() *Item {
	return h.CurrentItem
}

func (h *Handler) HasItem() bool {
	return h.CurrentItem != nil
}
