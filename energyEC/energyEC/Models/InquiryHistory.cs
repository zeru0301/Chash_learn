using System.ComponentModel.DataAnnotations.Schema;

namespace energyEC.Models
{
    [Table("inquiry_history")]
    public class InquiryHistory
    {
        public int Id { get; set; }
        public string inquiry_name { get; set; }= string.Empty;
        public string inquiry_form { get; set; } = string.Empty;

        public DateTime history_timestamp { get; set; } = DateTime.Now;
    }
}
