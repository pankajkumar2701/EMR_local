using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a visitchiefcomplaint entity with essential details
    /// </summary>
    public class VisitChiefComplaint
    {
        /// <summary>
        /// TenantId of the VisitChiefComplaint 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the VisitChiefComplaint 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Code of the VisitChiefComplaint 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the VisitChiefComplaint 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the VisitChiefComplaint 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Summary of the VisitChiefComplaint 
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// FollowupVisit of the VisitChiefComplaint 
        /// </summary>
        public bool? FollowupVisit { get; set; }
        /// <summary>
        /// Foreign key referencing the ChiefComplaint to which the VisitChiefComplaint belongs 
        /// </summary>
        public Guid? ChiefComplaintId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ChiefComplaint
        /// </summary>
        [ForeignKey("ChiefComplaintId")]
        public ChiefComplaint? ChiefComplaintId_ChiefComplaint { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the VisitChiefComplaint belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// CreatedBy of the VisitChiefComplaint 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the VisitChiefComplaint 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the VisitChiefComplaint 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the VisitChiefComplaint 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}