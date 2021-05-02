namespace Nasdaq.Psx.LastSale.Itch.v2.1 {

    #region Methods
    ///////////////////////////////////////////////////////////////////////

    public static class Endian {

        /// <summary>
        ///  Swap byte order for 2 byte unsigned short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Swap(ushort value)
            => unchecked(value << 8 | value >> 8);
        
        /// <summary>
        ///  Swap byte order in unsigned integer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(uint value)
            => unchecked((value & 0x000000FF) << 24 |
                         (value & 0x0000FF00) << 8  |
                         (value & 0x00FF0000) >> 8  |
                         (value & 0xFF000000) >> 24);
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Swap(ulong value)
            => unchecked((0x00000000000000FF) & (value >> 56) |
                         (0x000000000000FF00) & (value >> 40) |
                         (0x0000000000FF0000) & (value >> 24) |
                         (0x00000000FF000000) & (value >> 8)  |
                         (0x000000FF00000000) & (value << 8)  |
                         (0x0000FF0000000000) & (value << 24) |
                         (0x00FF000000000000) & (value << 40) |
                         (0xFF00000000000000) & (value << 56));
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Authenticity Values
    /// </summary>
    public enum Authenticity : byte {
        LiveProduction = (byte)'P',
        Test = (byte)'T',
    };


    /// <summary>
    ///  Breached Level Values
    /// </summary>
    public enum BreachedLevel : byte {
        Level1 = (byte)'1',
        Level2 = (byte)'2',
        Level3 = (byte)'3',
    };


    /// <summary>
    ///  Corrected Nav Premium Discount Amount
    /// </summary>
    public struct CorrectedNavPremiumDiscountAmount {
        public int Raw;
    };


    /// <summary>
    ///  Corrected Sale Condition Modifier
    /// </summary>
    public unsafe struct CorrectedSaleConditionModifier {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Trade Control Number
    /// </summary>
    public unsafe struct CorrectedTradeControlNumber {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Trade Price
    /// </summary>
    public struct CorrectedTradePrice {
        public int Raw;
    };


    /// <summary>
    ///  Corrected Trade Size
    /// </summary>
    public unsafe struct CorrectedTradeSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Count
    /// </summary>
    public unsafe struct Count {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        Halted = (byte)'H',
        QuotationOnly = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Etp Flag Values
    /// </summary>
    public enum EtpFlag : byte {
        Etp = (byte)'Y',
        NotEtp = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Etp Leverage Factor
    /// </summary>
    public unsafe struct EtpLeverageFactor {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfTransmissions = (byte)'O',
        StartOfMarketHours = (byte)'Q',
        StartOfSystemHours = (byte)'S',
        EndOfMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
        EndOfTransmissions = (byte)'C',
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        Deficient = (byte)'D',
        Delinquent = (byte)'E',
        Bankrupt = (byte)'Q',
        Suspended = (byte)'S',
        DeficientAndBankrupt = (byte)'G',
        DeficientAndDelinquent = (byte)'H',
        DelinquentAndBankrupt = (byte)'J',
        DeficientDelinquentAndBankrupt = (byte)'K',
        CreationsAndRedemptionsSuspended = (byte)'C',
        Normal = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Inverse Indicator Values
    /// </summary>
    public enum InverseIndicator : byte {
        InverseEtp = (byte)'Y',
        NotInverseEtp = (byte)'N',
    };


    /// <summary>
    ///  Ipo Flag Values
    /// </summary>
    public enum IpoFlag : byte {
        NasdaqListedInstrument = (byte)'Y',
        NasdaqListedInstrument = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Issue Classification Values
    /// </summary>
    public enum IssueClassification : byte {
        AmericanDepositaryShare = (byte)'A',
        Bond = (byte)'B',
        Common = (byte)'C',
        Depository = (byte)'F',
        144A = (byte)'I',
        Limited = (byte)'L',
        Notes = (byte)'N',
        OrdinaryShare = (byte)'O',
        Preferred = (byte)'P',
        Other = (byte)'Q',
        Right = (byte)'R',
        Shares = (byte)'S',
        Convertible = (byte)'T',
        Unit = (byte)'U',
        UnitsBenifInt = (byte)'V',
        Warrant = (byte)'W',
    };


    /// <summary>
    ///  Issue Sub Type Values
    /// </summary>
    public enum IssueSubType : ulong {
        PreferredTrustSecurities = "A",
        AlphaIndexEtNs = "AI",
        IndexBasedDerivative = "B",
        CommonShares = "C",
        CommodityBasedTrustShares = "CB",
        CommodityFuturesTrustShares = "CF",
        CurrencyTrustShares = "CL",
        CommodityIndexTrustShares = "CM",
        CollateralizedMortgageObligation = "CO",
        CurrencyTrustShares = "CT",
        Commodity­Currency = "CU",
        CurrencyWarrants = "CW",
        GlobalDepositary = "D",
        Etf­PortfolioDepositaryReceipt = "E",
        EquityGoldShares = "EG",
        EtnEquity = "EI",
        NextSharesExchange = "EM",
        ExchangeTradedNotes = "EN",
        EquityUnits = "EU",
        Holdrs = "F",
        EtnFixedIncome = "FI",
        EtnFutures = "FL",
        GlobalShares = "G",
        Etf = "I",
        Interest = "IR",
        Index = "IW",
        Index = "IX",
        Corporate = "J",
        Contingent = "L",
        Llc = "LL",
        EquityBasedDerivative = "M",
        ManagedFundShares = "MF",
        Etn = "ML",
        ManagedTrustSecurities = "MT",
        NyRegistryShares = "N",
        OpenEndedMutualFund = "O",
        PrivatelyHeldSecurity = "P",
        PoisonPill = "PP",
        PartnershipUnits = "PU",
        ClosedEndFunds = "Q",
        RegS = "R",
        CommodityRedeemable = "RC",
        Etn = "RF",
        Reit = "RT",
        Commodity­Redeemable = "RU",
        Seed = "S",
        SpotRateClosing = "SC",
        SpotRateIntraday = "SI",
        TrackingStock = "T",
        TrustCertificates = "TC",
        TrustUnits = "TU",
        Portal = "U",
        ContingentValueRight = "V",
        TrustIssuedReceipts = "W",
        WorldCurrencyOption = "WC",
        Trust = "X",
        Other = "Y",
        NotApplicable = "Z",
    };


    /// <summary>
    ///  Issue Symbol
    /// </summary>
    public unsafe struct IssueSymbol {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Length
    /// </summary>
    public unsafe struct Length {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Level 1
    /// </summary>
    public struct Level1 {
        public long Raw;
    };


    /// <summary>
    ///  Level 2
    /// </summary>
    public struct Level2 {
        public long Raw;
    };


    /// <summary>
    ///  Level 3
    /// </summary>
    public struct Level3 {
        public long Raw;
    };


    /// <summary>
    ///  Luld Reference Price Tier Values
    /// </summary>
    public enum LuldReferencePriceTier : byte {
        Tier1 = (byte)'1',
        Tier2 = (byte)'2',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Market Category Values
    /// </summary>
    public enum MarketCategory : byte {
        NasdaqGlobalSelectMarket = (byte)'Q',
        NasdaqGlobalMarket = (byte)'G',
        NasdaqCapitalMarket = (byte)'S',
        Nyse = (byte)'N',
        NyseMkt = (byte)'A',
        NyseArca = (byte)'P',
        BatsZ = (byte)'Z',
        InvestorsExchange = (byte)'V',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Market Center Identifier Values
    /// </summary>
    public enum MarketCenterIdentifier : byte {
        PsxExecutionSystem = (byte)'B',
        PsxExecutionSystem = (byte)'X',
    };


    /// <summary>
    ///  Market Code Values
    /// </summary>
    public enum MarketCode : byte {
        Nasdaq = (byte)'Q',
        Bx = (byte)'B',
        Psx = (byte)'X',
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        TradeReportMessage = (byte)'T',
        NextSharesTradeReportMessage = (byte)'M',
        TradeCancelErrorMessage = (byte)'X',
        TradeCancelErrorForNextSharesMessage = (byte)'O',
        TradeCorrectionMessage = (byte)'C',
        TradeCorrectionForNextSharesMessage = (byte)'Z',
        TradingActionMessage = (byte)'H',
        RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
        StockDirectoryMessage = (byte)'R',
        MwcbDeclineLevelMessage = (byte)'V',
        MwcbBreachMessage = (byte)'W',
        OperationalHaltMessage = (byte)'h',
    };


    /// <summary>
    ///  Nav Premium Discount Amount
    /// </summary>
    public struct NavPremiumDiscountAmount {
        public int Raw;
    };


    /// <summary>
    ///  Next Shares Symbol
    /// </summary>
    public unsafe struct NextSharesSymbol {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Operational Halt Action Values
    /// </summary>
    public enum OperationalHaltAction : byte {
        Halted = (byte)'H',
        Resumed = (byte)'T',
    };


    /// <summary>
    ///  Original Nav Premium Discount Amount
    /// </summary>
    public struct OriginalNavPremiumDiscountAmount {
        public int Raw;
    };


    /// <summary>
    ///  Original Sale Condition Modifier
    /// </summary>
    public unsafe struct OriginalSaleConditionModifier {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Control Number
    /// </summary>
    public unsafe struct OriginalTradeControlNumber {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Price
    /// </summary>
    public struct OriginalTradePrice {
        public int Raw;
    };


    /// <summary>
    ///  Original Trade Size
    /// </summary>
    public unsafe struct OriginalTradeSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Proxy Price
    /// </summary>
    public struct ProxyPrice {
        public int Raw;
    };


    /// <summary>
    ///  Reg Sho Action Values
    /// </summary>
    public enum RegShoAction : byte {
        NoPriceTest = (byte)'0',
        RegShoShortSalePriceTestRestriction = (byte)'1',
        TestRestrictionRemains = (byte)'2',
    };


    /// <summary>
    ///  Round Lot Size
    /// </summary>
    public unsafe struct RoundLotSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Round Lots Only Values
    /// </summary>
    public enum RoundLotsOnly : byte {
        RoundLotsOnly = (byte)'Y',
        NoRestriction = (byte)'N',
    };


    /// <summary>
    ///  Sale Condition Modifier Level 1 Values
    /// </summary>
    public enum SaleConditionModifierLevel1 : byte {
        ProxyPriceSettlement = (byte)'J',
        RegularSettlement = (byte)'@',
        CashSettlement = (byte)'C',
        NextDaySettlement = (byte)'N',
        SellerSettlement = (byte)'R',
    };


    /// <summary>
    ///  Sale Condition Modifier Level 2 Values
    /// </summary>
    public enum SaleConditionModifierLevel2 : byte {
        IntermarketSweep = (byte)'F',
        OpeningPrint = (byte)'O',
        DerivativePriced = (byte)'4',
        ReOpeningPrint = (byte)'5',
        ClosingPrint = (byte)'6',
        NotApplicable = (byte)' ',
    };


    /// <summary>
    ///  Sale Condition Modifier Level 3 Values
    /// </summary>
    public enum SaleConditionModifierLevel3 : byte {
        ExtendedHoursTrade = (byte)'T',
        ReportedLateOrOutOfSequence = (byte)'U',
        ReportedLateButInSequence = (byte)'L',
        SoldOutOfSequence = (byte)'Z',
        NotApplicable = (byte)' ',
    };


    /// <summary>
    ///  Sale Condition Modifier Level 4 Values
    /// </summary>
    public enum SaleConditionModifierLevel4 : byte {
        Acquisition = (byte)'A',
        Bunched = (byte)'B',
        Distribution = (byte)'D',
        PriceVariationTransaction = (byte)'H',
        PsxOfficialClosePrice = (byte)'M',
        PriorReferencePrice = (byte)'P',
        PsxOfficialOpeningPrice = (byte)'Q',
        SplitTrade = (byte)'S',
        WeightedAveragePrice = (byte)'W',
        CrossTrade = (byte)'X',
        OddLotExecution = (byte)'o',
        OddLotCrossExecution = (byte)'x',
        NotApplicable = (byte)' ',
    };


    /// <summary>
    ///  Security Class Values
    /// </summary>
    public enum SecurityClass : byte {
        Nasdaq = (byte)'Q',
        Nyse = (byte)'N',
        NyseAmex = (byte)'A',
        NyseArca = (byte)'P',
        Bats = (byte)'Z',
        InvestorsExchange = (byte)'V',
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public unsafe struct Sequence {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session
    /// </summary>
    public unsafe struct Session {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Short Sale Threshold Indicator Values
    /// </summary>
    public enum ShortSaleThresholdIndicator : byte {
        Restricted = (byte)'Y',
        NotRestricted = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Stock
    /// </summary>
    public unsafe struct Stock {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 6;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tracking Number
    /// </summary>
    public unsafe struct TrackingNumber {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Control Number
    /// </summary>
    public unsafe struct TradeControlNumber {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public struct TradePrice {
        public int Raw;
    };


    /// <summary>
    ///  Trade Size
    /// </summary>
    public unsafe struct TradeSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Action Reason Values
    /// </summary>
    public enum TradingActionReason : ulong {
        HaltNewsPending = "T1",
        HaltNewsDisseminated = "T2",
        SingleSecurityTradingPauseInEffect = "T5",
        RegulatoryHalt = "T6",
        HaltEtf = "T8",
        TradingHalted = "T12",
        HaltNonCompliance = "H4",
        HaltFilingsNotCurrent = "H9",
        HaltSecTradingSuspension = "H10",
        HaltRegulatoryConcern = "H11",
        VolatilityTradingPause = "LUDP",
        StraddleConditionTradingPause = "LUDS",
        CircuitBreakerHaltLevel1 = "MWC1",
        CircuitBreakerHaltLevel2 = "MWC2",
        CircuitBreakerHaltLevel3 = "MWC3",
        CarryOverCircuitBreakerHalt = "MWC0",
        OperationsHalt = "O1",
        IpoIssue = "IPO1",
        CorporateAction = "M1",
        NotAvailable = "M2",
        NewsAndResumptionTimes = "T3",
        TradingPauseQuotationOnlyPeriod = "T7",
        QualificationsIssuesResolved = "R4",
        FilingRequirementsSatisfied = "R9",
        IssuerNewsNotForthcoming = "C3",
        QualificationsHaltEnded = "C4",
        QualificationsHaltConcluded = "C9",
        TradeHaltConcludedByOtherRegulatoryAuthority = "C11",
        MarketWideCircuitBreakerResumption = "MWCQ",
        NewIssue = "R1",
        IssueAvailable = "R2",
        IpoSecurityReleased = "IPOQ",
        IpoSecurityPositioningWindowExtension = "IPOE",
        ReasonNotAvailable = "",
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        Length Length;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Mwcb Breach Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbBreachMessage {
        BreachedLevel BreachedLevel;
    };


    /// <summary>
    ///  Struct for Mwcb Decline Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbDeclineLevelMessage {
        Level1 Level1;
        Level2 Level2;
        Level3 Level3;
    };


    /// <summary>
    ///  Struct for Next Shares Trade Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NextSharesTradeReportMessage {
        MarketCenterIdentifier MarketCenterIdentifier;
        NextSharesSymbol NextSharesSymbol;
        SecurityClass SecurityClass;
        TradeControlNumber TradeControlNumber;
        ProxyPrice ProxyPrice;
        TradeSize TradeSize;
        NavPremiumDiscountAmount NavPremiumDiscountAmount;
        SaleConditionModifierLevel1 SaleConditionModifierLevel1;
        SaleConditionModifierLevel2 SaleConditionModifierLevel2;
        SaleConditionModifierLevel3 SaleConditionModifierLevel3;
        SaleConditionModifierLevel4 SaleConditionModifierLevel4;
    };


    /// <summary>
    ///  Struct for Operational Halt Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OperationalHaltMessage {
        Stock Stock;
        MarketCode MarketCode;
        OperationalHaltAction OperationalHaltAction;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        PacketHeader PacketHeader;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        Session Session;
        Sequence Sequence;
        Count Count;
    };


    /// <summary>
    ///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
        Stock Stock;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Stock Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockDirectoryMessage {
        Stock Stock;
        MarketCategory MarketCategory;
        FinancialStatusIndicator FinancialStatusIndicator;
        RoundLotSize RoundLotSize;
        RoundLotsOnly RoundLotsOnly;
        IssueClassification IssueClassification;
        IssueSubType IssueSubType;
        Authenticity Authenticity;
        ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
        IpoFlag IpoFlag;
        LuldReferencePriceTier LuldReferencePriceTier;
        EtpFlag EtpFlag;
        EtpLeverageFactor EtpLeverageFactor;
        InverseIndicator InverseIndicator;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        EventCode EventCode;
    };


    /// <summary>
    ///  Struct for Trade Cancel Error For Next Shares Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelErrorForNextSharesMessage {
        MarketCenterIdentifier MarketCenterIdentifier;
        IssueSymbol IssueSymbol;
        SecurityClass SecurityClass;
        OriginalTradeControlNumber OriginalTradeControlNumber;
        OriginalTradePrice OriginalTradePrice;
        OriginalNavPremiumDiscountAmount OriginalNavPremiumDiscountAmount;
        OriginalTradeSize OriginalTradeSize;
        OriginalSaleConditionModifier OriginalSaleConditionModifier;
    };


    /// <summary>
    ///  Struct for Trade Cancel Error Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelErrorMessage {
        MarketCenterIdentifier MarketCenterIdentifier;
        IssueSymbol IssueSymbol;
        SecurityClass SecurityClass;
        OriginalTradeControlNumber OriginalTradeControlNumber;
        OriginalTradePrice OriginalTradePrice;
        OriginalTradeSize OriginalTradeSize;
        OriginalSaleConditionModifier OriginalSaleConditionModifier;
    };


    /// <summary>
    ///  Struct for Trade Correction For Next Shares Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCorrectionForNextSharesMessage {
        MarketCenterIdentifier MarketCenterIdentifier;
        IssueSymbol IssueSymbol;
        SecurityClass SecurityClass;
        OriginalTradeControlNumber OriginalTradeControlNumber;
        OriginalTradePrice OriginalTradePrice;
        OriginalNavPremiumDiscountAmount OriginalNavPremiumDiscountAmount;
        OriginalTradeSize OriginalTradeSize;
        OriginalSaleConditionModifier OriginalSaleConditionModifier;
        CorrectedTradeControlNumber CorrectedTradeControlNumber;
        CorrectedTradePrice CorrectedTradePrice;
        CorrectedNavPremiumDiscountAmount CorrectedNavPremiumDiscountAmount;
        CorrectedTradeSize CorrectedTradeSize;
        CorrectedSaleConditionModifier CorrectedSaleConditionModifier;
    };


    /// <summary>
    ///  Struct for Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCorrectionMessage {
        MarketCenterIdentifier MarketCenterIdentifier;
        IssueSymbol IssueSymbol;
        SecurityClass SecurityClass;
        OriginalTradeControlNumber OriginalTradeControlNumber;
        OriginalTradePrice OriginalTradePrice;
        OriginalTradeSize OriginalTradeSize;
        OriginalSaleConditionModifier OriginalSaleConditionModifier;
        CorrectedTradeControlNumber CorrectedTradeControlNumber;
        CorrectedTradePrice CorrectedTradePrice;
        CorrectedTradeSize CorrectedTradeSize;
        CorrectedSaleConditionModifier CorrectedSaleConditionModifier;
    };


    /// <summary>
    ///  Struct for Trade Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportMessage {
        MarketCenterIdentifier MarketCenterIdentifier;
        IssueSymbol IssueSymbol;
        SecurityClass SecurityClass;
        TradeControlNumber TradeControlNumber;
        TradePrice TradePrice;
        TradeSize TradeSize;
        SaleConditionModifierLevel1 SaleConditionModifierLevel1;
        SaleConditionModifierLevel2 SaleConditionModifierLevel2;
        SaleConditionModifierLevel3 SaleConditionModifierLevel3;
        SaleConditionModifierLevel4 SaleConditionModifierLevel4;
    };


    /// <summary>
    ///  Struct for Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingActionMessage {
        IssueSymbol IssueSymbol;
        SecurityClass SecurityClass;
        CurrentTradingState CurrentTradingState;
        TradingActionReason TradingActionReason;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
