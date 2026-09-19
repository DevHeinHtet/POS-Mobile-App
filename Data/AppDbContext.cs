using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using POSMobileApp.Models;

namespace POSMobileApp.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmrAllergy> EmrAllergies { get; set; }

    public virtual DbSet<EmrAllergyType> EmrAllergyTypes { get; set; }

    public virtual DbSet<EmrAllergyTypeGroup> EmrAllergyTypeGroups { get; set; }

    public virtual DbSet<EmrAllergyTypeGroupView> EmrAllergyTypeGroupViews { get; set; }

    public virtual DbSet<EmrAllergyTypeView> EmrAllergyTypeViews { get; set; }

    public virtual DbSet<EmrAllergyView> EmrAllergyViews { get; set; }

    public virtual DbSet<EmrClinic> EmrClinics { get; set; }

    public virtual DbSet<EmrClinicItem> EmrClinicItems { get; set; }

    public virtual DbSet<EmrClinicItemView> EmrClinicItemViews { get; set; }

    public virtual DbSet<EmrClinicService> EmrClinicServices { get; set; }

    public virtual DbSet<EmrClinicServicesView> EmrClinicServicesViews { get; set; }

    public virtual DbSet<EmrClinicView> EmrClinicViews { get; set; }

    public virtual DbSet<EmrComplaint> EmrComplaints { get; set; }

    public virtual DbSet<EmrComplaintView> EmrComplaintViews { get; set; }

    public virtual DbSet<EmrCountry> EmrCountries { get; set; }

    public virtual DbSet<EmrCountryView> EmrCountryViews { get; set; }

    public virtual DbSet<EmrDiagnosis> EmrDiagnoses { get; set; }

    public virtual DbSet<EmrDiagnosisView> EmrDiagnosisViews { get; set; }

    public virtual DbSet<EmrDocComment> EmrDocComments { get; set; }

    public virtual DbSet<EmrDocCommentView> EmrDocCommentViews { get; set; }

    public virtual DbSet<EmrDotorSpeciality> EmrDotorSpecialities { get; set; }

    public virtual DbSet<EmrDotorSpecialityView> EmrDotorSpecialityViews { get; set; }

    public virtual DbSet<EmrEyeTest> EmrEyeTests { get; set; }

    public virtual DbSet<EmrEyeTestLeftandRightView> EmrEyeTestLeftandRightViews { get; set; }

    public virtual DbSet<EmrEyeTestList> EmrEyeTestLists { get; set; }

    public virtual DbSet<EmrEyeTestListView> EmrEyeTestListViews { get; set; }

    public virtual DbSet<EmrEyeTestView> EmrEyeTestViews { get; set; }

    public virtual DbSet<EmrFamilyHistory> EmrFamilyHistories { get; set; }

    public virtual DbSet<EmrFamilyHistoryView> EmrFamilyHistoryViews { get; set; }

    public virtual DbSet<EmrGeneric> EmrGenerics { get; set; }

    public virtual DbSet<EmrGenericView> EmrGenericViews { get; set; }

    public virtual DbSet<EmrInPatient> EmrInPatients { get; set; }

    public virtual DbSet<EmrInPatientItem> EmrInPatientItems { get; set; }

    public virtual DbSet<EmrInPatientItemView> EmrInPatientItemViews { get; set; }

    public virtual DbSet<EmrInPatientService> EmrInPatientServices { get; set; }

    public virtual DbSet<EmrInPatientServiceView> EmrInPatientServiceViews { get; set; }

    public virtual DbSet<EmrInPatientView> EmrInPatientViews { get; set; }

    public virtual DbSet<EmrInsurance> EmrInsurances { get; set; }

    public virtual DbSet<EmrInsuranceView> EmrInsuranceViews { get; set; }

    public virtual DbSet<EmrInvoice> EmrInvoices { get; set; }

    public virtual DbSet<EmrInvoiceItem> EmrInvoiceItems { get; set; }

    public virtual DbSet<EmrInvoiceItemView> EmrInvoiceItemViews { get; set; }

    public virtual DbSet<EmrInvoiceLuckyDraw> EmrInvoiceLuckyDraws { get; set; }

    public virtual DbSet<EmrInvoiceView> EmrInvoiceViews { get; set; }

    public virtual DbSet<EmrItem> EmrItems { get; set; }

    public virtual DbSet<EmrItemBarcode> EmrItemBarcodes { get; set; }

    public virtual DbSet<EmrItemBarcodeView> EmrItemBarcodeViews { get; set; }

    public virtual DbSet<EmrItemPrice> EmrItemPrices { get; set; }

    public virtual DbSet<EmrItemPriceView> EmrItemPriceViews { get; set; }

    public virtual DbSet<EmrItemUom> EmrItemUoms { get; set; }

    public virtual DbSet<EmrItemUomconversion> EmrItemUomconversions { get; set; }

    public virtual DbSet<EmrItemUomconversionView> EmrItemUomconversionViews { get; set; }

    public virtual DbSet<EmrItemUomview> EmrItemUomviews { get; set; }

    public virtual DbSet<EmrItemView> EmrItemViews { get; set; }

    public virtual DbSet<EmrLabResult> EmrLabResults { get; set; }

    public virtual DbSet<EmrLabResultView> EmrLabResultViews { get; set; }

    public virtual DbSet<EmrLetterType> EmrLetterTypes { get; set; }

    public virtual DbSet<EmrLetterTypeView> EmrLetterTypeViews { get; set; }

    public virtual DbSet<EmrLuckyExpense> EmrLuckyExpenses { get; set; }

    public virtual DbSet<EmrLuckyExpenseDataView> EmrLuckyExpenseDataViews { get; set; }

    public virtual DbSet<EmrLuckyExpensePurchase> EmrLuckyExpensePurchases { get; set; }

    public virtual DbSet<EmrLuckyIncome> EmrLuckyIncomes { get; set; }

    public virtual DbSet<EmrMedicineItem> EmrMedicineItems { get; set; }

    public virtual DbSet<EmrMedicineItemView> EmrMedicineItemViews { get; set; }

    public virtual DbSet<EmrOrder> EmrOrders { get; set; }

    public virtual DbSet<EmrOrderItem> EmrOrderItems { get; set; }

    public virtual DbSet<EmrOrderItemView> EmrOrderItemViews { get; set; }

    public virtual DbSet<EmrOt> EmrOts { get; set; }

    public virtual DbSet<EmrOtitem> EmrOtitems { get; set; }

    public virtual DbSet<EmrOtitemView> EmrOtitemViews { get; set; }

    public virtual DbSet<EmrOtservice> EmrOtservices { get; set; }

    public virtual DbSet<EmrOtservicesView> EmrOtservicesViews { get; set; }

    public virtual DbSet<EmrOtview> EmrOtviews { get; set; }

    public virtual DbSet<EmrPastMedicalHistory> EmrPastMedicalHistories { get; set; }

    public virtual DbSet<EmrPastMedicalHistoryView> EmrPastMedicalHistoryViews { get; set; }

    public virtual DbSet<EmrPatientDetail> EmrPatientDetails { get; set; }

    public virtual DbSet<EmrPatientDetailView> EmrPatientDetailViews { get; set; }

    public virtual DbSet<EmrPatientId> EmrPatientIds { get; set; }

    public virtual DbSet<EmrPatientIdview> EmrPatientIdviews { get; set; }

    public virtual DbSet<EmrPatientLetter> EmrPatientLetters { get; set; }

    public virtual DbSet<EmrPatientLetterView> EmrPatientLetterViews { get; set; }

    public virtual DbSet<EmrPatientOtherName> EmrPatientOtherNames { get; set; }

    public virtual DbSet<EmrPatientOtherNameView> EmrPatientOtherNameViews { get; set; }

    public virtual DbSet<EmrPayment> EmrPayments { get; set; }

    public virtual DbSet<EmrPaymentView> EmrPaymentViews { get; set; }

    public virtual DbSet<EmrPhysicalExam> EmrPhysicalExams { get; set; }

    public virtual DbSet<EmrPhysicalExamView> EmrPhysicalExamViews { get; set; }

    public virtual DbSet<EmrProgressNote> EmrProgressNotes { get; set; }

    public virtual DbSet<EmrProgressNoteView> EmrProgressNoteViews { get; set; }

    public virtual DbSet<EmrRecommendation> EmrRecommendations { get; set; }

    public virtual DbSet<EmrRecommendationView> EmrRecommendationViews { get; set; }

    public virtual DbSet<EmrServiceType> EmrServiceTypes { get; set; }

    public virtual DbSet<EmrServiceTypeView> EmrServiceTypeViews { get; set; }

    public virtual DbSet<EmrSocialHistory> EmrSocialHistories { get; set; }

    public virtual DbSet<EmrSocialHistoryView> EmrSocialHistoryViews { get; set; }

    public virtual DbSet<EmrSpeciality> EmrSpecialities { get; set; }

    public virtual DbSet<EmrSpecialityGroup> EmrSpecialityGroups { get; set; }

    public virtual DbSet<EmrSpecialityGroupView> EmrSpecialityGroupViews { get; set; }

    public virtual DbSet<EmrSpecialityView> EmrSpecialityViews { get; set; }

    public virtual DbSet<EmrStation> EmrStations { get; set; }

    public virtual DbSet<EmrStationView> EmrStationViews { get; set; }

    public virtual DbSet<EmrVisit> EmrVisits { get; set; }

    public virtual DbSet<EmrVisitView> EmrVisitViews { get; set; }

    public virtual DbSet<EmrVitalSign> EmrVitalSigns { get; set; }

    public virtual DbSet<EmrVitalSignView> EmrVitalSignViews { get; set; }

    public virtual DbSet<FinConsignmentRefund> FinConsignmentRefunds { get; set; }

    public virtual DbSet<FinConsignmentRefundView> FinConsignmentRefundViews { get; set; }

    public virtual DbSet<FinCreditPaid> FinCreditPaids { get; set; }

    public virtual DbSet<FinCreditPaidItem> FinCreditPaidItems { get; set; }

    public virtual DbSet<FinCreditPaidItemView> FinCreditPaidItemViews { get; set; }

    public virtual DbSet<FinCreditPaidView> FinCreditPaidViews { get; set; }

    public virtual DbSet<FinCreditReceive> FinCreditReceives { get; set; }

    public virtual DbSet<FinCreditReceiveItem> FinCreditReceiveItems { get; set; }

    public virtual DbSet<FinCreditReceiveItemView> FinCreditReceiveItemViews { get; set; }

    public virtual DbSet<FinCreditReceiveView> FinCreditReceiveViews { get; set; }

    public virtual DbSet<FinDeposit> FinDeposits { get; set; }

    public virtual DbSet<FinDepositView> FinDepositViews { get; set; }

    public virtual DbSet<FinExpense> FinExpenses { get; set; }

    public virtual DbSet<FinExpenseSession> FinExpenseSessions { get; set; }

    public virtual DbSet<FinExpenseSessionView> FinExpenseSessionViews { get; set; }

    public virtual DbSet<FinExpenseView> FinExpenseViews { get; set; }

    public virtual DbSet<FinIncome> FinIncomes { get; set; }

    public virtual DbSet<FinIncomeSession> FinIncomeSessions { get; set; }

    public virtual DbSet<FinIncomeSessionView> FinIncomeSessionViews { get; set; }

    public virtual DbSet<FinIncomeView> FinIncomeViews { get; set; }

    public virtual DbSet<FinIncomeWeek> FinIncomeWeeks { get; set; }

    public virtual DbSet<FinIncomeWeekView> FinIncomeWeekViews { get; set; }

    public virtual DbSet<FinPo> FinPos { get; set; }

    public virtual DbSet<FinPoitem> FinPoitems { get; set; }

    public virtual DbSet<FinPoitemView> FinPoitemViews { get; set; }

    public virtual DbSet<FinPoview> FinPoviews { get; set; }

    public virtual DbSet<FinSaleReturn> FinSaleReturns { get; set; }

    public virtual DbSet<FinSaleReturnItem> FinSaleReturnItems { get; set; }

    public virtual DbSet<FinSaleReturnItemView> FinSaleReturnItemViews { get; set; }

    public virtual DbSet<FinSaleReturnView> FinSaleReturnViews { get; set; }

    public virtual DbSet<InvAdjustment> InvAdjustments { get; set; }

    public virtual DbSet<InvAdjustmentItem> InvAdjustmentItems { get; set; }

    public virtual DbSet<InvAdjustmentItemView> InvAdjustmentItemViews { get; set; }

    public virtual DbSet<InvAdjustmentView> InvAdjustmentViews { get; set; }

    public virtual DbSet<InvConsignment> InvConsignments { get; set; }

    public virtual DbSet<InvConsignmentItem> InvConsignmentItems { get; set; }

    public virtual DbSet<InvConsignmentItemView> InvConsignmentItemViews { get; set; }

    public virtual DbSet<InvConsignmentView> InvConsignmentViews { get; set; }

    public virtual DbSet<InvExpireIn> InvExpireIns { get; set; }

    public virtual DbSet<InvExpireInView> InvExpireInViews { get; set; }

    public virtual DbSet<InvExpireOut> InvExpireOuts { get; set; }

    public virtual DbSet<InvExpireOutView> InvExpireOutViews { get; set; }

    public virtual DbSet<InvLocationMove> InvLocationMoves { get; set; }

    public virtual DbSet<InvLocationMoveItem> InvLocationMoveItems { get; set; }

    public virtual DbSet<InvLocationMoveItemView> InvLocationMoveItemViews { get; set; }

    public virtual DbSet<InvLocationMoveView> InvLocationMoveViews { get; set; }

    public virtual DbSet<InvMr> InvMrs { get; set; }

    public virtual DbSet<InvMritem> InvMritems { get; set; }

    public virtual DbSet<InvMritemView> InvMritemViews { get; set; }

    public virtual DbSet<InvMrview> InvMrviews { get; set; }

    public virtual DbSet<InvStockException> InvStockExceptions { get; set; }

    public virtual DbSet<InvStockExceptionItem> InvStockExceptionItems { get; set; }

    public virtual DbSet<InvStockExceptionItemView> InvStockExceptionItemViews { get; set; }

    public virtual DbSet<InvStockExceptionView> InvStockExceptionViews { get; set; }

    public virtual DbSet<InvStockFlow> InvStockFlows { get; set; }

    public virtual DbSet<InvStockFlowView> InvStockFlowViews { get; set; }

    public virtual DbSet<InvStockIn> InvStockIns { get; set; }

    public virtual DbSet<InvStockInItem> InvStockInItems { get; set; }

    public virtual DbSet<InvStockInItemView> InvStockInItemViews { get; set; }

    public virtual DbSet<InvStockInView> InvStockInViews { get; set; }

    public virtual DbSet<InvStockReportView> InvStockReportViews { get; set; }

    public virtual DbSet<InvStockRequest> InvStockRequests { get; set; }

    public virtual DbSet<InvStoreIssue> InvStoreIssues { get; set; }

    public virtual DbSet<InvStoreIssueItem> InvStoreIssueItems { get; set; }

    public virtual DbSet<InvStoreIssueItemView> InvStoreIssueItemViews { get; set; }

    public virtual DbSet<InvStoreIssueView> InvStoreIssueViews { get; set; }

    public virtual DbSet<InvStoreReceipt> InvStoreReceipts { get; set; }

    public virtual DbSet<InvStoreReceiptItem> InvStoreReceiptItems { get; set; }

    public virtual DbSet<InvStoreReceiptItemView> InvStoreReceiptItemViews { get; set; }

    public virtual DbSet<InvStoreReceiptView> InvStoreReceiptViews { get; set; }

    public virtual DbSet<InvoiceItemCost> InvoiceItemCosts { get; set; }

    public virtual DbSet<MstBranch> MstBranches { get; set; }

    public virtual DbSet<MstBranchView> MstBranchViews { get; set; }

    public virtual DbSet<MstBrand> MstBrands { get; set; }

    public virtual DbSet<MstBrandView> MstBrandViews { get; set; }

    public virtual DbSet<MstCurrencyExchange> MstCurrencyExchanges { get; set; }

    public virtual DbSet<MstCurrencyExchangeView> MstCurrencyExchangeViews { get; set; }

    public virtual DbSet<MstCustomer> MstCustomers { get; set; }

    public virtual DbSet<MstCustomerNewView> MstCustomerNewViews { get; set; }

    public virtual DbSet<MstCustomerView> MstCustomerViews { get; set; }

    public virtual DbSet<MstDoctor> MstDoctors { get; set; }

    public virtual DbSet<MstDoctorView> MstDoctorViews { get; set; }

    public virtual DbSet<MstItem> MstItems { get; set; }

    public virtual DbSet<MstItemGroup> MstItemGroups { get; set; }

    public virtual DbSet<MstItemGroupView> MstItemGroupViews { get; set; }

    public virtual DbSet<MstLocation> MstLocations { get; set; }

    public virtual DbSet<MstLocationStaff> MstLocationStaffs { get; set; }

    public virtual DbSet<MstLocationStaffView> MstLocationStaffViews { get; set; }

    public virtual DbSet<MstLocationView> MstLocationViews { get; set; }

    public virtual DbSet<MstLuckyPrize> MstLuckyPrizes { get; set; }

    public virtual DbSet<MstManufacturer> MstManufacturers { get; set; }

    public virtual DbSet<MstManufacturerView> MstManufacturerViews { get; set; }

    public virtual DbSet<MstOperator> MstOperators { get; set; }

    public virtual DbSet<MstOperatorView> MstOperatorViews { get; set; }

    public virtual DbSet<MstServiceType> MstServiceTypes { get; set; }

    public virtual DbSet<MstServiceTypeItem> MstServiceTypeItems { get; set; }

    public virtual DbSet<MstServiceTypeItemView> MstServiceTypeItemViews { get; set; }

    public virtual DbSet<MstServiceTypePerson> MstServiceTypePeople { get; set; }

    public virtual DbSet<MstServiceTypePersonView> MstServiceTypePersonViews { get; set; }

    public virtual DbSet<MstServiceTypeView> MstServiceTypeViews { get; set; }

    public virtual DbSet<MstStaff> MstStaffs { get; set; }

    public virtual DbSet<MstStaffView> MstStaffViews { get; set; }

    public virtual DbSet<MstSupplier> MstSuppliers { get; set; }

    public virtual DbSet<MstSupplierView> MstSupplierViews { get; set; }

    public virtual DbSet<MstTownship> MstTownships { get; set; }

    public virtual DbSet<MstTownshipView> MstTownshipViews { get; set; }

    public virtual DbSet<StStockFlowCheckFoc> StStockFlowCheckFocs { get; set; }

    public virtual DbSet<StStockFlowCheckFocview> StStockFlowCheckFocviews { get; set; }

    public virtual DbSet<StStockFlowCheckQtyofFocview> StStockFlowCheckQtyofFocviews { get; set; }

    public virtual DbSet<StockLedger> StockLedgers { get; set; }

    public virtual DbSet<SysUser> SysUsers { get; set; }

    public virtual DbSet<SysUserView> SysUserViews { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Table2> Table2s { get; set; }

    public virtual DbSet<Table3> Table3s { get; set; }

    public virtual DbSet<Table4> Table4s { get; set; }

    public virtual DbSet<Table5> Table5s { get; set; }

    public virtual DbSet<Table6> Table6s { get; set; }

    public virtual DbSet<Table7> Table7s { get; set; }

    public virtual DbSet<TonodataView> TonodataViews { get; set; }

    public virtual DbSet<Tonodatum> Tonodata { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmrAllergy>(entity =>
        {
            entity.HasKey(e => e.AllegriesId);

            entity.ToTable("EMR_Allergies");

            entity.Property(e => e.AllegriesId)
                .HasMaxLength(50)
                .HasColumnName("AllegriesID");
            entity.Property(e => e.Allergies).HasMaxLength(1000);
            entity.Property(e => e.AllergyTypeId)
                .HasMaxLength(50)
                .HasColumnName("AllergyTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrAllergyType>(entity =>
        {
            entity.HasKey(e => e.AllergyTypeId);

            entity.ToTable("EMR_AllergyType");

            entity.Property(e => e.AllergyTypeId)
                .HasMaxLength(50)
                .HasColumnName("AllergyTypeID");
            entity.Property(e => e.AllergyTypeGroupId)
                .HasMaxLength(200)
                .HasColumnName("AllergyTypeGroupID");
            entity.Property(e => e.AllergyTypeName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrAllergyTypeGroup>(entity =>
        {
            entity.HasKey(e => e.AllergyTypeGroupId);

            entity.ToTable("EMR_AllergyTypeGroup");

            entity.Property(e => e.AllergyTypeGroupId)
                .HasMaxLength(50)
                .HasColumnName("AllergyTypeGroupID");
            entity.Property(e => e.AllergyTypeGroupName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrAllergyTypeGroupView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_AllergyTypeGroupView");

            entity.Property(e => e.AllergyTypeGroupId)
                .HasMaxLength(50)
                .HasColumnName("AllergyTypeGroupID");
            entity.Property(e => e.AllergyTypeGroupName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrAllergyTypeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_AllergyTypeView");

            entity.Property(e => e.AllergyTypeGroupId)
                .HasMaxLength(200)
                .HasColumnName("AllergyTypeGroupID");
            entity.Property(e => e.AllergyTypeGroupName).HasMaxLength(50);
            entity.Property(e => e.AllergyTypeId)
                .HasMaxLength(50)
                .HasColumnName("AllergyTypeID");
            entity.Property(e => e.AllergyTypeName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrAllergyView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_AllergyView");

            entity.Property(e => e.AllegriesId)
                .HasMaxLength(50)
                .HasColumnName("AllegriesID");
            entity.Property(e => e.Allergies).HasMaxLength(1000);
            entity.Property(e => e.AllergyTypeId)
                .HasMaxLength(50)
                .HasColumnName("AllergyTypeID");
            entity.Property(e => e.AllergyTypeName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrClinic>(entity =>
        {
            entity.HasKey(e => e.ClinicVoucherId);

            entity.ToTable("EMR_Clinic");

            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrClinicItem>(entity =>
        {
            entity.HasKey(e => e.ClinicVoucherItemId);

            entity.ToTable("EMR_ClinicItem");

            entity.Property(e => e.ClinicVoucherItemId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherItemID");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<EmrClinicItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ClinicItemView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedByCode).HasMaxLength(20);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherItemId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherItemID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsStockCount).HasColumnName("isStockCount");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrClinicService>(entity =>
        {
            entity.HasKey(e => e.ClinicServicesId);

            entity.ToTable("EMR_ClinicServices");

            entity.Property(e => e.ClinicServicesId)
                .HasMaxLength(50)
                .HasColumnName("ClinicServicesID");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServicePrice).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.ServiceTypeSubName).HasMaxLength(200);
            entity.Property(e => e.Time).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<EmrClinicServicesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ClinicServicesView");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.ClinicServicesId)
                .HasMaxLength(50)
                .HasColumnName("ClinicServicesID");
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServicePrice).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceSubCateName).HasMaxLength(200);
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.ServiceTypeSubName).HasMaxLength(200);
            entity.Property(e => e.Time).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrClinicView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ClinicView");

            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrComplaint>(entity =>
        {
            entity.HasKey(e => e.ComplaintId);

            entity.ToTable("EMR_Complaint");

            entity.Property(e => e.ComplaintId)
                .HasMaxLength(50)
                .HasColumnName("ComplaintID");
            entity.Property(e => e.ComplaintDescription).HasMaxLength(1000);
            entity.Property(e => e.ComplaintOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrComplaintView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ComplaintView");

            entity.Property(e => e.ComplaintDescription).HasMaxLength(1000);
            entity.Property(e => e.ComplaintId)
                .HasMaxLength(50)
                .HasColumnName("ComplaintID");
            entity.Property(e => e.ComplaintOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("EMR_Country");

            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CountryCode).HasMaxLength(50);
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrCountryView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_CountryView");

            entity.Property(e => e.CountryCode).HasMaxLength(50);
            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrDiagnosis>(entity =>
        {
            entity.HasKey(e => e.DiagnosisId);

            entity.ToTable("EMR_Diagnosis");

            entity.Property(e => e.DiagnosisId)
                .HasMaxLength(50)
                .HasColumnName("DiagnosisID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiagnosisNote).HasMaxLength(1000);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrDiagnosisView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_DiagnosisView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiagnosisId)
                .HasMaxLength(50)
                .HasColumnName("DiagnosisID");
            entity.Property(e => e.DiagnosisNote).HasMaxLength(1000);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrDocComment>(entity =>
        {
            entity.HasKey(e => e.CommentId);

            entity.ToTable("EMR_DocComment");

            entity.Property(e => e.CommentId)
                .HasMaxLength(50)
                .HasColumnName("CommentID");
            entity.Property(e => e.CommentOn).HasColumnType("datetime");
            entity.Property(e => e.Commnet).HasMaxLength(1000);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrDocCommentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_DocCommentView");

            entity.Property(e => e.CommentId)
                .HasMaxLength(50)
                .HasColumnName("CommentID");
            entity.Property(e => e.CommentOn).HasColumnType("datetime");
            entity.Property(e => e.Commnet).HasMaxLength(1000);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrDotorSpeciality>(entity =>
        {
            entity.HasKey(e => e.DoctorSpecialityId);

            entity.ToTable("EMR_DotorSpeciality");

            entity.Property(e => e.DoctorSpecialityId)
                .HasMaxLength(50)
                .HasColumnName("DoctorSpecialityID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SpecialityId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityID");
        });

        modelBuilder.Entity<EmrDotorSpecialityView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_DotorSpecialityView");

            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.ContactInfo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorActive).HasColumnName("doctorActive");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNameEnglish).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.DoctorSpecialityId)
                .HasMaxLength(50)
                .HasColumnName("DoctorSpecialityID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmergencyContact).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.Speciality).HasMaxLength(50);
            entity.Property(e => e.SpecialityGroupName).HasMaxLength(50);
            entity.Property(e => e.SpecialityId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityID");
            entity.Property(e => e.SpecialityTitle).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrEyeTest>(entity =>
        {
            entity.HasKey(e => e.EyeTestId).HasName("PK_MER_EyeTest");

            entity.ToTable("EMR_EyeTest");

            entity.Property(e => e.EyeTestId)
                .HasMaxLength(50)
                .HasColumnName("EyeTestID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Lresult)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LResult");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Pd)
                .HasMaxLength(50)
                .HasColumnName("PD");
            entity.Property(e => e.Recommand).HasMaxLength(100);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Rresult)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RResult");
            entity.Property(e => e.TestOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrEyeTestLeftandRightView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_EyeTestLeftandRightView");

            entity.Property(e => e.Atest)
                .HasMaxLength(50)
                .HasColumnName("ATest");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ctest)
                .HasMaxLength(50)
                .HasColumnName("CTest");
            entity.Property(e => e.Distance).HasMaxLength(50);
            entity.Property(e => e.EyeTestId)
                .HasMaxLength(50)
                .HasColumnName("EyeTestID");
            entity.Property(e => e.EyeTestLid)
                .HasMaxLength(50)
                .HasColumnName("EyeTestLID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Ratest)
                .HasMaxLength(50)
                .HasColumnName("RATest");
            entity.Property(e => e.Rctest)
                .HasMaxLength(50)
                .HasColumnName("RCTest");
            entity.Property(e => e.Rstest)
                .HasMaxLength(50)
                .HasColumnName("RSTest");
            entity.Property(e => e.Side).HasMaxLength(50);
            entity.Property(e => e.Stest)
                .HasMaxLength(50)
                .HasColumnName("STest");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrEyeTestList>(entity =>
        {
            entity.HasKey(e => e.EyeTestLid).HasName("PK_EMR_EyeTestLeft");

            entity.ToTable("EMR_EyeTestList");

            entity.Property(e => e.EyeTestLid)
                .HasMaxLength(50)
                .HasColumnName("EyeTestLID");
            entity.Property(e => e.Atest)
                .HasMaxLength(50)
                .HasColumnName("ATest");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ctest)
                .HasMaxLength(50)
                .HasColumnName("CTest");
            entity.Property(e => e.Distance).HasMaxLength(50);
            entity.Property(e => e.EyeTestId)
                .HasMaxLength(50)
                .HasColumnName("EyeTestID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Side).HasMaxLength(50);
            entity.Property(e => e.Stest)
                .HasMaxLength(50)
                .HasColumnName("STest");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrEyeTestListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_EyeTestListView");

            entity.Property(e => e.Atest)
                .HasMaxLength(50)
                .HasColumnName("ATest");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ctest)
                .HasMaxLength(50)
                .HasColumnName("CTest");
            entity.Property(e => e.Distance).HasMaxLength(50);
            entity.Property(e => e.EyeTestId)
                .HasMaxLength(50)
                .HasColumnName("EyeTestID");
            entity.Property(e => e.EyeTestLid)
                .HasMaxLength(50)
                .HasColumnName("EyeTestLID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Lresult)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LResult");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Pd)
                .HasMaxLength(50)
                .HasColumnName("PD");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Rresult)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RResult");
            entity.Property(e => e.Side).HasMaxLength(50);
            entity.Property(e => e.Stest)
                .HasMaxLength(50)
                .HasColumnName("STest");
            entity.Property(e => e.TestOn).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrEyeTestView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_EyeTestView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EyeTestId)
                .HasMaxLength(50)
                .HasColumnName("EyeTestID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Lresult)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LResult");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Pd)
                .HasMaxLength(50)
                .HasColumnName("PD");
            entity.Property(e => e.Recommand).HasMaxLength(100);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Rresult)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RResult");
            entity.Property(e => e.TestOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrFamilyHistory>(entity =>
        {
            entity.HasKey(e => e.FamilyHistoryId);

            entity.ToTable("EMR_FamilyHistory");

            entity.Property(e => e.FamilyHistoryId)
                .HasMaxLength(50)
                .HasColumnName("FamilyHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FamilyHistory).HasMaxLength(1000);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrFamilyHistoryView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_FamilyHistoryView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FamilyHistory).HasMaxLength(1000);
            entity.Property(e => e.FamilyHistoryId)
                .HasMaxLength(50)
                .HasColumnName("FamilyHistoryID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrGeneric>(entity =>
        {
            entity.HasKey(e => e.GenericId);

            entity.ToTable("EMR_Generic");

            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrGenericView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_GenericView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrInPatient>(entity =>
        {
            entity.HasKey(e => e.InPatientVoucherId);

            entity.ToTable("EMR_InPatient");

            entity.Property(e => e.InPatientVoucherId)
                .HasMaxLength(50)
                .HasColumnName("InPatientVoucherID");
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InPatientVoucherNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Otamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("OTAmount");
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrInPatientItem>(entity =>
        {
            entity.HasKey(e => e.InPatientItemId);

            entity.ToTable("EMR_InPatientItem");

            entity.Property(e => e.InPatientItemId)
                .HasMaxLength(50)
                .HasColumnName("InPatientItemID");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.InPatientVoucherId)
                .HasMaxLength(50)
                .HasColumnName("InPatientVoucherID");
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<EmrInPatientItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_InPatientItemView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedByCode).HasMaxLength(20);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.InPatientItemId)
                .HasMaxLength(50)
                .HasColumnName("InPatientItemID");
            entity.Property(e => e.InPatientVoucherId)
                .HasMaxLength(50)
                .HasColumnName("InPatientVoucherID");
            entity.Property(e => e.InPatientVoucherNo).HasMaxLength(50);
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrInPatientService>(entity =>
        {
            entity.HasKey(e => e.InPatientServiceId);

            entity.ToTable("EMR_InPatientService");

            entity.Property(e => e.InPatientServiceId)
                .HasMaxLength(50)
                .HasColumnName("InPatientServiceID");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InPatientVoucherId)
                .HasMaxLength(50)
                .HasColumnName("InPatientVoucherID");
            entity.Property(e => e.IsSpfoc).HasColumnName("IsSPFOC");
            entity.Property(e => e.IsStfoc).HasColumnName("IsSTFOC");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServicePrice).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.ServiceTypeSubName).HasMaxLength(200);
            entity.Property(e => e.Time).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EmrInPatientServiceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_InPatientServiceView");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.InPatientServiceId)
                .HasMaxLength(50)
                .HasColumnName("InPatientServiceID");
            entity.Property(e => e.InPatientVoucherId)
                .HasMaxLength(50)
                .HasColumnName("InPatientVoucherID");
            entity.Property(e => e.InPatientVoucherNo).HasMaxLength(50);
            entity.Property(e => e.IsSpfoc).HasColumnName("IsSPFOC");
            entity.Property(e => e.IsStfoc).HasColumnName("IsSTFOC");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServicePrice).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceSubCateName).HasMaxLength(200);
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.ServiceTypeSubName).HasMaxLength(200);
            entity.Property(e => e.Time).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrInPatientView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_InPatientView");

            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DepositDate)
                .HasColumnType("datetime")
                .HasColumnName("depositDate");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InPatientVoucherId)
                .HasMaxLength(50)
                .HasColumnName("InPatientVoucherID");
            entity.Property(e => e.InPatientVoucherNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperationType).HasMaxLength(100);
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.Otamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("OTAmount");
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.OtvoucherNo)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherNo");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrInsurance>(entity =>
        {
            entity.HasKey(e => e.InsuranceId);

            entity.ToTable("EMR_Insurance");

            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactInfo).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountMedicine).HasMaxLength(200);
            entity.Property(e => e.InsuranceCode).HasMaxLength(200);
            entity.Property(e => e.InsuranceName).HasMaxLength(200);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrInsuranceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_InsuranceView");

            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactInfo).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountMedicine).HasMaxLength(200);
            entity.Property(e => e.InsuranceCode).HasMaxLength(200);
            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.InsuranceName).HasMaxLength(200);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrInvoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("EMR_Invoice");

            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BalanceBeforePaid).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditDueDate).HasColumnType("datetime");
            entity.Property(e => e.CreditReceivedAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.DoctorPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.InvoicePayment).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Other1Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Other1Remark).HasMaxLength(50);
            entity.Property(e => e.Other2Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Other2Remark).HasMaxLength(50);
            entity.Property(e => e.PatientAge).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PatientSubName).HasMaxLength(50);
            entity.Property(e => e.Prepaid).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RadioAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("radioAmount");
            entity.Property(e => e.RadioId)
                .HasMaxLength(50)
                .HasColumnName("radioID");
            entity.Property(e => e.RadioPercent)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("radioPercent");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TechAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TechId)
                .HasMaxLength(50)
                .HasColumnName("TechID");
            entity.Property(e => e.TechPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalCostBelongToDoctorIncentive).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VoucherType).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrInvoiceItem>(entity =>
        {
            entity.HasKey(e => e.InvoiceItemId).HasName("PK_EMR_InvoiceItem_1");

            entity.ToTable("EMR_InvoiceItem");

            entity.Property(e => e.InvoiceItemId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceItemID");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.IsNotDoctorIncentive).HasColumnName("isNotDoctorIncentive");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<EmrInvoiceItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_InvoiceItemView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedByCode).HasMaxLength(20);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceItemId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceItemID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.IsNotDoctorIncentive).HasColumnName("isNotDoctorIncentive");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrInvoiceLuckyDraw>(entity =>
        {
            entity.HasKey(e => e.LuckDrawId);

            entity.ToTable("EMR_InvoiceLuckyDraw");

            entity.Property(e => e.LuckDrawId)
                .HasMaxLength(50)
                .HasColumnName("LuckDrawID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EmrInvoiceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_InvoiceView");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BalanceBeforePaid).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditDueDate).HasColumnType("datetime");
            entity.Property(e => e.CreditReceivedAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.InvoicePayment).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.Other1Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Other1Remark).HasMaxLength(50);
            entity.Property(e => e.Other2Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Other2Remark).HasMaxLength(50);
            entity.Property(e => e.PatientAge).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PatientSubName).HasMaxLength(300);
            entity.Property(e => e.Prepaid).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RadioAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("radioAmount");
            entity.Property(e => e.RadioCode).HasMaxLength(50);
            entity.Property(e => e.RadioId)
                .HasMaxLength(50)
                .HasColumnName("radioID");
            entity.Property(e => e.RadioName).HasMaxLength(50);
            entity.Property(e => e.RadioPercent)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("radioPercent");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SaleReturn).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TechAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TechId)
                .HasMaxLength(50)
                .HasColumnName("TechID");
            entity.Property(e => e.TechName).HasMaxLength(50);
            entity.Property(e => e.TechPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TeechCode).HasMaxLength(50);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalCostAfterSaleReturn).HasColumnType("decimal(21, 2)");
            entity.Property(e => e.TotalCostBelongToDoctorIncentive).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VoucherType).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrItem>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("EMR_Item");

            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.BrandId)
                .HasMaxLength(50)
                .HasColumnName("BrandID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsParentItemId)
                .HasMaxLength(50)
                .HasColumnName("CsParentItemID");
            entity.Property(e => e.CssupplierId)
                .HasMaxLength(50)
                .HasColumnName("CSSupplierID");
            entity.Property(e => e.DefaultItemPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.InventUomid)
                .HasMaxLength(50)
                .HasColumnName("InventUOMID");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsCs).HasColumnName("isCS");
            entity.Property(e => e.IsMaterial).HasColumnName("isMaterial");
            entity.Property(e => e.IsStockCount).HasColumnName("isStockCount");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ManualCode).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ShortCode).HasMaxLength(20);
            entity.Property(e => e.ShowSeq).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<EmrItemBarcode>(entity =>
        {
            entity.HasKey(e => e.ItemBarcodeId);

            entity.ToTable("EMR_ItemBarcode");

            entity.Property(e => e.ItemBarcodeId)
                .HasMaxLength(50)
                .HasColumnName("ItemBarcodeID");
            entity.Property(e => e.BarcodeNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Uomid)
                .HasMaxLength(50)
                .HasColumnName("UOMID");
        });

        modelBuilder.Entity<EmrItemBarcodeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ItemBarcodeView");

            entity.Property(e => e.BarcodeNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemBarcodeId)
                .HasMaxLength(50)
                .HasColumnName("ItemBarcodeID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.Uomid)
                .HasMaxLength(50)
                .HasColumnName("UOMID");
        });

        modelBuilder.Entity<EmrItemPrice>(entity =>
        {
            entity.HasKey(e => e.ItemPriceId).HasName("PK_Mst_ItemPrice");

            entity.ToTable("EMR_ItemPrice");

            entity.Property(e => e.ItemPriceId)
                .HasMaxLength(50)
                .HasColumnName("ItemPriceID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FormulaAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FormulaPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceChangeFormula).HasMaxLength(50);
            entity.Property(e => e.PriceChangeFormulaType).HasMaxLength(50);
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<EmrItemPriceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ItemPriceView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FormulaAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FormulaPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemPriceId)
                .HasMaxLength(50)
                .HasColumnName("ItemPriceID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceChangeFormula).HasMaxLength(50);
            entity.Property(e => e.PriceChangeFormulaType).HasMaxLength(50);
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrItemUom>(entity =>
        {
            entity.HasKey(e => e.ItemUomid);

            entity.ToTable("EMR_ItemUOM", tb => tb.HasTrigger("TR_ItemUOM_RebuildCombine"));

            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsReportUnit).HasColumnName("isReportUnit");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UomLabel).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrItemUomconversion>(entity =>
        {
            entity.HasKey(e => e.ItemUomcovId);

            entity.ToTable("EMR_ItemUOMConversion");

            entity.Property(e => e.ItemUomcovId)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMCovID");
            entity.Property(e => e.Conversion).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromUom)
                .HasMaxLength(50)
                .HasColumnName("FromUOM");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ShowSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.ToUom)
                .HasMaxLength(50)
                .HasColumnName("ToUOM");
        });

        modelBuilder.Entity<EmrItemUomconversionView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ItemUOMConversionView");

            entity.Property(e => e.Conversion).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromUom)
                .HasMaxLength(50)
                .HasColumnName("FromUOM");
            entity.Property(e => e.FromUomid)
                .HasMaxLength(50)
                .HasColumnName("fromUOMID");
            entity.Property(e => e.FromUomlabel)
                .HasMaxLength(50)
                .HasColumnName("fromUOMlabel");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomcovId)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMCovID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ShowSeq).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.ToUom)
                .HasMaxLength(50)
                .HasColumnName("ToUOM");
            entity.Property(e => e.ToUomid)
                .HasMaxLength(50)
                .HasColumnName("toUOMID");
            entity.Property(e => e.ToUomlabe)
                .HasMaxLength(50)
                .HasColumnName("toUOMlabe");
        });

        modelBuilder.Entity<EmrItemUomview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ItemUOMView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsReportUnit).HasColumnName("isReportUnit");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UomLabel).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ItemVIew");

            entity.Property(e => e.BrandId)
                .HasMaxLength(50)
                .HasColumnName("BrandID");
            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsParentItemId)
                .HasMaxLength(50)
                .HasColumnName("CsParentItemID");
            entity.Property(e => e.CsparentItemName)
                .HasMaxLength(500)
                .HasColumnName("CSParentItemName");
            entity.Property(e => e.CssupplierId)
                .HasMaxLength(50)
                .HasColumnName("CSSupplierID");
            entity.Property(e => e.DefaultItemPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.InventUomid)
                .HasMaxLength(50)
                .HasColumnName("InventUOMID");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsCs).HasColumnName("isCS");
            entity.Property(e => e.IsMaterial).HasColumnName("isMaterial");
            entity.Property(e => e.IsStockCount).HasColumnName("isStockCount");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemSupplierCode).HasMaxLength(50);
            entity.Property(e => e.ItemSupplierName).HasMaxLength(300);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ManualCode).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ShortCode).HasMaxLength(20);
            entity.Property(e => e.ShowSeq).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<EmrLabResult>(entity =>
        {
            entity.HasKey(e => e.ResultId);

            entity.ToTable("EMR_LabResult");

            entity.Property(e => e.ResultId)
                .HasMaxLength(50)
                .HasColumnName("ResultID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceItemId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceItemID");
            entity.Property(e => e.IsNotDoctorIncentive).HasColumnName("isNotDoctorIncentive");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrLabResultView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_LabResultView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceItemId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceItemID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsNotDoctorIncentive).HasColumnName("isNotDoctorIncentive");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.ResultId)
                .HasMaxLength(50)
                .HasColumnName("ResultID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrLetterType>(entity =>
        {
            entity.HasKey(e => e.LetterTypeId);

            entity.ToTable("EMR_LetterType");

            entity.Property(e => e.LetterTypeId)
                .HasMaxLength(50)
                .HasColumnName("LetterTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LetterTitle).HasMaxLength(300);
            entity.Property(e => e.LetterTypeName).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrLetterTypeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_LetterTypeView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LetterTitle).HasMaxLength(300);
            entity.Property(e => e.LetterTypeId)
                .HasMaxLength(50)
                .HasColumnName("LetterTypeID");
            entity.Property(e => e.LetterTypeName).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrLuckyExpense>(entity =>
        {
            entity.ToTable("EMR_LuckyExpense");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Charges).HasColumnType("money");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.SaleId).HasMaxLength(50);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitId).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrLuckyExpenseDataView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_LuckyExpenseDataView");

            entity.Property(e => e.Charges).HasColumnType("money");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LuckyId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmrLuckyExpensePurchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EMR_LuckyExpensePurchase");
        });

        modelBuilder.Entity<EmrLuckyIncome>(entity =>
        {
            entity.ToTable("EMR_LuckyIncome");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LuckyId).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmrMedicineItem>(entity =>
        {
            entity.HasKey(e => e.MedicineItemId);

            entity.ToTable("EMR_MedicineItem");

            entity.Property(e => e.MedicineItemId)
                .HasMaxLength(50)
                .HasColumnName("MedicineItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrMedicineItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_MedicineItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.MedicineItemId)
                .HasMaxLength(50)
                .HasColumnName("MedicineItemID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_EMR_Order_1");

            entity.ToTable("EMR_Order");

            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationIdfrom)
                .HasMaxLength(50)
                .HasColumnName("LocationIDFrom");
            entity.Property(e => e.LocationIdto)
                .HasMaxLength(50)
                .HasColumnName("LocationIDTo");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(200)
                .HasColumnName("PatientID");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.ReferenceType).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(100);
            entity.Property(e => e.StartOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrOrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK_EMR_OrderItem_1");

            entity.ToTable("EMR_OrderItem");

            entity.Property(e => e.OrderItemId)
                .HasMaxLength(50)
                .HasColumnName("OrderItemID");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<EmrOrderItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_OrderItemView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedByCode).HasMaxLength(20);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderItemId)
                .HasMaxLength(50)
                .HasColumnName("OrderItemID");
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(200)
                .HasColumnName("PatientID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrOt>(entity =>
        {
            entity.HasKey(e => e.OtvoucherId);

            entity.ToTable("EMR_OT");

            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DepositId)
                .HasMaxLength(50)
                .HasColumnName("DepositID");
            entity.Property(e => e.InPatientPayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperationType).HasMaxLength(100);
            entity.Property(e => e.OtvoucherNo)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherNo");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrOtitem>(entity =>
        {
            entity.HasKey(e => e.OtvoucherItemId);

            entity.ToTable("EMR_OTItem");

            entity.Property(e => e.OtvoucherItemId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherItemID");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<EmrOtitemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_OTItemView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedByCode).HasMaxLength(20);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedType).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsMaterial).HasColumnName("isMaterial");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.OtvoucherItemId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherItemID");
            entity.Property(e => e.OtvoucherNo)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherNo");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrOtservice>(entity =>
        {
            entity.HasKey(e => e.OtserviceId);

            entity.ToTable("EMR_OTServices");

            entity.Property(e => e.OtserviceId)
                .HasMaxLength(50)
                .HasColumnName("OTServiceID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.ServiceTypeSubName).HasMaxLength(200);
            entity.Property(e => e.Time).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EmrOtservicesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_OTServicesView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtserviceId)
                .HasMaxLength(50)
                .HasColumnName("OTServiceID");
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.OtvoucherNo)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherNo");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServiceSubCateName).HasMaxLength(200);
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.ServiceTypeSubName).HasMaxLength(200);
            entity.Property(e => e.Time).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EmrOtview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_OTView");

            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Deposit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DepositDate)
                .HasColumnType("datetime")
                .HasColumnName("depositDate");
            entity.Property(e => e.DepositId)
                .HasMaxLength(50)
                .HasColumnName("DepositID");
            entity.Property(e => e.InPatientPayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperationType).HasMaxLength(100);
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.OtvoucherId)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherID");
            entity.Property(e => e.OtvoucherNo)
                .HasMaxLength(50)
                .HasColumnName("OTVoucherNo");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remains).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(4000);
            entity.Property(e => e.StaffById)
                .HasMaxLength(50)
                .HasColumnName("StaffByID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UseAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrPastMedicalHistory>(entity =>
        {
            entity.HasKey(e => e.MedicalHistoryId);

            entity.ToTable("EMR_PastMedicalHistory");

            entity.Property(e => e.MedicalHistoryId)
                .HasMaxLength(50)
                .HasColumnName("MedicalHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.MedicalHistory).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrPastMedicalHistoryView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_PastMedicalHistoryView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.MedicalHistory).HasMaxLength(1000);
            entity.Property(e => e.MedicalHistoryId)
                .HasMaxLength(50)
                .HasColumnName("MedicalHistoryID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrPatientDetail>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK_EMR_Patient");

            entity.ToTable("EMR_PatientDetail");

            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.AciveFrom).HasColumnType("datetime");
            entity.Property(e => e.ActiveTo).HasColumnType("datetime");
            entity.Property(e => e.AddressNo).HasMaxLength(50);
            entity.Property(e => e.Area).HasMaxLength(200);
            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.Building).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.DobDd)
                .HasMaxLength(50)
                .HasColumnName("DOB_DD");
            entity.Property(e => e.DobMm)
                .HasMaxLength(50)
                .HasColumnName("DOB_MM");
            entity.Property(e => e.DobYyyy)
                .HasMaxLength(50)
                .HasColumnName("DOB_YYYY");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Guardian).HasMaxLength(50);
            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.IsDobapproximate).HasColumnName("IsDOBApproximate");
            entity.Property(e => e.IsVip).HasColumnName("IsVIP");
            entity.Property(e => e.Lane).HasMaxLength(200);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrdtype)
                .HasMaxLength(50)
                .HasColumnName("MRDType");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.PatientName).HasMaxLength(50);
            entity.Property(e => e.PatientNo).HasMaxLength(200);
            entity.Property(e => e.PatientType).HasMaxLength(50);
            entity.Property(e => e.PreferredLanguage).HasMaxLength(50);
            entity.Property(e => e.ProfileUrl)
                .HasMaxLength(50)
                .HasColumnName("ProfileURL");
            entity.Property(e => e.ReceivedHostpitalNews).HasMaxLength(50);
            entity.Property(e => e.RegisterBy).HasMaxLength(50);
            entity.Property(e => e.RegisterationStatus).HasMaxLength(50);
            entity.Property(e => e.RegistrationOn).HasColumnType("datetime");
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.ResidentailPhone).HasMaxLength(50);
            entity.Property(e => e.Road).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Tilte).HasMaxLength(50);
            entity.Property(e => e.VippatientType)
                .HasMaxLength(50)
                .HasColumnName("VIPPatientType");
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrPatientDetailView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_PatientDetailView");

            entity.Property(e => e.AciveFrom).HasColumnType("datetime");
            entity.Property(e => e.ActiveTo).HasColumnType("datetime");
            entity.Property(e => e.AddressNo).HasMaxLength(50);
            entity.Property(e => e.Area).HasMaxLength(200);
            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.Building).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.DobDd)
                .HasMaxLength(50)
                .HasColumnName("DOB_DD");
            entity.Property(e => e.DobMm)
                .HasMaxLength(50)
                .HasColumnName("DOB_MM");
            entity.Property(e => e.DobYyyy)
                .HasMaxLength(50)
                .HasColumnName("DOB_YYYY");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Guardian).HasMaxLength(50);
            entity.Property(e => e.InsuranceCode).HasMaxLength(200);
            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.InsuranceName).HasMaxLength(200);
            entity.Property(e => e.IsDobapproximate).HasColumnName("IsDOBApproximate");
            entity.Property(e => e.IsVip).HasColumnName("IsVIP");
            entity.Property(e => e.Lane).HasMaxLength(200);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrdtype)
                .HasMaxLength(50)
                .HasColumnName("MRDType");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PatientName).HasMaxLength(50);
            entity.Property(e => e.PatientNo).HasMaxLength(200);
            entity.Property(e => e.PatientType).HasMaxLength(50);
            entity.Property(e => e.PreferredLanguage).HasMaxLength(50);
            entity.Property(e => e.ProfileUrl)
                .HasMaxLength(50)
                .HasColumnName("ProfileURL");
            entity.Property(e => e.ReceivedHostpitalNews).HasMaxLength(50);
            entity.Property(e => e.RegisterBy).HasMaxLength(50);
            entity.Property(e => e.RegisterationStatus).HasMaxLength(50);
            entity.Property(e => e.RegistrationOn).HasColumnType("datetime");
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.ResidentailPhone).HasMaxLength(50);
            entity.Property(e => e.Road).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Tilte).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VippatientType)
                .HasMaxLength(50)
                .HasColumnName("VIPPatientType");
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrPatientId>(entity =>
        {
            entity.HasKey(e => e.PatientIdentifierId);

            entity.ToTable("EMR_Patient_ID");

            entity.Property(e => e.PatientIdentifierId)
                .HasMaxLength(50)
                .HasColumnName("PatientIdentifierID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Idno)
                .HasMaxLength(50)
                .HasColumnName("IDNo");
            entity.Property(e => e.Idtype)
                .HasMaxLength(50)
                .HasColumnName("IDtype");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
        });

        modelBuilder.Entity<EmrPatientIdview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_Patient_IDView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Idno)
                .HasMaxLength(50)
                .HasColumnName("IDNo");
            entity.Property(e => e.Idtype)
                .HasMaxLength(50)
                .HasColumnName("IDtype");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PatientIdentifierId)
                .HasMaxLength(50)
                .HasColumnName("PatientIdentifierID");
            entity.Property(e => e.PatientName).HasMaxLength(50);
            entity.Property(e => e.PatientNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrPatientLetter>(entity =>
        {
            entity.HasKey(e => e.LetterId);

            entity.ToTable("EMR_PatientLetter");

            entity.Property(e => e.LetterId)
                .HasMaxLength(50)
                .HasColumnName("LetterID");
            entity.Property(e => e.ApprovalRemark).HasMaxLength(400);
            entity.Property(e => e.ApprovedById)
                .HasMaxLength(50)
                .HasColumnName("ApprovedByID");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LetterTypeId)
                .HasMaxLength(50)
                .HasColumnName("LetterTypeID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.VisitiId)
                .HasMaxLength(50)
                .HasColumnName("VisitiID");
        });

        modelBuilder.Entity<EmrPatientLetterView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_PatientLetterView");

            entity.Property(e => e.ApprovalRemark).HasMaxLength(400);
            entity.Property(e => e.ApprovedByCode).HasMaxLength(20);
            entity.Property(e => e.ApprovedById)
                .HasMaxLength(50)
                .HasColumnName("ApprovedByID");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LetterId)
                .HasMaxLength(50)
                .HasColumnName("LetterID");
            entity.Property(e => e.LetterTypeId)
                .HasMaxLength(50)
                .HasColumnName("LetterTypeID");
            entity.Property(e => e.LetterTypeName).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VisitiId)
                .HasMaxLength(50)
                .HasColumnName("VisitiID");
        });

        modelBuilder.Entity<EmrPatientOtherName>(entity =>
        {
            entity.HasKey(e => e.PatientOtherNameId);

            entity.ToTable("EMR_Patient_OtherName");

            entity.Property(e => e.PatientOtherNameId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PatientOtherNameID");
            entity.Property(e => e.AliasType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmrPatientOtherNameView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_Patient_OtherNameView");

            entity.Property(e => e.AliasType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PatientName).HasMaxLength(50);
            entity.Property(e => e.PatientNo).HasMaxLength(200);
            entity.Property(e => e.PatientOtherNameId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PatientOtherNameID");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmrPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("EMR_Payment");

            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .HasColumnName("PaymentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrPaymentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_PaymentView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .HasColumnName("PaymentID");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrPhysicalExam>(entity =>
        {
            entity.HasKey(e => e.PhysicalExamId);

            entity.ToTable("EMR_PhysicalExam");

            entity.Property(e => e.PhysicalExamId)
                .HasMaxLength(50)
                .HasColumnName("PhysicalExamID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExamDescription).HasMaxLength(1000);
            entity.Property(e => e.ExamOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrPhysicalExamView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_PhysicalExamView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExamDescription).HasMaxLength(1000);
            entity.Property(e => e.ExamOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.PhysicalExamId)
                .HasMaxLength(50)
                .HasColumnName("PhysicalExamID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrProgressNote>(entity =>
        {
            entity.HasKey(e => e.ProgressId);

            entity.ToTable("EMR_ProgressNote");

            entity.Property(e => e.ProgressId)
                .HasMaxLength(50)
                .HasColumnName("ProgressID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Progress).HasMaxLength(1000);
            entity.Property(e => e.ProgressOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrProgressNoteView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ProgressNoteView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Progress).HasMaxLength(1000);
            entity.Property(e => e.ProgressId)
                .HasMaxLength(50)
                .HasColumnName("ProgressID");
            entity.Property(e => e.ProgressOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrRecommendation>(entity =>
        {
            entity.HasKey(e => e.RecommendationId);

            entity.ToTable("EMR_Recommendation");

            entity.Property(e => e.RecommendationId)
                .HasMaxLength(50)
                .HasColumnName("RecommendationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemUnitId)
                .HasMaxLength(50)
                .HasColumnName("ItemUnitID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Level).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ParentRecordId)
                .HasMaxLength(100)
                .HasColumnName("ParentRecordID");
            entity.Property(e => e.ParentType).HasMaxLength(50);
            entity.Property(e => e.RecommendationInfo).HasMaxLength(500);
            entity.Property(e => e.SecondaryItemId)
                .HasMaxLength(50)
                .HasColumnName("SecondaryItemID");
            entity.Property(e => e.SecondaryType).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrRecommendationView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_RecommendationView");

            entity.Property(e => e.AllergyTypeName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUnitId)
                .HasMaxLength(50)
                .HasColumnName("ItemUnitID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Level).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ParentRecordId)
                .HasMaxLength(100)
                .HasColumnName("ParentRecordID");
            entity.Property(e => e.ParentType).HasMaxLength(50);
            entity.Property(e => e.RecommendationId)
                .HasMaxLength(50)
                .HasColumnName("RecommendationID");
            entity.Property(e => e.RecommendationInfo).HasMaxLength(500);
            entity.Property(e => e.SecondaryItemId)
                .HasMaxLength(50)
                .HasColumnName("SecondaryItemID");
            entity.Property(e => e.SecondaryType).HasMaxLength(50);
            entity.Property(e => e.UomLabel).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrServiceType>(entity =>
        {
            entity.ToTable("EMR_ServiceType");

            entity.Property(e => e.EmrserviceTypeId)
                .HasMaxLength(50)
                .HasColumnName("EMRServiceTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrServiceTypeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_ServiceTypeView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmrserviceTypeId)
                .HasMaxLength(50)
                .HasColumnName("EMRServiceTypeID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrSocialHistory>(entity =>
        {
            entity.HasKey(e => e.SocialHistoryId);

            entity.ToTable("EMR_SocialHistory");

            entity.Property(e => e.SocialHistoryId)
                .HasMaxLength(50)
                .HasColumnName("SocialHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.SocialHistory).HasMaxLength(1000);
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<EmrSocialHistoryView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_SocialHistoryView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoteOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.SocialHistory).HasMaxLength(1000);
            entity.Property(e => e.SocialHistoryId)
                .HasMaxLength(50)
                .HasColumnName("SocialHistoryID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
        });

        modelBuilder.Entity<EmrSpeciality>(entity =>
        {
            entity.HasKey(e => e.SpecialityId);

            entity.ToTable("EMR_Speciality");

            entity.Property(e => e.SpecialityId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SpecialityGroupId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityGroupID");
            entity.Property(e => e.SpecialityTitle).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrSpecialityGroup>(entity =>
        {
            entity.HasKey(e => e.SpecialityGroupId);

            entity.ToTable("EMR_SpecialityGroup");

            entity.Property(e => e.SpecialityGroupId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SpecialityGroupName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrSpecialityGroupView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_SpecialityGroupView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SpecialityGroupId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityGroupID");
            entity.Property(e => e.SpecialityGroupName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrSpecialityView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_SpecialityView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SpecialityGroupId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityGroupID");
            entity.Property(e => e.SpecialityGroupName).HasMaxLength(50);
            entity.Property(e => e.SpecialityId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityID");
            entity.Property(e => e.SpecialityTitle).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrStation>(entity =>
        {
            entity.HasKey(e => e.StationId);

            entity.ToTable("EMR_Station");

            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StationCode).HasMaxLength(50);
            entity.Property(e => e.StationName).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrStationView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_StationView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StationCode).HasMaxLength(50);
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.StationName).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrVisit>(entity =>
        {
            entity.HasKey(e => e.VisitId);

            entity.ToTable("EMR_Visit");

            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SpecialityId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VisitOn).HasColumnType("datetime");
            entity.Property(e => e.VisitType).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrVisitView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_VisitView");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
            entity.Property(e => e.ContactInfo).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.EmergencyContact).HasMaxLength(50);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SpecialityId)
                .HasMaxLength(50)
                .HasColumnName("SpecialityID");
            entity.Property(e => e.SpecialityTitle).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VisitOn).HasColumnType("datetime");
            entity.Property(e => e.VisitType).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmrVitalSign>(entity =>
        {
            entity.HasKey(e => e.VitalSignId);

            entity.ToTable("EMR_VitalSign");

            entity.Property(e => e.VitalSignId)
                .HasMaxLength(50)
                .HasColumnName("VitalSignID");
            entity.Property(e => e.Bmi)
                .HasMaxLength(50)
                .HasColumnName("BMI");
            entity.Property(e => e.Bsa)
                .HasMaxLength(50)
                .HasColumnName("BSA");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Diastolic).HasMaxLength(50);
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.MeanArterialPressure).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Oxygen).HasMaxLength(50);
            entity.Property(e => e.Pain).HasMaxLength(50);
            entity.Property(e => e.Pulse).HasMaxLength(50);
            entity.Property(e => e.PulsePressure).HasMaxLength(50);
            entity.Property(e => e.Respiratory).HasMaxLength(50);
            entity.Property(e => e.ShortIndex).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Systolic).HasMaxLength(50);
            entity.Property(e => e.Temperature).HasMaxLength(50);
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VitalSignOn).HasColumnType("datetime");
            entity.Property(e => e.Waist).HasMaxLength(50);
            entity.Property(e => e.Weight).HasMaxLength(50);
        });

        modelBuilder.Entity<EmrVitalSignView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMR_VitalSignView");

            entity.Property(e => e.Bmi)
                .HasMaxLength(50)
                .HasColumnName("BMI");
            entity.Property(e => e.Bsa)
                .HasMaxLength(50)
                .HasColumnName("BSA");
            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Diastolic).HasMaxLength(50);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.MeanArterialPressure).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.Oxygen).HasMaxLength(50);
            entity.Property(e => e.Pain).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Pulse).HasMaxLength(50);
            entity.Property(e => e.PulsePressure).HasMaxLength(50);
            entity.Property(e => e.Respiratory).HasMaxLength(50);
            entity.Property(e => e.ShortIndex).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Systolic).HasMaxLength(50);
            entity.Property(e => e.Temperature).HasMaxLength(50);
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VisitStatus).HasMaxLength(20);
            entity.Property(e => e.VisitType).HasMaxLength(50);
            entity.Property(e => e.VitalSignId)
                .HasMaxLength(50)
                .HasColumnName("VitalSignID");
            entity.Property(e => e.VitalSignOn).HasColumnType("datetime");
            entity.Property(e => e.Waist).HasMaxLength(50);
            entity.Property(e => e.Weight).HasMaxLength(50);
        });

        modelBuilder.Entity<FinConsignmentRefund>(entity =>
        {
            entity.HasKey(e => e.ConRefundId);

            entity.ToTable("Fin_ConsignmentRefund");

            entity.Property(e => e.ConRefundId)
                .HasMaxLength(50)
                .HasColumnName("ConRefundID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ConRefundNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<FinConsignmentRefundView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_ConsignmentRefundView");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ConRefundId)
                .HasMaxLength(50)
                .HasColumnName("ConRefundID");
            entity.Property(e => e.ConRefundNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<FinCreditPaid>(entity =>
        {
            entity.HasKey(e => e.CreditPaidId);

            entity.ToTable("Fin_CreditPaid");

            entity.Property(e => e.CreditPaidId)
                .HasMaxLength(50)
                .HasColumnName("CreditPaidID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPaidNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherAmount1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OtherTitle1).HasMaxLength(200);
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.VouncherAmount).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<FinCreditPaidItem>(entity =>
        {
            entity.HasKey(e => e.CreditPaidItemId);

            entity.ToTable("Fin_CreditPaidItem");

            entity.Property(e => e.CreditPaidItemId)
                .HasMaxLength(50)
                .HasColumnName("CreditPaidItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPaidId)
                .HasMaxLength(50)
                .HasColumnName("CreditPaidID");
            entity.Property(e => e.ItemAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RemainAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(1000);
        });

        modelBuilder.Entity<FinCreditPaidItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_CreditPaidItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPaidId)
                .HasMaxLength(50)
                .HasColumnName("CreditPaidID");
            entity.Property(e => e.CreditPaidItemId)
                .HasMaxLength(50)
                .HasColumnName("CreditPaidItemID");
            entity.Property(e => e.ItemAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RemainAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(1000);
        });

        modelBuilder.Entity<FinCreditPaidView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_CreditPaidView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPaidId)
                .HasMaxLength(50)
                .HasColumnName("CreditPaidID");
            entity.Property(e => e.CreditPaidNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherAmount1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OtherTitle1).HasMaxLength(200);
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.VouncherAmount).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<FinCreditReceive>(entity =>
        {
            entity.HasKey(e => e.CreditReceivedId);

            entity.ToTable("Fin_CreditReceive");

            entity.Property(e => e.CreditReceivedId)
                .HasMaxLength(50)
                .HasColumnName("CreditReceivedID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditReceivedNo).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherAmount1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OtherTitle1).HasMaxLength(200);
            entity.Property(e => e.ReceivedAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VouncherAmount).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<FinCreditReceiveItem>(entity =>
        {
            entity.HasKey(e => e.CreditReceivedItemId);

            entity.ToTable("Fin_CreditReceiveItem");

            entity.Property(e => e.CreditReceivedItemId)
                .HasMaxLength(50)
                .HasColumnName("CreditReceivedItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditReceivedId)
                .HasMaxLength(50)
                .HasColumnName("CreditReceivedID");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RemainAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(1000);
        });

        modelBuilder.Entity<FinCreditReceiveItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_CreditReceiveItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditReceivedId)
                .HasMaxLength(50)
                .HasColumnName("CreditReceivedID");
            entity.Property(e => e.CreditReceivedItemId)
                .HasMaxLength(50)
                .HasColumnName("CreditReceivedItemID");
            entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.ItemAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RemainAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(1000);
        });

        modelBuilder.Entity<FinCreditReceiveView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_CreditReceiveView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditReceivedId)
                .HasMaxLength(50)
                .HasColumnName("CreditReceivedID");
            entity.Property(e => e.CreditReceivedNo).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherAmount1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OtherTitle1).HasMaxLength(200);
            entity.Property(e => e.ReceivedAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VouncherAmount).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<FinDeposit>(entity =>
        {
            entity.HasKey(e => e.DepositId);

            entity.ToTable("Fin_Deposit");

            entity.Property(e => e.DepositId)
                .HasMaxLength(50)
                .HasColumnName("DepositID");
            entity.Property(e => e.ApprovedbyId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedbyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Deposit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DepositDate)
                .HasColumnType("datetime")
                .HasColumnName("depositDate");
            entity.Property(e => e.DepositVoucherNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .HasColumnName("RefNO");
            entity.Property(e => e.Remains).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SalePersonId)
                .HasMaxLength(50)
                .HasColumnName("salePersonID");
            entity.Property(e => e.UseAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<FinDepositView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_DepositView");

            entity.Property(e => e.ApprovedbyId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedbyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Deposit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DepositDate)
                .HasColumnType("datetime")
                .HasColumnName("depositDate");
            entity.Property(e => e.DepositId)
                .HasMaxLength(50)
                .HasColumnName("DepositID");
            entity.Property(e => e.DepositVoucherNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorName).HasMaxLength(150);
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .HasColumnName("RefNO");
            entity.Property(e => e.Remains).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SalePersonId)
                .HasMaxLength(50)
                .HasColumnName("salePersonID");
            entity.Property(e => e.UseAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<FinExpense>(entity =>
        {
            entity.HasKey(e => e.ExpenseId);

            entity.ToTable("Fin_Expense");

            entity.Property(e => e.ExpenseId)
                .HasMaxLength(50)
                .HasColumnName("ExpenseID");
            entity.Property(e => e.AdminNote).HasMaxLength(1000);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExpenseCode).HasMaxLength(200);
            entity.Property(e => e.ExpenseNo).HasMaxLength(50);
            entity.Property(e => e.ExpenseOn).HasColumnType("datetime");
            entity.Property(e => e.ExpenseSessionId)
                .HasMaxLength(50)
                .HasColumnName("ExpenseSessionID");
            entity.Property(e => e.ExpenseStatus).HasMaxLength(50);
            entity.Property(e => e.Hashkeys).HasMaxLength(300);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("OperatorID");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<FinExpenseSession>(entity =>
        {
            entity.HasKey(e => e.ExpenseSessionId);

            entity.ToTable("Fin_ExpenseSession");

            entity.Property(e => e.ExpenseSessionId)
                .HasMaxLength(50)
                .HasColumnName("ExpenseSessionID");
            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExpenseCode).HasMaxLength(200);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SearchWords).HasMaxLength(50);
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SessionTitle).HasMaxLength(300);
        });

        modelBuilder.Entity<FinExpenseSessionView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_ExpenseSessionView");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExpenseCode).HasMaxLength(200);
            entity.Property(e => e.ExpenseSessionId)
                .HasMaxLength(50)
                .HasColumnName("ExpenseSessionID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SearchWords).HasMaxLength(50);
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SessionTitle).HasMaxLength(300);
        });

        modelBuilder.Entity<FinExpenseView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_ExpenseView");

            entity.Property(e => e.AdminNote).HasMaxLength(1000);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExpenseCode).HasMaxLength(200);
            entity.Property(e => e.ExpenseId)
                .HasMaxLength(50)
                .HasColumnName("ExpenseID");
            entity.Property(e => e.ExpenseNo).HasMaxLength(50);
            entity.Property(e => e.ExpenseOn).HasColumnType("datetime");
            entity.Property(e => e.ExpenseSessionId)
                .HasMaxLength(50)
                .HasColumnName("ExpenseSessionID");
            entity.Property(e => e.ExpenseStatus).HasMaxLength(50);
            entity.Property(e => e.Hashkeys).HasMaxLength(300);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorCode).HasMaxLength(200);
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("OperatorID");
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SessionTitle).HasMaxLength(300);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<FinIncome>(entity =>
        {
            entity.HasKey(e => e.IncomeId);

            entity.ToTable("Fin_Income");

            entity.Property(e => e.IncomeId)
                .HasMaxLength(50)
                .HasColumnName("IncomeID");
            entity.Property(e => e.AdminNote).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.HashKeys).HasMaxLength(300);
            entity.Property(e => e.IncomeCode).HasMaxLength(300);
            entity.Property(e => e.IncomeNo).HasMaxLength(50);
            entity.Property(e => e.IncomeOn).HasColumnType("datetime");
            entity.Property(e => e.IncomeSessionId)
                .HasMaxLength(50)
                .HasColumnName("IncomeSessionID");
            entity.Property(e => e.IncomeStatus).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("OperatorID");
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<FinIncomeSession>(entity =>
        {
            entity.HasKey(e => e.IncomeSessionId);

            entity.ToTable("Fin_IncomeSession");

            entity.Property(e => e.IncomeSessionId)
                .HasMaxLength(50)
                .HasColumnName("IncomeSessionID");
            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncomeCode).HasMaxLength(200);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SearchWord).HasMaxLength(500);
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SessionTitle).HasMaxLength(300);
        });

        modelBuilder.Entity<FinIncomeSessionView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_IncomeSessionView");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncomeCode).HasMaxLength(200);
            entity.Property(e => e.IncomeSessionId)
                .HasMaxLength(50)
                .HasColumnName("IncomeSessionID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SearchWord).HasMaxLength(500);
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SessionTitle).HasMaxLength(300);
        });

        modelBuilder.Entity<FinIncomeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_IncomeView");

            entity.Property(e => e.AdminNote).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.HashKeys).HasMaxLength(300);
            entity.Property(e => e.IncomeCode).HasMaxLength(300);
            entity.Property(e => e.IncomeId)
                .HasMaxLength(50)
                .HasColumnName("IncomeID");
            entity.Property(e => e.IncomeNo).HasMaxLength(50);
            entity.Property(e => e.IncomeOn).HasColumnType("datetime");
            entity.Property(e => e.IncomeSessionId)
                .HasMaxLength(50)
                .HasColumnName("IncomeSessionID");
            entity.Property(e => e.IncomeStatus).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorCode).HasMaxLength(200);
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("OperatorID");
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.Seq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SessionTitle).HasMaxLength(300);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<FinIncomeWeek>(entity =>
        {
            entity.HasKey(e => e.IncomeWeekId);

            entity.ToTable("Fin_IncomeWeek");

            entity.Property(e => e.IncomeWeekId)
                .HasMaxLength(50)
                .HasColumnName("IncomeWeekID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditReceive).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IncomeId)
                .HasMaxLength(50)
                .HasColumnName("IncomeID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherIncome).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RealCreditReceive)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_CreditReceive");
            entity.Property(e => e.RealOtherIncome)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_OtherIncome");
            entity.Property(e => e.RealSaleIncome)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_SaleIncome");
            entity.Property(e => e.RealTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_Total");
            entity.Property(e => e.SaleIncome).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.WeekName).HasMaxLength(100);
        });

        modelBuilder.Entity<FinIncomeWeekView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_IncomeWeekView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditReceive).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IncomeId)
                .HasMaxLength(50)
                .HasColumnName("IncomeID");
            entity.Property(e => e.IncomeWeekId)
                .HasMaxLength(50)
                .HasColumnName("IncomeWeekID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherIncome).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RealCreditReceive)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_CreditReceive");
            entity.Property(e => e.RealOtherIncome)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_OtherIncome");
            entity.Property(e => e.RealSaleIncome)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_SaleIncome");
            entity.Property(e => e.RealTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Real_Total");
            entity.Property(e => e.SaleIncome).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.WeekName).HasMaxLength(100);
        });

        modelBuilder.Entity<FinPo>(entity =>
        {
            entity.HasKey(e => e.Poid);

            entity.ToTable("Fin_PO");

            entity.Property(e => e.Poid)
                .HasMaxLength(50)
                .HasColumnName("POID");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommercialTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommercialTaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPaidAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InternalPono)
                .HasMaxLength(50)
                .HasColumnName("InternalPONo");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Other1Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Other1Title).HasMaxLength(50);
            entity.Property(e => e.Other2Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Other2Title).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus).HasMaxLength(50);
            entity.Property(e => e.Podate)
                .HasColumnType("datetime")
                .HasColumnName("PODate");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SalePersonId)
                .HasMaxLength(50)
                .HasColumnName("SalePersonID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalItemCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.VoucherPayAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FinPoitem>(entity =>
        {
            entity.HasKey(e => e.PoitemId);

            entity.ToTable("Fin_POItem");

            entity.Property(e => e.PoitemId)
                .HasMaxLength(50)
                .HasColumnName("POItemID");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Poid)
                .HasMaxLength(50)
                .HasColumnName("POID");
            entity.Property(e => e.Poqty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("POQty");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RemainingQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalPoqty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TotalPOQty");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<FinPoitemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_POItemView");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.InternalPono)
                .HasMaxLength(50)
                .HasColumnName("InternalPONo");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Podate)
                .HasColumnType("datetime")
                .HasColumnName("PODate");
            entity.Property(e => e.Poid)
                .HasMaxLength(50)
                .HasColumnName("POID");
            entity.Property(e => e.PoitemId)
                .HasMaxLength(50)
                .HasColumnName("POItemID");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.Poqty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("POQty");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RemainingQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalPoqty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TotalPOQty");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<FinPoview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_POView");

            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommercialTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommercialTaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPaidAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InternalPono)
                .HasMaxLength(50)
                .HasColumnName("InternalPONo");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Other1Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Other1Title).HasMaxLength(50);
            entity.Property(e => e.Other2Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Other2Title).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus).HasMaxLength(50);
            entity.Property(e => e.Podate)
                .HasColumnType("datetime")
                .HasColumnName("PODate");
            entity.Property(e => e.Poid)
                .HasMaxLength(50)
                .HasColumnName("POID");
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .HasColumnName("PONo");
            entity.Property(e => e.Received).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Remain).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SalePersonId)
                .HasMaxLength(50)
                .HasColumnName("SalePersonID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalItemCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPoqty)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("TotalPOQty");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VoucherPayAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FinSaleReturn>(entity =>
        {
            entity.HasKey(e => e.ReturnId);

            entity.ToTable("Fin_SaleReturn");

            entity.Property(e => e.ReturnId)
                .HasMaxLength(50)
                .HasColumnName("ReturnID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.Property(e => e.ReceiptById)
                .HasMaxLength(50)
                .HasColumnName("ReceiptByID");
            entity.Property(e => e.RefundAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnNo).HasMaxLength(50);
            entity.Property(e => e.ReturnStatus).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<FinSaleReturnItem>(entity =>
        {
            entity.HasKey(e => e.ReturnItemId).HasName("PK_INV_SaleReturnItem");

            entity.ToTable("Fin_SaleReturnItem");

            entity.Property(e => e.ReturnItemId)
                .HasMaxLength(50)
                .HasColumnName("ReturnItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromLocationId)
                .HasMaxLength(50)
                .HasColumnName("FromLocationID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ReturnId)
                .HasMaxLength(50)
                .HasColumnName("ReturnID");
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TakenQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ToLocationId)
                .HasMaxLength(50)
                .HasColumnName("ToLocationID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<FinSaleReturnItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_SaleReturnItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromLocationId)
                .HasMaxLength(50)
                .HasColumnName("FromLocationID");
            entity.Property(e => e.FromLocationName).HasMaxLength(500);
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnId)
                .HasMaxLength(50)
                .HasColumnName("ReturnID");
            entity.Property(e => e.ReturnItemId)
                .HasMaxLength(50)
                .HasColumnName("ReturnItemID");
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReturnStatus).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TakenQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ToLocationId)
                .HasMaxLength(50)
                .HasColumnName("ToLocationID");
            entity.Property(e => e.ToLocationName).HasMaxLength(500);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<FinSaleReturnView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fin_SaleReturnView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.Property(e => e.ReceiptById)
                .HasMaxLength(50)
                .HasColumnName("ReceiptByID");
            entity.Property(e => e.RefundAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnId)
                .HasMaxLength(50)
                .HasColumnName("ReturnID");
            entity.Property(e => e.ReturnNo).HasMaxLength(50);
            entity.Property(e => e.ReturnStatus).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<InvAdjustment>(entity =>
        {
            entity.HasKey(e => e.AdjustmentId);

            entity.ToTable("INV_Adjustment");

            entity.Property(e => e.AdjustmentId)
                .HasMaxLength(50)
                .HasColumnName("AdjustmentID");
            entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustmentNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
        });

        modelBuilder.Entity<InvAdjustmentItem>(entity =>
        {
            entity.HasKey(e => e.AdjustmentItemId);

            entity.ToTable("INV_AdjustmentItem");

            entity.Property(e => e.AdjustmentItemId)
                .HasMaxLength(50)
                .HasColumnName("AdjustmentItemID");
            entity.Property(e => e.ActualQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AdjustQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AdjustmentId)
                .HasMaxLength(50)
                .HasColumnName("AdjustmentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SystemQty).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<InvAdjustmentItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_AdjustmentItemView");

            entity.Property(e => e.ActualQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AdjustQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustmentId)
                .HasMaxLength(50)
                .HasColumnName("AdjustmentID");
            entity.Property(e => e.AdjustmentItemId)
                .HasMaxLength(50)
                .HasColumnName("AdjustmentItemID");
            entity.Property(e => e.AdjustmentNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.IsStockCount).HasColumnName("isStockCount");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SystemQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
        });

        modelBuilder.Entity<InvAdjustmentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_AdjustmentView");

            entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustmentId)
                .HasMaxLength(50)
                .HasColumnName("AdjustmentID");
            entity.Property(e => e.AdjustmentNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
        });

        modelBuilder.Entity<InvConsignment>(entity =>
        {
            entity.HasKey(e => e.Csid);

            entity.ToTable("INV_Consignment");

            entity.Property(e => e.Csid)
                .HasMaxLength(50)
                .HasColumnName("CSID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Csno)
                .HasMaxLength(50)
                .HasColumnName("CSNo");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("StoreID");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<InvConsignmentItem>(entity =>
        {
            entity.HasKey(e => e.CsitemId);

            entity.ToTable("INV_ConsignmentItem");

            entity.Property(e => e.CsitemId)
                .HasMaxLength(50)
                .HasColumnName("CSItemID");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Csid)
                .HasMaxLength(50)
                .HasColumnName("CSID");
            entity.Property(e => e.CsrealItemId)
                .HasMaxLength(50)
                .HasColumnName("CSRealItemID");
            entity.Property(e => e.DefQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefItemId)
                .HasMaxLength(50)
                .HasColumnName("RefItemID");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvConsignmentItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_ConsignmentItemView");

            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Csid)
                .HasMaxLength(50)
                .HasColumnName("CSID");
            entity.Property(e => e.CsitemId)
                .HasMaxLength(50)
                .HasColumnName("CSItemID");
            entity.Property(e => e.Csno)
                .HasMaxLength(50)
                .HasColumnName("CSNo");
            entity.Property(e => e.CsrealItemId)
                .HasMaxLength(50)
                .HasColumnName("CSRealItemID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DefQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefItemId)
                .HasMaxLength(50)
                .HasColumnName("RefItemID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("StoreID");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvConsignmentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_ConsignmentView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Csid)
                .HasMaxLength(50)
                .HasColumnName("CSID");
            entity.Property(e => e.Csno)
                .HasMaxLength(50)
                .HasColumnName("CSNo");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("StoreID");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<InvExpireIn>(entity =>
        {
            entity.HasKey(e => e.ExpireInId);

            entity.ToTable("INV_ExpireIn");

            entity.Property(e => e.ExpireInId)
                .HasMaxLength(50)
                .HasColumnName("ExpireInID");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.TotalOutQty).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<InvExpireInView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_ExpireInView");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExDate).HasColumnType("datetime");
            entity.Property(e => e.ExStatus).HasMaxLength(50);
            entity.Property(e => e.ExpireInId)
                .HasMaxLength(50)
                .HasColumnName("ExpireInID");
            entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.RemainQty).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.TotalOutQty).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<InvExpireOut>(entity =>
        {
            entity.HasKey(e => e.ExpireOutId);

            entity.ToTable("INV_ExpireOut");

            entity.Property(e => e.ExpireOutId)
                .HasMaxLength(50)
                .HasColumnName("ExpireOutID");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExpireInId)
                .HasMaxLength(50)
                .HasColumnName("ExpireInID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OutQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefType).HasMaxLength(50);
        });

        modelBuilder.Entity<InvExpireOutView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_ExpireOutView");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExpireInId)
                .HasMaxLength(50)
                .HasColumnName("ExpireInID");
            entity.Property(e => e.ExpireOutId)
                .HasMaxLength(50)
                .HasColumnName("ExpireOutID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OutQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefDate).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefType).HasMaxLength(50);
        });

        modelBuilder.Entity<InvLocationMove>(entity =>
        {
            entity.HasKey(e => e.LocationMoveId);

            entity.ToTable("INV_LocationMove");

            entity.Property(e => e.LocationMoveId)
                .HasMaxLength(50)
                .HasColumnName("LocationMoveID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationIdfrom)
                .HasMaxLength(50)
                .HasColumnName("LocationIDFrom");
            entity.Property(e => e.LocationIdto)
                .HasMaxLength(50)
                .HasColumnName("LocationIDTo");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MoveDate).HasColumnType("datetime");
            entity.Property(e => e.MoveNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<InvLocationMoveItem>(entity =>
        {
            entity.HasKey(e => e.LocationMoveItemId);

            entity.ToTable("INV_LocationMoveItem");

            entity.Property(e => e.LocationMoveItemId)
                .HasMaxLength(50)
                .HasColumnName("LocationMoveItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationMoveId)
                .HasMaxLength(50)
                .HasColumnName("LocationMoveID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MoveQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TotalMoveQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvLocationMoveItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_LocationMoveItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationIdfrom)
                .HasMaxLength(50)
                .HasColumnName("LocationIDFrom");
            entity.Property(e => e.LocationIdto)
                .HasMaxLength(50)
                .HasColumnName("LocationIDTo");
            entity.Property(e => e.LocationMoveId)
                .HasMaxLength(50)
                .HasColumnName("LocationMoveID");
            entity.Property(e => e.LocationMoveItemId)
                .HasMaxLength(50)
                .HasColumnName("LocationMoveItemID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MoveDate).HasColumnType("datetime");
            entity.Property(e => e.MoveNo).HasMaxLength(50);
            entity.Property(e => e.MoveQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalMoveQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvLocationMoveView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_LocationMoveView");

            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromLocationCode).HasMaxLength(100);
            entity.Property(e => e.FromLocationName).HasMaxLength(500);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationIdfrom)
                .HasMaxLength(50)
                .HasColumnName("LocationIDFrom");
            entity.Property(e => e.LocationIdto)
                .HasMaxLength(50)
                .HasColumnName("LocationIDTo");
            entity.Property(e => e.LocationMoveId)
                .HasMaxLength(50)
                .HasColumnName("LocationMoveID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MoveDate).HasColumnType("datetime");
            entity.Property(e => e.MoveNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.ToLocationCode).HasMaxLength(100);
            entity.Property(e => e.ToLocationName).HasMaxLength(500);
        });

        modelBuilder.Entity<InvMr>(entity =>
        {
            entity.HasKey(e => e.Mrid);

            entity.ToTable("INV_MR");

            entity.Property(e => e.Mrid)
                .HasMaxLength(50)
                .HasColumnName("MRID");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrdate)
                .HasColumnType("datetime")
                .HasColumnName("MRDate");
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNo");
            entity.Property(e => e.Mrstatus)
                .HasMaxLength(50)
                .HasColumnName("MRStatus");
            entity.Property(e => e.Mrtype)
                .HasMaxLength(50)
                .HasColumnName("MRType");
            entity.Property(e => e.RequestById)
                .HasMaxLength(50)
                .HasColumnName("RequestByID");
            entity.Property(e => e.RequestToId)
                .HasMaxLength(50)
                .HasColumnName("RequestToID");
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.SuperApprovedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMritem>(entity =>
        {
            entity.HasKey(e => e.MritemId);

            entity.ToTable("INV_MRItem");

            entity.Property(e => e.MritemId)
                .HasMaxLength(50)
                .HasColumnName("MRItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrid)
                .HasMaxLength(200)
                .HasColumnName("MRID");
            entity.Property(e => e.RemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.RequestQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalRemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvMritemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_MRItemView");

            entity.Property(e => e.AprrovedByUser).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrdate)
                .HasColumnType("datetime")
                .HasColumnName("MRDate");
            entity.Property(e => e.Mrid)
                .HasMaxLength(200)
                .HasColumnName("MRID");
            entity.Property(e => e.MritemId)
                .HasMaxLength(50)
                .HasColumnName("MRItemID");
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNo");
            entity.Property(e => e.Mrstatus)
                .HasMaxLength(50)
                .HasColumnName("MRStatus");
            entity.Property(e => e.Mrtype)
                .HasMaxLength(50)
                .HasColumnName("MRType");
            entity.Property(e => e.RemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.RequestQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.StationName).HasMaxLength(50);
            entity.Property(e => e.SuperApprovedByUser).HasMaxLength(150);
            entity.Property(e => e.TotalRemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvMrview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_MRVIew");

            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.AprrovedByUser).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrdate)
                .HasColumnType("datetime")
                .HasColumnName("MRDate");
            entity.Property(e => e.Mrid)
                .HasMaxLength(50)
                .HasColumnName("MRID");
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNo");
            entity.Property(e => e.Mrstatus)
                .HasMaxLength(50)
                .HasColumnName("MRStatus");
            entity.Property(e => e.Mrtype)
                .HasMaxLength(50)
                .HasColumnName("MRType");
            entity.Property(e => e.RequestById)
                .HasMaxLength(50)
                .HasColumnName("RequestByID");
            entity.Property(e => e.RequestByUser).HasMaxLength(150);
            entity.Property(e => e.RequestToId)
                .HasMaxLength(50)
                .HasColumnName("RequestToID");
            entity.Property(e => e.RequestToUser).HasMaxLength(150);
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.StationName).HasMaxLength(50);
            entity.Property(e => e.SuperApprovedBy).HasMaxLength(50);
            entity.Property(e => e.SuperApprovedByUser).HasMaxLength(150);
        });

        modelBuilder.Entity<InvStockException>(entity =>
        {
            entity.HasKey(e => e.StockExceptionId);

            entity.ToTable("INV_StockException");

            entity.Property(e => e.StockExceptionId)
                .HasMaxLength(50)
                .HasColumnName("StockExceptionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ExceptionNo).HasMaxLength(50);
            entity.Property(e => e.ExceptionType).HasMaxLength(50);
            entity.Property(e => e.FromLocation).HasMaxLength(50);
            entity.Property(e => e.FromStation).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RequestBy).HasMaxLength(50);
            entity.Property(e => e.RequestOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusBy).HasMaxLength(50);
            entity.Property(e => e.StatusOn).HasColumnType("datetime");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.ToLocation).HasMaxLength(50);
            entity.Property(e => e.ToStation).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<InvStockExceptionItem>(entity =>
        {
            entity.HasKey(e => e.StockExceptionItemId);

            entity.ToTable("INV_StockExceptionItem");

            entity.Property(e => e.StockExceptionItemId)
                .HasMaxLength(50)
                .HasColumnName("StockExceptionItemID");
            entity.Property(e => e.Cost).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasMaxLength(50)
                .HasColumnName("QTY");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.StockExceptionId)
                .HasMaxLength(50)
                .HasColumnName("StockExceptionID");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<InvStockExceptionItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StockExceptionItemView");

            entity.Property(e => e.Cost).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByName).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByName).HasMaxLength(150);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasMaxLength(50)
                .HasColumnName("QTY");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.RfDate).HasColumnType("datetime");
            entity.Property(e => e.StockExceptionId)
                .HasMaxLength(50)
                .HasColumnName("StockExceptionID");
            entity.Property(e => e.StockExceptionItemId)
                .HasMaxLength(50)
                .HasColumnName("StockExceptionItemID");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvStockExceptionView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StockExceptionView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByName).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ExceptionNo).HasMaxLength(50);
            entity.Property(e => e.ExceptionType).HasMaxLength(50);
            entity.Property(e => e.FromLocation).HasMaxLength(50);
            entity.Property(e => e.FromLocationName).HasMaxLength(500);
            entity.Property(e => e.FromStation).HasMaxLength(50);
            entity.Property(e => e.FromStationName).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByName).HasMaxLength(150);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RequestBy).HasMaxLength(50);
            entity.Property(e => e.RequestByName).HasMaxLength(150);
            entity.Property(e => e.RequestOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusBy).HasMaxLength(50);
            entity.Property(e => e.StatusByName).HasMaxLength(150);
            entity.Property(e => e.StatusOn).HasColumnType("datetime");
            entity.Property(e => e.StockExceptionId)
                .HasMaxLength(50)
                .HasColumnName("StockExceptionID");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.ToLocation).HasMaxLength(50);
            entity.Property(e => e.ToLocationName).HasMaxLength(500);
            entity.Property(e => e.ToStation).HasMaxLength(50);
            entity.Property(e => e.ToStationName).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<InvStockFlow>(entity =>
        {
            entity.HasKey(e => e.StockFlowId).HasName("PK_ST_StockFlow");

            entity.ToTable("INV_StockFlow");

            entity.Property(e => e.StockFlowId)
                .HasMaxLength(50)
                .HasColumnName("StockFlowID");
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlowBy).HasMaxLength(50);
            entity.Property(e => e.FlowOn).HasColumnType("datetime");
            entity.Property(e => e.FlowQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FlowTitle).HasMaxLength(50);
            entity.Property(e => e.FlowType).HasMaxLength(50);
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.OwnerRefId)
                .HasMaxLength(50)
                .HasColumnName("OwnerRefID");
            entity.Property(e => e.OwnerRefType).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.SubRefId)
                .HasMaxLength(50)
                .HasColumnName("SubRefID");
            entity.Property(e => e.SubRefType).HasMaxLength(50);
        });

        modelBuilder.Entity<InvStockFlowView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StockFlowView");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlowBy).HasMaxLength(50);
            entity.Property(e => e.FlowOn).HasColumnType("datetime");
            entity.Property(e => e.FlowQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FlowTitle).HasMaxLength(50);
            entity.Property(e => e.FlowType).HasMaxLength(50);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.OwnerRefId)
                .HasMaxLength(50)
                .HasColumnName("OwnerRefID");
            entity.Property(e => e.OwnerRefType).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.SalePerson).HasMaxLength(150);
            entity.Property(e => e.StockFlowId)
                .HasMaxLength(50)
                .HasColumnName("StockFlowID");
            entity.Property(e => e.SubRefId)
                .HasMaxLength(50)
                .HasColumnName("SubRefID");
            entity.Property(e => e.SubRefType).HasMaxLength(50);
        });

        modelBuilder.Entity<InvStockIn>(entity =>
        {
            entity.HasKey(e => e.StockInId);

            entity.ToTable("INV_StockIn");

            entity.Property(e => e.StockInId)
                .HasMaxLength(50)
                .HasColumnName("StockInID");
            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StockInDate).HasColumnType("datetime");
            entity.Property(e => e.StockInNo).HasMaxLength(50);
            entity.Property(e => e.StockInStatus).HasMaxLength(50);
            entity.Property(e => e.StockInSupplierId)
                .HasMaxLength(50)
                .HasColumnName("StockInSupplierID");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<InvStockInItem>(entity =>
        {
            entity.HasKey(e => e.StockInItemId);

            entity.ToTable("INV_StockInItem");

            entity.Property(e => e.StockInItemId)
                .HasMaxLength(50)
                .HasColumnName("StockInItemID");
            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ManufactureId)
                .HasMaxLength(50)
                .HasColumnName("ManufactureID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StockInId)
                .HasMaxLength(50)
                .HasColumnName("StockInID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalInQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvStockInItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StockInItemView");

            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ManufactureId)
                .HasMaxLength(50)
                .HasColumnName("ManufactureID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StockInDate).HasColumnType("datetime");
            entity.Property(e => e.StockInId)
                .HasMaxLength(50)
                .HasColumnName("StockInID");
            entity.Property(e => e.StockInItemId)
                .HasMaxLength(50)
                .HasColumnName("StockInItemID");
            entity.Property(e => e.StockInNo).HasMaxLength(50);
            entity.Property(e => e.StockInStatus).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalInQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvStockInView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StockInView");

            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StockInDate).HasColumnType("datetime");
            entity.Property(e => e.StockInId)
                .HasMaxLength(50)
                .HasColumnName("StockInID");
            entity.Property(e => e.StockInNo).HasMaxLength(50);
            entity.Property(e => e.StockInStatus).HasMaxLength(50);
            entity.Property(e => e.StockInSupplierId)
                .HasMaxLength(50)
                .HasColumnName("StockInSupplierID");
            entity.Property(e => e.StockInSupplierName).HasMaxLength(300);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<InvStockReportView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Inv_StockReportView");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.AddedByCode).HasMaxLength(20);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Expr1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Expr2).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Expr4).HasMaxLength(50);
            entity.Property(e => e.Expr5).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Expr6).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Expr8).HasColumnType("datetime");
            entity.Property(e => e.Focqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FOCQty");
            entity.Property(e => e.Focunit)
                .HasMaxLength(50)
                .HasColumnName("FOCUnit");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceItemId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceItemID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.PoitemId)
                .HasMaxLength(50)
                .HasColumnName("POItemID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.ReferenceType).HasMaxLength(50);
            entity.Property(e => e.RemainingQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.StockLedgerId)
                .HasMaxLength(50)
                .HasColumnName("StockLedgerID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<InvStockRequest>(entity =>
        {
            entity.HasKey(e => e.StockRequestId);

            entity.ToTable("INV_StockRequest");

            entity.Property(e => e.StockRequestId)
                .HasMaxLength(50)
                .HasColumnName("StockRequestID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnit).HasMaxLength(50);
            entity.Property(e => e.IssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.RemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RequestOn).HasColumnType("datetime");
            entity.Property(e => e.RequestQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RequestTitle).HasMaxLength(50);
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.SubRefId)
                .HasMaxLength(50)
                .HasColumnName("SubRefID");
            entity.Property(e => e.SubRefType).HasMaxLength(50);
            entity.Property(e => e.TotalIssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalRemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalRequestQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvStoreIssue>(entity =>
        {
            entity.HasKey(e => e.IssueId);

            entity.ToTable("INV_StoreIssue");

            entity.Property(e => e.IssueId)
                .HasMaxLength(50)
                .HasColumnName("IssueID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IssueBy).HasMaxLength(50);
            entity.Property(e => e.IssueNo).HasMaxLength(200);
            entity.Property(e => e.IssueOn).HasColumnType("datetime");
            entity.Property(e => e.IssueStatus).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrid)
                .HasMaxLength(50)
                .HasColumnName("MRID");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
        });

        modelBuilder.Entity<InvStoreIssueItem>(entity =>
        {
            entity.HasKey(e => e.IssueItemId);

            entity.ToTable("INV_StoreIssueItem");

            entity.Property(e => e.IssueItemId)
                .HasMaxLength(50)
                .HasColumnName("IssueItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IssueBarcodes).HasMaxLength(50);
            entity.Property(e => e.IssueId)
                .HasMaxLength(50)
                .HasColumnName("IssueID");
            entity.Property(e => e.IssueRemarks).HasMaxLength(50);
            entity.Property(e => e.IssuedQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IssuedUom)
                .HasMaxLength(50)
                .HasColumnName("IssuedUOM");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.StockInHand).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalIssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvStoreIssueItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StoreIssueItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IssueBarcodes).HasMaxLength(50);
            entity.Property(e => e.IssueId)
                .HasMaxLength(50)
                .HasColumnName("IssueID");
            entity.Property(e => e.IssueItemId)
                .HasMaxLength(50)
                .HasColumnName("IssueItemID");
            entity.Property(e => e.IssueNo).HasMaxLength(200);
            entity.Property(e => e.IssueOn).HasColumnType("datetime");
            entity.Property(e => e.IssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IssueRemarks).HasMaxLength(50);
            entity.Property(e => e.IssueStatus).HasMaxLength(50);
            entity.Property(e => e.IssuedQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IssuedUom)
                .HasMaxLength(50)
                .HasColumnName("IssuedUOM");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrid)
                .HasMaxLength(50)
                .HasColumnName("MRID");
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNo");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.RequestQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.StockInHand).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalIssueQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalRemainQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvStoreIssueView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StoreIssueView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IssueBy).HasMaxLength(50);
            entity.Property(e => e.IssueId)
                .HasMaxLength(50)
                .HasColumnName("IssueID");
            entity.Property(e => e.IssueNo).HasMaxLength(200);
            entity.Property(e => e.IssueOn).HasColumnType("datetime");
            entity.Property(e => e.IssuePersonCode).HasMaxLength(20);
            entity.Property(e => e.IssuePersonName).HasMaxLength(150);
            entity.Property(e => e.IssueStatus).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Mrid)
                .HasMaxLength(50)
                .HasColumnName("MRID");
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNo");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.StationName).HasMaxLength(50);
        });

        modelBuilder.Entity<InvStoreReceipt>(entity =>
        {
            entity.HasKey(e => e.ReceiptId);

            entity.ToTable("INV_StoreReceipt");

            entity.Property(e => e.ReceiptId)
                .HasMaxLength(50)
                .HasColumnName("ReceiptID");
            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.Property(e => e.ReceiptById)
                .HasMaxLength(50)
                .HasColumnName("ReceiptByID");
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.ReceiptOn).HasColumnType("datetime");
            entity.Property(e => e.ReceiptStatus).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SrrefId)
                .HasMaxLength(50)
                .HasColumnName("SRRefID");
            entity.Property(e => e.SrrefNo)
                .HasMaxLength(50)
                .HasColumnName("SRRefNo");
            entity.Property(e => e.SrrefType)
                .HasMaxLength(50)
                .HasColumnName("SRRefType");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
        });

        modelBuilder.Entity<InvStoreReceiptItem>(entity =>
        {
            entity.HasKey(e => e.ReceiptItemId);

            entity.ToTable("INV_StoreReceiptItem");

            entity.Property(e => e.ReceiptItemId)
                .HasMaxLength(50)
                .HasColumnName("ReceiptItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(50)
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiptQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TotalReceiptQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<InvStoreReceiptItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StoreReceiptItemView");

            entity.Property(e => e.Balance).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GenericId)
                .HasMaxLength(50)
                .HasColumnName("GenericID");
            entity.Property(e => e.IsCheckExpire).HasColumnName("isCheckExpire");
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemUomid)
                .HasMaxLength(50)
                .HasColumnName("ItemUOMID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.Property(e => e.ReceiptById)
                .HasMaxLength(50)
                .HasColumnName("ReceiptByID");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(50)
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiptItemId)
                .HasMaxLength(50)
                .HasColumnName("ReceiptItemID");
            entity.Property(e => e.ReceiptLocation)
                .HasMaxLength(50)
                .HasColumnName("receiptLocation");
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.ReceiptOn).HasColumnType("datetime");
            entity.Property(e => e.ReceiptPersonName).HasMaxLength(150);
            entity.Property(e => e.ReceiptQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReceiptStatus).HasMaxLength(50);
            entity.Property(e => e.RefQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SrrefId)
                .HasMaxLength(50)
                .HasColumnName("SRRefID");
            entity.Property(e => e.SrrefType)
                .HasMaxLength(50)
                .HasColumnName("SRRefType");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
            entity.Property(e => e.TotalReceiptQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<InvStoreReceiptView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INV_StoreReceiptView");

            entity.Property(e => e.CountryId)
                .HasMaxLength(50)
                .HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.Property(e => e.ReceiptById)
                .HasMaxLength(50)
                .HasColumnName("ReceiptByID");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(50)
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.ReceiptOn).HasColumnType("datetime");
            entity.Property(e => e.ReceiptPersonCode).HasMaxLength(20);
            entity.Property(e => e.ReceiptPersonName).HasMaxLength(150);
            entity.Property(e => e.ReceiptStatus).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SrrefId)
                .HasMaxLength(50)
                .HasColumnName("SRRefID");
            entity.Property(e => e.SrrefNo)
                .HasMaxLength(50)
                .HasColumnName("SRRefNo");
            entity.Property(e => e.SrrefType)
                .HasMaxLength(50)
                .HasColumnName("SRRefType");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<InvoiceItemCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceI__3214EC2772F5709A");

            entity.ToTable("InvoiceItemCost");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceItemId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceItemID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.StockLedgerId)
                .HasMaxLength(50)
                .HasColumnName("StockLedgerID");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MstBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId);

            entity.ToTable("Mst_Branch");

            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchEmail).HasMaxLength(50);
            entity.Property(e => e.BranchFax).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageName).HasMaxLength(500);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("ImageURL");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstBranchView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_BranchView");

            entity.Property(e => e.BranchEmail).HasMaxLength(50);
            entity.Property(e => e.BranchFax).HasMaxLength(50);
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageName).HasMaxLength(500);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("ImageURL");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstBrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("Mst_Brand");

            entity.Property(e => e.BrandId)
                .HasMaxLength(50)
                .HasColumnName("BrandID");
            entity.Property(e => e.BrandCode).HasMaxLength(50);
            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstBrandView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_BrandView");

            entity.Property(e => e.BrandCode).HasMaxLength(50);
            entity.Property(e => e.BrandId)
                .HasMaxLength(50)
                .HasColumnName("BrandID");
            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstCurrencyExchange>(entity =>
        {
            entity.HasKey(e => e.CurrencyExchangeId);

            entity.ToTable("Mst_CurrencyExchange");

            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstCurrencyExchangeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_CurrencyExchangeView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyExchangeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrencyExchangeID");
            entity.Property(e => e.CurrencyExchangeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Mst_Customer1");

            entity.ToTable("Mst_Customer");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Apbm)
                .HasMaxLength(50)
                .HasColumnName("APBM");
            entity.Property(e => e.Bpl)
                .HasMaxLength(50)
                .HasColumnName("BPL");
            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Dmk)
                .HasMaxLength(50)
                .HasColumnName("DMK");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gsmk)
                .HasMaxLength(50)
                .HasColumnName("GSMK");
            entity.Property(e => e.Jpl)
                .HasMaxLength(50)
                .HasColumnName("JPL");
            entity.Property(e => e.Kk)
                .HasMaxLength(50)
                .HasColumnName("KK");
            entity.Property(e => e.Kmas)
                .HasMaxLength(50)
                .HasColumnName("KMAS");
            entity.Property(e => e.Kpl)
                .HasMaxLength(50)
                .HasColumnName("KPL");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Law)
                .HasMaxLength(50)
                .HasColumnName("LAW");
            entity.Property(e => e.Lmpl)
                .HasMaxLength(50)
                .HasColumnName("LMPL");
            entity.Property(e => e.Lpmk)
                .HasMaxLength(50)
                .HasColumnName("LPMK");
            entity.Property(e => e.Lppl)
                .HasMaxLength(50)
                .HasColumnName("LPPL");
            entity.Property(e => e.Lpyh)
                .HasMaxLength(50)
                .HasColumnName("LPYH");
            entity.Property(e => e.Lst)
                .HasMaxLength(50)
                .HasColumnName("LST");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Nrcno).HasColumnName("NRCNo");
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.Pk)
                .HasMaxLength(50)
                .HasColumnName("PK");
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.Sth)
                .HasMaxLength(50)
                .HasColumnName("STH");
            entity.Property(e => e.Syk)
                .HasMaxLength(50)
                .HasColumnName("SYK");
            entity.Property(e => e.Tam)
                .HasMaxLength(50)
                .HasColumnName("TAM");
            entity.Property(e => e.Tpl)
                .HasMaxLength(50)
                .HasColumnName("TPL");
            entity.Property(e => e.Yhnkak)
                .HasMaxLength(50)
                .HasColumnName("YHNKAK");
            entity.Property(e => e.Ypl)
                .HasMaxLength(50)
                .HasColumnName("YPL");
        });

        modelBuilder.Entity<MstCustomerNewView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_CustomerNewView");

            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Email).HasMaxLength(50);
        });

        modelBuilder.Entity<MstCustomerView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_CustomerView");

            entity.Property(e => e.Apbm)
                .HasMaxLength(50)
                .HasColumnName("APBM");
            entity.Property(e => e.Bpl)
                .HasMaxLength(50)
                .HasColumnName("BPL");
            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Dmk)
                .HasMaxLength(50)
                .HasColumnName("DMK");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gsmk)
                .HasMaxLength(50)
                .HasColumnName("GSMK");
            entity.Property(e => e.Jpl)
                .HasMaxLength(50)
                .HasColumnName("JPL");
            entity.Property(e => e.Kk)
                .HasMaxLength(50)
                .HasColumnName("KK");
            entity.Property(e => e.Kmas)
                .HasMaxLength(50)
                .HasColumnName("KMAS");
            entity.Property(e => e.Kpl)
                .HasMaxLength(50)
                .HasColumnName("KPL");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Law)
                .HasMaxLength(50)
                .HasColumnName("LAW");
            entity.Property(e => e.Lmpl)
                .HasMaxLength(50)
                .HasColumnName("LMPL");
            entity.Property(e => e.Lpmk)
                .HasMaxLength(50)
                .HasColumnName("LPMK");
            entity.Property(e => e.Lppl)
                .HasMaxLength(50)
                .HasColumnName("LPPL");
            entity.Property(e => e.Lpyh)
                .HasMaxLength(50)
                .HasColumnName("LPYH");
            entity.Property(e => e.Lst)
                .HasMaxLength(50)
                .HasColumnName("LST");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Nrcno).HasColumnName("NRCNo");
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.Pk)
                .HasMaxLength(50)
                .HasColumnName("PK");
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.Sth)
                .HasMaxLength(50)
                .HasColumnName("STH");
            entity.Property(e => e.Syk)
                .HasMaxLength(50)
                .HasColumnName("SYK");
            entity.Property(e => e.Tam)
                .HasMaxLength(50)
                .HasColumnName("TAM");
            entity.Property(e => e.Tpl)
                .HasMaxLength(50)
                .HasColumnName("TPL");
            entity.Property(e => e.Yhnkak)
                .HasMaxLength(50)
                .HasColumnName("YHNKAK");
            entity.Property(e => e.Ypl)
                .HasMaxLength(50)
                .HasColumnName("YPL");
        });

        modelBuilder.Entity<MstDoctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId);

            entity.ToTable("Mst_Doctor");

            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.ContactInfo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNameEnglish).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmergencyContact).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Speciality).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<MstDoctorView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_DoctorView");

            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.ContactInfo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(50)
                .HasColumnName("DoctorID");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNameEnglish).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmergencyContact).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Speciality).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<MstItem>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("Mst_Item");

            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.BarcodeImage).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultItemPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ImageId)
                .HasMaxLength(50)
                .HasColumnName("ImageID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.ItemTypeId)
                .HasMaxLength(50)
                .HasColumnName("ItemTypeID");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.ShortCode1).HasMaxLength(20);
            entity.Property(e => e.ShortCode2).HasMaxLength(50);
            entity.Property(e => e.StockType).HasMaxLength(50);
        });

        modelBuilder.Entity<MstItemGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupId);

            entity.ToTable("Mst_ItemGroup");

            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageId)
                .HasMaxLength(50)
                .HasColumnName("ImageID");
            entity.Property(e => e.ItemGroupCode).HasMaxLength(50);
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ParentId)
                .HasMaxLength(50)
                .HasColumnName("ParentID");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StockType).HasMaxLength(50);
        });

        modelBuilder.Entity<MstItemGroupView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_ItemGroupView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageId)
                .HasMaxLength(50)
                .HasColumnName("ImageID");
            entity.Property(e => e.ItemGroupCode).HasMaxLength(50);
            entity.Property(e => e.ItemGroupId)
                .HasMaxLength(50)
                .HasColumnName("ItemGroupID");
            entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            entity.Property(e => e.ItemGroupType)
                .HasMaxLength(50)
                .HasColumnName("itemGroupType");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ParentId)
                .HasMaxLength(50)
                .HasColumnName("ParentID");
            entity.Property(e => e.ParentTypeName).HasMaxLength(500);
            entity.Property(e => e.ParentTypeSeq).HasColumnName("Parent_Type_Seq");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.StockType).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(1004);
            entity.Property(e => e.TypeSeq).HasColumnName("Type_Seq");
        });

        modelBuilder.Entity<MstLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("Mst_Location");

            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<MstLocationStaff>(entity =>
        {
            entity.HasKey(e => e.LocationStaffId);

            entity.ToTable("Mst_LocationStaff");

            entity.Property(e => e.LocationStaffId)
                .HasMaxLength(50)
                .HasColumnName("LocationStaffID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
        });

        modelBuilder.Entity<MstLocationStaffView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_LocationStaffView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.LocationStaffId)
                .HasMaxLength(50)
                .HasColumnName("LocationStaffID");
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<MstLocationView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_LocationView");

            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationCode).HasMaxLength(100);
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<MstLuckyPrize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EMR_LuckyPrize");

            entity.ToTable("Mst_LuckyPrize");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<MstManufacturer>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK_Mst_Supplier");

            entity.ToTable("Mst_Manufacturer");

            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<MstManufacturerView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_ManufacturerView");

            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<MstOperator>(entity =>
        {
            entity.HasKey(e => e.OperatorId);

            entity.ToTable("Mst_Operator");

            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("OperatorID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.ContactInfo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmergencyContact).HasMaxLength(100);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorCode).HasMaxLength(200);
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.OperatorType).HasMaxLength(200);
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.Speciality).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<MstOperatorView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_OperatorView");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchNo).HasMaxLength(50);
            entity.Property(e => e.ContactInfo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmergencyContact).HasMaxLength(100);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OperatorCode).HasMaxLength(200);
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("OperatorID");
            entity.Property(e => e.OperatorName).HasMaxLength(200);
            entity.Property(e => e.OperatorType).HasMaxLength(200);
            entity.Property(e => e.PositionName).HasMaxLength(500);
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.Speciality).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(20);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<MstServiceType>(entity =>
        {
            entity.HasKey(e => e.ServiceTypeId);

            entity.ToTable("Mst_ServiceType");

            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<MstServiceTypeItem>(entity =>
        {
            entity.HasKey(e => e.ServiceTypeItemId);

            entity.ToTable("Mst_ServiceTypeItem");

            entity.Property(e => e.ServiceTypeItemId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeItemID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultItemQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<MstServiceTypeItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_ServiceTypeItemView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultItemQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DefaultUnitQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.ItemCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeItemId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeItemID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.ShowSeq).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .HasColumnName("UnitID");
            entity.Property(e => e.UomLabel).HasMaxLength(50);
            entity.Property(e => e.UomcombineIds)
                .HasMaxLength(1000)
                .HasColumnName("UOMCombineIDs");
            entity.Property(e => e.UomcombineLabels)
                .HasMaxLength(300)
                .HasColumnName("UOMCombineLabels");
        });

        modelBuilder.Entity<MstServiceTypePerson>(entity =>
        {
            entity.HasKey(e => e.ServiceTypePersonId).HasName("PK_Mst_ServiceTypePerson1");

            entity.ToTable("Mst_ServiceTypePerson");

            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("PersonID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
        });

        modelBuilder.Entity<MstServiceTypePersonView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_ServiceTypePersonView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.DoctorNo).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("PersonID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.ServiceTypePersonId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypePersonID");
        });

        modelBuilder.Entity<MstServiceTypeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_ServiceTypeView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceTypeCode).HasMaxLength(50);
            entity.Property(e => e.ServiceTypeId)
                .HasMaxLength(50)
                .HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(50);
            entity.Property(e => e.VisitId)
                .HasMaxLength(50)
                .HasColumnName("VisitID");
        });

        modelBuilder.Entity<MstStaff>(entity =>
        {
            entity.HasKey(e => e.StaffId);

            entity.ToTable("Mst_Staff");

            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.ContactNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<MstStaffView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_StaffView");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.ContactNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleName).HasMaxLength(100);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SysUserCode).HasMaxLength(20);
            entity.Property(e => e.SysUserName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<MstSupplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK_Mst_Supplier1");

            entity.ToTable("Mst_Supplier");

            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsNo)
                .HasMaxLength(50)
                .HasColumnName("CS_No");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IsCs).HasColumnName("Is_CS");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<MstSupplierView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_SupplierView");

            entity.Property(e => e.ContactInfo).HasMaxLength(500);
            entity.Property(e => e.ContactPerson).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsNo)
                .HasMaxLength(50)
                .HasColumnName("CS_No");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IsCs).HasColumnName("Is_CS");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(300);
        });

        modelBuilder.Entity<MstTownship>(entity =>
        {
            entity.HasKey(e => e.TownshipId);

            entity.ToTable("Mst_township");

            entity.Property(e => e.TownshipId)
                .HasMaxLength(50)
                .HasColumnName("TownshipID");
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.TownshipCode).HasMaxLength(50);
            entity.Property(e => e.TownshipName).HasMaxLength(50);
        });

        modelBuilder.Entity<MstTownshipView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mst_townshipView");

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.TownshipCode).HasMaxLength(50);
            entity.Property(e => e.TownshipId)
                .HasMaxLength(50)
                .HasColumnName("TownshipID");
            entity.Property(e => e.TownshipName).HasMaxLength(50);
        });

        modelBuilder.Entity<StStockFlowCheckFoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ST_StockFlowCheckFOC");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlowBy).HasMaxLength(50);
            entity.Property(e => e.FlowOn).HasColumnType("datetime");
            entity.Property(e => e.FlowQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FlowTitle).HasMaxLength(50);
            entity.Property(e => e.FlowType).HasMaxLength(50);
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.OwnerRefId)
                .HasMaxLength(50)
                .HasColumnName("OwnerRefID");
            entity.Property(e => e.OwnerRefType).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.StockFlowId)
                .HasMaxLength(50)
                .HasColumnName("StockFlowID");
            entity.Property(e => e.SubRefId)
                .HasMaxLength(50)
                .HasColumnName("SubRefID");
            entity.Property(e => e.SubRefType).HasMaxLength(50);
        });

        modelBuilder.Entity<StStockFlowCheckFocview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ST_StockFlowCheckFOCView");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlowBy).HasMaxLength(50);
            entity.Property(e => e.FlowOn).HasColumnType("datetime");
            entity.Property(e => e.FlowQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FlowTitle).HasMaxLength(50);
            entity.Property(e => e.FlowType).HasMaxLength(50);
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.OwnerRefId)
                .HasMaxLength(50)
                .HasColumnName("OwnerRefID");
            entity.Property(e => e.OwnerRefType).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.StockFlowId)
                .HasMaxLength(50)
                .HasColumnName("StockFlowID");
            entity.Property(e => e.SubRefId)
                .HasMaxLength(50)
                .HasColumnName("SubRefID");
            entity.Property(e => e.SubRefType).HasMaxLength(50);
        });

        modelBuilder.Entity<StStockFlowCheckQtyofFocview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ST_StockFlowCheckQTYofFOCView");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlowBy).HasMaxLength(50);
            entity.Property(e => e.FlowOn).HasColumnType("datetime");
            entity.Property(e => e.FlowQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FlowTitle).HasMaxLength(50);
            entity.Property(e => e.FlowType).HasMaxLength(50);
            entity.Property(e => e.FocQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsFoc).HasColumnName("IsFOC");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationGroup).HasMaxLength(50);
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.NonFocQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OwnerRefId)
                .HasMaxLength(50)
                .HasColumnName("OwnerRefID");
            entity.Property(e => e.OwnerRefType).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("RefID");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(50);
            entity.Property(e => e.StockFlowId)
                .HasMaxLength(50)
                .HasColumnName("StockFlowID");
            entity.Property(e => e.SubRefId)
                .HasMaxLength(50)
                .HasColumnName("SubRefID");
            entity.Property(e => e.SubRefType).HasMaxLength(50);
        });

        modelBuilder.Entity<StockLedger>(entity =>
        {
            entity.HasKey(e => e.StockLedgerId).HasName("PK__StockLed__3E88170BFA65F45F");

            entity.ToTable("StockLedger");

            entity.Property(e => e.StockLedgerId)
                .HasMaxLength(50)
                .HasColumnName("StockLedgerID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .HasColumnName("ItemID");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasColumnName("LocationID");
            entity.Property(e => e.PoitemId)
                .HasMaxLength(50)
                .HasColumnName("POItemID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.ReferenceType).HasMaxLength(50);
            entity.Property(e => e.RemainingQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SysUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Sys_User");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.DeviceName).HasMaxLength(500);
            entity.Property(e => e.DeviceType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.LandingPage).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(1000);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PositionId)
                .HasMaxLength(50)
                .HasColumnName("PositionID");
            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .HasColumnName("RoleID");
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<SysUserView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Sys_UserView");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedByName).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentCode).HasMaxLength(50);
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName).HasMaxLength(200);
            entity.Property(e => e.DeviceName).HasMaxLength(500);
            entity.Property(e => e.DeviceType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Expr1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LandingPage).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByName).HasMaxLength(150);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(1000);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PositionId)
                .HasMaxLength(50)
                .HasColumnName("PositionID");
            entity.Property(e => e.PositionName).HasMaxLength(500);
            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(100);
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasColumnName("StationID");
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("table1");

            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.SrNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Table2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table2");

            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.SrNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Table3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table3");

            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Table4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table4");

            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.ClinicVoucherNo).HasMaxLength(50);
            entity.Property(e => e.SrNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Table5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table5");

            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Table6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table6");

            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.SrNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Table7>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table7");

            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("invoiceID");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.SrNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TonodataView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TONODataView");

            entity.Property(e => e.ClinicVoucherId)
                .HasMaxLength(50)
                .HasColumnName("ClinicVoucherID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedByCode).HasMaxLength(20);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Lavgmmhg)
                .HasMaxLength(50)
                .HasColumnName("LAvgmmhg");
            entity.Property(e => e.Lfirstmmhg)
                .HasMaxLength(50)
                .HasColumnName("LFirstmmhg");
            entity.Property(e => e.Lresult)
                .HasMaxLength(50)
                .HasColumnName("LResult");
            entity.Property(e => e.Lsecondmmhg)
                .HasMaxLength(50)
                .HasColumnName("LSecondmmhg");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedByCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.Ravgmmhg)
                .HasMaxLength(50)
                .HasColumnName("RAvgmmhg");
            entity.Property(e => e.Rfirstmmhg)
                .HasMaxLength(50)
                .HasColumnName("RFirstmmhg");
            entity.Property(e => e.Rresult)
                .HasMaxLength(50)
                .HasColumnName("RResult");
            entity.Property(e => e.Rsecondmmhg)
                .HasMaxLength(50)
                .HasColumnName("RSecondmmhg");
            entity.Property(e => e.TestOn).HasColumnType("datetime");
            entity.Property(e => e.TonotestId)
                .HasMaxLength(50)
                .HasColumnName("TONOTestID");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
            entity.Property(e => e.VisitNo).HasMaxLength(200);
            entity.Property(e => e.VisitStatus).HasMaxLength(20);
            entity.Property(e => e.VisitType).HasMaxLength(50);
        });

        modelBuilder.Entity<Tonodatum>(entity =>
        {
            entity.HasKey(e => e.TonotestId);

            entity.ToTable("TONOData");

            entity.Property(e => e.TonotestId)
                .HasMaxLength(50)
                .HasColumnName("TONOTestID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.Lavgmmhg)
                .HasMaxLength(50)
                .HasColumnName("LAvgmmhg");
            entity.Property(e => e.Lfirstmmhg)
                .HasMaxLength(50)
                .HasColumnName("LFirstmmhg");
            entity.Property(e => e.Lresult)
                .HasMaxLength(50)
                .HasColumnName("LResult");
            entity.Property(e => e.Lsecondmmhg)
                .HasMaxLength(50)
                .HasColumnName("LSecondmmhg");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Ravgmmhg)
                .HasMaxLength(50)
                .HasColumnName("RAvgmmhg");
            entity.Property(e => e.Rfirstmmhg)
                .HasMaxLength(50)
                .HasColumnName("RFirstmmhg");
            entity.Property(e => e.Rresult)
                .HasMaxLength(50)
                .HasColumnName("RResult");
            entity.Property(e => e.Rsecondmmhg)
                .HasMaxLength(50)
                .HasColumnName("RSecondmmhg");
            entity.Property(e => e.TestOn).HasColumnType("datetime");
            entity.Property(e => e.VisitId)
                .HasMaxLength(200)
                .HasColumnName("VisitID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
