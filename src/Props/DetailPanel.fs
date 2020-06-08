namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type detailPanel =
    /// Flag for button disabled or enabled
    static member inline disabled (value: bool) = Interop.mkDetailPanelAttr "disabled" value

    /// Icon of button from material icons or custom component
    static member inline icon (value: string) = Interop.mkDetailPanelAttr "icon" value
    /// Icon of button from material icons or custom component
    static member inline icon (value: ReactElement) = Interop.mkDetailPanelAttr "icon" value

    /// Props for icon as IconProps from https://material-ui.com/api/icon/
    static member inline iconProps (props: IReactProperty list) = Interop.mkDetailPanelAttr "iconProps" (createObj !!props)

    /// Independent actions that will not on row' actions section
    static member inline isFreeAction (value: bool) = Interop.mkDetailPanelAttr "isFreeAction" value

    /// Icon of button from material icons or custom component
    static member inline openIcon (value: string) = Interop.mkDetailPanelAttr "openIcon" value
    /// Icon of button from material icons or custom component
    static member inline openIcon (value: ReactElement) = Interop.mkDetailPanelAttr "openIcon" value

    /// Tooltip for button
    static member inline tooltip (value: string) = Interop.mkDetailPanelAttr "tooltip" value

    /// Render result of detail panel according rowData
    static member inline render<'T> (handler: 'T -> ReactElement) = Interop.mkDetailPanelAttr "render" handler
    /// Render result of detail panel according rowData
    static member inline render<'T> (handler: 'T -> string) = Interop.mkDetailPanelAttr "render" handler

[<Erase>]
type detailPanels =
    static member inline detailPanel (props: IDetailPanelProperty list) = unbox (createObj !!props) : IDetailPanelsProperty
