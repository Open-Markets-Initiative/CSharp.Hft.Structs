namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Aggressor Side Values
    /// </summary>
    public enum AggressorSide : byte {
        Buy = "1",
        Sell = "2",
        AggressorSide = "2",
        AggressorSide = "1",
    };


    /// <summary>
    ///  Aggressor Time
    /// </summary>
    public struct AggressorTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Algorithmic Trade Indicator Values
    /// </summary>
    public enum AlgorithmicTradeIndicator : byte {
        AlgorithmicTrade = "1",
        AlgorithmicTradeIndicator = "1",
        AlgorithmicTradeIndicator = "1",
    };


    /// <summary>
    ///  Application Sequence Number
    /// </summary>
    public struct ApplicationSequenceNumber {
        public uint Raw;
    };


    /// <summary>
    ///  Application Sequence Reset Indicator Values
    /// </summary>
    public enum ApplicationSequenceResetIndicator : byte {
        NoReset = "0",
        Reset = "1",
        ApplSeqResetIndicator = "1",
        ApplSeqResetIndicator = "0",
    };


    /// <summary>
    ///  Bid Px
    /// </summary>
    public struct BidPx {
        public ulong Raw;
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public struct BidSize {
        public ulong Raw;
    };


    /// <summary>
    ///  Body Len
    /// </summary>
    public struct BodyLen {
        public ushort Raw;
    };


    /// <summary>
    ///  Completion Indicator Values
    /// </summary>
    public enum CompletionIndicator : byte {
        Incomplete = "0",
        Complete = "1",
        CompletionIndicator = "1",
        CompletionIndicator = "0",
    };


    /// <summary>
    ///  Cross Request Type Values
    /// </summary>
    public enum CrossRequestType : byte {
        CrossAnnouncement = "1",
        LiquidityImprovementCross = "2",
        CrossRequestType = "2",
        CrossRequestType = "1",
    };


    /// <summary>
    ///  Display Qty
    /// </summary>
    public struct DisplayQty {
        public ulong Raw;
    };


    /// <summary>
    ///  Exec Id
    /// </summary>
    public struct ExecId {
        public ulong Raw;
    };


    /// <summary>
    ///  Fast Market Indicator Values
    /// </summary>
    public enum FastMarketIndicator : byte {
        No = "0",
        Yes = "1",
        FastMarketIndicator = "1",
        FastMarketIndicator = "0",
    };


    /// <summary>
    ///  Header Length
    /// </summary>
    public struct HeaderLength {
        public ushort Raw;
    };


    /// <summary>
    ///  Imbalance Qty
    /// </summary>
    public struct ImbalanceQty {
        public ulong Raw;
    };


    /// <summary>
    ///  Implied Market Indicator Values
    /// </summary>
    public enum ImpliedMarketIndicator : byte {
        NotImplied = "0",
        ImpliedInOut = "3",
        ImpliedMarketIndicator = "3",
        ImpliedMarketIndicator = "0",
    };


    /// <summary>
    ///  Input Source Values
    /// </summary>
    public enum InputSource : byte {
        ClipClientBroker = "1",
        InputSource = "1",
        InputSource = "1",
    };


    /// <summary>
    ///  Last Msg Seq Num Processed
    /// </summary>
    public struct LastMsgSeqNumProcessed {
        public uint Raw;
    };


    /// <summary>
    ///  Last Px
    /// </summary>
    public struct LastPx {
        public ulong Raw;
    };


    /// <summary>
    ///  Last Qty
    /// </summary>
    public struct LastQty {
        public ulong Raw;
    };


    /// <summary>
    ///  Last Update Time
    /// </summary>
    public struct LastUpdateTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public struct LegRatioQty {
        public int Raw;
    };


    /// <summary>
    ///  Leg Security Id
    /// </summary>
    public struct LegSecurityId {
        public long Raw;
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        Buy = "1",
        Sell = "2",
        LegSide = "2",
        LegSide = "1",
    };


    /// <summary>
    ///  Leg Symbol
    /// </summary>
    public struct LegSymbol {
        public int Raw;
    };


    /// <summary>
    ///  Market Condition Values
    /// </summary>
    public enum MarketCondition : byte {
        Normal = "0",
        Stressed = "1",
        MarketCondition = "1",
        MarketCondition = "0",
    };


    /// <summary>
    ///  Market Segment ID
    /// </summary>
    public struct MarketSegmentId {
        public int Raw;
    };


    /// <summary>
    ///  Match Sub Type Values
    /// </summary>
    public enum MatchSubType : byte {
        OpeningAuction = "1",
        ClosingAuction = "2",
        IntradayAuction = "3",
        CircuitBreakerAuction = "4",
        IpoAuction = "5",
        MatchSubType = "5",
        MatchSubType = "1",
    };


    /// <summary>
    ///  Match Type Values
    /// </summary>
    public enum MatchType : byte {
        ConfirmedTradeReport = "3",
        CrossAuction = "5",
        CallAuction = "7",
        LiquidityImprovementCross = "13",
        MatchType = "13",
        MatchType = "3",
    };


    /// <summary>
    ///  Md Entry Px
    /// </summary>
    public struct MdEntryPx {
        public ulong Raw;
    };


    /// <summary>
    ///  Md Entry Size
    /// </summary>
    public struct MdEntrySize {
        public ulong Raw;
    };


    /// <summary>
    ///  Md Entry Type Values
    /// </summary>
    public enum MdEntryType : byte {
        Trade = "2",
        OpeningPrice = "4",
        ClosingPrice = "5",
        HighPrice = "7",
        LowPrice = "8",
        TradeVolume = "66",
        PreviousClosingPrice = "101",
        OpeningAuction = "200",
        IntradayAuction = "201",
        CircuitBreakerAuction = "202",
        ClosingAuction = "203",
        IpoAuction = "204",
        MdEntryType = "204",
        MdEntryType = "2",
    };


    /// <summary>
    ///  Msg Seq Num
    /// </summary>
    public struct MsgSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  No Legs
    /// </summary>
    public struct NoLegs {
        public byte Raw;
    };


    /// <summary>
    ///  No Md Entries
    /// </summary>
    public struct NoMdEntries {
        public byte Raw;
    };


    /// <summary>
    ///  Offer Px
    /// </summary>
    public struct OfferPx {
        public ulong Raw;
    };


    /// <summary>
    ///  Offer Size
    /// </summary>
    public struct OfferSize {
        public ulong Raw;
    };


    /// <summary>
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        Market = "1",
        OrdType = "1",
        OrdType = "1",
    };


    /// <summary>
    ///  Packet Id
    /// </summary>
    public struct PacketId {
        public ushort Raw;
    };


    /// <summary>
    ///  Packet Seq Num
    /// </summary>
    public struct PacketSeqNum {
        public uint Raw;
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
    ///  Pad5
    /// </summary>
    public unsafe struct Pad5 {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Partition ID
    /// </summary>
    public struct PartitionId {
        public byte Raw;
    };


    /// <summary>
    ///  Potential Security Trading Event Values
    /// </summary>
    public enum PotentialSecurityTradingEvent : byte {
        None = "0",
        PriceVolatilityAuctionIsExtended = "10",
        PotentialSecurityTradingEvent = "10",
        PotentialSecurityTradingEvent = "0",
    };


    /// <summary>
    ///  Prev Display Qty
    /// </summary>
    public struct PrevDisplayQty {
        public ulong Raw;
    };


    /// <summary>
    ///  Prev Price
    /// </summary>
    public struct PrevPrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public ulong Raw;
    };


    /// <summary>
    ///  Product Complex Values
    /// </summary>
    public enum ProductComplex : byte {
        StandardOptionStrategy = "2",
        NonStandardOptionStrategy = "3",
        VolatilityStrategy = "4",
        FuturesSpread = "5",
        InterProductSpread = "6",
        StandardFuturesStrategy = "7",
        PackAndBundle = "8",
        Strip = "9",
        ProductComplex = "9",
        ProductComplex = "2",
    };


    /// <summary>
    ///  Request Time
    /// </summary>
    public struct RequestTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Resting Cxl Qty
    /// </summary>
    public struct RestingCxlQty {
        public ulong Raw;
    };


    /// <summary>
    ///  Resting Hidden Qty
    /// </summary>
    public struct RestingHiddenQty {
        public long Raw;
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public struct SecurityId {
        public long Raw;
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        Active = "1",
        Inactive = "2",
        Expired = "4",
        KnockedOut = "6",
        KnockOutRevoked = "7",
        Suspended = "9",
        PendingDeletion = "11",
        KnockedOutAndSuspended = "12",
        SecurityStatus = "12",
        SecurityStatus = "1",
    };


    /// <summary>
    ///  Security Sub Type
    /// </summary>
    public struct SecuritySubType {
        public int Raw;
    };


    /// <summary>
    ///  Security Trading Event Values
    /// </summary>
    public enum SecurityTradingEvent : byte {
        PriceVolatilityAuctionIsExtended = "10",
        PriceVolatilityAuctionIsExtendedAgain = "11",
        SecurityTradingEvent = "11",
        SecurityTradingEvent = "0",
    };


    /// <summary>
    ///  Security Trading Status Values
    /// </summary>
    public enum SecurityTradingStatus : byte {
        TradingHalt = "2",
        MarketImbalanceBuy = "7",
        MarketImbalanceSell = "8",
        Closed = "200",
        Restricted = "201",
        Book = "202",
        Continuous = "203",
        OpeningAuction = "204",
        OpeningAuctionFreeze = "205",
        IntradayAuction = "206",
        IntradayAuctionFreeze = "207",
        CircuitBreakerAuction = "208",
        CircuitBreakerAuctionFreeze = "209",
        ClosingAuction = "210",
        ClosingAuctionFreeze = "211",
        IpoAuction = "212",
        IpoAuctionFreeze = "213",
        PreCall = "214",
        Call = "215",
        SecurityTradingStatus = "215",
        SecurityTradingStatus = "2",
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = "1",
        Sell = "2",
        Side = "2",
        Side = "1",
    };


    /// <summary>
    ///  Sold Out Indicator Values
    /// </summary>
    public enum SoldOutIndicator : byte {
        NotSoldOut = "0",
        SoldOut = "1",
        SoldOutIndicator = "1",
        SoldOutIndicator = "0",
    };


    /// <summary>
    ///  Template Id
    /// </summary>
    public struct TemplateId {
        public ushort Raw;
    };


    /// <summary>
    ///  Tot No Orders
    /// </summary>
    public struct TotNoOrders {
        public ushort Raw;
    };


    /// <summary>
    ///  Trad Ses Status Values
    /// </summary>
    public enum TradSesStatus : byte {
        Halted = "1",
        Open = "2",
        Closed = "3",
        TradSesStatus = "3",
        TradSesStatus = "1",
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        ImpliedTrade = "1",
        OutOfSequence = "107",
        SystematicInternalizer = "153",
        MidpointPrice = "155",
        TradedBeforeIssueDate = "156",
        TradeCondition = "156",
        TradeCondition = "1",
    };


    /// <summary>
    ///  Trading Session Id Values
    /// </summary>
    public enum TradingSessionId : byte {
        Day = "1",
        Morning = "3",
        Evening = "5",
        AfterHours = "6",
        Holiday = "7",
        TradingSessionId = "7",
        TradingSessionId = "1",
    };


    /// <summary>
    ///  Trading Session Sub Id Values
    /// </summary>
    public enum TradingSessionSubId : byte {
        PreTrading = "1",
        Continuous = "3",
        Closing = "4",
        PostTrading = "5",
        Quiescent = "7",
        TradingSessionSubId = "7",
        TradingSessionSubId = "1",
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public struct TransactTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Trd Match Id
    /// </summary>
    public struct TrdMatchId {
        public uint Raw;
    };


    /// <summary>
    ///  Trd Reg Ts Execution Time
    /// </summary>
    public struct TrdRegTsExecutionTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Trd Reg Ts Prev Time Priority
    /// </summary>
    public struct TrdRegTsPrevTimePriority {
        public ulong Raw;
    };


    /// <summary>
    ///  Trd Reg Ts Time In
    /// </summary>
    public struct TrdRegTsTimeIn {
        public ulong Raw;
    };


    /// <summary>
    ///  Trd Reg Ts Time Priority
    /// </summary>
    public struct TrdRegTsTimePriority {
        public ulong Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Complex Instrument
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddComplexInstrument {
        SecurityId SecurityId;
        TransactTime TransactTime;
        SecuritySubType SecuritySubType;
        ProductComplex ProductComplex;
        ImpliedMarketIndicator ImpliedMarketIndicator;
        NoLegs NoLegs;
        Pad1 Pad1;
    };


    /// <summary>
    ///  Struct for Auction Bbo
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionBbo {
        TransactTime TransactTime;
        SecurityId SecurityId;
        BidPx BidPx;
        OfferPx OfferPx;
        BidSize BidSize;
        OfferSize OfferSize;
        PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Auction Clearing Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionClearingPrice {
        TransactTime TransactTime;
        SecurityId SecurityId;
        LastPx LastPx;
        LastQty LastQty;
        ImbalanceQty ImbalanceQty;
        SecurityTradingStatus SecurityTradingStatus;
        PotentialSecurityTradingEvent PotentialSecurityTradingEvent;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Cross Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossRequest {
        SecurityId SecurityId;
        LastPx LastPx;
        LastQty LastQty;
        Side Side;
        CrossRequestType CrossRequestType;
        InputSource InputSource;
        Pad5 Pad5;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Execution Summary
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionSummary {
        SecurityId SecurityId;
        AggressorTime AggressorTime;
        RequestTime RequestTime;
        ExecId ExecId;
        LastQty LastQty;
        AggressorSide AggressorSide;
        TradeCondition TradeCondition;
        Pad6 Pad6;
        LastPx LastPx;
        RestingHiddenQty RestingHiddenQty;
        RestingCxlQty RestingCxlQty;
    };


    /// <summary>
    ///  Struct for Full Order Execution
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FullOrderExecution {
        Side Side;
        OrdType OrdType;
        AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
        Pad1 Pad1;
        TrdMatchId TrdMatchId;
        Price Price;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        SecurityId SecurityId;
        LastQty LastQty;
        LastPx LastPx;
    };


    /// <summary>
    ///  Struct for Heartbeat
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Heartbeat {
        LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Instrmt Leg Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrmtLegGrp {
        LegSymbol LegSymbol;
        Pad4 Pad4;
        LegSecurityId LegSecurityId;
        LegRatioQty LegRatioQty;
        LegSide LegSide;
        Pad3 Pad3;
    };


    /// <summary>
    ///  Struct for Instrument State Change
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrumentStateChange {
        SecurityId SecurityId;
        SecurityStatus SecurityStatus;
        SecurityTradingStatus SecurityTradingStatus;
        MarketCondition MarketCondition;
        FastMarketIndicator FastMarketIndicator;
        SecurityTradingEvent SecurityTradingEvent;
        SoldOutIndicator SoldOutIndicator;
        Pad2 Pad2;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Instrument Summary
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrumentSummary {
        SecurityId SecurityId;
        LastUpdateTime LastUpdateTime;
        TrdRegTsExecutionTime TrdRegTsExecutionTime;
        TotNoOrders TotNoOrders;
        SecurityStatus SecurityStatus;
        SecurityTradingStatus SecurityTradingStatus;
        MarketCondition MarketCondition;
        FastMarketIndicator FastMarketIndicator;
        SecurityTradingEvent SecurityTradingEvent;
        SoldOutIndicator SoldOutIndicator;
        NoMdEntries NoMdEntries;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Md Instrument Entry Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdInstrumentEntryGrp {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        MdEntryType MdEntryType;
        TradeCondition TradeCondition;
        Pad6 Pad6;
    };


    /// <summary>
    ///  Struct for Md Trade Entry Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdTradeEntryGrp {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        MdEntryType MdEntryType;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        BodyLen BodyLen;
        TemplateId TemplateId;
        MsgSeqNum MsgSeqNum;
    };


    /// <summary>
    ///  Struct for Order Add
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAdd {
        TrdRegTsTimeIn TrdRegTsTimeIn;
        SecurityId SecurityId;
        OrderDetails OrderDetails;
    };


    /// <summary>
    ///  Struct for Order Delete
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDelete {
        TrdRegTsTimeIn TrdRegTsTimeIn;
        TransactTime TransactTime;
        SecurityId SecurityId;
        OrderDetails OrderDetails;
    };


    /// <summary>
    ///  Struct for Order Details
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDetails {
        TrdRegTsTimePriority TrdRegTsTimePriority;
        DisplayQty DisplayQty;
        Side Side;
        OrdType OrdType;
        Pad6 Pad6;
        Price Price;
    };


    /// <summary>
    ///  Struct for Order Mass Delete
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderMassDelete {
        SecurityId SecurityId;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Order Modify
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModify {
        TrdRegTsTimeIn TrdRegTsTimeIn;
        TrdRegTsPrevTimePriority TrdRegTsPrevTimePriority;
        PrevPrice PrevPrice;
        PrevDisplayQty PrevDisplayQty;
        SecurityId SecurityId;
        OrderDetails OrderDetails;
    };


    /// <summary>
    ///  Struct for Order Modify Same Prio
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifySamePrio {
        TrdRegTsTimeIn TrdRegTsTimeIn;
        TransactTime TransactTime;
        PrevDisplayQty PrevDisplayQty;
        SecurityId SecurityId;
        OrderDetails OrderDetails;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        PacketInfo PacketInfo;
        ApplicationSequenceNumber ApplicationSequenceNumber;
        MarketSegmentId MarketSegmentId;
        PartitionId PartitionId;
        CompletionIndicator CompletionIndicator;
        ApplicationSequenceResetIndicator ApplicationSequenceResetIndicator;
        Pad5 Pad5;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Packet Info
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketInfo {
        HeaderLength HeaderLength;
        PacketId PacketId;
        PacketSeqNum PacketSeqNum;
    };


    /// <summary>
    ///  Struct for Partial Order Execution
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PartialOrderExecution {
        Side Side;
        OrdType OrdType;
        AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
        Pad1 Pad1;
        TrdMatchId TrdMatchId;
        Price Price;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        SecurityId SecurityId;
        LastQty LastQty;
        LastPx LastPx;
    };


    /// <summary>
    ///  Struct for Product State Change
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ProductStateChange {
        TradingSessionId TradingSessionId;
        TradingSessionSubId TradingSessionSubId;
        TradSesStatus TradSesStatus;
        MarketCondition MarketCondition;
        FastMarketIndicator FastMarketIndicator;
        Pad3 Pad3;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Product Summary
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ProductSummary {
        LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        TradingSessionId TradingSessionId;
        TradingSessionSubId TradingSessionSubId;
        TradSesStatus TradSesStatus;
        MarketCondition MarketCondition;
        FastMarketIndicator FastMarketIndicator;
        Pad7 Pad7;
    };


    /// <summary>
    ///  Struct for Quote Request
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteRequest {
        SecurityId SecurityId;
        LastQty LastQty;
        Side Side;
        Pad7 Pad7;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Snapshot Order
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotOrder {
        OrderDetails OrderDetails;
    };


    /// <summary>
    ///  Struct for Top Of Book
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TopOfBook {
        TransactTime TransactTime;
        SecurityId SecurityId;
        BidPx BidPx;
        OfferPx OfferPx;
        BidSize BidSize;
        OfferSize OfferSize;
    };


    /// <summary>
    ///  Struct for Trade Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReport {
        SecurityId SecurityId;
        TransactTime TransactTime;
        LastQty LastQty;
        LastPx LastPx;
        TrdMatchId TrdMatchId;
        MatchType MatchType;
        MatchSubType MatchSubType;
        AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trade Reversal
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReversal {
        SecurityId SecurityId;
        TransactTime TransactTime;
        LastQty LastQty;
        LastPx LastPx;
        TrdRegTsExecutionTime TrdRegTsExecutionTime;
        TrdMatchId TrdMatchId;
        TradeCondition TradeCondition;
        Pad2 Pad2;
        NoMdEntries NoMdEntries;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
