namespace Cboe.Edgx.Options.AuctionFeed.Pitch.v1.1.1 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction End Offset
    /// </summary>
    public unsafe struct AuctionEndOffset {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public unsafe struct AuctionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct Contracts {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Count
    /// </summary>
    public unsafe struct Count {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct ExecutionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    public unsafe struct Length {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        TimeMessage = 0x20,
        UnitClearMessage = 0x97,
        AuctionNotificationMessage = 0xAD,
        AuctionCancelMessage = 0xAE,
        AuctionTradeMessage = 0xAF,
        SymbolMappingMessage = 0x2E,
        EndOfSessionMessage = 0x2D,
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
    public unsafe struct Price {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public unsafe struct Sequence {
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
    public unsafe struct Time {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Time Offset
    /// </summary>
    public unsafe struct TimeOffset {
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
    ///  Unit
    /// </summary>
    public unsafe struct Unit {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
