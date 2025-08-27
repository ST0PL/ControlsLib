# ![Controls Library](/assets/controlsLib.png)
### A WPF library of custom UI components and extended standard controls.

# Getting Started

1. **Get the [latest release](https://github.com/ST0PL/ControlsLib/releases/latest)**  

2. **Add** `ControlsLib.dll` **reference to your project**

3. **Include library styles** in `App.xaml`:
```xaml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="/ControlsLib;component/Styles/Generic.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```
4. **Add required namespaces** to your window:
```xaml
<Window x:Class="YourApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:YourApp"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800"
        xmlns:clib="clr-namespace:ControlsLib.Controls;assembly=ControlsLib"
        xmlns:prop="clr-namespace:ControlsLib.AttachedProperties;assembly=ControlsLib">
</Window>
```
5. **Use ControlsLib components**
```xaml
<Window x:Class="YourApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:YourApp"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800"
        xmlns:clib="clr-namespace:ControlsLib.Controls;assembly=ControlsLib"
        xmlns:prop="clr-namespace:ControlsLib.AttachedProperties;assembly=ControlsLib">

    <clib:Button Background="#d22d39"
                 CornerRadius="10"
                 Padding="10"
                 BorderThickness="0"
                 HoverBackgroundColor="#bc2934"
                 ClickBackgroundColor="#a0222b"
                 Foreground="White"
                 FontSize="15"
                 HorizontalAlignment="Left"
                 FontWeight="SemiBold"
                 Content="Button content"/>
</Window>
```
# Examples

For example see [Rich Presence GUI](https://github.com/ST0PL/RichPresenceGUI)

# Api Reference

## Custom controls

- NavigationRadioButton
    - `FlagX`
    - `FlagY`
    - `FlagEndX`
    - `FlagEndY`
    - `FlagAnimationDuration`
    - `FlagCornerRadius`
    - `FlagBackground`
    - `FlagPadding`
    - `FlagMargin`
    - `FlagPosition`
- TimeProgressBar
    - `TimeContext`
    - `CornerRadius`
    - `ProgressBarBackground`
    - `ProgressBarBorderBrush`
    - `ProgressBarForeground`
    - `ProgressBarCornerRadius`
    - `ProgressBarBorderThickness`
    - `ProgressBarWidth`
    - `ProgressBarHeight`

## Extended standard controls
- Button
    - `CornerRadius`
    - `HoverBackgroundColor`
    - `ClickBackgroundColor`
- CheckBox
    - `Title`
    - `TitleFontSize`
    - `TitleFontWeight`
    - `TitleFontStyle`
    - `TitleFontFamily`
    - `TitleFontStretch`
    - `TitleForeground`
    - `TitleOpacity`
    - `CornerRadius`
    - `CheckWidth`
    - `CheckHeight`
- ComboBox
    - `CornerRadius`
    - `ItemsCornerRadius`
    - `ItemsForeground`
    - `HoverBackgroundColor`
    - `ClickBackgroundColor`
    - `PopupBackground`
    - `PopupBorderBrush`
    - `PopupBorderThickness`
    - `PopupCornerRadius`
    - `PopupWidth`
    - `PopupHeight`
    - `PopupMaxWidth`
    - `PopupMaxHeight`
    - `HoverItemBackground`
    - `SelectedItemBackground`
    - `Command`
    - `CommandParameter`
    - `CommandTarget`
    - `PopupMargin`
    - `PopupPadding`
    - `PopupEffect`
- ImageRadioButton
    - `CornerRadius`
    - `ImageSource`
    - `CheckedImageSource`
    - `HoverBackgroundColor`
    - `ClickBackgroundColor`
    - `CheckedBackgroundColor`
    - `CheckedForegroundColor`
    - `CheckedBorderBrush`
    - `ImageWidth`
    - `ImageHeight`
    - `ImageMargin`
    - `ContentMargin`
- ListView (ListBox)
    - `ScrollViewerStyle`
    - `HoverItemBorderBrush`
    - `HoverItemBackground`
    - `SelectedItemBorderBrush`
    - `SelectedItemBackground`
    - `ItemBorderThickness`
    - `ItemBorderRadius`
    - `ScrollBarWidth`
    - `ScrollBarBackground`
    - `ScrollBarCornerRadius`
    - `ScrollBarThumbBackground`
    - `HoverScrollBarThumbBackground`
    - `ClickScrollBarThumbBackground`
    - `ScrollBarThumbCornerRadius`
    - `ScrollBarThumbWidth`
    - `CanSelect`
- ProgressBar
    - `CornerRadius`
- ScrollViewer
    - `ScrollBarWidth`
    - `ScrollBarBackground`
    - `ScrollBarCornerRadius`
    - `ScrollBarThumbBackground`
    - `HoverScrollBarThumbBackground`
    - `ClickScrollBarThumbBackground`
    - `ScrollBarThumbCornerRadius`
    - `ScrollBarThumbWidth`
- TextBox
    - `CornerRadius`
    - `Title`
    - `TitleFontSize`
    - `TitleFontWeight`
    - `TitleFontStyle`
    - `TitleFontFamily`
    - `TitleFontStretch`
    - `TitleForeground`
    - `TitleOpacity`
    - `Placeholder`
    - `PlaceholderFontSize`
    - `PlaceholderFontWeight`
    - `PlaceholderFontStyle`
    - `PlaceholderFontFamily`
    - `PlaceholderFontStretch`
    - `PlaceholderForeground`
    - `PlaceholderOpacity`

## Attached properties

- ListBoxBehaviour
	- `AllowCopy`

- PanelChildrenProperties
	- `Margin`
	- `Width`
- ScrollViewerHelper
	- `ScrollBarWidth`
	- `ScrollBarBackground`
	- `ScrollBarCornerRadius`
	- `ScrollBarThumbBackground`
	- `HoverScrollBarThumbBackground`
	- `ClickScrollBarThumbBackground`
	- `ScrollBarThumbCornerRadius`
	- `ScrollBarThumbWidth`

## Other

- TreeTools
	- `GetVisualChild<T>()`
	- `GetVisualChild()`
	- `GetVisualParent<T>()`
    - `GetVisualChildren<T>()`
	- `GetVisualTree()`
	- `GetLogicalChild<T>()`
	- `GetLogicalChild()`
    - `GetLogicalTree()`
	- `GetChild<T>()`
- TimeBarContext
	- `StartSpan`
	- `Percents`
	- `EndSpan`
- FlagPosition
	- `Left`
	- `Right`
