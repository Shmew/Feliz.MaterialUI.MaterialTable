# Feliz.MaterialUI.MaterialTable - Styling

Taken from [material-table - Styling](https://material-table.com/#/docs/features/styling)

```fsharp:materialtable-styling
[<RequireQualifiedAccess>]
module Samples.Styling

open Fable.Core.Experimental
open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

let render = React.functionComponent (fun () ->
    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]
        materialTable.title "Styling Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field<RowData> (fun rd -> nameof rd.name)
                column.cellStyle [
                    style.backgroundColor "#039BE5"
                    style.color "#FFF"
                ]
                column.headerStyle [
                    style.backgroundColor "#039BE5"
                ]
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
        materialTable.options [
            options.headerStyle [
                style.backgroundColor "#01579b"
                style.color "#FFF"
            ]
        ]
    ])
```