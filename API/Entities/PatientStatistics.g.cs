using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a patientstatistics entity with essential details
    /// </summary>
    public class PatientStatistics
    {
        /// <summary>
        /// TenantId of the PatientStatistics 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PatientStatistics 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientStatistics belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// VisitCount of the PatientStatistics 
        /// </summary>
        public int? VisitCount { get; set; }
        /// <summary>
        /// ApponumericmentCount of the PatientStatistics 
        /// </summary>
        public int? ApponumericmentCount { get; set; }
    }
}