using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a productbatch entity with essential details
    /// </summary>
    public class ProductBatch
    {
        /// <summary>
        /// TenantId of the ProductBatch 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductBatch 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// PurchaseValue of the ProductBatch 
        /// </summary>
        public int? PurchaseValue { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the ProductBatch belongs 
        /// </summary>
        public Guid? ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }
        /// <summary>
        /// BatchNumber of the ProductBatch 
        /// </summary>
        public string? BatchNumber { get; set; }
        /// <summary>
        /// BatchQuantity of the ProductBatch 
        /// </summary>
        public int? BatchQuantity { get; set; }
        /// <summary>
        /// PackReceiptQuantity of the ProductBatch 
        /// </summary>
        public int? PackReceiptQuantity { get; set; }
        /// <summary>
        /// UnitPrice of the ProductBatch 
        /// </summary>
        public int? UnitPrice { get; set; }

        /// <summary>
        /// ExpiryDate of the ProductBatch 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// ManufactureDate of the ProductBatch 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        /// <summary>
        /// AverageCost of the ProductBatch 
        /// </summary>
        public int? AverageCost { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the ProductBatch belongs 
        /// </summary>
        public Guid? Product { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("Product")]
        public Product? Product_Product { get; set; }
    }
}