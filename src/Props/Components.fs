namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Feliz

[<Erase>]
type components =
    static member inline action (comp: ReactElement) = Interop.mkComponentsAttr "Action" comp
    static member inline action<'T> (handler: Bindings.Components.ActionProps<'T> -> ReactElement) = Interop.mkComponentsAttr "Action" handler
    static member inline action (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Action" handler
    static member inline action (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Action" styledComp

    static member inline actions (comp: ReactElement) = Interop.mkComponentsAttr "Actions" comp
    static member inline actions (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Actions" handler
    static member inline actions (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Actions" styledComp

    static member inline body (comp: ReactElement) = Interop.mkComponentsAttr "Body" comp
    static member inline body (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Body" handler
    static member inline body (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Body" styledComp

    static member inline cell (comp: ReactElement) = Interop.mkComponentsAttr "Cell" comp
    static member inline cell (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Cell" handler
    static member inline cell (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Cell" styledComp

    static member inline container (comp: ReactElement) = Interop.mkComponentsAttr "Container" comp
    static member inline container (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Container" handler
    static member inline container (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Container" styledComp

    static member inline editCell (comp: ReactElement) = Interop.mkComponentsAttr "EditCell" comp
    static member inline editCell (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "EditCell" handler
    static member inline editCell (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "EditCell" styledComp

    static member inline editField (comp: ReactElement) = Interop.mkComponentsAttr "EditField" comp
    static member inline editField (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "EditField" handler
    static member inline editField (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "EditField" styledComp

    static member inline editRow (comp: ReactElement) = Interop.mkComponentsAttr "EditRow" comp
    static member inline editRow (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "EditRow" handler
    static member inline editRow (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "EditRow" styledComp

    static member inline filterRow (comp: ReactElement) = Interop.mkComponentsAttr "FilterRow" comp
    static member inline filterRow (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "FilterRow" handler
    static member inline filterRow (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "FilterRow" styledComp

    static member inline groupbar (comp: ReactElement) = Interop.mkComponentsAttr "Groupbar" comp
    static member inline groupbar (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Groupbar" handler
    static member inline groupbar (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Groupbar" styledComp

    static member inline header (comp: ReactElement) = Interop.mkComponentsAttr "Header" comp
    static member inline header (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Header" handler
    static member inline header (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Header" styledComp

    static member inline overlayLoading (comp: ReactElement) = Interop.mkComponentsAttr "OverlayLoading" comp
    static member inline overlayLoading (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "OverlayLoading" handler
    static member inline overlayLoading (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "OverlayLoading" styledComp

    static member inline overlayError (comp: ReactElement) = Interop.mkComponentsAttr "OverlayError" comp
    static member inline overlayError (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "OverlayError" handler
    static member inline overlayError (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "OverlayError" styledComp

    static member inline pagination (comp: ReactElement) = Interop.mkComponentsAttr "Pagination" comp
    static member inline pagination (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Pagination" handler
    static member inline pagination (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Pagination" styledComp

    static member inline row (comp: ReactElement) = Interop.mkComponentsAttr "Row" comp
    static member inline row (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Row" handler
    static member inline row (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Row" styledComp

    static member inline toolbar (comp: ReactElement) = Interop.mkComponentsAttr "Toolbar" comp
    static member inline toolbar (handler: MaterialUI.PropsObject -> ReactElement) = Interop.mkComponentsAttr "Toolbar" handler
    static member inline toolbar (styledComp: Bindings.Components.StyledComponent) = Interop.mkComponentsAttr "Toolbar" styledComp
