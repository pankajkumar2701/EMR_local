using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a chiefcomplaint entity with essential details
    /// </summary>
    public class ChiefComplaint
    {
        /// <summary>
        /// TenantId of the ChiefComplaint 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ChiefComplaint 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Code of the ChiefComplaint 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the ChiefComplaint 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the ChiefComplaint 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Favourite of the ChiefComplaint 
        /// </summary>
        public bool? Favourite { get; set; }
        /// <summary>
        /// IsDeleted of the ChiefComplaint 
        /// </summary>
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// IsAbnormal of the ChiefComplaint 
        /// </summary>
        public bool? IsAbnormal { get; set; }
        /// <summary>
        /// CreatedBy of the ChiefComplaint 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the ChiefComplaint 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ChiefComplaint 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ChiefComplaint 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}