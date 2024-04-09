using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a medication entity with essential details
    /// </summary>
    public class Medication
    {
        /// <summary>
        /// TenantId of the Medication 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Medication 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Medication 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// ReadyRx of the Medication 
        /// </summary>
        public bool? ReadyRx { get; set; }
        /// <summary>
        /// FormulationCode of the Medication 
        /// </summary>
        public string? FormulationCode { get; set; }
        /// <summary>
        /// OtcDrug of the Medication 
        /// </summary>
        public bool? OtcDrug { get; set; }
        /// <summary>
        /// SystemFavourite of the Medication 
        /// </summary>
        public bool? SystemFavourite { get; set; }
        /// <summary>
        /// Generic of the Medication 
        /// </summary>
        public string? Generic { get; set; }
        /// <summary>
        /// Deleted of the Medication 
        /// </summary>
        public bool? Deleted { get; set; }
        /// <summary>
        /// MedicationType of the Medication 
        /// </summary>
        public int? MedicationType { get; set; }
        /// <summary>
        /// Foreign key referencing the RouteInfo to which the Medication belongs 
        /// </summary>
        public Guid? RouteInfoId { get; set; }

        /// <summary>
        /// Navigation property representing the associated RouteInfo
        /// </summary>
        [ForeignKey("RouteInfoId")]
        public RouteInfo? RouteInfoId_RouteInfo { get; set; }
    }
}