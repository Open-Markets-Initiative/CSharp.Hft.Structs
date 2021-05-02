namespace Siac.Cts.Output.Cta.v1.91 {

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
    ///  Administrative Message Type Values
    /// </summary>
    public enum AdministrativeMessageType : byte {
        StartOfEndOfDayMessage = (byte)'A',
        EndOfEndOfDayMessage = (byte)'B',
        StartOfStartOfDayMessage = (byte)'C',
        EndOfStartOfDayMessage = (byte)'D',
        AdministrativeUnformattedMessage = (byte)'H',
    };


    /// <summary>
    ///  Auction Collar Lower Threshold Price
    /// </summary>
    public unsafe struct AuctionCollarLowerThresholdPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Collar Reference Price
    /// </summary>
    public unsafe struct AuctionCollarReferencePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Index Value
    /// </summary>
    public struct BidIndexValue {
        public long Raw;
    };


    /// <summary>
    ///  Block Checksum
    /// </summary>
    public unsafe struct BlockChecksum {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Pad Byte
    /// </summary>
    public struct BlockPadByte {
        public byte Raw;
    };


    /// <summary>
    ///  Block Sequence Number
    /// </summary>
    public unsafe struct BlockSequenceNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Size
    /// </summary>
    public unsafe struct BlockSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Buy Volume
    /// </summary>
    public unsafe struct BuyVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancel Error Action Values
    /// </summary>
    public enum CancelErrorAction : byte {
        Cancel = (byte)'1',
        Error = (byte)'2',
    };


    /// <summary>
    ///  Category 1
    /// </summary>
    public unsafe struct Category1 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Category 2 Values
    /// </summary>
    public enum Category2 : byte {
        NoReason = (byte)' ',
        IntermarketSweepOrder = (byte)'F',
        MarketCenterOpeningTrade = (byte)'O',
        DerivativelyPriced = (byte)'4',
        MarketCenterReopeningTrade = (byte)'5',
        MarketCenterClosingTrade = (byte)'6',
        QualifiedContingentTrade = (byte)'7',
        Reserved = (byte)'8',
        CorrectedConsolidatedClosePriceAsPerListingMarket = (byte)'9',
    };


    /// <summary>
    ///  Category 3 Values
    /// </summary>
    public enum Category3 : byte {
        NotExtendedHoursOrSoldOutOfSequence = (byte)' ',
        SoldLast = (byte)'L',
        ExtendedHoursTrade = (byte)'T',
        ExtendedHoursSold = (byte)'U',
        SoldOutOfSequence = (byte)'Z',
    };


    /// <summary>
    ///  Category 4 Values
    /// </summary>
    public enum Category4 : byte {
        NoSroRequiredTradeDetail = (byte)' ',
        AveragePriceTrade = (byte)'B',
        AutomaticExecution = (byte)'E',
        PriceVariationTrade = (byte)'H',
        OddLotTrade = (byte)'I',
        Rule127Or155 = (byte)'K',
        MarketCenterOfficialClose = (byte)'M',
        PriorReferencePrice = (byte)'P',
        MarketCenterOfficialOpen = (byte)'Q',
        ContingentTrade = (byte)'V',
        CrossTrade = (byte)'X',
    };


    /// <summary>
    ///  Consolidated High Low Last Indicator Values
    /// </summary>
    public enum ConsolidatedHighLowLastIndicator : byte {
        None = (byte)'A',
        High = (byte)'B',
        Low = (byte)'C',
        Last = (byte)'D',
        HighLast = (byte)'E',
        LowLast = (byte)'F',
        HighLowLast = (byte)'G',
        HighLow = (byte)'H',
    };


    /// <summary>
    ///  Control Message Type Values
    /// </summary>
    public enum ControlMessageType : byte {
        StartOfDayMessage = (byte)'A',
        ResetBlockSequenceNumberMessage = (byte)'L',
        StartOfTestCycleMessage = (byte)'M',
        EndOfTestCycleMessage = (byte)'N',
        DisasterRecoveryDataCenterActivationMessage = (byte)'P',
        LineIntegrityMessage = (byte)'T',
        EndOfDayMessage = (byte)'Z',
    };


    /// <summary>
    ///  Crossing Session 1 Total Trades Volume
    /// </summary>
    public unsafe struct CrossingSession1TotalTradesVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Crossing Session 2 Dollar Value
    /// </summary>
    public unsafe struct CrossingSession2DollarValue {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Crossing Session 2 Total Trades Volume
    /// </summary>
    public unsafe struct CrossingSession2TotalTradesVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Data Feed Indicator
    /// </summary>
    public unsafe struct DataFeedIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dollar Value
    /// </summary>
    public unsafe struct DollarValue {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        FinancialStatusNotApplicable = (byte)'0',
        Bankrupt = (byte)'1',
        BelowContinuingListingStandards = (byte)'2',
        BankruptAndBelowContinuingListingStandards = (byte)'3',
        LateFiling = (byte)'4',
        BankruptAndLateFiling = (byte)'5',
        BelowContinuingListingStandardsAndLateFiling = (byte)'6',
        BankruptBelowContinuingListingStandardsAndLateFiling = (byte)'7',
        CreationsSuspended = (byte)'8',
        RedemptionsSuspended = (byte)'9',
        Liquidation = (byte)'A',
    };


    /// <summary>
    ///  Future Use
    /// </summary>
    public unsafe struct FutureUse {
        public const int Size = 62;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Halt Reason Values
    /// </summary>
    public enum HaltReason : byte {
        NotApplicable = (byte)' ',
        NewsDissemination = (byte)'D',
        OrderImbalance = (byte)'I',
        LimitUpLimitDownTradingPause = (byte)'M',
        NewsPending = (byte)'P',
        Operational = (byte)'X',
        SubpennyTrading = (byte)'Y',
        MarketWideCircuitBreakerLevel1Breached = (byte)'1',
        MarketWideCircuitBreakerLevel2Breached = (byte)'2',
        MarketWideCircuitBreakerLevel3Breached = (byte)'3',
    };


    /// <summary>
    ///  Held Trade Indicator Values
    /// </summary>
    public enum HeldTradeIndicator : byte {
        NotApplicable = (byte)' ',
        CannotBeUsedAsALastSaleForBothParticipantAndConsolidatedBasis = (byte)'A',
        CanBeUsedAsALastSaleForParticipantButNotConsolidatedBasis = (byte)'B',
        CanBeUsedAsALastSaleForParticipantAndConsolidatedBasis = (byte)'C',
    };


    /// <summary>
    ///  High Indication Price Upper Limit Price Band
    /// </summary>
    public unsafe struct HighIndicationPriceUpperLimitPriceBand {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Price
    /// </summary>
    public unsafe struct HighPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Index Message Type Values
    /// </summary>
    public enum IndexMessageType : byte {
        IndexMessage = (byte)'I',
        BidAndOfferIndexMessage = (byte)'Q',
    };


    /// <summary>
    ///  Index Symbol
    /// </summary>
    public unsafe struct IndexSymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Index Value
    /// </summary>
    public struct IndexValue {
        public long Raw;
    };


    /// <summary>
    ///  Instrument Type Values
    /// </summary>
    public enum InstrumentType : byte {
        CtaEligibleEquity = (byte)'0',
        LocalIssue = (byte)'1',
        CorporateBond = (byte)'2',
        GovernmentBond = (byte)'3',
    };


    /// <summary>
    ///  Last Participant Id Values
    /// </summary>
    public enum LastParticipantId : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        Ltse = (byte)'L',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Cts = (byte)'S',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Last Price
    /// </summary>
    public unsafe struct LastPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Limit Up Limit Down Indicator Values
    /// </summary>
    public enum LimitUpLimitDownIndicator : byte {
        LimitUpLimitDownNotApplicable = (byte)' ',
        LimitUpLimitDownPriceBand = (byte)'A',
        RepublishedLimitUpLimitDownPriceBand = (byte)'B',
        NationalBestBidLimitStateEntered = (byte)'C',
        NationalBestBidLimitStateExited = (byte)'D',
        NationalBestOfferLimitStateEntered = (byte)'E',
        NationalBestOfferLimitStateExited = (byte)'F',
        NationalBestBidAndNationalBestOfferLimitStateEntered = (byte)'G',
        NationalBestBidAndNationalBestOfferLimitStateExited = (byte)'H',
        NationalBestBidLimitStateEnteredAndNationalBestOfferLimitStateExited = (byte)'I',
        NationalBestBidLimitStateExitedAndNationalBestOfferLimitStateEntered = (byte)'J',
    };


    /// <summary>
    ///  Low Indication Price Lower Limit Price Band
    /// </summary>
    public unsafe struct LowIndicationPriceLowerLimitPriceBand {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Low Price
    /// </summary>
    public unsafe struct LowPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Status Message Type Values
    /// </summary>
    public enum MarketStatusMessageType : byte {
        MarketWideCircuitBreakerDeclineLevelStatusMessage = (byte)'M',
        MarketWideCircuitBreakerStatusMessage = (byte)'L',
        ApproximateAdjustedVolumeMarketCenterMessage = (byte)'N',
        ApproximateTradesAndTotalDollarValueMessage = (byte)'O',
        CrossingSessionSummaryMessage = (byte)'P',
    };


    /// <summary>
    ///  Message Category Values
    /// </summary>
    public enum MessageCategory : byte {
        Administrative = (byte)'A',
        Control = (byte)'C',
        Index = (byte)'I',
        MarketStatus = (byte)'M',
        PriorDay = (byte)'P',
        Summary = (byte)'S',
        Trade = (byte)'T',
    };


    /// <summary>
    ///  Message Id
    /// </summary>
    public struct MessageId {
        public byte Raw;
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Messages In Block
    /// </summary>
    public struct MessagesInBlock {
        public byte Raw;
    };


    /// <summary>
    ///  Mwcb Level 2
    /// </summary>
    public struct MwcbLevel2 {
        public long Raw;
    };


    /// <summary>
    ///  Mwcb Level 3
    /// </summary>
    public struct MwcbLevel3 {
        public long Raw;
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public unsafe struct Nanoseconds {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Extensions
    /// </summary>
    public struct NumberOfExtensions {
        public byte Raw;
    };


    /// <summary>
    ///  Number Of Participants
    /// </summary>
    public struct NumberOfParticipants {
        public byte Raw;
    };


    /// <summary>
    ///  Offer Index Value
    /// </summary>
    public struct OfferIndexValue {
        public long Raw;
    };


    /// <summary>
    ///  Open Price
    /// </summary>
    public unsafe struct OpenPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Participant Reference Number
    /// </summary>
    public struct OriginalParticipantReferenceNumber {
        public long Raw;
    };


    /// <summary>
    ///  Participant Id Values
    /// </summary>
    public enum ParticipantId : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        Ltse = (byte)'L',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Cts = (byte)'S',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Participant Open High Low Last Indicator Values
    /// </summary>
    public enum ParticipantOpenHighLowLastIndicator : byte {
        None = (byte)'A',
        High = (byte)'B',
        Low = (byte)'C',
        Last = (byte)'D',
        HighLast = (byte)'E',
        LowLast = (byte)'F',
        Unused = (byte)'G',
        Open = (byte)'H',
        OpenHigh = (byte)'I',
        OpenLow = (byte)'J',
        OpenHighLowLast = (byte)'K',
        OpenLast = (byte)'L',
        OpenHighLow = (byte)'M',
        OpenHighLast = (byte)'N',
        OpenLowLast = (byte)'O',
        HighLow = (byte)'P',
        HighLowLast = (byte)'Q',
    };


    /// <summary>
    ///  Participant Reference Number
    /// </summary>
    public struct ParticipantReferenceNumber {
        public long Raw;
    };


    /// <summary>
    ///  Previous Close Price
    /// </summary>
    public unsafe struct PreviousClosePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Previous Close Price Date
    /// </summary>
    public unsafe struct PreviousClosePriceDate {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Primary Listing Market Participant Id Values
    /// </summary>
    public enum PrimaryListingMarketParticipantId : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Prior Day Message Type Values
    /// </summary>
    public enum PriorDayMessageType : byte {
        PriorDayTradeCorrectionMessage = (byte)'C',
        PriorDayTradeMessage = (byte)'L',
        PriorDayTradeMessage = (byte)'X',
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public struct Reserved {
        public byte Raw;
    };


    /// <summary>
    ///  Retransmission Indicator Values
    /// </summary>
    public enum RetransmissionIndicator : byte {
        Original = (byte)'O',
        Retransmitted = (byte)'V',
    };


    /// <summary>
    ///  Sale Condition Values
    /// </summary>
    public enum SaleCondition : byte {
        RegularSale = (byte)' ',
        AveragePriceTrade = (byte)'B',
        CashTrade = (byte)'C',
        AutomaticExecution = (byte)'E',
        IntermarketSweepOrder = (byte)'F',
        PriceVariationTrade = (byte)'H',
        OddLotTrade = (byte)'I',
        Rule127Or155 = (byte)'K',
        SoldLast = (byte)'L',
        MarketCenterOfficialClose = (byte)'M',
        NextDayTrade = (byte)'N',
        MarketCenterOpeningTrade = (byte)'O',
        PriorReferencePrice = (byte)'P',
        MarketCenterOfficialOpen = (byte)'Q',
        Seller = (byte)'R',
        ExtendedHoursTrade = (byte)'T',
        ExtendedHoursSold = (byte)'U',
        ContingentTrade = (byte)'V',
        CrossTrade = (byte)'X',
        Sold = (byte)'Z',
        DerivativelyPriced = (byte)'4',
        MarketCenterReopeningTrade = (byte)'5',
        MarketCenterClosingTrade = (byte)'6',
        QualifiedContingentTrade = (byte)'7',
        Reserved = (byte)'8',
        CorrectedConsolidatedClosePriceAsPerListingMarket = (byte)'9',
    };


    /// <summary>
    ///  Sale Condition Category Values
    /// </summary>
    public enum SaleConditionCategory : byte {
        NotApplicable = (byte)' ',
        Category1 = (byte)'1',
        Category2 = (byte)'2',
        Category3 = (byte)'3',
        Category4 = (byte)'4',
    };


    /// <summary>
    ///  Seconds
    /// </summary>
    public unsafe struct Seconds {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        NotApplicable = (byte)' ',
        OpeningDelay = (byte)'1',
        TradingHalt = (byte)'2',
        Resume = (byte)'3',
        NoOpenNoResume = (byte)'4',
        PriceIndication = (byte)'5',
        TradingRangeIndication = (byte)'6',
        MarketImbalanceBuy = (byte)'7',
        MarketImbalanceSell = (byte)'8',
        MarketOnCloseImbalanceBuy = (byte)'9',
        MarketOnCloseImbalanceSell = (byte)'A',
        Reserved = (byte)'B',
        NoMarketImbalance = (byte)'C',
        NoMarketOnCloseImbalance = (byte)'D',
        ShortSaleRestriction = (byte)'E',
        LimitUpLimitDown = (byte)'F',
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol Short
    /// </summary>
    public unsafe struct SecuritySymbolShort {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sell Volume
    /// </summary>
    public unsafe struct SellVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sellers Sale Days
    /// </summary>
    public struct SellersSaleDays {
        public byte Raw;
    };


    /// <summary>
    ///  Short Sale Restriction Indicator Values
    /// </summary>
    public enum ShortSaleRestrictionIndicator : byte {
        NotInEffect = (byte)' ',
        Activated = (byte)'A',
        Continued = (byte)'C',
        Deactivated = (byte)'D',
        RestrictionInEffect = (byte)'E',
    };


    /// <summary>
    ///  Stop Stock Indicator Values
    /// </summary>
    public enum StopStockIndicator : byte {
        NotApplicable = (byte)'0',
        StopStock = (byte)'1',
    };


    /// <summary>
    ///  Summary Message Type Values
    /// </summary>
    public enum SummaryMessageType : byte {
        ConsolidatedStartOfDaySummaryMessage = (byte)'A',
        ParticipantStartOfDaySummaryMessage = (byte)'B',
        ConsolidatedEndOfDaySummaryMessage = (byte)'C',
        ParticipantEndOfDaySummaryMessage = (byte)'D',
    };


    /// <summary>
    ///  Tick Values
    /// </summary>
    public enum Tick : byte {
        NotApplicable = (byte)' ',
        Upward = (byte)'1',
        Downward = (byte)'2',
        UnchangedUpward = (byte)'3',
        UnchangedDownward = (byte)'4',
    };


    /// <summary>
    ///  Total Trades
    /// </summary>
    public unsafe struct TotalTrades {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Volume
    /// </summary>
    public unsafe struct TotalVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Message Type Values
    /// </summary>
    public enum TradeMessageType : byte {
        AuctionStatusMessage = (byte)'A',
        TradeCorrectionMessage = (byte)'C',
        LongTradeMessage = (byte)'L',
        TradingStatusMessage = (byte)'S',
        ShortTradeMessage = (byte)'T',
        TradeCancelErrorMessage = (byte)'X',
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public unsafe struct TradePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price Short
    /// </summary>
    public unsafe struct TradePriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Reporting Facility Id Values
    /// </summary>
    public enum TradeReportingFacilityId : byte {
        NotApplicable = (byte)' ',
        InactiveValueA = (byte)'A',
        FinraNasdaqChicago = (byte)'B',
        InactiveValueC = (byte)'C',
        InactiveValueD = (byte)'D',
        InactiveValueI = (byte)'I',
        InactiveValueJ = (byte)'J',
        InactiveValueK = (byte)'K',
        InactiveValueM = (byte)'M',
        FinraNyse = (byte)'N',
        InactiveValueP = (byte)'P',
        FinraNasdaqCarteret = (byte)'B',
        InactiveValueV = (byte)'V',
        InactiveValueW = (byte)'W',
        InactiveValueX = (byte)'X',
        InactiveValueY = (byte)'Y',
        InactiveValueZ = (byte)'Z',
    };


    /// <summary>
    ///  Trade Through Exempt Indicator Values
    /// </summary>
    public enum TradeThroughExemptIndicator : byte {
        NotATradeThroughExemption = (byte)'0',
        TradeThroughExemption = (byte)'1',
    };


    /// <summary>
    ///  Trade Total Volume
    /// </summary>
    public unsafe struct TradeTotalVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Volume
    /// </summary>
    public unsafe struct TradeVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Volume Short
    /// </summary>
    public unsafe struct TradeVolumeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transaction Id
    /// </summary>
    public unsafe struct TransactionId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public struct Version {
        public byte Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Administrative
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Administrative {
        AdministrativeMessageType AdministrativeMessageType;
    };


    /// <summary>
    ///  Struct for Administrative Unformatted Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdministrativeUnformattedMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        Text Text;
    };


    /// <summary>
    ///  Struct for Approximate Adjusted Volume Market Center Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApproximateAdjustedVolumeMarketCenterMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        NumberOfParticipants NumberOfParticipants;
    };


    /// <summary>
    ///  Struct for Approximate Trades And Total Dollar Value Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApproximateTradesAndTotalDollarValueMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        TotalTrades TotalTrades;
        DollarValue DollarValue;
    };


    /// <summary>
    ///  Struct for Auction Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionStatusMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        AuctionCollarReferencePrice AuctionCollarReferencePrice;
        AuctionCollarUpperThresholdPrice AuctionCollarUpperThresholdPrice;
        AuctionCollarLowerThresholdPrice AuctionCollarLowerThresholdPrice;
        NumberOfExtensions NumberOfExtensions;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        FutureUse FutureUse;
    };


    /// <summary>
    ///  Struct for Bid And Offer Index Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BidAndOfferIndexMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        IndexSymbol IndexSymbol;
        BidIndexValue BidIndexValue;
        OfferIndexValue OfferIndexValue;
    };


    /// <summary>
    ///  Struct for Block Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BlockHeader {
        Version Version;
        BlockSize BlockSize;
        DataFeedIndicator DataFeedIndicator;
        RetransmissionIndicator RetransmissionIndicator;
        BlockSequenceNumber BlockSequenceNumber;
        MessagesInBlock MessagesInBlock;
        SipBlockTimestamp SipBlockTimestamp;
        BlockChecksum BlockChecksum;
    };


    /// <summary>
    ///  Struct for Consolidated Data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedData {
        PreviousClosePriceDate PreviousClosePriceDate;
        LastParticipantId LastParticipantId;
        LastPrice LastPrice;
        HighPrice HighPrice;
        LowPrice LowPrice;
        TotalVolume TotalVolume;
        Tick Tick;
    };


    /// <summary>
    ///  Struct for Consolidated End Of Day Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedEndOfDaySummaryMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        LastParticipantId LastParticipantId;
        PreviousClosePriceDate PreviousClosePriceDate;
        LastPrice LastPrice;
        HighPrice HighPrice;
        LowPrice LowPrice;
        TotalVolume TotalVolume;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        NumberOfParticipants NumberOfParticipants;
    };


    /// <summary>
    ///  Struct for Consolidated Start Of Day Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedStartOfDaySummaryMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        ParticipantId ParticipantId;
        PreviousClosePriceDate PreviousClosePriceDate;
        PreviousClosePrice PreviousClosePrice;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        NumberOfParticipants NumberOfParticipants;
    };


    /// <summary>
    ///  Struct for Control
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Control {
        ControlMessageType ControlMessageType;
    };


    /// <summary>
    ///  Struct for Corrected Trade
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CorrectedTrade {
        SaleConditions SaleConditions;
        TradePriceLong TradePriceLong;
        TradeVolumeLong TradeVolumeLong;
        SellersSaleDays SellersSaleDays;
        StopStockIndicator StopStockIndicator;
        TradeThroughExemptIndicator TradeThroughExemptIndicator;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PriorDayTradeDateAndTime PriorDayTradeDateAndTime;
    };


    /// <summary>
    ///  Struct for Crossing Session Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossingSessionSummaryMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        CrossingSession1TotalTradesVolume CrossingSession1TotalTradesVolume;
        CrossingSession2DollarValue CrossingSession2DollarValue;
        CrossingSession2TotalTradesVolume CrossingSession2TotalTradesVolume;
    };


    /// <summary>
    ///  Struct for Disaster Recovery Data Center Activation Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DisasterRecoveryDataCenterActivationMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for End Of End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfEndOfDayMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for End Of Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfStartOfDayMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for End Of Test Cycle Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfTestCycleMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Index
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Index {
        IndexMessageType IndexMessageType;
    };


    /// <summary>
    ///  Struct for Index Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IndexMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        IndexSymbol IndexSymbol;
        IndexValue IndexValue;
    };


    /// <summary>
    ///  Struct for Line Integrity Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LineIntegrityMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Long Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongTradeMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        SaleConditions SaleConditions;
        TradePrice TradePrice;
        TradeVolume TradeVolume;
        SellersSaleDays SellersSaleDays;
        StopStockIndicator StopStockIndicator;
        TradeThroughExemptIndicator TradeThroughExemptIndicator;
        TradeReportingFacilityId TradeReportingFacilityId;
        Timestamp2 Timestamp2;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        HeldTradeIndicator HeldTradeIndicator;
        ConsolidatedHighLowLastIndicator ConsolidatedHighLowLastIndicator;
        ParticipantOpenHighLowLastIndicator ParticipantOpenHighLowLastIndicator;
    };


    /// <summary>
    ///  Struct for Market Status
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketStatus {
        MarketStatusMessageType MarketStatusMessageType;
    };


    /// <summary>
    ///  Struct for Market Wide Circuit Breaker Decline Level Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketWideCircuitBreakerDeclineLevelStatusMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        MwcbLevel1 MwcbLevel1;
        MwcbLevel2 MwcbLevel2;
        MwcbLevel3 MwcbLevel3;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Market Wide Circuit Breaker Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketWideCircuitBreakerStatusMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        MarketWideCircuitBreakerLevelIndicator MarketWideCircuitBreakerLevelIndicator;
        Reserved Reserved;
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
        MessageLength MessageLength;
        MessageCategory MessageCategory;
    };


    /// <summary>
    ///  Struct for Original Trade
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OriginalTrade {
        SaleConditions SaleConditions;
        TradePriceLong TradePriceLong;
        TradeVolumeLong TradeVolumeLong;
        SellersSaleDays SellersSaleDays;
        StopStockIndicator StopStockIndicator;
        TradeThroughExemptIndicator TradeThroughExemptIndicator;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PriorDayTradeDateAndTime PriorDayTradeDateAndTime;
    };


    /// <summary>
    ///  Struct for Participant Data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParticipantData {
        PreviousClosePriceDate PreviousClosePriceDate;
        LastParticipantId LastParticipantId;
        LastPrice LastPrice;
        HighPrice HighPrice;
        LowPrice LowPrice;
        TotalVolume TotalVolume;
        Tick Tick;
    };


    /// <summary>
    ///  Struct for Participant End Of Day Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParticipantEndOfDaySummaryMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        ParticipantId ParticipantId;
        PreviousClosePriceDate PreviousClosePriceDate;
        LastPrice LastPrice;
        HighPrice HighPrice;
        LowPrice LowPrice;
        OpenPrice OpenPrice;
        TotalVolume TotalVolume;
        Tick Tick;
    };


    /// <summary>
    ///  Struct for Participant Start Of Day Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParticipantStartOfDaySummaryMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        ParticipantId ParticipantId;
        PreviousClosePriceDate PreviousClosePriceDate;
        PreviousClosePrice PreviousClosePrice;
    };


    /// <summary>
    ///  Struct for Participants
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Participants {
        ParticipantId ParticipantId;
        TradeTotalVolume TradeTotalVolume;
    };


    /// <summary>
    ///  Struct for Prior Day
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriorDay {
        PriorDayMessageType PriorDayMessageType;
    };


    /// <summary>
    ///  Struct for Prior Day Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriorDayTradeCorrectionMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        CorrectedTrade CorrectedTrade;
        TradeReportingFacilityId TradeReportingFacilityId;
        OriginalTrade OriginalTrade;
    };


    /// <summary>
    ///  Struct for Prior Day Trade Date And Time
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriorDayTradeDateAndTime {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Prior Day Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriorDayTradeMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        SaleConditions SaleConditions;
        TradePrice TradePrice;
        TradeVolume TradeVolume;
        SellersSaleDays SellersSaleDays;
        StopStockIndicator StopStockIndicator;
        TradeThroughExemptIndicator TradeThroughExemptIndicator;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        TradeReportingFacilityId TradeReportingFacilityId;
        PriorDayTradeDateAndTime PriorDayTradeDateAndTime;
    };


    /// <summary>
    ///  Struct for Reset Block Sequence Number Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResetBlockSequenceNumberMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Sale Conditions
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SaleConditions {
        Category1 Category1;
        Category2 Category2;
        Category3 Category3;
        Category4 Category4;
    };


    /// <summary>
    ///  Struct for Short Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortTradeMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbolShort SecuritySymbolShort;
        SaleCondition SaleCondition;
        SaleConditionCategory SaleConditionCategory;
        TradePriceShort TradePriceShort;
        TradeVolumeShort TradeVolumeShort;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        ConsolidatedHighLowLastIndicator ConsolidatedHighLowLastIndicator;
        ParticipantOpenHighLowLastIndicator ParticipantOpenHighLowLastIndicator;
    };


    /// <summary>
    ///  Struct for Sip Block Timestamp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SipBlockTimestamp {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfDayMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Start Of End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfEndOfDayMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Start Of Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfStartOfDayMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Start Of Test Cycle Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfTestCycleMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Summary
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Summary {
        SummaryMessageType SummaryMessageType;
    };


    /// <summary>
    ///  Struct for Timestamp 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Timestamp1 {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Timestamp 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Timestamp2 {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Trade
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Trade {
        TradeMessageType TradeMessageType;
    };


    /// <summary>
    ///  Struct for Trade Cancel Error Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelErrorMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        SaleConditions SaleConditions;
        TradePrice TradePrice;
        TradeVolume TradeVolume;
        SellersSaleDays SellersSaleDays;
        StopStockIndicator StopStockIndicator;
        TradeThroughExemptIndicator TradeThroughExemptIndicator;
        TradeReportingFacilityId TradeReportingFacilityId;
        OriginalParticipantReferenceNumberOfOriginalTransactionBeingCancelledOrErrored OriginalParticipantReferenceNumberOfOriginalTransactionBeingCancelledOrErrored;
        Timestamp2 Timestamp2;
        CancelErrorAction CancelErrorAction;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        ConsolidatedData ConsolidatedData;
        ParticipantData ParticipantData;
    };


    /// <summary>
    ///  Struct for Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCorrectionMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        CorrectedTrade CorrectedTrade;
        TradeReportingFacilityId TradeReportingFacilityId;
        Timestamp2 Timestamp2;
        OriginalParticipantReferenceNumber OriginalParticipantReferenceNumber;
        OriginalTrade OriginalTrade;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        ConsolidatedData ConsolidatedData;
        ParticipantData ParticipantData;
    };


    /// <summary>
    ///  Struct for Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingStatusMessage {
        ParticipantId ParticipantId;
        Timestamp1 Timestamp1;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbol SecuritySymbol;
        InstrumentType InstrumentType;
        LastPrice LastPrice;
        HighIndicationPriceUpperLimitPriceBand HighIndicationPriceUpperLimitPriceBand;
        LowIndicationPriceLowerLimitPriceBand LowIndicationPriceLowerLimitPriceBand;
        BuyVolume BuyVolume;
        SellVolume SellVolume;
        SecurityStatus SecurityStatus;
        HaltReason HaltReason;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        LimitUpLimitDownIndicator LimitUpLimitDownIndicator;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
