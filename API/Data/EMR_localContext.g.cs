using Microsoft.EntityFrameworkCore;
using EMR_local.Entities;

namespace EMR_local.Data
{
    public class EMR_localContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GFUVFUP;Initial Catalog=T754323_EMR_local;Persist Security Info=True;user id=pankazz;password=123456;Integrated Security=false;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(a => a.Id);
            modelBuilder.Entity<UserToken>().HasKey(a => a.Id);
            modelBuilder.Entity<RoleEntitlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Entity>().HasKey(a => a.Id);
            modelBuilder.Entity<Tenant>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<Role>().HasKey(a => a.Id);
            modelBuilder.Entity<UnitType>().HasKey(a => a.Id);
            modelBuilder.Entity<Active>().HasKey(a => a.Id);
            modelBuilder.Entity<Contact>().HasKey(a => a.Id);
            modelBuilder.Entity<Allergy>().HasKey(a => a.Id);
            modelBuilder.Entity<Patient>().HasKey(a => a.Id);
            modelBuilder.Entity<Gender>().HasKey(a => a.Id);
            modelBuilder.Entity<Title>().HasKey(a => a.Id);
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
            modelBuilder.Entity<Country>().HasKey(a => a.Id);
            modelBuilder.Entity<Language>().HasKey(a => a.Id);
            modelBuilder.Entity<Currency>().HasKey(a => a.Id);
            modelBuilder.Entity<Location>().HasKey(a => a.Id);
            modelBuilder.Entity<Membership>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientNotes>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientAllergy>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientStatistics>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientComorbidity>().HasKey(a => a.Id);
            modelBuilder.Entity<Comorbidity>().HasKey(a => a.Id);
            modelBuilder.Entity<ContactMember>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientPayor>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientLifeStyle>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientEnrollmentLink>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientHospitalisationHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<PregnancyHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientMedicalHistoryNote>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientPregnancy>().HasKey(a => a.Id);
            modelBuilder.Entity<Visit>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitMedicalCertificate>().HasKey(a => a.Id);
            modelBuilder.Entity<Invoice>().HasKey(a => a.Id);
            modelBuilder.Entity<InvoiceLine>().HasKey(a => a.Id);
            modelBuilder.Entity<InvoiceFile>().HasKey(a => a.Id);
            modelBuilder.Entity<Dispense>().HasKey(a => a.Id);
            modelBuilder.Entity<DispenseActivityHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<DispenseItem>().HasKey(a => a.Id);
            modelBuilder.Entity<PatientPharmacyQueue>().HasKey(a => a.Id);
            modelBuilder.Entity<DispenseItemDosage>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentGateway>().HasKey(a => a.Id);
            modelBuilder.Entity<Notification>().HasKey(a => a.Id);
            modelBuilder.Entity<AppointmentReminderLog>().HasKey(a => a.Id);
            modelBuilder.Entity<AccountSettlement>().HasKey(a => a.Id);
            modelBuilder.Entity<AppointmentService>().HasKey(a => a.Id);
            modelBuilder.Entity<Payment>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentMode>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitInvestigation>().HasKey(a => a.Id);
            modelBuilder.Entity<DoctorInvestigation>().HasKey(a => a.Id);
            modelBuilder.Entity<Investigation>().HasKey(a => a.Id);
            modelBuilder.Entity<Product>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductBatch>().HasKey(a => a.Id);
            modelBuilder.Entity<FinanceSetting>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductUom>().HasKey(a => a.Id);
            modelBuilder.Entity<GstSettings>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductClassification>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductManufacture>().HasKey(a => a.Id);
            modelBuilder.Entity<Formulation>().HasKey(a => a.Id);
            modelBuilder.Entity<Medication>().HasKey(a => a.Id);
            modelBuilder.Entity<DrugList>().HasKey(a => a.Id);
            modelBuilder.Entity<DrugListItems>().HasKey(a => a.Id);
            modelBuilder.Entity<MedicationComposition>().HasKey(a => a.Id);
            modelBuilder.Entity<Generic>().HasKey(a => a.Id);
            modelBuilder.Entity<MedicationDosage>().HasKey(a => a.Id);
            modelBuilder.Entity<RouteInfo>().HasKey(a => a.Id);
            modelBuilder.Entity<Procedure>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitGuideline>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitDiagnosis>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitType>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitMode>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitChiefComplaint>().HasKey(a => a.Id);
            modelBuilder.Entity<ChiefComplaint>().HasKey(a => a.Id);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<ClinicalParameter>().HasKey(a => a.Id);
            modelBuilder.Entity<ClinicalParameterValue>().HasKey(a => a.Id);
            modelBuilder.Entity<Uom>().HasKey(a => a.Id);
            modelBuilder.Entity<Doctor>().HasKey(a => a.Id);
            modelBuilder.Entity<Appointment>().HasKey(a => a.Id);
            modelBuilder.Entity<TokenManagement>().HasKey(a => a.Id);
            modelBuilder.Entity<DayVisit>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceipt>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptPurchaseOrderRelation>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptFile>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptActivityHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReceiptItem>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReturn>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReturnItem>().HasKey(a => a.Id);
            modelBuilder.Entity<GoodsReturnFile>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceList>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceListVersion>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceListItem>().HasKey(a => a.Id);
            modelBuilder.Entity<PriceListComponent>().HasKey(a => a.Id);
            modelBuilder.Entity<PurchaseOrder>().HasKey(a => a.Id);
            modelBuilder.Entity<PurchaseOrderLine>().HasKey(a => a.Id);
            modelBuilder.Entity<PurchaseOrderFile>().HasKey(a => a.Id);
            modelBuilder.Entity<Requisition>().HasKey(a => a.Id);
            modelBuilder.Entity<RequisitionLine>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustment>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustmentItem>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustmentFile>().HasKey(a => a.Id);
            modelBuilder.Entity<State>().HasKey(a => a.Id);
            modelBuilder.Entity<City>().HasKey(a => a.Id);
            modelBuilder.Entity<BloodGroup>().HasKey(a => a.Id);
            modelBuilder.Entity<Specialisation>().HasKey(a => a.Id);
            modelBuilder.Entity<Qualification>().HasKey(a => a.Id);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UserToken>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserToken>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.EntityId_Entity).WithMany().HasForeignKey(c => c.EntityId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Entity>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<User>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Role>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UnitType>().HasOne(a => a.Active_Active).WithMany().HasForeignKey(c => c.Active);
            modelBuilder.Entity<Allergy>().HasOne(a => a.Active_Active).WithMany().HasForeignKey(c => c.Active);
            modelBuilder.Entity<Patient>().HasOne(a => a.TitleId_Title).WithMany().HasForeignKey(c => c.TitleId);
            modelBuilder.Entity<Patient>().HasOne(a => a.GenderId_Gender).WithMany().HasForeignKey(c => c.GenderId);
            modelBuilder.Entity<Patient>().HasOne(a => a.BloodGroup_BloodGroup).WithMany().HasForeignKey(c => c.BloodGroup);
            modelBuilder.Entity<Patient>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Patient>().HasOne(a => a.StateId_State).WithMany().HasForeignKey(c => c.StateId);
            modelBuilder.Entity<Patient>().HasOne(a => a.CityId_City).WithMany().HasForeignKey(c => c.CityId);
            modelBuilder.Entity<Patient>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Address>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Address>().HasOne(a => a.City_City).WithMany().HasForeignKey(c => c.City);
            modelBuilder.Entity<Address>().HasOne(a => a.State_State).WithMany().HasForeignKey(c => c.State);
            modelBuilder.Entity<Country>().HasOne(a => a.CurrencyId_Currency).WithMany().HasForeignKey(c => c.CurrencyId);
            modelBuilder.Entity<Country>().HasOne(a => a.LanguageId_Language).WithMany().HasForeignKey(c => c.LanguageId);
            modelBuilder.Entity<Location>().HasOne(a => a.CityId_City).WithMany().HasForeignKey(c => c.CityId);
            modelBuilder.Entity<Location>().HasOne(a => a.StateId_State).WithMany().HasForeignKey(c => c.StateId);
            modelBuilder.Entity<Location>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<PatientNotes>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientAllergy>().HasOne(a => a.Allergy_Allergy).WithMany().HasForeignKey(c => c.Allergy);
            modelBuilder.Entity<PatientAllergy>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientAllergy>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<PatientStatistics>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientComorbidity>().HasOne(a => a.ComorbidityId_Comorbidity).WithMany().HasForeignKey(c => c.ComorbidityId);
            modelBuilder.Entity<PatientComorbidity>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.ContactId_Contact).WithMany().HasForeignKey(c => c.ContactId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.TitleId_Title).WithMany().HasForeignKey(c => c.TitleId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.GenderId_Gender).WithMany().HasForeignKey(c => c.GenderId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.StateId_State).WithMany().HasForeignKey(c => c.StateId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.CityId_City).WithMany().HasForeignKey(c => c.CityId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<ContactMember>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<PatientPayor>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPayor>().HasOne(a => a.ContactId_Contact).WithMany().HasForeignKey(c => c.ContactId);
            modelBuilder.Entity<PatientLifeStyle>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientLifeStyle>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<PatientEnrollmentLink>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientHospitalisationHistory>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientHospitalisationHistory>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<PregnancyHistory>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientMedicalHistoryNote>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPregnancy>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPregnancy>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Visit>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Visit>().HasOne(a => a.PreviousVisitId_Visit).WithMany().HasForeignKey(c => c.PreviousVisitId);
            modelBuilder.Entity<Visit>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<Visit>().HasOne(a => a.ContactId_Contact).WithMany().HasForeignKey(c => c.ContactId);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitType_VisitType).WithMany().HasForeignKey(c => c.VisitType);
            modelBuilder.Entity<Visit>().HasOne(a => a.VisitMode_VisitMode).WithMany().HasForeignKey(c => c.VisitMode);
            modelBuilder.Entity<Visit>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitMedicalCertificate>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<InvoiceLine>().HasOne(a => a.GstSettingsId_GstSettings).WithMany().HasForeignKey(c => c.GstSettingsId);
            modelBuilder.Entity<InvoiceFile>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Dispense>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<DispenseActivityHistory>().HasOne(a => a.DispenseId_Dispense).WithMany().HasForeignKey(c => c.DispenseId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.DispenseId_Dispense).WithMany().HasForeignKey(c => c.DispenseId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<DispenseItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<PatientPharmacyQueue>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PatientPharmacyQueue>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<PatientPharmacyQueue>().HasOne(a => a.DispenseId_Dispense).WithMany().HasForeignKey(c => c.DispenseId);
            modelBuilder.Entity<DispenseItemDosage>().HasOne(a => a.DispenseItemId_DispenseItem).WithMany().HasForeignKey(c => c.DispenseItemId);
            modelBuilder.Entity<DispenseItemDosage>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<PaymentGateway>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Notification>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AppointmentReminderLog>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AccountSettlement>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AccountSettlement>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<AccountSettlement>().HasOne(a => a.Currency_Currency).WithMany().HasForeignKey(c => c.Currency);
            modelBuilder.Entity<AppointmentService>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<AppointmentService>().HasOne(a => a.Service_Product).WithMany().HasForeignKey(c => c.Service);
            modelBuilder.Entity<Payment>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Payment>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Payment>().HasOne(a => a.PaymentModeId_PaymentMode).WithMany().HasForeignKey(c => c.PaymentModeId);
            modelBuilder.Entity<Payment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.DoctorInvestigationId_DoctorInvestigation).WithMany().HasForeignKey(c => c.DoctorInvestigationId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.InvestigationId_Investigation).WithMany().HasForeignKey(c => c.InvestigationId);
            modelBuilder.Entity<VisitInvestigation>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<Investigation>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductCategoryId_ProductCategory).WithMany().HasForeignKey(c => c.ProductCategoryId);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductManufactureId_ProductManufacture).WithMany().HasForeignKey(c => c.ProductManufactureId);
            modelBuilder.Entity<Product>().HasOne(a => a.FormulationId_Formulation).WithMany().HasForeignKey(c => c.FormulationId);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductClassificationId_ProductClassification).WithMany().HasForeignKey(c => c.ProductClassificationId);
            modelBuilder.Entity<Product>().HasOne(a => a.InvestigationId_Investigation).WithMany().HasForeignKey(c => c.InvestigationId);
            modelBuilder.Entity<Product>().HasOne(a => a.ProcedureId_Procedure).WithMany().HasForeignKey(c => c.ProcedureId);
            modelBuilder.Entity<Product>().HasOne(a => a.ContactId_Contact).WithMany().HasForeignKey(c => c.ContactId);
            modelBuilder.Entity<Product>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<ProductBatch>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<ProductBatch>().HasOne(a => a.Product_Product).WithMany().HasForeignKey(c => c.Product);
            modelBuilder.Entity<FinanceSetting>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<ProductUom>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<ProductUom>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<Medication>().HasOne(a => a.RouteInfoId_RouteInfo).WithMany().HasForeignKey(c => c.RouteInfoId);
            modelBuilder.Entity<DrugListItems>().HasOne(a => a.DrugListId_DrugList).WithMany().HasForeignKey(c => c.DrugListId);
            modelBuilder.Entity<DrugListItems>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<MedicationComposition>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<MedicationComposition>().HasOne(a => a.GenericId_Generic).WithMany().HasForeignKey(c => c.GenericId);
            modelBuilder.Entity<MedicationComposition>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<MedicationDosage>().HasOne(a => a.MedicationId_Medication).WithMany().HasForeignKey(c => c.MedicationId);
            modelBuilder.Entity<MedicationDosage>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<Procedure>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.ClinicalParameterId_ClinicalParameter).WithMany().HasForeignKey(c => c.ClinicalParameterId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.ClinicalParameterValueId_ClinicalParameterValue).WithMany().HasForeignKey(c => c.ClinicalParameterValueId);
            modelBuilder.Entity<VisitVitalTemplateParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<VisitGuideline>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitGuideline>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<VisitDiagnosis>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.VisitDiagnosisId_VisitDiagnosis).WithMany().HasForeignKey(c => c.VisitDiagnosisId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.ClinicalParameterId_ClinicalParameter).WithMany().HasForeignKey(c => c.ClinicalParameterId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.ClinicalParameterValueId_ClinicalParameterValue).WithMany().HasForeignKey(c => c.ClinicalParameterValueId);
            modelBuilder.Entity<VisitDiagnosisParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<VisitChiefComplaint>().HasOne(a => a.ChiefComplaintId_ChiefComplaint).WithMany().HasForeignKey(c => c.ChiefComplaintId);
            modelBuilder.Entity<VisitChiefComplaint>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.VisitChiefComplaint_VisitChiefComplaint).WithMany().HasForeignKey(c => c.VisitChiefComplaint);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.ClinicalParameterId_ClinicalParameter).WithMany().HasForeignKey(c => c.ClinicalParameterId);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.ClinicalParameterValueId_ClinicalParameterValue).WithMany().HasForeignKey(c => c.ClinicalParameterValueId);
            modelBuilder.Entity<VisitChiefComplaintParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<ClinicalParameter>().HasOne(a => a.UomId_Uom).WithMany().HasForeignKey(c => c.UomId);
            modelBuilder.Entity<ClinicalParameter>().HasOne(a => a.UnitTypeId_UnitType).WithMany().HasForeignKey(c => c.UnitTypeId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.TitleId_Title).WithMany().HasForeignKey(c => c.TitleId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.OfficialAddressId_Address).WithMany().HasForeignKey(c => c.OfficialAddressId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.LanguageId_Language).WithMany().HasForeignKey(c => c.LanguageId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.GenderId_Gender).WithMany().HasForeignKey(c => c.GenderId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.Qualifications_Qualification).WithMany().HasForeignKey(c => c.Qualifications);
            modelBuilder.Entity<Doctor>().HasOne(a => a.Specialisations_Specialisation).WithMany().HasForeignKey(c => c.Specialisations);
            modelBuilder.Entity<Doctor>().HasOne(a => a.StateId_State).WithMany().HasForeignKey(c => c.StateId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.CityId_City).WithMany().HasForeignKey(c => c.CityId);
            modelBuilder.Entity<Doctor>().HasOne(a => a.CountryId_Country).WithMany().HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<Appointment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<TokenManagement>().HasOne(a => a.DayVisitId_DayVisit).WithMany().HasForeignKey(c => c.DayVisitId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.DoctorId_Doctor).WithMany().HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.VisitId_Visit).WithMany().HasForeignKey(c => c.VisitId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.AppointmentId_Appointment).WithMany().HasForeignKey(c => c.AppointmentId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<DayVisit>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<GoodsReceipt>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<GoodsReceiptPurchaseOrderRelation>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptPurchaseOrderRelation>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<GoodsReceiptFile>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptActivityHistory>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<GoodsReceiptItem>().HasOne(a => a.PurchaseOrderLineId_PurchaseOrderLine).WithMany().HasForeignKey(c => c.PurchaseOrderLineId);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<GoodsReturn>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.GoodsReturnId_GoodsReturn).WithMany().HasForeignKey(c => c.GoodsReturnId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.GoodsReceiptItemId_GoodsReceiptItem).WithMany().HasForeignKey(c => c.GoodsReceiptItemId);
            modelBuilder.Entity<GoodsReturnItem>().HasOne(a => a.ProductUom_ProductUom).WithMany().HasForeignKey(c => c.ProductUom);
            modelBuilder.Entity<GoodsReturnFile>().HasOne(a => a.GoodsReturnId_GoodsReturn).WithMany().HasForeignKey(c => c.GoodsReturnId);
            modelBuilder.Entity<PriceListVersion>().HasOne(a => a.PriceListId_PriceList).WithMany().HasForeignKey(c => c.PriceListId);
            modelBuilder.Entity<PriceListItem>().HasOne(a => a.PriceListId_PriceList).WithMany().HasForeignKey(c => c.PriceListId);
            modelBuilder.Entity<PriceListItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<PriceListItem>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<PriceListComponent>().HasOne(a => a.PriceListId_PriceList).WithMany().HasForeignKey(c => c.PriceListId);
            modelBuilder.Entity<PriceListComponent>().HasOne(a => a.Location_Location).WithMany().HasForeignKey(c => c.Location);
            modelBuilder.Entity<PurchaseOrder>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.RequisitionId_Requisition).WithMany().HasForeignKey(c => c.RequisitionId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.RequisitionLineId_RequisitionLine).WithMany().HasForeignKey(c => c.RequisitionLineId);
            modelBuilder.Entity<PurchaseOrderLine>().HasOne(a => a.GoodsReceiptId_GoodsReceipt).WithMany().HasForeignKey(c => c.GoodsReceiptId);
            modelBuilder.Entity<PurchaseOrderFile>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<Requisition>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.RequisitionId_Requisition).WithMany().HasForeignKey(c => c.RequisitionId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.PurchaseOrderId_PurchaseOrder).WithMany().HasForeignKey(c => c.PurchaseOrderId);
            modelBuilder.Entity<RequisitionLine>().HasOne(a => a.PurchaseOrderLineId_PurchaseOrderLine).WithMany().HasForeignKey(c => c.PurchaseOrderLineId);
            modelBuilder.Entity<StockAdjustment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.StockAdjustmentId_StockAdjustment).WithMany().HasForeignKey(c => c.StockAdjustmentId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.ProductBatchId_ProductBatch).WithMany().HasForeignKey(c => c.ProductBatchId);
            modelBuilder.Entity<StockAdjustmentItem>().HasOne(a => a.ProductUomId_ProductUom).WithMany().HasForeignKey(c => c.ProductUomId);
            modelBuilder.Entity<StockAdjustmentFile>().HasOne(a => a.StockAdjustmentId_StockAdjustment).WithMany().HasForeignKey(c => c.StockAdjustmentId);
        }

        public DbSet<UserInRole> UserInRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<RoleEntitlement> RoleEntitlement { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UnitType> UnitType { get; set; }
        public DbSet<Active> Active { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Allergy> Allergy { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Membership> Membership { get; set; }
        public DbSet<PatientNotes> PatientNotes { get; set; }
        public DbSet<PatientAllergy> PatientAllergy { get; set; }
        public DbSet<PatientStatistics> PatientStatistics { get; set; }
        public DbSet<PatientCategory> PatientCategory { get; set; }
        public DbSet<PatientComorbidity> PatientComorbidity { get; set; }
        public DbSet<Comorbidity> Comorbidity { get; set; }
        public DbSet<ContactMember> ContactMember { get; set; }
        public DbSet<PatientPayor> PatientPayor { get; set; }
        public DbSet<PatientLifeStyle> PatientLifeStyle { get; set; }
        public DbSet<PatientEnrollmentLink> PatientEnrollmentLink { get; set; }
        public DbSet<PatientHospitalisationHistory> PatientHospitalisationHistory { get; set; }
        public DbSet<PregnancyHistory> PregnancyHistory { get; set; }
        public DbSet<PatientMedicalHistoryNote> PatientMedicalHistoryNote { get; set; }
        public DbSet<PatientPregnancy> PatientPregnancy { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<VisitMedicalCertificate> VisitMedicalCertificate { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceLine> InvoiceLine { get; set; }
        public DbSet<InvoiceFile> InvoiceFile { get; set; }
        public DbSet<Dispense> Dispense { get; set; }
        public DbSet<DispenseActivityHistory> DispenseActivityHistory { get; set; }
        public DbSet<DispenseItem> DispenseItem { get; set; }
        public DbSet<PatientPharmacyQueue> PatientPharmacyQueue { get; set; }
        public DbSet<DispenseItemDosage> DispenseItemDosage { get; set; }
        public DbSet<PaymentGateway> PaymentGateway { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<AppointmentReminderLog> AppointmentReminderLog { get; set; }
        public DbSet<AccountSettlement> AccountSettlement { get; set; }
        public DbSet<AppointmentService> AppointmentService { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentMode> PaymentMode { get; set; }
        public DbSet<VisitInvestigation> VisitInvestigation { get; set; }
        public DbSet<DoctorInvestigation> DoctorInvestigation { get; set; }
        public DbSet<Investigation> Investigation { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductBatch> ProductBatch { get; set; }
        public DbSet<FinanceSetting> FinanceSetting { get; set; }
        public DbSet<ProductUom> ProductUom { get; set; }
        public DbSet<GstSettings> GstSettings { get; set; }
        public DbSet<ProductClassification> ProductClassification { get; set; }
        public DbSet<ProductManufacture> ProductManufacture { get; set; }
        public DbSet<Formulation> Formulation { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<DrugList> DrugList { get; set; }
        public DbSet<DrugListItems> DrugListItems { get; set; }
        public DbSet<MedicationComposition> MedicationComposition { get; set; }
        public DbSet<Generic> Generic { get; set; }
        public DbSet<MedicationDosage> MedicationDosage { get; set; }
        public DbSet<RouteInfo> RouteInfo { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<VisitVitalTemplateParameter> VisitVitalTemplateParameter { get; set; }
        public DbSet<VisitGuideline> VisitGuideline { get; set; }
        public DbSet<VisitDiagnosis> VisitDiagnosis { get; set; }
        public DbSet<VisitDiagnosisParameter> VisitDiagnosisParameter { get; set; }
        public DbSet<VisitType> VisitType { get; set; }
        public DbSet<VisitMode> VisitMode { get; set; }
        public DbSet<VisitChiefComplaint> VisitChiefComplaint { get; set; }
        public DbSet<ChiefComplaint> ChiefComplaint { get; set; }
        public DbSet<VisitChiefComplaintParameter> VisitChiefComplaintParameter { get; set; }
        public DbSet<ClinicalParameter> ClinicalParameter { get; set; }
        public DbSet<ClinicalParameterValue> ClinicalParameterValue { get; set; }
        public DbSet<Uom> Uom { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<TokenManagement> TokenManagement { get; set; }
        public DbSet<DayVisit> DayVisit { get; set; }
        public DbSet<GoodsReceipt> GoodsReceipt { get; set; }
        public DbSet<GoodsReceiptPurchaseOrderRelation> GoodsReceiptPurchaseOrderRelation { get; set; }
        public DbSet<GoodsReceiptFile> GoodsReceiptFile { get; set; }
        public DbSet<GoodsReceiptActivityHistory> GoodsReceiptActivityHistory { get; set; }
        public DbSet<GoodsReceiptItem> GoodsReceiptItem { get; set; }
        public DbSet<GoodsReturn> GoodsReturn { get; set; }
        public DbSet<GoodsReturnItem> GoodsReturnItem { get; set; }
        public DbSet<GoodsReturnFile> GoodsReturnFile { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<PriceListVersion> PriceListVersion { get; set; }
        public DbSet<PriceListItem> PriceListItem { get; set; }
        public DbSet<PriceListComponent> PriceListComponent { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }
        public DbSet<PurchaseOrderFile> PurchaseOrderFile { get; set; }
        public DbSet<Requisition> Requisition { get; set; }
        public DbSet<RequisitionLine> RequisitionLine { get; set; }
        public DbSet<StockAdjustment> StockAdjustment { get; set; }
        public DbSet<StockAdjustmentItem> StockAdjustmentItem { get; set; }
        public DbSet<StockAdjustmentFile> StockAdjustmentFile { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<Specialisation> Specialisation { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
    }
}