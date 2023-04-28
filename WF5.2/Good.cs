using System;

namespace WF5._2
{
    public class Good
    {
        string name;
        string description;
        double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                {
                    throw new Exception("Цена не может быть меньше нуля");
                }
                price = value;
            }
        }
        public Good()
        {
            Name = "Unknown";
            Description = "Unknown";
            Price = 0;
        }
        public Good(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"Название: {Name}\tОписание: {Description}\tЦена: {Price}";
        }
    }
}