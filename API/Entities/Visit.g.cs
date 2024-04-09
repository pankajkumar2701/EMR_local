using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a visit entity with essential details
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// TenantId of the Visit 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Visit 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Code of the Visit 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the Visit 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the Visit belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }

        /// <summary>
        /// VisitStartDate of the Visit 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? VisitStartDate { get; set; }

        /// <summary>
        /// VisitCloseDate of the Visit 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? VisitCloseDate { get; set; }

        /// <summary>
        /// PreviousVisitDate of the Visit 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PreviousVisitDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the Visit belongs 
        /// </summary>
        public Guid? PreviousVisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("PreviousVisitId")]
        public Visit? PreviousVisitId_Visit { get; set; }
        /// <summary>
        /// PrescriptionConverted of the Visit 
        /// </summary>
        public bool? PrescriptionConverted { get; set; }
        /// <summary>
        /// VisitAttending of the Visit 
        /// </summary>
        public bool? VisitAttending { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Visit belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the Contact to which the Visit belongs 
        /// </summary>
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Contact
        /// </summary>
        [ForeignKey("ContactId")]
        public Contact? ContactId_Contact { get; set; }
        /// <summary>
        /// CreditVisit of the Visit 
        /// </summary>
        public bool? CreditVisit { get; set; }
        /// <summary>
        /// CoverCategoryId of the Visit 
        /// </summary>
        public string? CoverCategoryId { get; set; }
        /// <summary>
        /// MedicationLayout of the Visit 
        /// </summary>
        public int? MedicationLayout { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitType to which the Visit belongs 
        /// </summary>
        public Guid? VisitType { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitType
        /// </summary>
        [ForeignKey("VisitType")]
        public VisitType? VisitType_VisitType { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitMode to which the Visit belongs 
        /// </summary>
        public Guid? VisitMode { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitMode
        /// </summary>
        [ForeignKey("VisitMode")]
        public VisitMode? VisitMode_VisitMode { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the Visit belongs 
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("DoctorId")]
        public Doctor? DoctorId_Doctor { get; set; }
    }
}