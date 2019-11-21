[<RequireQualifiedAccess>]
module Samples.DetailPanel

open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int }

let render = React.functionComponent (fun () ->
    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]        
        materialTable.title "Detail Panel With RowClick Preview"
        materialTable.columns [
            columns.column [
                column.title "Name"
                column.field "name"
            ]
            columns.column [
                column.title "Surname"
                column.field "surname"
            ]
            columns.column [
                column.title "Birth Year"
                column.field "birthYear"
                column.type'.numeric
            ]
            columns.column [
                column.title "Birth Place"
                column.field "birthCity"
                column.lookup<int,string> [ 
                    (34, "İstanbul")
                    (63, "Şanlıurfa") 
                ]
            ]
        ]
        materialTable.data [
            { name = "Mehmet"
              surname = "Baran"
              birthYear = 1987
              birthCity = 63 }
            { name = "Zerya Betül"
              surname = "Baran"
              birthYear = 2017
              birthCity = 34 }
        ]
        materialTable.detailPanels<RowData> (fun rowData ->
            Mui.cardMedia [
                cardMedia.component' "iframe"
                cardMedia.src "https://www.youtube.com/embed/C0DPdy98e4c"
                Interop.mkAttr "allow" "accelerometer; autoplay; encrypted-media; fullscreen; gyroscope; picture-in-picture" // See https://github.com/Zaid-Ajaj/Feliz/issues/124
                prop.height 315
                prop.style [ style.borderWidth 0 ]
            ]
        )
        materialTable.onRowClick (fun _ _ togglePanel -> togglePanel())
    ])
