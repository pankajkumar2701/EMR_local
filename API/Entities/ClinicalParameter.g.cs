using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a clinicalparameter entity with essential details
    /// </summary>
    public class ClinicalParameter
    {
        /// <summary>
        /// TenantId of the ClinicalParameter 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ClinicalParameter 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the ClinicalParameter 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// InputTypeId of the ClinicalParameter 
        /// </summary>
        public Guid? InputTypeId { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the ClinicalParameter belongs 
        /// </summary>
        public Guid? UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("UomId")]
        public Uom? UomId_Uom { get; set; }
        /// <summary>
        /// Foreign key referencing the UnitType to which the ClinicalParameter belongs 
        /// </summary>
        public Guid? UnitTypeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated UnitType
        /// </summary>
        [ForeignKey("UnitTypeId")]
        public UnitType? UnitTypeId_UnitType { get; set; }
        /// <summary>
        /// Notes of the ClinicalParameter 
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// Suggestion of the ClinicalParameter 
        /// </summary>
        public bool? Suggestion { get; set; }
        /// <summary>
        /// FeatureParameter of the ClinicalParameter 
        /// </summary>
        public bool? FeatureParameter { get; set; }
        /// <summary>
        /// CreatedBy of the ClinicalParameter 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the ClinicalParameter 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ClinicalParameter 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ClinicalParameter 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}