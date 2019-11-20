[<RequireQualifiedAccess>]
module Samples.ComponentOverriding

open Elmish.SweetAlert
open Fable.Core
open Fable.MaterialUI.Icons
open Feliz
open Feliz.ElmishComponents
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

type private Model = { Dummy: string }

let private init () = { Dummy = "" }

type private Msg =
    | AddRow
    | SaveRow of string

let private update msg model =
    match msg with
    | AddRow ->
        model,
        SimpleAlert("Not in my demo you ain't!")
            .Type(AlertType.Error)
        |> SweetAlert.Run
    | SaveRow s ->
        model,
        SimpleAlert(sprintf "Saved %s!" s)
            .Type(AlertType.Success)
        |> SweetAlert.Run

let private view = React.functionComponent (fun (input: {| model: Model; dispatch: Msg -> unit |}) ->
    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]
        materialTable.title "Action Overriding Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field "name"
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
            { name = "Mehmet"; surname = "Baran"; birthYear = 1987; birthCity = 63 }
            { name = "Zerya Betül"; surname = "Baran"; birthYear = 2017; birthCity = 34 }
        ]
        materialTable.actions [
            actions.action [
                action.icon (Mui.icon [ addIcon [] ])
                action.tooltip "Add User"
                action.isFreeAction true
                action.onClick (fun _ _ -> input.dispatch AddRow)
            ]
            actions.action [
                action.icon (Mui.icon [ saveIcon [] ])
                action.tooltip "Save User"
                action.onClick<RowData> (fun _ rowData -> input.dispatch (SaveRow rowData.name))
            ]
        ]
        materialTable.components [
            components.action (fun props ->
                let propAction =
                    match props.action with
                    | U2.Case1 singAction -> singAction
                    | U2.Case2 funAction -> funAction (props.data.Value)

                Mui.button [
                    if props.data.IsSome then prop.onClick <| fun ev -> propAction.onClick ev props.data.Value
                    button.color.primary
                    button.variant.contained
                    prop.style [ style.textTransform.none ]
                    button.size.small
                    prop.text "Such custom!"
                ]
            )
        ]
        materialTable.options [
            options.headerStyle [
                style.backgroundColor theme.palette.background.``default``
            ]
        ]
    ])

let render () = React.elmishComponent("freeAction", init(), update, (fun model dispatch -> view {| model = model; dispatch = dispatch |} ))
