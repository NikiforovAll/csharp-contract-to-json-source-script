using CobsDomain.DslLineStateServiceReference;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DomainBellaNS.API
{

    [DataContract]
    public enum DomainError
    {
        [EnumMember]
        DomainError = 1,
        [EnumMember]
        InvalidBundleId,
        [EnumMember]
        InvalidProductId,
        [EnumMember]
        InvalidSubscriptionId,
        [EnumMember]
        ServiceAccountNotFound,
        [EnumMember]
        SubscriptionNotFound,
        [EnumMember]
        CustomerAccountNotFound,
        [EnumMember]
        PropositionNotFound,
        [EnumMember]
        ProductNotFound,
        [EnumMember]
        BundleNotFound,
        [EnumMember]
        InvoiceNotFound,
        [EnumMember]
        AccountIdAlreadyHasCredentials,
        [EnumMember]
        LoginFailed,
        [EnumMember]
        LoginNotFound,
        [EnumMember]
        LoginDuplicate,
        [EnumMember]
        PasswordsDoNotMatch,
        [EnumMember]
        InvalidPassword,
        [EnumMember]
        BundleIdNotFound,
        [EnumMember]
        CustomerAccountAlreadyExists,
        [EnumMember]
        ServiceAccountAlreadyExists,
        [EnumMember]
        InvalidInvoiceId,
        [EnumMember]
        NoServiceAccountsFound,
        [EnumMember]
        NoCustomerAccounts,
        [EnumMember]
        IdValidationError,
        [EnumMember]
        PeriodValidationError,
        [EnumMember]
        EmptyArgument,
        [EnumMember]
        InvalidArgument,
        [EnumMember]
        InvalidOrderState,
        [EnumMember]
        ProductNotMandatory,
        [EnumMember]
        BundleNotMandatory,
        [EnumMember]
        OrderNotFound,
        [EnumMember]
        DuplicateKey,
        [EnumMember]
        InvalidNumberOfEntities,
        [EnumMember]
        SettingNotFound,
        [EnumMember]
        UnexpectedError,
        [EnumMember]
        ValidateOrderError,
        [EnumMember]
        InvalidPropositionId,
        [EnumMember]
        InvalidScore,
        [EnumMember]
        TaskNotFound,
        [EnumMember]
        InvalidOrderStatus,
        [EnumMember]
        ServiceCategoryNotFound,
        [EnumMember]
        VendorNotFound,
        [EnumMember]
        ServiceAccountActivationError,
        [EnumMember]
        ServiceAccountStopError,
        [EnumMember]
        InstallationIsAlreadyRequested,
        [EnumMember]
        OrderIdIsMissed,
        [EnumMember]
        FutureConnectionIdIsNotFound,
        [EnumMember]
        IncorrectServiceAccountState,
        [EnumMember]
        PropositionProlongationIsNotAvailable,
        [EnumMember]
        IncorrectServiceCategory,
        [EnumMember]
        InvalidProcessStep,
        [EnumMember]
        CobsInvalidParameters,
        [EnumMember]
        CobsRetrieveOrderError,
        [EnumMember]
        MandateNotFound,
        [EnumMember]
        FunctionalityIsNotSupported,
        [EnumMember]
        OrderStateNotFound,
        [EnumMember]
        IncorrectProlongationContractDuration,
        [EnumMember]
        CobsPostCodeCheckError,
        [EnumMember]
        TypeOfServiceAlreadyExists,
        [EnumMember]
        TypeOfServiceNotFound,
        [EnumMember]
        IncorrectPropositionId,
        [EnumMember]
        ProductTypeOfServiceDublication,
        [EnumMember]
        EmptyProductCollection,
        [EnumMember]
        PropositionNameAlreadyExists,
        [EnumMember]
        ProductTemplateIsNotFound,
        [EnumMember]
        IncorrectProductTemplateId,
        [EnumMember]
        EmptyProductBundleCollection,
        [EnumMember]
        ProductTemplateNameAlreadyExists,
        [EnumMember]
        ProductBundleDuplication,
        [EnumMember]
        NoInvoicesSelected,
        [EnumMember]
        EmptyInvoiceId,
        [EnumMember]
        InvalidAmount,
        [EnumMember]
        MatchBankTransactionError,
        [EnumMember]
        UnsupportedBankTransactionType,
        [EnumMember]
        InvoiceClearanceFailed,
        [EnumMember]
        AddPaymentToServiceAccountError,
        [EnumMember]
        RemainingPaymentAmountError,
        [EnumMember]
        TransactionNotFound,
        [EnumMember]
        InvalidInvoiceStatus,
        [EnumMember]
        InvoiceItemIsMissing,
        [EnumMember]
        DiscountNotFound,
        [EnumMember]
        BundleWithIncorrectTypeOfServiceId,
        [EnumMember]
        ProductTemplateDeletionIsImpossible,
        [EnumMember]
        PropositionDeletionIsImpossible,
        [EnumMember]
        ProductWithMissingOrderType,
        [EnumMember]
        InvalidProductTemplateId,
        [EnumMember]
        TypeOfServiceIsUsed,
        [EnumMember]
        TaskActionNotFound,
        [EnumMember]
        GenericObjectPassed,
        [EnumMember]
        IncorrectDiscountId,
        [EnumMember]
        IncorrectProductId,
        [EnumMember]
        EmptyOrderTypes,
        [EnumMember]
        InvalidPricePlanId,
        [EnumMember]
        IncorrectPricePlanId,
        [EnumMember]
        IncorrectPriceItemDuration,
        [EnumMember]
        IncorrectPriceItemId,
        [EnumMember]
        InvalidPriceItemDuration,
        [EnumMember]
        InvalidPriceItemVariablePrice,
        [EnumMember]
        InvalidPriceItemSetupPrice,
        [EnumMember]
        InvalidPriceItemBundleId,
        [EnumMember]
        InvalidPriceItemId,
        [EnumMember]
        IncorrectDiscountDuration,
        [EnumMember]
        InvalidDiscountDuration,
        [EnumMember]
        InvalidDiscountAmount,
        [EnumMember]
        InvalidDiscountName,
        [EnumMember]
        InvalidDiscountId,
        [EnumMember]
        NoPriceItemForBundle,
        [EnumMember]
        InvalidPricePlanName,
        [EnumMember]
        InvalidRateClassName,
        [EnumMember]
        ProductOfIncorrectTypeOfService,
        [EnumMember]
        InvalidServiceCategoryId,
        [EnumMember]
        IncorrectDiscountAmount,
        [EnumMember]
        ProductIsUsedInProposition,
        [EnumMember]
        PricePlanIsUsedInProduct,
        [EnumMember]
        StartOnGreaterThanEndOn,
        [EnumMember]
        InvalidSubscribedBundleId,
        [EnumMember]
        IncorrectDate,
        [EnumMember]
        IncorrectOperation,
        [EnumMember]
        CobsOrderUpdateException,
        [EnumMember]
        InvalidTaskRuleCreationRequest,
        [EnumMember]
        ContractSendToCustomerExists,
        [EnumMember]
        ServiceCategoryBankComponentParameter,
        [EnumMember]
        PriceItemDuplication,
        [EnumMember]
        IncorrectBundleId,
        [EnumMember]
        InvalidTypeOfServiceId,
        [EnumMember]
        InvalidPageNumber,
        [EnumMember]
        InvalidPerPage,
        [EnumMember]
        TaskRuleDoesNotExist,
        [EnumMember]
        MandateAlreadyExists,
        [EnumMember]
        IncorrectSequence,
        [EnumMember]
        DuplicateSetting,
        [EnumMember]
        InvalidName,
        [EnumMember]
        InvalidStartOn,
        [EnumMember]
        InvalidEndOn,
        [EnumMember]
        InvalidCreatedOn,
        [EnumMember]
        InvalidCreatedBy,
        [EnumMember]
        InvalidDescription,
        [EnumMember]
        ChangeApplicationLogicNotImplemented,
        [EnumMember]
        TypeOfServiceIdDuplictaion,
        [EnumMember]
        InvalidId,
        [EnumMember]
        IncorrectServiceCategoryId,
        [EnumMember]
        OfferNotFound,
        [EnumMember]
        InvalidCashbackId,
        [EnumMember]
        InvalidCashbackName,
        [EnumMember]
        InvalidCashbackDuration,
        [EnumMember]
        IncorrectCashbackId,
        [EnumMember]
        IncorrectCashbackDuration,
        [EnumMember]
        IncorrectCashbackAmount,
        [EnumMember]
        InvalidCashbackAmount,
        [EnumMember]
        CustomerAccountInBlackList,
        [EnumMember]
        RoleAlreadyExists,
        [EnumMember]
        EmptyRoleName,
        [EnumMember]
        EmptyRolesList,
        [EnumMember]
        EmptyRightsList,
        [EnumMember]
        RoleNotFound,
        [EnumMember]
        AccountNotFound,
        [EnumMember]
        RoleIsAssignedToAccount,
        [EnumMember]
        InvalidReasonCodeId,
        [EnumMember]
        IncorrectReasonCodeId,
        [EnumMember]
        InvalidAccountId,
        [EnumMember]
        InvalidServiceAccountId,
        [EnumMember]
        IncorrectServiceAccountId,
        [EnumMember]
        IncorrectFinancialActionRequestId,
        [EnumMember]
        InvalidFinancialActionRequestId,
        [EnumMember]
        InvalidVerifiedBy,
        [EnumMember]
        IncorrectFinancialActionRequestState,
        [EnumMember]
        FinancialActionRequestConfirmationLogicNotImplemented,
        [EnumMember]
        FinancialActionRequestRejectionLogicNotImplemented,
        [EnumMember]
        IncorrectBankTransactionId,
        [EnumMember]
        IncorrectIban,
        [EnumMember]
        IncorrectCreditTransferId,
        [EnumMember]
        EmptyAccessToken,
        [EnumMember]
        EmptyRefreshToken,
        [EnumMember]
        EmptyAccountId,
        [EnumMember]
        InvalidTokenLifetime,
        [EnumMember]
        CredentialsNotFound,
        [EnumMember]
        AccountIsBlocked,
        [EnumMember]
        SessionNotFound,
        [EnumMember]
        InvalidToken,
        [EnumMember]
        SessionExpired,
        [EnumMember]
        IncorrectManualBalanceCorrectionRequestState,
        [EnumMember]
        InvalidReasonCode,
        [EnumMember]
        IncorrectInvoiceStatus,
        [EnumMember]
        IncorrectManualInvoiceClearanceRequestState,
        [EnumMember]
        IncorrectAmountToMatch,
        [EnumMember]
        InvalidRoleName,
        [EnumMember]
        InvalidCashbackBillPeriodQuantity,
        [EnumMember]
        IncorrectRequestId,
        [EnumMember]
        InvalidBankTransactionId,
        [EnumMember]
        MultipleOverpaidInvoices,
        [EnumMember]
        IncorrectInvoiceId,
        [EnumMember]
        UnknownInvoiceClearanceDetails,
        [EnumMember]
        InvoiceIsAlreadyClearing,
        [EnumMember]
        TaskSkillDoesNotExist,
        [EnumMember]
        EmployeeAlreadyHasSuchSkill,
        [EnumMember]
        InvalidTaskStatus,
        [EnumMember]
        UnsupportedUpdateOrderRequest,
        [EnumMember]
        OverstappenServiceError,
        [EnumMember]
        OverstappenDossierIsNotFound,
        [EnumMember]
        ImpossibleToChangeOrCancelOverstappenRequest,
        [EnumMember]
        ProlongationIsNotAvailable,
        [EnumMember]
        InvalidMailToPayResponse,
        [EnumMember]
        MtpPaymentRequestNotFound,
        [EnumMember]
        IncorrectUncollectableInvoiceClearanceRequestState,
        [EnumMember]
        InvalidDelay,
        [EnumMember]
        GlEventNotFound,
        [EnumMember]
        InvalidGlBalanceId,
        [EnumMember]
        GlAccountNotFound,
        [EnumMember]
        UnknownDunningProcess,
        [EnumMember]
        OrderAlreadyHasAnAssignedCustomer,
        [EnumMember]
        RateClassNotFound,
        [EnumMember]
        InvalidRateClassId,
        [EnumMember]
        InvalidPhoneCode,
        [EnumMember]
        InvalidBundleCoverageSize,
        [EnumMember]
        NoPropositionVendorsSpecified,
        [EnumMember]
        CannotBeSoldByThisVendor,
        [EnumMember]
        SaledateNotValidForThisVendor,
        [EnumMember]
        BundleCoverageAlreadyExists,
        [EnumMember]
        InvalidExcassoReasonId,
        [EnumMember]
        VerifyCreditTransferError,
        [EnumMember]
        IncorrectCreditTransferRequestId,
        [EnumMember]
        IncorrectBankTransactionType,
        [EnumMember]
        IncorrectExcassoAmount,
        [EnumMember]
        InvalidCreditTransferId,
        [EnumMember]
        UnknownTypeOfRegularVirtualBalanceRecord,
        [EnumMember]
        ExcassoBlockExists,
        [EnumMember]
        ExcassoBlockNotFound,
        [EnumMember]
        InvalidExcassoBlockId,
        [EnumMember]
        InvalidExcassoBlockDuration,
        [EnumMember]
        ServiceAccountBlockedForExcasso,
        [EnumMember]
        InvalidExcassoBlockStatus,
        [EnumMember]
        BlockReasonNotFound,
        [EnumMember]
        InvalidCreditRiskLevel,
        [EnumMember]
        InvalidSequenceNumber,
        [EnumMember]
        InvalidBalance,
        [EnumMember]
        CobsMapNotFound,
        [EnumMember]
        OrderTypeViolation,
        [EnumMember]
        ClearanceBlockExists,
        [EnumMember]
        ClearanceBlockNotFound,
        [EnumMember]
        InvoiceClearanceBlocked,
        [EnumMember]
        UnknowCancellationReason,
        [EnumMember]
        InvalidCancellationFeeType,
        [EnumMember]
        InvalidOrderAction,
        [EnumMember]
        ReversalOfRevertedCallDataRecord,
        [EnumMember]
        CreatePaymentArrangementError,
        [EnumMember]
        InvalidPaymentArrangementId,
        [EnumMember]
        InvalidPaymentArrangementStatus,
        [EnumMember]
        InvalidClearanceBlockDuration,
        [EnumMember]
        InvalidDirectDebitBlockDuration,
        [EnumMember]
        DirectDebitBlockExists,
        [EnumMember]
        DirectDebitBlockNotFound,
        [EnumMember]
        InvoiceDirectDebitBlocked,
        [EnumMember]
        DunningProcessNotFound,
        [EnumMember]
        RecreationAlreadyInitiated,
        [EnumMember]
        IncorrectInvoiceType,
        [EnumMember]
        CannotRecreateNonEndNoteInvoiceInDunningWithIncludingUninvoicedVirtualBalanceRecords,
        [EnumMember]
        CannotRecreateInvoiceWithDirectDebitBlock,
        [EnumMember]
        IncorrectStatusOrType,
        [EnumMember]
        RecreationOfUnrespondedInvoice,
        [EnumMember]
        InvoiceWithClearanceBlockRecreation,
        [EnumMember]
        ContractIdIsEmpty,
        [EnumMember]
        ContractNotFound,
        [EnumMember]
        InvalidCreateAdjustingOrderRequest,
        [EnumMember]
        AvailablePropositionNotFound,
        [EnumMember]
        InvalidSubscriptionStatus,
        [EnumMember]
        CannotRecreateInvoiceWithoutNewVirtualBalanceRecords,
        [EnumMember]
        BundleIsNotMonthlyTerminable,
        [EnumMember]
        SubscribedBundleIdsAreNotUnique,
        [EnumMember]
        MoreThanOneIsMainBundle,
        [EnumMember]
        InvalidSubscribeBundleWithDiscountRequest,
        [EnumMember]
        StbNumberExceeded,
        [EnumMember]
        InvalidDslUpgrade,
        [EnumMember]
        DuplicateOrder,
        [EnumMember]
        NoIbanForServiceAccount,
        [EnumMember]
        InvalidRegionRange,
        [EnumMember]
        InvalidInstallationDatesRange,
        [EnumMember]
        InvalidRegionCodeLength,
        [EnumMember]
        RegionNameNotFound,
        [EnumMember]
        RegionNameExists,
        [EnumMember]
        ReginIdNotFound,
        [EnumMember]
        RegionScheduleNotExist,
        [EnumMember]
        RegionScheduleExists,
        [EnumMember]
        InstallationBookItemExists,
        [EnumMember]
        InstallationBookItemNotExist,
        [EnumMember]
        AllInstallationsBooked,
        [EnumMember]
        ServiceAccountAlreadySubscribed,
        [EnumMember]
        ServiceAccountNotSubscribed,
        [EnumMember]
        PendingInstallationRequestExists,
        [EnumMember]
        PendingInstallationRequestNotExist,
        [EnumMember]
        IncorrectBankTransactionState,
        [EnumMember]
        AssignedMailsNotFound,
        [EnumMember]
        AvailableProductNotFound,
        [EnumMember]
        PriceItemNotFound,
        [EnumMember]
        InvalidDunningBlockDuration,
        [EnumMember]
        DunningBlockNotFound,
        [EnumMember]
        AdjustingOrderPipelineFinished,
        [EnumMember]
        ServiceAccountIdIsEmpty,
        [EnumMember]
        RegionCodeExists,
        [EnumMember]
        CodesRangeNotInRegion,
        [EnumMember]
        RegionScheduleDaysExist,
        [EnumMember]
        RegionScheduleDaysNotFound,
        [EnumMember]
        InvalidMaxInstallationCount,
        [EnumMember]
        InvalidPlanninsToolReminderConfiguration,
        [EnumMember]
        WishDateManipulationIsNotPossible,
        [EnumMember]
        OverstappenDonorProcessIsNotOverdueYet,
        [EnumMember]
        CallDataRecordNotFound,
        [EnumMember]
        VideoOnDemandNotFound,
        [EnumMember]
        PqccCheckResultInfoForOrderNotFound
    }

    namespace CobsService
    {
        [DataContract]
        public class AdditionalHeaderFields
        {

            [DataMember]
            public string previousProdInstNrReseller { get; set; }
            [DataMember]
            public string previousOrderNrBaByXl { get; set; }
            [DataMember]
            public string previousProdInstNrBaByXl { get; set; }
            [DataMember]
            public int rejectCode { get; set; }
            [DataMember]
            public string serverName { get; set; }
            [DataMember]
            public string ceaseReason { get; set; }
            [DataMember]
            public string billingType { get; set; }
            [DataMember]
            public string contractContinuationType { get; set; }
            [DataMember]
            public DateTime contractFreeDate { get; set; }
            [DataMember]
            public bool newLineEnigeBewoner { get; set; }
            [DataMember]
            public string contractNumber { get; set; }

            public AdditionalHeaderFields() { }

        }

        [DataContract]
        public class CallForwardingfeaturesDto
        {

            [DataMember]
            public CallForwardingSubFeaturesDto callForwardingBusy { get; set; }
            [DataMember]
            public CallForwardingNoReplyFeaturesDto callForwardingNoReply { get; set; }
            [DataMember]
            public CallForwardingSubFeaturesDto callForwardingUnconditional { get; set; }

            public CallForwardingfeaturesDto() { }

        }

        [DataContract]
        public class CallForwardingNoReplyFeaturesDto
        {

            [DataMember]
            public bool enableVoicemail { get; set; }
            [DataMember]
            public string number { get; set; }
            [DataMember]
            public string rings { get; set; }
            [DataMember]
            public bool active { get; set; }

            public CallForwardingNoReplyFeaturesDto() { }

        }

        [DataContract]
        public class CallForwardingSubFeaturesDto
        {

            [DataMember]
            public bool enableVoicemail { get; set; }
            [DataMember]
            public string number { get; set; }
            [DataMember]
            public bool active { get; set; }

            public CallForwardingSubFeaturesDto() { }

        }

        [DataContract]
        public class CobsAccountDto
        {

            [DataMember]
            public string company { get; set; }
            [DataMember]
            public string initials { get; set; }
            [DataMember]
            public string intercalation { get; set; }
            [DataMember]
            public string lastName { get; set; }

            public CobsAccountDto() { }

        }

        [DataContract]
        public class CobsAddressDto
        {

            [DataMember]
            public string city { get; set; }
            [DataMember]
            public string country { get; set; }
            [DataMember]
            public int houseNumber { get; set; }
            [DataMember]
            public string houseNumberExtra { get; set; }
            [DataMember]
            public string street { get; set; }
            [DataMember]
            public string zipcode { get; set; }

            public CobsAddressDto() { }

        }

        [DataContract]
        public class CobsCancelDslOrderResponse
        {

            [DataMember]
            public bool isSuccessfull { get; set; }
            [DataMember]
            public string errorMessage { get; set; }

            public CobsCancelDslOrderResponse() { }

        }

        [DataContract]
        public class CobsDslCpeDelieveryDto
        {

            [DataMember]
            public string reference { get; set; }
            [DataMember]
            public string trackAndTraceUrl { get; set; }
            [DataMember]
            public DateTime dateSent { get; set; }
            [DataMember]
            public DateTime dateReturned { get; set; }
            [DataMember]
            public string cpeGroup { get; set; }
            [DataMember]
            public string cpeCode { get; set; }
            [DataMember]
            public bool isWireless { get; set; }
            [DataMember]
            public string description { get; set; }

            public CobsDslCpeDelieveryDto() { }

        }

        [DataContract]
        public class CobsDslHardwareDelieveryDto
        {

            [DataMember]
            public string delieveryDateString { get; set; }
            [DataMember]
            public string partOfDay { get; set; }
            [DataMember]
            public string sentDateString { get; set; }

            public CobsDslHardwareDelieveryDto() { }

        }

        [DataContract]
        public class CobsDslHeaderDto
        {

            [DataMember]
            public CobsDslOrderType orderType { get; set; }
            [DataMember]
            public string[] orderStatusEmailList { get; set; }
            [DataMember]
            public string resellerName { get; set; }
            [DataMember]
            public string productTypeCode { get; set; }
            [DataMember]
            public DateTime orderWishDate { get; set; }
            [DataMember]
            public DateTime noChargeCancelDueDate { get; set; }
            [DataMember]
            public string orderNrReseller { get; set; }
            [DataMember]
            public string orderNrBaByXl { get; set; }
            [DataMember]
            public string prodInstNrReserller { get; set; }
            [DataMember]
            public string prodInstNrBaByXl { get; set; }
            [DataMember]
            public string customerCodeIsp { get; set; }
            [DataMember]
            public string password { get; set; }
            [DataMember]
            public string kpnServiceId { get; set; }
            [DataMember]
            public int addNewContractPeriod { get; set; }
            [DataMember]
            public bool newLineEnigeBewoner { get; set; }

            public CobsDslHeaderDto() { }

        }

        [DataContract]
        public class CobsDslMiscDto
        {

            [DataMember]
            public string orderDelievered { get; set; }
            [DataMember]
            public DataExistingLineDto lineInfo { get; set; }
            [DataMember]
            public string nRPCodeField { get; set; }

            public CobsDslMiscDto() { }

        }

        [DataContract]
        public class CobsDslOrderDto
        {

            [DataMember]
            public CobsDslHeaderDto header { get; set; }
            [DataMember]
            public DataExistingLineDto dataExistingLine { get; set; }
            [DataMember]
            public DslDelieveryAddressDto delieveryAddress { get; set; }
            [DataMember]
            public DslOrderLineDto[] orderLines { get; set; }

            public CobsDslOrderDto() { }

        }

        [DataContract]
        public class CobsDslOrderStatus
        {

            [DataMember]
            public string statusNameField { get; set; }
            [DataMember]
            public DateTime statusDateField { get; set; }
            [DataMember]
            public string statusCommentField { get; set; }

            public CobsDslOrderStatus() { }

        }

        [DataContract]
        public enum CobsDslOrderType
        {
            [EnumMember]
            Unknown,
            [EnumMember]
            Provide,
            [EnumMember]
            ProductTypeChange,
            [EnumMember]
            Cease,
            [EnumMember]
            IpAddressChange,
            [EnumMember]
            ContactPersonChange,
            [EnumMember]
            Move,
            [EnumMember]
            TakeOver
        }

        [DataContract]
        public class CobsDslPlanDatesDto
        {

            [DataMember]
            public CobsDslHardwareDelieveryDto cpeDelievery { get; set; }
            [DataMember]
            public CobsDslHardwareDelieveryDto pstnDelievery { get; set; }
            [DataMember]
            public DateTime plannedDeliveryDate { get; set; }

            public CobsDslPlanDatesDto() { }

        }

        [DataContract]
        public class CobsDslSubmitOrderRequest
        {

            [DataMember]
            public CobsDslOrderDto order { get; set; }

            public CobsDslSubmitOrderRequest() { }

        }

        [DataContract]
        public class CobsErrorDto
        {

            [DataMember]
            public string code { get; set; }
            [DataMember]
            public string line { get; set; }
            [DataMember]
            public string linePos { get; set; }
            [DataMember]
            public string reason { get; set; }
            [DataMember]
            public string orderNrReseller { get; set; }

            public CobsErrorDto() { }

        }

        [DataContract]
        public class CobsGetAssociatedNumbersRequest
        {

            [DataMember]
            public string ispName { get; set; }
            [DataMember]
            public string dslPIN { get; set; }
            [DataMember]
            public string sessionKey { get; set; }
            [DataMember]
            public string endUserID { get; set; }
            [DataMember]
            public string zipcode { get; set; }

            public CobsGetAssociatedNumbersRequest() { }

        }

        [DataContract]
        public class CobsGetAssociatedNumbersResponse
        {

            [DataMember]
            public string result { get; set; }
            [DataMember]
            public CobsTelephoneNumber[] numbers { get; set; }

            public CobsGetAssociatedNumbersResponse() { }

        }

        [DataContract]
        public class CobsGetDslOrderRequest
        {

            [DataMember]
            public string sCobsOrderNumber { get; set; }
            [DataMember]
            public string sResellerOrderNumber { get; set; }

            public CobsGetDslOrderRequest() { }

        }

        [DataContract]
        public class CobsGetDslOrderResponse
        {

            [DataMember]
            public CobsDslHeaderDto statusHeader { get; set; }
            [DataMember]
            public CobsDslOrderStatus[] statuses { get; set; }
            [DataMember]
            public AdditionalHeaderFields additionalHeaderFields { get; set; }
            [DataMember]
            public CobsDslPlanDatesDto planDates { get; set; }
            [DataMember]
            public CobsDslCpeDelieveryDto[] cpeDelieveries { get; set; }
            [DataMember]
            public CobsDslMiscDto misc { get; set; }

            public CobsGetDslOrderResponse() { }

        }

        [DataContract]
        public class CobsGetNextDslOrderStatusResponse
        {

            [DataMember]
            public string nextPollId { get; set; }
            [DataMember]
            public CobsGetDslOrderResponse cobsGetDslOrderResponse { get; set; }

            public CobsGetNextDslOrderStatusResponse() { }

        }

        [DataContract]
        public class CobsGetNextTvOrderStatusRequest
        {

            [DataMember]
            public string lastPolledId { get; set; }
            [DataMember]
            public RunningEnvironment runningEnvironment { get; set; }

            public CobsGetNextTvOrderStatusRequest() { }

        }

        [DataContract]
        public class CobsGetNextTvOrderStatusResponse
        {

            [DataMember]
            public CobsTvOrderInfoDto tvOrderInfo { get; set; }
            [DataMember]
            public TvOrderStatusChangeDto[] orderStatusChanges { get; set; }
            [DataMember]
            public TvVasPackageOrderStateDto[] tvVasPackages { get; set; }
            [DataMember]
            public DateTime signalUtcDate { get; set; }
            [DataMember]
            public string nextSignalId { get; set; }
            [DataMember]
            public string error { get; set; }
            [DataMember]
            public string errorType { get; set; }

            public CobsGetNextTvOrderStatusResponse() { }

        }

        [DataContract]
        public class CobsGetNextVoipOrderStatusRequest
        {

            [DataMember]
            public string signalId { get; set; }
            [DataMember]
            public RunningEnvironment runningEnvironment { get; set; }

            public CobsGetNextVoipOrderStatusRequest() { }

        }

        [DataContract]
        public class CobsGetNextVoipOrderStatusResponse
        {

            [DataMember]
            public string nextSignalId { get; set; }
            [DataMember]
            public CobsVoipOrderDto orderInfo { get; set; }
            [DataMember]
            public string errorType { get; set; }
            [DataMember]
            public string error { get; set; }

            public CobsGetNextVoipOrderStatusResponse() { }

        }

        [DataContract]
        public class CobsOrderDataDto
        {

            [DataMember]
            public string orderMemoText { get; set; }
            [DataMember]
            public CobsVoipOrderType orderType { get; set; }
            [DataMember]
            public DateTime orderWishDate { get; set; }
            [DataMember]
            public DateTime orderDeliveryDate { get; set; }
            [DataMember]
            public DateTime orderPlanDate { get; set; }
            [DataMember]
            public OrderStateTransitionDto[] orderStateTransitions { get; set; }
            [DataMember]
            public string[] orderStatusEmailAddresses { get; set; }

            public CobsOrderDataDto() { }

        }

        [DataContract]
        public class CobsRetrieveTvOrderStatusRequest
        {

            [DataMember]
            public RunningEnvironment runningEnvironment { get; set; }
            [DataMember]
            public string tvOrderId { get; set; }

            public CobsRetrieveTvOrderStatusRequest() { }

        }

        [DataContract]
        public class CobsRetrieveTvOrderStatusResponse
        {

            [DataMember]
            public CobsTvOrderInfoDto order { get; set; }
            [DataMember]
            public TvOrderStatusChangeDto[] orderStatusChanges { get; set; }
            [DataMember]
            public string error { get; set; }
            [DataMember]
            public string errorType { get; set; }
            [DataMember]
            public TvVasPackageOrderStateDto[] tvVasPackages { get; set; }

            public CobsRetrieveTvOrderStatusResponse() { }

        }

        [DataContract]
        public class CobsSubmitDslOrderResponse
        {

            [DataMember]
            public Error[] errors { get; set; }
            [DataMember]
            public string serverName { get; set; }
            [DataMember]
            public string testMessage { get; set; }
            [DataMember]
            public string orderNrBaByXl { get; set; }
            [DataMember]
            public string prodInstNrBaByXl { get; set; }

            public CobsSubmitDslOrderResponse() { }

        }

        [DataContract]
        public class CobsSubmitTvOrderRequest
        {

            [DataMember]
            public RunningEnvironment runningEnvironment { get; set; }
            [DataMember]
            public CobsTvOrderDto tvOrder { get; set; }

            public CobsSubmitTvOrderRequest() { }

        }

        [DataContract]
        public class CobsSubmitTvOrderResponse
        {

            [DataMember]
            public SubmitCobsTvOrderErrorDto[] submitOrderErrors { get; set; }
            [DataMember]
            public string orderNumber { get; set; }
            [DataMember]
            public string tvProductInstanceNumber { get; set; }
            [DataMember]
            public string orderNumberIsp { get; set; }

            public CobsSubmitTvOrderResponse() { }

        }

        [DataContract]
        public class CobsTelephoneNumber
        {

            [DataMember]
            public string fullNumber { get; set; }
            [DataMember]
            public string status { get; set; }

            public CobsTelephoneNumber() { }

        }

        [DataContract]
        public class CobsTvOrderDto
        {

            [DataMember]
            public TvOrderType orderType { get; set; }
            [DataMember]
            public string ispName { get; set; }
            [DataMember]
            public int productTypeCode { get; set; }
            [DataMember]
            public string customerCodeIsp { get; set; }
            [DataMember]
            public string billingIdIsp { get; set; }
            [DataMember]
            public DateTime orderWishDt { get; set; }
            [DataMember]
            public string orderNumberIsp { get; set; }
            [DataMember]
            public string tvProductInstanceNumberIsp { get; set; }
            [DataMember]
            public string tvProductInstanceNumber { get; set; }
            [DataMember]
            public string relatedDslProductInstanceNumber { get; set; }
            [DataMember]
            public OrderEntryTvVasPackageDto[] tvVasPackageUpdates { get; set; }

            public CobsTvOrderDto() { }

        }

        [DataContract]
        public class CobsTvOrderInfoDto
        {

            [DataMember]
            public TvOrderType orderType { get; set; }
            [DataMember]
            public string ispName { get; set; }
            [DataMember]
            public int productTypeCode { get; set; }
            [DataMember]
            public string customerCodeIsp { get; set; }
            [DataMember]
            public string billingIdIsp { get; set; }
            [DataMember]
            public DateTime orderWishDt { get; set; }
            [DataMember]
            public DateTime planDt { get; set; }
            [DataMember]
            public DateTime deliverDt { get; set; }
            [DataMember]
            public string orderNumber { get; set; }
            [DataMember]
            public string orderNumberIsp { get; set; }
            [DataMember]
            public string tvProductInstanceNumberIsp { get; set; }
            [DataMember]
            public string tvProductInstanceNumber { get; set; }
            [DataMember]
            public string relatedDslProductInstanceNumber { get; set; }
            [DataMember]
            public string technicalAccountNumber { get; set; }
            [DataMember]
            public string pinCode { get; set; }
            [DataMember]
            public TvOrderStatus status { get; set; }
            [DataMember]
            public DateTime statusDt { get; set; }

            public CobsTvOrderInfoDto() { }

        }

        [DataContract]
        public class CobsVoipDataDto
        {

            [DataMember]
            public string voipOrderNumberBabyXl { get; set; }
            [DataMember]
            public string voipOrderNumberReseller { get; set; }
            [DataMember]
            public string voipProductInstanceNumberBabyXl { get; set; }
            [DataMember]
            public string voipProductInstanceNumberReseller { get; set; }
            [DataMember]
            public int voipProductTypeCode { get; set; }
            [DataMember]
            public string voipResellerCustomerBillingID { get; set; }
            [DataMember]
            public string voipTelephoneNumber { get; set; }
            [DataMember]
            public string voipUsername { get; set; }

            public CobsVoipDataDto() { }

        }

        [DataContract]
        public class CobsVoipOrderDto
        {

            [DataMember]
            public CobsAddressDto address { get; set; }
            [DataMember]
            public CobsAccountDto account { get; set; }
            [DataMember]
            public string dslProductInstanceNumberBabyXl { get; set; }
            [DataMember]
            public string messagePassword { get; set; }
            [DataMember]
            public DateTime noChargeCancelDueDate { get; set; }
            [DataMember]
            public CobsOrderDataDto orderData { get; set; }
            [DataMember]
            public string resellerName { get; set; }
            [DataMember]
            public bool testMessage { get; set; }
            [DataMember]
            public string voicemailEmailAddress { get; set; }
            [DataMember]
            public CobsVoipDataDto voipData { get; set; }

            public CobsVoipOrderDto() { }

        }

        [DataContract]
        public class CobsVoipOrderResultDto
        {

            [DataMember]
            public CobsErrorDto[] error { get; set; }
            [DataMember]
            public string serverName { get; set; }
            [DataMember]
            public string testMessage { get; set; }
            [DataMember]
            public string voipOrderNumberBabyXl { get; set; }
            [DataMember]
            public string voipProductInstanceNumberBabyXl { get; set; }
            [DataMember]
            public CobsVoipOrderType voipOrderType { get; set; }

            public CobsVoipOrderResultDto() { }

        }

        [DataContract]
        public enum CobsVoipOrderState
        {
            [EnumMember]
            Unknown,
            [EnumMember]
            Received,
            [EnumMember]
            AccOnHold,
            [EnumMember]
            Accepted,
            [EnumMember]
            InstallPlanned,
            [EnumMember]
            TechDelivered,
            [EnumMember]
            Completed,
            [EnumMember]
            CancelledRollingBack,
            [EnumMember]
            Cancelled,
            [EnumMember]
            DeniedRollingBack,
            [EnumMember]
            Denied,
            [EnumMember]
            Sleeping,
            [EnumMember]
            XTLplanned
        }

        [DataContract]
        public enum CobsVoipOrderType
        {
            [EnumMember]
            V_Provide,
            [EnumMember]
            V_Provide_NP,
            [EnumMember]
            V_Cease,
            [EnumMember]
            V_Cease_NP,
            [EnumMember]
            V_Move,
            [EnumMember]
            V_Transfer,
            [EnumMember]
            V_Change
        }

        [DataContract]
        public class DataExistingLineDto
        {

            [DataMember]
            public string contractNumber { get; set; }
            [DataMember]
            public string telNr { get; set; }
            [DataMember]
            public Isdn2Pstn isdn2pstn { get; set; }

            public DataExistingLineDto() { }

        }

        [DataContract]
        public class DslComunicationDto
        {

            [DataMember]
            public string[] telNr { get; set; }
            [DataMember]
            public string emailAddress { get; set; }

            public DslComunicationDto() { }

        }

        [DataContract]
        public class DslContactDto
        {

            [DataMember]
            public string companyName { get; set; }
            [DataMember]
            public string firstName { get; set; }
            [DataMember]
            public string middleName { get; set; }
            [DataMember]
            public string lastName { get; set; }
            [DataMember]
            public string suffix { get; set; }
            [DataMember]
            public DslGender gender { get; set; }
            [DataMember]
            public DslComunicationDto communication { get; set; }

            public DslContactDto() { }

        }

        [DataContract]
        public class DslDelieveryAddressDto
        {

            [DataMember]
            public string zipCode { get; set; }
            [DataMember]
            public string street { get; set; }
            [DataMember]
            public string houseNr { get; set; }
            [DataMember]
            public string houseNrExt { get; set; }
            [DataMember]
            public string city { get; set; }
            [DataMember]
            public DslContactDto contact { get; set; }

            public DslDelieveryAddressDto() { }

        }

        [DataContract]
        public enum DslGender
        {
            [EnumMember]
            M,
            [EnumMember]
            V
        }

        [DataContract]
        public class DslOrderLineDto
        {

            [DataMember]
            public string hardwareTypeId { get; set; }
            [DataMember]
            public int hardwareAmount { get; set; }

            public DslOrderLineDto() { }

        }

        [DataContract]
        public class Error
        {

            [DataMember]
            public int code { get; set; }
            [DataMember]
            public string line { get; set; }
            [DataMember]
            public string linePos { get; set; }
            [DataMember]
            public string reason { get; set; }
            [DataMember]
            public string orderNrReseller { get; set; }

            public Error() { }

        }

        [DataContract]
        public class GetPhonebookEntryResponse
        {

            [DataMember]
            public PhonebookEntryDto phonebookEntry { get; set; }
            [DataMember]
            public bool isSuccessful { get; set; }

            public GetPhonebookEntryResponse() { }

        }

        [DataContract]
        public class GetSubscriberSettingsResponse
        {

            [DataMember]
            public SubscriberSettingsDto subscriberSettingsDto { get; set; }
            [DataMember]
            public bool isSuccessful { get; set; }

            public GetSubscriberSettingsResponse() { }

        }

        [DataContract]
        public class GetVoipAccountStatusResponse
        {

            [DataMember]
            public VoipStateInformationDto[] voipstateInformation { get; set; }
            [DataMember]
            public bool isSuccessful { get; set; }

            public GetVoipAccountStatusResponse() { }

        }

        [DataContract]
        public enum Isdn2Pstn
        {
            [EnumMember]
            Undefined = 0,
            [EnumMember]
            ISDN2,
            [EnumMember]
            PSTN,
            [EnumMember]
            ISDN
        }

        [DataContract]
        public class OrderEntryTvVasPackageDto
        {

            [DataMember]
            public string tvVasPacketType { get; set; }
            [DataMember]
            public TvVasPacketAction action { get; set; }

            public OrderEntryTvVasPackageDto() { }

        }

        [DataContract]
        public class OrderStateTransitionDto
        {

            [DataMember]
            public DateTime statusDate { get; set; }
            [DataMember]
            public CobsVoipOrderState statusName { get; set; }

            public OrderStateTransitionDto() { }

        }

        [DataContract]
        public enum PaidServices
        {
            [EnumMember]
            BLOCK_ALL,
            [EnumMember]
            BLOCK_ADULT_CHAT_AND_AMUSEMENT,
            [EnumMember]
            BLOCK_ADULT_CHAT,
            [EnumMember]
            ALLOW_ALL
        }

        [DataContract]
        public class PhonebookEntryDto
        {

            [DataMember]
            public string firstName { get; set; }
            [DataMember]
            public string lastNamePrefix { get; set; }
            [DataMember]
            public string lastName { get; set; }
            [DataMember]
            public bool consentElectronicServices { get; set; }
            [DataMember]
            public bool consentInformationServices { get; set; }
            [DataMember]
            public bool consentPrintedPhonebook { get; set; }

            public PhonebookEntryDto() { }

        }



















        [DataContract]
        public enum ReservePhoneNumberOrderType
        {
            [EnumMember]
            Initial,
            [EnumMember]
            Change,
            [EnumMember]
            Rehoming
        }

        [DataContract]
        public class ReservePhoneNumberRequestDto
        {

            [DataMember]
            public string ispName { get; set; }
            [DataMember]
            public ReservePhoneNumberOrderType orderType { get; set; }
            [DataMember]
            public string dslPIN { get; set; }
            [DataMember]
            public string sessionKey { get; set; }
            [DataMember]
            public string endUserID { get; set; }
            [DataMember]
            public string zipcode { get; set; }
            [DataMember]
            public int addressHouseNumber { get; set; }
            [DataMember]
            public string addressHouseNumberExtra { get; set; }

            public ReservePhoneNumberRequestDto() { }

        }

        [DataContract]
        public enum RunningEnvironment
        {
            [EnumMember]
            Production,
            [EnumMember]
            Development,
            [EnumMember]
            Buildserver,
            [EnumMember]
            Training
        }

        [DataContract]
        public class SubmitCobsTvOrderErrorDto
        {

            [DataMember]
            public string type { get; set; }
            [DataMember]
            public string description { get; set; }

            public SubmitCobsTvOrderErrorDto() { }

        }

        [DataContract]
        public class SubscriberSettingsDto
        {

            [DataMember]
            public bool sendMyCallerID { get; set; }
            [DataMember]
            public bool bNumberHiding { get; set; }
            [DataMember]
            public PaidServices paidServiceRestriction { get; set; }
            [DataMember]
            public bool allowDialInternational { get; set; }
            [DataMember]
            public bool allowDialMobile { get; set; }
            [DataMember]
            public CallForwardingfeaturesDto callForwardingfeatures { get; set; }

            public SubscriberSettingsDto() { }

        }

        [DataContract]
        public enum TvOrderStatus
        {
            [EnumMember]
            Received,
            [EnumMember]
            Accepted,
            [EnumMember]
            Denied,
            [EnumMember]
            InstallPlanned,
            [EnumMember]
            Completed,
            [EnumMember]
            Cancelled,
            [EnumMember]
            AccOnHold,
            [EnumMember]
            PSTNPlanned,
            [EnumMember]
            XTLPlanned,
            [EnumMember]
            ToBeCancelled,
            [EnumMember]
            DeniedRollingBack,
            [EnumMember]
            ToBeDenied,
            [EnumMember]
            Sleeping,
            [EnumMember]
            Activated,
            [EnumMember]
            CancelledRollingBack,
            [EnumMember]
            PreOrder,
            [EnumMember]
            TechDelivered,
            [EnumMember]
            Unknown
        }

        [DataContract]
        public class TvOrderStatusChangeDto
        {

            [DataMember]
            public DateTime date { get; set; }
            [DataMember]
            public string status { get; set; }
            [DataMember]
            public string user { get; set; }

            public TvOrderStatusChangeDto() { }

        }

        [DataContract]
        public enum TvOrderType
        {
            [EnumMember]
            TvProvide,
            [EnumMember]
            TvCease,
            [EnumMember]
            TvChange
        }

        [DataContract]
        public class TvVasPackageOrderStateDto
        {

            [DataMember]
            public string tvVasPacketType { get; set; }
            [DataMember]
            public string description { get; set; }
            [DataMember]
            public TvVasPacketStatus action { get; set; }

            public TvVasPackageOrderStateDto() { }

        }

        [DataContract]
        public enum TvVasPacketAction
        {
            [EnumMember]
            Add,
            [EnumMember]
            Drop
        }

        [DataContract]
        public enum TvVasPacketStatus
        {
            [EnumMember]
            ToAdd,
            [EnumMember]
            Adding,
            [EnumMember]
            Added,
            [EnumMember]
            ToDrop,
            [EnumMember]
            Dropping,
            [EnumMember]
            Dropped
        }

        [DataContract]
        public enum Voip_refLockedBy
        {
            [EnumMember]
            ISP,
            [EnumMember]
            FINANCE
        }

        [DataContract]
        public class VoipStateInformationDto
        {

            [DataMember]
            public string endUserId { get; set; }
            [DataMember]
            public string voipUsername { get; set; }
            [DataMember]
            public VoipStateStatus voipState { get; set; }
            [DataMember]
            public DateTime lastChangeDate { get; set; }
            [DataMember]
            public string lastChangeBy { get; set; }
            [DataMember]
            public Voip_refLockedBy lockedBy { get; set; }

            public VoipStateInformationDto() { }

        }

        [DataContract]
        public enum VoipStateStatus
        {
            [EnumMember]
            Normal,
            [EnumMember]
            Suspend,
            [EnumMember]
            Normal_Pending,
            [EnumMember]
            Suspend_Pending
        }

        [ServiceContract]
        public interface CobsService
        {
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsVoipOrderResultDto SubmitVoipOrder(CobsVoipOrderDto order);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsSubmitTvOrderResponse SubmitTvOrder(CobsSubmitTvOrderRequest request);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsVoipOrderDto RetrieveVoipOrder(string cobsOrderNumber, string resellerOrderNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsRetrieveTvOrderStatusResponse RetrieveTvOrder(CobsRetrieveTvOrderStatusRequest request);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            string ReservePhoneNumber(ReservePhoneNumberRequestDto order);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsSubmitDslOrderResponse SubmitDslOrder(CobsDslSubmitOrderRequest request);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsCancelDslOrderResponse CancelDslOrder(string cobsOrderNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsGetDslOrderResponse RetrieveDslOrder(CobsGetDslOrderRequest request);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsGetNextDslOrderStatusResponse GetNextDslOrderStatus(string cobsDslOrderLastPolledId);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsGetAssociatedNumbersResponse CobsGetAssociatedNumbers(CobsGetAssociatedNumbersRequest order);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsGetNextTvOrderStatusResponse GetNextTvOrderStatus(CobsGetNextTvOrderStatusRequest request);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            CobsGetNextVoipOrderStatusResponse GetNextVoipOrderStatus(CobsGetNextVoipOrderStatusRequest request);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            string GetVoipSettingsId(string cobsOrderNumber, string phoneNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            GetSubscriberSettingsResponse GetVoipSettings(string cobsVoipProductNumber, string cobsOrderNumber, string phoneNumber, string voipSettingsId);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            void SetVoipSettings(SubscriberSettingsDto settings, string cobsOrderNumber, string phoneNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            GetPhonebookEntryResponse GetPhonebookEntry(string cobsOrderNumber, string phoneNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            void SetPhonebookEntry(PhonebookEntryDto phonebookEntry, string cobsOrderNumber, string phoneNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            GetVoipAccountStatusResponse GetVoipAccountStatus(string cobsOrderNumber, string phoneNumber);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            void SetVoipAccountStatus(string cobsOrderNumber, string phoneNumber, VoipStateStatus stateStatus, Voip_refLockedBy refLockedBy);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            void SetTvAccountState(string TvProductInstanceNumber, TVStateStatus TVStateStatus, string TvProductInstanceNumberIsp);
            [OperationContract]
            [FaultContractAttribute(typeof(DomainFault))]
            void SetDslState(string CobsDslProductInstanceNumber, LineStatus LineStatus, string PageText, string TvProductInstanceNumberIsp);
        }

    }


    [DataContractAttribute]
    public class DomainFault
    {
        [DataMemberAttribute]
        public DomainError Code;

        [DataMemberAttribute]
        public string Message;
    }

    [DataContract]
    public enum TVAccountState
    {
        [EnumMember]
        Ceased,
        [EnumMember]
        Normal,
        [EnumMember]
        Suspend

    }

}