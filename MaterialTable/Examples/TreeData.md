# Feliz.MaterialUI.MaterialTable - Tree Data

Taken from [material-table - Tree Data](https://material-table.com/#/docs/features/tree-data)

```fsharp:materialtable-treedata
[<RequireQualifiedAccess>]
module Samples.TreeData

open Fable.Core
open Feliz
open Feliz.MaterialUI.MaterialTable

[<StringEnum(CaseRules.None)>]
type private Sex =
    | Male
    | Female

[<StringEnum>]
type private AgeRange =
    | Adult
    | Child

type private RowData =
    { id: int
      name: string
      surname: string
      birthYear: int
      birthCity: int
      sex: Sex
      ageRange: AgeRange
      parentId: int option }

let render = React.functionComponent (fun () ->
    Mui.materialTable [
        materialTable.title "Tree Data Preview"
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
                column.title "Sex"
                column.field "sex"
            ]
            columns.column [
                column.title "Age Range"
                column.field "ageRange"
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
            { id = 1
              name = "a" 
              surname = "Baran"
              birthYear = 1987
              birthCity = 63
              sex = Male
              ageRange = Adult
              parentId = None }
            { id = 2
              name = "b" 
              surname = "Baran"
              birthYear = 1987
              birthCity = 34
              sex = Female
              ageRange = Adult
              parentId = Some 1 }
            { id = 3
              name = "c" 
              surname = "Baran"
              birthYear = 1987
              birthCity = 34
              sex = Female
              ageRange = Child
              parentId = Some 1 }
            { id = 4
              name = "d" 
              surname = "Baran"
              birthYear = 1987
              birthCity = 34
              sex = Female
              ageRange = Child
              parentId = Some 3 }
            { id = 5
              name = "e" 
              surname = "Baran"
              birthYear = 1987
              birthCity = 34
              sex = Female
              ageRange = Child
              parentId = None }
            { id = 6
              name = "f" 
              surname = "Baran"
              birthYear = 1987
              birthCity = 34
              sex = Female
              ageRange = Child
              parentId = Some 5 }
        ]
        materialTable.parentChildData<RowData> (fun row rows ->
                rows 
                |> List.tryFind (fun r -> r.id = Option.defaultValue -1 row.parentId)
        )
        materialTable.options [
            options.selection true
        ]
    ])
```