namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Feliz
open Feliz.MaterialUI

[<Erase>]
type Mui =
    static member inline materialTable (props: IMaterialTableProperty list) = reactElement (importDefault "material-table") (createObj !!props)
