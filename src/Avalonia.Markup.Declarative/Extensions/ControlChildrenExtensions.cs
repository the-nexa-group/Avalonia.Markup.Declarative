using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

public static class ControlChildrenExtensions
{
    extension<TPanel>(TPanel container) where TPanel : Panel
    {
        public TPanel Children(params Control[] children)
        {
            container.Children.AddRange(children);
            return container;
        }

        public TPanel Children(IEnumerable<Control> children)
        {
            container.Children.AddRange(children);
            return container;
        }
        
        public TPanel AddChild(Control child)
        {
            container.Children.Add(child);
            return container;
        }
    }

    extension<TItemsControl>(TItemsControl container) where TItemsControl : ItemsControl
    {
        public TItemsControl Items(params AvaloniaObject[] items)
        {
            if (container.Items is IList itemsCollection)
                foreach (var item in items)
                    itemsCollection.Add(item);
            return container;
        }

        public TItemsControl Items(IEnumerable<AvaloniaObject> items)
        {
            if (container.Items is IList itemsCollection)
                foreach (var item in items)
                    itemsCollection.Add(item);
            return container;
        }
        
        public TItemsControl AddItem(AvaloniaObject item)
        {
            if (container.Items is IList itemsCollection)
                itemsCollection.Add(item);
            return container;
        }

        public TItemsControl ItemsPanel(Panel panel)
        {
            container.ItemsPanel = new PanelTemplate(panel);
            return container;
        }
    }

    public static TItemsControl ItemTemplate<TItem, TItemsControl>(
        this TItemsControl control,
        Func<TItem, Control?> build)
        where TItemsControl : ItemsControl
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }

    public static ListBox ItemTemplate<TItem>(this ListBox control, Func<TItem, Control?> build) => 
        control.ItemTemplate<TItem, ListBox>(build);
    
    public static TabControl ItemTemplate<TItem>(this TabControl control, Func<TItem, Control?> build) => 
        control.ItemTemplate<TItem, TabControl>(build);
    
    public static MenuFlyout ItemTemplate<TItem>(
        this MenuFlyout control,
        Func<TItem, Control?> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }

    /// <param name="menuFlyout">The menu flyout to which the item will be added.</param>
    /// <typeparam name="TElement">The type of the menu flyout element.</typeparam>
    extension<TElement>(TElement menuFlyout) where TElement : MenuFlyout
    {
        public TElement Items(params MenuItem[] menuItems)
        {
           foreach (var item in menuItems)
               menuFlyout.Items.Add(item);
           return menuFlyout;
        }
        
        public TElement Items(IEnumerable<MenuItem> menuItems)
        {
            foreach (var item in menuItems)
                menuFlyout.Items.Add(item);
            return menuFlyout;
        }
        
        /// <summary>
        /// Adds a menu item to the specified menu flyout.
        /// </summary>
        /// <param name="menuItem">The menu item to be added to the flyout.</param>
        /// <returns>The menu flyout with the added item.</returns>
        public TElement AddItem(MenuItem menuItem)
        {
            menuFlyout.Items.Add(menuItem);
            return menuFlyout;
        }

        /// <summary>
        /// Adds item to MenuFlyout
        /// </summary>
        /// <param name="text">Item text</param>
        /// <param name="command">Item command</param>
        /// <param name="commandParameter">Command parameter</param>
        /// <returns></returns>
        public TElement AddItem(
            string text,
            ICommand command,
            object? commandParameter = null)
        {
            MenuItem item = new() { Header = text, Command = command };
            if (commandParameter != null)
                item.CommandParameter = commandParameter;

            menuFlyout.Items.Add(item);
            return menuFlyout;
        }
    }

    private record PanelTemplate(Panel Panel) : ITemplate<Panel?>
    {
        public Panel Build() => Panel;
        object ITemplate.Build() => throw new NotImplementedException();
    }
}