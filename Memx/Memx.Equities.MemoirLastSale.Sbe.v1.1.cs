namespace Memx.Equities.MemoirLastSale.Sbe.v1.1 {

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
    ///  Corrected Sale Condition 1
    /// </summary>
    public unsafe struct CorrectedSaleCondition1 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Sale Condition 2
    /// </summary>
    public unsafe struct CorrectedSaleCondition2 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Sale Condition 3
    /// </summary>
    public unsafe struct CorrectedSaleCondition3 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Sale Condition 4
    /// </summary>
    public unsafe struct CorrectedSaleCondition4 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Trade Price
    /// </summary>
    public struct CorrectedTradePrice {
        public long Raw;
    };


    /// <summary>
    ///  Corrected Trade Qty
    /// </summary>
    public unsafe struct CorrectedTradeQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
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
    ///  Last Price
    /// </summary>
    public struct LastPrice {
        public long Raw;
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
    ///  Original Sale Condition 1
    /// </summary>
    public unsafe struct OriginalSaleCondition1 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Sale Condition 2
    /// </summary>
    public unsafe struct OriginalSaleCondition2 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Sale Condition 3
    /// </summary>
    public unsafe struct OriginalSaleCondition3 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Sale Condition 4
    /// </summary>
    public unsafe struct OriginalSaleCondition4 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Price
    /// </summary>
    public struct OriginalTradePrice {
        public long Raw;
    };


    /// <summary>
    ///  Original Trade Qty
    /// </summary>
    public unsafe struct OriginalTradeQty {
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
    ///  Sale Condition 1
    /// </summary>
    public unsafe struct SaleCondition1 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sale Condition 2
    /// </summary>
    public unsafe struct SaleCondition2 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sale Condition 3
    /// </summary>
    public unsafe struct SaleCondition3 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sale Condition 4
    /// </summary>
    public unsafe struct SaleCondition4 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
        TradingSessionStatusMessage = 5,
        TradeReportMessage = 10,
        TradeCancelMessage = 11,
        TradeCorrectMessage = 12,
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
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public struct TradePrice {
        public long Raw;
    };


    /// <summary>
    ///  Trade Qty
    /// </summary>
    public unsafe struct TradeQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
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
    ///  Struct for Trade Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        TradeId TradeId;
        TradeQty TradeQty;
        LastPrice LastPrice;
        SaleCondition1 SaleCondition1;
        SaleCondition2 SaleCondition2;
        SaleCondition3 SaleCondition3;
        SaleCondition4 SaleCondition4;
    };


    /// <summary>
    ///  Struct for Trade Correct Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCorrectMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        TradeId TradeId;
        OriginalTradeQty OriginalTradeQty;
        OriginalTradePrice OriginalTradePrice;
        OriginalSaleCondition1 OriginalSaleCondition1;
        OriginalSaleCondition2 OriginalSaleCondition2;
        OriginalSaleCondition3 OriginalSaleCondition3;
        OriginalSaleCondition4 OriginalSaleCondition4;
        CorrectedTradeQty CorrectedTradeQty;
        CorrectedTradePrice CorrectedTradePrice;
        CorrectedSaleCondition1 CorrectedSaleCondition1;
        CorrectedSaleCondition2 CorrectedSaleCondition2;
        CorrectedSaleCondition3 CorrectedSaleCondition3;
        CorrectedSaleCondition4 CorrectedSaleCondition4;
    };


    /// <summary>
    ///  Struct for Trade Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportMessage {
        Timestamp Timestamp;
        SecurityId SecurityId;
        TradeId TradeId;
        TradeQty TradeQty;
        TradePrice TradePrice;
        SaleCondition1 SaleCondition1;
        SaleCondition2 SaleCondition2;
        SaleCondition3 SaleCondition3;
        SaleCondition4 SaleCondition4;
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
