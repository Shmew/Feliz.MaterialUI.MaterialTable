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
    type ColumnEditable =
        | Always
        | Never
        | OnAdd
        | OnUpdate

    [<StringEnum>]
    type ColumnFieldType =
        | Boolean
        | Currency
        | Date
        | DateTime
        | Numeric
        | String
        | Time

    [<StringEnum>]
    type ColumnType =
        | Group
        | Row

    [<AllowNullLiteral>] 
    type CurrencySetting =
        abstract locale: string option with get, set
        abstract currencyCode: string option with get, set
        abstract minimumFractionDigits: int option with get, set
        abstract maximumFractionDigits: int option with get, set

    [<AllowNullLiteral>]
    type Column<'RowData> =
        abstract cellStyle: U2<PropsObject, (ResizeArray<'RowData> -> 'RowData -> PropsObject)> option with get, set
        abstract currencySetting: CurrencySetting option with get, set
        abstract customFilterAndSearch: (string -> 'RowData -> Column<'RowData> -> bool) option with get, set
        abstract customSort: ('RowData -> 'RowData -> ColumnType -> int) option with get, set
        abstract defaultFilter: string option with get, set
        abstract defaultGroupOrder: int option with get, set
        abstract defaultGroupSort: OrderDirection option with get, set
        abstract defaultSort: OrderDirection option with get, set
        abstract disableClick: bool option with get, set
        abstract editable: U2<ColumnEditable, (Column<'RowData> -> 'RowData -> bool)> option with get, set
        abstract editComponent: ReactElement option with get, set
        abstract emptyValue: U3<string, ReactElement, ('RowData -> U2<ReactElement, string>)> option with get, set
        abstract export: bool option with get, set
        abstract field: string option with get, set
        abstract filtering: bool option with get, set
        abstract filterCellStyle: PropsObject option with get, set
        abstract filterComponent: U2<ReactElement,Column<'RowData> -> (string -> 'Value -> unit)> option with get, set
        abstract filterPlaceholder: string option with get, set
        abstract grouping: bool option with get, set
        abstract headerStyle: PropsObject option with get, set
        abstract hidden: bool option with get, set
        abstract hideFilterIcon: bool option with get, set
        abstract initialEditValue: 'RowData option with get, set
        abstract lookup: ResizeArray<'K * 'V> option with get, set
        abstract readOnly: bool option with get, set
        abstract removable: bool option with get, set
        abstract render: ('RowData -> ColumnType -> ReactElement) option with get, set
        abstract searchable: bool option with get, set
        abstract sorting: bool option with get, set
        abstract title: U2<string, ReactElement> option with get, set
        abstract ``type``: ColumnFieldType option with get, set
        abstract width: string option with get, set

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
