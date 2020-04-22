namespace Nyse.Equities.OpenBook.Ultra.v2.1.b {

    #region Methods
    ///////////////////////////////////////////////////////////////////////

    public static class Endian {

        /// <summary>
        ///  Swap byte order for 2 byte unsigned short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Swap(ushort value)
            => unchecked(value << 8 | value >> 8);
        
        /// <summary>
        ///  Swap byte order in unsigned integer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(uint value)
            => unchecked((value & 0x000000FF) << 24 |
                         (value & 0x0000FF00) << 8  |
                         (value & 0x00FF0000) >> 8  |
                         (value & 0xFF000000) >> 24);
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Chg Qty
    /// </summary>
    public struct ChgQty {
        public int Raw;
    };


    /// <summary>
    ///  Delta Size
    /// </summary>
    public struct DeltaSize {
        public short Raw;
    };


    /// <summary>
    ///  Link Flag
    /// </summary>
    public struct LinkFlag {
        public byte Raw;
    };


    /// <summary>
    ///  Link Id 1
    /// </summary>
    public struct LinkId1 {
        public int Raw;
    };


    /// <summary>
    ///  Link Id 2
    /// </summary>
    public struct LinkId2 {
        public int Raw;
    };


    /// <summary>
    ///  Link Id 3
    /// </summary>
    public struct LinkId3 {
        public int Raw;
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public struct MessageCount {
        public byte Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : ushort {
        FullUpdateMessage = 230,
        DeltaUpdateMessage = 231,
        SequenceNumberResetMessage = 1,
        HeartbeatMessage = 2,
    };


    /// <summary>
    ///  Mpv
    /// </summary>
    public struct Mpv {
        public short Raw;
    };


    /// <summary>
    ///  Next Sequence Number
    /// </summary>
    public struct NextSequenceNumber {
        public int Raw;
    };


    /// <summary>
    ///  Num Orders
    /// </summary>
    public struct NumOrders {
        public short Raw;
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public unsafe struct PacketSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Numerator
    /// </summary>
    public struct PriceNumerator {
        public int Raw;
    };


    /// <summary>
    ///  Price Scale Code
    /// </summary>
    public struct PriceScaleCode {
        public sbyte Raw;
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public unsafe struct ProductId {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        NoSpecialQuoteCondition = (byte)' ',
        SlowQuote = (byte)'W',
    };


    /// <summary>
    ///  Reason Code Values
    /// </summary>
    public enum ReasonCode : byte {
        NewOrderadditionalInterestAdded = (byte)'O',
        Cancel = (byte)'C',
        Execution = (byte)'E',
        MultipleEvents = (byte)'X',
    };


    /// <summary>
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Retransmission Flag
    /// </summary>
    public struct RetransmissionFlag {
        public byte Raw;
    };


    /// <summary>
    ///  Sequence Number
    /// </summary>
    public unsafe struct SequenceNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
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
    ///  Source Seq Num
    /// </summary>
    public struct SourceSeqNum {
        public int Raw;
    };


    /// <summary>
    ///  Source Session Id
    /// </summary>
    public struct SourceSessionId {
        public sbyte Raw;
    };


    /// <summary>
    ///  Source Time
    /// </summary>
    public struct SourceTime {
        public int Raw;
    };


    /// <summary>
    ///  Source Time Micro Secs
    /// </summary>
    public struct SourceTimeMicroSecs {
        public short Raw;
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
        public int Raw;
    };


    /// <summary>
    ///  Symbol Seq Num
    /// </summary>
    public struct SymbolSeqNum {
        public int Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        PreOpening = (byte)'P',
        CoreSession = (byte)'O',
        Closed = (byte)'X',
        Halted = (byte)'H',
    };


    /// <summary>
    ///  Update Size
    /// </summary>
    public struct UpdateSize {
        public short Raw;
    };


    /// <summary>
    ///  Volume
    /// </summary>
    public struct Volume {
        public int Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Delta Price Point
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeltaPricePoint {
        PriceNumerator PriceNumerator;
        Volume Volume;
        ChgQty ChgQty;
        NumOrders NumOrders;
        Side Side;
        ReasonCode ReasonCode;
        LinkId1 LinkId1;
        LinkId2 LinkId2;
        LinkId3 LinkId3;
    };


    /// <summary>
    ///  Struct for Delta Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeltaUpdateMessage {
        DeltaSize DeltaSize;
        SymbolIndex SymbolIndex;
        SourceTime SourceTime;
        SourceTimeMicroSecs SourceTimeMicroSecs;
        SourceSeqNum SourceSeqNum;
        SourceSessionId SourceSessionId;
        QuoteCondition QuoteCondition;
        TradingStatus TradingStatus;
        PriceScaleCode PriceScaleCode;
    };


    /// <summary>
    ///  Struct for Delta Update Messages
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeltaUpdateMessages {
    };


    /// <summary>
    ///  Struct for Full Price Point
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FullPricePoint {
        PriceNumerator PriceNumerator;
        Volume Volume;
        NumOrders NumOrders;
        Side Side;
        Reserved1 Reserved1;
    };


    /// <summary>
    ///  Struct for Full Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FullUpdateMessage {
        UpdateSize UpdateSize;
        SymbolIndex SymbolIndex;
        SourceTime SourceTime;
        SourceTimeMicroSecs SourceTimeMicroSecs;
        SymbolSeqNum SymbolSeqNum;
        SourceSessionId SourceSessionId;
        Symbol Symbol;
        PriceScaleCode PriceScaleCode;
        QuoteCondition QuoteCondition;
        TradingStatus TradingStatus;
        Reserved1 Reserved1;
        Mpv Mpv;
    };


    /// <summary>
    ///  Struct for Full Update Messages
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FullUpdateMessages {
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        PacketSize PacketSize;
        MessageType MessageType;
        SequenceNumber SequenceNumber;
        Timestamp Timestamp;
        ProductId ProductId;
        RetransmissionFlag RetransmissionFlag;
        MessageCount MessageCount;
        LinkFlag LinkFlag;
    };


    /// <summary>
    ///  Struct for Sequence Number Reset Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequenceNumberResetMessage {
        NextSequenceNumber NextSequenceNumber;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
