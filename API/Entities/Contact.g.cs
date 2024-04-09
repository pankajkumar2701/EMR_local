using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a contact entity with essential details
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// TenantId of the Contact 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Contact 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Contact 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Mobile of the Contact 
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Email of the Contact 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// JobTitle of the Contact 
        /// </summary>
        public string? JobTitle { get; set; }
        /// <summary>
        /// CreatedBy of the Contact 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Contact 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Contact 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Contact 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}