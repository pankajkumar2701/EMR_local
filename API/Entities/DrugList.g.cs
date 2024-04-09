using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a druglist entity with essential details
    /// </summary>
    public class DrugList
    {
        /// <summary>
        /// Primary key for the DrugList 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the DrugList 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the DrugList 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Brand of the DrugList 
        /// </summary>
        public bool? Brand { get; set; }
        /// <summary>
        /// Generic of the DrugList 
        /// </summary>
        public bool? Generic { get; set; }
        /// <summary>
        /// FileName of the DrugList 
        /// </summary>
        public string? FileName { get; set; }
    }
}