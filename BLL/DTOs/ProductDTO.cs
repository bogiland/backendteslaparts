namespace TeslaStore.BLL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        
        // Дополнительные поля для демонстрации бизнес-логики (поведения и вычислений)
        public string? FormattedPrice { get; set; }
        public bool IsPremium { get; set; }
        public string? TaxInfo { get; set; }
    }
}
