using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a generic entity with essential details
    /// </summary>
    public class Generic
    {
        /// <summary>
        /// TenantId of the Generic 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Generic 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the Generic 
        /// </summary>
        public string? Name { get; set; }
    }
}