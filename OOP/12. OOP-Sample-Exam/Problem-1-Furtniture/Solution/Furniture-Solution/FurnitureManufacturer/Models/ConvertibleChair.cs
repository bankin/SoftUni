namespace FurnitureManufacturer.Models
{
    using System.Text;

    using Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair, IChair, IFurniture
    {
        private const decimal ConvertedHeight = 0.10M;
        private const string ToStringFormatAddition = ", State: {0}";
        private const string ConvertedState = "Converted";
        private const string NormalState = "Normal";

        private readonly decimal nonConvertedHeight;

        public ConvertibleChair(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight, initialNumberOfLegs)
        {
            this.nonConvertedHeight = initialHeight;
        }

        public bool IsConverted { get; private set; }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.Height = this.nonConvertedHeight;
            }
            else
            {
                this.Height = ConvertedHeight;
            }

            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());
            result.Append(ToStringFormatAddition);
            return string.Format(result.ToString(), this.IsConverted ? ConvertedState : NormalState);
        }
    }
}
