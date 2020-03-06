namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type localization =
    /// Key value pair for localize body component
    static member inline body (props: ILocalizationBodyProperty list) = Interop.mkLocalizationAttr "body" (createObj !!props)
    /// Key value pair for localize grouping component
    static member inline grouping (props: ILocalizationGroupingProperty list) = Interop.mkLocalizationAttr "grouping" (createObj !!props)
    /// Key value pair for localize header component
    static member inline header (props: ILocalizationHeaderProperty list) = Interop.mkLocalizationAttr "header" (createObj !!props)
    /// Key value pair for localize pagination component
    static member inline pagination (props: ILocalizationPaginationProperty list) = Interop.mkLocalizationAttr "pagination" (createObj !!props)
    /// Key value pair for localize toolbar component
    static member inline toolbar (props: ILocalizationToolbarProperty list) = Interop.mkLocalizationAttr "pagination" (createObj !!props)

module localization =
    [<Erase>]
    type body =
        static member inline editRow (props: ILocalizationEditRowProperty list) = Interop.mkLocalizationBodyAttr "emptyDataSourceMessage" (createObj !!props)
        static member inline emptyDataSourceMessage (value: string) = Interop.mkLocalizationBodyAttr "emptyDataSourceMessage" value
        static member inline filterRow (props: ILocalizationFilterRowProperty list) = Interop.mkLocalizationBodyAttr "emptyDataSourceMessage" (createObj !!props)
        static member inline addTooltip (value: string) = Interop.mkLocalizationBodyAttr "addTooltip" value
        static member inline deleteTooltip (value: string) = Interop.mkLocalizationBodyAttr "deleteTooltip" value
        static member inline editTooltip (value: string) = Interop.mkLocalizationBodyAttr "editTooltip" value
    
    module body =
        [<Erase>]
        type editRow =
            static member inline deleteText (value: string) = Interop.mkLocalizationEditRowAttr "deleteText" value
            static member inline cancelTooltip (value: string) = Interop.mkLocalizationEditRowAttr "cancelTooltip" value
            static member inline saveTooltip (value: string) = Interop.mkLocalizationEditRowAttr "saveTooltip" value

        [<Erase>]
        type filterRow =
            static member inline filterTooltip (value: string) = Interop.mkLocalizationFilterRowAttr "filterTooltip" value
    
    [<Erase>]
    type grouping =
        static member inline placeholder (value: string) = Interop.mkLocalizationGroupingAttr "placeholder" value
    
    [<Erase>]
    type header =
        static member inline actions (value: string) = Interop.mkLocalizationHeaderAttr "actions" value
    
    [<Erase>]
    type pagination =
        static member inline labelDisplayedRows (value: string) = Interop.mkLocalizationPaginationAttr "labelDisplayedRows" value
        static member inline labelRowsSelect (value: string) = Interop.mkLocalizationPaginationAttr "labelRowsSelect" value
        static member inline labelRowsPerPage (value: string) = Interop.mkLocalizationPaginationAttr "labelRowsPerPage" value
        static member inline firstAriaLabel (value: string) = Interop.mkLocalizationPaginationAttr "firstAriaLabel" value
        static member inline firstTooltip (value: string) = Interop.mkLocalizationPaginationAttr "firstTooltip" value
        static member inline previousAriaLabel (value: string) = Interop.mkLocalizationPaginationAttr "previousAriaLabel" value
        static member inline previousTooltip (value: string) = Interop.mkLocalizationPaginationAttr "previousTooltip" value
        static member inline nextAriaLabel (value: string) = Interop.mkLocalizationPaginationAttr "nextAriaLabel" value
        static member inline nextTooltip (value: string) = Interop.mkLocalizationPaginationAttr "nextTooltip" value
        static member inline lastAriaLabel (value: string) = Interop.mkLocalizationPaginationAttr "lastAriaLabel" value
        static member inline lastTooltip (value: string) = Interop.mkLocalizationPaginationAttr "lastTooltip" value
    
    [<Erase>]
    type toolbar =
        static member inline addRemoveColumns (value: string) = Interop.mkLocalizationToolbarAttr "addRemoveColumns" value
        static member inline nRowsSelected (value: string) = Interop.mkLocalizationToolbarAttr "nRowsSelected" value
        static member inline showColumnsTitle (value: string) = Interop.mkLocalizationToolbarAttr "showColumnsTitle" value
        static member inline showColumnsAriaLabel (value: string) = Interop.mkLocalizationToolbarAttr "showColumnsAriaLabel" value
        static member inline exportTitle (value: string) = Interop.mkLocalizationToolbarAttr "exportTitle" value
        static member inline exportAriaLabel (value: string) = Interop.mkLocalizationToolbarAttr "exportAriaLabel" value
        static member inline exportName (value: string) = Interop.mkLocalizationToolbarAttr "exportName" value
        static member inline searchTooltip (value: string) = Interop.mkLocalizationToolbarAttr "searchTooltip" value
        static member inline searchPlaceholder (value: string) = Interop.mkLocalizationToolbarAttr "searchPlaceholder" value
