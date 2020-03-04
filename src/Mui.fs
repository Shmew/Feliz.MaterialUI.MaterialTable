namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.MaterialUI

[<Erase>]
type Mui =
    static member inline materialTable (props: IReactProperty list) = reactElement (importDefault "material-table") (createObj !!props)
    static member inline mTableAction (props: IReactProperty list) = reactElement (import "MTableAction" "material-table") (createObj !!props)
    static member inline mTableActions (props: IReactProperty list) = reactElement (import "MTableActions" "material-table") (createObj !!props)
    static member inline mTableBodyRow (props: IReactProperty list) = reactElement (import "MTableBodyRow" "material-table") (createObj !!props)
    static member inline mTableBody (props: IReactProperty list) = reactElement (import "MTableBody" "material-table") (createObj !!props)
    static member inline mTableCell (props: IReactProperty list) = reactElement (import "MTableCell" "material-table") (createObj !!props)
    static member inline mTableEditField (props: IReactProperty list) = reactElement (import "MTableEditField" "material-table") (createObj !!props)
    static member inline mTableEditRow (props: IReactProperty list) = reactElement (import "MTableEditRow" "material-table") (createObj !!props)
    static member inline mTableFilterRow (props: IReactProperty list) = reactElement (import "MTableFilterRow" "material-table") (createObj !!props)
    static member inline mTableGroupRow (props: IReactProperty list) = reactElement (import "MTableGroupRow" "material-table") (createObj !!props)
    static member inline mTableGroupbar (props: IReactProperty list) = reactElement (import "MTableGroupbar" "material-table") (createObj !!props)
    static member inline mTableHeader (props: IReactProperty list) = reactElement (import "MTableHeader" "material-table") (createObj !!props)
    static member inline mTablePagination (props: IReactProperty list) = reactElement (import "MTablePagination" "material-table") (createObj !!props)
    static member inline mTableSteppedPagination (props: IReactProperty list) = reactElement (import "MTableSteppedPagination" "material-table") (createObj !!props)
    static member inline mTableToolbar (props: IReactProperty list) = reactElement (import "MTableToolbar" "material-table") (createObj !!props)
    