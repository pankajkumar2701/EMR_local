using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a visitinvestigation entity with essential details
    /// </summary>
    public class VisitInvestigation
    {
        /// <summary>
        /// TenantId of the VisitInvestigation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the VisitInvestigation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Sequence of the VisitInvestigation 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Summary of the VisitInvestigation 
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// Foreign key referencing the DoctorInvestigation to which the VisitInvestigation belongs 
        /// </summary>
        public Guid? DoctorInvestigationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DoctorInvestigation
        /// </summary>
        [ForeignKey("DoctorInvestigationId")]
        public DoctorInvestigation? DoctorInvestigationId_DoctorInvestigation { get; set; }
        /// <summary>
        /// DoctorInvestigationProfileItemId of the VisitInvestigation 
        /// </summary>
        public Guid? DoctorInvestigationProfileItemId { get; set; }
        /// <summary>
        /// DoctorInvestigationProfileName of the VisitInvestigation 
        /// </summary>
        public string? DoctorInvestigationProfileName { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the VisitInvestigation belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the VisitInvestigation belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Investigation to which the VisitInvestigation belongs 
        /// </summary>
        public Guid? InvestigationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Investigation
        /// </summary>
        [ForeignKey("InvestigationId")]
        public Investigation? InvestigationId_Investigation { get; set; }
        /// <summary>
        /// InvestigationProfileId of the VisitInvestigation 
        /// </summary>
        public Guid? InvestigationProfileId { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the VisitInvestigation belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// ProductName of the VisitInvestigation 
        /// </summary>
        public string? ProductName { get; set; }
    }
}