using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a goodsreceipt entity with essential details
    /// </summary>
    public class GoodsReceipt
    {
        /// <summary>
        /// Required field TenantId of the GoodsReceipt 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReceipt 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Code of the GoodsReceipt 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReceipt 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// ReceivedDate of the GoodsReceipt 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Supplier of the GoodsReceipt 
        /// </summary>
        public string? Supplier { get; set; }
        /// <summary>
        /// Reason of the GoodsReceipt 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ReferenceNumber of the GoodsReceipt 
        /// </summary>
        public string? ReferenceNumber { get; set; }
        /// <summary>
        /// PurchaseOrderNo of the GoodsReceipt 
        /// </summary>
        public string? PurchaseOrderNo { get; set; }
    }
}