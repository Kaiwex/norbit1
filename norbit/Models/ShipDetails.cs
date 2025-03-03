namespace ShipCostCalculator.Models
{
    public class ShipDetails
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public string? Material { get; set; }  // Сделали поле Nullable, теперь оно может быть пустым (null)
    }
}
