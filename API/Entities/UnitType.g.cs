using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a unittype entity with essential details
    /// </summary>
    public class UnitType
    {
        /// <summary>
        /// TenantId of the UnitType 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the UnitType 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Code of the UnitType 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the UnitType 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Active to which the UnitType belongs 
        /// </summary>
        public Guid? Active { get; set; }

        /// <summary>
        /// Navigation property representing the associated Active
        /// </summary>
        [ForeignKey("Active")]
        public Active? Active_Active { get; set; }
        /// <summary>
        /// CreatedBy of the UnitType 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the UnitType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the UnitType 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the UnitType 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}