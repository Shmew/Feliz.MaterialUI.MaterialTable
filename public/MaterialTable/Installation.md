# Feliz.MaterialUI.Pickers - Installation

To install `Feliz.MaterialUI.Pickers` into your project, you need to install the nuget package into your F# project
```bash
# nuget
dotnet add package Feliz.MaterialUI.Pickers
# paket
paket add Feliz.MaterialUI.Pickers --project ./project/path
```
Then you need to install the corresponding npm dependencies:
```bash
npm install react
npm install react-dom
npm install @date-io/core
npm install @date-io/date-fns
npm install @material-ui/core
npm install @material-ui/lab
npm install @material-ui/pickers
npm install date-fns
npm install prop-types

___

yarn add react
yarn add react-dom
yarn add @date-io/core
yarn add @date-io/date-fns
yarn add @material-ui/core
yarn add @material-ui/lab
yarn add @material-ui/pickers
yarn add date-fns
yarn add prop-types
```

### Use Femto

If you happen to use [Femto](https://github.com/Zaid-Ajaj/Femto), then it can install everything for you in one go
```bash
cd ./project
femto install Feliz.MaterialUI.Pickers
```
Here, the nuget package will be installed using the package manager that the project is using (detected by Femto) and then the required npm packages will be resolved.
