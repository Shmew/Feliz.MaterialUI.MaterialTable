# Feliz.MaterialUI.MaterialTable - Installation

To install `Feliz.MaterialUI.MaterialTable` into your project, you need to install the nuget package into your F# project
```bash
# nuget
dotnet add package Feliz.MaterialUI.MaterialTable
# paket
paket add Feliz.MaterialUI.MaterialTable --project ./project/path
```
Then you need to install the corresponding npm dependencies:
```bash
npm install material-design-icons (if you want to import css via scss)
npm install material-table
npm install lodash

___

yarn add material-design-icons (if you want to import css via scss)
yarn add material-table
yarn add lodash
```

If you opt to not use scss in your project you can add the icons to your html:

```html
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
```

The last option for icons is to implement the icons yourself.

### Use Femto

If you happen to use [Femto](https://github.com/Zaid-Ajaj/Femto), then it can install everything for you in one go
```bash
cd ./project
femto install Feliz.MaterialUI.MaterialTable
```
Here, the nuget package will be installed using the package manager that the project is using (detected by Femto) and then the required npm packages will be resolved.
