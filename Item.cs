using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Item
    {
        private int stock;
        private double price;
        private string location;

        public Item(int stock, double price, string location)
        {
            this.stock = stock;
            this.price = price;
            this.location = location;
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(stock != value)
                {
                    stock = value;
                }
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(price != value)
                {
                    price = value;
                }
            }
        }
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if(location != value)
                {
                    location = value;
                }
            }
        }
    }
}
