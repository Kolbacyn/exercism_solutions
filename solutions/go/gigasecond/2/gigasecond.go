// Package gigasecond contains function AddGigasecond which calculates time
// in gigaseconds after a certain date.
package gigasecond

// import path for the time package from the standard library
import (
    "time"
    )

// AddGigasecond accepts one argument t of time.Time type and returns
// time.Time value.
func AddGigasecond(t time.Time) time.Time {
	gigasecond := time.Second * 1e9
	return t.Add(gigasecond)
}
