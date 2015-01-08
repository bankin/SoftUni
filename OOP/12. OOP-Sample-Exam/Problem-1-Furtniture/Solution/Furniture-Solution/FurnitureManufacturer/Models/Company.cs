namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Interfaces;

    public class Company : ICompany
    {
        private const string NameNullOrEmptyErrorMessage = "Name cannot be null or empty";
        private const int NameMinimumLenght = 5;
        private const string NameLenghtLessThanValidSymbolsErrorMessage = "Name lenght must be at least {0} symbols";
        private const int RegistrationNumberLength = 10;
        private const string RegistrationNumberInvalidLengthErrorMessage = "Registration number must be at least {0} symbols";
        private const string RegistrationNumberInvalidSymbolsErrorMessage = "Registration number must contain only digits";
        private const string FurnitureNullErrorMessage = "Furniture cannot be null";
        private const string ToStringFormat = "{0} - {1} - {2} {3}";
        private const int ZeroFurnitures = 0;
        private const string NoFurnitures = "no";
        private const int OneFurniture = 1;
        private const string ManyFurnitures = "furnitures";
        private const string SingleFurniture = "furniture";

        private readonly ICollection<IFurniture> furnitures;
        private string name;
        private string registrationNumber;

        public Company(string initialName, string initialRegistrationNumber)
        {
            this.Name = initialName;
            this.RegistrationNumber = initialRegistrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameNullOrEmptyErrorMessage);
                }

                if (value.Length < NameMinimumLenght)
                {
                    throw new ArgumentOutOfRangeException(string.Format(NameLenghtLessThanValidSymbolsErrorMessage, NameMinimumLenght));
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (value.Length != RegistrationNumberLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format(RegistrationNumberInvalidLengthErrorMessage, RegistrationNumberLength));
                }

                if (value.Any(ch => !char.IsDigit(ch)))
                {
                    throw new ArgumentException(RegistrationNumberInvalidSymbolsErrorMessage);
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException(FurnitureNullErrorMessage);
            }

            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException(FurnitureNullErrorMessage);
            }

            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format(
                ToStringFormat,
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != ZeroFurnitures ? this.Furnitures.Count.ToString() : NoFurnitures,
                this.Furnitures.Count != OneFurniture ? ManyFurnitures : SingleFurniture));

            var sortedFurnitures = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            foreach (var furniture in sortedFurnitures)
            {
                result.AppendLine(furniture.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
