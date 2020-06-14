namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open System

[<Erase>]
type column =
    /// Cell cellStyle
    static member inline cellStyle (props: #IStyleAttribute list) = Interop.mkColumnAttr "cellStyle" (createObj !!props)
    /// Cell cellStyle
    static member inline cellStyle<'T> (handler: 'T list -> 'T -> IStyleAttribute list) =
        fun (allRowData: ResizeArray<'T>) rowData ->
            handler (List.ofSeq allRowData) rowData
            |> fun res -> (createObj !!res)
        |> fun handler -> Func<_,_,_> handler
        |> Interop.mkColumnAttr "cellStyle"

    /// This field can be used when column type is currency
    static member inline currencySetting (props: ICurrencySettingProperty list) = 
        Interop.mkColumnAttr "currencySetting" (createObj !!props)

    /// This field can be used for overriding filter and search algorithm
    static member inline customFilterAndSearch<'T> (handler: string -> 'T -> Bindings.Column<'T> -> bool) = 
        Interop.mkColumnAttr "customFilterAndSearch" (Func<_,_,_,_> handler)

    /// This field can be used for overriding sort algorithm
    static member inline customSort<'T> (handler: 'T -> 'T -> Bindings.ColumnType -> int) = 
        Interop.mkColumnAttr "customSort" (Func<_,_,_,_> handler)

    /// Default Filter value for filtering column
    static member inline defaultFilter (value: obj) = Interop.mkColumnAttr "defaultFilter" value

    /// Default grouped column by order
    static member inline defaultGroupOrder (value: int) = Interop.mkColumnAttr "defaultGroupOrder" value

    /// Sets the date locale
    static member inline dateSetting (locale: string) = Interop.mkColumnAttr "dateSetting" (createObj !![ "locale" ==> locale ])

    /// Disable the 'onRowClick' event for this cell
    static member inline disableClick (value: bool) = Interop.mkColumnAttr "disableClick" value

    /// Editable custom component
    static member inline editable<'T> (handler: Bindings.Column<'T> -> 'T -> bool) =
        Interop.mkColumnAttr "editable" (Func<_,_,_> handler)

    /// Editable custom component
    static member inline editComponent (value: ReactElement) = Interop.mkColumnAttr "editComponent" value

    /// When data is empty or undefined, string value, ReactElement or function result can be set as default value
    static member inline emptyValue (value: string) = Interop.mkColumnAttr "emptyValue" value
    /// When data is empty or undefined, string value, ReactElement or function result can be set as default value
    static member inline emptyValue (value: ReactElement) = Interop.mkColumnAttr "emptyValue" value
    /// When data is empty or undefined, string value, ReactElement or function result can be set as default value
    static member inline emptyValue (handler: unit -> ReactElement) = Interop.mkColumnAttr "emptyValue" handler
    /// When data is empty or undefined, string value, ReactElement or function result can be set as default value
    static member inline emptyValue (handler: unit -> string) = Interop.mkColumnAttr "emptyValue" handler

    /// Flag for make column exportable or not
    static member inline export (value: bool) = Interop.mkColumnAttr "export" value

    /// Field name of data row
    static member inline field (value: string) = Interop.mkColumnAttr "field" value
    /// Field name of data row
    static member inline field<'T> (select: 'T -> string) = Interop.mkColumnAttr "field" (select (unbox null)) 

    /// Flag to activate or disable filtering feature of column
    static member inline filtering (value: bool) = Interop.mkColumnAttr "filtering" value

    /// Filter cell style
    static member inline filterCellStyle (props: #IStyleAttribute list) = Interop.mkColumnAttr "filterCellStyle" (createObj !!props)

    /// Filter component
    static member inline filterComponent (value: ReactElement) = Interop.mkColumnAttr "filterComponent" value
    /// Filter component
    ///
    /// Takes a handler of column properties and rowId -> 'Value -> unit
    static member inline filterComponent<'RowData,'Value> (handler: Bindings.Column<'RowData> -> (string -> 'Value -> unit) -> ReactElement) = 
        Interop.mkColumnAttr "filterComponent" (Func<_,_,_> handler)

    /// Filter textbox placeholder
    static member inline filterPlaceholder (value: string) = Interop.mkColumnAttr "filterPlaceholder" value

    /// Flag to activate or disable grouping feature of column
    static member inline grouping (value: bool) = Interop.mkColumnAttr "grouping" value

    /// Header cell style
    static member inline headerStyle (props: #IStyleAttribute list) = Interop.mkColumnAttr "headerStyle" (createObj !!props)

    /// Flag to activate or disable grouping feature of column
    static member inline hidden (value: bool) = Interop.mkColumnAttr "hidden" value

    /// Initial value on add new row
    static member inline initialEditValue (value: obj) = Interop.mkColumnAttr "initialEditValue" value

    /// Key value pair for lookup render data
    static member inline lookup<'K, 'V> (lookups: ('K * 'V) list) = Interop.mkColumnAttr "lookup" (createObj !!lookups)

    /// Flag to make column readonly when editing, the column will still be editable when adding a row
    static member inline readOnly (value: bool) = Interop.mkColumnAttr "readonly" value

    /// Flag for column that could be removed with columnsButton or not
    static member inline removable (value: bool) = Interop.mkColumnAttr "removable" value

    /// Render a custom node for cell. Parameter is rowData and return value must be ReactElement
    static member inline render<'T> (handler: 'T -> Bindings.ColumnType -> ReactElement) = Interop.mkColumnAttr "render" (Func<_,_,_> handler)

    /// If true, includes the column when performing a search
    static member inline searchable (value: bool) = Interop.mkColumnAttr "searchable" value

    /// Flag to activate or disable sorting feature of column
    static member inline sorting (value: bool) = Interop.mkColumnAttr "sorting" value

    /// Header text
    static member inline title (value: string) = Interop.mkColumnAttr "title" value
    /// Header element
    static member inline title (value: ReactElement) = Interop.mkColumnAttr "title" value

    /// Width of the column in px
    static member inline width (value: int) = Interop.mkColumnAttr "width" value
    /// Width of the column in px
    static member inline width (value: float) = Interop.mkColumnAttr "width" value
    /// Width of the column in px
    static member inline width (value: Styles.ICssUnit) = Interop.mkColumnAttr "width" value

module column =
    [<Erase>]
    type currencySetting =
        static member inline currencyCode (value: string) = Interop.mkCurrencySettingAttr "currencyCode" value
        static member inline locale (value: string) = Interop.mkCurrencySettingAttr "locale" value
        static member inline maximumFractionDigits (value: int) = Interop.mkCurrencySettingAttr "maximumFractionDigits" value
        static member inline minimumFractionDigits (value: int) = Interop.mkCurrencySettingAttr "minimumFractionDigits" value

    /// Default grouped sort direction
    [<Erase>]
    type defaultGroupSort =
        static member inline asc = Interop.mkColumnAttr "defaultGroupSort" "asc"
        static member inline desc = Interop.mkColumnAttr "defaultGroupSort" "desc"

    /// Sorting direction: 'asc', 'desc'
    [<Erase>]
    type defaultSort =
        static member inline asc = Interop.mkColumnAttr "defaultSort" "asc"
        static member inline desc = Interop.mkColumnAttr "defaultSort" "desc"

    /// Editable custom component options
    [<Erase>]
    type editable =
        static member inline always = Interop.mkColumnAttr "editable" "always"
        static member inline never = Interop.mkColumnAttr "editable" "never"
        static member inline onAdd = Interop.mkColumnAttr "editable" "onAdd"
        static member inline onUpdate = Interop.mkColumnAttr "editable" "onUpdate"

    /// Data Type
    [<Erase>]
    type type' =
        static member inline boolean = Interop.mkColumnAttr "type" "boolean"
        static member inline currency = Interop.mkColumnAttr "type" "currency"
        static member inline date = Interop.mkColumnAttr "type" "date"
        static member inline datetime = Interop.mkColumnAttr "type" "datetime"
        static member inline numeric = Interop.mkColumnAttr "type" "numeric"
        static member inline time = Interop.mkColumnAttr "type" "time"

[<Erase>]
type columns =
    static member inline column (props: IColumnProperty list) = unbox (createObj !!props) : IColumnsProperty