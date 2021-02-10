[<RequireQualifiedAccess>]
module Samples.Localization

open Fable.Core.Experimental
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
        materialTable.title "Pêşdîtine Tabloye Kurdî"
        materialTable.columns [
            columns.column [
                column.title "Nav"
                column.field<RowData> (fun rd -> nameof rd.name)
            ]
            columns.column [
                column.title "Paşnav"
                column.field<RowData> (fun rd -> nameof rd.surname)
            ]
            columns.column [
                column.title "Salê Zayîn"
                column.field<RowData> (fun rd -> nameof rd.birthYear)
                column.type'.numeric
            ]
            columns.column [
                column.title "Cîhe Zayîn"
                column.field<RowData> (fun rd -> nameof rd.birthCity)
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
        materialTable.localization [
            localization.body [
                localization.body.emptyDataSourceMessage "Guherandinên ku tiştek tune"
            ]
            localization.toolbar [
                localization.toolbar.searchTooltip "Lêgerîn"
                localization.toolbar.searchPlaceholder "Gerr"
            ]
            localization.pagination [
                localization.pagination.labelRowsSelect "Xet"
                localization.pagination.labelDisplayedRows " {from}-{to} xete {count}"
                localization.pagination.firstTooltip "Rûpele Berîn"
                localization.pagination.previousTooltip "Rûpele Berê"
                localization.pagination.nextTooltip "Rûpele Piştî"
                localization.pagination.lastTooltip "Rûpele Talî"
            ]
        ]
    ])
