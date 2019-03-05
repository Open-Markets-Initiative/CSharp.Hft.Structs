namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Ask Customer Volume
    /// </summary>
    public unsafe struct AskCustomerVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Price
    /// </summary>
    public struct AskPrice {
        public int Raw;
    };


    /// <summary>
    ///  Ask Volume
    /// </summary>
    public unsafe struct AskVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        Opening = (byte)'O',
        Halt = (byte)'H',
    };


    /// <summary>
    ///  Bid Customer Volume
    /// </summary>
    public unsafe struct BidCustomerVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public struct BidPrice {
        public int Raw;
    };


    /// <summary>
    ///  Bid Volume
    /// </summary>
    public unsafe struct BidVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Capacity Values
    /// </summary>
    public enum Capacity : byte {
        NotSpecified = (byte)' ',
        Customer = (byte)'0',
        Firm = (byte)'1',
        BrokerDealer = (byte)'2',
        MarketMaker = (byte)'3',
        ProfessionalCustomer = (byte)'8',
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public unsafe struct ChannelId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Close
    /// </summary>
    public struct Close {
        public int Raw;
    };


    /// <summary>
    ///  Contract Multiplier
    /// </summary>
    public unsafe struct ContractMultiplier {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contracts
    /// </summary>
    public unsafe struct Contracts {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Delivery Flag Values
    /// </summary>
    public enum DeliveryFlag : byte {
        Heartbeat = 1,
        XdpFailover = 10,
        OriginalMessage = 11,
        SequenceNumberResetMessage = 12,
        OneRetransmissionPacket = 13,
        RetransmissionSequenceMessage = 15,
        OneRefreshPacket = 17,
        RefreshSequenceStart = 18,
        RefreshSequenceMessage = 19,
        RefreshSequenceEnd = 20,
        MessageUnavailable = 21,
    };


    /// <summary>
    ///  Exchange Code Values
    /// </summary>
    public enum ExchangeCode : byte {
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        NyseMkt = (byte)'A',
        GlobalOtc = (byte)'1',
        ArcaLocalNontapebIndex = (byte)'2',
    };


    /// <summary>
    ///  Group Id
    /// </summary>
    public unsafe struct GroupId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Halt Condition
    /// </summary>
    public unsafe struct HaltCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Price
    /// </summary>
    public struct HighPrice {
        public int Raw;
    };


    /// <summary>
    ///  Imbalance Side Values
    /// </summary>
    public enum ImbalanceSide : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        NoImbalance = (byte)' ',
    };


    /// <summary>
    ///  Low Price
    /// </summary>
    public struct LowPrice {
        public int Raw;
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        NyseCash = 1,
        EuropeCash = 2,
        NyseArcaCash = 3,
        NyseArcaOptions = 4,
        NyseArcaBonds = 5,
        ArcaEdge = 6,
        Liffe = 7,
        NyseAmericanOptions = 8,
        NyseMktCash = 9,
    };


    /// <summary>
    ///  Market Imbalance Qty
    /// </summary>
    public unsafe struct MarketImbalanceQty {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Imbalance Side Values
    /// </summary>
    public enum MarketImbalanceSide : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        NoImbalance = (byte)' ',
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Message Type Values
    /// </summary>
    public enum MessageType : ushort {
        OutrightQuoteMessage = 401,
        OutrightTradeMessage = 407,
        OutrightTradeCancelMessage = 409,
        OutrightTradeCorrectionMessage = 411,
        OutrightImbalanceMessage = 413,
        OutrightCrossingRfqMessage = 415,
        OutrightBoldRfqMessage = 471,
        OutrightSummaryMessage = 417,
        UnderlyingStatusMessage = 419,
        OutrightSeriesStatusMessage = 421,
        RefreshOutrightQuoteMessage = 501,
        RefreshOutrightTradeMessage = 507,
        RefreshOutrightImbalanceMessage = 509,
        UnderlyingIndexMappingMessage = 435,
        SeriesIndexMappingMessage = 437,
        StreamIdMessage = 455,
        SequenceNumberResetMessage = 1,
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public unsafe struct Nanoseconds {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open
    /// </summary>
    public struct Open {
        public int Raw;
    };


    /// <summary>
    ///  Option Symbol Root
    /// </summary>
    public unsafe struct OptionSymbolRoot {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Id
    /// </summary>
    public unsafe struct OriginalTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public unsafe struct PacketSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Paired Qty
    /// </summary>
    public unsafe struct PairedQty {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Participant
    /// </summary>
    public unsafe struct Participant {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public int Raw;
    };


    /// <summary>
    ///  Price Resolution Values
    /// </summary>
    public enum PriceResolution : byte {
        AllPenny = 0,
        PennyNickel = 1,
        NickelDime = 5,
    };


    /// <summary>
    ///  Price Scale Code
    /// </summary>
    public unsafe struct PriceScaleCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public unsafe struct ProductId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = 0,
        Call = 1,
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        RegularTrading = (byte)'1',
        Rotation = (byte)'2',
        TradingHalted = (byte)'3',
        Preopen = (byte)'4',
        RotationLegalWidthQuotePending = (byte)'5',
    };


    /// <summary>
    ///  Reference Price
    /// </summary>
    public struct ReferencePrice {
        public int Raw;
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
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 3
    /// </summary>
    public unsafe struct Reserved3 {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved A 1
    /// </summary>
    public unsafe struct ReservedA1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved B 1
    /// </summary>
    public unsafe struct ReservedB1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        LightUpADarkSeries = (byte)'L',
        OpenADarkSeries = (byte)'N',
        Open = (byte)'O',
        Close = (byte)'X',
        Halt = (byte)'S',
        Unhalt = (byte)'U',
        UnhaltADarkSeries = (byte)'T',
        EndOfRfqAuction = (byte)'Q',
    };


    /// <summary>
    ///  Security Type Values
    /// </summary>
    public enum SecurityType : byte {
        Adr = (byte)'A',
        CommonStock = (byte)'C',
        Debentures = (byte)'D',
        Etf = (byte)'E',
        Foreign = (byte)'F',
        AmericanDepositoryShares = (byte)'H',
        Units = (byte)'I',
        MiscliquidTrust = (byte)'M',
        OrdinaryShares = (byte)'O',
        PreferredStock = (byte)'P',
        Rights = (byte)'R',
        SharesOfBeneficiaryInterest = (byte)'S',
        Test = (byte)'T',
        Units = (byte)'U',
        Warrant = (byte)'W',
        Index = (byte)'X',
    };


    /// <summary>
    ///  Sequence Number
    /// </summary>
    public unsafe struct SequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Series Index
    /// </summary>
    public unsafe struct SeriesIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Source Ns
    /// </summary>
    public unsafe struct SourceNs {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Time
    /// </summary>
    public unsafe struct SourceTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Time Ns
    /// </summary>
    public unsafe struct SourceTimeNs {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stream Id
    /// </summary>
    public unsafe struct StreamId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public unsafe struct StrikePrice {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Seq Num
    /// </summary>
    public unsafe struct SymbolSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Id
    /// </summary>
    public unsafe struct SystemId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Imbalance Qty
    /// </summary>
    public unsafe struct TotalImbalanceQty {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Volume
    /// </summary>
    public unsafe struct TotalVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Cond 1 Values
    /// </summary>
    public enum TradeCond1 : byte {
        RegularTrade = (byte)' ',
        LateReport = (byte)'I',
        FloorTrade = (byte)'R',
        SoSweepTrade = (byte)'S',
    };


    /// <summary>
    ///  Trade Cond 2 Values
    /// </summary>
    public enum TradeCond2 : byte {
        ComplexTradeWithEquity = (byte)'P',
        ComplexTrade = (byte)'L',
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
    ///  Underlying Index
    /// </summary>
    public unsafe struct UnderlyingIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Seq Num
    /// </summary>
    public unsafe struct UnderlyingSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Volume 2
    /// </summary>
    public unsafe struct Volume2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Volume 4
    /// </summary>
    public unsafe struct Volume4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

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
        MessageSize MessageSize;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Outright Bold Rfq Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightBoldRfqMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        Side Side;
        Capacity Capacity;
        Contracts Contracts;
        Price Price;
        Participant Participant;
    };


    /// <summary>
    ///  Struct for Outright Crossing Rfq Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightCrossingRfqMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        Side Side;
        Reserved1 Reserved1;
        Volume2 Volume2;
        Price Price;
    };


    /// <summary>
    ///  Struct for Outright Imbalance Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightImbalanceMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        ReferencePrice ReferencePrice;
        PairedQty PairedQty;
        TotalImbalanceQty TotalImbalanceQty;
        MarketImbalanceQty MarketImbalanceQty;
        AuctionType AuctionType;
        ImbalanceSide ImbalanceSide;
        MarketImbalanceSide MarketImbalanceSide;
        Reserved3 Reserved3;
    };


    /// <summary>
    ///  Struct for Outright Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightQuoteMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        AskPrice AskPrice;
        BidPrice BidPrice;
        AskVolume AskVolume;
        BidVolume BidVolume;
        AskCustomerVolume AskCustomerVolume;
        BidCustomerVolume BidCustomerVolume;
        QuoteCondition QuoteCondition;
        Reserved1 Reserved1;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Outright Series Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightSeriesStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Outright Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightSummaryMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        HighPrice HighPrice;
        LowPrice LowPrice;
        Open Open;
        Close Close;
        TotalVolume TotalVolume;
    };


    /// <summary>
    ///  Struct for Outright Trade Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightTradeCancelMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        OriginalTradeId OriginalTradeId;
    };


    /// <summary>
    ///  Struct for Outright Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightTradeCorrectionMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        OriginalTradeId OriginalTradeId;
        TradeId TradeId;
        Price Price;
        Volume4 Volume4;
        TradeCond1 TradeCond1;
        TradeCond2 TradeCond2;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Outright Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightTradeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeId TradeId;
        Price Price;
        Volume4 Volume4;
        TradeCond1 TradeCond1;
        TradeCond2 TradeCond2;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        PacketHeader PacketHeader;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        PacketSize PacketSize;
        DeliveryFlag DeliveryFlag;
        MessageCount MessageCount;
        SequenceNumber SequenceNumber;
        Timestamp Timestamp;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Refresh Outright Imbalance Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshOutrightImbalanceMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        ReferencePrice ReferencePrice;
        PairedQty PairedQty;
        TotalImbalanceQty TotalImbalanceQty;
        MarketImbalanceQty MarketImbalanceQty;
        AuctionType AuctionType;
        ImbalanceSide ImbalanceSide;
        MarketImbalanceSide MarketImbalanceSide;
        Reserved3 Reserved3;
    };


    /// <summary>
    ///  Struct for Refresh Outright Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshOutrightQuoteMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        AskPrice AskPrice;
        BidPrice BidPrice;
        AskVolume AskVolume;
        BidVolume BidVolume;
        AskCustomerVolume AskCustomerVolume;
        BidCustomerVolume BidCustomerVolume;
        QuoteCondition QuoteCondition;
        Reserved1 Reserved1;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Refresh Outright Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshOutrightTradeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeId TradeId;
        Price Price;
        Volume4 Volume4;
        TradeCond1 TradeCond1;
        TradeCond2 TradeCond2;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Sequence Number Reset Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequenceNumberResetMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Series Index Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SeriesIndexMappingMessage {
        SeriesIndex SeriesIndex;
        ChannelId ChannelId;
        ReservedA1 ReservedA1;
        MarketId MarketId;
        SystemId SystemId;
        ReservedB1 ReservedB1;
        StreamId StreamId;
        UnderlyingIndex UnderlyingIndex;
        ContractMultiplier ContractMultiplier;
        MaturityDate MaturityDate;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        PriceScaleCode PriceScaleCode;
        UnderlyingSymbol UnderlyingSymbol;
        OptionSymbolRoot OptionSymbolRoot;
        GroupId GroupId;
    };


    /// <summary>
    ///  Struct for Stream Id Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamIdMessage {
        StreamId StreamId;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Underlying Index Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingIndexMappingMessage {
        UnderlyingIndex UnderlyingIndex;
        UnderlyingSymbol UnderlyingSymbol;
        ChannelId ChannelId;
        MarketId MarketId;
        SystemId SystemId;
        ExchangeCode ExchangeCode;
        PriceScaleCode PriceScaleCode;
        SecurityType SecurityType;
        PriceResolution PriceResolution;
        Reserved1 Reserved1;
    };


    /// <summary>
    ///  Struct for Underlying Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        UnderlyingIndex UnderlyingIndex;
        UnderlyingSeqNum UnderlyingSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved2 Reserved2;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
