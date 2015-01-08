namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class AdjustableChair : Chair, IAdjustableChair, IChair, IFurniture
    {
        public AdjustableChair(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight, initialNumberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
