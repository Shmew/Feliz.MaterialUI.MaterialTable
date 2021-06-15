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
    type Editing =
        | Update

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

    type CurrencySetting =
        abstract locale: string option
        abstract currencyCode: string option
        abstract minimumFractionDigits: int option
        abstract maximumFractionDigits: int option

    type Validation =
        abstract isValid: bool
        abstract helperText: string option

    [<RequireQualifiedAccess>]
    module Validation =
        let inline fromResult (inp: Result<unit,string>) =
            match inp with
            | Ok _ -> {| isValid = true |} |> unbox<Validation>
            | Error str -> {| isValid = false; helperText = str |} |> unbox<Validation>

    type Column<'RowData> =
        abstract align: ColumnAlign option
        abstract cellStyle: U2<PropsObject, ('RowData [] -> 'RowData -> PropsObject)> option
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
        abstract lookup: 'K * 'V [] option with get, set
        abstract readOnly: bool option
        abstract removable: bool option
        abstract render: ('RowData -> ColumnType -> ReactElement) option
        abstract searchable: bool option
        abstract sorting: bool option
        abstract title: U2<string, ReactElement> option
        abstract ``type``: ColumnFieldType option
        abstract validate: ('RowData -> U3<Validation,string,bool>) option
        abstract width: string option

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

    type Query<'RowData> =
        abstract error: ErrorState option
        abstract filters: Filter<'RowData> []
        abstract orderBy: Column<'RowData>
        abstract orderDirection: OrderDirection
        abstract page: int
        abstract pageSize: int
        abstract search: string
        abstract totalCount: int
    
    [<AllowNullLiteral>]
    type QueryResultNative<'RowData> =
        abstract data: 'RowData []
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

    type IconProps =
        abstract children: string
        abstract classes: PropsObject option
        abstract color: MuiIconColors
        abstract ``component``: Fable.React.ReactElementType
        abstract fontSize: MuiIconFontSize

     type Action<'RowData> =
        abstract disabled: bool option
        abstract icon: U2<string, (unit -> ReactElement)>
        abstract isFreeAction: bool option
        abstract position: string option
        abstract tooltip: string option
        abstract onClick: (Browser.Types.MouseEvent -> U2<'RowData, 'RowData []> -> unit)
        abstract iconProps: IconProps option
        abstract hidden: bool option

    [<Erase>]
    module Components =
        type RefComponent =
            abstract current: ReactElement option

        type StyledComponent =
            abstract classes: PropsObject option
            abstract innerRef: RefComponent option

        type ActionProps<'RowData> =
            abstract action: U2<Action<'RowData>, U2<'RowData, 'RowData []> -> Action<'RowData>>
            abstract data: U2<'RowData, 'RowData []> option
            abstract disabled: bool option
            abstract size: string option

    type Components<'RowData> =
        abstract Action: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Actions: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Body: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Cell: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Container: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract EditField: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract EditRow: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract FilterRow: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Groupbar: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract GroupRow: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Header: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract OverlayLoading: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract OverlayError: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Pagination: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Row: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option
        abstract Toolbar: U3<ReactElement,'RowData -> ReactElement, Components.StyledComponent> option

    type Editable<'RowData> =
        abstract isDeletable: ('RowData -> bool) option
        abstract isDeleteHidden: ('RowData -> bool) option
        abstract isEditable: ('RowData -> bool) option
        abstract isEditHidden: ('RowData -> bool) option
        abstract onRowAdd: ('RowData -> JS.Promise<unit>) option
        abstract onRowUpdate: ('RowData -> JS.Promise<unit>) option
        abstract onRowDelete: ('RowData -> JS.Promise<unit>) option
        abstract onRowAddCancelled: ('RowData -> JS.Promise<unit>) option
        abstract onRowUpdateCancelled: ('RowData -> JS.Promise<unit>) option
        
    type DetailPanel<'RowData> =
        abstract disabled: bool option
        abstract icon: U4<IconProps,ReactElement,string,'RowData -> ReactElement> option
        abstract openIcon: U4<Components.RefComponent,ReactElement,string,'RowData -> ReactElement> option
        abstract tooltip: string option
        abstract render: 'RowData -> ReactElement

    type Icons<'RowData> =
        abstract Add: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Check: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Clear: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Delete: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract DetailPanel: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Edit: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Export: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Filter: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract FirstPage: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract LastPage: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract NextPage: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract PreviousPage: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Refresh: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract ResetSearch: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract Search: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract SortArrow: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract ThirdStateCheck: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option
        abstract ViewColumn: U3<ReactElement,'RowData -> ReactElement, Components.RefComponent> option

    type Props<'RowData> =
        abstract actions: Action<'RowData> [] option
        abstract columns: Column<'RowData> []
        abstract components: Components<'RowData> option
        abstract data: 'RowData []
        abstract editable: Editable<'RowData> option
        abstract detailPanel: U2<'RowData -> ReactElement,DetailPanel<'RowData> []> option
        abstract icons: Icons<'RowData> option
        abstract isLoading: bool option
        abstract title: U2<ReactElement,string> option
        abstract page: int option
        abstract totalCount: int option

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

//open Feliz
open Bindings

//[<NoEquality;NoComparison>]
//type SubTableData<'RowData when 'RowData : not struct> =
//    { additionalWidth: float option
//      ``checked``: bool option
//      columnOrder: int option
//      disabled: bool option
//      editing: Editing option
//      filterValue: string option
//      groupOrder: int option
//      groupSort: OrderDirection option
//      id: int option
//      initialWidth: string option
//      isTreeExpanded: bool option
//      markedForTreeRemove: bool option
//      path: int [] option
//      showDetailPanel: ('RowData -> ReactElement) option 
//      width: string option }

//[<NoEquality;NoComparison>]
//type TableData<'RowData when 'RowData : not struct> =
//    { additionalWidth: float option
//      ``checked``: bool option
//      columnOrder: int option
//      disabled: bool option
//      editCellList: SubTableData<'RowData> [] option
//      editing: Editing option
//      filterValue: string option
//      childRows: SubTableData<'RowData> [] option
//      groupOrder: int option
//      groupSort: OrderDirection option
//      id: int option
//      initialWidth: string option
//      isTreeExpanded: bool option
//      markedForTreeRemove: bool option
//      path: int [] option
//      showDetailPanel: ('RowData -> ReactElement) option 
//      width: string option }

//type IRowData = interface end

//[<NoEquality;NoComparison>]
//type TableMutableData<'RowData when 'RowData : not struct> =
//    { tableData: TableData<'RowData> }

//[<Erase>]
//module TableData =
//    let inline tryGet (data: #IRowData seq) = 
//        unbox<TableMutableData<'RowData> list>(data)
//        |> fun data -> 
//            if List.tryHead data |> Option.bind (fun x -> unbox<TableData<'RowData> option>(x.tableData)) |> Option.isSome then
//                Some data
//            else None

type TableRef<'RowData> =
    abstract props: Props<'RowData>

//[<AutoOpen>]
//module FelizExtensions =
//    type React with
//        static member useMaterialTableState<'RowData when 'RowData :> IRowData and 'RowData : not struct> (initial: 'RowData list) : 'RowData list * ('RowData list -> unit) * (TableMutableData<'RowData> list -> unit) = 
//            let v,setV = Feliz.React.useState (unbox<obj> initial)

//            unbox<'RowData list>(v),unbox<'RowData list -> unit>(setV),(unbox setV)
