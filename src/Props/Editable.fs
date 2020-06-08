namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Feliz
open System

[<Erase>]
type editable =
    /// Allows dynamic adjustment of deletion action based on row data.
    static member inline isDeleteHidden<'T> (handler: 'T -> bool) =
        Interop.mkEditableAttr "isDeleteHidden" handler

    /// Allows dynamic adjustment of edit action based on row data.
    static member inline isEditHidden<'T> (handler: 'T -> bool) =
        Interop.mkEditableAttr "isEditHidden" handler

    /// Fired when a new row is added, given row data.
    static member inline onRowAdd<'T> (handler: 'T -> JS.Promise<unit>) = 
        Interop.mkEditableAttr "onRowAdd" handler
    /// Fired when a new row is added, given row data.
    static member inline onRowAdd<'T> (handler: 'T -> Async<unit>) = 
        Interop.mkEditableAttr "onRowAdd" (handler >> Async.StartAsPromise)

    /// Fired when a row add is cancelled.
    static member inline onRowAddCancelled<'T> (handler: 'T -> JS.Promise<unit>) = 
        Interop.mkEditableAttr "onRowAddCancelled" handler
    /// Fired when a row add is cancelled.
    static member inline onRowAddCancelled<'T> (handler: 'T -> Async<unit>) = 
        Interop.mkEditableAttr "onRowAddCancelled" (handler >> Async.StartAsPromise)
    
    /// Fired when a row update is cancelled.
    static member inline onRowUpdateCancelled<'T> (handler: 'T -> JS.Promise<unit>) = 
        Interop.mkEditableAttr "onRowUpdateCancelled" handler
    /// Fired when a row update is cancelled.
    static member inline onRowUpdateCancelled<'T> (handler: 'T -> Async<unit>) = 
        Interop.mkEditableAttr "onRowUpdateCancelled" (handler >> Async.StartAsPromise)

    /// Fired when a row is updated, given newData and oldData respectively
    static member inline onRowUpdate<'T> (handler: 'T -> 'T -> JS.Promise<unit>) = 
        Interop.mkEditableAttr "onRowUpdate" (Func<_,_,_> handler)
    /// Fired when a row is updated, given newData and oldData respectively
    static member inline onRowUpdate<'T> (handler: 'T -> 'T -> Async<unit>) = 
        Func<_,_,_>(fun newData oldData -> handler newData oldData |> Async.StartAsPromise)
        |> Interop.mkEditableAttr "onRowUpdate"

    /// Fired when a row is deleted, given the old data
    static member inline onRowDelete<'T> (handler: 'T -> JS.Promise<unit>) = 
        Interop.mkEditableAttr "onRowDelete" handler
    /// Fired when a row is deleted, given the old data
    static member inline onRowDelete<'T> (handler: 'T -> Async<unit>) = 
        Interop.mkEditableAttr "onRowDelete" (handler >> Async.StartAsPromise)
