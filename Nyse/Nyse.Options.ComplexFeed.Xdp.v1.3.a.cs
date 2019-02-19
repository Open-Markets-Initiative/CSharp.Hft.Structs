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
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Ask Customer Volume
    /// </summary>
    public struct AskCustomerVolume {
        public ushort Raw;
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
    public struct AskVolume {
        public ushort Raw;
    };


    /// <summary>
    ///  Bid Customer Volume
    /// </summary>
    public struct BidCustomerVolume {
        public ushort Raw;
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
    public struct BidVolume {
        public ushort Raw;
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public struct ChannelId {
        public byte Raw;
    };


    /// <summary>
    ///  Complex Index
    /// </summary>
    public struct ComplexIndex {
        public uint Raw;
    };


    /// <summary>
    ///  Complex Symbol
    /// </summary>
    public unsafe struct ComplexSymbol {
        public const int Size = 21;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Delivery Flag Values
    /// </summary>
    public enum DeliveryFlag : byte {
        Heartbeat = "1",
        XdpFailover = "10",
        OriginalMessage = "11",
        SequenceNumberResetMessage = "12",
        OneRetransmissionPacket = "13",
        RetransmissionSequenceMessage = "15",
        OneRefreshPacket = "17",
        RefreshSequenceStart = "18",
        RefreshSequenceMessage = "19",
        RefreshSequenceEnd = "20",
        MessageUnavailable = "21",
    };


    /// <summary>
    ///  Halt Condition
    /// </summary>
    public unsafe struct HaltCondition {
        public const int Size = 1;

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
        public ushort Raw;
    };


    /// <summary>
    ///  Leg Security Type Values
    /// </summary>
    public enum LegSecurityType : byte {
        OptionsSeriesLeg = (byte)'O',
        EquityStockLeg = (byte)'E',
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        NyseCash = "1",
        EuropeCash = "2",
        NyseArcaCash = "3",
        NyseArcaOptions = "4",
        NyseArcaBonds = "5",
        ArcaEdge = "6",
        Liffe = "7",
        NyseAmericanOptions = "8",
        NyseMktCash = "9",
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public struct MessageCount {
        public byte Raw;
    };


    /// <summary>
    ///  Message Size
    /// </summary>
    public struct MessageSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : ushort {
        ComplexQuoteMessage = "423",
        ComplexTradeMessage = "425",
        ComplexCrossingRfqMessage = "429",
        ComplexCubeRfqMessage = "472",
        ComplexStatusMessage = "433",
        RefreshComplexQuoteMessage = "511",
        RefreshComplexTradeMessage = "513",
        ComplexSymbolDefinitionMessage = "439",
        StreamIdMessage = "455",
        SequenceNumberResetMessage = "1",
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public struct Nanoseconds {
        public uint Raw;
    };


    /// <summary>
    ///  No Of Legs
    /// </summary>
    public struct NoOfLegs {
        public ushort Raw;
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public struct PacketSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public int Raw;
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public struct ProductId {
        public byte Raw;
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
    ///  Sequence Number
    /// </summary>
    public struct SequenceNumber {
        public uint Raw;
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
    public struct SourceNs {
        public uint Raw;
    };


    /// <summary>
    ///  Source Time
    /// </summary>
    public struct SourceTime {
        public uint Raw;
    };


    /// <summary>
    ///  Source Time Ns
    /// </summary>
    public struct SourceTimeNs {
        public uint Raw;
    };


    /// <summary>
    ///  Stream Id
    /// </summary>
    public struct StreamId {
        public ushort Raw;
    };


    /// <summary>
    ///  Symbol Index
    /// </summary>
    public struct SymbolIndex {
        public uint Raw;
    };


    /// <summary>
    ///  Symbol Seq Num
    /// </summary>
    public struct SymbolSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  System Id
    /// </summary>
    public struct SystemId {
        public byte Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public uint Raw;
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
    public struct TradeId {
        public uint Raw;
    };


    /// <summary>
    ///  Volume 2
    /// </summary>
    public struct Volume2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Volume 4
    /// </summary>
    public struct Volume4 {
        public uint Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Complex Crossing Rfq Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexCrossingRfqMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        ComplexIndex ComplexIndex;
        SymbolSeqNum SymbolSeqNum;
        Side Side;
        Reserved1 Reserved1;
        Volume2 Volume2;
        Price Price;
    };


    /// <summary>
    ///  Struct for Complex Cube Rfq Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexCubeRfqMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        ComplexIndex ComplexIndex;
        SymbolSeqNum SymbolSeqNum;
        Side Side;
        Reserved1 Reserved1;
        Volume2 Volume2;
        Price Price;
    };


    /// <summary>
    ///  Struct for Complex Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexQuoteMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ComplexIndex ComplexIndex;
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
    ///  Struct for Complex Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ComplexIndex ComplexIndex;
        SymbolSeqNum SymbolSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Complex Symbol Definition Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexSymbolDefinitionMessage {
        ComplexIndex ComplexIndex;
        ComplexSymbol ComplexSymbol;
        ChannelId ChannelId;
        MarketId MarketId;
        SystemId SystemId;
        Reserved1 Reserved1;
        StreamId StreamId;
        NoOfLegs NoOfLegs;
        Reserved2 Reserved2;
        LegDefinition LegDefinition;
    };


    /// <summary>
    ///  Struct for Complex Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTradeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ComplexIndex ComplexIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeId TradeId;
        Price Price;
        Volume4 Volume4;
        TradeCond1 TradeCond1;
        TradeCond2 TradeCond2;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Leg Definition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegDefinition {
        SymbolIndex SymbolIndex;
        LegRatioQty LegRatioQty;
        Side Side;
        LegSecurityType LegSecurityType;
    };


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
    ///  Struct for Refresh Complex Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshComplexQuoteMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ComplexIndex ComplexIndex;
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
    ///  Struct for Refresh Complex Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshComplexTradeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ComplexIndex ComplexIndex;
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
    ///  Struct for Stream Id Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamIdMessage {
        StreamId StreamId;
        Reserved2 Reserved2;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
