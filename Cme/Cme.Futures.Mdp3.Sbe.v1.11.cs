namespace Cme.Futures.Mdp3.Sbe.v1.11 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Actual
    /// </summary>
    public unsafe struct Actual {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Aggressor Indicator Values
    /// </summary>
    public enum AggressorIndicator : byte {
        NoValue = 255,
        NotAggressor = 0,
        Aggressor = 1,
    };


    /// <summary>
    ///  Aggressor Side Values
    /// </summary>
    public enum AggressorSide : byte {
        NoValue = 255,
        NoAggressor = 0,
        Buy = 1,
        Sell = 2,
    };


    /// <summary>
    ///  Appl Id
    /// </summary>
    public struct ApplId {
        public short Raw;
    };


    /// <summary>
    ///  Asset
    /// </summary>
    public unsafe struct Asset {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Length
    /// </summary>
    public unsafe struct BlockLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Trade Eligible
    /// </summary>
    public unsafe struct BlockTradeEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cfi Code
    /// </summary>
    public unsafe struct CfiCode {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cleared Volume
    /// </summary>
    public struct ClearedVolume {
        public int Raw;
    };


    /// <summary>
    ///  Collateral Market Price
    /// </summary>
    public struct CollateralMarketPrice {
        public long Raw;
    };


    /// <summary>
    ///  Contract Multiplier
    /// </summary>
    public struct ContractMultiplier {
        public int Raw;
    };


    /// <summary>
    ///  Contract Multiplier Unit
    /// </summary>
    public struct ContractMultiplierUnit {
        public sbyte Raw;
    };


    /// <summary>
    ///  Country Of Issue
    /// </summary>
    public unsafe struct CountryOfIssue {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Coupon Day Count
    /// </summary>
    public unsafe struct CouponDayCount {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Coupon Frequency Period
    /// </summary>
    public unsafe struct CouponFrequencyPeriod {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Coupon Frequency Unit
    /// </summary>
    public unsafe struct CouponFrequencyUnit {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Coupon Rate
    /// </summary>
    public struct CouponRate {
        public long Raw;
    };


    /// <summary>
    ///  Currency
    /// </summary>
    public unsafe struct Currency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Current Chunk
    /// </summary>
    public unsafe struct CurrentChunk {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Product Eligibility
    /// </summary>
    public unsafe struct DailyProductEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Dated Date
    /// </summary>
    public unsafe struct DatedDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Day
    /// </summary>
    public unsafe struct Day {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Decay Quantity
    /// </summary>
    public struct DecayQuantity {
        public int Raw;
    };


    /// <summary>
    ///  Decay Start Date
    /// </summary>
    public unsafe struct DecayStartDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Decaying Product Eligibility
    /// </summary>
    public unsafe struct DecayingProductEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Dirty Price
    /// </summary>
    public struct DirtyPrice {
        public long Raw;
    };


    /// <summary>
    ///  Display Factor
    /// </summary>
    public struct DisplayFactor {
        public long Raw;
    };


    /// <summary>
    ///  Ebf Eligible
    /// </summary>
    public unsafe struct EbfEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Efp Eligible
    /// </summary>
    public unsafe struct EfpEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Efr Eligible
    /// </summary>
    public unsafe struct EfrEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Efs Eligible
    /// </summary>
    public unsafe struct EfsEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Electronic Match Eligible
    /// </summary>
    public unsafe struct ElectronicMatchEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  End Date
    /// </summary>
    public unsafe struct EndDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  End Of Event
    /// </summary>
    public unsafe struct EndOfEvent {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Event Time
    /// </summary>
    public unsafe struct EventTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Type Values
    /// </summary>
    public enum EventType : byte {
        Activation = 5,
        LastEligibleTradeDate = 7,
    };


    /// <summary>
    ///  Final Daily
    /// </summary>
    public unsafe struct FinalDaily {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Financial Instrument Full Name
    /// </summary>
    public unsafe struct FinancialInstrumentFullName {
        public const int Size = 35;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Flow Schedule Type
    /// </summary>
    public struct FlowScheduleType {
        public sbyte Raw;
    };


    /// <summary>
    ///  Gt Orders Eligibility
    /// </summary>
    public unsafe struct GtOrdersEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Halt Reason Values
    /// </summary>
    public enum HaltReason : byte {
        GroupSchedule = 0,
        SurveillanceIntervention = 1,
        MarketEvent = 2,
        InstrumentActivation = 3,
        InstrumentExpiration = 4,
        Unknown = 5,
        RecoveryInProcess = 6,
    };


    /// <summary>
    ///  Heart Bt Int
    /// </summary>
    public struct HeartBtInt {
        public sbyte Raw;
    };


    /// <summary>
    ///  High Limit Price
    /// </summary>
    public struct HighLimitPrice {
        public long Raw;
    };


    /// <summary>
    ///  I Link Indicative Mass Quoting Eligible
    /// </summary>
    public unsafe struct ILinkIndicativeMassQuotingEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Implied Matching Eligibility
    /// </summary>
    public unsafe struct ImpliedMatchingEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Instrument Guid
    /// </summary>
    public unsafe struct InstrumentGuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Intraday
    /// </summary>
    public unsafe struct Intraday {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Inverted Book
    /// </summary>
    public unsafe struct InvertedBook {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Is Ao N Instrument
    /// </summary>
    public unsafe struct IsAoNInstrument {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Is Fractional
    /// </summary>
    public unsafe struct IsFractional {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Issue Date
    /// </summary>
    public unsafe struct IssueDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issuer
    /// </summary>
    public unsafe struct Issuer {
        public const int Size = 25;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Implied Msg
    /// </summary>
    public unsafe struct LastImpliedMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Msg Seq Num Processed
    /// </summary>
    public unsafe struct LastMsgSeqNumProcessed {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Qty
    /// </summary>
    public struct LastQty {
        public int Raw;
    };


    /// <summary>
    ///  Last Quote Msg
    /// </summary>
    public unsafe struct LastQuoteMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Stats Msg
    /// </summary>
    public unsafe struct LastStatsMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Trade Msg
    /// </summary>
    public unsafe struct LastTradeMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Update Time
    /// </summary>
    public unsafe struct LastUpdateTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Volume Msg
    /// </summary>
    public unsafe struct LastVolumeMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Leg Option Delta
    /// </summary>
    public struct LegOptionDelta {
        public int Raw;
    };


    /// <summary>
    ///  Leg Price
    /// </summary>
    public struct LegPrice {
        public long Raw;
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public struct LegRatioQty {
        public sbyte Raw;
    };


    /// <summary>
    ///  Leg Security Id
    /// </summary>
    public struct LegSecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        BuySide = 1,
        SellSide = 2,
    };


    /// <summary>
    ///  Lot Type
    /// </summary>
    public struct LotType {
        public sbyte Raw;
    };


    /// <summary>
    ///  Low Limit Price
    /// </summary>
    public struct LowLimitPrice {
        public long Raw;
    };


    /// <summary>
    ///  Main Fraction
    /// </summary>
    public unsafe struct MainFraction {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Depth
    /// </summary>
    public struct MarketDepth {
        public sbyte Raw;
    };


    /// <summary>
    ///  Market Segment Id
    /// </summary>
    public unsafe struct MarketSegmentId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Set
    /// </summary>
    public unsafe struct MarketSet {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Match Algorithm
    /// </summary>
    public unsafe struct MatchAlgorithm {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Max No Of Substitutions
    /// </summary>
    public unsafe struct MaxNoOfSubstitutions {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Max Price Variation
    /// </summary>
    public struct MaxPriceVariation {
        public long Raw;
    };


    /// <summary>
    ///  Max Trade Vol
    /// </summary>
    public unsafe struct MaxTradeVol {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Display Qty
    /// </summary>
    public struct MdDisplayQty {
        public int Raw;
    };


    /// <summary>
    ///  Md Display Qty Optional
    /// </summary>
    public struct MdDisplayQtyOptional {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Px
    /// </summary>
    public struct MdEntryPx {
        public long Raw;
    };


    /// <summary>
    ///  Md Entry Px Optional
    /// </summary>
    public struct MdEntryPxOptional {
        public long Raw;
    };


    /// <summary>
    ///  Md Entry Size
    /// </summary>
    public struct MdEntrySize {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Size Optional
    /// </summary>
    public struct MdEntrySizeOptional {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Type  Values
    /// </summary>
    public enum MdEntryType : byte {
        Bid = (byte)'0',
        Offer = (byte)'1',
        Trade = (byte)'2',
        OpenPrice = (byte)'4',
        SettlementPrice = (byte)'6',
        TradingSessionHighPrice = (byte)'7',
        TradingSessionLowPrice = (byte)'8',
        Vwap = (byte)'9',
        ClearedVolume = (byte)'B',
        OpenInterest = (byte)'C',
        ImpliedBid = (byte)'E',
        ImpliedOffer = (byte)'F',
        BookReset = (byte)'J',
        SessionHighBid = (byte)'N',
        SessionLowOffer = (byte)'O',
        FixingPrice = (byte)'W',
        ElectronicVolume = (byte)'e',
        ThresholdLimitsandPriceBandVariation = (byte)'g',
    };


    /// <summary>
    ///  Md Entry Type Book Values
    /// </summary>
    public enum MdEntryTypeBook : byte {
        Bid = (byte)'0',
        Offer = (byte)'1',
        ImpliedBid = (byte)'E',
        ImpliedOffer = (byte)'F',
        BookReset = (byte)'J',
    };


    /// <summary>
    ///  Md Entry Type Daily Statistics Values
    /// </summary>
    public enum MdEntryTypeDailyStatistics : byte {
        SettlementPrice = (byte)'6',
        ClearedVolume = (byte)'B',
        OpenInterest = (byte)'C',
        FixingPrice = (byte)'W',
    };


    /// <summary>
    ///  Md Entry Type Statistics Values
    /// </summary>
    public enum MdEntryTypeStatistics : byte {
        OpenPrice = (byte)'4',
        HighTrade = (byte)'7',
        LowTrade = (byte)'8',
        Vwap = (byte)'9',
        HighestBid = (byte)'N',
        LowestOffer = (byte)'O',
    };


    /// <summary>
    ///  Md Feed Type
    /// </summary>
    public unsafe struct MdFeedType {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Order Priority
    /// </summary>
    public unsafe struct MdOrderPriority {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Order Priority Optional
    /// </summary>
    public unsafe struct MdOrderPriorityOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Price Level
    /// </summary>
    public unsafe struct MdPriceLevel {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Price Level Optional
    /// </summary>
    public struct MdPriceLevelOptional {
        public sbyte Raw;
    };


    /// <summary>
    ///  Md Security Trading Status Values
    /// </summary>
    public enum MdSecurityTradingStatus : byte {
        NoValue = 255,
        TradingHalt = 2,
        Close = 4,
        NewPriceIndication = 15,
        ReadyToTrade = 17,
        NotAvailableForTrading = 18,
        UnknownorInvalid = 20,
        PreOpen = 21,
        PreCross = 24,
        Cross = 25,
        PostClose = 26,
        NoChange = 103,
        PrivateWorkup = 201,
        PublicWorkup = 202,
    };


    /// <summary>
    ///  Md Stream Id Values
    /// </summary>
    public enum MdStreamId : byte {
        NoValue = 255,
        MarketPlaceAssistant = 0,
        Globex = 1,
        Refinitiv = 2,
        Icap = 3,
    };


    /// <summary>
    ///  Md Trade Entry Id
    /// </summary>
    public unsafe struct MdTradeEntryId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Update Action Values
    /// </summary>
    public enum MdUpdateAction : byte {
        New = 0,
        Change = 1,
        Delete = 2,
        DeleteThru = 3,
        DeleteFrom = 4,
        Overlay = 5,
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public unsafe struct MessageSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Size
    /// </summary>
    public unsafe struct MessageSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Min Cab Price
    /// </summary>
    public struct MinCabPrice {
        public long Raw;
    };


    /// <summary>
    ///  Min Lot Size
    /// </summary>
    public struct MinLotSize {
        public int Raw;
    };


    /// <summary>
    ///  Min Price Increment
    /// </summary>
    public struct MinPriceIncrement {
        public long Raw;
    };


    /// <summary>
    ///  Min Price Increment Amount
    /// </summary>
    public struct MinPriceIncrementAmount {
        public long Raw;
    };


    /// <summary>
    ///  Min Price Increment Optional
    /// </summary>
    public struct MinPriceIncrementOptional {
        public long Raw;
    };


    /// <summary>
    ///  Min Trade Vol
    /// </summary>
    public unsafe struct MinTradeVol {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Money Or Par Values
    /// </summary>
    public enum MoneyOrPar : byte {
        NoValue = 255,
        Money = 1,
        Par = 2,
    };


    /// <summary>
    ///  Month
    /// </summary>
    public unsafe struct Month {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Negative Price Outright Eligible
    /// </summary>
    public unsafe struct NegativePriceOutrightEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Negative Strike Eligible
    /// </summary>
    public unsafe struct NegativeStrikeEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  No Chunks
    /// </summary>
    public unsafe struct NoChunks {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Null Value
    /// </summary>
    public unsafe struct NullValue {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Num In Group
    /// </summary>
    public unsafe struct NumInGroup {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Orders
    /// </summary>
    public struct NumberOfOrders {
        public int Raw;
    };


    /// <summary>
    ///  Number Of Orders Optional
    /// </summary>
    public struct NumberOfOrdersOptional {
        public int Raw;
    };


    /// <summary>
    ///  Open Close Settl Flag Values
    /// </summary>
    public enum OpenCloseSettlFlag : byte {
        NoValue = 255,
        DailyOpenPrice = 0,
        IndicativeOpeningPrice = 5,
        IntradayVwap = 100,
        RepoAverage830Am = 101,
        RepoAverage10Am = 102,
        PrevSessionRepoAverage10Am = 103,
    };


    /// <summary>
    ///  Open Interest Qty
    /// </summary>
    public struct OpenInterestQty {
        public int Raw;
    };


    /// <summary>
    ///  Order Cross Eligible
    /// </summary>
    public unsafe struct OrderCrossEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public unsafe struct OrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Id Optional
    /// </summary>
    public unsafe struct OrderIdOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Qty
    /// </summary>
    public struct OrderQty {
        public int Raw;
    };


    /// <summary>
    ///  Order Update Action Values
    /// </summary>
    public enum OrderUpdateAction : byte {
        New = 0,
        Update = 1,
        Delete = 2,
    };


    /// <summary>
    ///  Original Contract Size
    /// </summary>
    public struct OriginalContractSize {
        public int Raw;
    };


    /// <summary>
    ///  Otc Eligible
    /// </summary>
    public unsafe struct OtcEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 1
    /// </summary>
    public unsafe struct Padding1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 2
    /// </summary>
    public unsafe struct Padding2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 3
    /// </summary>
    public unsafe struct Padding3 {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 4
    /// </summary>
    public unsafe struct Padding4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 5
    /// </summary>
    public unsafe struct Padding5 {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 6
    /// </summary>
    public unsafe struct Padding6 {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 7
    /// </summary>
    public unsafe struct Padding7 {
        public const int Size = 7;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Par Value
    /// </summary>
    public struct ParValue {
        public long Raw;
    };


    /// <summary>
    ///  Party Role Clearing Org
    /// </summary>
    public unsafe struct PartyRoleClearingOrg {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Display Format
    /// </summary>
    public unsafe struct PriceDisplayFormat {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Quote Method
    /// </summary>
    public unsafe struct PriceQuoteMethod {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Ratio
    /// </summary>
    public struct PriceRatio {
        public long Raw;
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = 0,
        Call = 1,
    };


    /// <summary>
    ///  Quote Req Id
    /// </summary>
    public unsafe struct QuoteReqId {
        public const int Size = 23;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Type
    /// </summary>
    public struct QuoteType {
        public sbyte Raw;
    };


    /// <summary>
    ///  Recovery Msg
    /// </summary>
    public unsafe struct RecoveryMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reference Id
    /// </summary>
    public unsafe struct ReferenceId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Related Security Id
    /// </summary>
    public struct RelatedSecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Related Symbol
    /// </summary>
    public unsafe struct RelatedSymbol {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Repo Sub Type Values
    /// </summary>
    public enum RepoSubType : byte {
        Special = 0,
        Gc = 1,
        GcForDbv = 2,
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 8
    /// </summary>
    public unsafe struct Reserved8 {
        public const int Size = 8;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Bits
    /// </summary>
    public unsafe struct ReservedBits {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rfq Cross Eligible
    /// </summary>
    public unsafe struct RfqCrossEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Risk Set
    /// </summary>
    public unsafe struct RiskSet {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rounded
    /// </summary>
    public unsafe struct Rounded {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rpt Seq
    /// </summary>
    public unsafe struct RptSeq {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public unsafe struct SchemaId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Alt Id
    /// </summary>
    public unsafe struct SecurityAltId {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Alt Id Source Values
    /// </summary>
    public enum SecurityAltIdSource : byte {
        NoValue = 255,
        Cusip = 1,
        Isin = 4,
    };


    /// <summary>
    ///  Security Exchange
    /// </summary>
    public unsafe struct SecurityExchange {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Group
    /// </summary>
    public unsafe struct SecurityGroup {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public struct SecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Security Id Optional
    /// </summary>
    public struct SecurityIdOptional {
        public int Raw;
    };


    /// <summary>
    ///  Security Sub Type
    /// </summary>
    public unsafe struct SecuritySubType {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Trading Event Values
    /// </summary>
    public enum SecurityTradingEvent : byte {
        NoEvent = 0,
        NoCancel = 1,
        ResetStatistics = 4,
        ImpliedMatchingOn = 5,
        ImpliedMatchingOff = 6,
        EndOfWorkup = 7,
    };


    /// <summary>
    ///  Security Trading Status Values
    /// </summary>
    public enum SecurityTradingStatus : byte {
        NoValue = 255,
        TradingHalt = 2,
        Close = 4,
        NewPriceIndication = 15,
        ReadyToTrade = 17,
        NotAvailableForTrading = 18,
        UnknownorInvalid = 20,
        PreOpen = 21,
        PreCross = 24,
        Cross = 25,
        PostClose = 26,
        NoChange = 103,
        PrivateWorkup = 201,
        PublicWorkup = 202,
    };


    /// <summary>
    ///  Security Type
    /// </summary>
    public unsafe struct SecurityType {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Update Action Values
    /// </summary>
    public enum SecurityUpdateAction : byte {
        Add = (byte)'A',
        Delete = (byte)'D',
        Modify = (byte)'M',
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public unsafe struct SendingTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settl Currency
    /// </summary>
    public unsafe struct SettlCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = 1,
        Sell = 2,
    };


    /// <summary>
    ///  Side Optional
    /// </summary>
    public struct SideOptional {
        public sbyte Raw;
    };


    /// <summary>
    ///  Start Date
    /// </summary>
    public unsafe struct StartDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Currency
    /// </summary>
    public unsafe struct StrikeCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public long Raw;
    };


    /// <summary>
    ///  Sub Fraction
    /// </summary>
    public unsafe struct SubFraction {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : ushort {
        ChannelReset = 4,
        AdminHeartbeat = 12,
        AdminLogin = 15,
        AdminLogout = 16,
        SecurityStatus = 30,
        MdIncrementalRefreshVolume = 37,
        QuoteRequest = 39,
        MdIncrementalRefreshBook = 46,
        MdIncrementalRefreshOrderBook = 47,
        MdIncrementalRefreshTradeSummary = 48,
        MdIncrementalRefreshDailyStatistics = 49,
        MdIncrementalRefreshLimitsBanding = 50,
        MdIncrementalRefreshSessionStatistics = 51,
        SnapshotFullRefresh = 52,
        SnapshotFullRefreshOrderBook = 53,
        MdInstrumentDefinitionFuture = 54,
        MdInstrumentDefinitionOption = 55,
        MdInstrumentDefinitionSpread = 56,
        MdInstrumentDefinitionFixedIncome = 57,
        MdInstrumentDefinitionRepo = 58,
        SnapshotRefreshTopOrders = 59,
        SecurityStatusWorkup = 60,
        SnapshotFullRefreshTcp = 61,
        CollateralMarketValue = 62,
    };


    /// <summary>
    ///  Term Code
    /// </summary>
    public unsafe struct TermCode {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Termination Type
    /// </summary>
    public unsafe struct TerminationType {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Text
    /// </summary>
    public unsafe struct Text {
        public const int Size = 180;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tick Rule
    /// </summary>
    public struct TickRule {
        public sbyte Raw;
    };


    /// <summary>
    ///  Tot Num Reports
    /// </summary>
    public unsafe struct TotNumReports {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tot Num Reports Optional
    /// </summary>
    public unsafe struct TotNumReportsOptional {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Date
    /// </summary>
    public unsafe struct TradeDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Link Id
    /// </summary>
    public unsafe struct TradeLinkId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tradeable Size
    /// </summary>
    public struct TradeableSize {
        public int Raw;
    };


    /// <summary>
    ///  Trading Reference Date
    /// </summary>
    public unsafe struct TradingReferenceDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Reference Price
    /// </summary>
    public struct TradingReferencePrice {
        public long Raw;
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public unsafe struct TransactTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Triangulation Eligible
    /// </summary>
    public unsafe struct TriangulationEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Underlying Instrument Guid
    /// </summary>
    public unsafe struct UnderlyingInstrumentGuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Product
    /// </summary>
    public unsafe struct UnderlyingProduct {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Product Optional
    /// </summary>
    public unsafe struct UnderlyingProductOptional {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Security Alt Id
    /// </summary>
    public unsafe struct UnderlyingSecurityAltId {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Security Alt Id Source Values
    /// </summary>
    public enum UnderlyingSecurityAltIdSource : byte {
        NoValue = 255,
        Cusip = 1,
        Isin = 4,
    };


    /// <summary>
    ///  Underlying Security Id
    /// </summary>
    public struct UnderlyingSecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Measure
    /// </summary>
    public unsafe struct UnitOfMeasure {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Measure Qty
    /// </summary>
    public struct UnitOfMeasureQty {
        public long Raw;
    };


    /// <summary>
    ///  User Defined Instrument
    /// </summary>
    public unsafe struct UserDefinedInstrument {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Variable Cab Eligible
    /// </summary>
    public unsafe struct VariableCabEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variable Product Eligibility
    /// </summary>
    public unsafe struct VariableProductEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Volatility Quoted Option
    /// </summary>
    public unsafe struct VolatilityQuotedOption {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Week
    /// </summary>
    public unsafe struct Week {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Workup Trading Status Values
    /// </summary>
    public enum WorkupTradingStatus : byte {
        ReadyToTrade = 17,
        NotAvailableForTrading = 18,
        PrivateWorkup = 201,
        PublicWorkup = 202,
    };


    /// <summary>
    ///  Year
    /// </summary>
    public unsafe struct Year {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Zero Price Outright Eligible
    /// </summary>
    public unsafe struct ZeroPriceOutrightEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Admin Login 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdminLogin15 {
        HeartBtInt HeartBtInt;
    };


    /// <summary>
    ///  Struct for Admin Logout 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdminLogout16 {
        Text Text;
    };


    /// <summary>
    ///  Struct for Binary Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BinaryPacketHeader {
        MessageSequenceNumber MessageSequenceNumber;
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Channel Reset 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChannelReset4 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
    };


    /// <summary>
    ///  Struct for Channel Reset Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChannelResetGroup {
        ApplId ApplId;
    };


    /// <summary>
    ///  Struct for Channel Reset Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChannelResetGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Collateral Market Value 62
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CollateralMarketValue62 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Collateral Market Value Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CollateralMarketValueGroup {
        UnderlyingSecurityAltId UnderlyingSecurityAltId;
        UnderlyingSecurityAltIdSource UnderlyingSecurityAltIdSource;
        CollateralMarketPrice CollateralMarketPrice;
        DirtyPrice DirtyPrice;
        UnderlyingInstrumentGuid UnderlyingInstrumentGuid;
        MdStreamId MdStreamId;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Collateral Market Value Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CollateralMarketValueGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Events Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EventsGroup {
        EventType EventType;
        EventTime EventTime;
    };


    /// <summary>
    ///  Struct for Events Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EventsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Group Size
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GroupSize {
        BlockLength BlockLength;
        NumInGroup NumInGroup;
    };


    /// <summary>
    ///  Struct for Group Size 8 Byte
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GroupSize8Byte {
        BlockLength BlockLength;
        Padding5 Padding5;
        NumInGroup NumInGroup;
    };


    /// <summary>
    ///  Struct for Inst Attrib Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribGroup {
        InstAttribValue InstAttribValue;
    };


    /// <summary>
    ///  Struct for Inst Attrib Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Inst Attrib Value
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribValue {
        Reserved8 Reserved8;
        IsAoNInstrument IsAoNInstrument;
        InvertedBook InvertedBook;
        VariableCabEligible VariableCabEligible;
        TriangulationEligible TriangulationEligible;
        ImpliedMatchingEligibility ImpliedMatchingEligibility;
        GtOrdersEligibility GtOrdersEligibility;
        DailyProductEligibility DailyProductEligibility;
        VariableProductEligibility VariableProductEligibility;
        DecayingProductEligibility DecayingProductEligibility;
        ZeroPriceOutrightEligible ZeroPriceOutrightEligible;
        RfqCrossEligible RfqCrossEligible;
        VolatilityQuotedOption VolatilityQuotedOption;
        IsFractional IsFractional;
        NegativePriceOutrightEligible NegativePriceOutrightEligible;
        NegativeStrikeEligible NegativeStrikeEligible;
        ILinkIndicativeMassQuotingEligible ILinkIndicativeMassQuotingEligible;
        OtcEligible OtcEligible;
        EfrEligible EfrEligible;
        EfsEligible EfsEligible;
        EbfEligible EbfEligible;
        EfpEligible EfpEligible;
        BlockTradeEligible BlockTradeEligible;
        OrderCrossEligible OrderCrossEligible;
        ElectronicMatchEligible ElectronicMatchEligible;
    };


    /// <summary>
    ///  Struct for Lot Type Rules Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LotTypeRulesGroup {
        LotType LotType;
        MinLotSize MinLotSize;
    };


    /// <summary>
    ///  Struct for Lot Type Rules Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LotTypeRulesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Feed Types Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDFeedTypesGroup {
        MdFeedType MdFeedType;
        MarketDepth MarketDepth;
    };


    /// <summary>
    ///  Struct for M D Feed Types Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDFeedTypesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Book Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshBookGroup {
        MdEntryPxOptional MdEntryPxOptional;
        MdEntrySizeOptional MdEntrySizeOptional;
        SecurityId SecurityId;
        RptSeq RptSeq;
        NumberOfOrdersOptional NumberOfOrdersOptional;
        MdPriceLevel MdPriceLevel;
        MdUpdateAction MdUpdateAction;
        MdEntryTypeBook MdEntryTypeBook;
        TradeableSize TradeableSize;
        Padding1 Padding1;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Book Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshBookGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Book Order Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshBookOrderGroup {
        OrderId OrderId;
        MdOrderPriorityOptional MdOrderPriorityOptional;
        MdDisplayQtyOptional MdDisplayQtyOptional;
        ReferenceId ReferenceId;
        OrderUpdateAction OrderUpdateAction;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Book Order Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshBookOrderGroups {
        GroupSize8Byte GroupSize8Byte;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Daily Statistics Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshDailyStatisticsGroup {
        MdEntryPxOptional MdEntryPxOptional;
        MdEntrySizeOptional MdEntrySizeOptional;
        SecurityId SecurityId;
        RptSeq RptSeq;
        TradingReferenceDate TradingReferenceDate;
        SettlPriceType SettlPriceType;
        MdUpdateAction MdUpdateAction;
        MdEntryTypeDailyStatistics MdEntryTypeDailyStatistics;
        Padding7 Padding7;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Daily Statistics Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshDailyStatisticsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Limits Banding Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshLimitsBandingGroup {
        HighLimitPrice HighLimitPrice;
        LowLimitPrice LowLimitPrice;
        MaxPriceVariation MaxPriceVariation;
        SecurityId SecurityId;
        RptSeq RptSeq;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Limits Banding Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshLimitsBandingGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Order Book Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshOrderBookGroup {
        OrderIdOptional OrderIdOptional;
        MdOrderPriorityOptional MdOrderPriorityOptional;
        MdEntryPxOptional MdEntryPxOptional;
        MdDisplayQtyOptional MdDisplayQtyOptional;
        SecurityId SecurityId;
        MdUpdateAction MdUpdateAction;
        MdEntryTypeBook MdEntryTypeBook;
        Padding6 Padding6;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Order Book Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshOrderBookGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Session Statistics Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshSessionStatisticsGroup {
        MdEntryPx MdEntryPx;
        SecurityId SecurityId;
        RptSeq RptSeq;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        MdUpdateAction MdUpdateAction;
        MdEntryTypeStatistics MdEntryTypeStatistics;
        MdEntrySizeOptional MdEntrySizeOptional;
        Padding1 Padding1;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Session Statistics Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshSessionStatisticsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Trade Summary Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshTradeSummaryGroup {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        NumberOfOrders NumberOfOrders;
        AggressorSide AggressorSide;
        MdUpdateAction MdUpdateAction;
        MdTradeEntryId MdTradeEntryId;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Trade Summary Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshTradeSummaryGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Trade Summary Order Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshTradeSummaryOrderGroup {
        OrderId OrderId;
        LastQty LastQty;
        Padding4 Padding4;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Trade Summary Order Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshTradeSummaryOrderGroups {
        GroupSize8Byte GroupSize8Byte;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Volume Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshVolumeGroup {
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        MdUpdateAction MdUpdateAction;
        Padding3 Padding3;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Volume Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshVolumeGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Instrument Definition Spread Leg Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDInstrumentDefinitionSpreadLegGroup {
        LegSecurityId LegSecurityId;
        LegSide LegSide;
        LegRatioQty LegRatioQty;
        LegPrice LegPrice;
        LegOptionDelta LegOptionDelta;
    };


    /// <summary>
    ///  Struct for M D Instrument Definition Spread Leg Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDInstrumentDefinitionSpreadLegGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Match Event Indicator
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MatchEventIndicator {
        EndOfEvent EndOfEvent;
        Reserved Reserved;
        RecoveryMsg RecoveryMsg;
        LastImpliedMsg LastImpliedMsg;
        LastStatsMsg LastStatsMsg;
        LastQuoteMsg LastQuoteMsg;
        LastVolumeMsg LastVolumeMsg;
        LastTradeMsg LastTradeMsg;
    };


    /// <summary>
    ///  Struct for Maturity Month Year
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MaturityMonthYear {
        Year Year;
        Month Month;
        Day Day;
        Week Week;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Daily Statistics 49
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshDailyStatistics49 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Limits Banding 50
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshLimitsBanding50 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Order Book 47
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshOrderBook47 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Session Statistics 51
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshSessionStatistics51 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Volume 37
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshVolume37 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageSize MessageSize;
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        BinaryPacketHeader BinaryPacketHeader;
    };


    /// <summary>
    ///  Struct for Quote Request 39
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteRequest39 {
        TransactTime TransactTime;
        QuoteReqId QuoteReqId;
        MatchEventIndicator MatchEventIndicator;
        Padding3 Padding3;
    };


    /// <summary>
    ///  Struct for Related Instruments Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedInstrumentsGroup {
        RelatedSecurityId RelatedSecurityId;
        RelatedSymbol RelatedSymbol;
    };


    /// <summary>
    ///  Struct for Related Instruments Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedInstrumentsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Related Sym Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroup {
        Symbol Symbol;
        SecurityId SecurityId;
        OrderQty OrderQty;
        QuoteType QuoteType;
        SideOptional SideOptional;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Related Sym Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Security Status 30
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatus30 {
        TransactTime TransactTime;
        SecurityGroup SecurityGroup;
        Asset Asset;
        SecurityIdOptional SecurityIdOptional;
        TradeDate TradeDate;
        MatchEventIndicator MatchEventIndicator;
        SecurityTradingStatus SecurityTradingStatus;
        HaltReason HaltReason;
        SecurityTradingEvent SecurityTradingEvent;
    };


    /// <summary>
    ///  Struct for Security Status Workup 60
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatusWorkup60 {
        TransactTime TransactTime;
        MdEntryPxOptional MdEntryPxOptional;
        SecurityId SecurityId;
        MatchEventIndicator MatchEventIndicator;
        TradeDate TradeDate;
        TradeLinkId TradeLinkId;
        WorkupTradingStatus WorkupTradingStatus;
        HaltReason HaltReason;
        SecurityTradingEvent SecurityTradingEvent;
    };


    /// <summary>
    ///  Struct for Security Status Workup Order Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatusWorkupOrderGroup {
        OrderId OrderId;
        Side Side;
        AggressorIndicator AggressorIndicator;
    };


    /// <summary>
    ///  Struct for Security Status Workup Order Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatusWorkupOrderGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Settl Price Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlPriceType {
        NullValue NullValue;
        ReservedBits ReservedBits;
        Intraday Intraday;
        Rounded Rounded;
        Actual Actual;
        FinalDaily FinalDaily;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh 52
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefresh52 {
        LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        TotNumReports TotNumReports;
        SecurityId SecurityId;
        RptSeq RptSeq;
        TransactTime TransactTime;
        LastUpdateTime LastUpdateTime;
        TradeDate TradeDate;
        MdSecurityTradingStatus MdSecurityTradingStatus;
        HighLimitPrice HighLimitPrice;
        LowLimitPrice LowLimitPrice;
        MaxPriceVariation MaxPriceVariation;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshGroup {
        MdEntryPxOptional MdEntryPxOptional;
        MdEntrySizeOptional MdEntrySizeOptional;
        NumberOfOrdersOptional NumberOfOrdersOptional;
        MdPriceLevelOptional MdPriceLevelOptional;
        TradingReferenceDate TradingReferenceDate;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        SettlPriceType SettlPriceType;
        MdEntryType MdEntryType;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Order Book 53
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshOrderBook53 {
        LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        TotNumReports TotNumReports;
        SecurityId SecurityId;
        NoChunks NoChunks;
        CurrentChunk CurrentChunk;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Order Book Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshOrderBookGroup {
        OrderId OrderId;
        MdOrderPriorityOptional MdOrderPriorityOptional;
        MdEntryPx MdEntryPx;
        MdDisplayQty MdDisplayQty;
        MdEntryTypeBook MdEntryTypeBook;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Order Book Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshOrderBookGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Tc P 61
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshTcP61 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        SecurityId SecurityId;
        HighLimitPrice HighLimitPrice;
        LowLimitPrice LowLimitPrice;
        MaxPriceVariation MaxPriceVariation;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Tcp Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshTcpGroup {
        MdEntryPxOptional MdEntryPxOptional;
        MdEntrySizeOptional MdEntrySizeOptional;
        TradeableSize TradeableSize;
        NumberOfOrdersOptional NumberOfOrdersOptional;
        MdPriceLevelOptional MdPriceLevelOptional;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        MdEntryType MdEntryType;
        TradingReferenceDate TradingReferenceDate;
        SettlPriceType SettlPriceType;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Tcp Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshTcpGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Snapshot Refresh Top Orders 59
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotRefreshTopOrders59 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        SecurityId SecurityId;
    };


    /// <summary>
    ///  Struct for Snapshot Refresh Top Orders Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotRefreshTopOrdersGroup {
        OrderId OrderId;
        MdOrderPriority MdOrderPriority;
        MdEntryPx MdEntryPx;
        MdDisplayQty MdDisplayQty;
        MdEntryTypeBook MdEntryTypeBook;
    };


    /// <summary>
    ///  Struct for Snapshot Refresh Top Orders Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotRefreshTopOrdersGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Underlyings Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingsGroup {
        UnderlyingSecurityId UnderlyingSecurityId;
        UnderlyingSymbol UnderlyingSymbol;
    };


    /// <summary>
    ///  Struct for Underlyings Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingsGroups {
        GroupSize GroupSize;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
