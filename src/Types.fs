namespace Feliz.MaterialUI.MaterialTable

open System.ComponentModel

type IActionProperty = interface end
type IActionsProperty = interface end
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

[<EditorBrowsable(EditorBrowsableState.Never)>]
module Interop =
    let mkActionAttr (key: string) (value: obj) : IActionProperty = unbox (key, value)
    let mkColumnAttr (key: string) (value: obj) : IColumnProperty = unbox (key, value)
    let mkComponentsAttr (key: string) (value: obj) : IComponentsProperty = unbox (key, value)
    let mkCurrencySettingAttr (key: string) (value: obj) : ICurrencySettingProperty = unbox (key, value)
    let mkDetailPanelAttr (key: string) (value: obj) : IDetailPanelProperty = unbox (key, value)
    let mkEditableAttr (key: string) (value: obj) : IEditableProperty = unbox (key, value)
    let mkFixedColumnAttr (key: string) (value: obj) : IFixedColumnProperty = unbox (key, value)
    let mkLocalizationAttr (key: string) (value: obj) : ILocalizationProperty = unbox (key, value)
    let mkLocalizationBodyAttr (key: string) (value: obj) : ILocalizationBodyProperty = unbox (key, value)
    let mkLocalizationEditRowAttr (key: string) (value: obj) : ILocalizationEditRowProperty = unbox (key, value)
    let mkLocalizationFilterRowAttr (key: string) (value: obj) : ILocalizationFilterRowProperty = unbox (key, value)
    let mkLocalizationGroupingAttr (key: string) (value: obj) : ILocalizationGroupingProperty = unbox (key, value)
    let mkLocalizationHeaderAttr (key: string) (value: obj) : ILocalizationHeaderProperty = unbox (key, value)
    let mkLocalizationPaginationAttr (key: string) (value: obj) : ILocalizationPaginationProperty = unbox (key, value)
    let mkLocalizationToolbarAttr (key: string) (value: obj) : ILocalizationToolbarProperty = unbox (key, value)
    let mkIconsAttr (key: string) (value: obj) : IIconsProperty = unbox (key, value)
    let mkOptionsAttr (key: string) (value: obj) : IOptionsProperty = unbox (key, value)
