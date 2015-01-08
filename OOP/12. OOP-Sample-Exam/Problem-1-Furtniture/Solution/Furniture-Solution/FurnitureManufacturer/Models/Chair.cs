namespace FurnitureManufacturer.Models
{
    using System.Text;

    using Interfaces;

    public class Chair : Furniture, IChair, IFurniture
    {
        private const string ToStringFormatAddition = ", Legs: {0}";

        public Chair(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight)
        {
            this.NumberOfLegs = initialNumberOfLegs;
        }

        public int NumberOfLegs { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());
            result.Append(ToStringFormatAddition);
            return string.Format(result.ToString(), this.NumberOfLegs);
        }
    }
}
