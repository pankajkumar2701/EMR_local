using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a visitdiagnosis entity with essential details
    /// </summary>
    public class VisitDiagnosis
    {
        /// <summary>
        /// TenantId of the VisitDiagnosis 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the VisitDiagnosis 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the VisitDiagnosis 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the VisitDiagnosis 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Summary of the VisitDiagnosis 
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// FollowupVisit of the VisitDiagnosis 
        /// </summary>
        public bool? FollowupVisit { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the VisitDiagnosis belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// IcdCode of the VisitDiagnosis 
        /// </summary>
        public string? IcdCode { get; set; }
        /// <summary>
        /// IcdName of the VisitDiagnosis 
        /// </summary>
        public string? IcdName { get; set; }
        /// <summary>
        /// CreatedBy of the VisitDiagnosis 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the VisitDiagnosis 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the VisitDiagnosis 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the VisitDiagnosis 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}