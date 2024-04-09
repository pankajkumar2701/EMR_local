using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a city entity with essential details
    /// </summary>
    public class City
    {
        /// <summary>
        /// TenantId of the City 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the City 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the City 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}