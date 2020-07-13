namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Feliz

[<Erase>]
type icons =
    static member inline add (value: ReactElement) = Interop.mkIconsAttr "Add" (fun () -> value)
    static member inline check (value: ReactElement) = Interop.mkIconsAttr "Check" (fun () -> value)
    static member inline clear (value: ReactElement) = Interop.mkIconsAttr "Clear" (fun () -> value)
    static member inline delete (value: ReactElement) = Interop.mkIconsAttr "Delete" (fun () -> value)
    static member inline detailPanel (value: ReactElement) = Interop.mkIconsAttr "DetailPanel" (fun () -> value)
    static member inline edit (value: ReactElement) = Interop.mkIconsAttr "Edit" (fun () -> value)
    static member inline export (value: ReactElement) = Interop.mkIconsAttr "Export" (fun () -> value)
    static member inline filter (value: ReactElement) = Interop.mkIconsAttr "Filter" (fun () -> value)
    static member inline firstPage (value: ReactElement) = Interop.mkIconsAttr "FirstPage" (fun () -> value)
    static member inline lastPage (value: ReactElement) = Interop.mkIconsAttr "LastPage" (fun () -> value)
    static member inline nextPage (value: ReactElement) = Interop.mkIconsAttr "NextPage" (fun () -> value)
    static member inline previousPage (value: ReactElement) = Interop.mkIconsAttr "PreviousPage" (fun () -> value)
    static member inline resetSearch (value: ReactElement) = Interop.mkIconsAttr "ResetSearch" (fun () -> value)
    static member inline retry (value: ReactElement) = Interop.mkIconsAttr "Retry" (fun () -> value)
    static member inline search (value: ReactElement) = Interop.mkIconsAttr "Search" (fun () -> value)
    static member inline sortArrow (value: ReactElement) = Interop.mkIconsAttr "SortArrow" (fun () -> value)
    static member inline thirdStateCheck (value: ReactElement) = Interop.mkIconsAttr "ThirdStateCheck" (fun () -> value)
    static member inline viewColumn (value: ReactElement) = Interop.mkIconsAttr "ViewColumn" (fun () -> value)
