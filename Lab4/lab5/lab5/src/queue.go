package src

type Queue struct {
	MaxLength int
	Items     []*Item
}

func (q *Queue) Length() int {
	return len(q.Items)
}

func (q *Queue) Push(item *Item) bool {
	if len(q.Items) < q.MaxLength {
		q.Items = append(q.Items, item)
		return true
	}
	return false
}

func (q *Queue) Pop() *Item {
	if len(q.Items) == 0 {
		return nil
	}

	item := q.Items[len(q.Items)-1]
	q.Items = q.Items[:len(q.Items)-1]

	return item
}

func (q *Queue) IsFull() bool {
	return len(q.Items) == q.MaxLength
}