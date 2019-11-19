namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Feliz

[<Erase>]
type components =
    static member inline action<'T> (handler: Bindings.Components.ActionProps<'T> -> ReactElement) = Interop.mkComponentsAttr "Action" handler
    static member inline actions (comp: ReactElement) = Interop.mkComponentsAttr "Actions" comp
    static member inline body (comp: ReactElement) = Interop.mkComponentsAttr "Body" comp
    static member inline cell (comp: ReactElement) = Interop.mkComponentsAttr "Cell" comp
    static member inline container (comp: ReactElement) = Interop.mkComponentsAttr "Container" comp
    static member inline editField (comp: ReactElement) = Interop.mkComponentsAttr "EditField" comp
    static member inline editRow (comp: ReactElement) = Interop.mkComponentsAttr "EditRow" comp
    static member inline filterRow (comp: ReactElement) = Interop.mkComponentsAttr "FilterRow" comp
    static member inline groupbar (comp: ReactElement) = Interop.mkComponentsAttr "Groupbar" comp
    static member inline header (comp: ReactElement) = Interop.mkComponentsAttr "Header" comp
    static member inline overlayLoading (comp: ReactElement) = Interop.mkComponentsAttr "OverlayLoading" comp
    static member inline pagination (comp: ReactElement) = Interop.mkComponentsAttr "Pagination" comp
    static member inline row (comp: ReactElement) = Interop.mkComponentsAttr "Row" comp
    static member inline toolbar (comp: ReactElement) = Interop.mkComponentsAttr "Toolbar" comp
