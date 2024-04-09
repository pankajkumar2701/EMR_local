using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a stockadjustment entity with essential details
    /// </summary>
    public class StockAdjustment
    {
        /// <summary>
        /// TenantId of the StockAdjustment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockAdjustment 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// ReferenceNo of the StockAdjustment 
        /// </summary>
        public string? ReferenceNo { get; set; }
        /// <summary>
        /// Code of the StockAdjustment 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// AdjustmentDate of the StockAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AdjustmentDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the StockAdjustment belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
    }
}