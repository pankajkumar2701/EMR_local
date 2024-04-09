using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a patient entity with essential details
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// TenantId of the Patient 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Patient 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Code of the Patient 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Required field Name of the Patient 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Title to which the Patient belongs 
        /// </summary>
        public Guid? TitleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Title
        /// </summary>
        [ForeignKey("TitleId")]
        public Title? TitleId_Title { get; set; }

        /// <summary>
        /// Required field FirstName of the Patient 
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// MiddleName of the Patient 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the Patient 
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Foreign key referencing the Gender to which the Patient belongs 
        /// </summary>
        [Required]
        public Guid GenderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Gender
        /// </summary>
        [ForeignKey("GenderId")]
        public Gender? GenderId_Gender { get; set; }

        /// <summary>
        /// Required field Dob of the Patient 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Dob { get; set; }

        /// <summary>
        /// Required field Age of the Patient 
        /// </summary>
        [Required]
        public int Age { get; set; }
        /// <summary>
        /// DobIsApproximate of the Patient 
        /// </summary>
        public bool? DobIsApproximate { get; set; }
        /// <summary>
        /// NationalIdNumber of the Patient 
        /// </summary>
        public string? NationalIdNumber { get; set; }

        /// <summary>
        /// RegisteredOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RegisteredOn { get; set; }

        /// <summary>
        /// DateOfDeath of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateOfDeath { get; set; }
        /// <summary>
        /// ReasonOfDeath of the Patient 
        /// </summary>
        public string? ReasonOfDeath { get; set; }
        /// <summary>
        /// IsDeceased of the Patient 
        /// </summary>
        public bool? IsDeceased { get; set; }

        /// <summary>
        /// Required field Mobile of the Patient 
        /// </summary>
        [Required]
        public string Mobile { get; set; }
        /// <summary>
        /// Email of the Patient 
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// LastVisitDate of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastVisitDate { get; set; }
        /// <summary>
        /// EntityCode of the Patient 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Patient 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// Foreign key referencing the BloodGroup to which the Patient belongs 
        /// </summary>
        public Guid? BloodGroup { get; set; }

        /// <summary>
        /// Navigation property representing the associated BloodGroup
        /// </summary>
        [ForeignKey("BloodGroup")]
        public BloodGroup? BloodGroup_BloodGroup { get; set; }
        /// <summary>
        /// FileNumber of the Patient 
        /// </summary>
        public string? FileNumber { get; set; }
        /// <summary>
        /// AlternateMobile of the Patient 
        /// </summary>
        public string? AlternateMobile { get; set; }
        /// <summary>
        /// IsDisabled of the Patient 
        /// </summary>
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// MobileNumberCountryCode of the Patient 
        /// </summary>
        public int? MobileNumberCountryCode { get; set; }
        /// <summary>
        /// AlternateNumberCountryCode of the Patient 
        /// </summary>
        public int? AlternateNumberCountryCode { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Patient belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// PatientNotes of the Patient 
        /// </summary>
        public string? PatientNotes { get; set; }
        /// <summary>
        /// IsVip of the Patient 
        /// </summary>
        public bool? IsVip { get; set; }
        /// <summary>
        /// IsConfidential of the Patient 
        /// </summary>
        public bool? IsConfidential { get; set; }
        /// <summary>
        /// AddressLine1 of the Patient 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Patient 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// Foreign key referencing the State to which the Patient belongs 
        /// </summary>
        public Guid? StateId { get; set; }

        /// <summary>
        /// Navigation property representing the associated State
        /// </summary>
        [ForeignKey("StateId")]
        public State? StateId_State { get; set; }
        /// <summary>
        /// Foreign key referencing the City to which the Patient belongs 
        /// </summary>
        public Guid? CityId { get; set; }

        /// <summary>
        /// Navigation property representing the associated City
        /// </summary>
        [ForeignKey("CityId")]
        public City? CityId_City { get; set; }
        /// <summary>
        /// PostalCode of the Patient 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the Patient belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
    }
}