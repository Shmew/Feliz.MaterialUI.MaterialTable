namespace Feliz.MaterialUI.MaterialTable

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open System

[<Erase>]
type materialTable =
    /// Action list. An icon button will be rendered for each actions
    static member inline actions (prop: IActionsProperty) = Interop.mkMaterialTableAttr "actions" (prop|> Array.singleton |> ResizeArray)
    /// Action list. An icon button will be rendered for each actions
    static member inline actions (props: IActionsProperty list) = Interop.mkMaterialTableAttr "actions" (props |> ResizeArray)
    /// Column definitions
    static member inline columns (prop: IColumnsProperty) = Interop.mkMaterialTableAttr "columns" (prop |> Array.singleton |> ResizeArray)
    /// Column definitions
    static member inline columns (props: IColumnsProperty list) = Interop.mkMaterialTableAttr "columns" (props |> ResizeArray)
    /// Component customization
    static member inline components (prop: IComponentsProperty) = Interop.mkMaterialTableAttr "components" (createObj !![ prop ])
    /// Component customization
    static member inline components (props: IComponentsProperty list) = Interop.mkMaterialTableAttr "components" (createObj !!props)
    /// Data to be rendered
    static member inline data (values: 'T list) = Interop.mkMaterialTableAttr "data" (values |> ResizeArray)
    /// Data to be rendered
    static member inline data<'T> (handler: Bindings.Query<'T> -> JS.Promise<QueryResult<'T>>) = 
        Interop.mkMaterialTableAttr "data" (fun query -> handler query |> QueryResult.mapPromiseToNative)
    /// Component(s) to be rendered on detail panel
    static member inline detailPanels (prop: IDetailPanelsProperty) = Interop.mkMaterialTableAttr "detailPanel" (prop |> Array.singleton |> ResizeArray)
    /// Component(s) to be rendered on detail panel
    static member inline detailPanels (props: IDetailPanelsProperty list) = Interop.mkMaterialTableAttr "detailPanel" (props |> ResizeArray)
    /// Component(s) to be rendered on detail panel
    static member inline detailPanels<'T> (handler: 'T -> ReactElement) = Interop.mkMaterialTableAttr "detailPanel" handler
    /// Object for add, update and delete functions
    static member inline editable (props: IEditableProperty list) = Interop.mkMaterialTableAttr "editable" (createObj !!props)
    /// Icons customization
    static member inline icons (prop: IIconsProperty) = Interop.mkMaterialTableAttr "icons" (createObj !![ prop ])
    /// Icons customization
    static member inline icons (props: IIconsProperty list) = Interop.mkMaterialTableAttr "icons" (createObj !!props)
    /// Flag for loading animation
    static member inline isLoading (value: bool) = Interop.mkMaterialTableAttr "isLoading" value
    /// All text for localization
    static member inline localization (prop: ILocalizationProperty) = Interop.mkMaterialTableAttr "localization" (createObj !![ prop ])
    /// All text for localization
    static member inline localization (props: ILocalizationProperty list) = Interop.mkMaterialTableAttr "localization" (createObj !!props)
    /// To handle page changes (page)
    static member inline onChangePage (handler: int -> unit) = Interop.mkMaterialTableAttr "onChangePage" handler
    /// To handle rows per page changes (pageSize)
    static member inline onChangeRowsPerPage (handler: int -> unit) = Interop.mkMaterialTableAttr "onChangeRowsPerPage" handler
    /// To handle column show/hidden changes (column, hidden)
    static member inline onChangeColumnHidden<'T> (handler: Bindings.Column<'T> -> bool -> unit) = Interop.mkMaterialTableAttr "onChangeColumnHidden" (Func<_,_,_> handler)
    /// To handle column drag and drops (sourceIndex, destinationIndex)
    static member inline onColumnDragged (handler: int -> int -> unit) = Interop.mkMaterialTableAttr "onColumnDragged" (Func<_,_,_> handler)
    /// To handle column group removed (groupedColumn, index)
    static member inline onGroupRemoved<'T> (handler: Bindings.Column<'T> -> int -> unit) = Interop.mkMaterialTableAttr "onGroupRemoved" (Func<_,_,_> handler)
    /// To handle order changes (orderedColumnId, orderDirection)
    static member inline onOrderChange (handler: int -> Bindings.OrderDirection -> unit) = Interop.mkMaterialTableAttr "onOrderChange" (Func<_,_,_> handler)
    /// To handle row click (event, rowData)
    static member inline onRowClick<'T> (handler: Browser.Types.MouseEvent -> 'T -> (unit -> unit) -> unit) = Interop.mkMaterialTableAttr "onRowClick" (Func<_,_,_,_> handler)
    /// To handle selection changes
    static member inline onSelectionChange<'T> (handler: 'T list -> 'T -> unit) = Interop.mkMaterialTableAttr "onSelectionChange"  (Func<_,_,_> handler)
    /// To handle tree data rows expand changes
    static member inline onTreeExpandChange (handler: obj option -> bool -> unit) = Interop.mkMaterialTableAttr "onTreeExpandChange" (Func<_,_,_> handler)
    /// To handle search changes
    static member inline onSearchChange (handler: string -> unit) = Interop.mkMaterialTableAttr "onSearchChange" handler
    /// All options of table
    static member inline options (prop: IOptionsProperty) = Interop.mkMaterialTableAttr "options" (createObj !![ prop ])
    /// All options of table
    static member inline options (props: IOptionsProperty list) = Interop.mkMaterialTableAttr "options" (createObj !!props)
    /// Func that makes table parent-child table
    static member inline parentChildData<'T> (handler: 'T -> 'T list -> 'T option) = 
        Interop.mkMaterialTableAttr "parentChildData" (Func<_,_,_> (fun (row: 'T) (rows: ResizeArray<'T>) -> rows |> List.ofSeq |> handler row))
    /// Func that makes table parent-child table
    static member inline parentChildData<'T> (handler: 'T -> 'T [] -> 'T option) = 
        Interop.mkMaterialTableAttr "parentChildData" (Func<_,_,_> (fun (row: 'T) (rows: ResizeArray<'T>) -> rows |> Array.ofSeq |> handler row))
    /// Could be use to pass ref over withStyles
    static member inline tableRef (handler: Element -> unit) = Interop.mkMaterialTableAttr "tableRef" handler
    /// Could be use to pass ref over withStyles
    static member inline tableRef<'T> (ref: Fable.React.IRefValue<Bindings.MaterialTableProps<'T> option>) = Interop.mkMaterialTableAttr "tableRef" ref
    /// Table Title (only render if toolbar option is true)
    static member inline title (value: ReactElement) = Interop.mkMaterialTableAttr "title" value
    /// Table Title (only render if toolbar option is true)
    static member inline title (value: string) = Interop.mkMaterialTableAttr "title" value
