using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EMR_local.Entities
{
    /// <summary> 
    /// Represents a product entity with essential details
    /// </summary>
    public class Product
    {
        /// <summary>
        /// TenantId of the Product 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Product 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// OnlineDefault of the Product 
        /// </summary>
        public bool? OnlineDefault { get; set; }
        /// <summary>
        /// Default of the Product 
        /// </summary>
        public bool? Default { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductCategory to which the Product belongs 
        /// </summary>
        public Guid? ProductCategoryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductCategory
        /// </summary>
        [ForeignKey("ProductCategoryId")]
        public ProductCategory? ProductCategoryId_ProductCategory { get; set; }
        /// <summary>
        /// ProductType of the Product 
        /// </summary>
        public int? ProductType { get; set; }
        /// <summary>
        /// Inventoried of the Product 
        /// </summary>
        public bool? Inventoried { get; set; }
        /// <summary>
        /// HsnCode of the Product 
        /// </summary>
        public string? HsnCode { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductManufacture to which the Product belongs 
        /// </summary>
        public Guid? ProductManufactureId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductManufacture
        /// </summary>
        [ForeignKey("ProductManufactureId")]
        public ProductManufacture? ProductManufactureId_ProductManufacture { get; set; }
        /// <summary>
        /// Description of the Product 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Foreign key referencing the Formulation to which the Product belongs 
        /// </summary>
        public Guid? FormulationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Formulation
        /// </summary>
        [ForeignKey("FormulationId")]
        public Formulation? FormulationId_Formulation { get; set; }
        /// <summary>
        /// ScheduleDrug of the Product 
        /// </summary>
        public int? ScheduleDrug { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductClassification to which the Product belongs 
        /// </summary>
        public Guid? ProductClassificationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductClassification
        /// </summary>
        [ForeignKey("ProductClassificationId")]
        public ProductClassification? ProductClassificationId_ProductClassification { get; set; }
        /// <summary>
        /// LowestUomId of the Product 
        /// </summary>
        public Guid? LowestUomId { get; set; }
        /// <summary>
        /// BaseType of the Product 
        /// </summary>
        public int? BaseType { get; set; }
        /// <summary>
        /// Status of the Product 
        /// </summary>
        public bool? Status { get; set; }
        /// <summary>
        /// ReOrderLevel of the Product 
        /// </summary>
        public int? ReOrderLevel { get; set; }
        /// <summary>
        /// ReOrderQuantity of the Product 
        /// </summary>
        public int? ReOrderQuantity { get; set; }
        /// <summary>
        /// GstCategoryId of the Product 
        /// </summary>
        public Guid? GstCategoryId { get; set; }
        /// <summary>
        /// GstPercentage of the Product 
        /// </summary>
        public int? GstPercentage { get; set; }
        /// <summary>
        /// ReOrderQuantityUomId of the Product 
        /// </summary>
        public Guid? ReOrderQuantityUomId { get; set; }
        /// <summary>
        /// DrugScheduleId of the Product 
        /// </summary>
        public Guid? DrugScheduleId { get; set; }
        /// <summary>
        /// ComponentType of the Product 
        /// </summary>
        public int? ComponentType { get; set; }
        /// <summary>
        /// Foreign key referencing the Investigation to which the Product belongs 
        /// </summary>
        public Guid? InvestigationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Investigation
        /// </summary>
        [ForeignKey("InvestigationId")]
        public Investigation? InvestigationId_Investigation { get; set; }
        /// <summary>
        /// Foreign key referencing the Procedure to which the Product belongs 
        /// </summary>
        public Guid? ProcedureId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Procedure
        /// </summary>
        [ForeignKey("ProcedureId")]
        public Procedure? ProcedureId_Procedure { get; set; }
        /// <summary>
        /// Foreign key referencing the Contact to which the Product belongs 
        /// </summary>
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Contact
        /// </summary>
        [ForeignKey("ContactId")]
        public Contact? ContactId_Contact { get; set; }
        /// <summary>
        /// Foreign key referencing the Medication to which the Product belongs 
        /// </summary>
        public Guid? MedicationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Medication
        /// </summary>
        [ForeignKey("MedicationId")]
        public Medication? MedicationId_Medication { get; set; }
        /// <summary>
        /// Import of the Product 
        /// </summary>
        public bool? Import { get; set; }

        /// <summary>
        /// SellingStartDate of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SellingStartDate { get; set; }

        /// <summary>
        /// SellingEndDate of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SellingEndDate { get; set; }
    }
}