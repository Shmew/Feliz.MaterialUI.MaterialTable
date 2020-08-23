namespace Feliz.MaterialUI.MaterialTable

open Fable.Core
open System.ComponentModel

type IActionProperty = interface end
type IActionsProperty = interface end
type ICellEditableProperty = interface end
type IColumnProperty = interface end
type IColumnsProperty = interface end
type IComponentsProperty = interface end
type ICurrencySettingProperty = interface end
type IDetailPanelProperty = interface end
type IDetailPanelsProperty = interface end
type IEditableProperty = interface end
type IFixedColumnProperty = interface end
type ILocalizationProperty = interface end
type ILocalizationBodyProperty = interface end
type ILocalizationEditRowProperty = interface end
type ILocalizationFilterRowProperty = interface end
type ILocalizationGroupingProperty = interface end
type ILocalizationHeaderProperty = interface end
type ILocalizationPaginationProperty = interface end
type ILocalizationToolbarProperty = interface end
type IIconsProperty = interface end
type IOptionsProperty = interface end

[<EditorBrowsable(EditorBrowsableState.Never);Erase>]
module Interop =
    let inline mkActionAttr (key: string) (value: obj) : IActionProperty = unbox (key, value)
    let inline mkCellEditableAttr (key: string) (value: obj) : ICellEditableProperty = unbox (key, value)
    let inline mkColumnAttr (key: string) (value: obj) : IColumnProperty = unbox (key, value)
    let inline mkComponentsAttr (key: string) (value: obj) : IComponentsProperty = unbox (key, value)
    let inline mkCurrencySettingAttr (key: string) (value: obj) : ICurrencySettingProperty = unbox (key, value)
    let inline mkDetailPanelAttr (key: string) (value: obj) : IDetailPanelProperty = unbox (key, value)
    let inline mkEditableAttr (key: string) (value: obj) : IEditableProperty = unbox (key, value)
    let inline mkFixedColumnAttr (key: string) (value: obj) : IFixedColumnProperty = unbox (key, value)
    let inline mkLocalizationAttr (key: string) (value: obj) : ILocalizationProperty = unbox (key, value)
    let inline mkLocalizationBodyAttr (key: string) (value: obj) : ILocalizationBodyProperty = unbox (key, value)
    let inline mkLocalizationEditRowAttr (key: string) (value: obj) : ILocalizationEditRowProperty = unbox (key, value)
    let inline mkLocalizationFilterRowAttr (key: string) (value: obj) : ILocalizationFilterRowProperty = unbox (key, value)
    let inline mkLocalizationGroupingAttr (key: string) (value: obj) : ILocalizationGroupingProperty = unbox (key, value)
    let inline mkLocalizationHeaderAttr (key: string) (value: obj) : ILocalizationHeaderProperty = unbox (key, value)
    let inline mkLocalizationPaginationAttr (key: string) (value: obj) : ILocalizationPaginationProperty = unbox (key, value)
    let inline mkLocalizationToolbarAttr (key: string) (value: obj) : ILocalizationToolbarProperty = unbox (key, value)
    let inline mkIconsAttr (key: string) (value: obj) : IIconsProperty = unbox (key, value)
    let inline mkOptionsAttr (key: string) (value: obj) : IOptionsProperty = unbox (key, value)
