namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Feliz
open System

[<Erase>]
type editable =
    /// Fired when a new row is added, given row data
    static member inline onRowAdd<'T> (handler: 'T -> JS.Promise<unit>) = Interop.mkEditableAttr "onRowAdd" handler
    /// Fired when a row is updated, given newData and oldData respectively
    static member inline onRowUpdate<'T> (handler: 'T -> 'T -> JS.Promise<unit>) = Interop.mkEditableAttr "onRowUpdate" (Func<_,_,_> handler)
    /// Fired when a row is deleted, given the old data
    static member inline onRowDelete<'T> (handler: 'T -> JS.Promise<unit>) = Interop.mkEditableAttr "onRowDelete" handler