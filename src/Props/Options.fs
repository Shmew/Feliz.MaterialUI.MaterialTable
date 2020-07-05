namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open System

[<Erase>]
type fixedColumns =
    /// Specify the number of left-most columns to fix in place
    static member inline left (value: int) = Interop.mkFixedColumnAttr "left" value
    /// Specify the number of right-most columns to fix in place
    static member inline right (value: int) = Interop.mkFixedColumnAttr "right" value

[<Erase>]
type options =
    /// Actions cell style
    static member inline actionsCellStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "actionsCellStyle" (createObj !!props)

    /// Order of actions column
    static member inline actionsColumnIndex (value: int) = Interop.mkOptionsAttr "actionsColumnIndex" value

    /// Flag for columns button that controls which column could be rendered
    static member inline columnsButton (value: bool) = Interop.mkOptionsAttr "columnsButton" value

    /// cspNonce for react-beautiful-dnd context
    static member inline cspNonce (value: string) = Interop.mkOptionsAttr "cspNonce" value

    /// Debounce interval for search and filter
    static member inline debounceInterval (value: int) = Interop.mkOptionsAttr "debounceInterval" value
    /// Debounce interval for search and filter
    static member inline debounceInterval (value: float) = Interop.mkOptionsAttr "debounceInterval" value

    /// Flag for expanded items
    static member inline defaultExpanded (value: bool) = Interop.mkOptionsAttr "defaultExpanded" value
    /// Handler to set flag for expanded items
    static member inline defaultExpanded<'T> (handler: 'T -> bool) = Interop.mkOptionsAttr "defaultExpanded" handler

    /// Detail panel column style
    static member inline detailPanelColumnStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "detailPanelColumnStyle" (createObj !!props)

    /// Flag for double scroll bar for long tables
    static member inline doubleHorizontalScroll (value: bool) = Interop.mkOptionsAttr "doubleHorizontalScroll" value

    /// Flag for drag and drop headers
    static member inline draggable (value: bool) = Interop.mkOptionsAttr "draggable" value

    /// Edit cell style
    static member inline editCellStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "editCellStyle" (createObj !!props)

    /// Flag for rendering rows to complete page size
    static member inline emptyRowsWhenPaging (value: bool) = Interop.mkOptionsAttr "emptyRowsWhenPaging" value

    /// Flag for export all data instead of rendered data
    static member inline exportAllData (value: bool) = Interop.mkOptionsAttr "exportAllData" value

    /// Flag for export button that render export buttons
    static member inline exportButton (value: bool) = Interop.mkOptionsAttr "exportButton" value

    /// Delimiter to use in exported CSV file
    static member inline exportDelimiter (value: string) = Interop.mkOptionsAttr "exportDelimiter" value

    /// Exported file name
    static member inline exportFileName (value: string) = Interop.mkOptionsAttr "exportFileName" value

    /// Function to create a custom CSV file
    static member inline exportCsv<'Column,'RenderData> (handler: 'Column list -> 'RenderData list -> unit) = 
        fun (cols: ResizeArray<'Column>) (renderData: ResizeArray<'RenderData>) ->
            handler (List.ofSeq cols) (List.ofSeq renderData)
        |> fun handler -> Func<_,_,_> handler
        |> Interop.mkOptionsAttr "exportCsv"

    /// Function to create a custom PDF file
    static member inline exportPdf<'Column,'RenderData> (handler: 'Column list -> 'RenderData list -> unit) = 
        fun (cols: ResizeArray<'Column>) (renderData: ResizeArray<'RenderData>) ->
            handler (List.ofSeq cols) (List.ofSeq renderData)
        |> fun handler -> Func<_,_,_> handler
        |> Interop.mkOptionsAttr "exportPdf"

    /// Flag for filtering row
    static member inline filtering (value: bool) = Interop.mkOptionsAttr "filtering" value

    /// Filter cell style for all filter cells
    static member inline filterCellStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "filterCellStyle" (createObj !!props)

    /// Filter cell style for all filter cells
    static member inline filterRowStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "filterRowStyle" (createObj !!props)

    /// Specify columns that are fixed in place regardless of table width via left and right column counts
    static member inline fixedColumns (props: IFixedColumnProperty list) = Interop.mkOptionsAttr "fixedColumns" (createObj !!props)

    /// Flag for groupbar visibility
    static member inline grouping (value: bool) = Interop.mkOptionsAttr "grouping" value

    /// Flag for header visibility
    static member inline header (value: bool) = Interop.mkOptionsAttr "header" value

    /// Header cell style for all headers
    static member inline headerStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "headerStyle" (createObj !!props)

    /// Flag for hiding filter icons
    static member inline hideFilterIcons (value: bool) = Interop.mkOptionsAttr "hideFilterIcons" value

    /// Max body height in px
    static member inline maxBodyHeight (value: int) = Interop.mkOptionsAttr "maxBodyHeight" value
    /// Max body height in px
    static member inline maxBodyHeight (value: float) = Interop.mkOptionsAttr "maxBodyHeight" value
    /// Max body height
    static member inline maxBodyHeight (value: Feliz.Styles.ICssUnit) = Interop.mkOptionsAttr "maxBodyHeight" value

    /// Min body height in px
    static member inline minBodyHeight (value: int) = Interop.mkOptionsAttr "minBodyHeight" value
    /// Min body height in px
    static member inline minBodyHeight (value: float) = Interop.mkOptionsAttr "minBodyHeight" value
    /// Min body height
    static member inline minBodyHeight (value: Feliz.Styles.ICssUnit) = Interop.mkOptionsAttr "minBodyHeight" value

    /// Initial Page Number
    static member inline initialPage (value: int) = Interop.mkOptionsAttr "initialPage" value

    /// Flag for paging feature
    static member inline paging (value: bool) = Interop.mkOptionsAttr "paging" value

    /// Number of rows that would be rendered on every page
    static member inline pageSize (value: int) = Interop.mkOptionsAttr "pageSize" value

    /// Page size options that could be selected by user
    static member inline pageSizeOptions (value: int list) = Interop.mkOptionsAttr "pageSizeOptions" (value |> ResizeArray)
    /// Page size options that could be selected by user
    static member inline pageSizeOptions (value: {| value: int; label: string |} list) = 
        Interop.mkOptionsAttr "pageSizeOptions" (value |> List.map toPlainJsObj |> ResizeArray)

    /// Css style to be applied to table rows
    static member inline rowStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "rowStyle" (createObj !!props)
    /// Css style to be applied to table rows
    ///
    /// Takes a handler of row data, index, and level respectively
    static member inline rowStyle<'T> (handler: 'T -> int -> int -> IStyleAttribute list) =
        fun rowData index level -> 
            handler rowData index level 
            |> (fun styles -> createObj !!styles)
        |> fun res -> Func<_,_,_,_> res
        |> Interop.mkOptionsAttr "rowStyle" 

    /// Flag for showing message if there is no data in table
    static member inline showEmptyDataSourceMessage (value: bool) = Interop.mkOptionsAttr "showEmptyDataSourceMessage" value

    /// Flag for search feature
    static member inline search (value: bool) = Interop.mkOptionsAttr "search" value

    /// Initialize search field focused
    static member inline searchAutoFocus (value: bool) = Interop.mkOptionsAttr "searchAutoFocus" value

    /// Search field css style
    static member inline searchFieldStyle (props: #IStyleAttribute list) = Interop.mkOptionsAttr "searchFieldStyle" (createObj !!props)

    /// Set the search text
    static member inline searchText (value: string) = Interop.mkOptionsAttr "searchText" value

    /// Flag for selection feature
    static member inline selection (value: bool) = Interop.mkOptionsAttr "selection" value

    /// Selection checkbox props
    static member inline selectionProps (props: IReactProperty list) = Interop.mkOptionsAttr "selectionProps" (createObj !!props)
    /// Selection checkbox props
    static member inline selectionProps<'T> (handler: 'T -> IReactProperty list) = 
        Interop.mkOptionsAttr "selectionProps" (Func<_,_> (handler >> (fun props -> createObj !!props))) 

    /// Flag for showing first and last page buttons on pagination component
    static member inline showFirstLastPageButtons (value: bool) = Interop.mkOptionsAttr "showFirstLastPageButtons" value

    /// Flag for showing select all checkbox
    static member inline showSelectAllCheckbox (value: bool) = Interop.mkOptionsAttr "showSelectAllCheckbox" value

    /// Flag for showing selected rows text on toolbar
    static member inline showTextRowsSelected (value: bool) = Interop.mkOptionsAttr "showTextRowsSelected" value

    /// Flag for title
    static member inline showTitle (value: bool) = Interop.mkOptionsAttr "showTitle" value

    /// Flag to activate or disable sorting feature of table
    static member inline sorting (value: bool) = Interop.mkOptionsAttr "sorting" value

    /// Could be used to pass ref over withStyles
    static member inline tableRef (ref': Fable.React.IRefValue<'T>) = Interop.mkOptionsAttr "tableRef" ref'

    /// Flag for third sort click
    static member inline thirdSortClick (value: bool) = Interop.mkOptionsAttr "thirdSortClick" value

    /// Flag for toolbar
    static member inline toolbar (value: bool) = Interop.mkOptionsAttr "toolbar" value

module options =
    /// Position of add row
    [<Erase>]
    type addRowPosition =
        static member inline first = Interop.mkOptionsAttr "addRowPosition" "first"
        static member inline last = Interop.mkOptionsAttr "addRowPosition" "last"

    /// Detail panel column alignment.
    [<Erase>]
    type detailPanelColumnAlignment =
        static member inline left = Interop.mkOptionsAttr "detailPanelColumnAlignment" "left"
        static member inline right = Interop.mkOptionsAttr "detailPanelColumnAlignment" "right"

    /// Detail panel visibility type.
    [<Erase>]
    type detailPanelType =
        static member inline multiple = Interop.mkOptionsAttr "detailPanelType" "multiple"
        static member inline single = Interop.mkOptionsAttr "detailPanelType" "single"

    /// Detail panel visibility type.
    [<Erase>]
    type loadingType =
        static member inline linear = Interop.mkOptionsAttr "loadingType" "linear"
        static member inline overlay = Interop.mkOptionsAttr "loadingType" "overlay"

    /// Set overflow behavior.
    [<Erase>]
    type overflowY =
        static member inline auto = Interop.mkOptionsAttr "overflowY" "auto"
        static member inline hidden = Interop.mkOptionsAttr "overflowY" "hidden"
        static member inline inherit' = Interop.mkOptionsAttr "overflowY" "inherit"
        static member inline initial = Interop.mkOptionsAttr "overflowY" "initial"
        static member inline scroll = Interop.mkOptionsAttr "overflowY" "scroll"
        static member inline visible = Interop.mkOptionsAttr "overflowY" "visible"

    /// Detail panel visibility type.
    [<Erase>]
    type padding =
        static member inline default' = Interop.mkOptionsAttr "padding" "default"
        static member inline dense = Interop.mkOptionsAttr "padding" "dense"

    [<Erase>]
    type paginationType =
        static member inline normal = Interop.mkOptionsAttr "paginationType" "normal"
        static member inline stepped = Interop.mkOptionsAttr "paginationType" "stepped"

    [<Erase>]
    type searchFieldAlignment =
        static member inline left = Interop.mkOptionsAttr "searchFieldAlignment" "left"
        static member inline right = Interop.mkOptionsAttr "searchFieldAlignment" "right"

    [<Erase>]
    type searchFieldVariant =
        static member inline filled = Interop.mkOptionsAttr "searchFieldVariant" "filled"
        static member inline outlined = Interop.mkOptionsAttr "searchFieldVariant" "outlined"
        static member inline standard = Interop.mkOptionsAttr "searchFieldVariant" "standard"

    /// Specify if columns should use a width algorithm or be fixed in place
    [<Erase>]
    type tableLayout =
        /// Make the table layout use a width-algorithm
        static member inline auto = Interop.mkOptionsAttr "tableLayout" "auto"
        /// Make the table layout use a fixed width
        static member inline fixed' = Interop.mkOptionsAttr "tableLayout" "fixed"

    /// Flag for pagination type
    [<Erase>]
    type toolbarButtonAlignment =
        static member inline left = Interop.mkOptionsAttr "toolbarButtonAlignment" "left"
        static member inline right = Interop.mkOptionsAttr "toolbarButtonAlignment" "right"
