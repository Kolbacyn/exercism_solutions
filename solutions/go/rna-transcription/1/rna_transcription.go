package strand

import (
    "strings"
)

var conversionDNAToRNA = map[rune]string{
    'G': "C",
    'C': "G",
    'T': "A",
    'A': "U",
}

func ToRNA(dna string) string {
	var rna strings.Builder
    for _, a := range dna {
        if val, ok := conversionDNAToRNA[a]; ok {
            rna.WriteString(val)
        } else {
            return ""
        }
    }
    return rna.String()
}
