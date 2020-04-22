namespace Nasdaq.Equities.Level2.Itch.v2.0 {

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
        Paused = (byte)'P',
        QuotationOnlyPeriod = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Etp Flag Values
    /// </summary>
    public enum EtpFlag : byte {
        Etp = (byte)'Y',
        NotEtp = (byte)'N',
        NotAvailable = (byte)' ',
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
        StartOfMessages = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfMarketHours = (byte)'Q',
        EndOfMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
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
        InCompliance = (byte)' ',
    };


    /// <summary>
    ///  Interest Flag Values
    /// </summary>
    public enum InterestFlag : byte {
        BuySideRpiOrdersAvailable = (byte)'B',
        SellSideRpiOrdersAvailable = (byte)'S',
        BothSidesRpiOrdersAvailable = (byte)'A',
        NoRpiOrdersAvailable = (byte)'N',
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
        SetUpForIpoRelease = (byte)'Y',
        NotSetUpForIpoRelease = (byte)'N',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Ipo Price
    /// </summary>
    public unsafe struct IpoPrice {
        public const int Size = 10;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Ipo Quotation Release Qualifier Values
    /// </summary>
    public enum IpoQuotationReleaseQualifier : byte {
        AnticipatedQuotationReleaseTime = (byte)'A',
        IpoReleaseCanceledOrPostponed = (byte)'C',
    };


    /// <summary>
    ///  Ipo Quotation Release Time
    /// </summary>
    public unsafe struct IpoQuotationReleaseTime {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Issue Subtype Values
    /// </summary>
    public enum IssueSubtype : ulong {
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
        NotAvailable = (byte)' ',
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
        Na = (byte)' ',
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
    ///  Market Maker Mode Values
    /// </summary>
    public enum MarketMakerMode : byte {
        Normal = (byte)'N',
        Passive = (byte)'P',
        Syndicate = (byte)'S',
        PreSyndicate = (byte)'R',
        Penalty = (byte)'L',
    };


    /// <summary>
    ///  Market Participant State Values
    /// </summary>
    public enum MarketParticipantState : byte {
        Active = (byte)'A',
        Excused = (byte)'E',
        Withdrawn = (byte)'W',
        Suspended = (byte)'S',
        Deleted = (byte)'D',
    };


    /// <summary>
    ///  Market Side Values
    /// </summary>
    public enum MarketSide : byte {
        BidUpdate = (byte)'B',
        OfferAskUpdate = (byte)'S',
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        StockDirectoryMessage = (byte)'R',
        StockTradingActionMessage = (byte)'H',
        RegShoRestrictionMessage = (byte)'Y',
        ParticipantPositionSummaryMessage = (byte)'P',
        OperationalHaltMessage = (byte)'h',
        MarketParticipantBidaskUpdateMessage = (byte)'U',
        RetailPriceInterestIndicatorMessage = (byte)'N',
        MwcbDeclineLevelMessage = (byte)'V',
        MwcbStatusMessage = (byte)'W',
        IpoQuotingPeriodUpdateMessage = (byte)'K',
    };


    /// <summary>
    ///  Mpid
    /// </summary>
    public unsafe struct Mpid {
        public const int Size = 4;

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
        TradingHalted = (byte)'H',
        TradingResumed = (byte)'T',
    };


    /// <summary>
    ///  Participant Shares
    /// </summary>
    public unsafe struct ParticipantShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public int Raw;
    };


    /// <summary>
    ///  Primary Market Maker Values
    /// </summary>
    public enum PrimaryMarketMaker : byte {
        Primary = (byte)'Y',
        NonPrimary = (byte)'N',
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
        NoRestrictions = (byte)'N',
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
    ///  Struct for Ipo Quoting Period Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IpoQuotingPeriodUpdateMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        IpoQuotationReleaseTime IpoQuotationReleaseTime;
        IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier;
        IpoPrice IpoPrice;
    };


    /// <summary>
    ///  Struct for Market Participant Bidask Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketParticipantBidaskUpdateMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        MarketSide MarketSide;
        ParticipantShares ParticipantShares;
        Stock Stock;
        Price Price;
        Mpid Mpid;
    };


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
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Mwcb Decline Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbDeclineLevelMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Level1 Level1;
        Level2 Level2;
        Level3 Level3;
    };


    /// <summary>
    ///  Struct for Mwcb Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbStatusMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BreachedLevel BreachedLevel;
    };


    /// <summary>
    ///  Struct for Operational Halt Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OperationalHaltMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
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
    ///  Struct for Participant Position Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParticipantPositionSummaryMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Mpid Mpid;
        Stock Stock;
        PrimaryMarketMaker PrimaryMarketMaker;
        MarketMakerMode MarketMakerMode;
        MarketParticipantState MarketParticipantState;
    };


    /// <summary>
    ///  Struct for Reg Sho Restriction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoRestrictionMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Retail Price Interest Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetailPriceInterestIndicatorMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        InterestFlag InterestFlag;
    };


    /// <summary>
    ///  Struct for Stock Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockDirectoryMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        MarketCategory MarketCategory;
        FinancialStatusIndicator FinancialStatusIndicator;
        RoundLotSize RoundLotSize;
        RoundLotsOnly RoundLotsOnly;
        IssueClassification IssueClassification;
        IssueSubtype IssueSubtype;
        Authenticity Authenticity;
        ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
        IpoFlag IpoFlag;
        LuldReferencePriceTier LuldReferencePriceTier;
        EtpFlag EtpFlag;
        EtpLeverageFactor EtpLeverageFactor;
        InverseIndicator InverseIndicator;
    };


    /// <summary>
    ///  Struct for Stock Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockTradingActionMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        CurrentTradingState CurrentTradingState;
        TradingActionReason TradingActionReason;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        EventCode EventCode;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
