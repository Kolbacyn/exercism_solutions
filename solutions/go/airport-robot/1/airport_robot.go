package airportrobot

import (
    "fmt"
)

type Greeter interface {
    LanguageName() string
    Greet(name string) string
}

func SayHello(name string, g Greeter) string {
    return fmt.Sprintf("I can speak %s: %s", g.LanguageName(), g.Greet(name))
}

type Italian struct {}

func (g Italian) Greet(name string) string {
    return fmt.Sprintf("Ciao %v!", name)
}

func (g Italian) LanguageName() string {
    return "Italian"
}

type Portuguese struct {}

func (g Portuguese) Greet(name string) string {
    return fmt.Sprintf("Olá %v!", name)
}

func (g Portuguese) LanguageName() string {
    return "Portuguese"
}