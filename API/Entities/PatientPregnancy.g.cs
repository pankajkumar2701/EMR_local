using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a patientpregnancy entity with essential details
    /// </summary>
    public class PatientPregnancy
    {
        /// <summary>
        /// TenantId of the PatientPregnancy 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PatientPregnancy 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientPregnancy belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the PatientPregnancy belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// IsPregnant of the PatientPregnancy 
        /// </summary>
        public bool? IsPregnant { get; set; }
        /// <summary>
        /// Gravidity of the PatientPregnancy 
        /// </summary>
        public int? Gravidity { get; set; }
        /// <summary>
        /// Parity of the PatientPregnancy 
        /// </summary>
        public int? Parity { get; set; }
        /// <summary>
        /// Miscarriage of the PatientPregnancy 
        /// </summary>
        public int? Miscarriage { get; set; }
        /// <summary>
        /// Termination of the PatientPregnancy 
        /// </summary>
        public int? Termination { get; set; }

        /// <summary>
        /// EddDate of the PatientPregnancy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EddDate { get; set; }

        /// <summary>
        /// LmpDate of the PatientPregnancy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LmpDate { get; set; }
        /// <summary>
        /// Notes of the PatientPregnancy 
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// PreferenceType of the PatientPregnancy 
        /// </summary>
        public int? PreferenceType { get; set; }
    }
}