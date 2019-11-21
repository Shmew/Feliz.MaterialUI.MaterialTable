[<RequireQualifiedAccess>]
module Samples.CustomColumnRendering

open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { name: string
      surname: string
      birthYear: int
      birthCity: int 
      imageUrl: string }

let render = React.functionComponent (fun () ->
    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]
        materialTable.title "Render Image Preview"
        materialTable.columns [
            columns.column [
                column.title "Avatar"
                column.field "imageUrl"
                column.render<RowData> (fun rowData ->
                    Mui.avatar [
                        avatar.src rowData.imageUrl
                        prop.style [ 
                            style.width 40
                            style.borderRadius (length.percent 50)
                        ]
                    ]
                )
            ]
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
              birthCity = 63
              imageUrl = "https://avatars0.githubusercontent.com/u/7895451?s=460&v=4" }
            { name = "Zerya Betül"
              surname = "Baran"
              birthYear = 2017
              birthCity = 34
              imageUrl = "https://avatars0.githubusercontent.com/u/7895451?s=460&v=4" }
        ]
    ])
