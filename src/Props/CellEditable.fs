namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open System

[<Erase>]
type cellEditable =
    /// Css style to be applied to the cell
    static member inline cellStyle (props: #IStyleAttribute list) = Interop.mkCellEditableAttr "cellStyle" (createObj !!props)

    /// This event will be fired when the cell edit is approved. 
    ///
    /// Parameters are the new value, old value, row data, and column definiton respectively
    static member inline onCellEditApproved<'CellValue,'RowData> (handler: 'CellValue -> 'CellValue -> 'RowData -> Bindings.Column<'RowData> -> JS.Promise<unit>) = 
        Interop.mkCellEditableAttr "onCellEditApproved" (Func<_,_,_,_,_> handler)
