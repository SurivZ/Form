using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Formulario
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string fullname = string.Empty;

        public string Fullname 
        {
            get => fullname; 
            set
            {
                if (fullname == value) return;

                fullname = value;
                onPropertyChanged(nameof(Fullname));
                onPropertyChanged(nameof(showName));
            }
        }

        public string showName => $"{Fullname}";

        void onPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class ListItem
    {
        // public List<ListItem> _items
        // {
        //     get;
        //     set;
        // }

        // public ListItem()
        // {
        //     _items = new List<Item>();
        //     loadItems();
        // }

        // public void loadItems()
        // {
        //     _items.Add(new Item
        //     {
        //         Name = ""
        //     });
        // }
    }
}
