namespace Eurex.Derivatives.Eti.T7.v2.5 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Account
    /// </summary>
    public unsafe struct Account {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Aggressor Indicator Values
    /// </summary>
    public enum AggressorIndicator : byte {
        Passive = 0,
        Agressor = 1,
        AggressorIndicatorMinimumValue = 1,
        AggressorIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Appl Beg Msg Id
    /// </summary>
    public unsafe struct ApplBegMsgId {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Appl Beg Seq Num
    /// </summary>
    public unsafe struct ApplBegSeqNum {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Appl End Msg Id
    /// </summary>
    public unsafe struct ApplEndMsgId {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Appl End Seq Num
    /// </summary>
    public unsafe struct ApplEndSeqNum {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Appl Id Values
    /// </summary>
    public enum ApplId : byte {
        Trade = 1,
        News = 2,
        Serviceavailability = 3,
        Sessiondata = 4,
        Listenerdata = 5,
        RiskControl = 6,
        ApplIDMinimumValue = 6,
        ApplIDMinimumValue = 0,
    };


    /// <summary>
    ///  Appl Id Status Values
    /// </summary>
    public enum ApplIdStatus : uint {
        Outboundconversionerror = 105,
        ApplIdStatusMinimumValue = 4294967294,
        ApplIdStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Appl Msg Id
    /// </summary>
    public unsafe struct ApplMsgId {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Appl Resend Flag Values
    /// </summary>
    public enum ApplResendFlag : byte {
        False = 0,
        True = 1,
        ApplResendFlagMinimumValue = 1,
        ApplResendFlagMinimumValue = 0,
    };


    /// <summary>
    ///  Appl Seq Indicator Values
    /// </summary>
    public enum ApplSeqIndicator : byte {
        NoRecoveryRequired = 0,
        RecoveryRequired = 1,
        ApplSeqIndicatorMinimumValue = 1,
        ApplSeqIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Appl Seq Num
    /// </summary>
    public unsafe struct ApplSeqNum {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Appl Seq Status Values
    /// </summary>
    public enum ApplSeqStatus : byte {
        Unavailable = 0,
        Available = 1,
        ApplSeqStatusMinimumValue = 1,
        ApplSeqStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Appl Seq Trade Date
    /// </summary>
    public unsafe struct ApplSeqTradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Appl Sub Id
    /// </summary>
    public unsafe struct ApplSubId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Appl Total Message Count
    /// </summary>
    public unsafe struct ApplTotalMessageCount {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Appl Usage Orders Values
    /// </summary>
    public enum ApplUsageOrders : byte {
        Automated = (byte)'A',
        Manual = (byte)'M',
        AutoSelect = (byte)'B',
        None = (byte)'N',
    };


    /// <summary>
    ///  Appl Usage Quotes Values
    /// </summary>
    public enum ApplUsageQuotes : byte {
        Automated = (byte)'A',
        Manual = (byte)'M',
        AutoSelect = (byte)'B',
        None = (byte)'N',
    };


    /// <summary>
    ///  Application System Name
    /// </summary>
    public unsafe struct ApplicationSystemName {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Application System Vendor
    /// </summary>
    public unsafe struct ApplicationSystemVendor {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Application System Version
    /// </summary>
    public unsafe struct ApplicationSystemVersion {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Cxl Size
    /// </summary>
    public struct BidCxlSize {
        public int Raw;
    };


    /// <summary>
    ///  Bid Px
    /// </summary>
    public unsafe struct BidPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public struct BidSize {
        public int Raw;
    };


    /// <summary>
    ///  Body Len
    /// </summary>
    public unsafe struct BodyLen {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cl Ord Id
    /// </summary>
    public unsafe struct ClOrdId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Trade Price
    /// </summary>
    public unsafe struct ClearingTradePrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Trade Qty
    /// </summary>
    public struct ClearingTradeQty {
        public int Raw;
    };


    /// <summary>
    ///  Compliance Id
    /// </summary>
    public unsafe struct ComplianceId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Compliance Text
    /// </summary>
    public unsafe struct ComplianceText {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cum Qty
    /// </summary>
    public struct CumQty {
        public int Raw;
    };


    /// <summary>
    ///  Cust Order Handling Inst
    /// </summary>
    public unsafe struct CustOrderHandlingInst {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cxl Qty
    /// </summary>
    public struct CxlQty {
        public int Raw;
    };


    /// <summary>
    ///  Default Cstm Appl Ver Id
    /// </summary>
    public unsafe struct DefaultCstmApplVerId {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Delta
    /// </summary>
    public struct Delta {
        public int Raw;
    };


    /// <summary>
    ///  Enrichment Rule Id
    /// </summary>
    public unsafe struct EnrichmentRuleId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Id
    /// </summary>
    public unsafe struct ExecId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Inst Values
    /// </summary>
    public enum ExecInst : byte {
        H = 1,
        Q = 2,
        Hq = 3,
        H6 = 5,
        Q6 = 6,
        ExecInstMinimumValue = 6,
        ExecInstMinimumValue = 1,
    };


    /// <summary>
    ///  Exec Restatement Reason Values
    /// </summary>
    public enum ExecRestatementReason : ushort {
        OrderBookRestatement = 001,
        OrderAdded = 101,
        OrderModified = 102,
        OrderCancelled = 103,
        IocOrderCancelled = 105,
        BookOrderExecuted = 108,
        MarketOrderTriggered = 135,
        CaoOrderActivated = 149,
        CaoOrderInactivated = 150,
        OcoOrderTriggered = 164,
        StopOrderTriggered = 172,
        OwnershipChanged = 181,
        OrderCancellationPending = 197,
        PendingCancellationExecuted = 199,
        BocOrderCancelled = 212,
        ExecRestatementReasonMinimumValue = 299,
        ExecRestatementReasonMinimumValue = 0,
    };


    /// <summary>
    ///  Exec Type Values
    /// </summary>
    public enum ExecType : byte {
        New = (byte)'0',
        Canceled = (byte)'4',
        Replaced = (byte)'5',
        PendingCancele = (byte)'6',
        Suspended = (byte)'9',
        Restated = (byte)'D',
        Triggered = (byte)'L',
        Trade = (byte)'F',
    };


    /// <summary>
    ///  Expire Date
    /// </summary>
    public unsafe struct ExpireDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exposure Duration
    /// </summary>
    public struct ExposureDuration {
        public long Raw;
    };


    /// <summary>
    ///  Fill Exec Id
    /// </summary>
    public struct FillExecId {
        public int Raw;
    };


    /// <summary>
    ///  Fill Liquidity Ind Values
    /// </summary>
    public enum FillLiquidityInd : byte {
        AddedLiquidity = 1,
        RemovedLiquidity = 2,
        TriggeredStopOrder = 5,
        TriggeredOcoOrder = 6,
        TriggeredMarketOrder = 7,
        FillLiquidityIndMinimumValue = 7,
        FillLiquidityIndMinimumValue = 1,
    };


    /// <summary>
    ///  Fill Match Id
    /// </summary>
    public unsafe struct FillMatchId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fill Px
    /// </summary>
    public unsafe struct FillPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fill Qty
    /// </summary>
    public struct FillQty {
        public int Raw;
    };


    /// <summary>
    ///  Fix Engine Name
    /// </summary>
    public unsafe struct FixEngineName {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fix Engine Vendor
    /// </summary>
    public unsafe struct FixEngineVendor {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fix Engine Version
    /// </summary>
    public unsafe struct FixEngineVersion {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Free Text 1
    /// </summary>
    public unsafe struct FreeText1 {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Free Text 2
    /// </summary>
    public unsafe struct FreeText2 {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Free Text 3
    /// </summary>
    public unsafe struct FreeText3 {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Gateway Id
    /// </summary>
    public unsafe struct GatewayId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Gateway Sub Id
    /// </summary>
    public unsafe struct GatewaySubId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Headline
    /// </summary>
    public unsafe struct Headline {
        public const int Size = 256;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Heart Bt Int
    /// </summary>
    public unsafe struct HeartBtInt {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Limit Price
    /// </summary>
    public unsafe struct HighLimitPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Implied Market Indicator Values
    /// </summary>
    public enum ImpliedMarketIndicator : byte {
        Notimplied = 0,
        Impliedinout = 3,
        ImpliedMarketIndicatorMinimumValue = 3,
        ImpliedMarketIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Last Entity Processed
    /// </summary>
    public unsafe struct LastEntityProcessed {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Fragment Values
    /// </summary>
    public enum LastFragment : byte {
        NotLastMessage = 0,
        LastMessage = 1,
        LastFragmentMinimumValue = 1,
        LastFragmentMinimumValue = 0,
    };


    /// <summary>
    ///  Last Px
    /// </summary>
    public unsafe struct LastPx {
        public const int Size = 8;

        public long Value;

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
    ///  Last Update Time
    /// </summary>
    public unsafe struct LastUpdateTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leaves Qty
    /// </summary>
    public struct LeavesQty {
        public int Raw;
    };


    /// <summary>
    ///  Leg Account
    /// </summary>
    public unsafe struct LegAccount {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Exec Id
    /// </summary>
    public struct LegExecId {
        public int Raw;
    };


    /// <summary>
    ///  Leg Last Px
    /// </summary>
    public unsafe struct LegLastPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Last Qty
    /// </summary>
    public struct LegLastQty {
        public int Raw;
    };


    /// <summary>
    ///  Leg Position Effect Values
    /// </summary>
    public enum LegPositionEffect : byte {
        Close = (byte)'C',
        Open = (byte)'O',
    };


    /// <summary>
    ///  Leg Price
    /// </summary>
    public unsafe struct LegPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public unsafe struct LegRatioQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Security Id
    /// </summary>
    public struct LegSecurityId {
        public long Raw;
    };


    /// <summary>
    ///  Leg Security Type Values
    /// </summary>
    public enum LegSecurityType : byte {
        MultilegInstrument = 1,
        UnderlyingLeg = 2,
        LegSecurityTypeMinimumValue = 2,
        LegSecurityTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        Buy = 1,
        Sell = 2,
        LegSideMinimumValue = 2,
        LegSideMinimumValue = 1,
    };


    /// <summary>
    ///  Leg Symbol
    /// </summary>
    public struct LegSymbol {
        public int Raw;
    };


    /// <summary>
    ///  List Update Action Values
    /// </summary>
    public enum ListUpdateAction : byte {
        Add = (byte)'A',
        Delete = (byte)'D',
    };


    /// <summary>
    ///  Low Limit Price
    /// </summary>
    public unsafe struct LowLimitPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        Xeur = 1,
        Xeee = 2,
        MarketIDMinimumValue = 255,
        MarketIDMinimumValue = 1,
    };


    /// <summary>
    ///  Market Segment Id
    /// </summary>
    public struct MarketSegmentId {
        public int Raw;
    };


    /// <summary>
    ///  Mass Action Reason Values
    /// </summary>
    public enum MassActionReason : byte {
        NoSpecialReason = 0,
        StopTrading = 1,
        Emergency = 2,
        MarketMakerProtection = 3,
        SessionLoss = 6,
        DuplicateSessionLogin = 7,
        ClearingRiskControl = 8,
        ProductStateHalt = 105,
        ProductStateHoliday = 106,
        InstrumentSuspended = 107,
        ComplexInstrumentDeletion = 109,
        VolatilityInterruption = 110,
        Producttemporarilynottradeable = 111,
        MassActionReasonMinimumValue = 200,
        MassActionReasonMinimumValue = 0,
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
    ///  Mass Action Type Values
    /// </summary>
    public enum MassActionType : byte {
        Suspendquotes = 1,
        Releasequotes = 2,
        MassActionTypeMinimumValue = 2,
        MassActionTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Match Date
    /// </summary>
    public unsafe struct MatchDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Match Sub Type Values
    /// </summary>
    public enum MatchSubType : byte {
        OpeningAuction = 1,
        ClosingAuction = 2,
        IntradayAuction = 3,
        CircuitBreakerAuction = 4,
        MatchSubTypeMinimumValue = 4,
        MatchSubTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Match Type Values
    /// </summary>
    public enum MatchType : byte {
        ConfirmedTradeReport = 3,
        Automatchincoming = 4,
        CrossAuction = 5,
        CallAuction = 7,
        Automatchresting = 11,
        MatchTypeMinimumValue = 12,
        MatchTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Matching Engine Status Values
    /// </summary>
    public enum MatchingEngineStatus : byte {
        Unavailable = 0,
        Available = 1,
        MatchingEngineStatusMinimumValue = 1,
        MatchingEngineStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Matching Engine Trade Date
    /// </summary>
    public unsafe struct MatchingEngineTradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mm Parameter Report Id
    /// </summary>
    public unsafe struct MmParameterReportId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Msg Seq Num
    /// </summary>
    public unsafe struct MsgSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Multi Leg Reporting Type Values
    /// </summary>
    public enum MultiLegReportingType : byte {
        Singlesecurity = 1,
        Individuallegofamultilegsecurity = 2,
        MultiLegReportingTypeMinimumValue = 2,
        MultiLegReportingTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Multileg Model Values
    /// </summary>
    public enum MultilegModel : byte {
        PredefinedMultilegSecurity = 0,
        UserdefinedMultleg = 1,
        MultilegModelMinimumValue = 1,
        MultilegModelMinimumValue = 0,
    };


    /// <summary>
    ///  Network Msg Id
    /// </summary>
    public unsafe struct NetworkMsgId {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Enrichment Rules
    /// </summary>
    public unsafe struct NoEnrichmentRules {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Fills
    /// </summary>
    public unsafe struct NoFills {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Fills Index
    /// </summary>
    public unsafe struct NoFillsIndex {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Leg Execs
    /// </summary>
    public unsafe struct NoLegExecs {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Legs
    /// </summary>
    public unsafe struct NoLegs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Mm Parameters
    /// </summary>
    public unsafe struct NoMmParameters {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Not Affected Orders
    /// </summary>
    public unsafe struct NoNotAffectedOrders {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Not Affected Securities
    /// </summary>
    public unsafe struct NoNotAffectedSecurities {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Party Details
    /// </summary>
    public unsafe struct NoPartyDetails {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Quote Entries
    /// </summary>
    public unsafe struct NoQuoteEntries {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Quote Events
    /// </summary>
    public unsafe struct NoQuoteEvents {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Quote Events Index
    /// </summary>
    public unsafe struct NoQuoteEventsIndex {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Sessions
    /// </summary>
    public unsafe struct NoSessions {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Not Aff Orig Cl Ord Id
    /// </summary>
    public unsafe struct NotAffOrigClOrdId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Not Affected Order Id
    /// </summary>
    public unsafe struct NotAffectedOrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Not Affected Security Id
    /// </summary>
    public unsafe struct NotAffectedSecurityId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Notification In
    /// </summary>
    public unsafe struct NotificationIn {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Securities
    /// </summary>
    public struct NumberOfSecurities {
        public int Raw;
    };


    /// <summary>
    ///  Offer Cxl Size
    /// </summary>
    public struct OfferCxlSize {
        public int Raw;
    };


    /// <summary>
    ///  Offer Px
    /// </summary>
    public unsafe struct OfferPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size
    /// </summary>
    public struct OfferSize {
        public int Raw;
    };


    /// <summary>
    ///  Ord Status Values
    /// </summary>
    public enum OrdStatus : byte {
        New = (byte)'0',
        Partiallyfilled = (byte)'1',
        Filled = (byte)'2',
        Canceled = (byte)'4',
        PendingCancel = (byte)'6',
        Suspended = (byte)'9',
    };


    /// <summary>
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        Market = 1,
        Limit = 2,
        Stop = 3,
        StopLimit = 4,
        OrdTypeMinimumValue = 4,
        OrdTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Order Category Values
    /// </summary>
    public enum OrderCategory : byte {
        Order = (byte)'1',
        Quote = (byte)'2',
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
    ///  Order Qty
    /// </summary>
    public struct OrderQty {
        public int Raw;
    };


    /// <summary>
    ///  Order Routing Indicator Values
    /// </summary>
    public enum OrderRoutingIndicator : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Order Side Values
    /// </summary>
    public enum OrderSide : byte {
        Buy = 1,
        Sell = 2,
        OrderSideMinimumValue = 2,
        OrderSideMinimumValue = 1,
    };


    /// <summary>
    ///  Orig Cl Ord Id
    /// </summary>
    public unsafe struct OrigClOrdId {
        public const int Size = 8;

        public long Value;

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
    ///  Orig Trade Id
    /// </summary>
    public unsafe struct OrigTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ownership Indicator Values
    /// </summary>
    public enum OwnershipIndicator : byte {
        NoChangeofOwnership = 0,
        ChangetoExecutingTrader = 1,
        OwnershipIndicatorMinimumValue = 1,
        OwnershipIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Pad 1
    /// </summary>
    public unsafe struct Pad1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 2
    /// </summary>
    public unsafe struct Pad2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 3
    /// </summary>
    public unsafe struct Pad3 {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 4
    /// </summary>
    public unsafe struct Pad4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 5
    /// </summary>
    public unsafe struct Pad5 {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 6
    /// </summary>
    public unsafe struct Pad6 {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 7
    /// </summary>
    public unsafe struct Pad7 {
        public const int Size = 7;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Partition Id
    /// </summary>
    public unsafe struct PartitionId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Action Type Values
    /// </summary>
    public enum PartyActionType : byte {
        HaltTrading = 1,
        Reinstate = 2,
        PartyActionTypeMinimumValue = 2,
        PartyActionTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Party Detail Desk Id
    /// </summary>
    public unsafe struct PartyDetailDeskId {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Executing Trader
    /// </summary>
    public unsafe struct PartyDetailExecutingTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Id Executing Trader
    /// </summary>
    public unsafe struct PartyDetailIdExecutingTrader {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Id Executing Unit
    /// </summary>
    public unsafe struct PartyDetailIdExecutingUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Detail Role Qualifier Values
    /// </summary>
    public enum PartyDetailRoleQualifier : byte {
        Trader = 10,
        HeadTrader = 11,
        Supervisor = 12,
        PartyDetailRoleQualifierMinimumValue = 12,
        PartyDetailRoleQualifierMinimumValue = 10,
    };


    /// <summary>
    ///  Party Detail Status Values
    /// </summary>
    public enum PartyDetailStatus : byte {
        Active = 0,
        Suspend = 1,
        PartyDetailStatusMinimumValue = 1,
        PartyDetailStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Party Id Beneficiary
    /// </summary>
    public unsafe struct PartyIdBeneficiary {
        public const int Size = 9;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Entering Firm Values
    /// </summary>
    public enum PartyIdEnteringFirm : byte {
        Participant = 1,
        MarketSupervision = 2,
        PartyIdEnteringFirmMinimumValue = 2,
        PartyIdEnteringFirmMinimumValue = 1,
    };


    /// <summary>
    ///  Party Id Entering Trader
    /// </summary>
    public unsafe struct PartyIdEnteringTrader {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Executing Trader
    /// </summary>
    public unsafe struct PartyIdExecutingTrader {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Executing Unit
    /// </summary>
    public unsafe struct PartyIdExecutingUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Location Id
    /// </summary>
    public unsafe struct PartyIdLocationId {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Order Origination Firm
    /// </summary>
    public unsafe struct PartyIdOrderOriginationFirm {
        public const int Size = 7;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Origination Market Values
    /// </summary>
    public enum PartyIdOriginationMarket : byte {
        Xkfe = 1,
        Xtaf = 2,
        PartyIdOriginationMarketMinimumValue = 2,
        PartyIdOriginationMarketMinimumValue = 1,
    };


    /// <summary>
    ///  Party Id Position Account
    /// </summary>
    public unsafe struct PartyIdPositionAccount {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Session Id
    /// </summary>
    public unsafe struct PartyIdSessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Take Up Trading Firm
    /// </summary>
    public unsafe struct PartyIdTakeUpTradingFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Password
    /// </summary>
    public unsafe struct Password {
        public const int Size = 32;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pct Count
    /// </summary>
    public struct PctCount {
        public int Raw;
    };


    /// <summary>
    ///  Position Effect Values
    /// </summary>
    public enum PositionEffect : byte {
        Close = (byte)'C',
        Open = (byte)'O',
    };


    /// <summary>
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Validity Check Type Values
    /// </summary>
    public enum PriceValidityCheckType : byte {
        None = 0,
        Optional = 1,
        Mandatory = 2,
        PriceValidityCheckTypeMinimumValue = 2,
        PriceValidityCheckTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Product Complex Values
    /// </summary>
    public enum ProductComplex : byte {
        Simpleinstrument = 1,
        Standardoptionstrategy = 2,
        Nonstandardoptionstrategy = 3,
        Volatilitystrategy = 4,
        FuturesSpread = 5,
        Interproductspread = 6,
        Standardfuturestrategy = 7,
        Packandbundle = 8,
        Strip = 9,
        ProductComplexMinimumValue = 9,
        ProductComplexMinimumValue = 1,
    };


    /// <summary>
    ///  Quote Entry Reject Reason Values
    /// </summary>
    public enum QuoteEntryRejectReason : uint {
        UnknownSecurity = 1,
        DuplicateQuote = 6,
        InvalidPrice = 8,
        NoReferencePriceAvailable = 16,
        NoSingleSidedQuotes = 100,
        InvalidQuotingModel = 103,
        InvalidSize = 106,
        InvalidUnderlyingPrice = 107,
        BidPriceNotReasonable = 108,
        AskPriceNotReasonable = 109,
        BidPriceExceedsRange = 110,
        AskPriceExceedsRange = 111,
        InstrumentStateFreeze = 115,
        DeletionAlreadyPending = 116,
        PreTradeRiskSessionLimitExceeded = 117,
        PreTradeRiskBuLimitExceeded = 118,
        EntitlementNotAssignedForUnderlying = 119,
        CantProcInCurrInstrState = 131,
        QuoteEntryRejectReasonMinimumValue = 65535,
        QuoteEntryRejectReasonMinimumValue = 0,
    };


    /// <summary>
    ///  Quote Entry Status Values
    /// </summary>
    public enum QuoteEntryStatus : byte {
        Accepted = 0,
        Rejected = 5,
        RemovedandRejected = 6,
        Pending = 10,
        QuoteEntryStatusMinimumValue = 100,
        QuoteEntryStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Quote Event Exec Id
    /// </summary>
    public struct QuoteEventExecId {
        public int Raw;
    };


    /// <summary>
    ///  Quote Event Liquidity Ind Values
    /// </summary>
    public enum QuoteEventLiquidityInd : byte {
        AddedLiquidity = 1,
        RemovedLiquidity = 2,
        QuoteEventLiquidityIndMinimumValue = 2,
        QuoteEventLiquidityIndMinimumValue = 1,
    };


    /// <summary>
    ///  Quote Event Match Id
    /// </summary>
    public unsafe struct QuoteEventMatchId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Event Px
    /// </summary>
    public unsafe struct QuoteEventPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Event Qty
    /// </summary>
    public struct QuoteEventQty {
        public int Raw;
    };


    /// <summary>
    ///  Quote Event Reason Values
    /// </summary>
    public enum QuoteEventReason : byte {
        Pendingcancellationexecuted = 14,
        Invalidprice = 15,
        QuoteEventReasonMinimumValue = 15,
        QuoteEventReasonMinimumValue = 14,
    };


    /// <summary>
    ///  Quote Event Side Values
    /// </summary>
    public enum QuoteEventSide : byte {
        Buy = 1,
        Sell = 2,
        QuoteEventSideMinimumValue = 2,
        QuoteEventSideMinimumValue = 1,
    };


    /// <summary>
    ///  Quote Event Type Values
    /// </summary>
    public enum QuoteEventType : byte {
        Removedquoteside = 3,
        Partiallyfilled = 4,
        Filled = 5,
        QuoteEventTypeMinimumValue = 5,
        QuoteEventTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Quote Id
    /// </summary>
    public unsafe struct QuoteId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Msg Id
    /// </summary>
    public unsafe struct QuoteMsgId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Response Id
    /// </summary>
    public unsafe struct QuoteResponseId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Size Type Values
    /// </summary>
    public enum QuoteSizeType : byte {
        TotalSize = 1,
        OpenSize = 2,
        QuoteSizeTypeMinimumValue = 2,
        QuoteSizeTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Ref Appl Id Values
    /// </summary>
    public enum RefApplId : byte {
        Trade = 1,
        News = 2,
        Serviceavailability = 3,
        Sessiondata = 4,
        Listenerdata = 5,
        RiskControl = 6,
        RefApplIDMinimumValue = 6,
        RefApplIDMinimumValue = 0,
    };


    /// <summary>
    ///  Ref Appl Last Msg Id
    /// </summary>
    public unsafe struct RefApplLastMsgId {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Ref Appl Last Seq Num
    /// </summary>
    public unsafe struct RefApplLastSeqNum {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ref Appl Sub Id
    /// </summary>
    public unsafe struct RefApplSubId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Related Product Complex Values
    /// </summary>
    public enum RelatedProductComplex : byte {
        Standardoptionstrategy = 2,
        Nonstandardoptionstrategy = 3,
        Volatilitystrategy = 4,
        FuturesSpread = 5,
        Interproductspread = 6,
        Standardfuturestrategy = 7,
        Packandbundle = 8,
        Strip = 9,
        RelatedProductComplexMinimumValue = 9,
        RelatedProductComplexMinimumValue = 1,
    };


    /// <summary>
    ///  Related Security Id
    /// </summary>
    public struct RelatedSecurityId {
        public long Raw;
    };


    /// <summary>
    ///  Related Symbol
    /// </summary>
    public struct RelatedSymbol {
        public int Raw;
    };


    /// <summary>
    ///  Request Out
    /// </summary>
    public unsafe struct RequestOut {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Requesting Party Clearing Firm
    /// </summary>
    public unsafe struct RequestingPartyClearingFirm {
        public const int Size = 9;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requesting Party Entering Firm
    /// </summary>
    public unsafe struct RequestingPartyEnteringFirm {
        public const int Size = 9;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requesting Party Id Entering Firm Values
    /// </summary>
    public enum RequestingPartyIdEnteringFirm : byte {
        Participant = 1,
        MarketSupervision = 2,
        RequestingPartyIdEnteringFirmMinimumValue = 2,
        RequestingPartyIdEnteringFirmMinimumValue = 1,
    };


    /// <summary>
    ///  Requesting Party Id Executing System Values
    /// </summary>
    public enum RequestingPartyIdExecutingSystem : uint {
        EurexClearing = 1,
        EurexTrading = 2,
        RequestingPartyIdExecutingSystemMinimumValue = 4294967294,
        RequestingPartyIdExecutingSystemMinimumValue = 0,
    };


    /// <summary>
    ///  Requesting Party Id Executing Trader
    /// </summary>
    public unsafe struct RequestingPartyIdExecutingTrader {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Response In
    /// </summary>
    public unsafe struct ResponseIn {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Action Values
    /// </summary>
    public enum RiskLimitAction : byte {
        Warning = 4,
        QueueInbound = 0,
        Reject = 2,
        RiskLimitActionMinimumValue = 4,
        RiskLimitActionMinimumValue = 0,
    };


    /// <summary>
    ///  Root Party Clearing Firm
    /// </summary>
    public unsafe struct RootPartyClearingFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Clearing Organization
    /// </summary>
    public unsafe struct RootPartyClearingOrganization {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Executing Firm
    /// </summary>
    public unsafe struct RootPartyExecutingFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Executing Trader
    /// </summary>
    public unsafe struct RootPartyExecutingTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Beneficiary
    /// </summary>
    public unsafe struct RootPartyIdBeneficiary {
        public const int Size = 9;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Clearing Unit
    /// </summary>
    public unsafe struct RootPartyIdClearingUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Executing Trader
    /// </summary>
    public unsafe struct RootPartyIdExecutingTrader {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Executing Unit
    /// </summary>
    public unsafe struct RootPartyIdExecutingUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Order Origination Firm
    /// </summary>
    public unsafe struct RootPartyIdOrderOriginationFirm {
        public const int Size = 7;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Position Account
    /// </summary>
    public unsafe struct RootPartyIdPositionAccount {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Session Id
    /// </summary>
    public unsafe struct RootPartyIdSessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Take Up Trading Firm
    /// </summary>
    public unsafe struct RootPartyIdTakeUpTradingFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secondary Gateway Id
    /// </summary>
    public unsafe struct SecondaryGatewayId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secondary Gateway Sub Id
    /// </summary>
    public unsafe struct SecondaryGatewaySubId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public struct SecurityId {
        public long Raw;
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
    ///  Security Sub Type
    /// </summary>
    public struct SecuritySubType {
        public int Raw;
    };


    /// <summary>
    ///  Sender Sub Id
    /// </summary>
    public unsafe struct SenderSubId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Session Instance Id
    /// </summary>
    public unsafe struct SessionInstanceId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Mode Values
    /// </summary>
    public enum SessionMode : byte {
        Hf = 1,
        Lf = 2,
        Gui = 3,
        SessionModeMinimumValue = 3,
        SessionModeMinimumValue = 1,
    };


    /// <summary>
    ///  Session Reject Reason Values
    /// </summary>
    public enum SessionRejectReason : uint {
        RequiredTagMissing = 1,
        Valueisincorrect = 5,
        Decryptionproblem = 7,
        InvalidMsgId = 11,
        IncorrectNumInGroupcount = 16,
        Other = 99,
        ThrottleLimitExceeded = 100,
        ExposureLimitExceeded = 101,
        ServiceTemporarilyNotAvailable = 102,
        ServiceNotAvailable = 103,
        ResultOfTransactionUnknown = 104,
        Outboundconversionerror = 105,
        HeartbeatViolation = 152,
        Internaltechnicalerror = 200,
        ValidationError = 210,
        UserAlreadyLoggedIn = 211,
        OrderNotFound = 10000,
        PriceNotReasonable = 10001,
        ClientOrderIdNotUnique = 10002,
        QuoteActivationInProgress = 10003,
        BuBookOrderLimitExceeded = 10004,
        SessionBookOrderLimitExceeded = 10005,
        CreateCiThrottleExceeded = 10010,
        SessionRejectReasonMinimumValue = 4294967294,
        SessionRejectReasonMinimumValue = 0,
    };


    /// <summary>
    ///  Session Status Values
    /// </summary>
    public enum SessionStatus : byte {
        Active = 0,
        Logout = 4,
        SessionStatusMinimumValue = 4,
        SessionStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Session Sub Mode Values
    /// </summary>
    public enum SessionSubMode : byte {
        Regulartradingsession = 0,
        FiXtradingsession = 1,
        RegularBackOfficesession = 2,
        SessionSubModeMinimumValue = 2,
        SessionSubModeMinimumValue = 0,
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = 1,
        Sell = 2,
        SideMinimumValue = 2,
        SideMinimumValue = 1,
    };


    /// <summary>
    ///  Side Last Px
    /// </summary>
    public unsafe struct SideLastPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Last Qty
    /// </summary>
    public struct SideLastQty {
        public int Raw;
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
    ///  Simple Security Id
    /// </summary>
    public unsafe struct SimpleSecurityId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stop Px
    /// </summary>
    public unsafe struct StopPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Link Id
    /// </summary>
    public unsafe struct StrategyLinkId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Subscription Scope
    /// </summary>
    public unsafe struct SubscriptionScope {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Party Id Desk Id
    /// </summary>
    public unsafe struct TargetPartyIdDeskId {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Party Id Executing Trader
    /// </summary>
    public unsafe struct TargetPartyIdExecutingTrader {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Party Id Session Id
    /// </summary>
    public unsafe struct TargetPartyIdSessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id
    /// </summary>
    public unsafe struct TemplateId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Throttle Disconnect Limit
    /// </summary>
    public unsafe struct ThrottleDisconnectLimit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Throttle No Msgs
    /// </summary>
    public unsafe struct ThrottleNoMsgs {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Throttle Time Interval
    /// </summary>
    public struct ThrottleTimeInterval {
        public long Raw;
    };


    /// <summary>
    ///  Time In Force Values
    /// </summary>
    public enum TimeInForce : byte {
        Day = 0,
        Gtc = 1,
        Ioc = 3,
        Gtd = 6,
        TimeInForceMinimumValue = 6,
        TimeInForceMinimumValue = 0,
    };


    /// <summary>
    ///  Tot Num Trade Reports
    /// </summary>
    public struct TotNumTradeReports {
        public int Raw;
    };


    /// <summary>
    ///  Trad Ses Event Values
    /// </summary>
    public enum TradSesEvent : byte {
        StartofService = 101,
        MarketReset = 102,
        EndofRestatement = 103,
        EndofDayService = 104,
        ServiceResumed = 105,
        TradSesEventMinimumValue = 105,
        TradSesEventMinimumValue = 100,
    };


    /// <summary>
    ///  Trad Ses Mode Values
    /// </summary>
    public enum TradSesMode : byte {
        Testing = 1,
        Simulated = 2,
        Production = 3,
        Acceptance = 4,
        TradSesModeMinimumValue = 4,
        TradSesModeMinimumValue = 1,
    };


    /// <summary>
    ///  Trade Date
    /// </summary>
    public unsafe struct TradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Manager Status Values
    /// </summary>
    public enum TradeManagerStatus : byte {
        Unavailable = 0,
        Available = 1,
        TradeManagerStatusMinimumValue = 1,
        TradeManagerStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Trade Manager Trade Date
    /// </summary>
    public unsafe struct TradeManagerTradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Report Type Values
    /// </summary>
    public enum TradeReportType : byte {
        Submit = 0,
        Alleged = 1,
        NoWasReplaced = 5,
        TradeBreak = 7,
        TradeReportTypeMinimumValue = 7,
        TradeReportTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Trading Capacity Values
    /// </summary>
    public enum TradingCapacity : byte {
        Customer = 1,
        Principal = 5,
        MarketMaker = 6,
        TradingCapacityMinimumValue = 6,
        TradingCapacityMinimumValue = 1,
    };


    /// <summary>
    ///  Trading Session Sub Id Values
    /// </summary>
    public enum TradingSessionSubId : byte {
        Closingauction = 4,
        TradingSessionSubIDMinimumValue = 7,
        TradingSessionSubIDMinimumValue = 1,
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
    ///  Transfer Reason Values
    /// </summary>
    public enum TransferReason : byte {
        Owner = 1,
        Clearer = 2,
        TransferReasonMinimumValue = 5,
        TransferReasonMinimumValue = 1,
    };


    /// <summary>
    ///  Trd Match Id
    /// </summary>
    public unsafe struct TrdMatchId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Reg Ts Entry Time
    /// </summary>
    public unsafe struct TrdRegTsEntryTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Reg Ts Time In
    /// </summary>
    public unsafe struct TrdRegTsTimeIn {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Reg Ts Time Out
    /// </summary>
    public unsafe struct TrdRegTsTimeOut {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Reg Ts Time Priority
    /// </summary>
    public unsafe struct TrdRegTsTimePriority {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Triggered Values
    /// </summary>
    public enum Triggered : byte {
        Nottriggered = 0,
        TriggeredStop = 1,
        TriggeredOco = 2,
        TriggeredMinimumValue = 2,
        TriggeredMinimumValue = 0,
    };


    /// <summary>
    ///  User Status Values
    /// </summary>
    public enum UserStatus : byte {
        Userstopped = 10,
        Userreleased = 11,
        UserStatusMinimumValue = 11,
        UserStatusMinimumValue = 10,
    };


    /// <summary>
    ///  Username
    /// </summary>
    public unsafe struct Username {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Var Text
    /// </summary>
    public unsafe struct VarText {
        public const int Size = 2000;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Var Text Len
    /// </summary>
    public unsafe struct VarTextLen {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Vega
    /// </summary>
    public struct Vega {
        public int Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Complex Instrument Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddComplexInstrumentRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        SecuritySubType SecuritySubType;
        ProductComplex ProductComplex;
        NoLegs NoLegs;
        ComplianceText ComplianceText;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Add Complex Instrument Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddComplexInstrumentResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        LowLimitPrice LowLimitPrice;
        HighLimitPrice HighLimitPrice;
        SecurityId SecurityId;
        LastUpdateTime LastUpdateTime;
        SecurityResponseId SecurityResponseId;
        MarketSegmentId MarketSegmentId;
        NumberOfSecurities NumberOfSecurities;
        SecuritySubType SecuritySubType;
        MultilegModel MultilegModel;
        ImpliedMarketIndicator ImpliedMarketIndicator;
        ProductComplex ProductComplex;
        NoLegs NoLegs;
    };


    /// <summary>
    ///  Struct for Broadcast Error Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BroadcastErrorNotification {
        MessageHeaderOut MessageHeaderOut;
        NotifHeader NotifHeader;
        ApplIdStatus ApplIdStatus;
        RefApplSubId RefApplSubId;
        VarTextLen VarTextLen;
        RefApplId RefApplId;
        SessionStatus SessionStatus;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Cross Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SecurityId SecurityId;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        ComplianceText ComplianceText;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Cross Request Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequestResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        ExecId ExecId;
    };


    /// <summary>
    ///  Struct for Delete All Order Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        MassActionReportId MassActionReportId;
        SecurityId SecurityId;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        NoNotAffectedOrders NoNotAffectedOrders;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        MassActionReason MassActionReason;
        ExecInst ExecInst;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Delete All Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderNrResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        MassActionReportId MassActionReportId;
    };


    /// <summary>
    ///  Struct for Delete All Order Quote Event Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderQuoteEventBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        MassActionReportId MassActionReportId;
        SecurityId SecurityId;
        MarketSegmentId MarketSegmentId;
        MassActionReason MassActionReason;
        ExecInst ExecInst;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Delete All Order Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SecurityId SecurityId;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Delete All Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeaderMe ResponseHeaderMe;
        MassActionReportId MassActionReportId;
        NoNotAffectedOrders NoNotAffectedOrders;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Delete All Quote Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllQuoteBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        MassActionReportId MassActionReportId;
        SecurityId SecurityId;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        MassActionReason MassActionReason;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        TargetPartyIdDeskId TargetPartyIdDeskId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Delete All Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllQuoteRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
    };


    /// <summary>
    ///  Struct for Delete All Quote Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllQuoteResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        MassActionReportId MassActionReportId;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Delete Order Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        CumQty CumQty;
        CxlQty CxlQty;
        MarketSegmentId MarketSegmentId;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        ExecRestatementReason ExecRestatementReason;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ProductComplex ProductComplex;
        Side Side;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Delete Order Complex Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderComplexRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
    };


    /// <summary>
    ///  Struct for Delete Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderNrResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        CumQty CumQty;
        CxlQty CxlQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Delete Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeaderMe ResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        CumQty CumQty;
        CxlQty CxlQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Delete Order Single Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderSingleRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        SimpleSecurityId SimpleSecurityId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Enrichment Rules Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EnrichmentRulesGrp {
        EnrichmentRuleId EnrichmentRuleId;
        PartyIdOriginationMarket PartyIdOriginationMarket;
        Account Account;
        PositionEffect PositionEffect;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Fills Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FillsGrp {
        FillPx FillPx;
        FillQty FillQty;
        FillMatchId FillMatchId;
        FillExecId FillExecId;
        FillLiquidityInd FillLiquidityInd;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Forced Logout Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ForcedLogoutNotification {
        MessageHeaderOut MessageHeaderOut;
        NotifHeader NotifHeader;
        VarTextLen VarTextLen;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Gateway Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GatewayRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        PartyIdSessionId PartyIdSessionId;
        DefaultCstmApplVerId DefaultCstmApplVerId;
        Password Password;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Gateway Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GatewayResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        GatewayId GatewayId;
        GatewaySubId GatewaySubId;
        SecondaryGatewayId SecondaryGatewayId;
        SecondaryGatewaySubId SecondaryGatewaySubId;
        SessionMode SessionMode;
        TradSesMode TradSesMode;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Heartbeat
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Heartbeat {
        MessageHeaderIn MessageHeaderIn;
    };


    /// <summary>
    ///  Struct for Heartbeat Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HeartbeatNotification {
        MessageHeaderOut MessageHeaderOut;
        NotifHeader NotifHeader;
    };


    /// <summary>
    ///  Struct for Inquire Enrichment Rule Id List Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireEnrichmentRuleIdListRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        LastEntityProcessed LastEntityProcessed;
    };


    /// <summary>
    ///  Struct for Inquire Enrichment Rule Id List Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireEnrichmentRuleIdListResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        LastEntityProcessed LastEntityProcessed;
        NoEnrichmentRules NoEnrichmentRules;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Inquire Mm Parameter Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireMmParameterRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
    };


    /// <summary>
    ///  Struct for Inquire Mm Parameter Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireMmParameterResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        MmParameterReportId MmParameterReportId;
        MarketSegmentId MarketSegmentId;
        NoMmParameters NoMmParameters;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Inquire Session List Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireSessionListRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
    };


    /// <summary>
    ///  Struct for Inquire Session List Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireSessionListResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        NoSessions NoSessions;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Inquire User Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireUserRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        LastEntityProcessed LastEntityProcessed;
    };


    /// <summary>
    ///  Struct for Inquire User Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireUserResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        LastEntityProcessed LastEntityProcessed;
        NoPartyDetails NoPartyDetails;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Instrmnt Leg Exec Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrmntLegExecGrp {
        LegSecurityId LegSecurityId;
        LegLastPx LegLastPx;
        LegLastQty LegLastQty;
        LegExecId LegExecId;
        LegSide LegSide;
        NoFillsIndex NoFillsIndex;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Instrmt Leg Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrmtLegGrp {
        LegSecurityId LegSecurityId;
        LegPrice LegPrice;
        LegSymbol LegSymbol;
        LegRatioQty LegRatioQty;
        LegSide LegSide;
        LegSecurityType LegSecurityType;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Leg Ord Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegOrdGrp {
        LegAccount LegAccount;
        LegPositionEffect LegPositionEffect;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Legal Notification Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegalNotificationBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        TransactTime TransactTime;
        VarTextLen VarTextLen;
        UserStatus UserStatus;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Logon Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogonRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        HeartBtInt HeartBtInt;
        PartyIdSessionId PartyIdSessionId;
        DefaultCstmApplVerId DefaultCstmApplVerId;
        Password Password;
        ApplUsageOrders ApplUsageOrders;
        ApplUsageQuotes ApplUsageQuotes;
        OrderRoutingIndicator OrderRoutingIndicator;
        FixEngineName FixEngineName;
        FixEngineVersion FixEngineVersion;
        FixEngineVendor FixEngineVendor;
        ApplicationSystemName ApplicationSystemName;
        ApplicationSystemVersion ApplicationSystemVersion;
        ApplicationSystemVendor ApplicationSystemVendor;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Logon Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogonResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        ThrottleTimeInterval ThrottleTimeInterval;
        ThrottleNoMsgs ThrottleNoMsgs;
        ThrottleDisconnectLimit ThrottleDisconnectLimit;
        HeartBtInt HeartBtInt;
        SessionInstanceId SessionInstanceId;
        TradSesMode TradSesMode;
        DefaultCstmApplVerId DefaultCstmApplVerId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Logout Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogoutRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
    };


    /// <summary>
    ///  Struct for Logout Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogoutResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
    };


    /// <summary>
    ///  Struct for Mass Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        QuoteId QuoteId;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        EnrichmentRuleId EnrichmentRuleId;
        PriceValidityCheckType PriceValidityCheckType;
        QuoteSizeType QuoteSizeType;
        NoQuoteEntries NoQuoteEntries;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Mass Quote Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        QuoteId QuoteId;
        QuoteResponseId QuoteResponseId;
        MarketSegmentId MarketSegmentId;
        NoQuoteEntries NoQuoteEntries;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Message Header In
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeaderIn {
        BodyLen BodyLen;
        TemplateId TemplateId;
        NetworkMsgId NetworkMsgId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Message Header Out
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeaderOut {
        BodyLen BodyLen;
        TemplateId TemplateId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Mm Parameter Definition Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmParameterDefinitionRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ExposureDuration ExposureDuration;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        CumQty CumQty;
        PctCount PctCount;
        Delta Delta;
        Vega Vega;
        ProductComplex ProductComplex;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Mm Parameter Definition Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmParameterDefinitionResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        ExecId ExecId;
    };


    /// <summary>
    ///  Struct for Mm Parameter Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmParameterGrp {
        ExposureDuration ExposureDuration;
        CumQty CumQty;
        PctCount PctCount;
        Delta Delta;
        Vega Vega;
        ProductComplex ProductComplex;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Modify Order Complex Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderComplexRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        Price Price;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        ExpireDate ExpireDate;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        ProductComplex ProductComplex;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ExecInst ExecInst;
        TimeInForce TimeInForce;
        TradingCapacity TradingCapacity;
        OwnershipIndicator OwnershipIndicator;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        PartyIdPositionAccount PartyIdPositionAccount;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        NoLegs NoLegs;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Modify Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderNrResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Modify Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeaderMe ResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Modify Order Single Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderSingleRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        Price Price;
        StopPx StopPx;
        ComplianceId ComplianceId;
        OrderQty OrderQty;
        ExpireDate ExpireDate;
        MarketSegmentId MarketSegmentId;
        SimpleSecurityId SimpleSecurityId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        TradingCapacity TradingCapacity;
        Account Account;
        PartyIdPositionAccount PartyIdPositionAccount;
        PositionEffect PositionEffect;
        OwnershipIndicator OwnershipIndicator;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Modify Order Single Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderSingleShortRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        Price Price;
        ComplianceId ComplianceId;
        OrderQty OrderQty;
        SimpleSecurityId SimpleSecurityId;
        EnrichmentRuleId EnrichmentRuleId;
        Side Side;
        PriceValidityCheckType PriceValidityCheckType;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingCapacity TradingCapacity;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for New Order Complex Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderComplexRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        Price Price;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        ExpireDate ExpireDate;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        ProductComplex ProductComplex;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ExecInst ExecInst;
        TimeInForce TimeInForce;
        TradingCapacity TradingCapacity;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdPositionAccount PartyIdPositionAccount;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        NoLegs NoLegs;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for New Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderNrResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for New Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeaderMe ResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        TrdRegTsEntryTime TrdRegTsEntryTime;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for New Order Single Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingleRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        Price Price;
        StopPx StopPx;
        ClOrdId ClOrdId;
        ComplianceId ComplianceId;
        OrderQty OrderQty;
        ExpireDate ExpireDate;
        MarketSegmentId MarketSegmentId;
        SimpleSecurityId SimpleSecurityId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        TradingCapacity TradingCapacity;
        Account Account;
        PartyIdPositionAccount PartyIdPositionAccount;
        PositionEffect PositionEffect;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for New Order Single Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingleShortRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        Price Price;
        ClOrdId ClOrdId;
        ComplianceId ComplianceId;
        OrderQty OrderQty;
        SimpleSecurityId SimpleSecurityId;
        EnrichmentRuleId EnrichmentRuleId;
        Side Side;
        PriceValidityCheckType PriceValidityCheckType;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingCapacity TradingCapacity;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for News Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewsBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        OrigTime OrigTime;
        VarTextLen VarTextLen;
        Headline Headline;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Not Affected Orders Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotAffectedOrdersGrp {
        NotAffectedOrderId NotAffectedOrderId;
        NotAffOrigClOrdId NotAffOrigClOrdId;
    };


    /// <summary>
    ///  Struct for Not Affected Securities Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotAffectedSecuritiesGrp {
        NotAffectedSecurityId NotAffectedSecurityId;
    };


    /// <summary>
    ///  Struct for Notif Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotifHeader {
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Nr Response Header Me
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NrResponseHeaderMe {
        RequestTime RequestTime;
        RequestOut RequestOut;
        TrdRegTsTimeIn TrdRegTsTimeIn;
        TrdRegTsTimeOut TrdRegTsTimeOut;
        ResponseIn ResponseIn;
        SendingTime SendingTime;
        MsgSeqNum MsgSeqNum;
        LastFragment LastFragment;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Nrbc Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NrbcHeader {
        SendingTime SendingTime;
        ApplSubId ApplSubId;
        ApplId ApplId;
        LastFragment LastFragment;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Party Action Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyActionReport {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        TransactTime TransactTime;
        TradeDate TradeDate;
        RequestingPartyIdExecutingTrader RequestingPartyIdExecutingTrader;
        PartyIdExecutingUnit PartyIdExecutingUnit;
        PartyIdExecutingTrader PartyIdExecutingTrader;
        RequestingPartyIdExecutingSystem RequestingPartyIdExecutingSystem;
        MarketId MarketId;
        PartyActionType PartyActionType;
        RequestingPartyIdEnteringFirm RequestingPartyIdEnteringFirm;
    };


    /// <summary>
    ///  Struct for Party Details Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyDetailsGrp {
        PartyDetailIdExecutingTrader PartyDetailIdExecutingTrader;
        PartyDetailExecutingTrader PartyDetailExecutingTrader;
        PartyDetailRoleQualifier PartyDetailRoleQualifier;
        PartyDetailStatus PartyDetailStatus;
        PartyDetailDeskId PartyDetailDeskId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Party Entitlements Update Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyEntitlementsUpdateReport {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        TransactTime TransactTime;
        TradeDate TradeDate;
        PartyDetailIdExecutingUnit PartyDetailIdExecutingUnit;
        RequestingPartyIdExecutingSystem RequestingPartyIdExecutingSystem;
        MarketId MarketId;
        ListUpdateAction ListUpdateAction;
        RequestingPartyEnteringFirm RequestingPartyEnteringFirm;
        RequestingPartyClearingFirm RequestingPartyClearingFirm;
        PartyDetailStatus PartyDetailStatus;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Quote Activation Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationNotification {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        MassActionReportId MassActionReportId;
        MarketSegmentId MarketSegmentId;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        ProductComplex ProductComplex;
        MassActionType MassActionType;
        MassActionReason MassActionReason;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Quote Activation Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        MassActionType MassActionType;
        ProductComplex ProductComplex;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Quote Activation Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        MassActionReportId MassActionReportId;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Quote Entry Ack Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteEntryAckGrp {
        SecurityId SecurityId;
        BidCxlSize BidCxlSize;
        OfferCxlSize OfferCxlSize;
        QuoteEntryRejectReason QuoteEntryRejectReason;
        QuoteEntryStatus QuoteEntryStatus;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Quote Entry Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteEntryGrp {
        SecurityId SecurityId;
        BidPx BidPx;
        OfferPx OfferPx;
        BidSize BidSize;
        OfferSize OfferSize;
    };


    /// <summary>
    ///  Struct for Quote Event Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteEventGrp {
        SecurityId SecurityId;
        QuoteEventPx QuoteEventPx;
        QuoteMsgId QuoteMsgId;
        QuoteEventMatchId QuoteEventMatchId;
        QuoteEventExecId QuoteEventExecId;
        QuoteEventQty QuoteEventQty;
        QuoteEventType QuoteEventType;
        QuoteEventSide QuoteEventSide;
        QuoteEventLiquidityInd QuoteEventLiquidityInd;
        QuoteEventReason QuoteEventReason;
    };


    /// <summary>
    ///  Struct for Quote Leg Exec Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteLegExecGrp {
        LegSecurityId LegSecurityId;
        LegLastPx LegLastPx;
        LegLastQty LegLastQty;
        LegExecId LegExecId;
        LegSide LegSide;
        NoQuoteEventsIndex NoQuoteEventsIndex;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Rbc Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RbcHeader {
        SendingTime SendingTime;
        ApplSeqNum ApplSeqNum;
        ApplSubId ApplSubId;
        PartitionId PartitionId;
        ApplResendFlag ApplResendFlag;
        ApplId ApplId;
        LastFragment LastFragment;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Rbc Header Me
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RbcHeaderMe {
        TrdRegTsTimeOut TrdRegTsTimeOut;
        NotificationIn NotificationIn;
        SendingTime SendingTime;
        ApplSubId ApplSubId;
        PartitionId PartitionId;
        ApplMsgId ApplMsgId;
        ApplId ApplId;
        ApplResendFlag ApplResendFlag;
        LastFragment LastFragment;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Reject
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Reject {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        SessionRejectReason SessionRejectReason;
        VarTextLen VarTextLen;
        SessionStatus SessionStatus;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Request Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestHeader {
        MsgSeqNum MsgSeqNum;
        SenderSubId SenderSubId;
    };


    /// <summary>
    ///  Struct for Response Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResponseHeader {
        RequestTime RequestTime;
        SendingTime SendingTime;
        MsgSeqNum MsgSeqNum;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Response Header Me
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResponseHeaderMe {
        RequestTime RequestTime;
        RequestOut RequestOut;
        TrdRegTsTimeIn TrdRegTsTimeIn;
        TrdRegTsTimeOut TrdRegTsTimeOut;
        ResponseIn ResponseIn;
        SendingTime SendingTime;
        MsgSeqNum MsgSeqNum;
        PartitionId PartitionId;
        ApplId ApplId;
        ApplMsgId ApplMsgId;
        LastFragment LastFragment;
    };


    /// <summary>
    ///  Struct for Retransmit Me Message Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmitMeMessageRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SubscriptionScope SubscriptionScope;
        PartitionId PartitionId;
        RefApplId RefApplId;
        ApplBegMsgId ApplBegMsgId;
        ApplEndMsgId ApplEndMsgId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Retransmit Me Message Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmitMeMessageResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        ApplTotalMessageCount ApplTotalMessageCount;
        ApplEndMsgId ApplEndMsgId;
        RefApplLastMsgId RefApplLastMsgId;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Retransmit Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmitRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        ApplBegSeqNum ApplBegSeqNum;
        ApplEndSeqNum ApplEndSeqNum;
        SubscriptionScope SubscriptionScope;
        PartitionId PartitionId;
        RefApplId RefApplId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Retransmit Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmitResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        ApplEndSeqNum ApplEndSeqNum;
        RefApplLastSeqNum RefApplLastSeqNum;
        ApplTotalMessageCount ApplTotalMessageCount;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Rfq Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SecurityId SecurityId;
        ComplianceId ComplianceId;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        Side Side;
        ComplianceText ComplianceText;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Rfq Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        ExecId ExecId;
    };


    /// <summary>
    ///  Struct for Risk Notification Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskNotificationBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        TransactTime TransactTime;
        TradeDate TradeDate;
        PartyDetailIdExecutingUnit PartyDetailIdExecutingUnit;
        RequestingPartyIdExecutingSystem RequestingPartyIdExecutingSystem;
        MarketId MarketId;
        ListUpdateAction ListUpdateAction;
        RiskLimitAction RiskLimitAction;
        RequestingPartyEnteringFirm RequestingPartyEnteringFirm;
        RequestingPartyClearingFirm RequestingPartyClearingFirm;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Service Availability Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ServiceAvailabilityBroadcast {
        MessageHeaderOut MessageHeaderOut;
        NrbcHeader NrbcHeader;
        MatchingEngineTradeDate MatchingEngineTradeDate;
        TradeManagerTradeDate TradeManagerTradeDate;
        ApplSeqTradeDate ApplSeqTradeDate;
        PartitionId PartitionId;
        MatchingEngineStatus MatchingEngineStatus;
        TradeManagerStatus TradeManagerStatus;
        ApplSeqStatus ApplSeqStatus;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Sessions Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SessionsGrp {
        PartyIdSessionId PartyIdSessionId;
        SessionMode SessionMode;
        SessionSubMode SessionSubMode;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Subscribe Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SubscribeRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SubscriptionScope SubscriptionScope;
        RefApplId RefApplId;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Subscribe Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SubscribeResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
        ApplSubId ApplSubId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Throttle Update Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ThrottleUpdateNotification {
        MessageHeaderOut MessageHeaderOut;
        NotifHeader NotifHeader;
        ThrottleTimeInterval ThrottleTimeInterval;
        ThrottleNoMsgs ThrottleNoMsgs;
        ThrottleDisconnectLimit ThrottleDisconnectLimit;
    };


    /// <summary>
    ///  Struct for Tm Trading Session Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TmTradingSessionStatusBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        TradSesEvent TradSesEvent;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Trade Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeader RbcHeader;
        SecurityId SecurityId;
        RelatedSecurityId RelatedSecurityId;
        Price Price;
        LastPx LastPx;
        SideLastPx SideLastPx;
        ClearingTradePrice ClearingTradePrice;
        TransactTime TransactTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        TradeId TradeId;
        OrigTradeId OrigTradeId;
        RootPartyIdExecutingUnit RootPartyIdExecutingUnit;
        RootPartyIdSessionId RootPartyIdSessionId;
        RootPartyIdExecutingTrader RootPartyIdExecutingTrader;
        RootPartyIdClearingUnit RootPartyIdClearingUnit;
        CumQty CumQty;
        LeavesQty LeavesQty;
        MarketSegmentId MarketSegmentId;
        RelatedSymbol RelatedSymbol;
        LastQty LastQty;
        SideLastQty SideLastQty;
        ClearingTradeQty ClearingTradeQty;
        SideTradeId SideTradeId;
        MatchDate MatchDate;
        TrdMatchId TrdMatchId;
        StrategyLinkId StrategyLinkId;
        TotNumTradeReports TotNumTradeReports;
        MultiLegReportingType MultiLegReportingType;
        TradeReportType TradeReportType;
        TransferReason TransferReason;
        RootPartyIdBeneficiary RootPartyIdBeneficiary;
        RootPartyIdTakeUpTradingFirm RootPartyIdTakeUpTradingFirm;
        RootPartyIdOrderOriginationFirm RootPartyIdOrderOriginationFirm;
        MatchType MatchType;
        MatchSubType MatchSubType;
        Side Side;
        AggressorIndicator AggressorIndicator;
        TradingCapacity TradingCapacity;
        Account Account;
        RootPartyIdPositionAccount RootPartyIdPositionAccount;
        PositionEffect PositionEffect;
        CustOrderHandlingInst CustOrderHandlingInst;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        OrderCategory OrderCategory;
        OrdType OrdType;
        RelatedProductComplex RelatedProductComplex;
        OrderSide OrderSide;
        RootPartyClearingOrganization RootPartyClearingOrganization;
        RootPartyExecutingFirm RootPartyExecutingFirm;
        RootPartyExecutingTrader RootPartyExecutingTrader;
        RootPartyClearingFirm RootPartyClearingFirm;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Trading Session Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingSessionStatusBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        MarketSegmentId MarketSegmentId;
        TradeDate TradeDate;
        TradSesEvent TradSesEvent;
        RefApplLastMsgId RefApplLastMsgId;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Unsubscribe Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnsubscribeRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        RefApplSubId RefApplSubId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Unsubscribe Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnsubscribeResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
    };


    /// <summary>
    ///  Struct for User Login Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLoginRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        Username Username;
        Password Password;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for User Login Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLoginResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
    };


    /// <summary>
    ///  Struct for User Logout Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLogoutRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        Username Username;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for User Logout Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLogoutResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeader ResponseHeader;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
