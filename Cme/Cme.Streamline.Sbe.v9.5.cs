namespace Cme.Streamline.Sbe.v9.5 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Accrual Days
    /// </summary>
    public unsafe struct AccrualDays {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
        NoValue = 255,
        NoAggressor = 0,
        Buy = 1,
        Sell = 2,
    };


    /// <summary>
    ///  Appl Id
    /// </summary>
    public unsafe struct ApplId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Batch Total Messages
    /// </summary>
    public unsafe struct BatchTotalMessages {
        public const int Size = 2;

        public short Value;

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
    ///  Day
    /// </summary>
    public unsafe struct Day {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Event Type
    /// </summary>
    public unsafe struct EventType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exponent
    /// </summary>
    public struct Exponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Fed Funds Date
    /// </summary>
    public unsafe struct FedFundsDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Final Daily
    /// </summary>
    public unsafe struct FinalDaily {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    public unsafe struct InstAttribType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct LegSide {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Mantissa
    /// </summary>
    public struct Mantissa {
        public int Raw;
    };


    /// <summary>
    ///  Market Depth
    /// </summary>
    public unsafe struct MarketDepth {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct MaturityDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Entry Code Values
    /// </summary>
    public enum MdEntryCode : byte {
        NoValue = 255,
        Indicative = 1,
        PreMarket = 2,
        PreliminaryClose = 3,
        SessionClose = 4,
        Close = 5,
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
    public unsafe struct MdEntrySize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Month
    /// </summary>
    public unsafe struct Month {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Next Fixed Payment Date
    /// </summary>
    public unsafe struct NextFixedPaymentDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Next Floating Payment Date
    /// </summary>
    public unsafe struct NextFloatingPaymentDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Nominal
    /// </summary>
    public unsafe struct Nominal {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Notional Percentage Outstanding
    /// </summary>
    public struct NotionalPercentageOutstanding {
        public int Raw;
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
    ///  Open Close Settl Flag
    /// </summary>
    public unsafe struct OpenCloseSettlFlag {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Orig Time
    /// </summary>
    public unsafe struct OrigTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Previous Fixing Date
    /// </summary>
    public unsafe struct PreviousFixingDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Type
    /// </summary>
    public unsafe struct PriceType {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct PutOrCall {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Condition
    /// </summary>
    public unsafe struct QuoteCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    public unsafe struct SecurityId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct SettlDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
        AdminHeartbeat = 312,
        AdminLogin = 315,
        AdminLogout = 316,
        MdIncrementalRefreshErisReferenceDataAndDailyStatistics = 333,
        MdNewsIndices = 339,
        MdIncrementalRefreshTradeBlocks = 340,
        QuoteRequest = 345,
        MdInstrumentDefinitionIndices = 347,
        MdIncrementalRefreshIndices = 348,
        MdIncrementalRefreshTradeBlocks = 349,
        MdIncrementalRefreshEris = 351,
        MdIncrementalRefreshEris = 353,
        MdIncrementalRefreshOtc = 356,
        MdInstrumentDefinitionEris = 363,
        MdIncrementalRefreshTradeBlocks = 365,
        MdIncrementalRefreshOtc = 366,
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
    public unsafe struct TradeDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct TradingReferenceDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Trd Type
    /// </summary>
    public unsafe struct TrdType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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
    ///  Vol Type
    /// </summary>
    public unsafe struct VolType {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Year
    /// </summary>
    public unsafe struct Year {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Struct for Accrued Coupons
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AccruedCoupons {
        Mantissa Mantissa;
        Exponent Exponent;
    };


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
    ///  Struct for Binary Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BinaryPacketHeader {
        MessageSequenceNumber MessageSequenceNumber;
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Cal Fut Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CalFutPx {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Coupon Rate
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CouponRate {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for D V 01
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DV01 {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Daily Incremental Eris Pai
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DailyIncrementalErisPai {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Eris Pai
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ErisPai {
        Mantissa Mantissa;
        Exponent Exponent;
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
    ///  Struct for Fair Coupon Pct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FairCouponPct {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Fed Funds Rate
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FedFundsRate {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Final Settlement Futures Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FinalSettlementFuturesPrice {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Fixed Npv
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FixedNpv {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Fixed Payment
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FixedPayment {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Float Npv
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FloatNpv {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Floating Payment
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FloatingPayment {
        Mantissa Mantissa;
        Exponent Exponent;
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
    ///  Struct for Interpolation Factor
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InterpolationFactor {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Leg Contract Multiplier
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegContractMultiplier {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Leg Purchase Rate
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegPurchaseRate {
        Mantissa Mantissa;
        Exponent Exponent;
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
    ///  Struct for M D Incremental Refresh Eris Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshErisGroup {
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
    ///  Struct for M D Incremental Refresh Eris Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshErisGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Eris Reference Data And Daily Statistics Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshErisReferenceDataAndDailyStatisticsGroup {
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
        PV01 PV01;
        DV01 DV01;
        SettlementNpv SettlementNpv;
        FinalSettlementFuturesPrice FinalSettlementFuturesPrice;
        SecurityDescription SecurityDescription;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Eris Reference Data And Daily Statistics Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshErisReferenceDataAndDailyStatisticsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Indices Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshIndicesGroup {
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
    ///  Struct for M D Incremental Refresh Indices Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshIndicesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Otc Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshOtcGroup {
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
    ///  Struct for M D Incremental Refresh Otc Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshOtcGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Trade Blocks Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshTradeBlocksGroup {
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
    ///  Struct for M D Incremental Refresh Trade Blocks Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshTradeBlocksGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Instrument Definition Eris Leg Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDInstrumentDefinitionErisLegGroup {
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
    ///  Struct for M D Instrument Definition Eris Leg Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDInstrumentDefinitionErisLegGroups {
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
    ///  Struct for Md Entry Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdEntryPx {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Md Entry Size
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdEntrySize {
        Mantissa Mantissa;
        Exponent Exponent;
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
    ///  Struct for Md Incremental Refresh Eris Reference Data And Daily Statistics 333
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshErisReferenceDataAndDailyStatistics333 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        BatchTotalMessages BatchTotalMessages;
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
    ///  Struct for Min Price Increment
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MinPriceIncrement {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Net Chg Prev Day
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetChgPrevDay {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Net Pct Chg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetPctChg {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Next Fixed Payment Amount
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NextFixedPaymentAmount {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Next Floating Payment Amount
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NextFloatingPaymentAmount {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Npv
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Npv {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for P V 01
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PV01 {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Percent Trading
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PercentTrading {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Previous Eris Pai
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PreviousErisPai {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Previous Fixing Rate
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PreviousFixingRate {
        Mantissa Mantissa;
        Exponent Exponent;
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


    /// <summary>
    ///  Struct for Settlement Npv
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlementNpv {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Strike Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrikePrice {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Unit Of Measure Qty
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitOfMeasureQty {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Yield
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Yield {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
