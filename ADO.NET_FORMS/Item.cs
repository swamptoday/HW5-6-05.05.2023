using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET_FORMS
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
