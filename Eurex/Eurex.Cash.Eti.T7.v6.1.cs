namespace Eurex.Cash.Eti.T7.v6.1 {

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
    ///  Affected Order Id
    /// </summary>
    public unsafe struct AffectedOrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Affected Orig Cl Ord Id
    /// </summary>
    public unsafe struct AffectedOrigClOrdId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
        ApplIDMinimumValue = 10,
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
    ///  Crossed Indicator Values
    /// </summary>
    public enum CrossedIndicator : byte {
        Nocrossing = 0,
        Crossrejected = 1,
        CrossedIndicatorMinimumValue = 1,
        CrossedIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Cum Qty
    /// </summary>
    public struct CumQty {
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
    ///  Default Cstm Appl Ver Sub Id Values
    /// </summary>
    public enum DefaultCstmApplVerSubId : ulong {
        Cash = "C0003",
    };


    /// <summary>
    ///  Delivery Type Values
    /// </summary>
    public enum DeliveryType : byte {
        Akv = 1,
        Gs = 2,
        Str = 3,
        Wpr = 4,
        DeliveryTypeMinimumValue = 4,
        DeliveryTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Display High Qty
    /// </summary>
    public struct DisplayHighQty {
        public int Raw;
    };


    /// <summary>
    ///  Display Low Qty
    /// </summary>
    public struct DisplayLowQty {
        public int Raw;
    };


    /// <summary>
    ///  Display Qty
    /// </summary>
    public struct DisplayQty {
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
    ///  Ex Destination Type Values
    /// </summary>
    public enum ExDestinationType : byte {
        TradeonexchangeorSi = 3,
        ExDestinationTypeMinimumValue = 3,
        ExDestinationTypeMinimumValue = 3,
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
        CorporateAction = 0,
        OrderBookRestatement = 1,
        ExchangeOption = 8,
        OrderAdded = 101,
        OrderModified = 102,
        OrderCancelled = 103,
        IocOrderCancelled = 105,
        FokOrderCancelled = 107,
        BookOrderExecuted = 108,
        InstrumentStateChange = 122,
        EndOfDayProcessing = 146,
        OrderExpiration = 148,
        CaoOrderActivated = 149,
        CaoOrderInactivated = 150,
        OaoOrderActivated = 151,
        OaoOrderInactivated = 152,
        AaoOrderActivated = 153,
        AaoOrderInactivated = 154,
        OrderRefreshed = 155,
        OcoOrderTriggered = 164,
        StopOrderTriggered = 172,
        OwnershipChanged = 181,
        OrderCancellationPending = 197,
        PendingCancellationExecuted = 199,
        BocOrderCancelled = 212,
        TrailingStopUpdate = 213,
        ExceedsMaximumQuantity = 237,
        InvalidLimitPrice = 238,
        UserDoesNotExist = 241,
        SessionDoesNotExist = 242,
        InvalidStopPrice = 243,
        InstrumentDoesNotExist = 245,
        BusinessUnitRiskEvent = 246,
        DividendPayment = 292,
        LastTradingDay = 294,
        TradingParameterChange = 295,
        CurrencyChange = 296,
        ProductAssignmentChange = 297,
        ReferencePriceChange = 298,
        TickRuleChange = 300,
        ExecRestatementReasonMinimumValue = 300,
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
    ///  Executing Trader
    /// </summary>
    public unsafe struct ExecutingTrader {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Executing Trader Qualifier Values
    /// </summary>
    public enum ExecutingTraderQualifier : byte {
        Algo = 22,
        Human = 24,
        ExecutingTraderQualifierMinimumValue = 24,
        ExecutingTraderQualifierMinimumValue = 22,
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
        Auction = 4,
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
    ///  Fix Cl Ord Id
    /// </summary>
    public unsafe struct FixClOrdId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Free Text 4
    /// </summary>
    public unsafe struct FreeText4 {
        public const int Size = 16;

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
    ///  Gateway Status Values
    /// </summary>
    public enum GatewayStatus : byte {
        Standby = 0,
        Active = 1,
        GatewayStatusMinimumValue = 1,
        GatewayStatusMinimumValue = 0,
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
    ///  Last Mkt Values
    /// </summary>
    public enum LastMkt : ushort {
        Xetr = 3,
        Xvie = 4,
        Xdub = 5,
        LastMktMinimumValue = 255,
        LastMktMinimumValue = 1,
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
    ///  Leaves Qty
    /// </summary>
    public struct LeavesQty {
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
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        Xetr = 3,
        Xvie = 4,
        Xdub = 5,
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
        SessionLoss = 6,
        DuplicateSessionLogin = 7,
        ClearingRiskControl = 8,
        ProductStateHalt = 105,
        ProductStateHoliday = 106,
        InstrumentSuspended = 107,
        VolatilityInterruption = 110,
        Producttemporarilynottradeable = 111,
        InstrumentStopped = 113,
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
    ///  Match Inst Cross Id
    /// </summary>
    public unsafe struct MatchInstCrossId {
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
        SystematicInternaliser = 9,
        Automatchresting = 11,
        Automatchatmidpoint = 12,
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
    ///  Msg Seq Num
    /// </summary>
    public unsafe struct MsgSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  No Affected Orders
    /// </summary>
    public unsafe struct NoAffectedOrders {
        public const int Size = 2;

        public short Value;

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
    ///  Order Attribute Liquidity Provision Values
    /// </summary>
    public enum OrderAttributeLiquidityProvision : byte {
        Y = 1,
        N = 0,
        OrderAttributeLiquidityProvisionMinimumValue = 1,
        OrderAttributeLiquidityProvisionMinimumValue = 0,
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
    ///  Order Id Sfx
    /// </summary>
    public unsafe struct OrderIdSfx {
        public const int Size = 4;

        public int Value;

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
    ///  Party Executing Firm
    /// </summary>
    public unsafe struct PartyExecutingFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Client Id
    /// </summary>
    public unsafe struct PartyIdClientId {
        public const int Size = 8;

        public long Value;

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
    ///  Party Id Investment Decision Maker
    /// </summary>
    public unsafe struct PartyIdInvestmentDecisionMaker {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Id Investment Decision Maker Qualifier Values
    /// </summary>
    public enum PartyIdInvestmentDecisionMakerQualifier : byte {
        Algo = 22,
        Human = 24,
        PartyIdInvestmentDecisionMakerQualifierMinimumValue = 24,
        PartyIdInvestmentDecisionMakerQualifierMinimumValue = 22,
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
    ///  Peg Offset Value Abs
    /// </summary>
    public unsafe struct PegOffsetValueAbs {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Peg Offset Value Bid Px
    /// </summary>
    public unsafe struct PegOffsetValueBidPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Peg Offset Value Offer Px
    /// </summary>
    public unsafe struct PegOffsetValueOfferPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Peg Offset Value Pct
    /// </summary>
    public unsafe struct PegOffsetValuePct {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
        Mandatory = 2,
        PriceValidityCheckTypeMinimumValue = 2,
        PriceValidityCheckTypeMinimumValue = 0,
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
        BidPriceNotReasonable = 108,
        AskPriceNotReasonable = 109,
        BidPriceExceedsRange = 110,
        AskPriceExceedsRange = 111,
        InstrumentStateFreeze = 115,
        DeletionAlreadyPending = 116,
        PreTradeRiskSessionLimitExceeded = 117,
        PreTradeRiskBuLimitExceeded = 118,
        BidValueExceedsLimit = 120,
        AskValueExceedsLimit = 121,
        NotTradeableForBusinessUnit = 122,
        QuantityLimitExceeded = 125,
        ValueLimitExceeded = 126,
        InvalidQuoteSpread = 127,
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
        Crossrejected = 16,
        QuoteEventReasonMinimumValue = 17,
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
        Modifiedquoteside = 2,
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
        RefApplIDMinimumValue = 10,
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
        T7 = 2,
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
    ///  Reserved Bid Size
    /// </summary>
    public unsafe struct ReservedBidSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Offer Size
    /// </summary>
    public unsafe struct ReservedOfferSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Size
    /// </summary>
    public unsafe struct ReservedSize {
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
    ///  Rfq Publish Indicator Values
    /// </summary>
    public enum RfqPublishIndicator : byte {
        MarketData = 1,
        DesignatedSponsor = 2,
        MarketDataandDesignatedSponsor = 3,
        MarketMakerandDesignatedSponsor = 4,
        MarketDataandMarketMakerandDesignatedSponsor = 5,
        RfqPublishIndicatorMinimumValue = 5,
        RfqPublishIndicatorMinimumValue = 1,
    };


    /// <summary>
    ///  Rfq Requester Disclosure Instruction Values
    /// </summary>
    public enum RfqRequesterDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        RfqRequesterDisclosureInstructionMinimumValue = 1,
        RfqRequesterDisclosureInstructionMinimumValue = 0,
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
    ///  Root Party Contra Firm
    /// </summary>
    public unsafe struct RootPartyContraFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Contra Firm Kv Number
    /// </summary>
    public unsafe struct RootPartyContraFirmKvNumber {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Contra Settlement Account
    /// </summary>
    public unsafe struct RootPartyContraSettlementAccount {
        public const int Size = 35;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Contra Settlement Firm
    /// </summary>
    public unsafe struct RootPartyContraSettlementFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Contra Settlement Location Values
    /// </summary>
    public enum RootPartyContraSettlementLocation : ulong {
        Apk = "APK",
        Cbf = "CBF",
        Cbl = "CBL",
        Cco = "CCO",
        Cik = "CIK",
        Eoc = "EOC",
        Hel = "HEL",
        Ibc = "IBC",
        Int = "INT",
        Kdp = "KDP",
        Mot = "MOT",
        Nec = "NEC",
        Oeb = "OEB",
        Sic = "SIC",
        Sis = "SIS",
        Vpc = "VPC",
        Vpd = "VPD",
        Vps = "VPS",
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
    ///  Root Party Executing Firm Kv Number
    /// </summary>
    public unsafe struct RootPartyExecutingFirmKvNumber {
        public const int Size = 4;

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
    ///  Root Party Id Clearing Unit
    /// </summary>
    public unsafe struct RootPartyIdClearingUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Contra Settlement Unit
    /// </summary>
    public unsafe struct RootPartyIdContraSettlementUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Contra Unit
    /// </summary>
    public unsafe struct RootPartyIdContraUnit {
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
    ///  Root Party Id Session Id
    /// </summary>
    public unsafe struct RootPartyIdSessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Settlement Unit
    /// </summary>
    public unsafe struct RootPartyIdSettlementUnit {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Settlement Account
    /// </summary>
    public unsafe struct RootPartySettlementAccount {
        public const int Size = 35;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Settlement Firm
    /// </summary>
    public unsafe struct RootPartySettlementFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Settlement Location Values
    /// </summary>
    public enum RootPartySettlementLocation : ulong {
        Apk = "APK",
        Cbf = "CBF",
        Cbl = "CBL",
        Cco = "CCO",
        Cik = "CIK",
        Eoc = "EOC",
        Hel = "HEL",
        Ibc = "IBC",
        Int = "INT",
        Kdp = "KDP",
        Mot = "MOT",
        Nec = "NEC",
        Oeb = "OEB",
        Sic = "SIC",
        Sis = "SIS",
        Vpc = "VPC",
        Vpd = "VPD",
        Vps = "VPS",
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
    ///  Secondary Gateway Status Values
    /// </summary>
    public enum SecondaryGatewayStatus : byte {
        Standby = 0,
        Active = 1,
        SecondaryGatewayStatusMinimumValue = 1,
        SecondaryGatewayStatusMinimumValue = 0,
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
        SessionGatewayAssignmentExpired = 214,
        GatewayNotReservedToSession = 215,
        GatewayIsStandby = 216,
        SessionLoginLimitReached = 217,
        PartitionNotReachableByHfGateway = 218,
        PartitionNotReachableByPsGateway = 219,
        NoGatewayAvailable = 222,
        UserEntitlementDataTimeout = 223,
        OrderNotFound = 10000,
        PriceNotReasonable = 10001,
        ClientOrderIdNotUnique = 10002,
        QuoteActivationInProgress = 10003,
        BuBookOrderLimitExceeded = 10004,
        SessionBookOrderLimitExceeded = 10005,
        StopBidPriceNotReasonable = 10006,
        StopAskPriceNotReasonable = 10007,
        OrderNotExecutableWithinValidity = 10008,
        InvalidTradingRestrictionForInstrumentState = 10009,
        TransactionNotAllowedInCurrentState = 10011,
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
    ///  Settl Curr Amt
    /// </summary>
    public unsafe struct SettlCurrAmt {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settl Curr Fx Rate
    /// </summary>
    public unsafe struct SettlCurrFxRate {
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
    ///  Settl Date
    /// </summary>
    public unsafe struct SettlDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Side Liquidity Ind Values
    /// </summary>
    public enum SideLiquidityInd : byte {
        AddedLiquidity = 1,
        RemovedLiquidity = 2,
        Auction = 4,
        SideLiquidityIndMinimumValue = 4,
        SideLiquidityIndMinimumValue = 1,
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
    ///  Side Trade Report Id
    /// </summary>
    public unsafe struct SideTradeReportId {
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
    ///  Stop Px Indicator Values
    /// </summary>
    public enum StopPxIndicator : byte {
        Donotoverwrite = 0,
        Overwrite = 1,
        StopPxIndicatorMinimumValue = 1,
        StopPxIndicatorMinimumValue = 0,
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
        Fok = 4,
        Gtx = 5,
        Gtd = 6,
        TimeInForceMinimumValue = 6,
        TimeInForceMinimumValue = 0,
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
    ///  Trade Number
    /// </summary>
    public unsafe struct TradeNumber {
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
        TradeBreak = 7,
        TradeReportTypeMinimumValue = 13,
        TradeReportTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Trading Capacity Values
    /// </summary>
    public enum TradingCapacity : byte {
        Customer = 1,
        Principal = 5,
        MarketMaker = 6,
        SystematicInternaliser = 8,
        RisklessPrincipal = 9,
        TradingCapacityMinimumValue = 9,
        TradingCapacityMinimumValue = 1,
    };


    /// <summary>
    ///  Trading Session Sub Id Values
    /// </summary>
    public enum TradingSessionSubId : byte {
        Openingauction = 2,
        Closingauction = 4,
        AnyAuction = 8,
        TradingSessionSubIDMinimumValue = 8,
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
        Userforcedlogout = 7,
        Userstopped = 10,
        Userreleased = 11,
        UserStatusMinimumValue = 11,
        UserStatusMinimumValue = 7,
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
    ///  Value Check Type Quantity Values
    /// </summary>
    public enum ValueCheckTypeQuantity : byte {
        Donotcheck = 0,
        Check = 1,
        ValueCheckTypeQuantityMinimumValue = 1,
        ValueCheckTypeQuantityMinimumValue = 0,
    };


    /// <summary>
    ///  Value Check Type Value Values
    /// </summary>
    public enum ValueCheckTypeValue : byte {
        Donotcheck = 0,
        Check = 1,
        ValueCheckTypeValueMinimumValue = 1,
        ValueCheckTypeValueMinimumValue = 0,
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
    ///  Volume Discovery Price
    /// </summary>
    public unsafe struct VolumeDiscoveryPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Affected Ord Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AffectedOrdGrp {
        AffectedOrderId AffectedOrderId;
        AffectedOrigClOrdId AffectedOrigClOrdId;
    };


    /// <summary>
    ///  Struct for Best Quote Execution Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestQuoteExecutionReport {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        ExecId ExecId;
        QuoteMsgId QuoteMsgId;
        SecurityId SecurityId;
        QuoteEventPx QuoteEventPx;
        MarketSegmentId MarketSegmentId;
        QuoteEventMatchId QuoteEventMatchId;
        QuoteEventExecId QuoteEventExecId;
        QuoteEventQty QuoteEventQty;
        ReservedSize ReservedSize;
        QuoteEventType QuoteEventType;
        QuoteEventSide QuoteEventSide;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Best Quote Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestQuoteResponse {
        MessageHeaderOut MessageHeaderOut;
        NrResponseHeaderMe NrResponseHeaderMe;
        QuoteId QuoteId;
        QuoteResponseId QuoteResponseId;
        SecurityId SecurityId;
        MarketSegmentId MarketSegmentId;
        BidCxlSize BidCxlSize;
        OfferCxlSize OfferCxlSize;
        Pad4 Pad4;
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
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
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
        Price Price;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        Side Side;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad1 Pad1;
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
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad6 Pad6;
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
        OrderIdSfx OrderIdSfx;
        CumQty CumQty;
        CxlQty CxlQty;
        MarketSegmentId MarketSegmentId;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        PartyIdSessionId PartyIdSessionId;
        ExecRestatementReason ExecRestatementReason;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        OrdStatus OrdStatus;
        ExecType ExecType;
        Side Side;
        FixClOrdId FixClOrdId;
        Pad6 Pad6;
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
        OrderIdSfx OrderIdSfx;
        CumQty CumQty;
        CxlQty CxlQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
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
        OrderIdSfx OrderIdSfx;
        CumQty CumQty;
        CxlQty CxlQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
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
        SecurityId SecurityId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        FixClOrdId FixClOrdId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Enrichment Rules Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EnrichmentRulesGrp {
        EnrichmentRuleId EnrichmentRuleId;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText4 FreeText4;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Enter Best Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EnterBestQuoteRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        QuoteId QuoteId;
        SecurityId SecurityId;
        BidPx BidPx;
        OfferPx OfferPx;
        PegOffsetValueBidPx PegOffsetValueBidPx;
        PegOffsetValueOfferPx PegOffsetValueOfferPx;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        BidSize BidSize;
        OfferSize OfferSize;
        ReservedBidSize ReservedBidSize;
        ReservedOfferSize ReservedOfferSize;
        MarketSegmentId MarketSegmentId;
        EnrichmentRuleId EnrichmentRuleId;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ValueCheckTypeQuantity ValueCheckTypeQuantity;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Extended Deletion Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExtendedDeletionReport {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        TrdRegTsEntryTime TrdRegTsEntryTime;
        Price Price;
        StopPx StopPx;
        VolumeDiscoveryPrice VolumeDiscoveryPrice;
        PegOffsetValueAbs PegOffsetValueAbs;
        PegOffsetValuePct PegOffsetValuePct;
        MarketSegmentId MarketSegmentId;
        OrderIdSfx OrderIdSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        OrderQty OrderQty;
        DisplayQty DisplayQty;
        DisplayLowQty DisplayLowQty;
        DisplayHighQty DisplayHighQty;
        ExpireDate ExpireDate;
        MatchInstCrossId MatchInstCrossId;
        PartyIdExecutingUnit PartyIdExecutingUnit;
        PartyIdSessionId PartyIdSessionId;
        PartyIdExecutingTrader PartyIdExecutingTrader;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        ExecRestatementReason ExecRestatementReason;
        OrdStatus OrdStatus;
        ExecType ExecType;
        Side Side;
        OrdType OrdType;
        TradingCapacity TradingCapacity;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        ApplSeqIndicator ApplSeqIndicator;
        ExDestinationType ExDestinationType;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText4 FreeText4;
        FixClOrdId FixClOrdId;
        Triggered Triggered;
        Pad3 Pad3;
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
    ///  Struct for Forced User Logout Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ForcedUserLogoutNotification {
        MessageHeaderOut MessageHeaderOut;
        NotifHeader NotifHeader;
        UserStatus UserStatus;
        Pad3 Pad3;
        Username Username;
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
        PartitionId PartitionId;
        DefaultCstmApplVerId DefaultCstmApplVerId;
        Password Password;
        Pad4 Pad4;
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
        GatewayStatus GatewayStatus;
        SecondaryGatewayStatus SecondaryGatewayStatus;
        SessionMode SessionMode;
        TradSesMode TradSesMode;
        Pad4 Pad4;
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
        MarketId MarketId;
        TradSesMode TradSesMode;
        DefaultCstmApplVerId DefaultCstmApplVerId;
        DefaultCstmApplVerSubId DefaultCstmApplVerSubId;
        Pad2 Pad2;
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
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        ValueCheckTypeQuantity ValueCheckTypeQuantity;
        QuoteSizeType QuoteSizeType;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        NoQuoteEntries NoQuoteEntries;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad6 Pad6;
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
        StopPx StopPx;
        OrderIdSfx OrderIdSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        DisplayQty DisplayQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        Triggered Triggered;
        Pad6 Pad6;
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
        StopPx StopPx;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        OrderIdSfx OrderIdSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        DisplayQty DisplayQty;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        Triggered Triggered;
        Pad6 Pad6;
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
        SecurityId SecurityId;
        Price Price;
        StopPx StopPx;
        VolumeDiscoveryPrice VolumeDiscoveryPrice;
        PegOffsetValueAbs PegOffsetValueAbs;
        PegOffsetValuePct PegOffsetValuePct;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        OrderQty OrderQty;
        DisplayQty DisplayQty;
        DisplayLowQty DisplayLowQty;
        DisplayHighQty DisplayHighQty;
        ExpireDate ExpireDate;
        MarketSegmentId MarketSegmentId;
        MatchInstCrossId MatchInstCrossId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        ApplSeqIndicator ApplSeqIndicator;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        ValueCheckTypeQuantity ValueCheckTypeQuantity;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        StopPxIndicator StopPxIndicator;
        TradingCapacity TradingCapacity;
        ExDestinationType ExDestinationType;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        OwnershipIndicator OwnershipIndicator;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText4 FreeText4;
        FixClOrdId FixClOrdId;
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
        SecurityId SecurityId;
        Price Price;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        OrderQty OrderQty;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        Side Side;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        ValueCheckTypeQuantity ValueCheckTypeQuantity;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ApplSeqIndicator ApplSeqIndicator;
        ExecInst ExecInst;
        TradingCapacity TradingCapacity;
        ExDestinationType ExDestinationType;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad2 Pad2;
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
        OrderIdSfx OrderIdSfx;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        Triggered Triggered;
        Pad6 Pad6;
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
        OrderIdSfx OrderIdSfx;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        Triggered Triggered;
        Pad6 Pad6;
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
        VolumeDiscoveryPrice VolumeDiscoveryPrice;
        PegOffsetValueAbs PegOffsetValueAbs;
        PegOffsetValuePct PegOffsetValuePct;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        OrderQty OrderQty;
        DisplayQty DisplayQty;
        DisplayLowQty DisplayLowQty;
        DisplayHighQty DisplayHighQty;
        ExpireDate ExpireDate;
        MarketSegmentId MarketSegmentId;
        MatchInstCrossId MatchInstCrossId;
        ApplSeqIndicator ApplSeqIndicator;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        ValueCheckTypeQuantity ValueCheckTypeQuantity;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        TradingCapacity TradingCapacity;
        ExDestinationType ExDestinationType;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText4 FreeText4;
        FixClOrdId FixClOrdId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for New Order Single Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingleShortRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SecurityId SecurityId;
        Price Price;
        ClOrdId ClOrdId;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        OrderQty OrderQty;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        Side Side;
        ApplSeqIndicator ApplSeqIndicator;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        ValueCheckTypeQuantity ValueCheckTypeQuantity;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingCapacity TradingCapacity;
        ExDestinationType ExDestinationType;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad2 Pad2;
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
    ///  Struct for Order Exec Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecNotification {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        MarketSegmentId MarketSegmentId;
        OrderIdSfx OrderIdSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        DisplayQty DisplayQty;
        ExecRestatementReason ExecRestatementReason;
        Side Side;
        OrdStatus OrdStatus;
        ExecType ExecType;
        MatchType MatchType;
        Triggered Triggered;
        CrossedIndicator CrossedIndicator;
        FixClOrdId FixClOrdId;
        NoFills NoFills;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Order Exec Report Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecReportBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        TrdRegTsEntryTime TrdRegTsEntryTime;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        Price Price;
        StopPx StopPx;
        VolumeDiscoveryPrice VolumeDiscoveryPrice;
        PegOffsetValueAbs PegOffsetValueAbs;
        PegOffsetValuePct PegOffsetValuePct;
        MarketSegmentId MarketSegmentId;
        OrderIdSfx OrderIdSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        OrderQty OrderQty;
        DisplayQty DisplayQty;
        DisplayLowQty DisplayLowQty;
        DisplayHighQty DisplayHighQty;
        ExpireDate ExpireDate;
        MatchInstCrossId MatchInstCrossId;
        PartyIdExecutingUnit PartyIdExecutingUnit;
        PartyIdSessionId PartyIdSessionId;
        PartyIdExecutingTrader PartyIdExecutingTrader;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        ExecRestatementReason ExecRestatementReason;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        OrdStatus OrdStatus;
        ExecType ExecType;
        MatchType MatchType;
        Side Side;
        OrdType OrdType;
        TradingCapacity TradingCapacity;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        ApplSeqIndicator ApplSeqIndicator;
        ExDestinationType ExDestinationType;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText4 FreeText4;
        FixClOrdId FixClOrdId;
        NoFills NoFills;
        Triggered Triggered;
        CrossedIndicator CrossedIndicator;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Order Exec Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecResponse {
        MessageHeaderOut MessageHeaderOut;
        ResponseHeaderMe ResponseHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        TrdRegTsEntryTime TrdRegTsEntryTime;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        MarketSegmentId MarketSegmentId;
        OrderIdSfx OrderIdSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        DisplayQty DisplayQty;
        ExecRestatementReason ExecRestatementReason;
        Side Side;
        OrdStatus OrdStatus;
        ExecType ExecType;
        MatchType MatchType;
        Triggered Triggered;
        CrossedIndicator CrossedIndicator;
        NoFills NoFills;
        Pad7 Pad7;
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
        MassActionType MassActionType;
        MassActionReason MassActionReason;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Quote Activation Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        MassActionType MassActionType;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad5 Pad5;
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
    ///  Struct for Quote Execution Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteExecutionReport {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        ExecId ExecId;
        MarketSegmentId MarketSegmentId;
        NoQuoteEvents NoQuoteEvents;
        Pad3 Pad3;
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
        PartitionId PartitionId;
        RefApplId RefApplId;
        Pad5 Pad5;
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
    ///  Struct for Rfq Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqBroadcast {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        SecurityId SecurityId;
        ExecId ExecId;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        Side Side;
        PartyExecutingFirm PartyExecutingFirm;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Rfq Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqRequest {
        MessageHeaderIn MessageHeaderIn;
        RequestHeader RequestHeader;
        SecurityId SecurityId;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        RfqPublishIndicator RfqPublishIndicator;
        RfqRequesterDisclosureInstruction RfqRequesterDisclosureInstruction;
        Side Side;
        Pad5 Pad5;
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
        Price Price;
        LastPx LastPx;
        SettlCurrAmt SettlCurrAmt;
        SettlCurrFxRate SettlCurrFxRate;
        TransactTime TransactTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        TradeId TradeId;
        OrigTradeId OrigTradeId;
        RootPartyIdExecutingUnit RootPartyIdExecutingUnit;
        RootPartyIdSessionId RootPartyIdSessionId;
        RootPartyIdExecutingTrader RootPartyIdExecutingTrader;
        RootPartyIdSettlementUnit RootPartyIdSettlementUnit;
        RootPartyIdClearingUnit RootPartyIdClearingUnit;
        RootPartyIdContraUnit RootPartyIdContraUnit;
        RootPartyIdContraSettlementUnit RootPartyIdContraSettlementUnit;
        OrderIdSfx OrderIdSfx;
        CumQty CumQty;
        LeavesQty LeavesQty;
        MarketSegmentId MarketSegmentId;
        LastQty LastQty;
        SideTradeId SideTradeId;
        SideTradeReportId SideTradeReportId;
        TradeNumber TradeNumber;
        MatchDate MatchDate;
        SettlDate SettlDate;
        TrdMatchId TrdMatchId;
        LastMkt LastMkt;
        TradeReportType TradeReportType;
        TransferReason TransferReason;
        MatchType MatchType;
        MatchSubType MatchSubType;
        Side Side;
        SideLiquidityInd SideLiquidityInd;
        DeliveryType DeliveryType;
        TradingCapacity TradingCapacity;
        Account Account;
        SettlCurrency SettlCurrency;
        Currency Currency;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText4 FreeText4;
        OrderCategory OrderCategory;
        OrdType OrdType;
        RootPartyExecutingFirm RootPartyExecutingFirm;
        RootPartyExecutingTrader RootPartyExecutingTrader;
        RootPartyClearingFirm RootPartyClearingFirm;
        RootPartyExecutingFirmKvNumber RootPartyExecutingFirmKvNumber;
        RootPartySettlementAccount RootPartySettlementAccount;
        RootPartySettlementLocation RootPartySettlementLocation;
        RootPartySettlementFirm RootPartySettlementFirm;
        RootPartyContraFirm RootPartyContraFirm;
        RootPartyContraSettlementFirm RootPartyContraSettlementFirm;
        RootPartyContraFirmKvNumber RootPartyContraFirmKvNumber;
        RootPartyContraSettlementAccount RootPartyContraSettlementAccount;
        RootPartyContraSettlementLocation RootPartyContraSettlementLocation;
        Pad1 Pad1;
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
    ///  Struct for Trailing Stop Update Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TrailingStopUpdateNotification {
        MessageHeaderOut MessageHeaderOut;
        RbcHeaderMe RbcHeaderMe;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        StopPx StopPx;
        OrderIdSfx OrderIdSfx;
        MarketSegmentId MarketSegmentId;
        OrderQty OrderQty;
        ExecRestatementReason ExecRestatementReason;
        OrdStatus OrdStatus;
        ExecType ExecType;
        Side Side;
        FixClOrdId FixClOrdId;
        Pad3 Pad3;
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
