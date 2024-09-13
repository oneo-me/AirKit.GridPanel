using Avalonia.Controls;
using Avalonia.Diagnostics;

namespace Avalonia.GridPanel.Demo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.AttachDevTools(new DevToolsOptions
        {
            LaunchView = DevToolsViewKind.VisualTree
        });
        ListBox.ItemsSource = Enumerable.Range(0, 1000000).ToList();
    }
}
