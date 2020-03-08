namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open System

[<Erase>]
type action =
    /// Button enabled/disabled
    static member inline disabled (value: bool) = Interop.mkActionAttr "disabled" value
    /// Button hidden flag
    static member inline hidden (value: bool) = Interop.mkActionAttr "hidden" value
    /// Icon of button from material icons or custom component
    static member inline icon (value: string) = Interop.mkActionAttr "icon" value
    /// Icon of button from material icons or custom component
    static member inline icon (value: ReactElement) = Interop.mkActionAttr "icon" (fun () -> value)
    /// Props for icon as IconProps from https://material-ui.com/api/icon/
    static member inline iconProps (props: IReactProperty list) = Interop.mkActionAttr "iconProps" (createObj !!props)
    /// Independent actions that will not on row' actions section
    static member inline isFreeAction (value: bool) = Interop.mkActionAttr "isFreeAction" value
    /// This event will be fired when button clicked. Parameters are event and row or rows
    static member inline onClick<'T> (render: Browser.Types.MouseEvent -> 'T -> unit) = Interop.mkActionAttr "onClick" (Func<_,_,_> render)
    /// Tooltip for button
    static member inline tooltip (value: string) = Interop.mkActionAttr "tooltip" value

module action =
    /// Sets the position of the action
    [<Erase>]
    type position =
        static member inline auto = Interop.mkActionAttr "position" "auto"
        static member inline toolbar = Interop.mkActionAttr "position" "toolbar"
        static member inline toolbarOnSelect = Interop.mkActionAttr "position" "toolbarOnSelect"
        static member inline row = Interop.mkActionAttr "position" "row"

[<Erase>]
type actions =
    static member inline action (props: IActionProperty list) = unbox (createObj !!props) : IActionsProperty
    static member inline action<'T> (rowData: 'T -> IActionProperty list) = unbox (rowData >> (fun res -> createObj !!res)) : IActionsProperty