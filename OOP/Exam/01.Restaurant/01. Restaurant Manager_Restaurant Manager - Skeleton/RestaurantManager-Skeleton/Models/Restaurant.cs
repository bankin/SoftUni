using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using RestaurantManager.Interfaces;
using System.Text.RegularExpressions;
using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    class Restaurant : IRestaurant
    {
        private string tagLine = "***** {0} - {1} *****\n";
        private string noRecipesMessage = "No recipes... yet\n";
        private string menuCategoryTagLing = "~~~~~ {0} ~~~~~\n";
        private string[] menuCategories = {"Drink", "Salad", "Main Course", "Dessert"};

        private static string baseMenuEntry = "==  {0} == ${1:0.00}\nPer serving: {2} {3}, {4} kcal\nReady in {5} minutes\n";
        private string drinkMenuEntry = baseMenuEntry + "Carbonated: {6}\n";
        private string saladMenuEntry = "[VEGAN] " + baseMenuEntry + "Contains pasta: {6}\n";
        private string mainCourseMenuEntry = baseMenuEntry + "Type: {6}\n";
        private string dessertMenuEntry = baseMenuEntry;
         
        private string vegan = "[VEGAN] ";
        private string noSugar = "[NO SUGAR] ";

        private string name;
        private string location;
        private IList<IRecipe> recipes;
        

        public Restaurant(string name, string location)
        {
            if (name == null || name == "")
            {
                throw new ArgumentException("The name is required");
            }
            if (location == null || location == "")
            {
                throw new ArgumentException("The name is required");
            }
            this.name = name;
            this.location = location;
            this.recipes = new List<IRecipe>();
        }

        public IList<IRecipe> Recipes
        {
            get { return this.recipes; }
        }

        public void AddRecipe(IRecipe recipe)
        {
            //If null exception
            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            //Check for null
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            var menu = new StringBuilder();
            menu.Append(string.Format(tagLine, this.name, this.location));
            if (this.Recipes.Count == 0)
            {
                menu.Append(noRecipesMessage);
            }
            else
            {
                foreach (var category in menuCategories)
                {
                    string catClass = Regex.Replace(category, @"\s+", "");
                    var items = this.Recipes.Where(r => r.GetType().Name.Equals(catClass));

                    if (items.Any())
                    {
                        menu.Append(string.Format(menuCategoryTagLing, category + "s").ToUpper());

                        items.OrderBy(i => i.Name);

                        foreach (var item in items)
                        {
                            string entry = "";
                            string unit = item.Unit == MetricUnit.Grams ? "g" : "ml";
                            switch (catClass)
                            {
                                case "Drink":
                                    Drink drink = item as Drink;
                                    entry = string.Format(drinkMenuEntry, item.Name, item.Price, item.QuantityPerServing,
                                        unit, item.Calories, item.TimeToPrepare, drink.IsCarbonated ? "yes" : "no");
                                    break;
                                case "Salad":
                                    Salad salad = item as Salad;
                                    entry = string.Format(saladMenuEntry, item.Name, item.Price, item.QuantityPerServing, unit, item.Calories, item.TimeToPrepare, salad.ContainsPasta?"yes":"no");
                                    break;
                                case "MainCourse":
                                    MainCourse mainCourse = item as MainCourse;
                                    entry = mainCourse.IsVegan ? vegan : "";
                                    entry += string.Format(mainCourseMenuEntry, item.Name, item.Price, item.QuantityPerServing, unit, item.Calories, item.TimeToPrepare, mainCourse.Type);
                                    break;
                                case "Dessert":
                                    Dessert dessert = item as Dessert;
                                    entry = dessert.WithSugar ? "" : noSugar;
                                    entry += dessert.IsVegan ? vegan : "";
                                    entry += string.Format(dessertMenuEntry, item.Name, item.Price, item.QuantityPerServing, unit, item.Calories, item.TimeToPrepare);
                                    break;
                            }
                            menu.Append(entry);
                        }
                    }
                }
            }

            return menu.ToString().Trim();
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public string Location
        {
            get { throw new NotImplementedException(); }
        }
    }
}
