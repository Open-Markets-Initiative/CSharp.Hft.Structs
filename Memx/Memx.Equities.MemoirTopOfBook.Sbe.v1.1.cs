namespace Memx.Equities.MemoirTopOfBook.Sbe.v1.1 {

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
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Swap(ulong value)
            => unchecked((0x00000000000000FF) & (value >> 56) |
                         (0x000000000000FF00) & (value >> 40) |
                         (0x0000000000FF0000) & (value >> 24) |
                         (0x00000000FF000000) & (value >> 8)  |
                         (0x000000FF00000000) & (value << 8)  |
                         (0x0000FF0000000000) & (value << 24) |
                         (0x00FF000000000000) & (value << 40) |
                         (0xFF00000000000000) & (value << 56));
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  As Of Sequence Number
    /// </summary>
    public unsafe struct AsOfSequenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public struct BidPrice {
        public long Raw;
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Length
    /// </summary>
    public unsafe struct BlockLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Header Length
    /// </summary>
    public struct HeaderLength {
        public byte Raw;
    };


    /// <summary>
    ///  Is Test Symbol
    /// </summary>
    public unsafe struct IsTestSymbol {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        HeartbeatMessage = 0,
        SessionShutdownMessage = 1,
        SequencedMessage = 2,
    };


    /// <summary>
    ///  Mpv
    /// </summary>
    public struct Mpv {
        public long Raw;
    };


    /// <summary>
    ///  Offer Price
    /// </summary>
    public struct OfferPrice {
        public long Raw;
    };


    /// <summary>
    ///  Offer Size
    /// </summary>
    public unsafe struct OfferSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Round Lot
    /// </summary>
    public unsafe struct RoundLot {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public unsafe struct SchemaId {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public unsafe struct SecurityId {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Trading Status
    /// </summary>
    public unsafe struct SecurityTradingStatus {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Trading Status Reason
    /// </summary>
    public unsafe struct SecurityTradingStatusReason {
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
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Id
    /// </summary>
    public unsafe struct SessionId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Short Sale Restriction
    /// </summary>
    public unsafe struct ShortSaleRestriction {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Sfx
    /// </summary>
    public unsafe struct SymbolSfx {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : byte {
        InstrumentDirectoryMessage = 1,
        RegShoRestrictionMessage = 2,
        SecurityTradingStatusMessage = 3,
        SnapshotCompleteMessage = 4,
        TradingSessionStatusMessage = 5,
        BestBidOfferMessage = 10,
        BestBidMessage = 11,
        BestOfferMessage = 12,
        BestBidShortMessage = 13,
        BestOfferShortMessage = 14,
        ClearBookMessage = 15,
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Session
    /// </summary>
    public unsafe struct TradingSession {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Best Bid Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestBidMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        BidSize BidSize;
        BidPrice BidPrice;
    };


    /// <summary>
    ///  Struct for Best Bid Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestBidOfferMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        BidSize BidSize;
        BidPrice BidPrice;
        OfferSize OfferSize;
        OfferPrice OfferPrice;
    };


    /// <summary>
    ///  Struct for Best Bid Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestBidShortMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        BidSize BidSize;
        BidPrice BidPrice;
    };


    /// <summary>
    ///  Struct for Best Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestOfferMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        OfferSize OfferSize;
        OfferPrice OfferPrice;
    };


    /// <summary>
    ///  Struct for Best Offer Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestOfferShortMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        OfferSize OfferSize;
        OfferPrice OfferPrice;
    };


    /// <summary>
    ///  Struct for Clear Book Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClearBookMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
    };


    /// <summary>
    ///  Struct for Common Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CommonHeader {
        MessageType MessageType;
        HeaderLength HeaderLength;
        SessionId SessionId;
        SequenceNumber SequenceNumber;
    };


    /// <summary>
    ///  Struct for Instrument Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrumentDirectoryMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        RoundLot RoundLot;
        IsTestSymbol IsTestSymbol;
        Mpv Mpv;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageLength MessageLength;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        CommonHeader CommonHeader;
    };


    /// <summary>
    ///  Struct for Reg Sho Restriction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoRestrictionMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        ShortSaleRestriction ShortSaleRestriction;
    };


    /// <summary>
    ///  Struct for Sbe Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SbeHeader {
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Sbe Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SbeMessage {
        SbeHeader SbeHeader;
    };


    /// <summary>
    ///  Struct for Security Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityTradingStatusMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        SecurityTradingStatus SecurityTradingStatus;
        SecurityTradingStatusReason SecurityTradingStatusReason;
    };


    /// <summary>
    ///  Struct for Sequenced Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequencedMessage {
        MessageCount MessageCount;
    };


    /// <summary>
    ///  Struct for Snapshot Complete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotCompleteMessage {
        Timestamp Timestamp;
        AsOfSequenceNumber AsOfSequenceNumber;
    };


    /// <summary>
    ///  Struct for Trading Session Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingSessionStatusMessage {
        Timestamp Timestamp;
        TradingSession TradingSession;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
