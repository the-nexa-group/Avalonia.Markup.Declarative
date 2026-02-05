using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public static class CommonAttachedPropertyExtensions
{
     /// <param name="control">Control for positioning</param>
    /// <typeparam name="TElement"></typeparam>
    extension<TElement>(TElement control) where TElement : Control
    {
        public TElement Dock(Dock dock)
        {
            DockPanel.SetDock(control, dock);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_Column (in xaml: Grid.Column) extension 
        /// </summary>
        /// <param name="value">Grid.Column value</param>
        /// <returns></returns>
        public TElement Col(int value)
        {
            Grid.SetColumn(control, value);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_Row (in xaml: Grid.Row) extension 
        /// </summary>
        /// <param name="value">Grid.Row value</param>
        /// <returns></returns>
        public TElement Row(int value)
        {
            Grid.SetRow(control, value);
            return control;
        }
        
        /// <summary>
        /// It's a shortcut for Grid_ColumnSpan (in xaml: Grid.ColumnSpan) extension 
        /// </summary>
        /// <param name="value">Grid.ColumnSpan value</param>
        /// <returns></returns>
        public TElement ColSpan(int value)
        {
            Grid.SetColumnSpan(control, value);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_RowSpan (in xaml: Grid.RowSpan) extension 
        /// </summary>
        /// <param name="value">Grid.RowSpan value</param>
        /// <returns></returns>
        public TElement RowSpan(int value)
        {
            Grid.SetRowSpan(control, value);
            return control;
        }
    }

    /// <param name="control">Grid control</param>
    /// <typeparam name="TElement">Grid</typeparam>
    extension<TElement>(TElement control) where TElement : Grid
    {
        /// <summary>
        /// It's a shortcut for Grid_ColumnDefinitions (in xaml: Grid.ColumnDefinitions) extension 
        /// </summary>
        /// <param name="value">Grid.ColumnDefinitions value</param>
        /// <returns></returns>
        public TElement Cols(ColumnDefinitions value)
        {
            control.ColumnDefinitions = value;
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_RowDefinitions (in xaml: Grid.RowDefinitions) extension 
        /// </summary>
        /// <param name="value">Grid.RowDefinitions value</param>
        /// <returns></returns>
        public TElement Rows(RowDefinitions value)
        {
            control.RowDefinitions = value;
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_ColumnDefinitions (in xaml: Grid.ColumnDefinitions) extension 
        /// </summary>
        /// <param name="value">String representing ColumnDefinitions i.e. "0,*,30,Auto" </param>
        /// <returns></returns>
        public TElement Cols(string value)
        {
            control.ColumnDefinitions = ColumnDefinitions.Parse(value);
            return control;
        }

        /// <summary>
        /// It's a shortcut for Grid_RowDefinitions (in xaml: Grid.RowDefinitions) extension 
        /// </summary>
        /// <param name="value">String representing RowDefinitions i.e. "0,*,30,Auto" </param>
        /// <returns></returns>
        public TElement Rows(string value)
        {
            control.RowDefinitions = RowDefinitions.Parse(value);
            return control;
        }
    }
}