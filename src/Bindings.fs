namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open System.ComponentModel

[<EditorBrowsable(EditorBrowsableState.Never);RequireQualifiedAccess>]
module Lodash =
    open Fable.Core.JsInterop

    let cloneDeep (x: 'T) : 'T = importDefault "lodash/cloneDeep"

[<Erase>]
module Bindings =
    open Feliz
    open Feliz.MaterialUI

    [<StringEnum;RequireQualifiedAccess>]
    type OrderDirection =
        | Asc
        | Desc

    [<StringEnum;RequireQualifiedAccess>]
    type ColumnAlign =
        | Center
        | Inherit
        | Justify
        | Left
        | Right

    [<StringEnum;RequireQualifiedAccess>]
    type ColumnEditable =
        | Always
        | Never
        | OnAdd
        | OnUpdate

    [<StringEnum;RequireQualifiedAccess>]
    type ColumnFieldType =
        | Boolean
        | Currency
        | Date
        | DateTime
        | Numeric
        | String
        | Time

    [<StringEnum;RequireQualifiedAccess>]
    type ColumnType =
        | Group
        | Row

    [<AllowNullLiteral>] 
    type CurrencySetting =
        abstract locale: string option
        abstract currencyCode: string option
        abstract minimumFractionDigits: int option
        abstract maximumFractionDigits: int option

    [<AllowNullLiteral>] 
    type Validation =
        abstract isValid: bool
        abstract helperText: string option

    [<RequireQualifiedAccess>]
    module Validation =
        let inline fromResult (inp: Result<unit,string>) =
            match inp with
            | Ok _ -> {| isValid = true |} |> unbox<Validation>
            | Error str -> {| isValid = false; helperText = str |} |> unbox<Validation>

    [<AllowNullLiteral>]
    type Column<'RowData> =
        abstract align: ColumnAlign option
        abstract cellStyle: U2<PropsObject, (ResizeArray<'RowData> -> 'RowData -> PropsObject)> option
        abstract currencySetting: CurrencySetting option
        abstract customFilterAndSearch: (string -> 'RowData -> Column<'RowData> -> bool) option
        abstract customSort: ('RowData -> 'RowData -> ColumnType -> int) option
        abstract defaultFilter: string option
        abstract defaultGroupOrder: int option
        abstract defaultGroupSort: OrderDirection option
        abstract defaultSort: OrderDirection option
        abstract disableClick: bool option
        abstract editable: U2<ColumnEditable, (Column<'RowData> -> 'RowData -> bool)> option
        abstract editComponent: ReactElement option
        abstract editPlaceholder: string option
        abstract emptyValue: U3<string, ReactElement, ('RowData -> U2<ReactElement, string>)> option
        abstract export: bool option
        abstract field: string option
        abstract filtering: bool option
        abstract filterCellStyle: PropsObject option
        abstract filterComponent: U2<ReactElement,Column<'RowData> -> (string -> 'Value -> unit)> option with get, set
        abstract filterPlaceholder: string option
        abstract grouping: bool option
        abstract groupTitle: U3<string,ReactElement,'RowData -> string>
        abstract headerStyle: PropsObject option
        abstract hidden: bool option
        abstract hideFilterIcon: bool option
        abstract initialEditValue: 'RowData option
        abstract lookup: ResizeArray<'K * 'V> option with get, set
        abstract readOnly: bool option
        abstract removable: bool option
        abstract render: ('RowData -> ColumnType -> ReactElement) option
        abstract searchable: bool option
        abstract sorting: bool option
        abstract title: U2<string, ReactElement> option
        abstract ``type``: ColumnFieldType option
        abstract validate: ('RowData -> U3<Validation,string,bool>) option
        abstract width: string option

    [<AllowNullLiteral>] 
    type Filter<'RowData> =
        abstract column: Column<'RowData>
        abstract operator: string
        abstract value: 'RowData option

    [<StringEnum;RequireQualifiedAccess>]
    type ErrorCause =
        | Add
        | Delete
        | Query
        | Update
    
    [<AllowNullLiteral>] 
    type ErrorState =
        abstract message: string
        abstract errorCause: ErrorCause

    [<AllowNullLiteral>] 
    type Query<'RowData> =
        abstract error: ErrorState option
        abstract filters: ResizeArray<Filter<'RowData>>
        abstract orderBy: Column<'RowData>
        abstract orderDirection: OrderDirection
        abstract page: int
        abstract pageSize: int
        abstract search: string
        abstract totalCount: int
    
    [<AllowNullLiteral>]
    type QueryResultNative<'RowData> =
        abstract data: ResizeArray<'RowData>
        abstract page: int
        abstract totalCount: int

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
        abstract children: string
        abstract classes: PropsObject option
        abstract color: MuiIconColors
        abstract ``component``: Fable.React.ReactElementType
        abstract fontSize: MuiIconFontSize

    [<AllowNullLiteral>] 
     type Action<'RowData> =
        abstract disabled: bool option
        abstract icon: U2<string, (unit -> ReactElement)>
        abstract isFreeAction: bool option
        abstract position: string option
        abstract tooltip: string option
        abstract onClick: (Browser.Types.MouseEvent -> U2<'RowData, ResizeArray<'RowData>> -> unit)
        abstract iconProps: IconProps option
        abstract hidden: bool option

    module Components =
        [<AllowNullLiteral>]
        type RefComponent =
            abstract current: ReactElement option

        [<AllowNullLiteral>]
        type StyledComponent =
            abstract classes: PropsObject option
            abstract innerRef: RefComponent option

        [<AllowNullLiteral>]
        type ActionProps<'RowData> =
            abstract action: U2<Action<'RowData>, U2<'RowData, ResizeArray<'RowData>> -> Action<'RowData>>
            abstract data: U2<'RowData, ResizeArray<'RowData>> option
            abstract disabled: bool option
            abstract size: string option

type QueryResult<'RowData> =
    { data: 'RowData seq
      page: int
      totalCount: int }

    member this.Native =
        {| data = this.data |> ResizeArray
           page = this.page
           totalCount = this.totalCount |}
        |> unbox<Bindings.QueryResultNative<'RowData>>

[<Erase>]
module QueryResult =
    let inline mapPromiseToNative (prom: JS.Promise<QueryResult<'RowData>>) =
        prom
        |> Promise.map (fun p -> p.Native)
