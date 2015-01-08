namespace FurnitureManufacturer.Models
{
    using System.Text;

    using Interfaces;

    public class Table : Furniture, ITable
    {
        private const string ToStringFormatAddition = ", Length: {0}, Width: {1}, Area: {2}";

        public Table(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, decimal initialLength, decimal initialWidth)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight)
        {
            this.Length = initialLength;
            this.Width = initialWidth;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());
            result.Append(ToStringFormatAddition);
            return string.Format(result.ToString(), this.Length, this.Width, this.Area);
        }
    }
}
