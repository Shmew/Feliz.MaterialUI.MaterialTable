[<RequireQualifiedAccess>]
module Samples.Editable

open Feliz
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

let render = React.functionComponent (fun () ->
    let state, setState = 
        [ { name = "Mehmet"; 
            surname = "Baran"
            birthYear = 1987
            birthCity = 63 }
          { name = "Zerya Betül"
            surname = "Baran"
            birthYear = 2017
            birthCity = 34 } ]
        |> React.useState

    Mui.materialTable [
        materialTable.title "Editable Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field "name"
            ]
            columns.column [
                column.title "Surname"
                column.field "surname"
                column.initialEditValue "Initial edit value"
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
        materialTable.data state
        materialTable.editable [
            editable.onRowAdd<RowData> (fun newData ->
                Promise.create (fun res reject ->
                    state @ [ newData ]
                    |> setState
                    res()
                )
            )
            editable.onRowUpdate<RowData> (fun newData oldData ->
                Promise.create (fun res reject ->
                    state 
                    |> List.map (fun d -> if d = oldData then newData else d)
                    |> setState
                    res()
                )
            )
            editable.onRowDelete<RowData> (fun oldData ->
                Promise.create (fun res reject ->
                    state
                    |> List.filter (fun d -> d <> oldData)
                    |> setState
                    res()
                )
            )
        ]
    ])
