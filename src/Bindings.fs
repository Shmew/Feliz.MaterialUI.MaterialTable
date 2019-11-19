namespace Feliz.MaterialUI.MaterialTable

module Bindings =
    open Fable.Core
    open Feliz
    open Feliz.MaterialUI
        
    [<StringEnum>]
    type OrderDirection =
        | Asc
        | Desc

    [<StringEnum>]
    type ColumnType =
        | Group
        | Row

    [<StringEnum>]
    type ColumnFieldType =
        | Boolean
        | Currency
        | Date
        | DateTime
        | Numeric
        | String
        | Time

    [<AllowNullLiteral>] 
    type CurrencySetting =
        abstract locale: string option with get, set
        abstract currencyCode: string option with get, set
        abstract minimumFractionDigits: float option with get, set
        abstract maximumFractionDigits: float option with get, set

    [<AllowNullLiteral>]
    type TableData =
        abstract filterValue: obj option with get, set
        abstract groupOrder: obj option with get, set
        abstract groupSort: string with get, set
        abstract id: int with get, set

    [<AllowNullLiteral>] 
    type EditCellColumnDef =
        abstract field: string with get, set
        abstract title: string with get, set
        abstract tableData: TableData with get, set

    [<AllowNullLiteral>]
    type EditComponentProps<'RowData> =
        abstract rowData: 'RowData with get, set
        abstract value: obj option with get, set
        abstract onChange: (obj option -> unit) with get, set
        abstract columnDef: EditCellColumnDef with get, set
        

    [<AllowNullLiteral>]
    type Column<'RowData> =
        abstract cellStyle: U2<obj, (ResizeArray<'RowData> -> 'RowData -> obj)> option with get, set
        abstract currencySetting: CurrencySetting option with get, set
        abstract customFilterAndSearch: (obj option -> 'RowData -> Column<'RowData> -> bool) option with get, set
        abstract customSort: ('RowData -> 'RowData -> ColumnType -> float) option with get, set
        abstract defaultFilter: obj option with get, set
        abstract defaultGroupOrder: float option with get, set
        abstract defaultGroupSort: U2<string, string> option with get, set
        abstract defaultSort: U2<string, string> option with get, set
        abstract disableClick: bool option with get, set
        abstract editComponent: (EditComponentProps<'RowData> -> ReactElement) option with get, set
        abstract emptyValue: U3<string, ReactElement, (obj option -> U2<ReactElement, string>)> option with get, set
        abstract export: bool option with get, set
        /// Returns `keyof` RowData or a string
        abstract field: U2<obj, string> option with get, set
        abstract filtering: bool option with get, set
        abstract filterPlaceholder: string option with get, set
        abstract filterCellStyle: obj option with get, set
        abstract grouping: bool option with get, set
        abstract headerStyle: obj option with get, set
        abstract hidden: bool option with get, set
        abstract hideFilterIcon: bool option with get, set
        abstract initialEditValue: obj option with get, set
        abstract lookup: obj option with get, set
        abstract editable: U5<string, string, string, string, (Column<'RowData> -> 'RowData -> bool)> option with get, set
        abstract removable: bool option with get, set
        abstract render: ('RowData -> U2<string, string> -> obj option) option with get, set
        abstract searchable: bool option with get, set
        abstract sorting: bool option with get, set
        abstract title: U2<string, ReactElement> option with get, set
        abstract ``type``: ColumnFieldType option with get, set

    [<AllowNullLiteral>] 
    type Filter<'RowData> =
        abstract column: Column<'RowData> with get, set
        abstract operator: string with get, set
        abstract value: obj option with get, set

    [<AllowNullLiteral>] 
    type Query<'RowData> =
        abstract filters: ResizeArray<Filter<'RowData>> with get, set
        abstract page: float with get, set
        abstract pageSize: float with get, set
        abstract search: string with get, set
        abstract orderBy: Column<'RowData> with get, set
        abstract orderDirection: OrderDirection with get, set
    
    [<AllowNullLiteral>]
    type QueryResult<'RowData> =
        abstract data: ResizeArray<'RowData> with get, set
        abstract page: float with get, set
        abstract totalCount: float with get, set

    [<StringEnum; RequireQualifiedAccess>]
    type MuiIconColors =
        | Inherit
        | Primary
        | Secondary
        | Action
        | Error
        | Disabled

    [<StringEnum; RequireQualifiedAccess>]
    type MuiIconFontSize =
        | Inherit
        | Default
        | Small
        | Large

    [<AllowNullLiteral>]
    type IconProps =
        abstract children: string with get, set
        abstract classes: IThemeProps with get, set
        abstract color: MuiIconColors with get, set
        abstract ``component``: Fable.React.ReactElementType with get, set
        abstract fontSize: MuiIconFontSize with get, set

    [<AllowNullLiteral>] 
     type Action<'RowData> =
        abstract disabled: bool option with get, set
        abstract icon: U2<string, (unit -> ReactElement)> with get, set
        abstract isFreeAction: bool option with get, set
        abstract position: U4<string, string, string, string> option with get, set
        abstract tooltip: string option with get, set
        abstract onClick: (Browser.Types.MouseEvent -> U2<'RowData, ResizeArray<'RowData>> -> unit) with get, set
        abstract iconProps: IconProps option with get, set
        abstract hidden: bool option with get, set

    module Components =
        [<AllowNullLiteral>]
        type ActionProps<'RowData> =
            abstract action: U2<Action<'RowData>, U2<'RowData, ResizeArray<'RowData>> -> Action<'RowData>> with get, set
            abstract data: U2<'RowData, ResizeArray<'RowData>> option with get, set
            abstract disabled: bool option with get, set
            abstract size: string option with get, set

        [<AllowNullLiteral>]
        type ActionsProps<'RowData> =
            abstract action: ResizeArray<Action<'RowData>> with get, set
            abstract components: obj with get, set
            abstract data: U2<ResizeArray<'RowData>, 'RowData> option with get, set
            abstract disabled: bool option with get, set
            abstract size: string option with get, set
            
        // Finish this