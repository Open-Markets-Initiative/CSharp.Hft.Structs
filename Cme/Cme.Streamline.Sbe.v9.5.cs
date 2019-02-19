namespace MyNamespace {

    #region Methods
    ///////////////////////////////////////////////////////////////////////

    public static class Endian {

        /// <summary>
        ///  Swap byte order for 2 byte unsigned short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ushort value)
            => value << 8 | value >> 8 
        
        /// <summary>
        ///  Swap byte order in unsigned integer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(uint value)
            => (value & 0x000000FF) << 24 |
               (value & 0x0000FF00) << 8  |
               (value & 0x00FF0000) >> 8  |
               (value & 0xFF000000) >> 24;
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ulong value)
            => (0x00000000000000FF) & (value >> 56) |
               (0x000000000000FF00) & (value >> 40) |
               (0x0000000000FF0000) & (value >> 24) |
               (0x00000000FF000000) & (value >> 8)  |
               (0x000000FF00000000) & (value << 8)  |
               (0x0000FF0000000000) & (value << 24) |
               (0x00FF000000000000) & (value << 40) |
               (0xFF00000000000000) & (value << 56);
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Accrual Days
    /// </summary>
    public struct AccrualDays {
        public uint Raw;
    };


    /// <summary>
    ///  Accrued Coupons
    /// </summary>
    public struct AccruedCoupons {
        public long Raw;
    };


    /// <summary>
    ///  Actual
    /// </summary>
    public unsafe struct Actual {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Aggressor Side Values
    /// </summary>
    public enum AggressorSide : byte {
        AggressorSide = "0",
        AggressorSide = "1",
        AggressorSide = "2",
    };


    /// <summary>
    ///  Appl Id
    /// </summary>
    public struct ApplId {
        public ushort Raw;
    };


    /// <summary>
    ///  Batch Total Messages
    /// </summary>
    public struct BatchTotalMessages {
        public ushort Raw;
    };


    /// <summary>
    ///  Block Length
    /// </summary>
    public struct BlockLength {
        public ushort Raw;
    };


    /// <summary>
    ///  Cal Fut Px
    /// </summary>
    public struct CalFutPx {
        public long Raw;
    };


    /// <summary>
    ///  Coupon Rate
    /// </summary>
    public struct CouponRate {
        public int Raw;
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
    ///  Daily Incremental Eris Pai
    /// </summary>
    public struct DailyIncrementalErisPai {
        public long Raw;
    };


    /// <summary>
    ///  Day
    /// </summary>
    public struct Day {
        public byte Raw;
    };


    /// <summary>
    ///  DV 01
    /// </summary>
    public struct Dv01 {
        public long Raw;
    };


    /// <summary>
    ///  End Of Event
    /// </summary>
    public unsafe struct EndOfEvent {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Eris Pai
    /// </summary>
    public struct ErisPai {
        public long Raw;
    };


    /// <summary>
    ///  Event Time
    /// </summary>
    public struct EventTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Event Type
    /// </summary>
    public struct EventType {
        public byte Raw;
    };


    /// <summary>
    ///  Fair Coupon Pct
    /// </summary>
    public struct FairCouponPct {
        public long Raw;
    };


    /// <summary>
    ///  Fed Funds Date
    /// </summary>
    public struct FedFundsDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Fed Funds Rate
    /// </summary>
    public struct FedFundsRate {
        public long Raw;
    };


    /// <summary>
    ///  Final Daily
    /// </summary>
    public unsafe struct FinalDaily {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Final Settlement Futures Price
    /// </summary>
    public struct FinalSettlementFuturesPrice {
        public long Raw;
    };


    /// <summary>
    ///  Fixed Npv
    /// </summary>
    public struct FixedNpv {
        public long Raw;
    };


    /// <summary>
    ///  Fixed Payment
    /// </summary>
    public struct FixedPayment {
        public long Raw;
    };


    /// <summary>
    ///  Float Npv
    /// </summary>
    public struct FloatNpv {
        public long Raw;
    };


    /// <summary>
    ///  Floating Payment
    /// </summary>
    public struct FloatingPayment {
        public long Raw;
    };


    /// <summary>
    ///  Headline
    /// </summary>
    public unsafe struct Headline {
        public const int Size = 50;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Heart Bt Int
    /// </summary>
    public struct HeartBtInt {
        public sbyte Raw;
    };


    /// <summary>
    ///  Inst Attrib Type
    /// </summary>
    public struct InstAttribType {
        public byte Raw;
    };


    /// <summary>
    ///  Inst Attrib Value
    /// </summary>
    public unsafe struct InstAttribValue {
        public const int Size = 100;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Interpolation Factor
    /// </summary>
    public struct InterpolationFactor {
        public long Raw;
    };


    /// <summary>
    ///  Last Implied Msg
    /// </summary>
    public unsafe struct LastImpliedMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  Last Volume Msg
    /// </summary>
    public unsafe struct LastVolumeMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Leg Benchmark Curve Name
    /// </summary>
    public unsafe struct LegBenchmarkCurveName {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Contract Multiplier
    /// </summary>
    public struct LegContractMultiplier {
        public long Raw;
    };


    /// <summary>
    ///  Leg Credit Rating
    /// </summary>
    public unsafe struct LegCreditRating {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Currency
    /// </summary>
    public unsafe struct LegCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Date Offset
    /// </summary>
    public struct LegDateOffset {
        public sbyte Raw;
    };


    /// <summary>
    ///  Leg Pay Frequencey
    /// </summary>
    public unsafe struct LegPayFrequencey {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Purchase Rate
    /// </summary>
    public struct LegPurchaseRate {
        public long Raw;
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public struct LegRatioQty {
        public int Raw;
    };


    /// <summary>
    ///  Leg Ref Id
    /// </summary>
    public unsafe struct LegRefId {
        public const int Size = 17;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Security Group
    /// </summary>
    public unsafe struct LegSecurityGroup {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Security Type
    /// </summary>
    public unsafe struct LegSecurityType {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Side
    /// </summary>
    public struct LegSide {
        public byte Raw;
    };


    /// <summary>
    ///  Leg Symbol
    /// </summary>
    public unsafe struct LegSymbol {
        public const int Size = 50;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Depth
    /// </summary>
    public struct MarketDepth {
        public byte Raw;
    };


    /// <summary>
    ///  Market Sector
    /// </summary>
    public unsafe struct MarketSector {
        public const int Size = 26;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public struct MaturityDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Md Entry Code Values
    /// </summary>
    public enum MdEntryCode : byte {
        MdEntryCode = "1",
        MdEntryCode = "2",
        MdEntryCode = "3",
        MdEntryCode = "4",
        MdEntryCode = "5",
    };


    /// <summary>
    ///  Md Entry Date
    /// </summary>
    public struct MdEntryDate {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Id
    /// </summary>
    public unsafe struct MdEntryId {
        public const int Size = 26;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Entry Position No
    /// </summary>
    public struct MdEntryPositionNo {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Px
    /// </summary>
    public struct MdEntryPx {
        public long Raw;
    };


    /// <summary>
    ///  Md Entry Size
    /// </summary>
    public struct MdEntrySize {
        public ulong Raw;
    };


    /// <summary>
    ///  Md Entry Time
    /// </summary>
    public struct MdEntryTime {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Type
    /// </summary>
    public unsafe struct MdEntryType {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Feed Type
    /// </summary>
    public unsafe struct MdFeedType {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Update Action Values
    /// </summary>
    public enum MdUpdateAction : byte {
        MdUpdateAction = "0",
        MdUpdateAction = "1",
        MdUpdateAction = "2",
        MdUpdateAction = "3",
        MdUpdateAction = "4",
        MdUpdateAction = "5",
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public struct MessageSequenceNumber {
        public uint Raw;
    };


    /// <summary>
    ///  Message Size
    /// </summary>
    public struct MessageSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Min Price Increment
    /// </summary>
    public struct MinPriceIncrement {
        public long Raw;
    };


    /// <summary>
    ///  Month
    /// </summary>
    public struct Month {
        public byte Raw;
    };


    /// <summary>
    ///  Net Chg Prev Day
    /// </summary>
    public struct NetChgPrevDay {
        public long Raw;
    };


    /// <summary>
    ///  Net Pct Chg
    /// </summary>
    public struct NetPctChg {
        public long Raw;
    };


    /// <summary>
    ///  Next Fixed Payment Amount
    /// </summary>
    public struct NextFixedPaymentAmount {
        public long Raw;
    };


    /// <summary>
    ///  Next Fixed Payment Date
    /// </summary>
    public struct NextFixedPaymentDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Next Floating Payment Amount
    /// </summary>
    public struct NextFloatingPaymentAmount {
        public long Raw;
    };


    /// <summary>
    ///  Next Floating Payment Date
    /// </summary>
    public struct NextFloatingPaymentDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Nominal
    /// </summary>
    public struct Nominal {
        public ulong Raw;
    };


    /// <summary>
    ///  Notional Percentage Outstanding
    /// </summary>
    public struct NotionalPercentageOutstanding {
        public int Raw;
    };


    /// <summary>
    ///  Npv
    /// </summary>
    public struct Npv {
        public long Raw;
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
    public struct NumInGroup {
        public byte Raw;
    };


    /// <summary>
    ///  Number Of Orders
    /// </summary>
    public struct NumberOfOrders {
        public int Raw;
    };


    /// <summary>
    ///  Open Close Settl Flag
    /// </summary>
    public struct OpenCloseSettlFlag {
        public byte Raw;
    };


    /// <summary>
    ///  Orig Time
    /// </summary>
    public struct OrigTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Percent Trading
    /// </summary>
    public struct PercentTrading {
        public long Raw;
    };


    /// <summary>
    ///  Previous Eris Pai
    /// </summary>
    public struct PreviousErisPai {
        public long Raw;
    };


    /// <summary>
    ///  Previous Fixing Date
    /// </summary>
    public struct PreviousFixingDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Previous Fixing Rate
    /// </summary>
    public struct PreviousFixingRate {
        public long Raw;
    };


    /// <summary>
    ///  Price Type
    /// </summary>
    public struct PriceType {
        public ushort Raw;
    };


    /// <summary>
    ///  Product
    /// </summary>
    public struct Product {
        public sbyte Raw;
    };


    /// <summary>
    ///  Product Complex
    /// </summary>
    public unsafe struct ProductComplex {
        public const int Size = 26;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Put Or Call
    /// </summary>
    public struct PutOrCall {
        public byte Raw;
    };


    /// <summary>
    ///  PV 01
    /// </summary>
    public struct Pv01 {
        public long Raw;
    };


    /// <summary>
    ///  Quote Condition
    /// </summary>
    public unsafe struct QuoteCondition {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Req Id
    /// </summary>
    public unsafe struct QuoteReqId {
        public const int Size = 26;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rate Descriptor
    /// </summary>
    public unsafe struct RateDescriptor {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rate Type
    /// </summary>
    public unsafe struct RateType {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
        public const int Size = 50;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Bits
    /// </summary>
    public unsafe struct ReservedBits {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Restructuring Type
    /// </summary>
    public unsafe struct RestructuringType {
        public const int Size = 2;

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
    public struct RptSeq {
        public uint Raw;
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public struct SchemaId {
        public ushort Raw;
    };


    /// <summary>
    ///  Sector Group
    /// </summary>
    public unsafe struct SectorGroup {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sector Sub Group
    /// </summary>
    public unsafe struct SectorSubGroup {
        public const int Size = 26;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Alt Id
    /// </summary>
    public unsafe struct SecurityAltId {
        public const int Size = 26;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Alt Id Source
    /// </summary>
    public unsafe struct SecurityAltIdSource {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Description
    /// </summary>
    public unsafe struct SecurityDescription {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
        public const int Size = 12;

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
        public ulong Raw;
    };


    /// <summary>
    ///  Security Sub Type
    /// </summary>
    public unsafe struct SecuritySubType {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Type
    /// </summary>
    public unsafe struct SecurityType {
        public const int Size = 4;

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
        SecurityUpdateAction = (byte)'A',
        SecurityUpdateAction = (byte)'D',
        SecurityUpdateAction = (byte)'M',
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public struct SendingTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Seniority
    /// </summary>
    public unsafe struct Seniority {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settl Date
    /// </summary>
    public struct SettlDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Settlement Npv
    /// </summary>
    public struct SettlementNpv {
        public long Raw;
    };


    /// <summary>
    ///  Strategy Link Id
    /// </summary>
    public unsafe struct StrategyLinkId {
        public const int Size = 26;

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
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 50;

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
        AdminHeartbeat = "312",
        AdminLogin = "315",
        AdminLogout = "316",
        MdIncrementalRefreshErisReferenceDataAndDailyStatistics = "333",
        MdNewsIndices = "339",
        MdIncrementalRefreshTradeBlocks = "340",
        QuoteRequest = "345",
        MdInstrumentDefinitionIndices = "347",
        MdIncrementalRefreshIndices = "348",
        MdIncrementalRefreshTradeBlocks = "349",
        MdIncrementalRefreshEris = "351",
        MdIncrementalRefreshEris = "353",
        MdIncrementalRefreshOtc = "356",
        MdInstrumentDefinitionEris = "363",
        MdIncrementalRefreshTradeBlocks = "365",
        MdIncrementalRefreshOtc = "366",
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
    ///  Trade Date
    /// </summary>
    public struct TradeDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public struct TradeId {
        public int Raw;
    };


    /// <summary>
    ///  Trading Reference Date
    /// </summary>
    public struct TradingReferenceDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public struct TransactTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Trd Type
    /// </summary>
    public struct TrdType {
        public byte Raw;
    };


    /// <summary>
    ///  Unit Of Measure
    /// </summary>
    public unsafe struct UnitOfMeasure {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Measure Currency
    /// </summary>
    public unsafe struct UnitOfMeasureCurrency {
        public const int Size = 3;

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

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public struct Version {
        public ushort Raw;
    };


    /// <summary>
    ///  Vol Type
    /// </summary>
    public struct VolType {
        public ushort Raw;
    };


    /// <summary>
    ///  Week
    /// </summary>
    public struct Week {
        public byte Raw;
    };


    /// <summary>
    ///  Year
    /// </summary>
    public struct Year {
        public ushort Raw;
    };


    /// <summary>
    ///  Yield
    /// </summary>
    public struct Yield {
        public long Raw;
    };


    /// <summary>
    ///  Yield Type
    /// </summary>
    public unsafe struct YieldType {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Admin Login 315
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdminLogin315 {
        HeartBtInt HeartBtInt;
    };


    /// <summary>
    ///  Struct for Admin Logout 316
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdminLogout316 {
        Text Text;
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
        GroupSizeEncoding GroupSizeEncoding;
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
    ///  Struct for Group Size Encoding
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GroupSizeEncoding {
        BlockLength BlockLength;
        NumInGroup NumInGroup;
    };


    /// <summary>
    ///  Struct for Inst Attrib Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribGroup {
        InstAttribType InstAttribType;
        InstAttribValue InstAttribValue;
    };


    /// <summary>
    ///  Struct for Inst Attrib Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribGroups {
        GroupSizeEncoding GroupSizeEncoding;
    };


    /// <summary>
    ///  Struct for Legs Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegsGroup {
        LegBenchmarkCurveName LegBenchmarkCurveName;
        RateDescriptor RateDescriptor;
        PreviousFixingDate PreviousFixingDate;
        LegPayFrequencey LegPayFrequencey;
        PreviousFixingRate PreviousFixingRate;
        LegSymbol LegSymbol;
        LegRatioQty LegRatioQty;
        LegSide LegSide;
        LegCurrency LegCurrency;
        LegSecurityType LegSecurityType;
        LegSecurityGroup LegSecurityGroup;
        LegDateOffset LegDateOffset;
        InterpolationFactor InterpolationFactor;
    };


    /// <summary>
    ///  Struct for Legs Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Lines Of Text Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LinesOfTextGroup {
        Text Text;
    };


    /// <summary>
    ///  Struct for Lines Of Text Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LinesOfTextGroups {
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
    ///  Struct for MD Feed Types Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdFeedTypesGroup {
        MdFeedType MdFeedType;
        MarketDepth MarketDepth;
    };


    /// <summary>
    ///  Struct for MD Feed Types Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdFeedTypesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Eris 351
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshEris351 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Eris 353
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshEris353 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Eris Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshErisGroup {
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        RptSeq RptSeq;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        CalFutPx CalFutPx;
        MdEntryPositionNo MdEntryPositionNo;
        NumberOfOrders NumberOfOrders;
        TradeId TradeId;
        AggressorSide AggressorSide;
        Symbol Symbol;
        SecurityGroup SecurityGroup;
        SecurityType SecurityType;
        SecurityExchange SecurityExchange;
        Product Product;
        MaturityDate MaturityDate;
        ReferenceId ReferenceId;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Eris Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshErisGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Eris Reference Data And Daily Statistics 333
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatistics333 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Eris Reference Data And Daily Statistics Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatisticsGroup {
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        RptSeq RptSeq;
        MdEntryPx MdEntryPx;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        SettlPriceType SettlPriceType;
        CalFutPx CalFutPx;
        ReferenceId ReferenceId;
        MdEntrySize MdEntrySize;
        Symbol Symbol;
        SecurityGroup SecurityGroup;
        Product Product;
        SecurityType SecurityType;
        SecurityExchange SecurityExchange;
        MaturityDate MaturityDate;
        CouponRate CouponRate;
        TradeDate TradeDate;
        FairCouponPct FairCouponPct;
        LegPurchaseRate LegPurchaseRate;
        FixedNpv FixedNpv;
        FloatNpv FloatNpv;
        Npv Npv;
        AccruedCoupons AccruedCoupons;
        DailyIncrementalErisPai DailyIncrementalErisPai;
        ErisPai ErisPai;
        FedFundsRate FedFundsRate;
        MinPriceIncrement MinPriceIncrement;
        FixedPayment FixedPayment;
        FloatingPayment FloatingPayment;
        NextFixedPaymentDate NextFixedPaymentDate;
        NextFixedPaymentAmount NextFixedPaymentAmount;
        NextFloatingPaymentAmount NextFloatingPaymentAmount;
        TradingReferenceDate TradingReferenceDate;
        PreviousErisPai PreviousErisPai;
        FedFundsDate FedFundsDate;
        AccrualDays AccrualDays;
        Nominal Nominal;
        LegCreditRating LegCreditRating;
        LegContractMultiplier LegContractMultiplier;
        NextFloatingPaymentDate NextFloatingPaymentDate;
        Pv01 Pv01;
        Dv01 Dv01;
        SettlementNpv SettlementNpv;
        FinalSettlementFuturesPrice FinalSettlementFuturesPrice;
        SecurityDescription SecurityDescription;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Eris Reference Data And Daily Statistics Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatisticsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Indices 348
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshIndices348 {
        TransactTime TransactTime;
        MdFeedType MdFeedType;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Indices Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshIndicesGroup {
        MdEntryType MdEntryType;
        RptSeq RptSeq;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        Symbol Symbol;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        YieldType YieldType;
        Yield Yield;
        NetChgPrevDay NetChgPrevDay;
        NetPctChg NetPctChg;
        PercentTrading PercentTrading;
        MdEntryCode MdEntryCode;
        MdEntryDate MdEntryDate;
        MdEntryTime MdEntryTime;
        ReferenceId ReferenceId;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Indices Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshIndicesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Ot C 356
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshOtC356 {
        TransactTime TransactTime;
        TradeDate TradeDate;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Ot C 366
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshOtC366 {
        TransactTime TransactTime;
        TradeDate TradeDate;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Otc Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshOtcGroup {
        MdEntryType MdEntryType;
        RptSeq RptSeq;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        Symbol Symbol;
        SecurityGroup SecurityGroup;
        SecurityType SecurityType;
        MaturityMonthYear MaturityMonthYear;
        SecurityExchange SecurityExchange;
        Product Product;
        MaturityDate MaturityDate;
        CouponRate CouponRate;
        RestructuringType RestructuringType;
        Seniority Seniority;
        NotionalPercentageOutstanding NotionalPercentageOutstanding;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        UnitOfMeasure UnitOfMeasure;
        UnitOfMeasureCurrency UnitOfMeasureCurrency;
        UnitOfMeasureQty UnitOfMeasureQty;
        MdEntryDate MdEntryDate;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        PriceType PriceType;
        SettlDate SettlDate;
        QuoteCondition QuoteCondition;
        MarketSector MarketSector;
        SectorGroup SectorGroup;
        SectorSubGroup SectorSubGroup;
        ProductComplex ProductComplex;
        SecuritySubType SecuritySubType;
        VolType VolType;
        ReferenceId ReferenceId;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Otc Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshOtcGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Trade Blocks 340
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeBlocks340 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Trade Blocks 349
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeBlocks349 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
        TradeDate TradeDate;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Trade Blocks 365
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeBlocks365 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
        TradeDate TradeDate;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Blocks Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeBlocksGroup {
        MdUpdateAction MdUpdateAction;
        SecurityId SecurityId;
        RptSeq RptSeq;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        NumberOfOrders NumberOfOrders;
        TradeId TradeId;
        AggressorSide AggressorSide;
        Symbol Symbol;
        SecurityGroup SecurityGroup;
        SecurityType SecurityType;
        SecuritySubType SecuritySubType;
        MaturityMonthYear MaturityMonthYear;
        SecurityExchange SecurityExchange;
        MaturityDate MaturityDate;
        UnitOfMeasure UnitOfMeasure;
        UnitOfMeasureCurrency UnitOfMeasureCurrency;
        UnitOfMeasureQty UnitOfMeasureQty;
        CouponRate CouponRate;
        PriceType PriceType;
        TrdType TrdType;
        MdEntryId MdEntryId;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        RestructuringType RestructuringType;
        Seniority Seniority;
        ReferenceId ReferenceId;
        StrategyLinkId StrategyLinkId;
        LegRefId LegRefId;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Blocks Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeBlocksGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        MessageSize MessageSize;
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        MessageSequenceNumber MessageSequenceNumber;
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Quote Request 345
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteRequest345 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        QuoteReqId QuoteReqId;
    };


    /// <summary>
    ///  Struct for Related Sym Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroup {
        Symbol Symbol;
    };


    /// <summary>
    ///  Struct for Related Sym Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Security Alt Id Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityAltIdGroup {
        SecurityAltId SecurityAltId;
        SecurityAltIdSource SecurityAltIdSource;
    };


    /// <summary>
    ///  Struct for Security Alt Id Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityAltIdGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Settl Price Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlPriceType {
        NullValue NullValue;
        ReservedBits ReservedBits;
        Rounded Rounded;
        Actual Actual;
        FinalDaily FinalDaily;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
