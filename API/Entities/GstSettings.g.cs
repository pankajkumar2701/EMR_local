using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a gstsettings entity with essential details
    /// </summary>
    public class GstSettings
    {
        /// <summary>
        /// TenantId of the GstSettings 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GstSettings 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Category of the GstSettings 
        /// </summary>
        public string? Category { get; set; }
        /// <summary>
        /// Rate of the GstSettings 
        /// </summary>
        public int? Rate { get; set; }
    }
}