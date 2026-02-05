using System.Collections.Generic;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public static class NativeMenuExtensions
{
    extension<TNativeMenu>(TNativeMenu menu)
        where TNativeMenu : NativeMenu
    {
        public NativeMenu Items(params NativeMenuItemBase[] items)
        {
            foreach (var item in items)
                menu.Items.Add(item);
            return menu;
        }

        public NativeMenu Items(IEnumerable<NativeMenuItemBase> items)
        {
            foreach (var item in items)
                menu.Items.Add(item);
            return menu;
        }

        public NativeMenu AddItem(NativeMenuItemBase item)
        {
            menu.Items.Add(item);
            return menu;
        }
    }


    extension(NativeMenuItem menu)
    {
        public NativeMenuItem Items(params NativeMenuItemBase[] items)
        {
            menu.Menu ??= [];
            foreach (var item in items)
                menu.Menu.Items.Add(item);
            return menu;
        }

        public NativeMenuItem Items(IEnumerable<NativeMenuItemBase> items)
        {
            menu.Menu ??= [];
            foreach (var item in items)
                menu.Menu.Items.Add(item);
            return menu;
        }
        
        public NativeMenuItem AddItem(NativeMenuItemBase item)
        {
            menu.Menu ??= [];
            menu.Menu.Items.Add(item);
            return menu;
        }
    }
}