namespace Task.Model.DTOs
{
    public class ProductGetResponse
    {
        public string Title { get; set; } = string.Empty;
        public string TitleDomestic { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool HasVideo { get; set; }

    }
}
