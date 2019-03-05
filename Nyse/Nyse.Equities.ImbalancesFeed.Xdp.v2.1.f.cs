namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction Status Values
    /// </summary>
    public enum AuctionStatus : byte {
        WillRunOpenClose = 0,
        WillRunInterest = 1,
        WillNotRunImbalance = 2,
        WillNotRunTransitionToClosing = 3,
    };


    /// <summary>
    ///  Auction Time
    /// </summary>
    public unsafe struct AuctionTime {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        EarlyOpening = (byte)'O',
        CoreOpening = (byte)'M',
        Reopening = (byte)'H',
        Closing = (byte)'C',
        RegulatoryImbalance = (byte)'R',
    };


    /// <summary>
    ///  Begin Seq Num
    /// </summary>
    public unsafe struct BeginSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Closing Only Clearing Price
    /// </summary>
    public unsafe struct ClosingOnlyClearingPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Continuous Book Clearing Price
    /// </summary>
    public unsafe struct ContinuousBookClearingPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Current Refresh Pkt
    /// </summary>
    public unsafe struct CurrentRefreshPkt {
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
    ///  End Seq Num
    /// </summary>
    public unsafe struct EndSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exchange Code
    /// </summary>
    public unsafe struct ExchangeCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Freeze Status Values
    /// </summary>
    public enum FreezeStatus : byte {
        NoImbalanceFreeze = 0,
        ImbalanceFreeze = 1,
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
    ///  Imbalance Side Values
    /// </summary>
    public enum ImbalanceSide : byte {
        NoImbalance = (byte)' ',
        BuySide = (byte)'B',
        SellSide = (byte)'S',
    };


    /// <summary>
    ///  Indicative Match Price
    /// </summary>
    public unsafe struct IndicativeMatchPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Seq Num
    /// </summary>
    public unsafe struct LastSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Symbol Seq Num
    /// </summary>
    public unsafe struct LastSymbolSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lot Size
    /// </summary>
    public unsafe struct LotSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lower Collar
    /// </summary>
    public unsafe struct LowerCollar {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Id
    /// </summary>
    public unsafe struct MarketId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Imbalance Qty
    /// </summary>
    public unsafe struct MarketImbalanceQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market State
    /// </summary>
    public unsafe struct MarketState {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
        SequenceNumberResetMessage = 1,
        SymbolIndexMappingMessage = 3,
        RetransmissionRequestMessage = 10,
        RequestResponseMessage = 11,
        HeartbeatResponseMessage = 12,
        SymbolIndexMappingRequestMessage = 13,
        RefreshRequestMessage = 15,
        MessageUnavailableMessage = 31,
        SymbolClearMessage = 32,
        SecurityStatusMessage = 34,
        RefreshHeaderMessage = 35,
        ImbalanceMessage = 105,
    };


    /// <summary>
    ///  Mpv
    /// </summary>
    public unsafe struct Mpv {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Next Source Seq Num
    /// </summary>
    public unsafe struct NextSourceSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Extensions
    /// </summary>
    public unsafe struct NumExtensions {
        public const int Size = 1;

        public sbyte Value;

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
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Prev Close Price
    /// </summary>
    public unsafe struct PrevClosePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Prev Close Volume
    /// </summary>
    public unsafe struct PrevCloseVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price 1
    /// </summary>
    public unsafe struct Price1 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price 2
    /// </summary>
    public unsafe struct Price2 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Resolution
    /// </summary>
    public unsafe struct PriceResolution {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Reference Price
    /// </summary>
    public unsafe struct ReferencePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Request Seq Num
    /// </summary>
    public unsafe struct RequestSeqNum {
        public const int Size = 4;

        public int Value;

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
    ///  Retransmit Method
    /// </summary>
    public unsafe struct RetransmitMethod {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Round Lot
    /// </summary>
    public unsafe struct RoundLot {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Status
    /// </summary>
    public unsafe struct SecurityStatus {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Type
    /// </summary>
    public unsafe struct SecurityType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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
    ///  Session State
    /// </summary>
    public unsafe struct SessionState {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Ssr Filing Price
    /// </summary>
    public unsafe struct SsrFilingPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ssr State
    /// </summary>
    public unsafe struct SsrState {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ssr Triggering Exchange Id
    /// </summary>
    public unsafe struct SsrTriggeringExchangeId {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ssr Triggering Volume
    /// </summary>
    public unsafe struct SsrTriggeringVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Status
    /// </summary>
    public unsafe struct Status {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    public unsafe struct SymbolIndex {
        public const int Size = 4;

        public int Value;

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
    ///  Time
    /// </summary>
    public unsafe struct Time {
        public const int Size = 4;

        public int Value;

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
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Refresh Pkts
    /// </summary>
    public unsafe struct TotalRefreshPkts {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Trade
    /// </summary>
    public unsafe struct UnitOfTrade {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Upper Collar
    /// </summary>
    public unsafe struct UpperCollar {
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
    ///  Struct for Heartbeat Response Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HeartbeatResponseMessage {
        SourceId SourceId;
    };


    /// <summary>
    ///  Struct for Imbalance Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ImbalanceMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        ReferencePrice ReferencePrice;
        PairedQty PairedQty;
        TotalImbalanceQty TotalImbalanceQty;
        MarketImbalanceQty MarketImbalanceQty;
        AuctionTime AuctionTime;
        AuctionType AuctionType;
        ImbalanceSide ImbalanceSide;
        ContinuousBookClearingPrice ContinuousBookClearingPrice;
        ClosingOnlyClearingPrice ClosingOnlyClearingPrice;
        SsrFilingPrice SsrFilingPrice;
        IndicativeMatchPrice IndicativeMatchPrice;
        UpperCollar UpperCollar;
        LowerCollar LowerCollar;
        AuctionStatus AuctionStatus;
        FreezeStatus FreezeStatus;
        NumExtensions NumExtensions;
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


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
