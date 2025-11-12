using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace energyEC.Models
{
    [Table("purchase_history")]
    public class PurchaseHistory
    {
        [Key]
        [Column("history_id")]
        public int Id { get; set; }

        [Column("history_timestamp")]
        public DateTime HistoryTimestamp { get; set; }

        [Column("product_name")]
        public string ProductName { get; set; } = string.Empty;

        [Column("product_pieces")]
        public int ProductPieces { get; set; }
    }
}