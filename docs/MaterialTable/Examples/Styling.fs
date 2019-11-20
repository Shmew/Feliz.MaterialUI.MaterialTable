[<RequireQualifiedAccess>]
module Samples.Styling

open Feliz
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

let render = React.functionComponent (fun () ->
    Mui.materialTable [
        materialTable.title "Styling Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field "name"
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
                column.field "surname"
            ]
            columns.column [
                column.title "Birth Year"
                column.field "birthYear"
                column.type'.numeric
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
            options.headerStyle [
                style.backgroundColor "#01579b"
                style.color "#FFF"
            ]
        ]
    ])
