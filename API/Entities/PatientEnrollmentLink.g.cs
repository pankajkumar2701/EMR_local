using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a patientenrollmentlink entity with essential details
    /// </summary>
    public class PatientEnrollmentLink
    {
        /// <summary>
        /// Primary key for the PatientEnrollmentLink 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PatientEnrollmentLink 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// MobileCountryCode of the PatientEnrollmentLink 
        /// </summary>
        public int? MobileCountryCode { get; set; }
        /// <summary>
        /// MobileNumber of the PatientEnrollmentLink 
        /// </summary>
        public string? MobileNumber { get; set; }
        /// <summary>
        /// Link of the PatientEnrollmentLink 
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// Required field ExpiryDateTime of the PatientEnrollmentLink 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ExpiryDateTime { get; set; }
        /// <summary>
        /// Visited of the PatientEnrollmentLink 
        /// </summary>
        public bool? Visited { get; set; }
        /// <summary>
        /// Secret of the PatientEnrollmentLink 
        /// </summary>
        public string? Secret { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientEnrollmentLink belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
    }
}