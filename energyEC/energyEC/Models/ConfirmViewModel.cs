namespace energyEC.Models
{
    public class ConfirmViewModel
    {
        public int ProductId { get; set; }
        public string ProductName {  get; set; } = string.Empty;

        public int ProductPrice {  get; set; }

        public int Quantity {  get; set; }


        //コンタクトフォーム

        public string ContactName { get; set; } = string.Empty;

        public string ContactForm { get; set; } = string.Empty;
    }
}
