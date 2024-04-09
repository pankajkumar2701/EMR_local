using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a state entity with essential details
    /// </summary>
    public class State
    {
        /// <summary>
        /// TenantId of the State 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the State 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the State 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// CreatedBy of the State 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the State 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the State 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the State 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}