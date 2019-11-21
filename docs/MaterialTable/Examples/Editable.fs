[<RequireQualifiedAccess>]
module Samples.Editable

open Fable.Core.Experimental
open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int
      someDateTime: System.DateTime }

let render = React.functionComponent (fun () ->
    let state, setState = 
        [ { name = "Mehmet"
            surname = "Baran"
            birthYear = 1987
            birthCity = 63
            someDateTime = System.DateTime.Now }
          { name = "Zerya Betül"
            surname = "Baran"
            birthYear = 2017
            birthCity = 34 
            someDateTime = System.DateTime.Today } ]
        |> React.useState

    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]
        materialTable.title "Editable Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field<RowData> (fun rd -> nameof rd.name)
            ]
            columns.column [
                column.title "Surname"
                column.field<RowData> (fun rd -> nameof rd.surname)
                column.initialEditValue "Initial edit value"
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
            columns.column [
                column.title "Some DateTime"
                column.field "someDateTime"
                column.type'.datetime
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
