namespace Cme.Futures.iLink3.Sbe.v8.7 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Access Key Id
    /// </summary>
    public unsafe struct AccessKeyId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Affected Order Id
    /// </summary>
    public unsafe struct AffectedOrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Aggressor Indicator Values
    /// </summary>
    public enum AggressorIndicator : byte {
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  Aon
    /// </summary>
    public unsafe struct Aon {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Auto Quote Request Values
    /// </summary>
    public enum AutoQuoteRequest : byte {
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  Avg Px Group Id
    /// </summary>
    public unsafe struct AvgPxGroupId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Avg Px Indicator Values
    /// </summary>
    public enum AvgPxIndicator : byte {
        NoValue = 255,
        NoAveragePricing = 0,
        TradeispartofanAveragePriceGroupIdentifiedbytheAvgPxGrpId = 1,
        TradeispartofaNotionalValueAveragePriceGroup = 3,
    };


    /// <summary>
    ///  Benchmark Price
    /// </summary>
    public struct BenchmarkPrice {
        public long Raw;
    };


    /// <summary>
    ///  Bid Px
    /// </summary>
    public struct BidPx {
        public long Raw;
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 4;

        public int Value;

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
    ///  Business Reject Reason
    /// </summary>
    public unsafe struct BusinessRejectReason {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Business Reject Ref Id
    /// </summary>
    public unsafe struct BusinessRejectRefId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancelled Symbol
    /// </summary>
    public unsafe struct CancelledSymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Account Type Values
    /// </summary>
    public enum ClearingAccountType : byte {
        NoValue = 255,
        Customer = 0,
        Firm = 1,
    };


    /// <summary>
    ///  Clearing Trade Price Type Values
    /// </summary>
    public enum ClearingTradePriceType : byte {
        NoValue = 255,
        TradeClearingatExecutionPrice = 0,
        TradeClearingatAlternateClearingPrice = 1,
    };


    /// <summary>
    ///  ClOrdId
    /// </summary>
    public unsafe struct Clordid {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cmta Giveup Cd Values
    /// </summary>
    public enum CmtaGiveupCd : byte {
        NoValue = (byte)'zeroed',
        GiveUp = (byte)'G',
        SgXoffset = (byte)'S',
    };


    /// <summary>
    ///  Cross Id
    /// </summary>
    public unsafe struct CrossId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Id Optional
    /// </summary>
    public unsafe struct CrossIdOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Type
    /// </summary>
    public unsafe struct CrossType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cum Qty
    /// </summary>
    public unsafe struct CumQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Cust Order Capacity Values
    /// </summary>
    public enum CustOrderCapacity : byte {
        NoValue = 255,
        Membertradingfortheirownaccount = 1,
        Clearingfirmtradingforitsproprietaryaccount = 2,
        Membertradingforanothermember = 3,
        Allother = 4,
    };


    /// <summary>
    ///  Cust Order Handling Inst Values
    /// </summary>
    public enum CustOrderHandlingInst : byte {
        NoValue = (byte)'zeroed',
        FcMprovidedscreen = (byte)'C',
        Otherprovidedscreen = (byte)'D',
        FcmapIorFix = (byte)'G',
        AlgoEngine = (byte)'H',
        DeskElectronic = (byte)'W',
        ClientElectronic = (byte)'Y',
    };


    /// <summary>
    ///  Cxl Quantity
    /// </summary>
    public unsafe struct CxlQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cxl Rej Reason
    /// </summary>
    public unsafe struct CxlRejReason {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Data Length
    /// </summary>
    public unsafe struct DataLength {
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
    ///  Delay Duration
    /// </summary>
    public unsafe struct DelayDuration {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Delay To Time
    /// </summary>
    public unsafe struct DelayToTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Discretion Price
    /// </summary>
    public struct DiscretionPrice {
        public long Raw;
    };


    /// <summary>
    ///  Display Qty
    /// </summary>
    public unsafe struct DisplayQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dk Reason Values
    /// </summary>
    public enum DkReason : byte {
        NoValue = (byte)'zeroed',
        UnknownSecurity = (byte)'A',
        WrongSide = (byte)'B',
        QuantityExceedsOrder = (byte)'C',
        NoMatchingOrder = (byte)'D',
        PriceExceedsLimit = (byte)'E',
        CalculationDifference = (byte)'F',
        NoMatchingExecutionReport = (byte)'G',
        Other = (byte)'Z',
    };


    /// <summary>
    ///  Encoding Type
    /// </summary>
    public unsafe struct EncodingType {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Error Codes
    /// </summary>
    public unsafe struct ErrorCodes {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exchange Quote Req Id
    /// </summary>
    public unsafe struct ExchangeQuoteReqId {
        public const int Size = 17;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Ack Status Values
    /// </summary>
    public enum ExecAckStatus : byte {
        Accepted = 1,
        Rejected = 2,
    };


    /// <summary>
    ///  Exec Id
    /// </summary>
    public unsafe struct ExecId {
        public const int Size = 40;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Restatement Reason Values
    /// </summary>
    public enum ExecRestatementReason : byte {
        NoValue = 255,
        MarketExchangeOption = 8,
        CancelledNotBest = 9,
        CancelOnDisconnect = 100,
        SelfMatchPreventionOldestOrderCancelled = 103,
        CancelOnGlobexCreditControlsViolation = 104,
        CancelFromFirmsoft = 105,
        CancelFromRiskManagementApi = 106,
        SelfMatchPreventionNewestOrderCancelled = 107,
        Cancelduetovolquotedoptionorderrestedqtylessthanminordersize = 108,
    };


    /// <summary>
    ///  Exec Type Values
    /// </summary>
    public enum ExecType : byte {
        TradeCorrection = (byte)'G',
        TradeCancel = (byte)'H',
    };


    /// <summary>
    ///  Execution Mode Values
    /// </summary>
    public enum ExecutionMode : byte {
        NoValue = (byte)'zeroed',
        Aggressive = (byte)'A',
        Passive = (byte)'P',
    };


    /// <summary>
    ///  Executor
    /// </summary>
    public unsafe struct Executor {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Cycle Values
    /// </summary>
    public enum ExpirationCycle : byte {
        NoValue = 255,
        ExpireOnTradingSessionClose = 0,
        Expirationatgivendate = 2,
    };


    /// <summary>
    ///  Expire Date
    /// </summary>
    public unsafe struct ExpireDate {
        public const int Size = 2;

        public short Value;

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
    ///  Fault Tolerance Indicator Values
    /// </summary>
    public enum FaultToleranceIndicator : byte {
        NoValue = 255,
        Backup = 0,
        Primary = 1,
    };


    /// <summary>
    ///  Fill Exec Id
    /// </summary>
    public unsafe struct FillExecId {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fill Px
    /// </summary>
    public struct FillPx {
        public long Raw;
    };


    /// <summary>
    ///  Fill Qty
    /// </summary>
    public unsafe struct FillQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fill Yield Type
    /// </summary>
    public unsafe struct FillYieldType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Firm
    /// </summary>
    public unsafe struct Firm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  From Seq No
    /// </summary>
    public unsafe struct FromSeqNo {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hmac Signature
    /// </summary>
    public unsafe struct HmacSignature {
        public const int Size = 32;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Host Cross Id
    /// </summary>
    public unsafe struct HostCrossId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Idm Short Code
    /// </summary>
    public unsafe struct IdmShortCode {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Keep Alive Interval
    /// </summary>
    public unsafe struct KeepAliveInterval {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Keep Alive Interval Lapsed Values
    /// </summary>
    public enum KeepAliveIntervalLapsed : byte {
        NotLapsed = 0,
        Lapsed = 1,
    };


    /// <summary>
    ///  Last Fragment Values
    /// </summary>
    public enum LastFragment : byte {
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  Last Px
    /// </summary>
    public struct LastPx {
        public long Raw;
    };


    /// <summary>
    ///  Last Qty
    /// </summary>
    public unsafe struct LastQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Rpt Requested Values
    /// </summary>
    public enum LastRptRequested : byte {
        NoValue = 255,
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  Last Uuid
    /// </summary>
    public unsafe struct LastUuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leaves
    /// </summary>
    public unsafe struct Leaves {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leaves Qty Optional
    /// </summary>
    public unsafe struct LeavesQtyOptional {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Exec Id
    /// </summary>
    public unsafe struct LegExecId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Exec Ref Id
    /// </summary>
    public unsafe struct LegExecRefId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Last Px
    /// </summary>
    public struct LegLastPx {
        public long Raw;
    };


    /// <summary>
    ///  Leg Last Qty
    /// </summary>
    public unsafe struct LegLastQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct LegRatioQty {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
        Buy = 1,
        Sell = 2,
        Undisclosed = 7,
    };


    /// <summary>
    ///  Leg Trade Id
    /// </summary>
    public unsafe struct LegTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Trade Ref Id
    /// </summary>
    public unsafe struct LegTradeRefId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Liquidity Flag Values
    /// </summary>
    public enum LiquidityFlag : byte {
        NoValue = 255,
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  List Update Action Values
    /// </summary>
    public enum ListUpdateAction : byte {
        Add = (byte)'A',
        Delete = (byte)'D',
    };


    /// <summary>
    ///  Location
    /// </summary>
    public unsafe struct Location {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Location Optional
    /// </summary>
    public unsafe struct LocationOptional {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Managed Order Values
    /// </summary>
    public enum ManagedOrder : byte {
        NoValue = 255,
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  Mantissa
    /// </summary>
    public struct Mantissa {
        public long Raw;
    };


    /// <summary>
    ///  Mantissa 32
    /// </summary>
    public struct Mantissa32 {
        public int Raw;
    };


    /// <summary>
    ///  Manual Order Indicator Values
    /// </summary>
    public enum ManualOrderIndicator : byte {
        Automated = 0,
        Manual = 1,
    };


    /// <summary>
    ///  Manual Order Indicator Optional Values
    /// </summary>
    public enum ManualOrderIndicatorOptional : byte {
        NoValue = 255,
        Automated = 0,
        Manual = 1,
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
    ///  Mass Action Ord Typ Values
    /// </summary>
    public enum MassActionOrdTyp : byte {
        NoValue = (byte)'zeroed',
        Limit = (byte)'2',
        StopLimit = (byte)'4',
    };


    /// <summary>
    ///  Mass Action Reject Reason
    /// </summary>
    public unsafe struct MassActionRejectReason {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mass Action Report Id
    /// </summary>
    public unsafe struct MassActionReportId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mass Action Response Values
    /// </summary>
    public enum MassActionResponse : byte {
        Rejected = 0,
        Accepted = 1,
    };


    /// <summary>
    ///  Mass Action Scope Values
    /// </summary>
    public enum MassActionScope : byte {
        Instrument = 1,
        All = 7,
        MarketSegmentId = 9,
        InstrumentGroup = 10,
        QuoteSetId = 100,
    };


    /// <summary>
    ///  Mass Cancel Request Type Values
    /// </summary>
    public enum MassCancelRequestType : byte {
        NoValue = 255,
        SenderSubId = 100,
        Account = 101,
    };


    /// <summary>
    ///  Mass Cancel Tif Values
    /// </summary>
    public enum MassCancelTif : byte {
        NoValue = 255,
        Day = 0,
        GoodTillCancel = 1,
        GoodTillDate = 6,
    };


    /// <summary>
    ///  Mass Status Req Id
    /// </summary>
    public unsafe struct MassStatusReqId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mass Status Req Id Optional
    /// </summary>
    public unsafe struct MassStatusReqIdOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mass Status Req Type Values
    /// </summary>
    public enum MassStatusReqType : byte {
        Instrument = 1,
        InstrumentGroup = 3,
        MarketSegment = 100,
    };


    /// <summary>
    ///  Mass Status Tif Values
    /// </summary>
    public enum MassStatusTif : byte {
        NoValue = 255,
        Day = 0,
        Gtc = 1,
        Gtd = 6,
        Gfs = 99,
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
    ///  Md Trade Entry Id
    /// </summary>
    public unsafe struct MdTradeEntryId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Memo
    /// </summary>
    public unsafe struct Memo {
        public const int Size = 75;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Min Qty
    /// </summary>
    public unsafe struct MinQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mm Protection Reset Values
    /// </summary>
    public enum MmProtectionReset : byte {
        False = 0,
        True = 1,
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
    ///  Msg Count
    /// </summary>
    public unsafe struct MsgCount {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Msg Count 16
    /// </summary>
    public unsafe struct MsgCount16 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Next Seq No
    /// </summary>
    public unsafe struct NextSeqNo {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Nh
    /// </summary>
    public unsafe struct Nh {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  No Processed Entries
    /// </summary>
    public unsafe struct NoProcessedEntries {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Processed Entries 32
    /// </summary>
    public unsafe struct NoProcessedEntries32 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Ob
    /// </summary>
    public unsafe struct Ob {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Offer Px
    /// </summary>
    public struct OfferPx {
        public long Raw;
    };


    /// <summary>
    ///  Offer Size
    /// </summary>
    public unsafe struct OfferSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ofm Override Values
    /// </summary>
    public enum OfmOverride : byte {
        Disabled = 0,
        Enabled = 1,
    };


    /// <summary>
    ///  Ord Rej Reason
    /// </summary>
    public unsafe struct OrdRejReason {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ord Status Values
    /// </summary>
    public enum OrdStatus : byte {
        New = (byte)'0',
        PartiallyFilled = (byte)'1',
        Filled = (byte)'2',
        Cancelled = (byte)'4',
        Replaced = (byte)'5',
        PendingCancel = (byte)'6',
        Rejected = (byte)'8',
        Expired = (byte)'C',
        PendingReplace = (byte)'E',
        Undefined = (byte)'U',
    };


    /// <summary>
    ///  Ord Status Req Id
    /// </summary>
    public unsafe struct OrdStatusReqId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ord Status Req Id Optional
    /// </summary>
    public unsafe struct OrdStatusReqIdOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ord Status Req Type Values
    /// </summary>
    public enum OrdStatusReqType : byte {
        NoValue = 255,
        SenderSubId = 100,
        Account = 101,
    };


    /// <summary>
    ///  Ord Status Trd Values
    /// </summary>
    public enum OrdStatusTrd : byte {
        PartiallyFilled = 1,
        Filled = 2,
    };


    /// <summary>
    ///  Ord Status Trd Cxl Values
    /// </summary>
    public enum OrdStatusTrdCxl : byte {
        TradeCorrection = (byte)'G',
        TradeCancel = (byte)'H',
    };


    /// <summary>
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        MarketwithProtection = (byte)'1',
        Limit = (byte)'2',
        StopwithProtection = (byte)'3',
        StopLimit = (byte)'4',
        MarketWithLeftoverAsLimit = (byte)'K',
    };


    /// <summary>
    ///  Ord Type Optional Values
    /// </summary>
    public enum OrdTypeOptional : byte {
        NoValue = (byte)'zeroed',
        MarketWithProtection = (byte)'1',
        Limit = (byte)'2',
        StopLimit = (byte)'4',
        MarketWithLeftoverAsLimit = (byte)'K',
    };


    /// <summary>
    ///  Order Event Exec Id
    /// </summary>
    public unsafe struct OrderEventExecId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Event Px
    /// </summary>
    public struct OrderEventPx {
        public long Raw;
    };


    /// <summary>
    ///  Order Event Qty
    /// </summary>
    public unsafe struct OrderEventQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Event Reason
    /// </summary>
    public unsafe struct OrderEventReason {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Event Text
    /// </summary>
    public unsafe struct OrderEventText {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Event Type Values
    /// </summary>
    public enum OrderEventType : byte {
        NoValue = 255,
        PartiallyFilled = 4,
        Filled = 5,
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
    public unsafe struct OrderQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Qty Optional
    /// </summary>
    public unsafe struct OrderQtyOptional {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Request Id
    /// </summary>
    public unsafe struct OrderRequestId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Orig Secondary Execution Id
    /// </summary>
    public unsafe struct OrigSecondaryExecutionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Orig Side Trade Id
    /// </summary>
    public unsafe struct OrigSideTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  OrigClOrdId
    /// </summary>
    public unsafe struct Origclordid {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Order Event Exec Id
    /// </summary>
    public unsafe struct OriginalOrderEventExecId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ownership
    /// </summary>
    public unsafe struct Ownership {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Definition Status
    /// </summary>
    public unsafe struct PartyDetailDefinitionStatus {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Id
    /// </summary>
    public unsafe struct PartyDetailId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Request Status
    /// </summary>
    public unsafe struct PartyDetailRequestStatus {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Role Values
    /// </summary>
    public enum PartyDetailRole : ushort {
        ExecutingFirm = 1,
        CustomerAccount = 24,
        TakeUpFirm = 96,
        Operator = 118,
        TakeUpAccount = 1000,
    };


    /// <summary>
    ///  Party Details List Report Id
    /// </summary>
    public unsafe struct PartyDetailsListReportId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Details List Req Id
    /// </summary>
    public unsafe struct PartyDetailsListReqId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Details List Req Id Optional
    /// </summary>
    public unsafe struct PartyDetailsListReqIdOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id
    /// </summary>
    public unsafe struct PartyId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Source
    /// </summary>
    public unsafe struct PartyIdSource {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Role
    /// </summary>
    public unsafe struct PartyRole {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Poss Retrans Flag Values
    /// </summary>
    public enum PossRetransFlag : byte {
        False = 0,
        True = 1,
    };


    /// <summary>
    ///  Previous Seq No
    /// </summary>
    public unsafe struct PreviousSeqNo {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Previous Uuid
    /// </summary>
    public unsafe struct PreviousUuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public long Raw;
    };


    /// <summary>
    ///  Price Optional
    /// </summary>
    public struct PriceOptional {
        public long Raw;
    };


    /// <summary>
    ///  Quote Ack Status Values
    /// </summary>
    public enum QuoteAckStatus : byte {
        Accepted = 0,
        Rejected = 5,
    };


    /// <summary>
    ///  Quote Cancel Type Values
    /// </summary>
    public enum QuoteCancelType : byte {
        CancelperInstrument = 1,
        CancelperInstrumentgroup = 3,
        Cancelallquotes = 4,
        CancelperQuoteSet = 100,
    };


    /// <summary>
    ///  Quote Cxl Status Values
    /// </summary>
    public enum QuoteCxlStatus : byte {
        CancelperInstrument = 1,
        CancelperInstrumentgroup = 3,
        Cancelallquotes = 4,
        Rejected = 5,
        CancelperQuoteSet = 100,
    };


    /// <summary>
    ///  Quote Entry Id
    /// </summary>
    public unsafe struct QuoteEntryId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Entry Reject Reason
    /// </summary>
    public unsafe struct QuoteEntryRejectReason {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Error Code
    /// </summary>
    public unsafe struct QuoteErrorCode {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Id
    /// </summary>
    public unsafe struct QuoteId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Reject Reason
    /// </summary>
    public unsafe struct QuoteRejectReason {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Req Id
    /// </summary>
    public unsafe struct QuoteReqId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Req Id Optional
    /// </summary>
    public unsafe struct QuoteReqIdOptional {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Set Id
    /// </summary>
    public unsafe struct QuoteSetId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Type Values
    /// </summary>
    public enum QuoteType : byte {
        NoValue = 255,
        Tradeable = 1,
    };


    /// <summary>
    ///  Reason
    /// </summary>
    public unsafe struct Reason {
        public const int Size = 48;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ref Msg Type
    /// </summary>
    public unsafe struct RefMsgType {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ref Seq Num
    /// </summary>
    public unsafe struct RefSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ref Tag Id
    /// </summary>
    public unsafe struct RefTagId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Request Result Values
    /// </summary>
    public enum RequestResult : byte {
        ValidRequest = 0,
        NoDataFoundThatMatchedSelectionCriteria = 2,
        NotAuthorizedtoRetrieveData = 3,
        DataTemporarilyUnavailable = 4,
    };


    /// <summary>
    ///  Request Time
    /// </summary>
    public unsafe struct RequestTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Request Timestamp
    /// </summary>
    public unsafe struct RequestTimestamp {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requesting Party Id
    /// </summary>
    public unsafe struct RequestingPartyId {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requesting Party Id Source
    /// </summary>
    public unsafe struct RequestingPartyIdSource {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requesting Party Role
    /// </summary>
    public unsafe struct RequestingPartyRole {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 2
    /// </summary>
    public unsafe struct Reserved2 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 3
    /// </summary>
    public unsafe struct Reserved3 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 4
    /// </summary>
    public unsafe struct Reserved4 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 5
    /// </summary>
    public unsafe struct Reserved5 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rfq Side Values
    /// </summary>
    public enum RfqSide : byte {
        NoValue = 255,
        Buy = 1,
        Sell = 2,
        Cross = 8,
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
    ///  Sec Exec Id
    /// </summary>
    public unsafe struct SecExecId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secret Key Secure Id Expiration
    /// </summary>
    public unsafe struct SecretKeySecureIdExpiration {
        public const int Size = 2;

        public short Value;

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
    ///  Security Req Id
    /// </summary>
    public unsafe struct SecurityReqId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Response Id
    /// </summary>
    public unsafe struct SecurityResponseId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Response Type Values
    /// </summary>
    public enum SecurityResponseType : byte {
        AcceptSecurityProposalasis = 1,
        AcceptSecurityproposalwithrevisionsasindicatedinthemessage = 2,
        RejectSecurityProposal = 5,
    };


    /// <summary>
    ///  Security Sub Type
    /// </summary>
    public unsafe struct SecuritySubType {
        public const int Size = 8;

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
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Self Match Prevention Id
    /// </summary>
    public unsafe struct SelfMatchPreventionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Self Match Prevention Instruction Values
    /// </summary>
    public enum SelfMatchPreventionInstruction : byte {
        NoValue = (byte)'zeroed',
        CancelNewest = (byte)'N',
        CancelOldest = (byte)'O',
    };


    /// <summary>
    ///  Sender Id
    /// </summary>
    public unsafe struct SenderId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sender Id Optional
    /// </summary>
    public unsafe struct SenderIdOptional {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sending Time Epoch
    /// </summary>
    public unsafe struct SendingTimeEpoch {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seq Num
    /// </summary>
    public unsafe struct SeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session
    /// </summary>
    public unsafe struct Session {
        public const int Size = 3;

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
    ///  Short Sale Type Values
    /// </summary>
    public enum ShortSaleType : byte {
        NoValue = 255,
        LongSell = 0,
        ShortSaleWithNoExemptionSesh = 1,
        ShortSaleWithExemptionSsex = 2,
        UndisclosedSellInformationNotAvailableUndi = 3,
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = 1,
        Sell = 2,
        Undisclosed = 7,
    };


    /// <summary>
    ///  Side Optional Values
    /// </summary>
    public enum SideOptional : byte {
        NoValue = 255,
        Buy = 1,
        Sell = 2,
    };


    /// <summary>
    ///  Side Time In Force Values
    /// </summary>
    public enum SideTimeInForce : byte {
        Day = 0,
        Fak = 3,
    };


    /// <summary>
    ///  Side Trade Id
    /// </summary>
    public unsafe struct SideTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Repo Id
    /// </summary>
    public struct SourceRepoId {
        public int Raw;
    };


    /// <summary>
    ///  Split Msg Values
    /// </summary>
    public enum SplitMsg : byte {
        NoValue = 255,
        SplitMessageDelayed = 0,
        OutofOrderMessageDelayed = 1,
        CompleteMessageDelayed = 2,
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
    ///  Stop Px
    /// </summary>
    public struct StopPx {
        public long Raw;
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
        Negotiate = 500,
        NegotiationResponse = 501,
        NegotiationReject = 502,
        Establish = 503,
        EstablishmentAck = 504,
        EstablishmentReject = 505,
        Sequence = 506,
        Terminate = 507,
        RetransmitRequest = 508,
        Retransmission = 509,
        RetransmitReject = 510,
        NotApplied = 513,
        NewOrderSingle = 514,
        OrderCancelReplaceRequest = 515,
        OrderCancelRequest = 516,
        MassQuote = 517,
        PartyDetailsDefinitionRequest = 518,
        PartyDetailsDefinitionRequestAck = 519,
        BusinessReject = 521,
        ExecutionReportNew = 522,
        ExecutionReportReject = 523,
        ExecutionReportElimination = 524,
        ExecutionReportTradeOutright = 525,
        ExecutionReportTradeSpread = 526,
        ExecutionReportTradeSpreadLeg = 527,
        QuoteCancel = 528,
        OrderMassActionRequest = 529,
        OrderMassStatusRequest = 530,
        ExecutionReportModify = 531,
        ExecutionReportStatus = 532,
        OrderStatusRequest = 533,
        ExecutionReportCancel = 534,
        OrderCancelReject = 535,
        OrderCancelReplaceReject = 536,
        PartyDetailsListRequest = 537,
        PartyDetailsListReport = 538,
        ExecutionAck = 539,
        RequestForQuote = 543,
        NewOrderCross = 544,
        MassQuoteAck = 545,
        RequestForQuoteAck = 546,
        ExecutionReportTradeAddendumOutright = 548,
        ExecutionReportTradeAddendumSpread = 549,
        ExecutionReportTradeAddendumSpreadLeg = 550,
        SecurityDefinitionRequest = 560,
        SecurityDefinitionResponse = 561,
        OrderMassActionReport = 562,
        QuoteCancelAck = 563,
        ExecutionReportPendingCancel = 564,
        ExecutionReportPendingReplace = 565,
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
        public const int Size = 256;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Time In Force Values
    /// </summary>
    public enum TimeInForce : byte {
        NoValue = 255,
        Day = 0,
        GoodTillCancel = 1,
        FillAndKill = 3,
        FillOrKill = 4,
        GoodTillDate = 6,
        GoodForSession = 99,
    };


    /// <summary>
    ///  Tot No Quote Entries
    /// </summary>
    public unsafe struct TotNoQuoteEntries {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tot No Quote Entries Optional
    /// </summary>
    public unsafe struct TotNoQuoteEntriesOptional {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tot Num Parties
    /// </summary>
    public unsafe struct TotNumParties {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Affected Orders
    /// </summary>
    public unsafe struct TotalAffectedOrders {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Num Securities
    /// </summary>
    public unsafe struct TotalNumSecurities {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Addendum Values
    /// </summary>
    public enum TradeAddendum : byte {
        PartiallyFilled = 4,
        Filled = 5,
        TradeCancel = 100,
        TradeCorrection = 101,
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
    ///  Trading System Name
    /// </summary>
    public unsafe struct TradingSystemName {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading System Vendor
    /// </summary>
    public unsafe struct TradingSystemVendor {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading System Version
    /// </summary>
    public unsafe struct TradingSystemVersion {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trans Bkd Time
    /// </summary>
    public unsafe struct TransBkdTime {
        public const int Size = 8;

        public long Value;

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
    ///  Trd Reg Publication Reason
    /// </summary>
    public unsafe struct TrdRegPublicationReason {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Reg Publication Type
    /// </summary>
    public unsafe struct TrdRegPublicationType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Type
    /// </summary>
    public unsafe struct TrdType {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Px
    /// </summary>
    public struct UnderlyingPx {
        public long Raw;
    };


    /// <summary>
    ///  Underlying Security Id
    /// </summary>
    public struct UnderlyingSecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Unsolicited Cancel Type
    /// </summary>
    public unsafe struct UnsolicitedCancelType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Uuid
    /// </summary>
    public unsafe struct Uuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Var Data
    /// </summary>
    public unsafe struct VarData {
        public const int Size = 0;

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


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Affected Orders Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AffectedOrdersGroup {
        Origclordid Origclordid;
        AffectedOrderId AffectedOrderId;
        CxlQuantity CxlQuantity;
    };


    /// <summary>
    ///  Struct for Affected Orders Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AffectedOrdersGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Business Reject 521
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BusinessReject521 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        SenderIdOptional SenderIdOptional;
        PartyDetailsListReqIdOptional PartyDetailsListReqIdOptional;
        SendingTimeEpoch SendingTimeEpoch;
        BusinessRejectRefId BusinessRejectRefId;
        LocationOptional LocationOptional;
        RefSeqNum RefSeqNum;
        RefTagId RefTagId;
        BusinessRejectReason BusinessRejectReason;
        RefMsgType RefMsgType;
        PossRetransFlag PossRetransFlag;
        ManualOrderIndicatorOptional ManualOrderIndicatorOptional;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Calculated Ccy Last Qty
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CalculatedCcyLastQty {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Contra Calculated Ccy Last Qty
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ContraCalculatedCcyLastQty {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Contra Gross Trade Amt
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ContraGrossTradeAmt {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Credentials
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Credentials {
        DataLength DataLength;
    };


    /// <summary>
    ///  Struct for Establish 503
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Establish503 {
        HmacSignature HmacSignature;
        AccessKeyId AccessKeyId;
        TradingSystemName TradingSystemName;
        TradingSystemVersion TradingSystemVersion;
        TradingSystemVendor TradingSystemVendor;
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        NextSeqNo NextSeqNo;
        Session Session;
        Firm Firm;
        KeepAliveInterval KeepAliveInterval;
    };


    /// <summary>
    ///  Struct for Establishment Ack 504
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EstablishmentAck504 {
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        NextSeqNo NextSeqNo;
        PreviousSeqNo PreviousSeqNo;
        PreviousUuid PreviousUuid;
        KeepAliveInterval KeepAliveInterval;
        SecretKeySecureIdExpiration SecretKeySecureIdExpiration;
        FaultToleranceIndicator FaultToleranceIndicator;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Establishment Reject 505
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EstablishmentReject505 {
        Reason Reason;
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        NextSeqNo NextSeqNo;
        ErrorCodes ErrorCodes;
        FaultToleranceIndicator FaultToleranceIndicator;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Exec Inst
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecInst {
        Reserved5 Reserved5;
        Reserved4 Reserved4;
        Reserved3 Reserved3;
        Reserved2 Reserved2;
        Reserved1 Reserved1;
        Nh Nh;
        Ob Ob;
        Aon Aon;
    };


    /// <summary>
    ///  Struct for Execution Ack 539
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionAck539 {
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        ExecAckStatus ExecAckStatus;
        SeqNum SeqNum;
        Clordid Clordid;
        SecExecId SecExecId;
        LastPx LastPx;
        SecurityId SecurityId;
        LastQty LastQty;
        DkReason DkReason;
        Side Side;
        SenderId SenderId;
        SendingTimeEpoch SendingTimeEpoch;
        Location Location;
        ManualOrderIndicator ManualOrderIndicator;
    };


    /// <summary>
    ///  Struct for Execution Report Cancel 534
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportCancel534 {
        SeqNum SeqNum;
        Uuid Uuid;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        Price Price;
        StopPx StopPx;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        CrossIdOptional CrossIdOptional;
        HostCrossId HostCrossId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        CumQty CumQty;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        DelayDuration DelayDuration;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        ExecRestatementReason ExecRestatementReason;
        CrossType CrossType;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DelayToTime DelayToTime;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Elimination 524
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportElimination524 {
        SeqNum SeqNum;
        Uuid Uuid;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        Price Price;
        StopPx StopPx;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        CrossIdOptional CrossIdOptional;
        HostCrossId HostCrossId;
        Location Location;
        SecurityId SecurityId;
        CumQty CumQty;
        OrderQty OrderQty;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        CrossType CrossType;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Modify 531
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportModify531 {
        SeqNum SeqNum;
        Uuid Uuid;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        Price Price;
        StopPx StopPx;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        CrossIdOptional CrossIdOptional;
        HostCrossId HostCrossId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        CumQty CumQty;
        Leaves Leaves;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        DelayDuration DelayDuration;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        CrossType CrossType;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DelayToTime DelayToTime;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report New 522
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportNew522 {
        SeqNum SeqNum;
        Uuid Uuid;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        Price Price;
        StopPx StopPx;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        CrossIdOptional CrossIdOptional;
        HostCrossId HostCrossId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        DelayDuration DelayDuration;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        CrossType CrossType;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DelayToTime DelayToTime;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Pending Cancel 564
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportPendingCancel564 {
        SeqNum SeqNum;
        Uuid Uuid;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        Price Price;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        CumQty CumQty;
        LeavesQtyOptional LeavesQtyOptional;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        LiquidityFlag LiquidityFlag;
        DelayToTime DelayToTime;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Pending Replace 565
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportPendingReplace565 {
        SeqNum SeqNum;
        Uuid Uuid;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        Price Price;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        CumQty CumQty;
        Leaves Leaves;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        LiquidityFlag LiquidityFlag;
        ShortSaleType ShortSaleType;
        DelayToTime DelayToTime;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Reject 523
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportReject523 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        PriceOptional PriceOptional;
        StopPx StopPx;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        CrossIdOptional CrossIdOptional;
        HostCrossId HostCrossId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        MinQty MinQty;
        DisplayQty DisplayQty;
        OrdRejReason OrdRejReason;
        ExpireDate ExpireDate;
        DelayDuration DelayDuration;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        CrossType CrossType;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DelayToTime DelayToTime;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Status 532
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportStatus532 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        PriceOptional PriceOptional;
        StopPx StopPx;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        OrdStatusReqIdOptional OrdStatusReqIdOptional;
        MassStatusReqIdOptional MassStatusReqIdOptional;
        CrossIdOptional CrossIdOptional;
        HostCrossId HostCrossId;
        Location Location;
        SecurityId SecurityId;
        OrderQty OrderQty;
        CumQty CumQty;
        Leaves Leaves;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        OrdStatus OrdStatus;
        OrdTypeOptional OrdTypeOptional;
        Side Side;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        LastRptRequested LastRptRequested;
        CrossType CrossType;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Outright Order Event Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumOutrightOrderEventGroup {
        OrderEventPx OrderEventPx;
        OrderEventText OrderEventText;
        OrderEventExecId OrderEventExecId;
        OrderEventQty OrderEventQty;
        TradeAddendum TradeAddendum;
        OrderEventReason OrderEventReason;
        OriginalOrderEventExecId OriginalOrderEventExecId;
        ContraGrossTradeAmt ContraGrossTradeAmt;
        ContraCalculatedCcyLastQty ContraCalculatedCcyLastQty;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Outright Order Event Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumOutrightOrderEventGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Spread Leg Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumSpreadLegGroup {
        LegExecId LegExecId;
        LegLastPx LegLastPx;
        LegExecRefId LegExecRefId;
        LegTradeId LegTradeId;
        LegTradeRefId LegTradeRefId;
        LegSecurityId LegSecurityId;
        LegLastQty LegLastQty;
        LegSide LegSide;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Spread Leg Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumSpreadLegGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Spread Leg Order Event Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumSpreadLegOrderEventGroup {
        OrderEventPx OrderEventPx;
        OrderEventText OrderEventText;
        OrderEventExecId OrderEventExecId;
        OrderEventQty OrderEventQty;
        TradeAddendum TradeAddendum;
        OrderEventReason OrderEventReason;
        OriginalOrderEventExecId OriginalOrderEventExecId;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Spread Leg Order Event Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumSpreadLegOrderEventGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Spread Order Event Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumSpreadOrderEventGroup {
        OrderEventPx OrderEventPx;
        OrderEventText OrderEventText;
        OrderEventExecId OrderEventExecId;
        OrderEventQty OrderEventQty;
        TradeAddendum TradeAddendum;
        OrderEventReason OrderEventReason;
        OriginalOrderEventExecId OriginalOrderEventExecId;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Addendum Spread Order Event Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeAddendumSpreadOrderEventGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Outright Order Event Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeOutrightOrderEventGroup {
        OrderEventPx OrderEventPx;
        OrderEventText OrderEventText;
        OrderEventExecId OrderEventExecId;
        OrderEventQty OrderEventQty;
        OrderEventType OrderEventType;
        OrderEventReason OrderEventReason;
        ContraGrossTradeAmt ContraGrossTradeAmt;
        ContraCalculatedCcyLastQty ContraCalculatedCcyLastQty;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Outright Order Event Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeOutrightOrderEventGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Spread Leg Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeSpreadLegGroup {
        LegExecId LegExecId;
        LegLastPx LegLastPx;
        LegSecurityId LegSecurityId;
        LegTradeId LegTradeId;
        LegLastQty LegLastQty;
        LegSide LegSide;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Spread Leg Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeSpreadLegGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Spread Leg Order Event Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeSpreadLegOrderEventGroup {
        OrderEventPx OrderEventPx;
        OrderEventText OrderEventText;
        OrderEventExecId OrderEventExecId;
        OrderEventQty OrderEventQty;
        OrderEventType OrderEventType;
        OrderEventReason OrderEventReason;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Spread Leg Order Event Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeSpreadLegOrderEventGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Spread Order Event Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeSpreadOrderEventGroup {
        OrderEventPx OrderEventPx;
        OrderEventText OrderEventText;
        OrderEventExecId OrderEventExecId;
        OrderEventQty OrderEventQty;
        OrderEventType OrderEventType;
        OrderEventReason OrderEventReason;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Spread Order Event Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeSpreadOrderEventGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Fills Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FillsGroup {
        FillPx FillPx;
        FillQty FillQty;
        FillExecId FillExecId;
        FillYieldType FillYieldType;
    };


    /// <summary>
    ///  Struct for Fills Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FillsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Gross Trade Amt
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GrossTradeAmt {
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
    ///  Struct for Leg Option Delta
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegOptionDelta {
        Mantissa32 Mantissa32;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Mass Quote 517
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuote517 {
        PartyDetailsListReqId PartyDetailsListReqId;
        SendingTimeEpoch SendingTimeEpoch;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        QuoteReqIdOptional QuoteReqIdOptional;
        Location Location;
        QuoteId QuoteId;
        TotNoQuoteEntries TotNoQuoteEntries;
        MmProtectionReset MmProtectionReset;
        LiquidityFlag LiquidityFlag;
        ShortSaleType ShortSaleType;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Mass Quote Ack 545
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteAck545 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        SenderId SenderId;
        PartyDetailsListReqId PartyDetailsListReqId;
        RequestTime RequestTime;
        SendingTimeEpoch SendingTimeEpoch;
        QuoteReqIdOptional QuoteReqIdOptional;
        Location Location;
        QuoteId QuoteId;
        QuoteRejectReason QuoteRejectReason;
        DelayDuration DelayDuration;
        QuoteAckStatus QuoteAckStatus;
        ManualOrderIndicator ManualOrderIndicator;
        NoProcessedEntries NoProcessedEntries;
        MmProtectionReset MmProtectionReset;
        SplitMsg SplitMsg;
        LiquidityFlag LiquidityFlag;
        ShortSaleType ShortSaleType;
        TotNoQuoteEntriesOptional TotNoQuoteEntriesOptional;
        PossRetransFlag PossRetransFlag;
        DelayToTime DelayToTime;
    };


    /// <summary>
    ///  Struct for Mass Quote Ack Entry Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteAckEntryGroup {
        QuoteEntryId QuoteEntryId;
        SecurityId SecurityId;
        QuoteSetId QuoteSetId;
        QuoteEntryRejectReason QuoteEntryRejectReason;
    };


    /// <summary>
    ///  Struct for Mass Quote Ack Entry Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteAckEntryGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Mass Quote Entry Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteEntryGroup {
        BidPx BidPx;
        OfferPx OfferPx;
        QuoteEntryId QuoteEntryId;
        SecurityId SecurityId;
        BidSize BidSize;
        OfferSize OfferSize;
        UnderlyingSecurityId UnderlyingSecurityId;
        QuoteSetId QuoteSetId;
    };


    /// <summary>
    ///  Struct for Mass Quote Entry Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteEntryGroups {
        GroupSize GroupSize;
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
    ///  Struct for Negotiate 500
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Negotiate500 {
        HmacSignature HmacSignature;
        AccessKeyId AccessKeyId;
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        Session Session;
        Firm Firm;
    };


    /// <summary>
    ///  Struct for Negotiation Reject 502
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NegotiationReject502 {
        Reason Reason;
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        ErrorCodes ErrorCodes;
        FaultToleranceIndicator FaultToleranceIndicator;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Negotiation Response 501
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NegotiationResponse501 {
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        SecretKeySecureIdExpiration SecretKeySecureIdExpiration;
        FaultToleranceIndicator FaultToleranceIndicator;
        SplitMsg SplitMsg;
        PreviousSeqNo PreviousSeqNo;
        PreviousUuid PreviousUuid;
    };


    /// <summary>
    ///  Struct for New Order Cross 544
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCross544 {
        CrossId CrossId;
        OrderRequestId OrderRequestId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        Price Price;
        TransBkdTime TransBkdTime;
        SendingTimeEpoch SendingTimeEpoch;
        Location Location;
        SecurityId SecurityId;
    };


    /// <summary>
    ///  Struct for New Order Single 514
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingle514 {
        PriceOptional PriceOptional;
        OrderQty OrderQty;
        SecurityId SecurityId;
        Side Side;
        SeqNum SeqNum;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderRequestId OrderRequestId;
        SendingTimeEpoch SendingTimeEpoch;
        StopPx StopPx;
        Location Location;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        OrdType OrdType;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Not Applied 513
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotApplied513 {
        Uuid Uuid;
        FromSeqNo FromSeqNo;
        MsgCount MsgCount;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Option Delta
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionDelta {
        Mantissa32 Mantissa32;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Order Cancel Reject 535
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelReject535 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        Location Location;
        CxlRejReason CxlRejReason;
        DelayDuration DelayDuration;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        LiquidityFlag LiquidityFlag;
        DelayToTime DelayToTime;
    };


    /// <summary>
    ///  Struct for Order Cancel Replace Reject 536
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelReplaceReject536 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        ExecId ExecId;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderId OrderId;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        Location Location;
        CxlRejReason CxlRejReason;
        DelayDuration DelayDuration;
        ManualOrderIndicator ManualOrderIndicator;
        PossRetransFlag PossRetransFlag;
        SplitMsg SplitMsg;
        LiquidityFlag LiquidityFlag;
        DelayToTime DelayToTime;
    };


    /// <summary>
    ///  Struct for Order Cancel Replace Request 515
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelReplaceRequest515 {
        PriceOptional PriceOptional;
        OrderQty OrderQty;
        SecurityId SecurityId;
        Side Side;
        SeqNum SeqNum;
        SenderId SenderId;
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderIdOptional OrderIdOptional;
        StopPx StopPx;
        OrderRequestId OrderRequestId;
        SendingTimeEpoch SendingTimeEpoch;
        Location Location;
        MinQty MinQty;
        DisplayQty DisplayQty;
        ExpireDate ExpireDate;
        OrdType OrdType;
        TimeInForce TimeInForce;
        ManualOrderIndicator ManualOrderIndicator;
        OfmOverride OfmOverride;
        ExecInst ExecInst;
        ExecutionMode ExecutionMode;
        LiquidityFlag LiquidityFlag;
        ManagedOrder ManagedOrder;
        ShortSaleType ShortSaleType;
        DiscretionPrice DiscretionPrice;
    };


    /// <summary>
    ///  Struct for Order Cancel Request 516
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelRequest516 {
        OrderIdOptional OrderIdOptional;
        PartyDetailsListReqId PartyDetailsListReqId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        Clordid Clordid;
        OrderRequestId OrderRequestId;
        SendingTimeEpoch SendingTimeEpoch;
        Location Location;
        SecurityId SecurityId;
        Side Side;
        LiquidityFlag LiquidityFlag;
    };


    /// <summary>
    ///  Struct for Order Mass Action Report 562
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderMassActionReport562 {
        SeqNum SeqNum;
        Uuid Uuid;
        SenderId SenderId;
        PartyDetailsListReqId PartyDetailsListReqId;
        TransactTime TransactTime;
        SendingTimeEpoch SendingTimeEpoch;
        OrderRequestId OrderRequestId;
        MassActionReportId MassActionReportId;
        SecurityGroup SecurityGroup;
        Location Location;
        SecurityIdOptional SecurityIdOptional;
        DelayDuration DelayDuration;
        MassActionResponse MassActionResponse;
        ManualOrderIndicator ManualOrderIndicator;
        MassActionScope MassActionScope;
        TotalAffectedOrders TotalAffectedOrders;
        LastFragment LastFragment;
        MassActionRejectReason MassActionRejectReason;
        MarketSegmentId MarketSegmentId;
        MassCancelRequestType MassCancelRequestType;
        SideOptional SideOptional;
        MassActionOrdTyp MassActionOrdTyp;
        MassCancelTif MassCancelTif;
        SplitMsg SplitMsg;
        LiquidityFlag LiquidityFlag;
        PossRetransFlag PossRetransFlag;
        DelayToTime DelayToTime;
    };


    /// <summary>
    ///  Struct for Order Mass Action Request 529
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderMassActionRequest529 {
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderRequestId OrderRequestId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        SendingTimeEpoch SendingTimeEpoch;
        SecurityGroup SecurityGroup;
        Location Location;
        SecurityIdOptional SecurityIdOptional;
        MassActionScope MassActionScope;
        MarketSegmentId MarketSegmentId;
        MassCancelRequestType MassCancelRequestType;
        SideOptional SideOptional;
        MassActionOrdTyp MassActionOrdTyp;
        MassCancelTif MassCancelTif;
        LiquidityFlag LiquidityFlag;
    };


    /// <summary>
    ///  Struct for Order Mass Status Request 530
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderMassStatusRequest530 {
        PartyDetailsListReqId PartyDetailsListReqId;
        MassStatusReqId MassStatusReqId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        SendingTimeEpoch SendingTimeEpoch;
        SecurityGroup SecurityGroup;
        Location Location;
        SecurityIdOptional SecurityIdOptional;
        MassStatusReqType MassStatusReqType;
        OrdStatusReqType OrdStatusReqType;
        MassStatusTif MassStatusTif;
        MarketSegmentId MarketSegmentId;
    };


    /// <summary>
    ///  Struct for Order Status Request 533
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderStatusRequest533 {
        PartyDetailsListReqId PartyDetailsListReqId;
        OrdStatusReqId OrdStatusReqId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        OrderId OrderId;
        SendingTimeEpoch SendingTimeEpoch;
        Location Location;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
    };


    /// <summary>
    ///  Struct for Party Details Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyDetailsGroup {
        PartyDetailId PartyDetailId;
        PartyDetailRole PartyDetailRole;
    };


    /// <summary>
    ///  Struct for Party Details Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyDetailsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Party I Ds Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyIDsGroup {
        PartyId PartyId;
        PartyIdSource PartyIdSource;
        PartyRole PartyRole;
    };


    /// <summary>
    ///  Struct for Party I Ds Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyIDsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Quote Cancel Ack Entry Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelAckEntryGroup {
        QuoteEntryId QuoteEntryId;
        SecurityId SecurityId;
        QuoteEntryRejectReason QuoteEntryRejectReason;
    };


    /// <summary>
    ///  Struct for Quote Cancel Ack Entry Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelAckEntryGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Quote Cancel Ack Set Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelAckSetGroup {
        QuoteSetId QuoteSetId;
        QuoteErrorCode QuoteErrorCode;
    };


    /// <summary>
    ///  Struct for Quote Cancel Ack Set Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelAckSetGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Quote Cancel Entry Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelEntryGroup {
        SecurityGroup SecurityGroup;
        SecurityIdOptional SecurityIdOptional;
    };


    /// <summary>
    ///  Struct for Quote Cancel Entry Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelEntryGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Quote Cancel Set Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelSetGroup {
        BidSize BidSize;
        OfferSize OfferSize;
        QuoteSetId QuoteSetId;
    };


    /// <summary>
    ///  Struct for Quote Cancel Set Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelSetGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Related Sym Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroup {
        SecurityId SecurityId;
        OrderQtyOptional OrderQtyOptional;
        RfqSide RfqSide;
    };


    /// <summary>
    ///  Struct for Related Sym Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Request For Quote 543
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestForQuote543 {
        PartyDetailsListReqId PartyDetailsListReqId;
        QuoteReqId QuoteReqId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderId SenderId;
        SendingTimeEpoch SendingTimeEpoch;
        Location Location;
        QuoteType QuoteType;
    };


    /// <summary>
    ///  Struct for Request For Quote Ack 546
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestForQuoteAck546 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        SenderId SenderId;
        ExchangeQuoteReqId ExchangeQuoteReqId;
        PartyDetailsListReqId PartyDetailsListReqId;
        RequestTime RequestTime;
        SendingTimeEpoch SendingTimeEpoch;
        QuoteReqId QuoteReqId;
        Location Location;
        QuoteRejectReason QuoteRejectReason;
        DelayDuration DelayDuration;
        QuoteAckStatus QuoteAckStatus;
        ManualOrderIndicator ManualOrderIndicator;
        SplitMsg SplitMsg;
        PossRetransFlag PossRetransFlag;
        DelayToTime DelayToTime;
    };


    /// <summary>
    ///  Struct for Requesting Party I Ds Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestingPartyIDsGroup {
        RequestingPartyId RequestingPartyId;
        RequestingPartyIdSource RequestingPartyIdSource;
        RequestingPartyRole RequestingPartyRole;
    };


    /// <summary>
    ///  Struct for Requesting Party I Ds Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestingPartyIDsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Retransmission 509
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Retransmission509 {
        Uuid Uuid;
        LastUuid LastUuid;
        RequestTimestamp RequestTimestamp;
        FromSeqNo FromSeqNo;
        MsgCount16 MsgCount16;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Retransmit Reject 510
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmitReject510 {
        Reason Reason;
        Uuid Uuid;
        LastUuid LastUuid;
        RequestTimestamp RequestTimestamp;
        ErrorCodes ErrorCodes;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Retransmit Request 508
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmitRequest508 {
        Uuid Uuid;
        LastUuid LastUuid;
        RequestTimestamp RequestTimestamp;
        FromSeqNo FromSeqNo;
        MsgCount16 MsgCount16;
    };


    /// <summary>
    ///  Struct for Risk Free Rate
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskFreeRate {
        Mantissa32 Mantissa32;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Security Definition Request 560
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionRequest560 {
        PartyDetailsListReqId PartyDetailsListReqId;
        SecurityReqId SecurityReqId;
        ManualOrderIndicator ManualOrderIndicator;
        SeqNum SeqNum;
        SenderIdOptional SenderIdOptional;
        SendingTimeEpoch SendingTimeEpoch;
        SecuritySubType SecuritySubType;
        Location Location;
        StartDate StartDate;
        EndDate EndDate;
        MaxNoOfSubstitutions MaxNoOfSubstitutions;
        SourceRepoId SourceRepoId;
    };


    /// <summary>
    ///  Struct for Security Definition Request Leg Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionRequestLegGroup {
        LegPrice LegPrice;
        LegSecurityId LegSecurityId;
        LegOptionDelta LegOptionDelta;
        LegSide LegSide;
        LegRatioQty LegRatioQty;
    };


    /// <summary>
    ///  Struct for Security Definition Request Leg Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionRequestLegGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Security Definition Response 561
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionResponse561 {
        SeqNum SeqNum;
        Uuid Uuid;
        Text Text;
        FinancialInstrumentFullName FinancialInstrumentFullName;
        SenderId SenderId;
        Symbol Symbol;
        PartyDetailsListReqId PartyDetailsListReqId;
        SecurityReqId SecurityReqId;
        SecurityResponseId SecurityResponseId;
        SendingTimeEpoch SendingTimeEpoch;
        SecurityGroup SecurityGroup;
        SecurityType SecurityType;
        Location Location;
        SecurityIdOptional SecurityIdOptional;
        Currency Currency;
        MaturityMonthYear MaturityMonthYear;
        DelayDuration DelayDuration;
        StartDate StartDate;
        EndDate EndDate;
        MaxNoOfSubstitutions MaxNoOfSubstitutions;
        SourceRepoId SourceRepoId;
        TerminationType TerminationType;
        SecurityResponseType SecurityResponseType;
        ExpirationCycle ExpirationCycle;
        ManualOrderIndicator ManualOrderIndicator;
        SplitMsg SplitMsg;
        AutoQuoteRequest AutoQuoteRequest;
        PossRetransFlag PossRetransFlag;
    };


    /// <summary>
    ///  Struct for Security Definition Response Leg Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionResponseLegGroup {
        LegPrice LegPrice;
        LegOptionDelta LegOptionDelta;
        LegSecurityId LegSecurityId;
        LegSide LegSide;
        LegRatioQty LegRatioQty;
    };


    /// <summary>
    ///  Struct for Security Definition Response Leg Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionResponseLegGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Sequence 506
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Sequence506 {
        Uuid Uuid;
        NextSeqNo NextSeqNo;
        FaultToleranceIndicator FaultToleranceIndicator;
        KeepAliveIntervalLapsed KeepAliveIntervalLapsed;
    };


    /// <summary>
    ///  Struct for Sides Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SidesGroup {
        Clordid Clordid;
        PartyDetailsListReqId PartyDetailsListReqId;
        OrderQty OrderQty;
        Side Side;
        SideTimeInForce SideTimeInForce;
    };


    /// <summary>
    ///  Struct for Sides Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SidesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Simple Open Frame
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SimpleOpenFrame {
        SimpleOpenFramingHeader SimpleOpenFramingHeader;
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Simple Open Framing Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SimpleOpenFramingHeader {
        MessageLength MessageLength;
        EncodingType EncodingType;
    };


    /// <summary>
    ///  Struct for Terminate 507
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Terminate507 {
        Reason Reason;
        Uuid Uuid;
        RequestTimestamp RequestTimestamp;
        ErrorCodes ErrorCodes;
        SplitMsg SplitMsg;
    };


    /// <summary>
    ///  Struct for Time To Expiration
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeToExpiration {
        Mantissa32 Mantissa32;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Trd Reg Publications Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TrdRegPublicationsGroup {
        TrdRegPublicationType TrdRegPublicationType;
        TrdRegPublicationReason TrdRegPublicationReason;
    };


    /// <summary>
    ///  Struct for Trd Reg Publications Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TrdRegPublicationsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Volatility
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Volatility {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
