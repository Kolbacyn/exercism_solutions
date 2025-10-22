package census

type Resident struct {
	Name    string
	Age     int
	Address map[string]string
}

func NewResident(name string, age int, address map[string]string) *Resident {
	return &Resident{Name: name, Age: age, Address: address}
}

func (r *Resident) HasRequiredInfo() bool {
	if r.Name != "" && r.Address["street"] != "" {
        return true
    }
    return false
}

func (r *Resident) Delete() {
	r.Name = ""
    r.Age = 0
    r.Address = nil
}

func Count(residents []*Resident) int {
	counter := 0
    for i := range residents {
        if residents[i].HasRequiredInfo() {
            counter++
        }
    }
    return counter
}
