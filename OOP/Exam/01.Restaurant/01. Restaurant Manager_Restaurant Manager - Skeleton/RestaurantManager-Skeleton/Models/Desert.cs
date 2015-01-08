using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    class Dessert : IDessert
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private bool isVegan;
        private MetricUnit unit;
        private bool withSugar;

        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.price = price;
            this.calories = calories;
            this.quantityPerServing = quantityPerServing;
            this.timeToPrepare = timeToPrepare;
            this.isVegan = isVegan;
            this.unit = MetricUnit.Grams;
            this.withSugar = true;
        }

        public bool WithSugar
        {
            get { return withSugar; }
        }

        public void ToggleSugar()
        {
            this.withSugar = !this.withSugar;
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
