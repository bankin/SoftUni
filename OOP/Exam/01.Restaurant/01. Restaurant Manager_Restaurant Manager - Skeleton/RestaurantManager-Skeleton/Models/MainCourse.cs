using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    class MainCourse : IMainCourse
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private bool isVegan;
        private MainCourseType type;
        private MetricUnit unit;

        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {
            if (name == null || name == "")
            {
                throw new ArgumentException("The name is required");
            }
            if (price <= 0)
            {
                throw new ArgumentException("The price must be positive");
            }
            if (calories <= 0)
            {
                throw new ArgumentException("The price must be positive");
            }
            if (quantityPerServing <= 0)
            {
                throw new ArgumentException("The price must be positive");
            }
            if (timeToPrepare <= 0)
            {
                throw new ArgumentException("The price must be positive");
            }
            this.name = name;
            this.price = price;
            this.calories = calories;
            this.quantityPerServing = quantityPerServing;
            this.timeToPrepare = timeToPrepare;
            this.isVegan = isVegan;
            this.type = (MainCourseType) Enum.Parse(typeof (MainCourseType), type, true);
            this.unit = MetricUnit.Grams;
        }

        public Models.MainCourseType Type
        {
            get { return this.type; }
        }

        public bool IsVegan
        {
            get { return isVegan; }
        }

        public void ToggleVegan()
        {
            this.isVegan = !this.isVegan;
        }

        public string Name
        {
            get { return name; }
        }

        public decimal Price
        {
            get { return this.price; }
        }

        public int Calories
        {
            get { return this.calories; }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
        }

        public Models.MetricUnit Unit
        {
            get { return this.unit; }
        }

        public int TimeToPrepare
        {
            get { return this.timeToPrepare; }
        }
    }
}
