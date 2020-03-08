[<RequireQualifiedAccess>]
module Samples.FixedColumns

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
    Html.div [
        prop.style [
            style.width (length.px 1000)
        ]
        prop.children [
            Mui.materialTable [
                materialTable.title "Basic Fixed Columns Preview"
                materialTable.columns [
                    columns.column [
                        column.title "Name"
                        column.field<RowData> (fun rd -> nameof rd.name)
                        column.width 150
                    ]
                    columns.column [
                        column.title "Surname"
                        column.field<RowData> (fun rd -> nameof rd.surname)
                        column.width 150
                    ]
                    columns.column [
                        column.title "Birth Year"
                        column.field<RowData> (fun rd -> nameof rd.birthYear)
                        column.width 150
                        column.type'.numeric
                    ]
                    columns.column [
                        column.title "Birth Place"
                        column.field<RowData> (fun rd -> nameof rd.birthCity)
                        column.width 150
                        column.lookup<int,string> [ 
                            (34, "İstanbul")
                            (63, "Şanlıurfa") 
                        ]
                    ]
                    columns.column [
                        column.title "Name"
                        column.field<RowData> (fun rd -> nameof rd.name)
                        column.width 150
                    ]
                    columns.column [
                        column.title "Surname"
                        column.field<RowData> (fun rd -> nameof rd.surname)
                        column.width 150
                    ]
                    columns.column [
                        column.title "Birth Year"
                        column.field<RowData> (fun rd -> nameof rd.birthYear)
                        column.width 150
                        column.type'.numeric
                    ]
                    columns.column [
                        column.title "Birth Place"
                        column.field<RowData> (fun rd -> nameof rd.birthCity)
                        column.width 150
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
                    options.fixedColumns [
                        fixedColumns.left 2
                        fixedColumns.right 1
                    ]
                ]  
            ]
        ]
    ]
    )
