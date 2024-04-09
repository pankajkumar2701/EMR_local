using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a purchaseorder entity with essential details
    /// </summary>
    public class PurchaseOrder
    {
        /// <summary>
        /// Primary key for the PurchaseOrder 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PurchaseOrder 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Code of the PurchaseOrder 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// PurchaseOrderDate of the PurchaseOrder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PurchaseOrderDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the PurchaseOrder belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// OrderBy of the PurchaseOrder 
        /// </summary>
        public Guid? OrderBy { get; set; }

        /// <summary>
        /// ExpectedDeliveryDate of the PurchaseOrder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// CompletedDate of the PurchaseOrder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// InUsed of the PurchaseOrder 
        /// </summary>
        public bool? InUsed { get; set; }
        /// <summary>
        /// ReceivedStatus of the PurchaseOrder 
        /// </summary>
        public int? ReceivedStatus { get; set; }
        /// <summary>
        /// ReferenceNumber of the PurchaseOrder 
        /// </summary>
        public string? ReferenceNumber { get; set; }
        /// <summary>
        /// OrderAmount of the PurchaseOrder 
        /// </summary>
        public int? OrderAmount { get; set; }
        /// <summary>
        /// TotalAttachment of the PurchaseOrder 
        /// </summary>
        public int? TotalAttachment { get; set; }
    }
}