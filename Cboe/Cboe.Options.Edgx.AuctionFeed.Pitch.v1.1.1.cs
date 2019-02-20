namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction End Offset
    /// </summary>
    public struct AuctionEndOffset {
        public uint Raw;
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public struct AuctionId {
        public ulong Raw;
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        BatsAuctionMechanism = (byte)'B',
        StepUpMechanism = (byte)'T',
    };


    /// <summary>
    ///  Contracts
    /// </summary>
    public struct Contracts {
        public uint Raw;
    };


    /// <summary>
    ///  Count
    /// </summary>
    public struct Count {
        public byte Raw;
    };


    /// <summary>
    ///  Customer Indicator Values
    /// </summary>
    public enum CustomerIndicator : byte {
        NonCustomer = (byte)'N',
        Customer = (byte)'C',
    };


    /// <summary>
    ///  Execution Id
    /// </summary>
    public struct ExecutionId {
        public ulong Raw;
    };


    /// <summary>
    ///  Feed Symbol
    /// </summary>
    public unsafe struct FeedSymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Length
    /// </summary>
    public struct Length {
        public ushort Raw;
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public struct MessageLength {
        public byte Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        TimeMessage = "0x20",
        UnitClearMessage = "0x97",
        AuctionNotificationMessage = "0xAD",
        AuctionCancelMessage = "0xAE",
        AuctionTradeMessage = "0xAF",
        SymbolMappingMessage = "0x2E",
        EndOfSessionMessage = "0x2D",
    };


    /// <summary>
    ///  Osi Symbol
    /// </summary>
    public unsafe struct OsiSymbol {
        public const int Size = 21;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Participant Id
    /// </summary>
    public unsafe struct ParticipantId {
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
        public ulong Raw;
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public struct Sequence {
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
    ///  Symbol Condition
    /// </summary>
    public unsafe struct SymbolCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Time
    /// </summary>
    public struct Time {
        public uint Raw;
    };


    /// <summary>
    ///  Time Offset
    /// </summary>
    public struct TimeOffset {
        public uint Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public uint Raw;
    };


    /// <summary>
    ///  Unit
    /// </summary>
    public struct Unit {
        public byte Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Auction Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionCancelMessage {
        TimeOffset TimeOffset;
        AuctionId AuctionId;
    };


    /// <summary>
    ///  Struct for Auction Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionNotificationMessage {
        TimeOffset TimeOffset;
        Symbol Symbol;
        AuctionId AuctionId;
        AuctionType AuctionType;
        Side Side;
        Price Price;
        Contracts Contracts;
        CustomerIndicator CustomerIndicator;
        ParticipantId ParticipantId;
        AuctionEndOffset AuctionEndOffset;
    };


    /// <summary>
    ///  Struct for Auction Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionTradeMessage {
        TimeOffset TimeOffset;
        AuctionId AuctionId;
        ExecutionId ExecutionId;
        Price Price;
        Contracts Contracts;
    };


    /// <summary>
    ///  Struct for End Of Session Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfSessionMessage {
        Timestamp Timestamp;
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
        MessageLength MessageLength;
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
        Length Length;
        Count Count;
        Unit Unit;
        Sequence Sequence;
    };


    /// <summary>
    ///  Struct for Symbol Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolMappingMessage {
        FeedSymbol FeedSymbol;
        OsiSymbol OsiSymbol;
        SymbolCondition SymbolCondition;
    };


    /// <summary>
    ///  Struct for Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeMessage {
        Time Time;
    };


    /// <summary>
    ///  Struct for Unit Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitClearMessage {
        TimeOffset TimeOffset;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
