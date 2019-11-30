[<RequireQualifiedAccess>]
module Samples.RemoteData

open Fable.Core.JsInterop
open Fable.Core.Experimental
open Fable.MaterialUI.Icons
open Fable.SimpleHttp
open Fable.SimpleJson
open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.MaterialTable

type private RowData =
    { avatar: string
      email: string
      first_name: string
      id: int
      last_name: string }

type private RespJson =
    { page: int
      per_page: int
      total: int
      total_pages: int
      data: RowData [] }

let private buildUrl pageSize page =
    sprintf "https://reqres.in/api/users?per_page=%i&page=%i" pageSize (page + 1)

let render = React.functionComponent (fun () ->
    let theme = Styles.useTheme()

    Mui.materialTable [
        prop.style [ style.backgroundColor theme.palette.background.``default`` ]
        materialTable.title "Remote Data Preview"
        materialTable.columns [
            columns.column [
                column.title "Avatar"
                column.field<RowData> (fun rd -> nameof rd.avatar)
                column.render<RowData> (fun rowData ->
                    Mui.avatar [
                        avatar.src rowData.avatar
                        prop.style [ 
                            style.height 36
                            style.borderRadius (length.percent 50)
                        ]
                    ]
                )
            ]
            columns.column [
                column.title "Id"
                column.field<RowData> (fun rd -> nameof rd.id)
            ]
            columns.column [
                column.title "First Name"
                column.field<RowData> (fun rd -> nameof rd.first_name)
            ]
            columns.column [
                column.title "Last Name"
                column.field<RowData> (fun rd -> nameof rd.last_name)
            ]
        ]
        materialTable.data<RowData> (fun query ->
            Promise.create (fun resolve reject ->
                async {
                    let! (statusCode, responseText) =
                        buildUrl query.pageSize query.page
                        |> Http.get
                    if statusCode = 200 then
                        responseText
                        |> Json.tryParseAs<RespJson>
                        |> function
                        | Ok resJson -> 
                            { data = resJson.data
                              page = resJson.page - 1
                              totalCount = resJson.total }
                            |> resolve
                        | Error e -> e |> System.Exception |> reject
                }
                |> Async.StartImmediate
            )
        )
    ])
