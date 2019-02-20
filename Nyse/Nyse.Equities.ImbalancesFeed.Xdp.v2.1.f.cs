namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction Status Values
    /// </summary>
    public enum AuctionStatus : byte {
        WillRunOpenClose = "0",
        WillRunInterest = "1",
        WillNotRunImbalance = "2",
        WillNotRunTransitionToClosing = "3",
    };


    /// <summary>
    ///  Auction Time
    /// </summary>
    public struct AuctionTime {
        public ushort Raw;
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
    public struct BeginSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public struct ChannelId {
        public byte Raw;
    };


    /// <summary>
    ///  Closing Only Clearing Price
    /// </summary>
    public struct ClosingOnlyClearingPrice {
        public uint Raw;
    };


    /// <summary>
    ///  Continuous Book Clearing Price
    /// </summary>
    public struct ContinuousBookClearingPrice {
        public uint Raw;
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
        NoImbalanceFreeze = "0",
        ImbalanceFreeze = "1",
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
    public struct IndicativeMatchPrice {
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
    ///  Lower Collar
    /// </summary>
    public struct LowerCollar {
        public uint Raw;
    };


    /// <summary>
    ///  Market Id
    /// </summary>
    public struct MarketId {
        public ushort Raw;
    };


    /// <summary>
    ///  Market Imbalance Qty
    /// </summary>
    public struct MarketImbalanceQty {
        public uint Raw;
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
        SymbolIndexMappingMessage = "3",
        RetransmissionRequestMessage = "10",
        RequestResponseMessage = "11",
        HeartbeatResponseMessage = "12",
        SymbolIndexMappingRequestMessage = "13",
        RefreshRequestMessage = "15",
        MessageUnavailableMessage = "31",
        SymbolClearMessage = "32",
        SecurityStatusMessage = "34",
        RefreshHeaderMessage = "35",
        ImbalanceMessage = "105",
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
    ///  Num Extensions
    /// </summary>
    public struct NumExtensions {
        public byte Raw;
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public struct PacketSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Paired Qty
    /// </summary>
    public struct PairedQty {
        public uint Raw;
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
    ///  Reference Price
    /// </summary>
    public struct ReferencePrice {
        public uint Raw;
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
    ///  Retransmit Method
    /// </summary>
    public struct RetransmitMethod {
        public byte Raw;
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
    public struct SequenceNumber {
        public uint Raw;
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
    ///  Ssr Filing Price
    /// </summary>
    public struct SsrFilingPrice {
        public uint Raw;
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
    public struct SsrTriggeringVolume {
        public uint Raw;
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
    ///  Total Imbalance Qty
    /// </summary>
    public struct TotalImbalanceQty {
        public uint Raw;
    };


    /// <summary>
    ///  Total Refresh Pkts
    /// </summary>
    public struct TotalRefreshPkts {
        public ushort Raw;
    };


    /// <summary>
    ///  Unit Of Trade
    /// </summary>
    public struct UnitOfTrade {
        public ushort Raw;
    };


    /// <summary>
    ///  Upper Collar
    /// </summary>
    public struct UpperCollar {
        public uint Raw;
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
