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
    ///  Auction Only Price
    /// </summary>
    public struct AuctionOnlyPrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        AuctionInstructionMechanism = (byte)'B',
        SolicitationAuctionMechanism = (byte)'S',
        StepUpMechanism = (byte)'T',
        AllOrNone = (byte)'A',
    };


    /// <summary>
    ///  Buy Contracts
    /// </summary>
    public struct BuyContracts {
        public uint Raw;
    };


    /// <summary>
    ///  Client Id
    /// </summary>
    public unsafe struct ClientId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Indicative Price
    /// </summary>
    public struct IndicativePrice {
        public ulong Raw;
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
        AuctionUpdateMessage = "0xD1",
        AuctionSummaryMessage = "0x96",
        WidthUpdateMessage = "0xD2",
        SymbolMappingMessage = "0x2E",
        EndOfSessionMessage = "0x2D",
    };


    /// <summary>
    ///  Multiplier
    /// </summary>
    public struct Multiplier {
        public uint Raw;
    };


    /// <summary>
    ///  Opening Condition
    /// </summary>
    public unsafe struct OpeningCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opening Type Values
    /// </summary>
    public enum OpeningType : byte {
        GthOpening = (byte)'G',
        RthOpening = (byte)'O',
        HaltReopening = (byte)'H',
        VolatilityOpening = (byte)'V',
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
    ///  Quantity
    /// </summary>
    public struct Quantity {
        public uint Raw;
    };


    /// <summary>
    ///  Reference Price
    /// </summary>
    public struct ReferencePrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Sell Contracts
    /// </summary>
    public struct SellContracts {
        public uint Raw;
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
    ///  Symbol 6
    /// </summary>
    public unsafe struct Symbol6 {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol 8
    /// </summary>
    public unsafe struct Symbol8 {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Condition Values
    /// </summary>
    public enum SymbolCondition : byte {
        Normal = (byte)'N',
        ClosingOnly = (byte)'C',
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
    ///  Underlying
    /// </summary>
    public unsafe struct Underlying {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit
    /// </summary>
    public struct Unit {
        public byte Raw;
    };


    /// <summary>
    ///  Width Type Values
    /// </summary>
    public enum WidthType : byte {
        Regular = (byte)'R',
        Volatility = (byte)'V',
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
        Symbol6 Symbol6;
        AuctionId AuctionId;
        AuctionType AuctionType;
        Side Side;
        Price Price;
        Contracts Contracts;
        CustomerIndicator CustomerIndicator;
        ParticipantId ParticipantId;
        AuctionEndOffset AuctionEndOffset;
        ClientId ClientId;
    };


    /// <summary>
    ///  Struct for Auction Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionSummaryMessage {
        TimeOffset TimeOffset;
        Symbol8 Symbol8;
        OpeningType OpeningType;
        Price Price;
        Quantity Quantity;
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
    ///  Struct for Auction Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionUpdateMessage {
        TimeOffset TimeOffset;
        Symbol8 Symbol8;
        OpeningType OpeningType;
        ReferencePrice ReferencePrice;
        BuyContracts BuyContracts;
        SellContracts SellContracts;
        IndicativePrice IndicativePrice;
        AuctionOnlyPrice AuctionOnlyPrice;
        OpeningCondition OpeningCondition;
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
        Underlying Underlying;
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


    /// <summary>
    ///  Struct for Width Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WidthUpdateMessage {
        TimeOffset TimeOffset;
        Underlying Underlying;
        WidthType WidthType;
        Multiplier Multiplier;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
