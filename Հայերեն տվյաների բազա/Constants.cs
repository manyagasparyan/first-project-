﻿using Common.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Common
{
    public partial class Constants
    {
        public static int MainExternalClientId = 21;
        public static int MainPartnerId = 2121;         // who is this ??!
        public static string DefaultLanguageId = "en";
        public static string DefaultCurrencyId = "USD";
        public static string DefaultIp = "5.63.160.95";
        public static string DefaultCountryCode = "am";
        public static string CountryCodeArmenia = "ARM";
        public static int DefaultCountryId = 257; //Armenia
        public static int DefaultCityId = 1807;
        public static string DefaultCity = "Yerevan";
        public static string DefaultCountry = "Armenia";
        public static string CurrencyIdAmd = "AMD";
        public static string DefaultCurrencyIdForBetongames = "AMD";
        public static int NoCountry = 1;
        public static int NoCity = 2;

        public const int OwnVersionSecurityQuestionId = 1;
        public const int PlatformProductId = 1;

        public const int ClosePeriodPeriodicy = 1;
        public const int ClosePeriodDaily = 24;
        public const int AddMoneyToPartnerAccountPeriodicy = 1;
        public const int BetShopDailyTicketNumberResetPeriodicy = 24;

        public const decimal Delta = 0.00001m;

        public const string UserCustomRoleFormat = "{0} custom role";

        public const string liveKey = "GamingPlatformEntities1";
        public const string syncKey = "GamingPlatformEntities2";

        public const string AddingClientBonus = "Adding Client Bonus";
        public const string CancelClientBonus = "Bonus canceled by Admin";
        public const string RedeemClientBonus = "Bonus redeemed by Admin";
        public const string ResetBonus = "Reset bonus";

        // translation names
        public const string OnlineWithdrawalMethods = "OnlineWithdrawalMethods";
        public const string OfflineWithdrawalMethods = "OfflineWithdrawalMethods";
        public const string OnlineDepositMethods = "OnlineDepositMethods";
        public const string OfflineDepositMethods = "OfflineDepositMethods";

        //public class EmailSubjects
        //{
        //	public static string VerificationEmailSubject = "Verification message";
        //	public static string PasswordRecoveryEmailSubject = "Password recovery message";
        //	public static string PasswordResetEmailSubject = "Password reset message";
        //}

        //public static List<int> IpList17824833131 = new List<int> { 789, 825, 826, 827, 828, 829, 830, 831, 832, 833, 841, 836, 837, 838, 839, 840, 842, 843, 844, 834, 835 };

        //public static List<int> IpList17824833132 = new List<int> { 836, 837, 838, 839, 840, 842, 843, 844, 834, 835, 789, 825, 826, 827, 828, 829, 830, 831, 832, 833, 841 };

        public static List<int> IpList7815852201 = new List<int> { 818, 819, 820, 821, 822, 823, 824, 790, 791, 792, 793, 794, 795, 796, 797, 798, 799, 800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817 };

        public class WithdrawalStatusChangePermission
        {
            //Action with permission name
            public static Dictionary<string, string> AllowedWebActions = new Dictionary<string, string>
            {
                { "PaymentSystem/PayPaymentRequest", "ApproveForWithdrawal" },
                { "PaymentSystem/WithdrawalManuallyApprove", "ApproveForWithdrawal" },
                { "PaymentSystem/AllowPaymentRequest", "ConfirmForWithdrawal" },
                { "PaymentSystem/SetToFrozenPaymentRequest", "FreezeForWithdrawal" },
                { "PaymentSystem/SetToInProcessPaymentRequest", "InProcessForWithdrawal" },
                { "PaymentSystem/SetToWaitingForKYCPaymentRequest", "WaitingForKYCInWithdrawal" },

                //Cancel
                { "PaymentSystem/CancelApprovedWithdraw", "CancelForWithdrawal" },
                { "PaymentSystem/CancelApprovedWithdrawal", "CancelForWithdrawal" },
                { "PaymentSystem/CancelClientPaymentRequest", "CancelForWithdrawal" },
                { "PaymentSystem/RejectPaymentRequest", "CancelForWithdrawal" }
            };

            public static int[] AllowedPartners = { (int)Partner.Takbet, (int)Partner.Betfa,
                                                    (int)Partner.Betmah, (int)Partner.XFA1,
                                                    (int)Partner.Fastbet, (int)Partner.Irtoto };
        }

        /// <summary>
        /// Allowed methods and not allowed partners when player in force password change state
        /// </summary>
        public class ForcePasswordChange
        {
            public static string[] AllowedWebActions = { "Main/LoginClient", "Client/GetClientStates", "Client/LogoutClient", "Client/ForceChangeClientPassword" };
            public static string[] AllowedAdminActions = { "User/SetNewPassword", "User/Logout" };
            public static int[] NotAllowedPartners = { (int)Partner.Gusar, (int)Partner.TotoGamingAm };
        }

        public class SystemActivity
        {
            public static int[] AllowedPartners = { (int)Partner.Danybet };

            public static string[] ClientNotMonitoredActions = { "Client/GetClientStates",
                                                                 "Main/GetClientBalance",
                                                                 "Document/GetFriendToFriendTransferCount" };

            public static string[] UserNotMonitoredActions = { "PaymentSystem/GetPaymentRequestsCount"
                                                             , "Client/GetUsersUnreadMessagesCount"};
        }

        public class DepositCallsFromWeb
        {
            public static string[] DepositCalls = { "Main/GetPartnerPaymentSystems", "Document/CreateDepositRequest" };
        }

        public enum NotificationServiceProviders
        {
            TotoNotificationService = 1,
            DigitainSMSservice = 2
        }

        public class ClaimsIdentityType
        {
            public const string ParentPartnerId = "ParentPartnerId";
            public const string SessionId = "SessionId";
            public const string Token = "Token";
            public const string UserName = "UserName";
        }

        public enum AllowClientApp
        {
            Application = 1,
            Browser = 2
        }

        public enum AllowClientApiType
        {
            AdminApi = 1,
            SiteApi = 2
        }

        public enum ReportParamType
        {
            [Description("Withdrawal")]
            Withdrawal = 1,
            [Description("Deposit")]
            Deposit = 2
        }

        public enum ReportFilterType
        {
            [Description("Withdrawal")]
            Withdrawal = 1,
            [Description("Deposit")]
            Deposit = 2,
            [Description("Bet")]
            Bet = 3
        }

        public enum ReportTaskStatus
        {
            [Description("Pending")]
            Pending = 1,
            [Description("InProgress")]
            InProgress = 2,
            [Description("Canceled")]
            Canceled = 3,
            [Description("Finished")]
            Finished = 4,
            [Description("Failed")]
            Failed = 5
        }

        public enum ObjectTypes
        {
            ErrorType = 1,
            Client = 2,
            PaymentSystem = 3,
            BetShop = 4,
            Partner = 5,
            CashDesk = 6,
            PartnerProduct = 7,
            PartnerKey = 8,
            Account = 9,
            User = 10,
            ClientMessage = 11,
            Document = 12,
            BetShopGroup = 13,
            PartnerPaymentSetting = 14,
            PaymentRequest = 15,
            Transaction = 16,
            PartnerSetting = 17,
            Product = 18,
            PartnerProductSetting = 19,
            GameProvider = 20,
            fnBetShopBet = 21,
            Job = 22,
            Enumeration = 23,
            fnCashDeskTransaction = 24,
            RolePermission = 25,
            fnInternetBet = 26,
            fnPartnerPaymentSetting = 27,
            AccountType = 28,
            fnAccountType = 29,
            fnTranslationEntry = 30,
            Role = 31,
            Region = 32,
            fnClient = 33,
            fnPartnerProductSetting = 34,
            fnDepositToInternetClient = 35,
            BetShopReconing = 36,
            fnProduct = 37,
            fnRegion = 38,
            Currency = 39,
            Permission = 40,
            ClientSession = 41,
            PartnerCurrencySetting = 42,
            fnNote = 43,
            fnClientReport = 44,
            fnPaymentRequest = 45,
            Translation = 46,
            OperationType = 47,
            fnDocument = 48,
            fnOnlineClient = 49,
            fnReportByProvider = 50,
            fnReportByProduct = 51,
            fnReportByBetShopOperation = 52,
            fnUserLog = 53,
            fnReportByClientDetails = 54,
            ClientAccountsBalanceHistoryElement = 55,
            fnCorrection = 56,
            ClientIdentity = 57,
            fnClientIdentity = 58,
            ClientLog = 59,
            ClientCategory = 60,
            Bonus = 61,
            fnBonus = 62,
            fnBonusSetting = 63,
            fnInternetBetShort = 64,
            fnFreeSpin = 65,
            ProductCategory = 66,
            fnCorrectionReport = 67,
            fnInternetBetByGame = 68,
            fnWithdrawalRequest = 69,
            fnDepositRequest = 70,
            fnBetRequest = 71,
            fnClientRequest = 72,
            fnAddClientRequest = 73,
            fnSegmentsRequest = 74,
            fnClientObjectRequest = 75,
            fnProductObjectRequest = 76,
            fnProductRequest = 77,
            Tournament = 78,
            fnTournamentsRequest = 79,
            TournamentEntry = 80,
            //TournamentTypes = 81
            TournamentPrize = 82,
            fnReportBySportBonuses = 83,
            TournamentPrizeTypes = 84,
            PartnerGameProviderSetting = 85,
            Bank = 86,
            ProductType = 87,
            Segment = 88,
            fnGGRByPartners = 89,
            DashboardInfoBe = 90,
            fnPartnerPaymentSystem = 91,
            Commission = 92,
            ReferFriend = 93,
            Affiliate = 94,
            InviteFriend = 95,
            TempBank = 96,
            fnClientReportTotal = 97,
            fnCommissionsRequest = 98,
            Deposit = 99,
            Withdrawal = 100,
            fnReportByPlayerCategory = 101,
            RegistrationPage = 102,
            ProfilePage = 103,
            ClientBounsSettings = 104,
            ProductViewCategory = 105,
            fnReportByProvidersByProducts = 106,
            //SiteHeader = 107,
            //SiteFooter = 108,
            fnExternalOperations = 109,
            fnPartnerRegistrationIpSetting = 110,
            Site = 111,
            fnLostDepositBonus = 112,
            Language = 113,
            GameProduct = 114,
            PaymentSystemControls = 115,
            fnCardToCardTransaction = 116,
            PaymentSystemControlValues = 117,
            fnReportBySportProduct = 118,
            fnInternetBetWCC = 138,
            fnReportByClientGamingHistory = 139,
            fnPlayerPaymentSetting = 140,
            PlayerPaymentSetting = 141,
            ProductRate = 142,
            ResponsibleGaming = 143,
            //PartnerDepositLimit = 144,
            PartnerPeriodConfig = 145,
            PartnerPeriodTypes = 146,
            fnBonusBet = 147,
            Verification = 148,
            PaymentSystemName = 149
        }

        public class Languages
        {
            public const string English = "en";
            public const string Russian = "ru";
            public const string Armenian = "hy";
            public const string Arabic = "ar";
            public const string Turkish = "tr";
            public const string Danish = "da";
        }

        public class ResponseResults
        {
            public const string Success = "OK";
            public const string Error = "FAILED";
        }

        public enum SessionStates
        {
            Active = 1,
            Inactive = 2
        }

        public enum RegionStates
        {
            Active = 1,
            Inactive = 2
        }

        public enum Gender
        {
            Male = 1,
            Female = 2,
            Unknown = 3
        }

        public enum Partner
        {
            Danybet = 1,
            TotoGamingAm = 2,
            Portbet = 101,
            Mackbet = 102,
            Betbeto = 103,
            Betcloob = 104,
            Xlivebet = 105,
            LimaBet = 106,
            Jambobet = 107,
            CaptainWin = 108,
            Jambo = 109, // old
            Bethowin = 110,
            Cannonbet = 111,
            Molekulabet = 112,
            Hellobet = 113,
            Interbet = 114,
            Irbet = 115,
            Run88 = 116,
            Gusar = 117,
            Saturn365 = 118,
            Pishbini = 1001,
            Eurosport = 1002,
            SergenBet = 1003,
            XFA1 = 1004,
            Winstar90 = 1005,
            Bet999 = 1006,
            Betingem = 1007,
            Betoji = 1008,
            Goesporte = 1009,
            Xogame = 1010,
            Palbet = 1011,
            Betsitem = 1012,
            Kibet = 1013,
            Betnama = 1014,
            Irnets = 1015,
            Looix = 1016,
            Privebet = 1017,
            Hattrick = 1018,
            Oleobet = 1019,
            BetRealX = 1020,
            Bet5 = 1021,
            DavidBet = 1022,
            Irtoto = 1023,
            Fastbet = 1024,
            Qismatbet = 1025,
            Betkanyon = 1026,
            Takbet = 1027,
            Betfa = 1028,
            Captainwip = 1029,
            Wooowbet = 1030,
            Justinbet = 1031,
            Matrixbet = 1032,
            BetPerform = 1033,
            BetPluton = 1034,
            BetMan12 = 1035,
            SportLoto = 1036,
            CosmosWin = 1037,
            TotogamingCom = 1038,
            Betshah = 1039,
            CepBahis = 1040,
            Goodbet = 1041,
            AslanBet = 1042,
            Uni88Bet = 1043,
            Marcbet = 1044,
            BetPurse = 1046,
            Manotobetplus = 1047,
            ZumrutCasino = 1048,
            Betmah = 1049,
            Cloudbet = 1050,
            Tbet = 1051,
            WinonFire = 1052,
            Digitain = 2121
        }

        public enum ClientStates
        {
            Active = 1,
            BlockedForWithdraw = 10,
            BlockedForDeposit = 20,
            BlockedForTransaction = 4000,
            Blocked = 6000
        }

        public enum UserStates
        {
            Active = 1,
            Blocked = 2
        }

        public enum ClientInfoTypes
        {
            //Deposits, Withdrawals, BonusesPromotions, Information on this types look client notification settings for disable/enable notifications

            MobileVerificationKey = 1,
            EmailVerificationKey = 2,
            PasswordRecoveryMobileKey = 3,
            PasswordRecoveryEmailKey = 4,

            //Withdrawals
            WithdrawCancelByUserEmail = 5,
            WithdrawPayPandingEmail = 6,
            WithdrawAllowedEmail = 7,

            ResetPasswordFromAdminToEmail = 8,
            ApproveEmail = 9,
            PerfectMoneyApprovedEmail = 10,
            SafeChargeConfirmMessage = 11,

            //Withdrawals
            WithdrawCancelByUserSMS = 12,
            WithdrawPayPandingSMS = 13,
            WithdrawAllowedSMS = 14,

            ApproveSMS = 15,
            PerfectMoneyApprovedSMS = 16,
            SafeChargeConfirmSMS = 17,

            WithdrawFriendToFriendEmail = 18,

            //Deposits
            DepositAnsweredEmail = 19,
            DepositAnsweredSMS = 20,
            DepositApprovedEmail = 21,
            DepositApprovedSMS = 22,
            DepositCanceledByUserEmail = 23,
            DepositCanceledByUserSMS = 24,

            //Withdrawals
            WithdrawInProcessedEmail = 25,
            WithdrawInProcessedSMS = 26,

            TransferIdEmail = 27,
            TransferIdSms = 28,
            RegistrationVerificationLinkEmail = 29,
            RegistrationVerificationLinkSMS = 30,
            WellcomeMessageEmail = 31,
            PasswordRecoveryLinkEmail = 32,
            ProfileUpdateEmail = 33,
            PayboxConfirmMessage = 34,
            ResetPasswordSuccessfulEmail = 35,
            ChangePasswordSuccessfulEmail = 36,
            WithdrawPandingEmail = 37,
            WithdrawCancelByClientEmail = 38,
            PayboxConfirmSMS = 39,
            DocumentVerificationEmail = 60,

            PopupAfterLogin = 40,

            //Wager bonus received
            WagerBonusReceived = 41,

            //Xogame user registration
            RegistrationUserPassSms = 42,
            RegistrationUserPassEmail = 43,

            //TOTO
            WellcomeMessageEmaiUnder21 = 44,
            WellcomeMessageEmail21 = 45,
            WelcomeMessageWithoutBonusEmail = 46,
            WellcomeMessageSms21 = 47,

            //Xogame master visa transaction message
            MasterVisaTransactionMessage = 48,

            //Withdrawal Pay Pending Telcell
            WithdrawalTelcellPayPendingEmail = 49,
            WithdrawalTelcellPayPendingSms = 50,

            //////////////////////////////
            ResetUsernameSuccessfulEmail = 51,
            ResetUsernameSuccessfulSms = 52,

            PopupMessage = 53,

            //Malta License DepositInfo
            DepositInfo = 54

        }

        public enum ClientInfoStates
        {
            Active = 1,
            Expired = 2
        }

        public enum PartnerClientVerificationTypes
        {
            VerifiedInRegistration = 1,
            RequireMailOnly = 2,
            RequireMobileOnly = 3,
            RequireMailAndMobile = 4
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        public enum CoolOfPeriodType
        {
            Hour = 1,
            Day = 2
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        public enum DepositLimitType
        {
            Daily = 1,
            Weekly = 2,
            Monthly = 3
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        public enum RealityCheckPeriodType
        {
            None = 0,
            Minute = 1,
            Hour = 2
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        public enum TimeoutPeriodType
        {
            None = 0,
            Hour = 1,
            Day = 2,
            Month = 3
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        public enum SelfExclusionPeriodType
        {
            None = 0,
            Month = 1,
            Year = 2,
            Forever = 3,
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        public enum PartnerVerificationActionType
        {
            Deposit = 1,
            Withdrawal = 2,
            Bet = 3
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        /// 
        public enum PartnerVerificationOptionType
        {
            Mobile = 1,
            Email = 2,
            Document = 3
        }

        /// <summary>
        /// For Malta license
        /// </summary>
        /// 
        public enum PartnerVerificationOptionGroup
        {
            Group1 = 1,
            Group2 = 2,
            Group3 = 3
        }

        ///// <summary>
        ///// For Malta license
        ///// </summary>
        //public enum ClientVerificationOptions
        //{
        //    Email = 1,
        //    Mobile = 2,
        //    Document = 3
        //}

        ///// <summary>
        ///// For Malta license
        ///// </summary>
        //public enum ClientVerificationTypes
        //{
        //    Bet = 1,
        //    Deposit = 2,
        //    Withdrawal = 3
        //}

        public enum DocumentStates
        {
            New = 1,
            Won = 2,
            Lost = 3,
            Deleted = 4,
            Paid = 5,
            ReturnedToPartner = 6,
            Cashout = 7,
            Cashback = 8,
            ExpressBonus = 9,
            Cancel = 10
        }

        public enum PaymentRequestStates
        {
            Pending = 1,
            CanceledByClient = 2,
            InProcess = 3,
            Frozen = 4,
            WaitingForKYC = 5,
            CanceledByUser = 6,
            Allowed = 7,
            Approved = 8,
            Failed = 9,
            PayPanding = 10,
            Answered = 11,
            CancelApproved = 12,
            CanceledByPayment = 13,
            FirstTimeDeposit = 100,
            FirstTimeWithdraw = 101
        }

        public static List<int> PaymentRequestFinalStates = new List<int>
        {
            (int)PaymentRequestStates.CanceledByClient,
            (int)PaymentRequestStates.CanceledByUser,
            (int)PaymentRequestStates.Approved,
            (int)PaymentRequestStates.Failed
        };

        public enum TransactionTypes
        {
            Debit = 1,
            Credit = 2
        }

        public enum OperationTypes
        {
            PaymentRequestBooking = 1,
            PaymentRequestPay = 2,
            Bet = 3,
            Win = 4,
            TransferFromPaymentSystemToClient = 5,
            ClientTransferToBetShop = 6,
            //WithdrawFromBetShop = 7,
            //DepositToBetShop = 8,
            PayDepositFromBetshop = 9,
            CloseBetShopOperationDay = 10,
            PayBetShopDebt = 11,
            PayPartnerPaymentSettingDebt = 12,
            AddMoneyToPartnerBank = 13,
            PayPartnerProductDebt = 14,
            RollBack = 15,
            Jackpot = 16,
            //JackpotToProduct = 17,
            DebitCorrectionOnCashDesk = 18,
            CreditCorrectionOnCashDesk = 19,
            AddUnpaidWinsToPartnerMainAccount = 20,
            DebitCorrectionOnClient = 21,
            CreditCorrectionOnClient = 22,
            TransferFromBetShopToClient = 23,
            RecalculationCredit = 24,
            RecalculationDebit = 25,
            CashOut = 26,
            CashBackBonus = 27,
            ExpressBonus = 28,
            TransferFromCashDeskToBetShop = 29,
            TransferFromBetShopToCashDesk = 30,
            TransferMoneyFromAgentToAgent = 31,
            TransferFromClientToPaymentSystem = 32,
            DebitBonusCorrectionOnClient = 33,
            CreditBonusCorrectionOnClient = 34,
            Cancel = 35,
            BonusRecalculationCredit = 36, // pox hanel bonus -17
            BonusRecalculationDebit = 37, // -13
            BonusDebit = 38, // 16
            SportWagering = 39, // SportWagering
            SportFreeBet = 40, // SportFreeBet
            SportRealWagering = 41, // SportRealWagering
            FreeSpins = 42, // Free Spins
            UnlimitBet = 43,
            DebitAfilateOnClient = 44,
            FeeForUnusedBalance = 45,
            TournamentWinDaily = 46, // Sport
            TournamentWinMonthly = 47, // Sport
            //wagering Bonuses
            ActivateBonus = 48,//(wagering) Activating wagering bonus and transferring money to the bonus account
            CancelBonus = 49,//(wagering)cancelling bonus and reset account
            RedeemBonus = 50,//(wagering)Transfer money to the real account
            ResetBonusAccount = 51,//(wagering)reset account
            DebtRepayment = 52,// (wagering) debt repayment
            ExpiryBonus = 53,//(wagering)reset account

            ////
            TournamentPrize = 54,//prize after tournament
            Test = 55,
            CommissionPrize = 56,//prize after commission (referral bonus)
            RetentionBonus = 57,//bonus is given from admin
            Bonus = 58//Others bonuses

        }

        public enum ProductLevels
        {
            PlatformLevel = 1,
            BaseProductLevel = 2,
            SubProductLevel = 3
        }

        public enum AccountTypeKinds
        {
            Used = 1,
            UnUsed = 2,
            Booked = 3,
            Dept = 4,
            Bonus = 5,
            NonWagering = 6
        }

        public enum ChangeClientFieldActions
        {
            ChangeState = 1,
            ChangePassword = 3,
            ChangeGender = 4,
            ChangeBirthDate = 5,
            ChangeFirstName = 6,
            ChangeLastName = 7,
            ChangeDocumentNumber = 8,
            ChangeDocumentIssuedBy = 9,
            ChangeAddress = 10,
            ChangeMobileNumber = 11,
            ChangeLanguageId = 12,
            ChangeCategoryId = 13,
            ChangePromoCode = 14,
            ChangeSecurityQuestion = 15,
            ChangeEmail = 16,
            ChangePhoneNumber = 17,
            ChangeIsDocumentVerified = 18,
            ChangeIsEmailVerified = 19,
            ChangeIsMobileNumberVerified = 20,
            ChangeSendMail = 21,
            ChangeSendSms = 22,
            ChangeSendPromotions = 23,
            ChangeCallToPhone = 24,
            ChangeDocumentType = 25,
            ChangeRegionId = 26,
            ChangeZipCode = 27
        }

        public enum AccountType
        {
            ClientUnUsedBalance = 1,
            ClientUsedBalance = 2,
            ClientBooking = 3,
            BetShopDebtToPartner = 4,
            PaymentSystemSettingDebtToPartner = 5,
            PartnerBalance = 6,
            PartnerUnpaidDeposits = 7,
            ExternalClientsAccount = 8,
            PartnerBank = 9,
            PartnerExternalAccount = 10,
            ProductDebtToPartner = 11,
            ClientBonusBalance = 12,
            CashDeskDebtToBetShop = 13,
            ClientNonWageringBalance = 14,
            ClientP2PNonWageringBalance = 15,
        }

        public enum ClientMessageTypes
        {
            FromClient = 1,
            FromUser = 2,
            FeedBack = 3,
            FromSystem = 4
        }

        public enum ClientMessageStates
        {
            New = 1,
            Readed = 2,
            Deleted = 3
        }

        public static List<int> PrivatePaymentWithdrawlDepositConfirm = new List<int> { 1, 2, 3, 4 };

        public static List<int> PrivatePaymentkWithdrawlPartiallyOnline = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        public static List<int> PrivatePaymentWithdrawlOfflinePayments = new List<int> { 17, 18, 19 };

        public enum PaymentSystemsSamanBankWithdrawl
        {
            AstroPay = 1,
            PayKasa = 2,
            OtoPay = 3,
            PayKwik = 4,
            QRCode = 5,
            GarantiCepBank = 6,
            İşBankası = 7,
            ZiraatBankası = 8,
            QNBFinansbank = 9,
            PTTCepBank = 10,
            YapıKredi = 11,
            Akbank = 12,
            Vakıfbank = 13,
            TEBCepBank = 14,
            KuveytTürk = 15,
            INGBank = 16,
            AkbankReferans = 17,
            İşbankCepAnahtar = 18,
            Denizbank = 19,
        }

        public enum PaymentSystems
        {
            BetShop = 1,
            Arca = 5,
            IdramOffline = 6,
            ArcaIMV = 7,
            Tandem = 8,
            Telcell = 9,
            Bta = 10,
            Idram = 11,
            MobiDram = 12,
            InternalBE = 13,
            IdramDirectTransfer = 14,
            Neteller = 15,
            Spay = 16,
            Skrill = 17,
            SafeCharge = 18,
            WebMoney = 19,
            ParsiEx = 20,
            YapiKredi = 21,
            TransferToAccount = 22,
            Akbank = 23,
            GarantiBank = 24,
            AgentBank = 25,
            PerfectMoney = 26,
            Bankasi = 27,
            Convers3DSecure = 28,
            UniBank = 29,
            EasyPay = 30,
            ConverseTransfer = 31,
            PttHavale = 32,
            Alea = 33,
            AccWebMoney = 34,
            ConverceTerminal = 35,
            AccYandex = 36,
            AccMoneta = 37,
            AccQiwi = 38,
            AccMobileCommerce = 39,
            AccAlfaClick = 40,
            AccCompay = 41,
            Cannon = 42,
            ZainCash = 43,
            InterKassa = 44,
            Mpesa = 45,
            Friend2Friend = 46,
            IranianPerfect = 47,
            CannonWebMoney = 48,
            PerfectMoneyDirect = 49,
            Run88 = 50,
            GusarVisa = 51,
            GusarMaster = 52,
            IrbetBankIransfer = 53,
            Qiwi = 54,
            MolekulebetBankTransfer = 55,
            AccBankCards = 56,
            QiwiTerminal = 57,
            WooPayTerminal = 58,
            Kassa24Terminal = 59,
            Paybox = 60,
            WinPay = 61,
            Wooppay = 62,
            Bet999cash = 63,
            ExchangerP = 64,
            ExchangerIpg = 65,
            FinansBank = 66,
            Cepbank = 67,
            Vakifbank = 68,
            Ziraat = 69,
            MolekulaWebMoney = 70,
            TradeLance = 71,
            BankasiBetoji = 72,
            BanktransferBetoji = 73,
            PTTBankTransferBetoji = 74,
            GarantiCepbankBetoji = 75,
            GarantiOneCepbankBetoji = 76,
            GarantiOneCepbankPortbet = 77,
            Vuzu = 78,
            ConverseBankTransfer = 79,
            TelCellTransfer = 80,
            FastPay = 81,
            Woocommerce = 82,
            Promsvyazbank = 83,
            Asiahawala = 84,
            ZainPayoffline = 85,
            FastPayoffline = 86,
            DenizBank = 87,
            Privebet = 88,
            INGCepBank = 89,
            KuveytTurkCepBank = 90,
            PTTCepBank = 91,
            UZKard = 92,
            KorekCardAsiaCell = 93,
            ApcoPay = 94,
            Ecopayz = 95,
            Exchanger2 = 96,
            YapiKrediCebeHavale = 97,
            SamanBankWithdrawl = 98,
            NonSamanBank = 99,
            NovaBanka = 100,
            Halkbank = 101,
            Help2Pay = 102,
            PrivatePayment = 103,
            ParsianExchanger = 104,
            QR = 105,
            Para247 = 106,
            Vistapara = 107,
            Ripple = 108,
            Bitcoin = 109,
            Ethereum = 110,
            Entropay = 111,
            HiPay = 112,
            Accentpay = 113,
            Lateral = 114,
            Evolution = 115,
            CardToCard = 116,
            CashTransfer = 117,
            AsiahawalaOnline = 118,
            PayMega = 119,
            DavidQR = 120,
            Voucher = 121,
            CardTransferAm = 122,
            EasyPayTerminal = 123,
            EasyPayWallet = 124,
            LateralAlternative = 125,
            Alfacashier = 126,
            Papara = 127,
            MldPaykasa = 128,
            MldJetonWallet = 129,
            MldJetonVoucher = 130,
            MldQrRef = 131,
            MldPayznet = 132,
            Cash24 = 133,
            GiftShopVoucher = 134,
            AlliedWalletQuickPay = 135,
            LatBoleto = 136,
            LatBradesco = 137,
            LatItau = 138,
            LatBancodoBrasil = 139,
            EcompayBankCards = 140,
            AccJetonWallet = 141,
            AccJetonVoucher = 142,
            JetonWallet = 143,
            JetonVoucher = 144,
            Paygiga = 145,
            Envopay = 146,
            Paykasa = 147,
            PaySafeCard = 148,
            CardPay = 149,
            MldInstantBanking = 150,
            MldCommunityBanking = 151,
            Card2CardExchanger = 152,
            WebMoneyOffline = 153,
            RocketPay = 154,
            IdramTerminal = 155,
            AirtelMoney = 156,
            DayBankExternal = 157,
            DayBankInternal = 158,
            CepBankOffline = 159,
            AstroPay = 160,
            AnindaHavale = 161,
            AirtelMtn = 162,
            HizliQr = 163,
            PayToPays = 164,
            Paystack = 165,
            Rave = 166,
            GTPay = 167,
            KreditKart = 168,
            CoinPayment = 169,
            InterswitchWebPay = 170,
            RunPay = 171,
            CreditCard = 172,
            AnindaPapara = 173,
            Epro = 174,
            Zotapay = 175,
            HizliQrOffline = 176,
            ExpressQR = 177,
            RunPayOnline = 178,
            BestPayCardJeton = 179
        }

        public enum LimitTypes
        {
            FixedClientMaxLimit = 1,
            PercentClientMaxLimit = 2,
            FixedProductLimit = 3,
            PercentProductLimit = 4,
            FixedBetShopGroupLimit = 5,
            PercentBetShopGroupLimit = 6,
            FixedBetShopLimit = 7,
            PercentBetShopLimit = 8
        }
        public enum GameProvidertypes
        {
            Integrated = 1,
            Nonintegrated = 2,
            Unknown = 3,
        }
        public class GameProviders
        {
            public const int IqSoft = 1;
            public const int Evolution = 2;
            public const int Digitain_Sport = 3;
            public const int MicroGaming = 4;
            public const int BetSoft = 5;
            public const int TwoWinPower = 6;
            public const int Igromat = 7;
            public const int MyLucky6 = 8;
            public const int Digitain_P2P = 9;
            public const int Digitain_Belote = 10;
            public const int BetTvGames = 11;
            public const int Omegassw = 12;
            public const int SoftSwiss = 13;
            public const int BingoBoom = 14;
            public const int GoldenRace = 15;
            public const int Fugaso = 16;
            public const int FugasoAmatic = 17;
            public const int FugasoNetent = 18;
            public const int Habanero = 19;
            public const int EGT = 20;
            public const int Booongo = 21;
            public const int Panorama1x2 = 22;
            public const int Genii = 23;
            public const int FLG = 24;
            public const int Betongames = 25;
            public const int Belatra = 26;
            public const int AsiaGaming = 27;
            public const int InBet = 28;
            public const int LuckyStreak = 29;
            public const int EventBet = 30;
            public const int Spinomenal = 31;
            public const int Konect = 32;
            public const int EvoPlay = 33;
            public const int Playson = 34;
            public const int Omi = 35;
            public const int RedRake = 36;
            public const int Kiron = 37;
            public const int TomHorn = 38;
            public const int BoomingGames = 39;
            public const int P2PNetwork = 40;
            public const int XoGame = 41;
            public const int RGSTest = 42;
            public const int P2PMultiNetwork = 43;
            public const int XPG = 44;
            public const int Novomatic = 45;
            public const int Igrosoft = 46;
            public const int SuperLotto = 47;
            public const int TVBet = 48;
        }

        public enum SMSProviders : int
        {
            AfricasTalking = 1,
            Gateway = 2,
            Twilio = 3,
            Blackbox = 4,
            Soap = 5,
            Toto = 6,
            Infobip = 7
        }

        public class SMSProvidersCommands
        {
            public const string Join = "join";
            public const string Accept = "accept";
        }

        public class PartnerKeys
        {
            //public static string EvolutionAuthToken = "EvolutionAuthToken";
            //public static string TotoBlotSecretKey = "TotoBlotSecretKey";
            public static string PartnerWebSiteWebApiSecretKey = "PartnerWebSiteWebApiSecretKey";
            //public static string PartnerMicroGamingLogin = "PartnerMicroGamingLogin";
            //public static string PartnerMicroGamingPassword = "PartnerMicroGamingPassword";
            //public static string BetSoftPassKey = "BetSoftPassKey";
            //public static string TwoWinPowerSalt = "TwoWinPowerSalt";
            //public static string TotoBackgammonSecretKey = "TotoBackgammonSecretKey";
            //public static string DigitainSportsBookSecretKey = "DigitainSportsBookSecretKey";
            public static string MyLuckySecretKey = "MyLuckySecretKey";
            //public static string P2PGamingSecretKey = "P2pGamingSecretKey";
            //public static string BankId = "BankId";
            //public static string BetTvGames = "BetgamesSecretKey";
            public static string PartnerNetentLogin = "PartnerNetentLogin";
            public static string PartnerNetentPassword = "PartnerNetentPassword";
            //public static string SoftSwiss = "SoftSwissSecretKey";
            //public static string GoldenRace = "GoldenRaceSecretKey";
        }

        public class PartnerCfgs
        {
            public IDictionary<int, PartnerCfg> Keys = new Dictionary<int, PartnerCfg>();

            public PartnerCfgs()
            {
                Keys[8] = new PartnerCfg() { SecretKey = "MyLuckySecretKey" };
                Keys[12] = new PartnerCfg() { Login = "PartnerNetentLogin", Password = "PartnerNetentPassword" };
            }
        }

        //private static Hashtable userTokens = null;
        //public static Hashtable UserTokens
        //{
        //	get
        //	{
        //		return userTokens;
        //	}

        //	set
        //	{
        //		userTokens = value;
        //	}
        //}


        public class InternalOperationType
        {
            public static string Request = "Request";
            public static string Response = "Response";
        }

        public class InternalOperationSource
        {
            public static int FromGameProvider = 1;
            public static int FromPaymentSystem = 2;
            public static int FromBetShopGateway = 3;
            public static int FromAdminWebApi = 4;
            public static int FromWebSiteWebApi = 5;
            public static int FromAgentWebApi = 6;
            public static int FromSmsProvider = 7;
            public static int FromPaymentGateway = 8;
        }

        public class PartnerProductSettingStates
        {
            public static int Active = 1;
            public static int BlockedForWithdraw = 2;
            public static int BlockedForDeposit = 3;
            public static int Blocked = 4;
        }

        public class PartnerStates
        {
            public int Active = 1;
            public int Blocked = 2;
        }

        public class PartnerPaymentSystemStates
        {
            public static int Active = 1;
            public static int Blocked = 2;
        }

        public class CashDeskStates
        {
            public static int Active = 1;
            public static int BlockedForWithdraw = 2;
            public static int BlockedForDeposit = 3;
            public static int Blocked = 4;
        }

        public class BetShopStates
        {
            public static int Active = 1;
            public static int ManuallyBlocked = 2;
            public static int AutomaticallyBlocked = 3;
        }

        public class BetShopTypes
        {
            public static int Regular = 1;
            public static int WithDeposit = 2;
            public static int WithWithdraw = 3;
            public static int WithDepositAndWithdraw = 4;
        }

        public class BetShopGroupStates
        {
            public static int Active = 1;
            public static int ManuallyBlocked = 2;
            public static int AutomaticallyBlocked = 2;
        }

        public class GameProviderType
        {
            public static int CreditAndDebitNotConnected = 1;
            public static int CreditAndDebitConnected = 2;
            public static int Mixed = 3;
        }

        //public class PaymentSystemDepositStates
        //{
        //    public static int Made = 1;
        //    public static int InProcess = 2;
        //    public static int Payed = 3;
        //    public static int Cancelled = 4;
        //}

        public class HttpRequestMethods
        {
            public static string Post = "POST";
            public static string Get = "GET";
            public static string Delete = "DELETE";
            public static string Put = "PUT";
            public static string Patch = "PATCH";
        }

        public class HttpContentTypes
        {
            public static string ApplicationJson = "application/json";
            public static string ApplicationXml = "application/xml";
            public static string ApplicationUrlEncoded = "application/x-www-form-urlencoded";
            public static string TextXml = "text/xml";
            public static string TextJson = "text/json";
        }

        public enum ClientCategories
        {
            New = 1,
            Vip = 2,
            Madrid11 = 3,
            Madrid12 = 4,
            Barcelona11 = 5,
            Barcelona22 = 6,
            Casablanca1 = 7,
            Porto11 = 8,
            Porto12 = 9,
            NewCustomer = 10,
            Slemani_Delivery01 = 11,
            Slemani_Delivery02 = 12,
            Slemani_Palace01 = 13,
            Slemani_Palace02 = 14,
            Slemani_Palace03 = 15,
            Slemani_Agent01 = 16,
            Slemani_Agent02 = 17,
            Slemani_Agent03 = 18,
            Fake_Players = 19,
            Hewler_Delivery01 = 23,
            Hewler_Delivery02 = 24,
            Hewler_Chirok01 = 25,
            Hewler_Chirok02 = 26,
            Hewler_Tairawa01 = 27,
            Hewler_Tairawa02 = 28,
            Hewler_Clasico01 = 29,
            Hewler_Clasico02 = 30,
            Nonir = 65,
            Complainer = 66,
            Limited_Customers = 67,
            Ex_Vips = 68
        }

        public enum Tags
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            Tag1 = 5,
            Tag2 = 6,
            Tag3 = 7,
            Tag4 = 8,
            Tag5 = 9,
            Tag6 = 10,
            Tag7 = 11,
            Tag8 = 12,
            Tag9 = 13,
            Tag10 = 14,
            Live_Mistakes = 15,
            SignUp_Country = 16
        }

        public enum UserTypes
        {
            AdminUser = 1,
            Cashier = 2,
            System = 3
        }

        public class CacheItems
        {
            public const string PartnerPlayersInfoDashboard = "PartnerPlayersInfoDashboard";
            public const string Partners = "Partners";
            public const string PartnerSetting = "PartnerSetting";
            public const string PartnerSmsSetting = "PartnerSmsSetting";
            public const string PartnerGameProviderSettings = "PartnerGameProviderSettings";
            public const string EgtJackpot = "EgtJackpot_{0}";
            public const string Products = "Products";
            public const string AgregatorProducts = "AgreegatorProducts";
            public const string ProductCategory = "ProductCategory";
            public const string ProductLimits = "ProductLimits";
            public const string BetshopGroups = "BetshopGroups";
            public const string PartnerProductSettings = "PartnerProductSettings";
            public const string fnPartnerProductSettings = "fnPartnerProductSettings";
            public const string Permissions = "Permissions";
            public const string UserPermissions = "UserPermissions";
            public const string AccessObjects = "AccessObjects";
            public const string GameProviders = "GameProviders";
            public const string ObjectTypes = "ObjectTypes";
            public const string PartnerSettings = "PartnerSettings";
            public const string CashDesks = "CashDesks";
            public const string Enumerations = "Enumerations";
            public const string EnumerationsDictionary = "EnumerationsDictionary";
            public const string Currencies = "Currencies";
            public const string CurrenciesRate = "CurrenciesRate";
            public const string Regions = "Regions";
            public const string OnlineClients = "OnlineClients";
            public const string fnProducts = "fnProducts";
            public const string fnRegions = "fnRegions";
            public const string fnPartnerRegions = "fnPartnerRegions";
            public const string RealTimeInfo = "RealTimeInfo";
            public const string ClientUnreadMessagesCount = "ClientUnreadMessagesCount";
            public const string UsersUnreadMessagesCount = "UsersUnreadMessagesCount";
            public const string Categories = "Categories";
            public const string AccountTypes = "AccountTypes";
            public const string DateDiff = "DateDiff";
            public const string fnErrorTypes = "fnErrorTypes";
            public const string ClientClasifications = "ClientClasifications";
            public const string ClientCounts = "ClientCounts";
            public const string ClientSessions = "ClientSessions";
            public const string ProductSessions = "ProductSessions";
            public const string PlatformActiveSessions = "PlatformActiveSessions";
            public const string ProductActiveSessions = "ProductActiveSessions";
            public const string ClientCategories = "ClientCategories";
            public const string Languages = "Languages";
            public const string ObjectCurrencyPriorities = "ObjectCurrencyPriorities";
            public const string Clients = "Clients";
            public const string AccountBalances = "AccountBalances";
            public const string AccountTypePriorities = "AccountTypePriorities";
            public const string Accounts = "Accounts";
            public const string PartnerKey = "PartnerKey";
            public const string PendingDepositCount = "PendingDepositCount";
            public const string PendingWithdrawalCount = "PendingWithdrawalCount";
            public const string ClientNotificationSettings = "ClientNotificationSettings";
            public const string PartnerNotificationSettings = "PartnerNotificationSettings";
            public const string PartnerMessageInfoes = "PartnerMessageInfoes";
            public const string PartnerPaymentSettings = "PartnerPaymentSettings";
            public const string IntegratedServiceSettings = "IntegratedServiceSettings";
            public const string IntegratedServiceOptions = "IntegratedServicesOptions";
            public const string FriendToFriendTransferCount = "FriendToFriendTransferCount";
            public const string PlayerPaymentSetting = "PlayerPaymentSetting";
            public const string PartnerCurrencies = "PartnerCurrencies";
            public const string PartnerApis = "PartnerApis";

            //
            public const string AllowedClientApps = "AllowedClientApps";
            public const string ProjectSettings = "ProjectSettings";
            public const string ProjectDomains = "ProjectDomains";
            public static string UIProjectSmtpSettings = "UIProjectSmtpSettings";
            public static string UIProjectSmsSetting = "UIProjectSmsSetting";

            // dinamic payments
            public static string PartnerPaymentsWithControls = "PartnerPaymentsWithControls";

            //responsibl
            public static string ClientDepositLimit = "ClientDepositLimit";
            public static string RealityCheck = "RealityCheck";

            //Users and Clients activities (Autologout)
            public static string UserActivities = "UserActivities";
            public static string ClientActivities = "ClientActivities";

            //Translations
            public static string Translations = "Translations";

            // SelfExclusion
            public static string ClientSelfExclusionSetting = "ClientSelfExclusionSetting";

            // Partner verification
            public static string PartnerVerificationSettings = "PartnerVerificationSettings";
            public static string PartnerVerificationActions = "PartnerVerificationActions";
        }

        public enum PartnerPaymentSettingStates
        {
            Active = 1,
            Inactive = 2
        }

        public enum PlayerPaymentSettingState
        {
            Active = 1,
            Inactive = 2
        }

        public enum PaymentRequestTypes
        {
            Withdraw = 1,
            Deposit = 2
        }

        public enum RegionTypes
        {
            Street = 1,
            Distinct = 2,
            City = 3,
            Region = 4,
            Country = 5,
            Continent = 6,
            Mainland = 7
        }

        public class Currencies
        {
            public static string ArmenianDram = "AMD";
            public static string AustralianDollar = "AUD";
            public static string CanadianDollar = "CAD";
            public static string SwissFranc = "CHF";
            public static string DanishKrone = "DKK";
            public static string BritishPound = "GBP";
            public static string HongKongDollar = "HKD";
            public static string IranianRial = "IRR";
            public static string JapaneseYen = "JPY";
            public static string SouthKorean = "KRW";
            public static string NorwayKrone = "NOK";
            public static string SwedishKrona = "SEK";
            public static string SingaporeDollar = "SGD";
            public static string UsaDollar = "USD";
            public static string Euro = "EUR";
            public static string KazakhstaniTenge = "KZT";
            public static string IranianTuman = "IRT";
            public static string ChineseYuan = "CNY";
            public static string IraqyanDinar = "IQD";
            public static string IsraeliNewShekel = "ILS";
            public static string KenyanShilling = "KES";
            public static string MalaysianRinggit = "MYR";
            public static string MoroccoDirham = "MAD";
            public static string NigerianNaira = "NGN";
            public static string RussianRuble = "RUB";
            public static string TurkishLira = "TRY";
            public static string BelarusianRuble = "BYR";
            public static string BosnyanMark = "BAM";
            public static string UkrainianHryvnia = "UAH";
            public static string ThaiBaht = "THB";
            public static string AzerbaijaniManat = "AZN";
            public static string BrazilianRial = "BRL";
            public static string IndianRuppi = "INR";
            public static string PakistaniRuppe = "PKR";
            public static string TurkmenstanManat = "TMT";
            public static string TunisianDinar = "TND";
            public static string UgandanShilling = "UGX";
            public static string UzbekstanSom = "UZS";
            public static string SouthAfricanRand = "ZAR";
            public static string MexicanPeso = "MXN";
            public static string DominicanPeso = "DOP";
        }

        public class Jobs
        {
            public const int CloseAccountPeriod = 1;
            public const int AddMoneyToPartnerAccount = 2;
            public const int SendUnsendedPaymentRequests = 3;
            public const int CheckNotPayedPaymentRequestStatesInPaymentSystem = 4;
            public const int ExpireUserSessions = 5;
            public const int ResetBetShopLimits = 6;
            public const int ResetBetShopDailyTicketNumber = 7;
            public const int SetInvalidUnpaidBets = 8;
            public const int ExpireClientSessions = 9;
            public const int ExpireClientVerificationKeys = 10;
            public const int GiveCashBackBonuses = 11;
            public const int CloseClientPeriod = 12;
            public const int GiveAgentReports = 13;
            public const int CloseTournamentClosePeriod = 14;
            public const int SendTournamentPrizes = 15;
            public const int GiveAffilatePlayers = 16;
            public const int GiveAffilateReports = 17;
            public const int CancelPaymentTransfer = 18;
            public const int CloseCommissionPeriod = 19;
            public const int SendCommisisonsToReferral = 20;
            public const int CloseFriendToFriendTransactions = 21;
            public const int CloseMaxBetWinPeriod = 22;
            public const int ChangeReferralPlayersState = 23;
            public const int UpdateClientsBonusStatuses = 24;
            public const int PlayerBalanceClosePeriod = 25;
            public const int TotoPlayer21 = 26;
            public const int CloseLostDepositPeriod = 27;
            public const int HubspotClientInfoSend = 28;
            public const int ChangeTagAtoB = 29;
            public const int ApproveCardToCardTransfer = 30;
            public const int GetEgtJackpot = 31;
            public const int Hubspot1000BetSendInfo = 32;
            public const int HubspotNot48HourBetSendInfo = 33;
            public const int ChangeUserState = 34;
            public const int ScheduleAffilateSync = 35;
            public const int ScheduleGameProviderSync = 36;
            public const int PendingMessagesSenderJob = 37;
            public const int RemoveExpiredRefreshTokens = 38;
            public const int RecalculateLostGGR = 39;
            public const int GiveIAAffilatePlayers = 40;
            public const int GiveIAAffilateReports = 41;
            public const int FreeSpinDetailsUpdat = 42;
            public const int RemoveRollbackedTransactions = 43;
            public const int ChangePaymentRequestPendingStatus = 44;
            public const int GiveClientsBalance = 45;
            public const int ChangePaymentRequestPendingStatusJastinportal = 46;
            public const int ExportReport = 47;
        }

        public enum JobStates
        {
            Active = 1,
            Inactive = 2
        }

        public enum PartnerCurrencyStates
        {
            Active = 1,
            Inactive = 2
        }

        public enum ProductStates
        {
            Active = 1,
            Inactive = 2
        }

        public enum PartnerGameProviderSettingsState
        {
            Active = 1,
            Inactive = 2
        }

        public enum PaymentSystemTypes
        {
            AllowDepositAndWithdraw = 1,
            AllowOnlyDeposit = 2,
            AllowOnlyWithdraw = 3
        }

        public enum PaymentTypes
        {
            Online = 1,
            Offline = 2,
            Betshop = 3,
            WithdrawlStatus = 4
        }



        public enum NoteStates
        {
            Active = 1,
            Deleted = 2
        }

        public enum ClientInformedFromEnum
        {
            Friend = 1,
            GamblingForum = 2,
            Magazine = 3,
            Newsletter = 4,
            Other = 5,
            OutdoorAdvertisement = 6,
            RadioAdvertisement = 7,
            SocialNetwork = 8,
            TvAdvertisement = 9,
            WebsiteAdvertisement = 10
        }

        public class EnumerationTypes
        {
            public static string ObjectTypes = "ObjectTypes";
            public static string SessionStates = "SessionStates";
            public static string Gender = "Gender";
            public static string ClientStates = "ClientStates";
            public static string UserStates = "UserStates";
            public static string ClientInfoTypes = "ClientInfoTypes";
            public static string ClientInfoStates = "ClientInfoStates";
            public static string PartnerClientVerificationTypes = "PartnerClientVerificationTypes";
            public static string DocumentStates = "DocumentStates";
            public static string TransactionTypes = "TransactionTypes";
            public static string PaymentRequestStates = "PaymentRequestStates";
            public static string OperationTypes = "OperationTypes";
            public static string AccountTypeKinds = "AccountTypeKinds";
            public static string ChangeClientFieldActions = "ChangeClientFieldActions";
            public static string AccountType = "AccountType";
            public static string ClientMessageTypes = "ClientMessageTypes";
            public static string PaymentSystems = "PaymentSystems";
            public static string LimitTypes = "LimitTypes";
            public static string GameProviders = "GameProviders";
            public static string InternalOperationSource = "InternalOperationSource";
            public static string PartnerProductSettingStates = "PartnerProductSettingStates";
            public static string CashDeskStates = "CashDeskStates";
            public static string BetShopStates = "BetShopStates";
            public static string PartnerStates = "PartnerStates";
            public static string BetShopTypes = "BetShopTypes";
            public static string BetShopGroupStates = "BetShopGroupStates";
            public static string GameProviderType = "GameProviderType";
            public static string PaymentSystemDepositStates = "PaymentSystemDepositStates";
            public static string PaymentRequestSendedStates = "PaymentRequestSendedStates";
            public static string UserTypes = "UserTypes";
            public static string PartnerPaymentSettingStates = "PartnerPaymentSettingStates";
            public static string Jobs = "Jobs";
            public static string JobStates = "JobStates";
            public static string PaymentSystemTypes = "PaymentSystemTypes";
            public static string RegionTypes = "RegionTypes";
            public static string NoteStates = "NoteStates";
            public static string FilterOperations = "FilterOperations";
            public static string ProductStates = "ProductStates";
            public static string DeviceTypes = "DeviceTypes";
            public static string ClientDocumentTypes = "ClientDocumentTypes";
            public static string KYCDocumentTypes = "KYCDocumentTypes";
            public static string KYCDocumentStates = "KYCDocumentStates";
            public static string ClientLogActions = "ClientLogActions";
            public static string CreditDocumentTypes = "CreditDocumentTypes";
            public static string BonusTypes = "BonusTypes";
            public static string BonusStatus = "BonusStatus";
            public static string BonusWalletType = "BonusWalletType";
            public static string ExpressOddType = "ExpressOddType";
            public static string CategoryTypes = "CategoryTypes";
            public static string TournamentTypes = "TournamentTypes";
            public static string TournamentPrizeTypes = "TournamentPrizeTypes";
            public static string TournamentStates = "TournamentStates";
            public static string ProductTypes = "ProductTypesTypes";
            public static string BrandedTypes = "BrandedTypes";
            public static string SocialNetwork = "SocialNetwork";
            public static string CommissionCalculationPeriod = "CommissionCalculationPeriod";
            public static string CommissionType = "CommissionType";
            public static string CommissionSegmentType = "CommissionSegmentType";
            public static string NotificationSettingTypes = "NotificationSettingTypes";
            public static string NotificationSettingGroups = "NotificationSettingGroups";
            public static string SMSProviders = "SMSProviders";
            public static string ConditionType = "ConditionType";
            public static string BonusCreationType = "BonusCreationType";
            public static string LostDepositStatus = "LostDepositStatus";
            public static string SportBetTypes = "SportBetTypes";
            public static string MobileOSType = "MobileOSType";
            public static string GameBadgeType = "GameBadgeType";
            public static string ViewCategoryBadgeType = "ViewCategoryBadgeType";
            public static string ViewCategoryeType = "ViewCategoryeType";
            public static string CreditDocumentTypesP2PNetwork = "CreditDocumentTypesP2PNetwork";
            public static string OddDisplay = "OddDisplay";
            public static string UIProjectMarketType = "UIProjectMarketType";
            public static string PartnerPeriodTypes = "PartnerPeriodTypes";
            public static string ReportParamType = "ReportParamType";
            public static string ReportTaskStatus = "ReportTaskStatus";
        }

        public class RequestMethods
        {
            public const string GetOnlineClients = "GetOnlineClients";
            public const string GetDeposits = "GetDeposits";
            public const string GetWithdrawals = "GetWithdrawals";
            public const string GetBetsInfo = "GetBetsInfo";
            public const string GetPlayersInfo = "GetPlayersInfo";
            public const string GetProviderBets = "GetProviderBets";
            public const string GetClientsInfoList = "GetClientsInfoList";
            public const string ExportClientsInfoList = "ExportClientsInfoList";
        }

        public class PublishKeys
        {
            public const string ClientMessage = "ClientMessage";
        }

        public class FilterOperations
        {
            public const int IsEqualTo = 1;
            public const int IsGreaterThenOrEqualTo = 2;
            public const int IsGreaterThen = 3;
            public const int IsLessThenOrEqualTo = 4;
            public const int IsLessThen = 5;
            public const int IsNotEqualTo = 6;
            public const int Contains = 7;
            public const int StartsWith = 8;
            public const int EndsWith = 9;
            public const int DoesNotContain = 10;
        }

        public enum DeviceTypes
        {
            All = 0,
            Desktop = 1,
            Mobile = 2,
            Wap = 3,
        }

        public enum CreditDocumentTypes
        {
            Single = 1,
            Multiple = 2,
            System = 3,
            Bonus = 4,
        }

        public enum CreditDocumentTypesP2PNetwork
        {
            Bet = 1,
            CancelBet = 2,
            LoseBet = 3,
            WinGame = 4,
            Fee = 5,
            CancelFee = 6,
            LoseFee = 7,
            Rebuy = 8,
            CancelRebuy = 9,
            LoseRebuy = 10,
            WinTournament = 11,
            BetBonus = 12,
            CancelBonus = 13,
            WinBonus = 14,
            BetGameDataChange = 15,
            CancelGameDataChange = 16,
            WinGameDataChange = 17,
            BetTakeRisk = 18,
            CancelTakeRisk = 19,
            WinTakeRisk = 20,
            BetJackpot = 21,
            CancelJackpot = 22,
            WinJackpot = 23
        }

        public enum NoteTypes
        {
            Standard = 1,
            Attention = 2
        }

        public enum NotificationSettingTypes
        {
            Deposits = 1,
            Withdrawals = 2,
            BonusesPromotions = 3,
            Information = 4,
        }

        public enum PartnerPeriodTypes
        {
            Daily = 0,
            Weekly = 1,
            Monthly = 2,
        }

        public enum NotificationSettingGroups
        {
            Email = 1,
            SMS = 2,
        }

        public enum ClientDocumentTypes
        {
            Passport = 1,
            DriverLicense = 2,
            IDCard = 3
        }

        public enum KYCDocumentTypes
        {
            Passport = 1,
            DriverLicense = 2,
            IDCard = 3,
            BankStatement = 4,
            UtilityBill = 5,
            Other = 6
        }

        public enum KYCDocumentStates
        {
            Approved = 1,
            Rejected = 2,
            InProcess = 3
        }

        public enum ClientLogActions
        {
            ChangePasswordByUser = 1,
            ChangePasswordByClient = 2,
            ChangeWebSitePage = 3
        }

        public enum AgentTypes
        {
            TopAgent = 1,
            Agent = 2,
            Player = 3
        }

        public enum BonusTypes
        {
            Bonus = 1,
            FreeSpin = 2,
            SportWagering = 3,
            SportFreeBet = 4,
            SportRealWagering = 5,
            MobileVerified = 6,
            DynamicRealWager = 7,
            ProgressiveRealWager = 8,
            FutureRealWager = 9,
            Wager = 10,
            FreeBet = 11,
            RealWager = 12,
            RealMoney = 13,
        }

        public enum BonusConfirmationType
        {
            Manual = 1,
            Automatic = 2,
        }

        public enum WithdrawalEligibility
        {
            None = 1,
            Automatic = 2
        }
        public enum BonusScope
        {
            All = 0,
            Sport = 1,
            Wager = 2
        }

        public enum BonusTransferType
        {
            Percent = 1,
            Amount = 2
        }

        public enum BonusStatus
        {
            New = 1,
            Active = 2,
            Finished = 3,
            Cancelled = 4,
            Expired = 5,
            InActive = 6
        }
        // to do
        public enum ClientBonusStatus
        {
            New = 1,
            Active = 2,
            Finished = 3,
            Cancelled = 4,
            Expired = 5
        }

        public enum BonusWalletType
        {
            Real = 1,
            Bonus = 2
        }

        public enum ConditionType
        {
            VerifyMobileEmailDocument = 1,
            RegistrationDate = 2,
            DepositDate = 3,
            //DepositFixedAmount = 4,
            //MinDepositAmount = 5,
            //DepositAmountPercent = 6,
            EveryDeposit = 4,
            FirstDeposit = 5,
            DailyFirstdeposit = 6
        }

        public enum BonusCreationType
        {
            Manual = 1,
            Dynamic = 2
        }

        public enum LostDepositStatus
        {
            Pending = 1,
            Approved = 2,
            Canceled = 3
        }

        public enum ExpressOddType
        {
            Total = 1,
            Min = 2
        }

        public enum CategoryTypes
        {
            P2P = 1,
            Slots = 2,
            LiveDiller = 3,
            Sport = 4,
            Other = 1000,
        }

        public class IgromatApiCallStatus
        {
            public const string Success = "ok";
            public const string Error = "error";
        }

        public enum ClientFreeSpinStatus
        {
            Active = 1,
            InActive = 2
        }

        public class BetSoftApiCallResult
        {
            public const string Success = "OK";
            public const string Error = "ERROR";
        }

        public enum TournamentPrizeTypes
        {
            Money = 1,
            FreeSpins = 2,
            Notification = 3
        }

        public enum TournamentPrizeSendStatus
        {
            NoSend = 1,
            Error = 2,
            Success = 3
        }

        public enum TournamentTypes
        {
            Deposit = 1,
            Withdrawal = 2,
            Win = 3,
            GGR = 4,
            Bet = 5
        }

        public enum TournamentStates
        {
            New = 1,
            Started = 2,
            End = 3,
            Finished = 4,
            Canceled = 5,

        }

        public enum SegmentStates
        {
            New = 0,
            Used = 1
        }

        public enum BankCardTypes
        {
            Arca = 1,
            Idram = 2,
            Lateral = 3,
            EasyPayWalet = 4,
            EcompayBankCards = 5,
            CardPay = 6,
        }

        public enum SocialNetwork
        {
            WebSite = 0,
            Facebook = 1,
            Twitter = 2,
            LinkedIn = 3,
            Google = 4,
            VKontakte = 5,
            Ok = 6,
            FromExel = 7
        }

        public enum BrandedType
        {
            Branded = 1,
            NonBranded = 2
        }

        public enum CommissionConfirmationType
        {
            Manual = 1,
            Automatically = 2
        }

        public enum CommissionObjectType
        {
            ReferFriend = 93,
            Affiliate = 94,
            InviteFriend = 95
        }

        public enum CommissionCalculationPeriod
        {
            Daily = 1,
            Weekly = 2,
            Monthly = 3
        }

        public enum CommissionType
        {
            Deposit = 1,
            Withdrawal = 2,
            Win = 3,
            Ggr = 4,
            Bet = 5
        }

        public enum CommissionPayedType
        {
            Payed = 1,
            UnPayed = 2
        }

        public enum CommissionSegmentType
        {
            Main = 1,
            Standard = 2
        }


        public enum UserNotificationTriggers : int
        {
            Email_Deposit = 1, //bit at place 0 is 1

            Email_Withdrawal = 2, //bit at place 1 is 1

            Email_Bonus = 4, //bit at place 2 is 1

            SMS_Deposit = 8, //bit at place 3 is 1

            SMS_Withdrawal = 16, //bit at place 4 is 1

            SMS_Bonus = 32, //bit at place 5 is 1

            Email_Newsletter = 64, //bit at place 6 is 1

            SMS_Newsletter = 128, //bit at place 7 is 1

            Outgoing_Calls = 256 //bit at place 8 is 1
        }

        public enum PlayerReferralState
        {
            Inactive = 0,
            Active = 1
        }

        public enum UIControlState
        {
            Active = 1,
            Inactive = 2,
        }

        public enum UIControlLablePosition
        {
            Top = 1,
            Right = 2,
            Bottom = 3,
            left = 4,
        }

        public enum UIControlEditType
        {
            NotAllowed = 1,
            Once = 2,
            Always = 3,
        }

        public enum BankState
        {
            Inactive, Active
        }

        public enum VoucherStatus
        {
            New = 1,
            Used = 2
        }

        public enum BetTypes
        {
            Single = 1,
            System = 2,
            Express = 3
        }

        public enum OrderBetTypes
        {
            None = 0,
            Prematch = 1,
            Live = 2,
            Multi = 3
        }

        public enum SportBetTypes
        {
            None = 0,
            Prematch = 1,
            Live = 2,
            System = 3,
            Multi = 4,
            Kombi = 5
        }
        public enum PaymentControlType
        {

            Icon = 1,
            Label = 2,
            TextBox = 3,
            Radio = 4,
            Checkbox = 5,
            Select = 6,
            Row = 7,
            Calendar = 8,
            Container = 9,
            TimePicker = 10,
            AmountPicker = 11,
            Button = 12,
            Status = 13,
            Hidden = 14,
            QRCode = 15,
            Chat = 16
        }

        public enum DepositRequestType
        {
            WithTransactionId = 1, // create deposit request, then submit with transaction Id
            WithoutTransaction = 2, // just submit
            OnlyTransaction = 3, // create deposit request with serialized info
            WithCurrency = 4, // create deposit request, then submit with ConvertedCurrencyId
            WithTransactionDescription = 5, // create deposit request with serialized info, then submit
        }

        public enum ClientCategoryTypes
        {
            Client = 1, // Client category
            Payment = 2 // Payment category
        }

        public enum ClientCategoryStates
        {
            Active = 1,
            Inactive = 2
        }

        // PendingMessages table Status column values.
        public enum PendingMessageStatus
        {
            Pending,
            Sent,
            Failed
        }

        // For Mobile Gammes
        public enum MobileOSType
        {
            All = 0,
            Windows = 1,
            Iphone = 2,
            Android = 3
        }

        // For Gamme Badges
        public enum GameBadgeType
        {
            None = 0,
            Top = 1,
            Hot = 2,
            JackPot = 3,
            New = 4
        }

        // For Web Category Badges
        public enum ViewCategoryBadgeType
        {
            None = 0,
            Hot = 1,
            New = 2,
        }

        // For Web Category Type
        public enum ViewCategoryeType
        {
            None = 0,
            Link = 1,
        }

        // ViewCategorySection Type
        public enum ViewCategorySectionType
        {
            Casino = 1,
            LiveCasino = 2,
            CasinoMobile = 3
        }

        public enum GGRCalculationState
        {
            NoCalculated = 1,
            Calculated = 2
        }
    }
}
