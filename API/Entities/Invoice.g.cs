using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a invoice entity with essential details
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// TenantId of the Invoice 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Invoice 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the Invoice 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Code of the Invoice 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the Invoice belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the Invoice belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// GrossAmount of the Invoice 
        /// </summary>
        public int? GrossAmount { get; set; }
        /// <summary>
        /// NetAmount of the Invoice 
        /// </summary>
        public int? NetAmount { get; set; }
        /// <summary>
        /// DiscountAmount of the Invoice 
        /// </summary>
        public int? DiscountAmount { get; set; }
        /// <summary>
        /// DueAmount of the Invoice 
        /// </summary>
        public int? DueAmount { get; set; }
        /// <summary>
        /// CoPayAmount of the Invoice 
        /// </summary>
        public int? CoPayAmount { get; set; }
        /// <summary>
        /// PayorAmount of the Invoice 
        /// </summary>
        public int? PayorAmount { get; set; }

        /// <summary>
        /// InvoiceDate of the Invoice 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// DueDate of the Invoice 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// IsVoid of the Invoice 
        /// </summary>
        public bool? IsVoid { get; set; }
        /// <summary>
        /// InvoiceType of the Invoice 
        /// </summary>
        public int? InvoiceType { get; set; }
        /// <summary>
        /// PayorType of the Invoice 
        /// </summary>
        public int? PayorType { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the Invoice belongs 
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("DoctorId")]
        public Doctor? DoctorId_Doctor { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Invoice belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
    }
}