[<RequireQualifiedAccess>]
module Samples.Filtering

open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

let private (|Int|_|) (str: string) =
    match System.Int32.TryParse(str) with
    | true,res -> Some res
    | _ -> None

let render = React.functionComponent (fun () ->
    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]
        materialTable.title "Filtering Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field "name"
                column.filterPlaceholder "Filter on field size (int)"
                column.customFilterAndSearch<RowData> (fun term rowData _ -> match term with | Int i -> i = rowData.name.Length | _ -> false)
            ]
            columns.column [
                column.title "Surname"
                column.field "surname"
            ]
            columns.column [
                column.title "Birth Year"
                column.field "birthYear"
                column.type'.numeric
                column.filtering false
            ]
            columns.column [
                column.title "Birth Place"
                column.field "birthCity"
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
            options.filtering true
        ]
    ])
