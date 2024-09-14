# Avalonia.GridPanel

Switch language：[中文版](README.zh_CN.md) [English](README.md)

[Nuget](https://www.nuget.org/packages/ONEO.Avalonia.GridPanel)

> A control that supports grid virtualization layout.

**Note: Currently, it only reaches a barely usable level and is not recommended for formal projects.** If you do not
need to support features like ListBox.SelectedItem, you can use Avalonia.Controls.ItemsRepeater for implementation.

## Usage

```
dotnet add package ONEO.Avalonia.GridPanel
```

## Core requirements

- [x] Supports use in controls with selectable items such as ListBox
- [x] Supports grid layout
- [x] Supports virtualization layout
- [x] Supports custom size
- [x] Supports custom spacing
- [x] Supports keyboard navigation

## Some questions

- [ ] Different from the standard implementation of Avalonia: does not cache controls
- [ ] Cannot support dynamic height layouts: should require IScrollSnapPointsInfo related code, not specifically
  researched
- [ ] Currently, there is an issue with the number of instantiated controls, which may prevent execution during keyboard
  navigation
- [ ] **There is almost no documentation for VirtualizingPanel**

## Screenshot

![Screenshot](Screenshot.jpg)

## LICENSE

[MIT](LICENSE)
