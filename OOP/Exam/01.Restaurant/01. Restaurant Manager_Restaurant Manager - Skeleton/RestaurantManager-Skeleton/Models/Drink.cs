using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    class Drink : IDrink
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private bool isCarbonated;
        private MetricUnit unit;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            if (calories >= 100)
            {
                throw new ArgumentException("The calories must not be greater than 100");
            }
            if (timeToPrepare <= 20)
            {
                throw new ArgumentException("The time to prepare must not be graeter than 20 minutes");
            }
            this.name = name;
            this.price = price;
            this.calories = calories;
            this.quantityPerServing = quantityPerServing;
            this.timeToPrepare = timeToPrepare;
            this.isCarbonated = isCarbonated;
            this.unit = MetricUnit.Milliliters;
        }

        public bool IsCarbonated
        {
            get { return this.isCarbonated; }
        }

        public string Name
        {
            get { return this.name; }
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

        public int TimeToPrepare
        {
            get { return this.timeToPrepare; }
        }


        public MetricUnit Unit
        {
            get { return this.unit; }
        }
    }
}
