using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a pricelistcomponent entity with essential details
    /// </summary>
    public class PriceListComponent
    {
        /// <summary>
        /// TenantId of the PriceListComponent 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListComponent 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListComponent belongs 
        /// </summary>
        public Guid? PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the PriceListComponent belongs 
        /// </summary>
        public Guid? Location { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("Location")]
        public Location? Location_Location { get; set; }
    }
}