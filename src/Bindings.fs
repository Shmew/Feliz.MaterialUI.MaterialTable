namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JsInterop

module Bindings =
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
        abstract minimumFractionDigits: int option with get, set
        abstract maximumFractionDigits: int option with get, set

    [<AllowNullLiteral>]
    type TableData =
        abstract filterValue: string option with get, set
        abstract groupOrder: int option with get, set
        abstract groupSort: string with get, set
        abstract id: int with get, set

    [<AllowNullLiteral>] 
    type EditCellColumnDef =
        abstract field: string with get, set
        abstract title: string with get, set
        abstract tableData: TableData with get, set

    [<AllowNullLiteral>]
    type Column<'RowData> =
        abstract cellStyle: U2<PropsObject, (ResizeArray<'RowData> -> 'RowData -> PropsObject)> option with get, set
        abstract currencySetting: CurrencySetting option with get, set
        abstract customFilterAndSearch: (string -> 'RowData -> Column<'RowData> -> bool) option with get, set
        abstract customSort: ('RowData -> 'RowData -> ColumnType -> int) option with get, set
        abstract defaultFilter: string option with get, set
        abstract defaultGroupOrder: int option with get, set
        abstract defaultGroupSort: string option with get, set
        abstract defaultSort: string option with get, set
        abstract disableClick: bool option with get, set
        abstract editComponent: ReactElement option with get, set
        abstract emptyValue: U3<string, ReactElement, ('RowData -> U2<ReactElement, string>)> option with get, set
        abstract export: bool option with get, set
        abstract field: string option with get, set
        abstract filtering: bool option with get, set
        abstract filterPlaceholder: string option with get, set
        abstract filterCellStyle: PropsObject option with get, set
        abstract grouping: bool option with get, set
        abstract headerStyle: PropsObject option with get, set
        abstract hidden: bool option with get, set
        abstract hideFilterIcon: bool option with get, set
        abstract initialEditValue: 'RowData option with get, set
        abstract lookup: obj option with get, set
        abstract editable: U5<string, string, string, string, (Column<'RowData> -> 'RowData -> bool)> option with get, set
        abstract removable: bool option with get, set
        abstract render: ('RowData -> string -> ReactElement) option with get, set
        abstract searchable: bool option with get, set
        abstract sorting: bool option with get, set
        abstract title: U2<string, ReactElement> option with get, set
        abstract ``type``: ColumnFieldType option with get, set

    [<AllowNullLiteral>] 
    type Filter<'RowData> =
        abstract column: Column<'RowData> with get, set
        abstract operator: string with get, set
        abstract value: 'RowData option with get, set

    [<AllowNullLiteral>] 
    type Query<'RowData> =
        abstract filters: ResizeArray<Filter<'RowData>> with get, set
        abstract page: int with get, set
        abstract pageSize: int with get, set
        abstract search: string with get, set
        abstract orderBy: Column<'RowData> with get, set
        abstract orderDirection: OrderDirection with get, set
    
    [<AllowNullLiteral>]
    type QueryResultNative<'RowData> =
        abstract data: ResizeArray<'RowData> with get, set
        abstract page: int with get, set
        abstract totalCount: int with get, set

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
        abstract classes: PropsObject option with get, set
        abstract color: MuiIconColors with get, set
        abstract ``component``: Fable.React.ReactElementType with get, set
        abstract fontSize: MuiIconFontSize with get, set

    [<AllowNullLiteral>] 
     type Action<'RowData> =
        abstract disabled: bool option with get, set
        abstract icon: U2<string, (unit -> ReactElement)> with get, set
        abstract isFreeAction: bool option with get, set
        abstract position: string option with get, set
        abstract tooltip: string option with get, set
        abstract onClick: (Browser.Types.MouseEvent -> U2<'RowData, ResizeArray<'RowData>> -> unit) with get, set
        abstract iconProps: IconProps option with get, set
        abstract hidden: bool option with get, set

    module Components =
        [<AllowNullLiteral>]
        type RefComponent =
            abstract current: ReactElement option with get, set

        [<AllowNullLiteral>]
        type StyledComponent =
            abstract classes: PropsObject option with get, set
            abstract innerRef: RefComponent option with get, set

        [<AllowNullLiteral>]
        type ActionProps<'RowData> =
            abstract action: U2<Action<'RowData>, U2<'RowData, ResizeArray<'RowData>> -> Action<'RowData>> with get, set
            abstract data: U2<'RowData, ResizeArray<'RowData>> option with get, set
            abstract disabled: bool option with get, set
            abstract size: string option with get, set

    type [<AllowNullLiteral>] Components =
        abstract Action: ReactElement option with get, set
        abstract Actions: ReactElement option with get, set
        abstract Body: ReactElement option with get, set
        abstract Cell: ReactElement option with get, set
        abstract Container: ReactElement option with get, set
        abstract EditField: ReactElement option with get, set
        abstract EditRow: ReactElement option with get, set
        abstract FilterRow: ReactElement option with get, set
        abstract Groupbar: ReactElement option with get, set
        abstract GroupRow: ReactElement option with get, set
        abstract Header: ReactElement option with get, set
        abstract Pagination: ReactElement option with get, set
        abstract OverlayLoading: ReactElement option with get, set
        abstract Row: ReactElement option with get, set
        abstract Toolbar: ReactElement option with get, set

    type [<AllowNullLiteral>] DetailPanel<'RowData> =
        abstract disabled: bool option with get, set
        abstract icon: U2<string, ReactElement> option with get, set
        abstract openIcon: U2<string, ReactElement> option with get, set
        abstract tooltip: string option with get, set
        abstract render: ('RowData -> U2<string, ReactElement>) with get, set

    type [<AllowNullLiteral>] Editable<'RowData> =
        abstract isEditable: ('RowData -> bool) option with get, set
        abstract isDeletable: ('RowData -> bool) option with get, set
        abstract onRowAdd: ('RowData -> JS.Promise<unit>) option with get, set
        abstract onRowUpdate: ('RowData -> 'RowData -> JS.Promise<unit>) option with get, set
        abstract onRowDelete: ('RowData -> JS.Promise<unit>) option with get, set

    type [<AllowNullLiteral>] Icons =
        abstract Add: ReactElement option with get, set
        abstract Check: ReactElement option with get, set
        abstract Clear: ReactElement option with get, set
        abstract Delete: ReactElement option with get, set
        abstract DetailPanel: ReactElement option with get, set
        abstract Edit: ReactElement option with get, set
        abstract Export: ReactElement option with get, set
        abstract Filter: ReactElement option with get, set
        abstract FirstPage: ReactElement option with get, set
        abstract SortArrow: ReactElement option with get, set
        abstract LastPage: ReactElement option with get, set
        abstract NextPage: ReactElement option with get, set
        abstract PreviousPage: ReactElement option with get, set
        abstract ResetSearch: ReactElement option with get, set
        abstract Search: ReactElement option with get, set
        abstract ThirdStateCheck: ReactElement option with get, set
        abstract ViewColumn: ReactElement option with get, set

    [<StringEnum; RequireQualifiedAccess>]
    type OverflowY =
        | Visible
        | Hidden
        | Scroll
        | Auto
        | Initial
        | Inherit

    type [<AllowNullLiteral>] Options =
        abstract actionsCellStyle: PropsObject option with get, set
        abstract actionsColumnIndex: int option with get, set
        abstract addRowPosition: string option with get, set
        abstract columnsButton: bool option with get, set
        abstract defaultExpanded: U2<bool, ('RowData -> bool)> option with get, set
        abstract debounceInterval: int option with get, set
        abstract detailPanelType: string option with get, set
        abstract doubleHorizontalScroll: bool option with get, set
        abstract draggable: bool option with get, set
        abstract emptyRowsWhenPaging: bool option with get, set
        abstract exportAllData: bool option with get, set
        abstract exportButton: bool option with get, set
        abstract exportDelimiter: string option with get, set
        abstract exportFileName: string option with get, set
        abstract exportCsv: (ResizeArray<'Column> -> ResizeArray<'RenderData> -> unit) option with get, set
        abstract filtering: bool option with get, set
        abstract filterCellStyle: PropsObject option with get, set
        abstract groupRowSeparator: string option with get, set
        abstract header: bool option with get, set
        abstract headerStyle: PropsObject option with get, set
        abstract hideFilterIcons: bool option with get, set
        abstract initialPage: int option with get, set
        abstract loadingType: string option with get, set
        abstract maxBodyHeight: U2<int, string> option with get, set
        abstract minBodyHeight: U2<int, string> option with get, set
        abstract padding: string option with get, set
        abstract paging: bool option with get, set
        abstract grouping: bool option with get, set
        abstract pageSize: int option with get, set
        abstract pageSizeOptions: ResizeArray<int> option with get, set
        abstract paginationType: string option with get, set
        abstract rowStyle: U2<PropsObject, (PropsObject option -> int -> int -> PropsObject)> option with get, set
        abstract showEmptyDataSourceMessage: bool option with get, set
        abstract showFirstLastPageButtons: bool option with get, set
        abstract showSelectAllCheckbox: bool option with get, set
        abstract showTitle: bool option with get, set
        abstract showTextRowsSelected: bool option with get, set
        abstract search: bool option with get, set
        abstract searchFieldAlignment: string option with get, set
        abstract searchFieldStyle: PropsObject option with get, set
        abstract searchText: string option with get, set
        abstract selection: bool option with get, set
        abstract selectionProps: U2<PropsObject option, (PropsObject option -> PropsObject option)> option with get, set
        abstract sorting: bool option with get, set
        abstract thirdSortClick: bool option with get, set
        abstract toolbar: bool option with get, set
        abstract toolbarButtonAlignment: string option with get, set
        abstract detailPanelColumnAlignment: string option with get, set
        abstract overflowY: OverflowY option with get, set

    type [<AllowNullLiteral>] filterRow =
        abstract filterTooltip: string option with get, set

    type [<AllowNullLiteral>] editRow =
        abstract saveTooltip: string option with get, set
        abstract cancelTooltip: string option with get, set
        abstract deleteText: string option with get, set

    type [<AllowNullLiteral>] body =
        abstract dateTimePickerLocalization: PropsObject option with get, set
        abstract emptyDataSourceMessage: string option with get, set
        abstract filterRow: filterRow option with get, set
        abstract editRow: editRow option with get, set
        abstract addTooltip: string option with get, set
        abstract deleteTooltip: string option with get, set
        abstract editTooltip: string option with get, set

    type [<AllowNullLiteral>] header =
        abstract actions: string option with get, set

    type [<AllowNullLiteral>] grouping =
        abstract groupedBy: string option with get, set
        abstract placeholder: string option with get, set

    type [<AllowNullLiteral>] pagination =
        abstract firstTooltip: string option with get, set
        abstract firstAriaLabel: string option with get, set
        abstract previousTooltip: string option with get, set
        abstract previousAriaLabel: string option with get, set
        abstract nextTooltip: string option with get, set
        abstract nextAriaLabel: string option with get, set
        abstract labelDisplayedRows: string option with get, set
        abstract labelRowsPerPage: string option with get, set
        abstract lastTooltip: string option with get, set
        abstract lastAriaLabel: string option with get, set
        abstract labelRowsSelect: string option with get, set

    type [<AllowNullLiteral>] toolbar =
        abstract addRemoveColumns: string option with get, set
        abstract nRowsSelected: string option with get, set
        abstract showColumnsTitle: string option with get, set
        abstract showColumnsAriaLabel: string option with get, set
        abstract exportTitle: string option with get, set
        abstract exportAriaLabel: string option with get, set
        abstract exportName: string option with get, set
        abstract searchTooltip: string option with get, set
        abstract searchPlaceholder: string option with get, set

    type [<AllowNullLiteral>] Localization =
        abstract body: body option with get, set
        abstract header: header option with get, set
        abstract grouping: grouping option with get, set
        abstract pagination: pagination option with get, set
        abstract toolbar: toolbar option with get, set

    type [<AllowNullLiteral>] MaterialTableProps<'RowData> =
        abstract actions: ResizeArray<U2<Action<'RowData>, ('RowData -> Action<'RowData>)>> option with get, set
        abstract columns: ResizeArray<Column<'RowData>> with get, set
        abstract components: Components option with get, set
        abstract data: U2<ResizeArray<'RowData>, (Query<'RowData> -> JS.Promise<QueryResultNative<'RowData>>)> with get, set
        abstract detailPanel: U2<('RowData -> ReactElement), ResizeArray<U2<DetailPanel<'RowData>, ('RowData -> DetailPanel<'RowData>)>>> option with get, set
        abstract editable: Editable<'RowData> option with get, set
        abstract icons: Icons option with get, set
        abstract isLoading: bool option with get, set
        abstract title: U2<string, ReactElement> option with get, set
        abstract options: Options option with get, set
        abstract parentChildData: ('RowData -> ResizeArray<'RowData> -> 'RowData option) option with get, set
        abstract localization: Localization option with get, set
        abstract onChangeRowsPerPage: (int -> unit) option with get, set
        abstract onChangePage: (int -> unit) option with get, set
        abstract onChangeColumnHidden: (Column<'RowData> -> bool -> unit) option with get, set
        abstract onColumnDragged: (int -> int -> unit) option with get, set
        abstract onOrderChange: (int -> string -> unit) option with get, set
        abstract onGroupRemoved: (Column<'RowData> -> bool -> unit) option with get, set
        abstract onRowClick: (Browser.Types.MouseEvent -> 'RowData -> (int -> unit) -> unit) option with get, set
        abstract onRowSelected: ('RowData -> unit) option with get, set
        abstract onSearchChange: (string -> unit) option with get, set
        /// An event fired when the table has finished filtering data
        abstract onFilterChange: (ResizeArray<Filter<'RowData>> -> unit) option with get, set
        abstract onSelectionChange: (ResizeArray<'RowData> -> 'RowData -> unit) option with get, set
        abstract onTreeExpandChange: (ResizeArray<'RowData> -> bool -> unit) option with get, set
        abstract onQueryChange: (Query<'RowData> -> unit) option with get, set
        abstract style: PropsObject option with get, set
        abstract tableRef: Fable.React.IRefValue<MaterialTableProps<'RowData>> option with get, set
        abstract page: int option with get, set
        abstract totalCount: int option with get, set

type QueryResult<'RowData> =
    { data: 'RowData seq
      page: int
      totalCount: int }
    member this.Native =
        jsOptions<Bindings.QueryResultNative<'RowData>> (fun qr ->
            qr.data <- this.data |> ResizeArray
            qr.page <- this.page
            qr.totalCount <- this.totalCount)

module QueryResult =
    let mapPromiseToNative (prom: JS.Promise<QueryResult<'RowData>>) =
        prom
        |> Promise.map (fun p -> p.Native)
