using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a doctorinvestigation entity with essential details
    /// </summary>
    public class DoctorInvestigation
    {
        /// <summary>
        /// TenantId of the DoctorInvestigation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DoctorInvestigation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Sequence of the DoctorInvestigation 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// InvestigationProfile of the DoctorInvestigation 
        /// </summary>
        public bool? InvestigationProfile { get; set; }
        /// <summary>
        /// Favourite of the DoctorInvestigation 
        /// </summary>
        public bool? Favourite { get; set; }

        /// <summary>
        /// Required field Name of the DoctorInvestigation 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Code of the DoctorInvestigation 
        /// </summary>
        [Required]
        public string Code { get; set; }
    }
}