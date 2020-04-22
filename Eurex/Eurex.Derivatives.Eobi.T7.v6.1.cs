namespace Eurex.Derivatives.Eobi.T7.v6.1 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Aggressor Side Values
    /// </summary>
    public enum AggressorSide : byte {
        Buy = 1,
        Sell = 2,
        AggressorSideMinimumValue = 2,
        AggressorSideMinimumValue = 1,
    };


    /// <summary>
    ///  Aggressor Time
    /// </summary>
    public unsafe struct AggressorTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Algorithmic Trade Indicator Values
    /// </summary>
    public enum AlgorithmicTradeIndicator : byte {
        AlgorithmicTrade = 1,
        AlgorithmicTradeIndicatorMinimumValue = 1,
        AlgorithmicTradeIndicatorMinimumValue = 1,
    };


    /// <summary>
    ///  Application Sequence Number
    /// </summary>
    public unsafe struct ApplicationSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Application Sequence Reset Indicator Values
    /// </summary>
    public enum ApplicationSequenceResetIndicator : byte {
        NoReset = 0,
        Reset = 1,
        ApplSeqResetIndicatorMinimumValue = 1,
        ApplSeqResetIndicatorMinimumValue = 0,
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
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Completion Indicator Values
    /// </summary>
    public enum CompletionIndicator : byte {
        Incomplete = 0,
        Complete = 1,
        CompletionIndicatorMinimumValue = 1,
        CompletionIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Display Qty
    /// </summary>
    public struct DisplayQty {
        public int Raw;
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
    ///  Fast Market Indicator Values
    /// </summary>
    public enum FastMarketIndicator : byte {
        No = 0,
        Yes = 1,
        FastMarketIndicatorMinimumValue = 1,
        FastMarketIndicatorMinimumValue = 0,
    };


    /// <summary>
    ///  Header Length
    /// </summary>
    public unsafe struct HeaderLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Imbalance Qty
    /// </summary>
    public struct ImbalanceQty {
        public int Raw;
    };


    /// <summary>
    ///  Implied Market Indicator Values
    /// </summary>
    public enum ImpliedMarketIndicator : byte {
        NotImplied = 0,
        ImpliedInOut = 3,
        ImpliedMarketIndicatorMinimumValue = 3,
        ImpliedMarketIndicatorMinimumValue = 0,
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
    ///  Market Condition Values
    /// </summary>
    public enum MarketCondition : byte {
        Normal = 0,
        Stressed = 1,
        MarketConditionMinimumValue = 1,
        MarketConditionMinimumValue = 0,
    };


    /// <summary>
    ///  Market Segment Id
    /// </summary>
    public struct MarketSegmentId {
        public int Raw;
    };


    /// <summary>
    ///  Match Sub Type Values
    /// </summary>
    public enum MatchSubType : byte {
        OpeningAuction = 1,
        ClosingAuction = 2,
        IntradayAuction = 3,
        CircuitBreakerAuction = 4,
        IpoAuction = 5,
        MatchSubTypeMinimumValue = 5,
        MatchSubTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Match Type Values
    /// </summary>
    public enum MatchType : byte {
        ConfirmedTradeReport = 3,
        CrossAuction = 5,
        CallAuction = 7,
        MatchTypeMinimumValue = 7,
        MatchTypeMinimumValue = 3,
    };


    /// <summary>
    ///  Md Entry Px
    /// </summary>
    public unsafe struct MdEntryPx {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Entry Size
    /// </summary>
    public struct MdEntrySize {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Type Values
    /// </summary>
    public enum MdEntryType : byte {
        Trade = 2,
        OpeningPrice = 4,
        ClosingPrice = 5,
        HighPrice = 7,
        LowPrice = 8,
        TradeVolume = 66,
        PreviousClosingPrice = 101,
        OpeningAuction = 200,
        IntradayAuction = 201,
        CircuitBreakerAuction = 202,
        ClosingAuction = 203,
        IpoAuction = 204,
        MdEntryTypeMinimumValue = 204,
        MdEntryTypeMinimumValue = 2,
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
    ///  No Legs
    /// </summary>
    public unsafe struct NoLegs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Md Entries
    /// </summary>
    public unsafe struct NoMdEntries {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        Market = 1,
        OrdTypeMinimumValue = 1,
        OrdTypeMinimumValue = 1,
    };


    /// <summary>
    ///  Packet Id
    /// </summary>
    public unsafe struct PacketId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Seq Num
    /// </summary>
    public unsafe struct PacketSeqNum {
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
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Potential Security Trading Event Values
    /// </summary>
    public enum PotentialSecurityTradingEvent : byte {
        None = 0,
        PriceVolatilityAuctionIsExtended = 10,
        PotentialSecurityTradingEventMinimumValue = 10,
        PotentialSecurityTradingEventMinimumValue = 0,
    };


    /// <summary>
    ///  Prev Display Qty
    /// </summary>
    public struct PrevDisplayQty {
        public int Raw;
    };


    /// <summary>
    ///  Prev Price
    /// </summary>
    public unsafe struct PrevPrice {
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
    ///  Product Complex Values
    /// </summary>
    public enum ProductComplex : byte {
        StandardOptionStrategy = 2,
        NonStandardOptionStrategy = 3,
        VolatilityStrategy = 4,
        FuturesSpread = 5,
        InterProductSpread = 6,
        StandardFuturesStrategy = 7,
        PackAndBundle = 8,
        Strip = 9,
        ProductComplexMinimumValue = 9,
        ProductComplexMinimumValue = 2,
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
    ///  Resting Cxl Qty
    /// </summary>
    public struct RestingCxlQty {
        public int Raw;
    };


    /// <summary>
    ///  Resting Hidden Qty
    /// </summary>
    public struct RestingHiddenQty {
        public int Raw;
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
        Active = 1,
        Inactive = 2,
        Expired = 4,
        Suspended = 9,
        PendingDeletion = 11,
        SecurityStatusMinimumValue = 11,
        SecurityStatusMinimumValue = 1,
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
        PriceVolatilityAuctionIsExtended = 10,
        PriceVolatilityAuctionIsExtendedAgain = 11,
        SecurityTradingEventMinimumValue = 11,
        SecurityTradingEventMinimumValue = 0,
    };


    /// <summary>
    ///  Security Trading Status Values
    /// </summary>
    public enum SecurityTradingStatus : byte {
        TradingHalt = 2,
        MarketImbalanceBuy = 7,
        MarketImbalanceSell = 8,
        Closed = 200,
        Restricted = 201,
        Book = 202,
        Continuous = 203,
        OpeningAuction = 204,
        OpeningAuctionFreeze = 205,
        IntradayAuction = 206,
        IntradayAuctionFreeze = 207,
        CircuitBreakerAuction = 208,
        CircuitBreakerAuctionFreeze = 209,
        ClosingAuction = 210,
        ClosingAuctionFreeze = 211,
        IpoAuction = 212,
        IpoAuctionFreeze = 213,
        SecurityTradingStatusMinimumValue = 213,
        SecurityTradingStatusMinimumValue = 2,
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
    ///  Template Id
    /// </summary>
    public unsafe struct TemplateId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tot No Orders
    /// </summary>
    public unsafe struct TotNoOrders {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trad Ses Status Values
    /// </summary>
    public enum TradSesStatus : byte {
        Halted = 1,
        Open = 2,
        Closed = 3,
        TradSesStatusMinimumValue = 3,
        TradSesStatusMinimumValue = 1,
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        ImpliedTrade = 1,
        SystematicInternalizer = 153,
        MidpointPrice = 155,
        TradeConditionMinimumValue = 155,
        TradeConditionMinimumValue = 1,
    };


    /// <summary>
    ///  Trading Session Id Values
    /// </summary>
    public enum TradingSessionId : byte {
        Day = 1,
        Morning = 3,
        Evening = 5,
        AfterHours = 6,
        Holiday = 7,
        TradingSessionIDMinimumValue = 7,
        TradingSessionIDMinimumValue = 1,
    };


    /// <summary>
    ///  Trading Session Sub Id Values
    /// </summary>
    public enum TradingSessionSubId : byte {
        PreTrading = 1,
        Continuous = 3,
        Closing = 4,
        PostTrading = 5,
        Quiescent = 7,
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
    ///  Trd Match Id
    /// </summary>
    public unsafe struct TrdMatchId {
        public const int Size = 4;

        public int Value;

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
    ///  Trd Reg Ts Prev Time Priority
    /// </summary>
    public unsafe struct TrdRegTsPrevTimePriority {
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
    ///  Trd Reg Ts Time Priority
    /// </summary>
    public unsafe struct TrdRegTsTimePriority {
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
        LastQty LastQty;
        Pad4 Pad4;
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
        Pad2 Pad2;
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
        Pad5 Pad5;
        Price Price;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        SecurityId SecurityId;
        TrdMatchId TrdMatchId;
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
        Pad3 Pad3;
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
        NoMdEntries NoMdEntries;
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
        Pad2 Pad2;
    };


    /// <summary>
    ///  Struct for Md Trade Entry Grp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdTradeEntryGrp {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        MdEntryType MdEntryType;
        Pad3 Pad3;
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
        Pad2 Pad2;
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
        Pad4 Pad4;
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
        Pad4 Pad4;
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
        Pad5 Pad5;
        Price Price;
        TrdRegTsTimePriority TrdRegTsTimePriority;
        SecurityId SecurityId;
        TrdMatchId TrdMatchId;
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
        Pad3 Pad3;
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
    };


    /// <summary>
    ///  Struct for Trade Report
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReport {
        SecurityId SecurityId;
        TransactTime TransactTime;
        TrdMatchId TrdMatchId;
        LastQty LastQty;
        LastPx LastPx;
        MatchType MatchType;
        MatchSubType MatchSubType;
        AlgorithmicTradeIndicator AlgorithmicTradeIndicator;
        TradeCondition TradeCondition;
        Pad4 Pad4;
    };


    /// <summary>
    ///  Struct for Trade Reversal
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReversal {
        SecurityId SecurityId;
        TransactTime TransactTime;
        TrdMatchId TrdMatchId;
        LastQty LastQty;
        LastPx LastPx;
        TrdRegTsExecutionTime TrdRegTsExecutionTime;
        TradeCondition TradeCondition;
        Pad6 Pad6;
        NoMdEntries NoMdEntries;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
