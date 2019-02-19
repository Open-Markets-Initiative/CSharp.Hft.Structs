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
    ///  Ask Price
    /// </summary>
    public struct AskPrice {
        public uint Raw;
    };


    /// <summary>
    ///  Ask Volume
    /// </summary>
    public struct AskVolume {
        public uint Raw;
    };


    /// <summary>
    ///  Begin Seq Num
    /// </summary>
    public struct BeginSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public struct BidPrice {
        public uint Raw;
    };


    /// <summary>
    ///  Bid Volume
    /// </summary>
    public struct BidVolume {
        public uint Raw;
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public struct ChannelId {
        public byte Raw;
    };


    /// <summary>
    ///  Current Refresh Pkt
    /// </summary>
    public struct CurrentRefreshPkt {
        public ushort Raw;
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
    ///  End Seq Num
    /// </summary>
    public struct EndSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Exchange Code Values
    /// </summary>
    public enum ExchangeCode : byte {
        NyseAmerican = (byte)'A',
        NyseNational = (byte)'C',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        Iex = (byte)'V',
        Bats = (byte)'Z',
        GlobalOtc = (byte)'B',
        Otcbb = (byte)'U',
        OtherOtc = (byte)'V',
    };


    /// <summary>
    ///  Halt Condition Values
    /// </summary>
    public enum HaltCondition : byte {
        SecurityNotDelayedhalted = (byte)'~',
        NotDelayedhaltedNyseTapeAOnly = (byte)' ',
        NewsDissemination = (byte)'D',
        OrderImbalance = (byte)'I',
        NewsPending = (byte)'P',
        LuldPause = (byte)'M',
        RelatedSecurityNotUsed = (byte)'S',
        EquipmentChangeover = (byte)'X',
        NoOpenNoResume = (byte)'Z',
        MarketWideCircuitBreakerHaltLevel1 = (byte)'1',
        MarketWideCircuitBreakerHaltLevel2 = (byte)'2',
        MarketWideCircuitBreakerHaltLevel3 = (byte)'3',
    };


    /// <summary>
    ///  Id
    /// </summary>
    public struct Id {
        public uint Raw;
    };


    /// <summary>
    ///  Last Seq Num
    /// </summary>
    public struct LastSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Last Symbol Seq Num
    /// </summary>
    public struct LastSymbolSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Lot Size
    /// </summary>
    public struct LotSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        NyseEquities = "1",
        NyseArcaEquities = "3",
        NyseArcaOptions = "4",
        NyseBonds = "5",
        GlobalOtc = "6",
        NyseAmexOptions = "8",
        NyseAmericanEquities = "9",
        NyseNationalOptions = "10",
    };


    /// <summary>
    ///  Market State
    /// </summary>
    public unsafe struct MarketState {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
        SequenceNumberResetMessage = "1",
        SourceTimeReferenceMessage = "2",
        SymbolIndexMappingMessage = "3",
        RetransmissionRequestMessage = "10",
        RequestResponseMessage = "11",
        HeartbeatResponseMessage = "12",
        SymbolIndexMappingRequestMessage = "13",
        RefreshRequestMessage = "15",
        MessageUnavailableMessage = "31",
        SymbolClearMessage = "32",
        TradingSessionChangeMessage = "33",
        SecurityStatusMessage = "34",
        RefreshHeaderMessage = "35",
        QuoteMessage = "140",
    };


    /// <summary>
    ///  Mpv
    /// </summary>
    public struct Mpv {
        public ushort Raw;
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public struct Nanoseconds {
        public uint Raw;
    };


    /// <summary>
    ///  Next Source Seq Num
    /// </summary>
    public struct NextSourceSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public struct PacketSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Prev Close Price
    /// </summary>
    public struct PrevClosePrice {
        public uint Raw;
    };


    /// <summary>
    ///  Prev Close Volume
    /// </summary>
    public struct PrevCloseVolume {
        public uint Raw;
    };


    /// <summary>
    ///  Price 1
    /// </summary>
    public struct Price1 {
        public uint Raw;
    };


    /// <summary>
    ///  Price 2
    /// </summary>
    public struct Price2 {
        public uint Raw;
    };


    /// <summary>
    ///  Price Resolution
    /// </summary>
    public struct PriceResolution {
        public byte Raw;
    };


    /// <summary>
    ///  Price Scale Code
    /// </summary>
    public struct PriceScaleCode {
        public byte Raw;
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
        Closing = (byte)'C',
        OpeningQuote = (byte)'O',
        RegularQuote = (byte)'R',
        SlowOnTheBidAndAsk = (byte)'W',
    };


    /// <summary>
    ///  Request Seq Num
    /// </summary>
    public struct RequestSeqNum {
        public uint Raw;
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
    ///  Reserved 4
    /// </summary>
    public unsafe struct Reserved4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Retransmit Method Values
    /// </summary>
    public enum RetransmitMethod : byte {
        Udp = "0",
    };


    /// <summary>
    ///  Round Lot
    /// </summary>
    public unsafe struct RoundLot {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rpi Indicator Values
    /// </summary>
    public enum RpiIndicator : byte {
        NoRetailInterest = (byte)' ',
        RetailInterestOnBidSide = (byte)'A',
        RetailInterestOnOfferSide = (byte)'B',
        RetailInterestOnTheBidAndOfferSide = (byte)'C',
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        OpeningDelay = (byte)'3',
        TradingHalt = (byte)'4',
        Resume = (byte)'5',
        NoOpennoResume = (byte)'6',
        ShortSaleRestrictionActivatedDay1 = (byte)'A',
        ShortSaleRestrictionContinuedDay2 = (byte)'C',
        ShortSaleRestrictionDeactivated = (byte)'D',
        Preopening = (byte)'P',
        EarlySession = (byte)'E',
        CoreSession = (byte)'O',
        LateSessionNonNyseOnly = (byte)'L',
        Closed = (byte)'X',
        Time = (byte)'T',
        PriceIndication = (byte)'I',
        PreOpeningPriceIndication = (byte)'G',
        Rule15Indication = (byte)'R',
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
        UsDepositaryShares = (byte)'H',
        Units = (byte)'I',
        IndexLinkedNotes = (byte)'L',
        MiscliquidTrust = (byte)'M',
        OrdinaryShares = (byte)'O',
        PreferredStock = (byte)'P',
        Rights = (byte)'R',
        SharesOfBeneficiaryInterest = (byte)'S',
        Test = (byte)'T',
        Units = (byte)'U',
        Warrant = (byte)'W',
    };


    /// <summary>
    ///  Sequence Number
    /// </summary>
    public struct SequenceNumber {
        public uint Raw;
    };


    /// <summary>
    ///  Session State
    /// </summary>
    public unsafe struct SessionState {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Id
    /// </summary>
    public unsafe struct SourceId {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Ssr State
    /// </summary>
    public unsafe struct SsrState {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ssr Triggering Exchange Id Values
    /// </summary>
    public enum SsrTriggeringExchangeId : byte {
        NyseAmerican = (byte)'A',
        NasdaqOmxBx = (byte)'B',
        NyseNational = (byte)'C',
        Finra = (byte)'D',
        Ise = (byte)'I',
        Edga = (byte)'J',
        Edgx = (byte)'K',
        Chx = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        Cts = (byte)'S',
        NasdaqOmx = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqOmxPsx = (byte)'X',
        BatsY = (byte)'Y',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Ssr Triggering Volume
    /// </summary>
    public struct SsrTriggeringVolume {
        public uint Raw;
    };


    /// <summary>
    ///  Status
    /// </summary>
    public unsafe struct Status {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Time
    /// </summary>
    public struct Time {
        public uint Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public uint Raw;
    };


    /// <summary>
    ///  Total Refresh Pkts
    /// </summary>
    public struct TotalRefreshPkts {
        public ushort Raw;
    };


    /// <summary>
    ///  Trading Session
    /// </summary>
    public struct TradingSession {
        public byte Raw;
    };


    /// <summary>
    ///  Unit Of Trade
    /// </summary>
    public struct UnitOfTrade {
        public ushort Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Heartbeat Response Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HeartbeatResponseMessage {
        SourceId SourceId;
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
    ///  Struct for Message Unavailable Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageUnavailableMessage {
        BeginSeqNum BeginSeqNum;
        EndSeqNum EndSeqNum;
        ProductId ProductId;
        ChannelId ChannelId;
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
    ///  Struct for Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        AskPrice AskPrice;
        AskVolume AskVolume;
        BidPrice BidPrice;
        BidVolume BidVolume;
        QuoteCondition QuoteCondition;
        RpiIndicator RpiIndicator;
        Reserved4 Reserved4;
    };


    /// <summary>
    ///  Struct for Refresh Header Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshHeaderMessage {
        CurrentRefreshPkt CurrentRefreshPkt;
        TotalRefreshPkts TotalRefreshPkts;
        LastSeqNum LastSeqNum;
        LastSymbolSeqNum LastSymbolSeqNum;
    };


    /// <summary>
    ///  Struct for Refresh Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshRequestMessage {
        SymbolIndex SymbolIndex;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Request Response Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestResponseMessage {
        RequestSeqNum RequestSeqNum;
        BeginSeqNum BeginSeqNum;
        EndSeqNum EndSeqNum;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
        Status Status;
    };


    /// <summary>
    ///  Struct for Retransmission Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmissionRequestMessage {
        BeginSeqNum BeginSeqNum;
        EndSeqNum EndSeqNum;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Security Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved4 Reserved4;
        Price1 Price1;
        Price2 Price2;
        SsrTriggeringExchangeId SsrTriggeringExchangeId;
        SsrTriggeringVolume SsrTriggeringVolume;
        Time Time;
        SsrState SsrState;
        MarketState MarketState;
        SessionState SessionState;
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
    ///  Struct for Source Time Reference Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SourceTimeReferenceMessage {
        Id Id;
        SymbolSeqNum SymbolSeqNum;
        SourceTime SourceTime;
    };


    /// <summary>
    ///  Struct for Symbol Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolClearMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        NextSourceSeqNum NextSourceSeqNum;
    };


    /// <summary>
    ///  Struct for Symbol Index Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolIndexMappingMessage {
        SymbolIndex SymbolIndex;
        Symbol Symbol;
        Reserved1 Reserved1;
        MarketId MarketId;
        SystemId SystemId;
        ExchangeCode ExchangeCode;
        PriceScaleCode PriceScaleCode;
        SecurityType SecurityType;
        LotSize LotSize;
        PrevClosePrice PrevClosePrice;
        PrevCloseVolume PrevCloseVolume;
        PriceResolution PriceResolution;
        RoundLot RoundLot;
        Mpv Mpv;
        UnitOfTrade UnitOfTrade;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Symbol Index Mapping Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolIndexMappingRequestMessage {
        SymbolIndex SymbolIndex;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
        RetransmitMethod RetransmitMethod;
    };


    /// <summary>
    ///  Struct for Trading Session Change Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingSessionChangeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        TradingSession TradingSession;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
