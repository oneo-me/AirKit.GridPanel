# Avalonia.GridPanel

> 一个支持网格虚拟化布局的控件

**注意：目前仅仅达到凑合能用的地步，不建议用于正式项目**，如果不需要支持 ListBox.SelectedItem 之类的功能，可以使用
Avalonia.Controls.ItemsRepeater 实现。

## 核心需求

- [x] 支持在 ListBox 等具有选择项的控件中使用
- [x] 支持网格布局
- [x] 支持虚拟化布局
- [x] 支持自定义大小
- [x] 支持自定义间距
- [x] 支持键盘导航

## 一些问题

- [ ] 与 Avalonia 标准的实现方式有区别：不会缓存控件
- [ ] 无发支持动态高度的布局：应该需要 IScrollSnapPointsInfo 相关代码，没有集体研究
- [ ] 目前实例化控件数量存在问题，导致键盘导航时可能无发执行
- [ ] **VirtualizingPanel 开发几乎没有文档**

## LICENSE

[MIT](LICENSE)