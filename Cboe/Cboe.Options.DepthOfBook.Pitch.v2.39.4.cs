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
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ulong value)
            => (0x00000000000000FF) & (value >> 56) |
               (0x000000000000FF00) & (value >> 40) |
               (0x0000000000FF0000) & (value >> 24) |
               (0x00000000FF000000) & (value >> 8)  |
               (0x000000FF00000000) & (value << 8)  |
               (0x0000FF0000000000) & (value << 24) |
               (0x00FF000000000000) & (value << 40) |
               (0xFF00000000000000) & (value << 56);
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

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
        Opening = (byte)'O',
        Closing = (byte)'C',
        Halt = (byte)'H',
        Ipo = (byte)'I',
        Close = (byte)'M',
        Sum = (byte)'T',
        Bam = (byte)'B',
    };


    /// <summary>
    ///  Buy Shares
    /// </summary>
    public struct BuyShares {
        public uint Raw;
    };


    /// <summary>
    ///  Canceled Long Quantity
    /// </summary>
    public struct CanceledLongQuantity {
        public uint Raw;
    };


    /// <summary>
    ///  Canceled Short Quantity
    /// </summary>
    public struct CanceledShortQuantity {
        public ushort Raw;
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
    ///  Display Values
    /// </summary>
    public enum Display : ulong {
        NotAggregated = "0",
        Aggregated = "1",
    };


    /// <summary>
    ///  Executed Quantity
    /// </summary>
    public struct ExecutedQuantity {
        public uint Raw;
    };


    /// <summary>
    ///  Execution Id
    /// </summary>
    public struct ExecutionId {
        public ulong Raw;
    };


    /// <summary>
    ///  Expanded Symbol
    /// </summary>
    public unsafe struct ExpandedSymbol {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Long Price
    /// </summary>
    public struct LongPrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Long Quantity
    /// </summary>
    public struct LongQuantity {
        public uint Raw;
    };


    /// <summary>
    ///  Maintain Priority Values
    /// </summary>
    public enum MaintainPriority : ulong {
        ResetPriority = "0",
        MaintainPriority = "1",
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
        AddOrderLongMessage = "0x21",
        AddOrderShortMessage = "0x22",
        AddOrderExpandedMessage = "0x2F",
        OrderExecutedMessage = "0x23",
        OrderExecutedAtPriceSizeMessage = "0x24",
        ReduceSizeLongMessage = "0x25",
        ReduceSizeShortMessage = "0x26",
        ModifyOrderLongMessage = "0x27",
        ModifyOrderShortMessage = "0x28",
        DeleteOrderMessage = "0x29",
        TradeLongMessage = "0x2A",
        TradeShortMessage = "0x2B",
        TradeExpandedMessage = "0x30",
        TradeBreakMessage = "0x2C",
        EndOfSessionMessage = "0x2D",
        SymbolMappingMessage = "0x2E",
        TradingStatusMessage = "0x31",
        AuctionUpdateMessage = "0x95",
        AuctionSummaryMessage = "0x96",
        AuctionNotificationMessage = "0xAD",
        AuctionCancelMessage = "0xAE",
        AuctionTradeMessage = "0xAF",
        RetailPriceImprovementMessage = "0x98",
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public struct OrderId {
        public ulong Raw;
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
    ///  Reference Price
    /// </summary>
    public struct ReferencePrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Reg Sho Action Values
    /// </summary>
    public enum RegShoAction : byte {
        NoPriceTestInEffect = (byte)'0',
        RegShoPriceTestRestrictionInEffect = (byte)'1',
    };


    /// <summary>
    ///  Remaining Quantity
    /// </summary>
    public struct RemainingQuantity {
        public uint Raw;
    };


    /// <summary>
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 2
    /// </summary>
    public unsafe struct Reserved2 {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 6
    /// </summary>
    public unsafe struct Reserved6 {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 7
    /// </summary>
    public unsafe struct Reserved7 {
        public const int Size = 7;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Retail Price Improvement Values
    /// </summary>
    public enum RetailPriceImprovement : byte {
        BuySide = (byte)'B',
        SellSide = (byte)'S',
        BuyAndSell = (byte)'A',
        NoRpi = (byte)'N',
    };


    /// <summary>
    ///  Sell Shares
    /// </summary>
    public struct SellShares {
        public uint Raw;
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public struct Sequence {
        public uint Raw;
    };


    /// <summary>
    ///  Shares
    /// </summary>
    public struct Shares {
        public uint Raw;
    };


    /// <summary>
    ///  Short Price
    /// </summary>
    public struct ShortPrice {
        public ushort Raw;
    };


    /// <summary>
    ///  Short Quantity
    /// </summary>
    public struct ShortQuantity {
        public ushort Raw;
    };


    /// <summary>
    ///  Side Indicator Values
    /// </summary>
    public enum SideIndicator : byte {
        BuyOrder = (byte)'B',
        SellOrder = (byte)'S',
    };


    /// <summary>
    ///  Stock Symbol
    /// </summary>
    public unsafe struct StockSymbol {
        public const int Size = 8;

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
        public const int Size = 6;

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
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        NormalTrade = (byte)'',
        SpreadTrade = (byte)'S',
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        AcceptingOrders = (byte)'A',
        Halted = (byte)'H',
        QuoteOnly = (byte)'Q',
        ExchangeSpecificSuspension = (byte)'S',
        Trading = (byte)'T',
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
    ///  Struct for Add Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddFlags {
        Reserved7 Reserved7;
        Display Display;
    };


    /// <summary>
    ///  Struct for Add Order Expanded Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderExpandedMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        LongQuantity LongQuantity;
        ExpandedSymbol ExpandedSymbol;
        LongPrice LongPrice;
        AddFlags AddFlags;
        ParticipantId ParticipantId;
        CustomerIndicator CustomerIndicator;
    };


    /// <summary>
    ///  Struct for Add Order Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        LongQuantity LongQuantity;
        Symbol Symbol;
        LongPrice LongPrice;
        AddFlags AddFlags;
    };


    /// <summary>
    ///  Struct for Add Order Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        ShortQuantity ShortQuantity;
        Symbol Symbol;
        ShortPrice ShortPrice;
        AddFlags AddFlags;
    };


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
        SideIndicator SideIndicator;
        LongPrice LongPrice;
        Contracts Contracts;
        CustomerIndicator CustomerIndicator;
        ParticipantId ParticipantId;
        AuctionEndOffset AuctionEndOffset;
    };


    /// <summary>
    ///  Struct for Auction Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionSummaryMessage {
        TimeOffset TimeOffset;
        StockSymbol StockSymbol;
        AuctionType AuctionType;
        LongPrice LongPrice;
        Shares Shares;
    };


    /// <summary>
    ///  Struct for Auction Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionTradeMessage {
        TimeOffset TimeOffset;
        AuctionId AuctionId;
        ExecutionId ExecutionId;
        LongPrice LongPrice;
        Contracts Contracts;
    };


    /// <summary>
    ///  Struct for Auction Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionUpdateMessage {
        TimeOffset TimeOffset;
        StockSymbol StockSymbol;
        AuctionType AuctionType;
        ReferencePrice ReferencePrice;
        BuyShares BuyShares;
        SellShares SellShares;
        IndicativePrice IndicativePrice;
        AuctionOnlyPrice AuctionOnlyPrice;
    };


    /// <summary>
    ///  Struct for Delete Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
    };


    /// <summary>
    ///  Struct for End Of Session Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfSessionMessage {
        TimeOffset TimeOffset;
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
    ///  Struct for Modify Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyFlags {
        Reserved6 Reserved6;
        MaintainPriority MaintainPriority;
        Display Display;
    };


    /// <summary>
    ///  Struct for Modify Order Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        LongQuantity LongQuantity;
        LongPrice LongPrice;
        ModifyFlags ModifyFlags;
    };


    /// <summary>
    ///  Struct for Modify Order Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        ShortQuantity ShortQuantity;
        ShortPrice ShortPrice;
        ModifyFlags ModifyFlags;
    };


    /// <summary>
    ///  Struct for Order Executed At Price Size Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedAtPriceSizeMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        ExecutedQuantity ExecutedQuantity;
        RemainingQuantity RemainingQuantity;
        ExecutionId ExecutionId;
        LongPrice LongPrice;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        ExecutedQuantity ExecutedQuantity;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
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
    ///  Struct for Reduce Size Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReduceSizeLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        CanceledLongQuantity CanceledLongQuantity;
    };


    /// <summary>
    ///  Struct for Reduce Size Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReduceSizeShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        CanceledShortQuantity CanceledShortQuantity;
    };


    /// <summary>
    ///  Struct for Retail Price Improvement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetailPriceImprovementMessage {
        TimeOffset TimeOffset;
        ExpandedSymbol ExpandedSymbol;
        RetailPriceImprovement RetailPriceImprovement;
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
    ///  Struct for Trade Break Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeBreakMessage {
        TimeOffset TimeOffset;
        ExecutionId ExecutionId;
    };


    /// <summary>
    ///  Struct for Trade Expanded Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeExpandedMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        LongQuantity LongQuantity;
        ExpandedSymbol ExpandedSymbol;
        LongPrice LongPrice;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trade Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        LongQuantity LongQuantity;
        Symbol Symbol;
        LongPrice LongPrice;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trade Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        ShortQuantity ShortQuantity;
        Symbol Symbol;
        ShortPrice ShortPrice;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingStatusMessage {
        TimeOffset TimeOffset;
        ExpandedSymbol ExpandedSymbol;
        TradingStatus TradingStatus;
        RegShoAction RegShoAction;
        Reserved1 Reserved1;
        Reserved2 Reserved2;
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
