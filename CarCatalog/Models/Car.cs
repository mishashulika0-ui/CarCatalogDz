namespace CarCatalog.Models
{
    public class Car
    {
        public string Brand { get; set; } = string.Empty; // Марка
        public string Model { get; set; } = string.Empty; // Модель
        public decimal Price { get; set; }         // Ціна
    }
}