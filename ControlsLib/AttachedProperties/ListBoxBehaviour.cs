using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ControlsLib.AttachedProperties
{
    public class ListBoxBehaviour
    {

        private static readonly ConditionalWeakTable<ListBox, NotifyCollectionChangedEventHandler> AutoScrollHandlers = new();

        public static readonly DependencyProperty AllowCopyProperty
            = DependencyProperty.RegisterAttached("AllowCopy", typeof(bool), typeof(ListBoxBehaviour), new UIPropertyMetadata(OnAllowCopyChanged));

        public static readonly DependencyProperty AutoScrollProperty
            = DependencyProperty.RegisterAttached("AutoScroll", typeof(bool), typeof(ListBoxBehaviour), new UIPropertyMetadata(OnAutoScrollChanged));

        public static bool GetAllowCopy(DependencyObject obj)
            => (bool)obj.GetValue(AllowCopyProperty);
        public static void SetAllowCopy(DependencyObject obj, bool value)
            => obj.SetValue(AllowCopyProperty, value);

        public static bool GetAutoScroll(DependencyObject obj)
            => (bool)obj.GetValue(AutoScrollProperty);
        public static void SetAutoScroll(DependencyObject obj, bool value)
            => obj.SetValue(AutoScrollProperty, value);

        private static void OnAllowCopyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is ListBox listBox)
            {
                if ((bool)e.NewValue)
                {
                    ExecutedRoutedEventHandler handler = (_, _) => Clipboard.SetDataObject(listBox.SelectedItem.ToString());
                    var command = new RoutedCommand();
                    command.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control));
                    listBox.CommandBindings.Add(new CommandBinding(command, handler));
                }
                else
                    listBox.CommandBindings.Clear();
            }
        }
        private static void OnAutoScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ListBox listBox && listBox.ItemsSource is INotifyCollectionChanged observableCollection)
            {
                if ((bool)e.NewValue)
                {
                    if (!AutoScrollHandlers.TryGetValue(listBox, out var handler))
                    {
                        handler = (_, _) =>
                        {
                            var scrollViewer = TreeTools.GetVisualChild<ScrollViewer>(listBox);
                            if (scrollViewer?.VerticalOffset >= scrollViewer?.ScrollableHeight)
                                scrollViewer.ScrollToEnd();
                        };
                        AutoScrollHandlers.Add(listBox, handler);
                    }
                    observableCollection.CollectionChanged += handler;
                }
                else if (AutoScrollHandlers.TryGetValue(listBox, out var handler))
                {
                    observableCollection.CollectionChanged -= handler;
                    AutoScrollHandlers.Remove(listBox);
                }
            }
        }
    }
}
