namespace Eurex.Derivatives.Eti.T7.v9.0 {

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
    ///  Affected Order Request Id
    /// </summary>
    public unsafe struct AffectedOrderRequestId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Alloc Id
    /// </summary>
    public unsafe struct AllocId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Alloc Qty
    /// </summary>
    public unsafe struct AllocQty {
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
        TesMaintenance = 7,
        TesTrade = 8,
        SrqsMaintenance = 9,
        ServiceAvailabilityMarket = 10,
        ApplIDMinimumValue = 11,
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
    ///  Auto Approval Rule Id
    /// </summary>
    public unsafe struct AutoApprovalRuleId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Basket Exec Id
    /// </summary>
    public unsafe struct BasketExecId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Basket Party Contra Firm
    /// </summary>
    public unsafe struct BasketPartyContraFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Basket Profile Id
    /// </summary>
    public unsafe struct BasketProfileId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Basket Side Trade Report Id
    /// </summary>
    public unsafe struct BasketSideTradeReportId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Basket Trade Report Text
    /// </summary>
    public unsafe struct BasketTradeReportText {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Basket Trade Report Type Values
    /// </summary>
    public enum BasketTradeReportType : byte {
        Submit = 0,
        Addendum = 4,
        NoWasSubstitue = 5,
        BasketTradeReportTypeMinimumValue = 5,
        BasketTradeReportTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Basket Trd Match Id
    /// </summary>
    public unsafe struct BasketTrdMatchId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Px
    /// </summary>
    public unsafe struct BestBidPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Size
    /// </summary>
    public unsafe struct BestBidSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Px
    /// </summary>
    public unsafe struct BestOfferPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Size
    /// </summary>
    public unsafe struct BestOfferSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct BidSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct ClearingTradeQty {
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
    ///  Compression Action Values
    /// </summary>
    public enum CompressionAction : byte {
        StartCompression = 1,
        CommitCompression = 2,
        CancelCompression = 3,
        InquireCompression = 4,
        CompressionActionMinimumValue = 4,
        CompressionActionMinimumValue = 1,
    };


    /// <summary>
    ///  Compression Id
    /// </summary>
    public unsafe struct CompressionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Compression Status Values
    /// </summary>
    public enum CompressionStatus : byte {
        Open = 1,
        Executed = 2,
        CancelledByUser = 3,
        CancelledBySystem = 4,
        CompressionStatusMinimumValue = 4,
        CompressionStatusMinimumValue = 1,
    };


    /// <summary>
    ///  Cross Id
    /// </summary>
    public struct CrossId {
        public int Raw;
    };


    /// <summary>
    ///  Cross Request Id
    /// </summary>
    public struct CrossRequestId {
        public int Raw;
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
    public unsafe struct CumQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cust Order Handling Inst Values
    /// </summary>
    public enum CustOrderHandlingInst : byte {
        W = (byte)'W',
        Y = (byte)'Y',
        C = (byte)'C',
        G = (byte)'G',
        H = (byte)'H',
        D = (byte)'D',
    };


    /// <summary>
    ///  Cxl Qty
    /// </summary>
    public unsafe struct CxlQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cxl Size
    /// </summary>
    public unsafe struct CxlSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
        Derivatives = "D0001",
    };


    /// <summary>
    ///  Delete Reason Values
    /// </summary>
    public enum DeleteReason : byte {
        Nospecialreason = 100,
        TasChange = 101,
        IntradayExpiration = 102,
        RiskEvent = 103,
        StopTrading = 104,
        InstrumentDeletion = 105,
        InstrumentSuspension = 106,
        PreTradeRiskEvent = 107,
        AmendmentReset = 108,
        AmendmentUserCancelled = 109,
        CompressionCancelledByUser = 110,
        CompressionCancelledBySystem = 111,
        DeleteReasonMinimumValue = 111,
        DeleteReasonMinimumValue = 100,
    };


    /// <summary>
    ///  Delta
    /// </summary>
    public unsafe struct Delta {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Effect On Basket Values
    /// </summary>
    public enum EffectOnBasket : byte {
        AddVolume = 1,
        RemoveVolume = 2,
        EffectOnBasketMinimumValue = 2,
        EffectOnBasketMinimumValue = 1,
    };


    /// <summary>
    ///  Effective Time
    /// </summary>
    public unsafe struct EffectiveTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Enlight Rfq Avg Resp Rate Ranking Values
    /// </summary>
    public enum EnlightRfqAvgRespRateRanking : byte {
        Low = 1,
        Medium = 2,
        High = 3,
        EnlightRfqAvgRespRateRankingMinimumValue = 3,
        EnlightRfqAvgRespRateRankingMinimumValue = 1,
    };


    /// <summary>
    ///  Enlight Rfq Avg Resp Time Ranking Values
    /// </summary>
    public enum EnlightRfqAvgRespTimeRanking : byte {
        Low = 1,
        Medium = 2,
        High = 3,
        EnlightRfqAvgRespTimeRankingMinimumValue = 3,
        EnlightRfqAvgRespTimeRankingMinimumValue = 1,
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
    ///  Eurex Volume Ranking Values
    /// </summary>
    public enum EurexVolumeRanking : byte {
        Low = 1,
        Medium = 2,
        High = 3,
        EurexVolumeRankingMinimumValue = 3,
        EurexVolumeRankingMinimumValue = 1,
    };


    /// <summary>
    ///  Event Date
    /// </summary>
    public unsafe struct EventDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Type Values
    /// </summary>
    public enum EventType : byte {
        SwapStartDate = 8,
        SwapEndDate = 9,
        EventTypeMinimumValue = 114,
        EventTypeMinimumValue = 8,
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
        OrderBookRestatement = 1,
        OrderAdded = 101,
        OrderModified = 102,
        OrderCancelled = 103,
        IocOrderCancelled = 105,
        BookOrderExecuted = 108,
        ChangedtoIoc = 114,
        InstrumentStateChange = 122,
        MarketOrderTriggered = 135,
        CaoOrderActivated = 149,
        CaoOrderInactivated = 150,
        OcoOrderTriggered = 164,
        StopOrderTriggered = 172,
        OwnershipChanged = 181,
        OrderCancellationPending = 197,
        PendingCancellationExecuted = 199,
        BocOrderCancelled = 212,
        PanicCancel = 261,
        ClipExecution = 340,
        ClipArrangementtimeout = 343,
        ClipArrangementValidation = 344,
        ExecRestatementReasonMinimumValue = 344,
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
    ///  Exercise Style Values
    /// </summary>
    public enum ExerciseStyle : byte {
        European = 0,
        American = 1,
        ExerciseStyleMinimumValue = 1,
        ExerciseStyleMinimumValue = 0,
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
    ///  Expire Time
    /// </summary>
    public unsafe struct ExpireTime {
        public const int Size = 8;

        public long Value;

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
    public unsafe struct FillQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fill Ref Id
    /// </summary>
    public unsafe struct FillRefId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Firm Negotiation Id
    /// </summary>
    public unsafe struct FirmNegotiationId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Firm Trade Id
    /// </summary>
    public unsafe struct FirmTradeId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Free Text 5
    /// </summary>
    public unsafe struct FreeText5 {
        public const int Size = 132;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Free Text 5 Disclosure Instruction Values
    /// </summary>
    public enum FreeText5DisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        FreeText5DisclosureInstructionMinimumValue = 1,
        FreeText5DisclosureInstructionMinimumValue = 0,
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
    ///  Hedge Type Values
    /// </summary>
    public enum HedgeType : byte {
        DurationHedge = 0,
        NominalHedge = 1,
        PriceFactorHedge = 2,
        HedgeTypeMinimumValue = 2,
        HedgeTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Hedging Instruction Values
    /// </summary>
    public enum HedgingInstruction : byte {
        OnClose = 1,
        HedgingInstructionMinimumValue = 1,
        HedgingInstructionMinimumValue = 1,
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
    ///  Individual Alloc Id
    /// </summary>
    public unsafe struct IndividualAllocId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Input Source Values
    /// </summary>
    public enum InputSource : byte {
        ClientBroker = 1,
        ProprietaryBroker = 2,
        InputSourceMinimumValue = 2,
        InputSourceMinimumValue = 1,
    };


    /// <summary>
    ///  Instr Attrib Type Values
    /// </summary>
    public enum InstrAttribType : byte {
        VariableRate = 5,
        CouponRate = 100,
        Offsettothevariablecouponrate = 101,
        SwapCustomer1 = 102,
        SwapCustomer2 = 103,
        CashBasketReference = 104,
        InstrAttribTypeMinimumValue = 104,
        InstrAttribTypeMinimumValue = 5,
    };


    /// <summary>
    ///  Instr Attrib Value
    /// </summary>
    public unsafe struct InstrAttribValue {
        public const int Size = 32;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Instrmt Match Side Id
    /// </summary>
    public unsafe struct InstrmtMatchSideId {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Last Px
    /// </summary>
    public unsafe struct LastPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Px Disclosure Instruction Values
    /// </summary>
    public enum LastPxDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        LastPxDisclosureInstructionMinimumValue = 1,
        LastPxDisclosureInstructionMinimumValue = 0,
    };


    /// <summary>
    ///  Last Qty
    /// </summary>
    public unsafe struct LastQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Qty Disclosure Instruction Values
    /// </summary>
    public enum LastQtyDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        LastQtyDisclosureInstructionMinimumValue = 1,
        LastQtyDisclosureInstructionMinimumValue = 0,
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
    public unsafe struct LeavesQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leaves Qty Disclosure Instruction Values
    /// </summary>
    public enum LeavesQtyDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        LeavesQtyDisclosureInstructionMinimumValue = 1,
        LeavesQtyDisclosureInstructionMinimumValue = 0,
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
    ///  Leg Input Source Values
    /// </summary>
    public enum LegInputSource : byte {
        ClientBroker = 1,
        ProprietaryBroker = 2,
        LegInputSourceMinimumValue = 2,
        LegInputSourceMinimumValue = 1,
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
    public unsafe struct LegLastQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Leg Qty
    /// </summary>
    public unsafe struct LegQty {
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
        Nodx = 12,
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
        InternalConnectionLoss = 100,
        ProductStateHalt = 105,
        ProductStateHoliday = 106,
        InstrumentSuspended = 107,
        ComplexInstrumentDeletion = 109,
        VolatilityInterruption = 110,
        Producttemporarilynottradeable = 111,
        Memberdisable = 117,
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
    ///  Mass Action Sub Type Values
    /// </summary>
    public enum MassActionSubType : byte {
        BookorCancel = 1,
        MassActionSubTypeMinimumValue = 1,
        MassActionSubTypeMinimumValue = 1,
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
        OutsideBbo = 6,
        MatchSubTypeMinimumValue = 6,
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
        LiquidityImprovementCross = 13,
        MatchTypeMinimumValue = 14,
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
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity Month Year
    /// </summary>
    public unsafe struct MaturityMonthYear {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maximum Price
    /// </summary>
    public unsafe struct MaximumPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Book Type Values
    /// </summary>
    public enum MdBookType : byte {
        TopOfBook = 1,
        PriceDepth = 2,
        MdBookTypeMinimumValue = 2,
        MdBookTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Md Sub Book Type Values
    /// </summary>
    public enum MdSubBookType : byte {
        Implied = 1,
        VolumeWeightedAverage = 2,
        MdSubBookTypeMinimumValue = 2,
        MdSubBookTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Message Event Source Values
    /// </summary>
    public enum MessageEventSource : byte {
        BroadcasttoInitiator = (byte)'I',
        BroadcasttoApprover = (byte)'A',
        BroadcasttoRequester = (byte)'R',
        BroadcasttoQuoteSubmitter = (byte)'Q',
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
    ///  Multileg Price Model Values
    /// </summary>
    public enum MultilegPriceModel : byte {
        Standard = 0,
        UserDefined = 1,
        MultilegPriceModelMinimumValue = 1,
        MultilegPriceModelMinimumValue = 0,
    };


    /// <summary>
    ///  Negotiate Underlying Values
    /// </summary>
    public enum NegotiateUnderlying : byte {
        No = 0,
        Yes = 1,
        NegotiateUnderlyingMinimumValue = 1,
        NegotiateUnderlyingMinimumValue = 0,
    };


    /// <summary>
    ///  Negotiation Id
    /// </summary>
    public unsafe struct NegotiationId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Negotiation Start Time
    /// </summary>
    public unsafe struct NegotiationStartTime {
        public const int Size = 8;

        public long Value;

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
    ///  No Affected Order Requests
    /// </summary>
    public unsafe struct NoAffectedOrderRequests {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Basket Root Party Grps
    /// </summary>
    public unsafe struct NoBasketRootPartyGrps {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Basket Root Party Grps Bc
    /// </summary>
    public unsafe struct NoBasketRootPartyGrpsBc {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Basket Side Alloc
    /// </summary>
    public unsafe struct NoBasketSideAlloc {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Cross Legs
    /// </summary>
    public unsafe struct NoCrossLegs {
        public const int Size = 1;

        public sbyte Value;

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
    ///  No Events
    /// </summary>
    public unsafe struct NoEvents {
        public const int Size = 1;

        public sbyte Value;

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
    ///  No Instr Attrib
    /// </summary>
    public unsafe struct NoInstrAttrib {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Instrmt Match Sides
    /// </summary>
    public unsafe struct NoInstrmtMatchSides {
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
    ///  No Order Book Items
    /// </summary>
    public unsafe struct NoOrderBookItems {
        public const int Size = 1;

        public sbyte Value;

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
    ///  No Quote Side Entries
    /// </summary>
    public unsafe struct NoQuoteSideEntries {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Risk Limits
    /// </summary>
    public unsafe struct NoRiskLimits {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Risk Limits Qty
    /// </summary>
    public unsafe struct NoRiskLimitsQty {
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
    ///  No Side Allocs
    /// </summary>
    public unsafe struct NoSideAllocs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Sides
    /// </summary>
    public unsafe struct NoSides {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Srqs Related Trade I Ds
    /// </summary>
    public unsafe struct NoSrqsRelatedTradeIDs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Target Party I Ds
    /// </summary>
    public unsafe struct NoTargetPartyIDs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Underlying Stips
    /// </summary>
    public unsafe struct NoUnderlyingStips {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Number Of Resp Disclosure Instruction Values
    /// </summary>
    public enum NumberOfRespDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        NumberOfRespDisclosureInstructionMinimumValue = 1,
        NumberOfRespDisclosureInstructionMinimumValue = 0,
    };


    /// <summary>
    ///  Number Of Respondents
    /// </summary>
    public unsafe struct NumberOfRespondents {
        public const int Size = 4;

        public int Value;

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
    public unsafe struct OfferSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opt Attribute
    /// </summary>
    public unsafe struct OptAttribute {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Order Attribute Risk Reduction Values
    /// </summary>
    public enum OrderAttributeRiskReduction : byte {
        Y = 1,
        N = 0,
        OrderAttributeRiskReductionMinimumValue = 1,
        OrderAttributeRiskReductionMinimumValue = 0,
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
    ///  Order Origination Values
    /// </summary>
    public enum OrderOrigination : byte {
        Directaccessorsponsoredaccesscustomer = 5,
        OrderOriginationMinimumValue = 5,
        OrderOriginationMinimumValue = 5,
    };


    /// <summary>
    ///  Order Qty
    /// </summary>
    public unsafe struct OrderQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Qty Disclosure Instruction Values
    /// </summary>
    public enum OrderQtyDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        OrderQtyDisclosureInstructionMinimumValue = 1,
        OrderQtyDisclosureInstructionMinimumValue = 0,
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
    ///  Package Id
    /// </summary>
    public unsafe struct PackageId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pad 1
    /// </summary>
    public unsafe struct Pad1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Pad 11
    /// </summary>
    public unsafe struct Pad11 {
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
    ///  Pad 31
    /// </summary>
    public unsafe struct Pad31 {
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
    ///  Party Detail Executing Unit
    /// </summary>
    public unsafe struct PartyDetailExecutingUnit {
        public const int Size = 5;

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
        Rejected = 2,
        PartyDetailStatusMinimumValue = 2,
        PartyDetailStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Party Detail Status Information Values
    /// </summary>
    public enum PartyDetailStatusInformation : byte {
        Trrthresholdtoobig = 1,
        Blockallanonymous = 2,
        PartyDetailStatusInformationMinimumValue = 2,
        PartyDetailStatusInformationMinimumValue = 1,
    };


    /// <summary>
    ///  Party Entering Trader
    /// </summary>
    public unsafe struct PartyEnteringTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Party Executing Trader
    /// </summary>
    public unsafe struct PartyExecutingTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Executing Unit
    /// </summary>
    public unsafe struct PartyExecutingUnit {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
        PartyIdEnteringFirmMinimumValue = 3,
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
        PartyIdOriginationMarketMinimumValue = 2,
        PartyIdOriginationMarketMinimumValue = 1,
    };


    /// <summary>
    ///  Party Id Position Account
    /// </summary>
    public unsafe struct PartyIdPositionAccount {
        public const int Size = 32;

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
    ///  Party Id Settlement Location Values
    /// </summary>
    public enum PartyIdSettlementLocation : byte {
        ClearstremBankingFrankfurt = 1,
        ClearstremBankingLuxemburg = 2,
        ClsGroup = 3,
        Euroclear = 4,
        PartyIdSettlementLocationMinimumValue = 4,
        PartyIdSettlementLocationMinimumValue = 1,
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
    ///  Party Order Origination Disclosure Instruction Values
    /// </summary>
    public enum PartyOrderOriginationDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        PartyOrderOriginationDisclosureInstructionMinimumValue = 1,
        PartyOrderOriginationDisclosureInstructionMinimumValue = 0,
    };


    /// <summary>
    ///  Party Order Origination Trader
    /// </summary>
    public unsafe struct PartyOrderOriginationTrader {
        public const int Size = 132;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Party Sub Id Type Values
    /// </summary>
    public enum PartySubIdType : ushort {
        Buyer = 14001,
        Seller = 14002,
        PartySubIdTypeMinimumValue = 14002,
        PartySubIdTypeMinimumValue = 14001,
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
    ///  Price Disclosure Instruction Values
    /// </summary>
    public enum PriceDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        PriceDisclosureInstructionMinimumValue = 1,
        PriceDisclosureInstructionMinimumValue = 0,
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
        Flexiblesimpleinstrument = 10,
        ProductComplexMinimumValue = 10,
        ProductComplexMinimumValue = 1,
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = 0,
        Call = 1,
        PutOrCallMinimumValue = 1,
        PutOrCallMinimumValue = 0,
    };


    /// <summary>
    ///  Quote Cancel Type Values
    /// </summary>
    public enum QuoteCancelType : byte {
        CancelAllQuotes = 4,
        QuoteCancelTypeMinimumValue = 4,
        QuoteCancelTypeMinimumValue = 4,
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
        EntitlementNotAssignedForUnderlying = 119,
        CurrentlyNotTradeableOnBook = 124,
        QuantityLimitExceeded = 125,
        ValueLimitExceeded = 126,
        InvalidQuoteSpread = 127,
        BookorCancel = 128,
        CantProcInCurrInstrState = 131,
        InvalidQuoteType = 134,
        Tradingindicationrunningfortrader = 143,
        OnBookTradingdisabledforInstrumentType = 144,
        Liquidityproviderprotectionbidsidecancelled = 147,
        Liquidityproviderprotectionasksidecancelled = 148,
        OutsideQuotingPeriod = 155,
        MatchPriceNotOnPriceStep = 156,
        QuantityLimitExceedsTsl = 161,
        TooManyOrdersandQuotesinOrderBook = 163,
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
        Auction = 4,
        QuoteEventLiquidityIndMinimumValue = 4,
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
    public unsafe struct QuoteEventQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Event Reason Values
    /// </summary>
    public enum QuoteEventReason : byte {
        Pendingcancellationexecuted = 14,
        Invalidprice = 15,
        Crossrejected = 16,
        BookorCancel = 17,
        Plp = 18,
        QuoteEventReasonMinimumValue = 21,
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
    ///  Quote Instruction Values
    /// </summary>
    public enum QuoteInstruction : byte {
        DoNotQuote = 0,
        Quote = 1,
        QuoteInstructionMinimumValue = 1,
        QuoteInstructionMinimumValue = 0,
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
    ///  Quote Ref Price
    /// </summary>
    public unsafe struct QuoteRefPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Ref Price Source Values
    /// </summary>
    public enum QuoteRefPriceSource : byte {
        Underlying = 1,
        CustomUnderlyingPrice = 2,
        RefPrice = 3,
        QuoteRefPriceSourceMinimumValue = 3,
        QuoteRefPriceSourceMinimumValue = 1,
    };


    /// <summary>
    ///  Quote Req Id
    /// </summary>
    public unsafe struct QuoteReqId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Quote Status Values
    /// </summary>
    public enum QuoteStatus : byte {
        Removed = 6,
        Expired = 7,
        Active = 16,
        QuoteStatusMinimumValue = 17,
        QuoteStatusMinimumValue = 6,
    };


    /// <summary>
    ///  Quote Sub Type Values
    /// </summary>
    public enum QuoteSubType : byte {
        WorkingDelta = 1,
        BasisTrade = 2,
        QuoteSubTypeMinimumValue = 2,
        QuoteSubTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Quote Type Values
    /// </summary>
    public enum QuoteType : byte {
        Indicative = 0,
        Tradeable = 1,
        TradeableBoc = 100,
        QuoteTypeMinimumValue = 103,
        QuoteTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Quoting Status Values
    /// </summary>
    public enum QuotingStatus : byte {
        OpenActive = 1,
        OpenIdle = 2,
        ClosedInactive = 3,
        QuotingStatusMinimumValue = 4,
        QuotingStatusMinimumValue = 0,
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
        TesMaintenance = 7,
        TesTrade = 8,
        SrqsMaintenance = 9,
        ServiceAvailabilityMarket = 10,
        RefApplIDMinimumValue = 11,
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
    ///  Regulatory Trade Id
    /// </summary>
    public unsafe struct RegulatoryTradeId {
        public const int Size = 52;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Related Close Price
    /// </summary>
    public unsafe struct RelatedClosePrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Related Market Segment Id
    /// </summary>
    public struct RelatedMarketSegmentId {
        public int Raw;
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
    ///  Related Trade Id
    /// </summary>
    public unsafe struct RelatedTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Related Trade Quantity
    /// </summary>
    public unsafe struct RelatedTradeQuantity {
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
    ///  Requesting Party Sub Id Type Values
    /// </summary>
    public enum RequestingPartySubIdType : ushort {
        Requester = 5000,
        Responder = 5001,
        Both = 5002,
        System = 5003,
        RequestingPartySubIdTypeMinimumValue = 5003,
        RequestingPartySubIdTypeMinimumValue = 5000,
    };


    /// <summary>
    ///  Respondent Type Values
    /// </summary>
    public enum RespondentType : byte {
        AllMarketParticipants = 1,
        Anonymous = 102,
        RespondentTypeMinimumValue = 102,
        RespondentTypeMinimumValue = 1,
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
    ///  Reversal Approval Time
    /// </summary>
    public unsafe struct ReversalApprovalTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reversal Cancellation Reason Values
    /// </summary>
    public enum ReversalCancellationReason : byte {
        TasChange = 1,
        IntradayExpiration = 2,
        InstrumentDeletion = 3,
        InstrumentSuspension = 4,
        ReversalCancellationReasonMinimumValue = 4,
        ReversalCancellationReasonMinimumValue = 1,
    };


    /// <summary>
    ///  Reversal Indicator Values
    /// </summary>
    public enum ReversalIndicator : byte {
        No = 0,
        Yes = 1,
        ReversalIndicatorMinimumValue = 1,
        ReversalIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Reversal Initiation Time
    /// </summary>
    public unsafe struct ReversalInitiationTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reversal Reason Text
    /// </summary>
    public unsafe struct ReversalReasonText {
        public const int Size = 132;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Action Values
    /// </summary>
    public enum RiskLimitAction : byte {
        QueueInbound = 0,
        Reject = 2,
        Warning = 4,
        RiskLimitActionMinimumValue = 4,
        RiskLimitActionMinimumValue = 0,
    };


    /// <summary>
    ///  Risk Limit Group
    /// </summary>
    public unsafe struct RiskLimitGroup {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Net Position Qty
    /// </summary>
    public unsafe struct RiskLimitNetPositionQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Open Qty
    /// </summary>
    public unsafe struct RiskLimitOpenQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Platform Values
    /// </summary>
    public enum RiskLimitPlatform : byte {
        OnBook = 0,
        OffBook = 1,
        RiskLimitPlatformMinimumValue = 1,
        RiskLimitPlatformMinimumValue = 0,
    };


    /// <summary>
    ///  Risk Limit Qty
    /// </summary>
    public unsafe struct RiskLimitQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Report Id
    /// </summary>
    public unsafe struct RiskLimitReportId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Limit Requesting Party Role Values
    /// </summary>
    public enum RiskLimitRequestingPartyRole : byte {
        Clearingfirm = 4,
        Exchange = 22,
        Executingunit = 59,
        RiskLimitRequestingPartyRoleMinimumValue = 59,
        RiskLimitRequestingPartyRoleMinimumValue = 4,
    };


    /// <summary>
    ///  Risk Limit Type Values
    /// </summary>
    public enum RiskLimitType : byte {
        Longlimit = 4,
        Shortlimit = 5,
        RiskLimitTypeMinimumValue = 5,
        RiskLimitTypeMinimumValue = 4,
    };


    /// <summary>
    ///  Risk Limit Violation Indicator Values
    /// </summary>
    public enum RiskLimitViolationIndicator : byte {
        No = 0,
        Yes = 1,
        RiskLimitViolationIndicatorMinimumValue = 1,
        RiskLimitViolationIndicatorMinimumValue = 0,
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
    ///  Root Party Contra Trader
    /// </summary>
    public unsafe struct RootPartyContraTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Entering Trader
    /// </summary>
    public unsafe struct RootPartyEnteringTrader {
        public const int Size = 6;

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
    ///  Root Party Id Client Id
    /// </summary>
    public unsafe struct RootPartyIdClientId {
        public const int Size = 8;

        public long Value;

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
    ///  Root Party Id Execution Venue
    /// </summary>
    public unsafe struct RootPartyIdExecutionVenue {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Investment Decision Maker
    /// </summary>
    public unsafe struct RootPartyIdInvestmentDecisionMaker {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Root Party Id Investment Decision Maker Qualifier Values
    /// </summary>
    public enum RootPartyIdInvestmentDecisionMakerQualifier : byte {
        Algo = 22,
        Human = 24,
        RootPartyIdInvestmentDecisionMakerQualifierMinimumValue = 24,
        RootPartyIdInvestmentDecisionMakerQualifierMinimumValue = 22,
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
        public const int Size = 32;

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
    ///  Root Party Sub Id Type Values
    /// </summary>
    public enum RootPartySubIdType : ushort {
        Buyer = 4001,
        Seller = 4002,
        Broker = 4003,
        RootPartySubIdTypeMinimumValue = 4003,
        RootPartySubIdTypeMinimumValue = 4001,
    };


    /// <summary>
    ///  Secondary Quote Id
    /// </summary>
    public unsafe struct SecondaryQuoteId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secondary Trade Id
    /// </summary>
    public unsafe struct SecondaryTradeId {
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
    ///  Selective Request For Quote Service Status Values
    /// </summary>
    public enum SelectiveRequestForQuoteServiceStatus : byte {
        Unavailable = 0,
        Available = 1,
        SelectiveRequestForQuoteServiceStatusMinimumValue = 1,
        SelectiveRequestForQuoteServiceStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Selective Request For Quote Service Trade Date
    /// </summary>
    public unsafe struct SelectiveRequestForQuoteServiceTradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
        Outboundconversionerror = 105,
        HeartbeatViolation = 152,
        Internaltechnicalerror = 200,
        ValidationError = 210,
        UserAlreadyLoggedIn = 211,
        GatewayIsStandby = 216,
        SessionLoginLimitReached = 217,
        UserEntitlementDataTimeout = 223,
        PsGatewaySessionLimitReached = 224,
        UserLoginLimitReached = 225,
        OutstandingLoginsBuLimitReached = 226,
        OutstandingLoginsSessionLimitReached = 227,
        OrderNotFound = 10000,
        PriceNotReasonable = 10001,
        ClientOrderIdNotUnique = 10002,
        QuoteActivationInProgress = 10003,
        StopBidPriceNotReasonable = 10006,
        StopAskPriceNotReasonable = 10007,
        OrderNotExecutableWithinValidity = 10008,
        CreateCiThrottleExceeded = 10010,
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
        SessionSubModeMinimumValue = 3,
        SessionSubModeMinimumValue = 0,
    };


    /// <summary>
    ///  Settl Method Values
    /// </summary>
    public enum SettlMethod : byte {
        CashSettlement = (byte)'C',
        PhysicalSettlement = (byte)'P',
    };


    /// <summary>
    ///  Show Last Deal On Closure Values
    /// </summary>
    public enum ShowLastDealOnClosure : byte {
        No = 0,
        Yes = 1,
        ShowLastDealOnClosureMinimumValue = 1,
        ShowLastDealOnClosureMinimumValue = 0,
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
    ///  Side Compliance Text
    /// </summary>
    public unsafe struct SideComplianceText {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Disclosure Instruction Values
    /// </summary>
    public enum SideDisclosureInstruction : byte {
        No = 0,
        Yes = 1,
        SideDisclosureInstructionMinimumValue = 1,
        SideDisclosureInstructionMinimumValue = 0,
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
    public unsafe struct SideLastQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Side Market Segment Id
    /// </summary>
    public struct SideMarketSegmentId {
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
    ///  Side Trd Sub Typ Values
    /// </summary>
    public enum SideTrdSubTyp : ushort {
        BlockTrade = 2001,
        TradeatMarket = 2004,
        SideTrdSubTypMinimumValue = 2004,
        SideTrdSubTypMinimumValue = 2001,
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
    ///  Skip Validations Values
    /// </summary>
    public enum SkipValidations : byte {
        False = 0,
        True = 1,
        SkipValidationsMinimumValue = 1,
        SkipValidationsMinimumValue = 0,
    };


    /// <summary>
    ///  Srqs Related Trade Id
    /// </summary>
    public unsafe struct SrqsRelatedTradeId {
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
    ///  Strike Price
    /// </summary>
    public unsafe struct StrikePrice {
        public const int Size = 8;

        public long Value;

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
    ///  T 7 Entry Service Rtm Status Values
    /// </summary>
    public enum T7EntryServiceRtmStatus : byte {
        Unavailable = 0,
        Available = 1,
        T7EntryServiceRtmStatusMinimumValue = 1,
        T7EntryServiceRtmStatusMinimumValue = 0,
    };


    /// <summary>
    ///  T 7 Entry Service Rtm Trade Date
    /// </summary>
    public unsafe struct T7EntryServiceRtmTradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  T 7 Entry Service Status Values
    /// </summary>
    public enum T7EntryServiceStatus : byte {
        Unavailable = 0,
        Available = 1,
        T7EntryServiceStatusMinimumValue = 1,
        T7EntryServiceStatusMinimumValue = 0,
    };


    /// <summary>
    ///  T 7 Entry Service Trade Date
    /// </summary>
    public unsafe struct T7EntryServiceTradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Party Entering Trader
    /// </summary>
    public unsafe struct TargetPartyEnteringTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Party Executing Firm
    /// </summary>
    public unsafe struct TargetPartyExecutingFirm {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Party Executing Trader
    /// </summary>
    public unsafe struct TargetPartyExecutingTrader {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Tes Enrichment Rule Id
    /// </summary>
    public unsafe struct TesEnrichmentRuleId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tes Exec Id
    /// </summary>
    public unsafe struct TesExecId {
        public const int Size = 4;

        public int Value;

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
        DisasterRecovery = 5,
        TradSesModeMinimumValue = 5,
        TradSesModeMinimumValue = 1,
    };


    /// <summary>
    ///  Trade Alloc Status Values
    /// </summary>
    public enum TradeAllocStatus : byte {
        Pending = 1,
        Approved = 2,
        AutoApproved = 3,
        Uploaded = 4,
        Canceled = 5,
        PendingExecution = 6,
        PendingReversal = 7,
        ApprovedReversal = 8,
        Reversed = 9,
        CancelledReversal = 10,
        TradeAllocStatusMinimumValue = 10,
        TradeAllocStatusMinimumValue = 0,
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
    ///  Trade Platform Values
    /// </summary>
    public enum TradePlatform : byte {
        OffBook = 0,
        OnBook = 1,
        TradePlatformMinimumValue = 1,
        TradePlatformMinimumValue = 0,
    };


    /// <summary>
    ///  Trade Publish Indicator Values
    /// </summary>
    public enum TradePublishIndicator : byte {
        DoNotPublishTrade = 0,
        PublishTrade = 1,
        DeferredPublication = 2,
        Published = 3,
        TradePublishIndicatorMinimumValue = 3,
        TradePublishIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Trade Report Id
    /// </summary>
    public unsafe struct TradeReportId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Report Text
    /// </summary>
    public unsafe struct TradeReportText {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Report Type Values
    /// </summary>
    public enum TradeReportType : byte {
        Submit = 0,
        Alleged = 1,
        Accept = 2,
        Decline = 3,
        NoWasReplaced = 5,
        TradeReportCancel = 6,
        TradeBreak = 7,
        AllegedNew = 11,
        AllegedNoWas = 13,
        TradeReportTypeMinimumValue = 13,
        TradeReportTypeMinimumValue = 0,
    };


    /// <summary>
    ///  Trade Request Result Values
    /// </summary>
    public enum TradeRequestResult : byte {
        Cancelpending = 100,
        Canceldeclined = 101,
        Cancelapproved = 102,
        TradeRequestResultMinimumValue = 102,
        TradeRequestResultMinimumValue = 100,
    };


    /// <summary>
    ///  Trade To Quote Ratio Ranking Values
    /// </summary>
    public enum TradeToQuoteRatioRanking : byte {
        Low = 1,
        Medium = 2,
        High = 3,
        TradeToQuoteRatioRankingMinimumValue = 3,
        TradeToQuoteRatioRankingMinimumValue = 1,
    };


    /// <summary>
    ///  Trade To Request Ratio
    /// </summary>
    public unsafe struct TradeToRequestRatio {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Underlying Values
    /// </summary>
    public enum TradeUnderlying : byte {
        No = 1,
        Yes = 2,
        TradeUnderlyingMinimumValue = 2,
        TradeUnderlyingMinimumValue = 1,
    };


    /// <summary>
    ///  Trading Capacity Values
    /// </summary>
    public enum TradingCapacity : byte {
        Customer = 1,
        Principal = 5,
        MarketMaker = 6,
        TradingCapacityMinimumValue = 9,
        TradingCapacityMinimumValue = 1,
    };


    /// <summary>
    ///  Trading Session Sub Id Values
    /// </summary>
    public enum TradingSessionSubId : byte {
        Closingauction = 4,
        TradingSessionSubIDMinimumValue = 105,
        TradingSessionSubIDMinimumValue = 1,
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
    ///  Transaction Delay Indicator Values
    /// </summary>
    public enum TransactionDelayIndicator : byte {
        Notdelayed = 0,
        Delayed = 1,
        TransactionDelayIndicatorMinimumValue = 1,
        TransactionDelayIndicatorMinimumValue = 0,
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
    ///  Trd Reg Ts Execution Time
    /// </summary>
    public unsafe struct TrdRegTsExecutionTime {
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
    ///  Trd Rpt Status Values
    /// </summary>
    public enum TrdRptStatus : byte {
        Accepted = 0,
        Rejected = 1,
        Cancelled = 2,
        PendingNew = 4,
        Terminated = 7,
        DeemedVerified = 9,
        TrdRptStatusMinimumValue = 9,
        TrdRptStatusMinimumValue = 0,
    };


    /// <summary>
    ///  Trd Type Values
    /// </summary>
    public enum TrdType : ushort {
        BlockTrade = 1,
        ExchangeforSwap = 12,
        Compression = 50,
        VolaTrade = 1000,
        EfpFinTrade = 1001,
        EfpIndexFuturesTrade = 1002,
        TradeatMarket = 1004,
        Enlight = 1006,
        Blockqtpip = 1007,
        Btrf = 1010,
        Ebb = 1011,
        TrdTypeMinimumValue = 1011,
        TrdTypeMinimumValue = 1,
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
    ///  Underlying Currency
    /// </summary>
    public unsafe struct UnderlyingCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Delta Percentage
    /// </summary>
    public unsafe struct UnderlyingDeltaPercentage {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Effective Delta Percentage
    /// </summary>
    public unsafe struct UnderlyingEffectiveDeltaPercentage {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Issuer
    /// </summary>
    public unsafe struct UnderlyingIssuer {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Maturity Date
    /// </summary>
    public unsafe struct UnderlyingMaturityDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Price Stip Value
    /// </summary>
    public unsafe struct UnderlyingPriceStipValue {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Px
    /// </summary>
    public unsafe struct UnderlyingPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Qty
    /// </summary>
    public unsafe struct UnderlyingQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Security Desc
    /// </summary>
    public unsafe struct UnderlyingSecurityDesc {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Security Id
    /// </summary>
    public unsafe struct UnderlyingSecurityId {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Settlement Date
    /// </summary>
    public unsafe struct UnderlyingSettlementDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Stip Type Values
    /// </summary>
    public enum UnderlyingStipType : ulong {
        PayFrequency = "PAYFREQ",
    };


    /// <summary>
    ///  Underlying Stip Value
    /// </summary>
    public unsafe struct UnderlyingStipValue {
        public const int Size = 32;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Valid Until Time
    /// </summary>
    public unsafe struct ValidUntilTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Value Check Type Min Lot Size Values
    /// </summary>
    public enum ValueCheckTypeMinLotSize : byte {
        Donotcheck = 0,
        Check = 1,
        ValueCheckTypeMinLotSizeMinimumValue = 1,
        ValueCheckTypeMinLotSizeMinimumValue = 0,
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
    ///  Vega
    /// </summary>
    public unsafe struct Vega {
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
    ///  Struct for Add Complex Instrument Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddComplexInstrumentRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
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
    ///  Struct for Add Flexible Instrument Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddFlexibleInstrumentRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        StrikePrice StrikePrice;
        MarketSegmentId MarketSegmentId;
        MaturityDate MaturityDate;
        SettlMethod SettlMethod;
        OptAttribute OptAttribute;
        PutOrCall PutOrCall;
        ExerciseStyle ExerciseStyle;
        ComplianceText ComplianceText;
    };


    /// <summary>
    ///  Struct for Add Flexible Instrument Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddFlexibleInstrumentResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        SecurityResponseId SecurityResponseId;
        SecurityId SecurityId;
        StrikePrice StrikePrice;
        MarketSegmentId MarketSegmentId;
        MaturityDate MaturityDate;
        ProductComplex ProductComplex;
        SettlMethod SettlMethod;
        OptAttribute OptAttribute;
        PutOrCall PutOrCall;
        ExerciseStyle ExerciseStyle;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Affected Order Requests Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AffectedOrderRequestsGrpComp {
        AffectedOrderRequestId AffectedOrderRequestId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Approve Basket Trade Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApproveBasketTradeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        BasketTrdMatchId BasketTrdMatchId;
        BasketExecId BasketExecId;
        MarketSegmentId MarketSegmentId;
        RootPartySubIdType RootPartySubIdType;
        TrdType TrdType;
        TradeReportType TradeReportType;
        NoBasketSideAlloc NoBasketSideAlloc;
        BasketTradeReportText BasketTradeReportText;
        TradeReportId TradeReportId;
        BasketSideTradeReportId BasketSideTradeReportId;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Approve Reverse Tes Trade Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApproveReverseTesTradeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        PackageId PackageId;
        AllocId AllocId;
        TesExecId TesExecId;
        RelatedMarketSegmentId RelatedMarketSegmentId;
        TrdType TrdType;
        TradeReportId TradeReportId;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Approve Tes Trade Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApproveTesTradeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        AllocQty AllocQty;
        CompressionId CompressionId;
        PackageId PackageId;
        AllocId AllocId;
        TesExecId TesExecId;
        MarketSegmentId MarketSegmentId;
        RelatedMarketSegmentId RelatedMarketSegmentId;
        TrdType TrdType;
        TradingCapacity TradingCapacity;
        TradeReportType TradeReportType;
        Side Side;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        OrderOrigination OrderOrigination;
        TradeReportId TradeReportId;
        PositionEffect PositionEffect;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Account Account;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
    };


    /// <summary>
    ///  Struct for Basket Delete Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketDeleteBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        BasketTrdMatchId BasketTrdMatchId;
        TransactTime TransactTime;
        MarketSegmentId MarketSegmentId;
        BasketExecId BasketExecId;
        BasketProfileId BasketProfileId;
        TrdType TrdType;
        DeleteReason DeleteReason;
        MessageEventSource MessageEventSource;
        TradeReportId TradeReportId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Basket Exec Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketExecGrpComp {
        PackageId PackageId;
        SideMarketSegmentId SideMarketSegmentId;
        AllocId AllocId;
        SideTrdSubTyp SideTrdSubTyp;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Basket Execution Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketExecutionBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        BasketTrdMatchId BasketTrdMatchId;
        TransactTime TransactTime;
        BasketExecId BasketExecId;
        MarketSegmentId MarketSegmentId;
        BasketProfileId BasketProfileId;
        TrdType TrdType;
        TradeReportType TradeReportType;
        NoInstrmtMatchSides NoInstrmtMatchSides;
        MessageEventSource MessageEventSource;
        BasketSideTradeReportId BasketSideTradeReportId;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Basket Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        BasketExecId BasketExecId;
        TradeReportId TradeReportId;
    };


    /// <summary>
    ///  Struct for Basket Root Party Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketRootPartyGrpComp {
        RootPartySubIdType RootPartySubIdType;
        RootPartyContraFirm RootPartyContraFirm;
        RootPartyContraTrader RootPartyContraTrader;
        BasketSideTradeReportId BasketSideTradeReportId;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Basket Side Alloc Ext Bc Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketSideAllocExtBcGrpComp {
        AllocQty AllocQty;
        SecurityId SecurityId;
        LastPx LastPx;
        TransBkdTime TransBkdTime;
        RelatedClosePrice RelatedClosePrice;
        PackageId PackageId;
        SideMarketSegmentId SideMarketSegmentId;
        AllocId AllocId;
        NegotiationId NegotiationId;
        SrqsRelatedTradeId SrqsRelatedTradeId;
        SideTrdSubTyp SideTrdSubTyp;
        PartySubIdType PartySubIdType;
        Side Side;
        PositionEffect PositionEffect;
        EffectOnBasket EffectOnBasket;
        TradingCapacity TradingCapacity;
        TradeAllocStatus TradeAllocStatus;
        ProductComplex ProductComplex;
        TradePublishIndicator TradePublishIndicator;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Account Account;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Basket Side Alloc Ext Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketSideAllocExtGrpComp {
        AllocQty AllocQty;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        PackageId PackageId;
        SideMarketSegmentId SideMarketSegmentId;
        AllocId AllocId;
        Side Side;
        PositionEffect PositionEffect;
        TradingCapacity TradingCapacity;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        OrderOrigination OrderOrigination;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Account Account;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Basket Side Alloc Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BasketSideAllocGrpComp {
        AllocQty AllocQty;
        IndividualAllocId IndividualAllocId;
        PartySubIdType PartySubIdType;
        Side Side;
        InstrmtMatchSideId InstrmtMatchSideId;
        TradeAllocStatus TradeAllocStatus;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Broadcast Error Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BroadcastErrorNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        NotifHeaderComp NotifHeaderComp;
        ApplIdStatus ApplIdStatus;
        RefApplSubId RefApplSubId;
        VarTextLen VarTextLen;
        RefApplId RefApplId;
        SessionStatus SessionStatus;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Clip Deletion Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClipDeletionNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderMeComp RbcHeaderMeComp;
        OrderId OrderId;
        ExecId ExecId;
        SecurityId SecurityId;
        CxlQty CxlQty;
        MarketSegmentId MarketSegmentId;
        ExecRestatementReason ExecRestatementReason;
        ProductComplex ProductComplex;
        Side Side;
        OrdStatus OrdStatus;
        ExecType ExecType;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Clip Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClipResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        ExecId ExecId;
        SecurityId SecurityId;
        MarketSegmentId MarketSegmentId;
        CrossRequestId CrossRequestId;
        NoSides NoSides;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Cross Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        SecurityId SecurityId;
        OrderQty OrderQty;
        MarketSegmentId MarketSegmentId;
        ComplianceText ComplianceText;
    };


    /// <summary>
    ///  Struct for Cross Request Ack Side Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequestAckSideGrpComp {
        OrderId OrderId;
        InputSource InputSource;
        Side Side;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Cross Request Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequestResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        ExecId ExecId;
    };


    /// <summary>
    ///  Struct for Cross Request Side Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequestSideGrpComp {
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MaximumPrice MaximumPrice;
        InputSource InputSource;
        Side Side;
        TradingCapacity TradingCapacity;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        PositionEffect PositionEffect;
        CustOrderHandlingInst CustOrderHandlingInst;
        Account Account;
        PartyIdPositionAccount PartyIdPositionAccount;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        SideComplianceText SideComplianceText;
        PartyIdLocationId PartyIdLocationId;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Delete All Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderNrResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        MassActionReportId MassActionReportId;
    };


    /// <summary>
    ///  Struct for Delete All Order Quote Event Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllOrderQuoteEventBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderMeComp RbcHeaderMeComp;
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
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        SecurityId SecurityId;
        Price Price;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        Side Side;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
    };


    /// <summary>
    ///  Struct for Delete All Quote Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteAllQuoteBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderMeComp RbcHeaderMeComp;
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
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        MassActionReportId MassActionReportId;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Delete Basket Trade Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteBasketTradeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        BasketTrdMatchId BasketTrdMatchId;
        BasketExecId BasketExecId;
        MarketSegmentId MarketSegmentId;
        TrdType TrdType;
        TradeReportType TradeReportType;
        TradeReportId TradeReportId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Delete Clip Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteClipRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        OrderId OrderId;
        SecurityId SecurityId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        CrossRequestId CrossRequestId;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Delete Order Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderMeComp RbcHeaderMeComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        CumQty CumQty;
        CxlQty CxlQty;
        MarketSegmentId MarketSegmentId;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        PartyIdSessionId PartyIdSessionId;
        ExecRestatementReason ExecRestatementReason;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ProductComplex ProductComplex;
        Side Side;
        FixClOrdId FixClOrdId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Delete Order Complex Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderComplexRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        FixClOrdId FixClOrdId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Delete Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderNrResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
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
        TransactionDelayIndicator TransactionDelayIndicator;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Delete Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderMeComp ResponseHeaderMeComp;
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
        TransactionDelayIndicator TransactionDelayIndicator;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Delete Order Single Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderSingleRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        SimpleSecurityId SimpleSecurityId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        FixClOrdId FixClOrdId;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Delete Tes Trade Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteTesTradeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        CompressionId CompressionId;
        PackageId PackageId;
        MarketSegmentId MarketSegmentId;
        TesExecId TesExecId;
        RelatedMarketSegmentId RelatedMarketSegmentId;
        TrdType TrdType;
        TradeReportType TradeReportType;
        TradeReportId TradeReportId;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Enrichment Rules Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EnrichmentRulesGrpComp {
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
    ///  Struct for Fills Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FillsGrpComp {
        FillPx FillPx;
        FillQty FillQty;
        FillMatchId FillMatchId;
        FillExecId FillExecId;
        FillLiquidityInd FillLiquidityInd;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Forced Logout Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ForcedLogoutNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        NotifHeaderComp NotifHeaderComp;
        VarTextLen VarTextLen;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Forced User Logout Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ForcedUserLogoutNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        NotifHeaderComp NotifHeaderComp;
        Username Username;
        VarTextLen VarTextLen;
        UserStatus UserStatus;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Heartbeat
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Heartbeat {
        MessageHeaderInComp MessageHeaderInComp;
    };


    /// <summary>
    ///  Struct for Heartbeat Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HeartbeatNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        NotifHeaderComp NotifHeaderComp;
    };


    /// <summary>
    ///  Struct for Inquire Enrichment Rule Id List Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireEnrichmentRuleIdListRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        LastEntityProcessed LastEntityProcessed;
    };


    /// <summary>
    ///  Struct for Inquire Enrichment Rule Id List Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireEnrichmentRuleIdListResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        LastEntityProcessed LastEntityProcessed;
        NoEnrichmentRules NoEnrichmentRules;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Inquire Mm Parameter Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireMmParameterRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
    };


    /// <summary>
    ///  Struct for Inquire Mm Parameter Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireMmParameterResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        MmParameterReportId MmParameterReportId;
        MarketSegmentId MarketSegmentId;
        NoMmParameters NoMmParameters;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Inquire Pre Trade Risk Limits Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquirePreTradeRiskLimitsRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        RiskLimitPlatform RiskLimitPlatform;
        PartyExecutingUnit PartyExecutingUnit;
        RiskLimitGroup RiskLimitGroup;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Inquire Session List Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireSessionListRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
    };


    /// <summary>
    ///  Struct for Inquire Session List Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireSessionListResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        NoSessions NoSessions;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Inquire User Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireUserRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        LastEntityProcessed LastEntityProcessed;
    };


    /// <summary>
    ///  Struct for Inquire User Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InquireUserResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        LastEntityProcessed LastEntityProcessed;
        NoPartyDetails NoPartyDetails;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Instrmnt Leg Exec Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrmntLegExecGrpComp {
        LegSecurityId LegSecurityId;
        LegLastPx LegLastPx;
        LegLastQty LegLastQty;
        LegExecId LegExecId;
        LegSide LegSide;
        FillRefId FillRefId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Instrmt Leg Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrmtLegGrpComp {
        LegSecurityId LegSecurityId;
        LegPrice LegPrice;
        LegSymbol LegSymbol;
        LegRatioQty LegRatioQty;
        LegSide LegSide;
        LegSecurityType LegSecurityType;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Instrmt Match Side Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrmtMatchSideGrpComp {
        SecurityId SecurityId;
        LastPx LastPx;
        TransBkdTime TransBkdTime;
        RelatedClosePrice RelatedClosePrice;
        PackageId PackageId;
        SideMarketSegmentId SideMarketSegmentId;
        NegotiationId NegotiationId;
        SrqsRelatedTradeId SrqsRelatedTradeId;
        SideTrdSubTyp SideTrdSubTyp;
        ProductComplex ProductComplex;
        TradePublishIndicator TradePublishIndicator;
        InstrmtMatchSideId InstrmtMatchSideId;
        EffectOnBasket EffectOnBasket;
        TradeReportText TradeReportText;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Instrument Attribute Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrumentAttributeGrpComp {
        InstrAttribType InstrAttribType;
        InstrAttribValue InstrAttribValue;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Instrument Event Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrumentEventGrpComp {
        EventDate EventDate;
        EventType EventType;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Leg Ord Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegOrdGrpComp {
        LegAccount LegAccount;
        LegPositionEffect LegPositionEffect;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Legal Notification Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegalNotificationBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
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
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
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
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
    };


    /// <summary>
    ///  Struct for Logout Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogoutResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
    };


    /// <summary>
    ///  Struct for Mass Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassQuoteRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        QuoteId QuoteId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        QuoteSizeType QuoteSizeType;
        QuoteType QuoteType;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        QuoteId QuoteId;
        QuoteResponseId QuoteResponseId;
        MarketSegmentId MarketSegmentId;
        NoQuoteSideEntries NoQuoteSideEntries;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Message Header In Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeaderInComp {
        BodyLen BodyLen;
        TemplateId TemplateId;
        NetworkMsgId NetworkMsgId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Message Header Out Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeaderOutComp {
        BodyLen BodyLen;
        TemplateId TemplateId;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Mm Parameter Definition Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmParameterDefinitionRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        ExposureDuration ExposureDuration;
        CumQty CumQty;
        Delta Delta;
        Vega Vega;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PctCount PctCount;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Mm Parameter Definition Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmParameterDefinitionResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        ExecId ExecId;
    };


    /// <summary>
    ///  Struct for Mm Parameter Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmParameterGrpComp {
        ExposureDuration ExposureDuration;
        CumQty CumQty;
        Delta Delta;
        Vega Vega;
        PctCount PctCount;
        TargetPartyIdSessionId TargetPartyIdSessionId;
    };


    /// <summary>
    ///  Struct for Modify Order Complex Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderComplexRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        Price Price;
        OrderQty OrderQty;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        ExpireDate ExpireDate;
        MatchInstCrossId MatchInstCrossId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        ProductComplex ProductComplex;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecInst ExecInst;
        TimeInForce TimeInForce;
        TradingCapacity TradingCapacity;
        OwnershipIndicator OwnershipIndicator;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        PartyIdPositionAccount PartyIdPositionAccount;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FixClOrdId FixClOrdId;
        NoLegs NoLegs;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Modify Order Complex Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderComplexShortRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        Price Price;
        OrderQty OrderQty;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        ApplSeqIndicator ApplSeqIndicator;
        ProductComplex ProductComplex;
        Side Side;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecInst ExecInst;
        TimeInForce TimeInForce;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Modify Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderNrResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
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
        CrossedIndicator CrossedIndicator;
        ProductComplex ProductComplex;
        Triggered Triggered;
        TransactionDelayIndicator TransactionDelayIndicator;
    };


    /// <summary>
    ///  Struct for Modify Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderMeComp ResponseHeaderMeComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CxlQty CxlQty;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        ProductComplex ProductComplex;
        Triggered Triggered;
        TransactionDelayIndicator TransactionDelayIndicator;
    };


    /// <summary>
    ///  Struct for Modify Order Single Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderSingleRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        Price Price;
        OrderQty OrderQty;
        StopPx StopPx;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        ExpireDate ExpireDate;
        MarketSegmentId MarketSegmentId;
        SimpleSecurityId SimpleSecurityId;
        MatchInstCrossId MatchInstCrossId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
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
        FixClOrdId FixClOrdId;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Modify Order Single Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderSingleShortRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        Price Price;
        OrderQty OrderQty;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        SimpleSecurityId SimpleSecurityId;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        Side Side;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ApplSeqIndicator ApplSeqIndicator;
        ExecInst ExecInst;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for New Order Complex Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderComplexRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        Price Price;
        OrderQty OrderQty;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        ExpireDate ExpireDate;
        MatchInstCrossId MatchInstCrossId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        ProductComplex ProductComplex;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        ExecInst ExecInst;
        TimeInForce TimeInForce;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdPositionAccount PartyIdPositionAccount;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FixClOrdId FixClOrdId;
        NoLegs NoLegs;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for New Order Complex Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderComplexShortRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        SecurityId SecurityId;
        Price Price;
        OrderQty OrderQty;
        ClOrdId ClOrdId;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        ApplSeqIndicator ApplSeqIndicator;
        ProductComplex ProductComplex;
        Side Side;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecInst ExecInst;
        TimeInForce TimeInForce;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for New Order Nr Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderNrResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        ProductComplex ProductComplex;
        Triggered Triggered;
        TransactionDelayIndicator TransactionDelayIndicator;
    };


    /// <summary>
    ///  Struct for New Order Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderMeComp ResponseHeaderMeComp;
        OrderId OrderId;
        ClOrdId ClOrdId;
        SecurityId SecurityId;
        ExecId ExecId;
        TrdRegTsEntryTime TrdRegTsEntryTime;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        OrdStatus OrdStatus;
        ExecType ExecType;
        ExecRestatementReason ExecRestatementReason;
        CrossedIndicator CrossedIndicator;
        ProductComplex ProductComplex;
        Triggered Triggered;
        TransactionDelayIndicator TransactionDelayIndicator;
    };


    /// <summary>
    ///  Struct for New Order Single Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingleRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        Price Price;
        OrderQty OrderQty;
        StopPx StopPx;
        ClOrdId ClOrdId;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        ExpireDate ExpireDate;
        MarketSegmentId MarketSegmentId;
        SimpleSecurityId SimpleSecurityId;
        MatchInstCrossId MatchInstCrossId;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        ApplSeqIndicator ApplSeqIndicator;
        Side Side;
        OrdType OrdType;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingSessionSubId TradingSessionSubId;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Account Account;
        PartyIdPositionAccount PartyIdPositionAccount;
        PositionEffect PositionEffect;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FixClOrdId FixClOrdId;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for New Order Single Short Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingleShortRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        Price Price;
        OrderQty OrderQty;
        ClOrdId ClOrdId;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        SimpleSecurityId SimpleSecurityId;
        MatchInstCrossId MatchInstCrossId;
        EnrichmentRuleId EnrichmentRuleId;
        Side Side;
        ApplSeqIndicator ApplSeqIndicator;
        PriceValidityCheckType PriceValidityCheckType;
        ValueCheckTypeValue ValueCheckTypeValue;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        TimeInForce TimeInForce;
        ExecInst ExecInst;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for News Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewsBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        OrigTime OrigTime;
        VarTextLen VarTextLen;
        Headline Headline;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Not Affected Orders Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotAffectedOrdersGrpComp {
        NotAffectedOrderId NotAffectedOrderId;
        NotAffOrigClOrdId NotAffOrigClOrdId;
    };


    /// <summary>
    ///  Struct for Not Affected Securities Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotAffectedSecuritiesGrpComp {
        NotAffectedSecurityId NotAffectedSecurityId;
    };


    /// <summary>
    ///  Struct for Notif Header Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NotifHeaderComp {
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Nr Response Header Me Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NrResponseHeaderMeComp {
        RequestTime RequestTime;
        TrdRegTsTimeIn TrdRegTsTimeIn;
        TrdRegTsTimeOut TrdRegTsTimeOut;
        ResponseIn ResponseIn;
        SendingTime SendingTime;
        MsgSeqNum MsgSeqNum;
        LastFragment LastFragment;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Nrbc Header Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NrbcHeaderComp {
        SendingTime SendingTime;
        ApplSubId ApplSubId;
        ApplId ApplId;
        LastFragment LastFragment;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Order Book Item Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderBookItemGrpComp {
        SecurityId SecurityId;
        BestBidPx BestBidPx;
        BestBidSize BestBidSize;
        BestOfferPx BestOfferPx;
        BestOfferSize BestOfferSize;
        MdBookType MdBookType;
        MdSubBookType MdSubBookType;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Party Action Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyActionReport {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
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
    ///  Struct for Party Details Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartyDetailsGrpComp {
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
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
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
    ///  Struct for Pre Trade Risk Limit Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PreTradeRiskLimitResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        RiskLimitReportId RiskLimitReportId;
        MarketSegmentId MarketSegmentId;
        NoRiskLimits NoRiskLimits;
        PartyDetailStatus PartyDetailStatus;
        RiskLimitPlatform RiskLimitPlatform;
        PartyDetailExecutingUnit PartyDetailExecutingUnit;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Pre Trade Risk Limits Definition Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PreTradeRiskLimitsDefinitionRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        RiskLimitPlatform RiskLimitPlatform;
        NoRiskLimitsQty NoRiskLimitsQty;
        PartyDetailStatus PartyDetailStatus;
        RiskLimitGroup RiskLimitGroup;
        PartyDetailExecutingUnit PartyDetailExecutingUnit;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Quot Req Legs Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuotReqLegsGrpComp {
        LegSecurityId LegSecurityId;
        LegRatioQty LegRatioQty;
        LegSymbol LegSymbol;
        LegSecurityType LegSecurityType;
        LegSide LegSide;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Quote Activation Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderMeComp RbcHeaderMeComp;
        MassActionReportId MassActionReportId;
        MarketSegmentId MarketSegmentId;
        PartyIdEnteringTrader PartyIdEnteringTrader;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        PartyIdEnteringFirm PartyIdEnteringFirm;
        MassActionType MassActionType;
        MassActionSubType MassActionSubType;
        MassActionReason MassActionReason;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Quote Activation Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        TargetPartyIdSessionId TargetPartyIdSessionId;
        MassActionType MassActionType;
        MassActionSubType MassActionSubType;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Quote Activation Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteActivationResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        MassActionReportId MassActionReportId;
        NoNotAffectedSecurities NoNotAffectedSecurities;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Quote Entry Ack Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteEntryAckGrpComp {
        SecurityId SecurityId;
        CxlSize CxlSize;
        QuoteEntryRejectReason QuoteEntryRejectReason;
        QuoteEntryStatus QuoteEntryStatus;
        Side Side;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Quote Entry Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteEntryGrpComp {
        SecurityId SecurityId;
        BidPx BidPx;
        BidSize BidSize;
        OfferPx OfferPx;
        OfferSize OfferSize;
    };


    /// <summary>
    ///  Struct for Quote Event Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteEventGrpComp {
        SecurityId SecurityId;
        QuoteEventPx QuoteEventPx;
        QuoteEventQty QuoteEventQty;
        QuoteMsgId QuoteMsgId;
        QuoteEventMatchId QuoteEventMatchId;
        QuoteEventExecId QuoteEventExecId;
        QuoteEventType QuoteEventType;
        QuoteEventSide QuoteEventSide;
        QuoteEventLiquidityInd QuoteEventLiquidityInd;
        QuoteEventReason QuoteEventReason;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Quote Leg Exec Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteLegExecGrpComp {
        LegSecurityId LegSecurityId;
        LegLastPx LegLastPx;
        LegLastQty LegLastQty;
        LegExecId LegExecId;
        LegSide LegSide;
        NoQuoteEventsIndex NoQuoteEventsIndex;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Rbc Header Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RbcHeaderComp {
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
    ///  Struct for Rbc Header Me Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RbcHeaderMeComp {
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
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        SessionRejectReason SessionRejectReason;
        VarTextLen VarTextLen;
        SessionStatus SessionStatus;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Request Header Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestHeaderComp {
        MsgSeqNum MsgSeqNum;
        SenderSubId SenderSubId;
    };


    /// <summary>
    ///  Struct for Response Header Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResponseHeaderComp {
        RequestTime RequestTime;
        SendingTime SendingTime;
        MsgSeqNum MsgSeqNum;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Response Header Me Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResponseHeaderMeComp {
        RequestTime RequestTime;
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
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
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
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        ApplEndSeqNum ApplEndSeqNum;
        RefApplLastSeqNum RefApplLastSeqNum;
        ApplTotalMessageCount ApplTotalMessageCount;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Reverse Tes Trade Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReverseTesTradeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        PackageId PackageId;
        TesExecId TesExecId;
        RelatedMarketSegmentId RelatedMarketSegmentId;
        TrdType TrdType;
        TradeReportId TradeReportId;
        ReversalReasonText ReversalReasonText;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Rfq Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        SecurityId SecurityId;
        OrderQty OrderQty;
        MarketSegmentId MarketSegmentId;
        Side Side;
        ComplianceText ComplianceText;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Rfq Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrResponseHeaderMeComp NrResponseHeaderMeComp;
        ExecId ExecId;
    };


    /// <summary>
    ///  Struct for Risk Limit Qty Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskLimitQtyGrpComp {
        RiskLimitQty RiskLimitQty;
        RiskLimitType RiskLimitType;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Risk Limits Rpt Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskLimitsRptGrpComp {
        RiskLimitQty RiskLimitQty;
        RiskLimitOpenQty RiskLimitOpenQty;
        RiskLimitNetPositionQty RiskLimitNetPositionQty;
        RiskLimitType RiskLimitType;
        RiskLimitRequestingPartyRole RiskLimitRequestingPartyRole;
        RiskLimitViolationIndicator RiskLimitViolationIndicator;
        RiskLimitGroup RiskLimitGroup;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Risk Notification Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskNotificationBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
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
        MessageHeaderOutComp MessageHeaderOutComp;
        NrbcHeaderComp NrbcHeaderComp;
        MatchingEngineTradeDate MatchingEngineTradeDate;
        TradeManagerTradeDate TradeManagerTradeDate;
        ApplSeqTradeDate ApplSeqTradeDate;
        T7EntryServiceTradeDate T7EntryServiceTradeDate;
        T7EntryServiceRtmTradeDate T7EntryServiceRtmTradeDate;
        PartitionId PartitionId;
        MatchingEngineStatus MatchingEngineStatus;
        TradeManagerStatus TradeManagerStatus;
        ApplSeqStatus ApplSeqStatus;
        T7EntryServiceStatus T7EntryServiceStatus;
        T7EntryServiceRtmStatus T7EntryServiceRtmStatus;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Service Availability Market Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ServiceAvailabilityMarketBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        NrbcHeaderComp NrbcHeaderComp;
        SelectiveRequestForQuoteServiceTradeDate SelectiveRequestForQuoteServiceTradeDate;
        SelectiveRequestForQuoteServiceStatus SelectiveRequestForQuoteServiceStatus;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Sessions Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SessionsGrpComp {
        PartyIdSessionId PartyIdSessionId;
        SessionMode SessionMode;
        SessionSubMode SessionSubMode;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Side Alloc Ext Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SideAllocExtGrpComp {
        AllocQty AllocQty;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        IndividualAllocId IndividualAllocId;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Pad1 Pad1;
        TesEnrichmentRuleId TesEnrichmentRuleId;
        Side Side;
        TradeAllocStatus TradeAllocStatus;
        TradingCapacity TradingCapacity;
        PositionEffect PositionEffect;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        OrderOrigination OrderOrigination;
        Account Account;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdBeneficiary PartyIdBeneficiary;
        PartyIdLocationId PartyIdLocationId;
        CustOrderHandlingInst CustOrderHandlingInst;
        ComplianceText ComplianceText;
        Pad11 Pad11;
    };


    /// <summary>
    ///  Struct for Side Alloc Grp Bc Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SideAllocGrpBcComp {
        AllocQty AllocQty;
        ReversalApprovalTime ReversalApprovalTime;
        IndividualAllocId IndividualAllocId;
        TesEnrichmentRuleId TesEnrichmentRuleId;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Side Side;
        TradeAllocStatus TradeAllocStatus;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Side Alloc Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SideAllocGrpComp {
        AllocQty AllocQty;
        IndividualAllocId IndividualAllocId;
        TesEnrichmentRuleId TesEnrichmentRuleId;
        Side Side;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Side Cross Leg Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SideCrossLegGrpComp {
        LegInputSource LegInputSource;
        LegPositionEffect LegPositionEffect;
        LegAccount LegAccount;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Smart Party Detail Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SmartPartyDetailGrpComp {
        PartyDetailExecutingUnit PartyDetailExecutingUnit;
        PartyDetailExecutingTrader PartyDetailExecutingTrader;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Srqs Create Deal Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsCreateDealNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        LastPx LastPx;
        LastQty LastQty;
        QuoteId QuoteId;
        SecurityId SecurityId;
        ExpireTime ExpireTime;
        UnderlyingPx UnderlyingPx;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        UnderlyingEffectiveDeltaPercentage UnderlyingEffectiveDeltaPercentage;
        UnderlyingQty UnderlyingQty;
        UnderlyingPriceStipValue UnderlyingPriceStipValue;
        NegotiationId NegotiationId;
        TradeId TradeId;
        OrigTradeId OrigTradeId;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        TrdRptStatus TrdRptStatus;
        TradeReportType TradeReportType;
        MessageEventSource MessageEventSource;
        Side Side;
        NoOrderBookItems NoOrderBookItems;
        TradingCapacity TradingCapacity;
        TradePublishIndicator TradePublishIndicator;
        HedgingInstruction HedgingInstruction;
        RootPartyExecutingFirm RootPartyExecutingFirm;
        RootPartyExecutingTrader RootPartyExecutingTrader;
        RootPartyEnteringTrader RootPartyEnteringTrader;
        TargetPartyExecutingFirm TargetPartyExecutingFirm;
        TargetPartyExecutingTrader TargetPartyExecutingTrader;
        FirmTradeId FirmTradeId;
        FirmNegotiationId FirmNegotiationId;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FreeText5 FreeText5;
        PositionEffect PositionEffect;
        Account Account;
        PartyIdBeneficiary PartyIdBeneficiary;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Srqs Deal Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsDealNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        UnderlyingPriceStipValue UnderlyingPriceStipValue;
        UnderlyingPx UnderlyingPx;
        LastPx LastPx;
        LastQty LastQty;
        NegotiationId NegotiationId;
        TradeId TradeId;
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        RequestingPartySubIdType RequestingPartySubIdType;
        TrdRptStatus TrdRptStatus;
        TradeRequestResult TradeRequestResult;
        MessageEventSource MessageEventSource;
        TradingCapacity TradingCapacity;
        RootPartyExecutingFirm RootPartyExecutingFirm;
        RootPartyExecutingTrader RootPartyExecutingTrader;
        RootPartyEnteringTrader RootPartyEnteringTrader;
        TargetPartyExecutingFirm TargetPartyExecutingFirm;
        TargetPartyExecutingTrader TargetPartyExecutingTrader;
        TargetPartyEnteringTrader TargetPartyEnteringTrader;
        FirmTradeId FirmTradeId;
        FirmNegotiationId FirmNegotiationId;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FreeText5 FreeText5;
        PositionEffect PositionEffect;
        Account Account;
        PartyIdBeneficiary PartyIdBeneficiary;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Srqs Deal Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsDealResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        SecurityId SecurityId;
        QuoteId QuoteId;
        NegotiationId NegotiationId;
        TradeId TradeId;
        SecondaryTradeId SecondaryTradeId;
        FirmTradeId FirmTradeId;
        FirmNegotiationId FirmNegotiationId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Srqs Enter Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsEnterQuoteRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        BidPx BidPx;
        OfferPx OfferPx;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        BidSize BidSize;
        OfferSize OfferSize;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        QuoteRefPrice QuoteRefPrice;
        MarketSegmentId MarketSegmentId;
        NegotiationId NegotiationId;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        TradingCapacity TradingCapacity;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FreeText5 FreeText5;
        PositionEffect PositionEffect;
        Account Account;
        PartyIdBeneficiary PartyIdBeneficiary;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Srqs Hit Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsHitQuoteRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        QuoteId QuoteId;
        OrderQty OrderQty;
        ValidUntilTime ValidUntilTime;
        UnderlyingQty UnderlyingQty;
        UnderlyingPriceStipValue UnderlyingPriceStipValue;
        PartyIdClientId PartyIdClientId;
        PartyIdInvestmentDecisionMaker PartyIdInvestmentDecisionMaker;
        ExecutingTrader ExecutingTrader;
        MarketSegmentId MarketSegmentId;
        NegotiationId NegotiationId;
        Side Side;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        PartyIdInvestmentDecisionMakerQualifier PartyIdInvestmentDecisionMakerQualifier;
        TradingCapacity TradingCapacity;
        TradePublishIndicator TradePublishIndicator;
        OrderOrigination OrderOrigination;
        HedgingInstruction HedgingInstruction;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        FirmTradeId FirmTradeId;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FreeText5 FreeText5;
        PositionEffect PositionEffect;
        Account Account;
        PartyIdBeneficiary PartyIdBeneficiary;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Srqs Inquire Smart Respondent Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsInquireSmartRespondentRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        EurexVolumeRanking EurexVolumeRanking;
        EnlightRfqAvgRespTimeRanking EnlightRfqAvgRespTimeRanking;
        EnlightRfqAvgRespRateRanking EnlightRfqAvgRespRateRanking;
        TradeToQuoteRatioRanking TradeToQuoteRatioRanking;
    };


    /// <summary>
    ///  Struct for Srqs Inquire Smart Respondent Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsInquireSmartRespondentResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        MarketSegmentId MarketSegmentId;
        NoPartyDetails NoPartyDetails;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Srqs Negotiation Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsNegotiationNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        QuoteRefPrice QuoteRefPrice;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        BidPx BidPx;
        OfferPx OfferPx;
        LastPx LastPx;
        LeavesQty LeavesQty;
        LastQty LastQty;
        EffectiveTime EffectiveTime;
        LastUpdateTime LastUpdateTime;
        NegotiationId NegotiationId;
        NumberOfRespondents NumberOfRespondents;
        QuoteType QuoteType;
        QuoteSubType QuoteSubType;
        QuoteStatus QuoteStatus;
        QuoteInstruction QuoteInstruction;
        Side Side;
        QuoteRefPriceSource QuoteRefPriceSource;
        ShowLastDealOnClosure ShowLastDealOnClosure;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        PartyEnteringTrader PartyEnteringTrader;
        TargetPartyExecutingFirm TargetPartyExecutingFirm;
        TargetPartyExecutingTrader TargetPartyExecutingTrader;
        FirmNegotiationId FirmNegotiationId;
        FreeText5 FreeText5;
        PartyOrderOriginationTrader PartyOrderOriginationTrader;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Srqs Negotiation Requester Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsNegotiationRequesterNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        TrdRegTsExecutionTime TrdRegTsExecutionTime;
        QuoteRefPrice QuoteRefPrice;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        BidPx BidPx;
        OfferPx OfferPx;
        OrderQty OrderQty;
        LastPx LastPx;
        LeavesQty LeavesQty;
        LastQty LastQty;
        EffectiveTime EffectiveTime;
        LastUpdateTime LastUpdateTime;
        NegotiationId NegotiationId;
        NumberOfRespondents NumberOfRespondents;
        QuoteType QuoteType;
        QuoteSubType QuoteSubType;
        QuoteStatus QuoteStatus;
        NoTargetPartyIDs NoTargetPartyIDs;
        NumberOfRespDisclosureInstruction NumberOfRespDisclosureInstruction;
        Side Side;
        QuoteRefPriceSource QuoteRefPriceSource;
        ShowLastDealOnClosure ShowLastDealOnClosure;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        PartyEnteringTrader PartyEnteringTrader;
        FirmNegotiationId FirmNegotiationId;
        FreeText5 FreeText5;
        PartyOrderOriginationTrader PartyOrderOriginationTrader;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Srqs Negotiation Status Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsNegotiationStatusNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        EffectiveTime EffectiveTime;
        NegotiationId NegotiationId;
        QuoteStatus QuoteStatus;
        FirmNegotiationId FirmNegotiationId;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Srqs Open Negotiation Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsOpenNegotiationNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        NegotiationStartTime NegotiationStartTime;
        SecurityId SecurityId;
        BidPx BidPx;
        OfferPx OfferPx;
        LeavesQty LeavesQty;
        LastQty LastQty;
        LastPx LastPx;
        QuoteRefPrice QuoteRefPrice;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        ExpireTime ExpireTime;
        TradeToRequestRatio TradeToRequestRatio;
        NegotiationId NegotiationId;
        MarketSegmentId MarketSegmentId;
        SecuritySubType SecuritySubType;
        NumberOfRespondents NumberOfRespondents;
        QuoteType QuoteType;
        QuoteSubType QuoteSubType;
        QuoteStatus QuoteStatus;
        NoLegs NoLegs;
        Side Side;
        QuoteRefPriceSource QuoteRefPriceSource;
        TradeUnderlying TradeUnderlying;
        ProductComplex ProductComplex;
        NegotiateUnderlying NegotiateUnderlying;
        RespondentType RespondentType;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        PartyEnteringTrader PartyEnteringTrader;
        TargetPartyExecutingFirm TargetPartyExecutingFirm;
        TargetPartyExecutingTrader TargetPartyExecutingTrader;
        FirmNegotiationId FirmNegotiationId;
        FreeText5 FreeText5;
        PartyOrderOriginationTrader PartyOrderOriginationTrader;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Srqs Quote Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsQuoteNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        QuoteId QuoteId;
        SecondaryQuoteId SecondaryQuoteId;
        BidPx BidPx;
        BidSize BidSize;
        OfferPx OfferPx;
        OfferSize OfferSize;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        QuoteRefPrice QuoteRefPrice;
        NegotiationId NegotiationId;
        QuotingStatus QuotingStatus;
        TradingCapacity TradingCapacity;
        Pad2 Pad2;
        PartyIdExecutingTrader PartyIdExecutingTrader;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        PartyEnteringTrader PartyEnteringTrader;
        QuoteReqId QuoteReqId;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        FreeText5 FreeText5;
        PositionEffect PositionEffect;
        Account Account;
        PartyIdBeneficiary PartyIdBeneficiary;
        CustOrderHandlingInst CustOrderHandlingInst;
        PartyIdOrderOriginationFirm PartyIdOrderOriginationFirm;
        PartyIdPositionAccount PartyIdPositionAccount;
        PartyIdLocationId PartyIdLocationId;
        ComplianceText ComplianceText;
        PartyIdTakeUpTradingFirm PartyIdTakeUpTradingFirm;
    };


    /// <summary>
    ///  Struct for Srqs Quote Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsQuoteResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        QuoteId QuoteId;
        NegotiationId NegotiationId;
        QuoteReqId QuoteReqId;
    };


    /// <summary>
    ///  Struct for Srqs Quoting Status Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsQuotingStatusRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        MarketSegmentId MarketSegmentId;
        NegotiationId NegotiationId;
        QuotingStatus QuotingStatus;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        FreeText5 FreeText5;
    };


    /// <summary>
    ///  Struct for Srqs Related Trade Id Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsRelatedTradeIdGrpComp {
        SrqsRelatedTradeId SrqsRelatedTradeId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Srqs Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsStatusBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TradeDate TradeDate;
        TradSesEvent TradSesEvent;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Srqs Update Deal Status Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsUpdateDealStatusRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        UnderlyingPriceStipValue UnderlyingPriceStipValue;
        UnderlyingPx UnderlyingPx;
        LastQty LastQty;
        MarketSegmentId MarketSegmentId;
        NegotiationId NegotiationId;
        TradeId TradeId;
        TradeReportType TradeReportType;
        TrdRptStatus TrdRptStatus;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        FreeText5 FreeText5;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Srqs Update Negotiation Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SrqsUpdateNegotiationRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        QuoteRefPrice QuoteRefPrice;
        UnderlyingDeltaPercentage UnderlyingDeltaPercentage;
        BidPx BidPx;
        OfferPx OfferPx;
        OrderQty OrderQty;
        MarketSegmentId MarketSegmentId;
        NegotiationId NegotiationId;
        NoTargetPartyIDs NoTargetPartyIDs;
        NumberOfRespDisclosureInstruction NumberOfRespDisclosureInstruction;
        Side Side;
        QuoteCancelType QuoteCancelType;
        QuoteRefPriceSource QuoteRefPriceSource;
        ShowLastDealOnClosure ShowLastDealOnClosure;
        PartyExecutingFirm PartyExecutingFirm;
        PartyExecutingTrader PartyExecutingTrader;
        FreeText5 FreeText5;
        PartyOrderOriginationTrader PartyOrderOriginationTrader;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Subscribe Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SubscribeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        SubscriptionScope SubscriptionScope;
        RefApplId RefApplId;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Subscribe Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SubscribeResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        ApplSubId ApplSubId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Target Parties Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TargetPartiesComp {
        TargetPartyIdExecutingTrader TargetPartyIdExecutingTrader;
        SideDisclosureInstruction SideDisclosureInstruction;
        PriceDisclosureInstruction PriceDisclosureInstruction;
        LeavesQtyDisclosureInstruction LeavesQtyDisclosureInstruction;
        LastPxDisclosureInstruction LastPxDisclosureInstruction;
        LastQtyDisclosureInstruction LastQtyDisclosureInstruction;
        FreeText5DisclosureInstruction FreeText5DisclosureInstruction;
        PartyOrderOriginationDisclosureInstruction PartyOrderOriginationDisclosureInstruction;
        QuoteInstruction QuoteInstruction;
        TargetPartyExecutingFirm TargetPartyExecutingFirm;
        TargetPartyExecutingTrader TargetPartyExecutingTrader;
        PartyDetailStatus PartyDetailStatus;
        PartyDetailStatusInformation PartyDetailStatusInformation;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Tes Compression Run Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesCompressionRunStatusBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        CompressionId CompressionId;
        MarketSegmentId MarketSegmentId;
        CompressionAction CompressionAction;
        CompressionStatus CompressionStatus;
        TradePublishIndicator TradePublishIndicator;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Tes Compression Run Status Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesCompressionRunStatusRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        CompressionId CompressionId;
        MarketSegmentId MarketSegmentId;
        CompressionAction CompressionAction;
        TradePublishIndicator TradePublishIndicator;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Tes Compression Run Status Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesCompressionRunStatusResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        CompressionId CompressionId;
        MarketSegmentId MarketSegmentId;
        CompressionAction CompressionAction;
        CompressionStatus CompressionStatus;
        TradePublishIndicator TradePublishIndicator;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Tes Delete Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesDeleteBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        CompressionId CompressionId;
        MarketSegmentId MarketSegmentId;
        PackageId PackageId;
        TesExecId TesExecId;
        TrdType TrdType;
        DeleteReason DeleteReason;
        TradeReportType TradeReportType;
        MessageEventSource MessageEventSource;
        TradeReportId TradeReportId;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Tes Execution Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesExecutionBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TransactTime TransactTime;
        CompressionId CompressionId;
        MarketSegmentId MarketSegmentId;
        PackageId PackageId;
        TesExecId TesExecId;
        AllocId AllocId;
        TrdType TrdType;
        TradeReportType TradeReportType;
        Side Side;
        MessageEventSource MessageEventSource;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Tes Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
        TesExecId TesExecId;
        TradeReportId TradeReportId;
    };


    /// <summary>
    ///  Struct for Tes Reversal Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesReversalBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        ReversalInitiationTime ReversalInitiationTime;
        MarketSegmentId MarketSegmentId;
        PackageId PackageId;
        TesExecId TesExecId;
        TrdType TrdType;
        ReversalCancellationReason ReversalCancellationReason;
        NoSideAllocs NoSideAllocs;
        TradeReportId TradeReportId;
        ReversalReasonText ReversalReasonText;
    };


    /// <summary>
    ///  Struct for Tes Trade Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesTradeBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        SecurityId SecurityId;
        LastPx LastPx;
        LastQty LastQty;
        ClearingTradePrice ClearingTradePrice;
        ClearingTradeQty ClearingTradeQty;
        TransactTime TransactTime;
        RelatedSecurityId RelatedSecurityId;
        CompressionId CompressionId;
        RootPartyIdClientId RootPartyIdClientId;
        ExecutingTrader ExecutingTrader;
        RootPartyIdInvestmentDecisionMaker RootPartyIdInvestmentDecisionMaker;
        BasketTrdMatchId BasketTrdMatchId;
        SideLastPx SideLastPx;
        SideLastQty SideLastQty;
        PackageId PackageId;
        MarketSegmentId MarketSegmentId;
        TradeId TradeId;
        TradeDate TradeDate;
        SideTradeId SideTradeId;
        RootPartyIdSessionId RootPartyIdSessionId;
        OrigTradeId OrigTradeId;
        RootPartyIdExecutingUnit RootPartyIdExecutingUnit;
        RootPartyIdExecutingTrader RootPartyIdExecutingTrader;
        RootPartyIdClearingUnit RootPartyIdClearingUnit;
        StrategyLinkId StrategyLinkId;
        RelatedSymbol RelatedSymbol;
        TotNumTradeReports TotNumTradeReports;
        NegotiationId NegotiationId;
        NoSrqsRelatedTradeIDs NoSrqsRelatedTradeIDs;
        Pad31 Pad31;
        BasketProfileId BasketProfileId;
        TrdType TrdType;
        ProductComplex ProductComplex;
        RelatedProductComplex RelatedProductComplex;
        Side Side;
        TradingCapacity TradingCapacity;
        TradeReportType TradeReportType;
        TransferReason TransferReason;
        TradePublishIndicator TradePublishIndicator;
        MultiLegReportingType MultiLegReportingType;
        PositionEffect PositionEffect;
        MultilegPriceModel MultilegPriceModel;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        RootPartyIdInvestmentDecisionMakerQualifier RootPartyIdInvestmentDecisionMakerQualifier;
        OrderOrigination OrderOrigination;
        ReversalIndicator ReversalIndicator;
        Account Account;
        RootPartyIdPositionAccount RootPartyIdPositionAccount;
        CustOrderHandlingInst CustOrderHandlingInst;
        FreeText1 FreeText1;
        FreeText2 FreeText2;
        FreeText3 FreeText3;
        RootPartyExecutingFirm RootPartyExecutingFirm;
        RootPartyExecutingTrader RootPartyExecutingTrader;
        RootPartyClearingFirm RootPartyClearingFirm;
        RootPartyClearingOrganization RootPartyClearingOrganization;
        RootPartyIdBeneficiary RootPartyIdBeneficiary;
        RootPartyIdTakeUpTradingFirm RootPartyIdTakeUpTradingFirm;
        RootPartyIdOrderOriginationFirm RootPartyIdOrderOriginationFirm;
        RootPartyIdExecutionVenue RootPartyIdExecutionVenue;
        RegulatoryTradeId RegulatoryTradeId;
        BasketPartyContraFirm BasketPartyContraFirm;
        BasketSideTradeReportId BasketSideTradeReportId;
        Pad5 Pad5;
    };


    /// <summary>
    ///  Struct for Tes Trading Session Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TesTradingSessionStatusBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TradeDate TradeDate;
        TradSesEvent TradSesEvent;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Throttle Update Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ThrottleUpdateNotification {
        MessageHeaderOutComp MessageHeaderOutComp;
        NotifHeaderComp NotifHeaderComp;
        ThrottleTimeInterval ThrottleTimeInterval;
        ThrottleNoMsgs ThrottleNoMsgs;
        ThrottleDisconnectLimit ThrottleDisconnectLimit;
    };


    /// <summary>
    ///  Struct for Tm Trading Session Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TmTradingSessionStatusBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        TradSesEvent TradSesEvent;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Trade Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderComp RbcHeaderComp;
        SecurityId SecurityId;
        RelatedSecurityId RelatedSecurityId;
        Price Price;
        LastPx LastPx;
        LastQty LastQty;
        SideLastPx SideLastPx;
        SideLastQty SideLastQty;
        ClearingTradePrice ClearingTradePrice;
        ClearingTradeQty ClearingTradeQty;
        TransactTime TransactTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        LeavesQty LeavesQty;
        CumQty CumQty;
        RootPartyIdClientId RootPartyIdClientId;
        ExecutingTrader ExecutingTrader;
        RootPartyIdInvestmentDecisionMaker RootPartyIdInvestmentDecisionMaker;
        TradeId TradeId;
        OrigTradeId OrigTradeId;
        RootPartyIdExecutingUnit RootPartyIdExecutingUnit;
        RootPartyIdSessionId RootPartyIdSessionId;
        RootPartyIdExecutingTrader RootPartyIdExecutingTrader;
        RootPartyIdClearingUnit RootPartyIdClearingUnit;
        MarketSegmentId MarketSegmentId;
        RelatedSymbol RelatedSymbol;
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
        SideLiquidityInd SideLiquidityInd;
        TradingCapacity TradingCapacity;
        OrderOrigination OrderOrigination;
        OrderAttributeLiquidityProvision OrderAttributeLiquidityProvision;
        OrderAttributeRiskReduction OrderAttributeRiskReduction;
        ExecutingTraderQualifier ExecutingTraderQualifier;
        RootPartyIdInvestmentDecisionMakerQualifier RootPartyIdInvestmentDecisionMakerQualifier;
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
        RegulatoryTradeId RegulatoryTradeId;
        RootPartyIdExecutionVenue RootPartyIdExecutionVenue;
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Trading Session Status Broadcast
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingSessionStatusBroadcast {
        MessageHeaderOutComp MessageHeaderOutComp;
        RbcHeaderMeComp RbcHeaderMeComp;
        MarketSegmentId MarketSegmentId;
        TradeDate TradeDate;
        TradSesEvent TradSesEvent;
        RefApplLastMsgId RefApplLastMsgId;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Trd Instrmnt Leg Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TrdInstrmntLegGrpComp {
        LegSecurityId LegSecurityId;
        LegPrice LegPrice;
        LegQty LegQty;
    };


    /// <summary>
    ///  Struct for Underlying Stip Grp Comp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingStipGrpComp {
        UnderlyingStipValue UnderlyingStipValue;
        UnderlyingStipType UnderlyingStipType;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Unsubscribe Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnsubscribeRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        RefApplSubId RefApplSubId;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Unsubscribe Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnsubscribeResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
    };


    /// <summary>
    ///  Struct for User Login Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLoginRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        Username Username;
        Password Password;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for User Login Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLoginResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
    };


    /// <summary>
    ///  Struct for User Logout Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLogoutRequest {
        MessageHeaderInComp MessageHeaderInComp;
        RequestHeaderComp RequestHeaderComp;
        Username Username;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for User Logout Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserLogoutResponse {
        MessageHeaderOutComp MessageHeaderOutComp;
        ResponseHeaderComp ResponseHeaderComp;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
