using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SU21_Final_Project
{
   class Items
    {


        //Fields
        private string name;
        private int quantity;
        private double price;
        private double cost;
        private string category;
        private string description;
        public byte[] image;


        public Items() //default constructor when you don't set any values
        {

        }
        //Overload constructor with 4 parameters
        public Items(string name, string description, int quantity, double price, double cost, string category, byte[] image)
        {
           Name = name;
            Description = description;
           Quantity = quantity;
           Price = price;
            Cost = cost;
            Category = category;
            Image = image;
           
        }

        //5 properties to set and to get values for fields 
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public double Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }
        public string Category
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }

        public byte[] Image
        {
            set
            {
                image = value;
            }
            get
            {
                return image;
            }
        }

    }
}
