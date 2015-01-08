using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    class Salad : ISalad
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private bool containsPasta;
        private MetricUnit unit;
        private bool isVegan;

        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.price = price;
            this.calories = calories;
            this.quantityPerServing = quantityPerServing;
            this.timeToPrepare = timeToPrepare;
            this.containsPasta = containsPasta;
            this.unit = MetricUnit.Grams;
            this.isVegan = true;
        }

        public bool ContainsPasta
        {
            get { return this.containsPasta; }
        }

        public bool IsVegan
        {
            get { return this.isVegan; }
        }

        public void ToggleVegan()
        {
            throw new NotImplementedException();
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
