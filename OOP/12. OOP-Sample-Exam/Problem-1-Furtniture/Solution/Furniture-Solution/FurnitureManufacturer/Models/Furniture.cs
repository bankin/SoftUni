namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    public abstract class Furniture : IFurniture
    {
        private const string ModelNullOrEmptyErrorMessage = "Model cannot be null or empty";
        private const int ModelMinimumLenght = 3;
        private const string ModelLenghtLessThanValidSymbolsErrorMessage = "Model lenght must be at least {0} symbols";
        private const int Zero = 0;
        private const string PriceLessThanOrEqualToZeroErrorMessage = "Price cannot be less than {0}";
        private const string HeightLessThanOrEqualToZeroErrorMessage = "Height cannot be less than {0}";
        private const string ToStringFormat = "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}";

        private readonly MaterialType materialType;
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight)
        {
            this.Model = initialModel;
            this.materialType = initialMaterialType;
            this.Price = initialPrice;
            this.Height = initialHeight;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(ModelNullOrEmptyErrorMessage);
                }

                if (value.Length < ModelMinimumLenght)
                {
                    throw new ArgumentOutOfRangeException(string.Format(ModelLenghtLessThanValidSymbolsErrorMessage, ModelMinimumLenght));
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.materialType.ToString();
            }
        }

        public decimal Price 
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= Zero)
                {
                    throw new ArgumentOutOfRangeException(string.Format(PriceLessThanOrEqualToZeroErrorMessage, Zero));
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= Zero)
                {
                    throw new ArgumentOutOfRangeException(string.Format(HeightLessThanOrEqualToZeroErrorMessage, Zero));
                }

                this.height = value;
            } 
        }

        public override string ToString()
        {
            return string.Format(ToStringFormat, this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
