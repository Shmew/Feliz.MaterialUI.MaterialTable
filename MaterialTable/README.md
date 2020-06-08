# Feliz.MaterialUI.MaterialTable [![Nuget](https://img.shields.io/nuget/v/Feliz.MaterialUI.MaterialTable.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.MaterialUI.MaterialTable)

Fable bindings for [material-table](https://github.com/mbrn/material-table) with [Feliz](https://github.com/Zaid-Ajaj/Feliz) style api for use within MaterialUI.

Here is a quick look:

```fs
open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

let render = React.functionComponent (fun () ->
    Mui.materialTable [
        materialTable.title "My Title"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field<RowData> (fun rd -> nameof rd.name)
            ]
            columns.column [
                column.title "Surname"
                column.field<RowData> (fun rd -> nameof rd.surname)
            ]
            columns.column [
                column.title "Birth Year"
                column.field<RowData> (fun rd -> nameof rd.birthYear)
                column.type'.numeric
            ]
            columns.column [
                column.title "Birth Place"
                column.field<RowData> (fun rd -> nameof rd.birthCity)
                column.lookup<int,string> [ 
                    (34, "İstanbul")
                    (63, "Şanlıurfa") 
                ]
            ]
        ]
        materialTable.data [
            { name = "Mehmet"
              surname = "Baran"
              birthYear = 1987
              birthCity = 63 }
            { name = "Zerya Betül"
              surname = "Baran"
              birthYear = 2017
              birthCity = 34 }
        ]
    ])
```

Find documentation [here](https://shmew.github.io/Feliz.MaterialUI.MaterialTable/) with live examples.
