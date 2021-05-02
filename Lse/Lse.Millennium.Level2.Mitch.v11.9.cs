namespace Lse.Millennium.Level2.Mitch.v11.9 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Amnd
    /// </summary>
    public unsafe struct Amnd {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Attribution
    /// </summary>
    public unsafe struct Attribution {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        ClosingAuction = (byte)'C',
        OpeningAuction = (byte)'O',
        Aesp = (byte)'A',
        Edsp = (byte)'B',
        ResumeAuction = (byte)'E',
        PeriodicAuction = (byte)'F',
        ScheduledLevel1OnlyAuction = (byte)'G',
    };


    /// <summary>
    ///  Book Type Values
    /// </summary>
    public enum BookType : byte {
        OnBook = 1,
        OffBook = 2,
        PrivateRfq = 3,
    };


    /// <summary>
    ///  Buy Limit Price
    /// </summary>
    public struct BuyLimitPrice {
        public long Raw;
    };


    /// <summary>
    ///  Buy Limit Size
    /// </summary>
    public unsafe struct BuyLimitSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Canc
    /// </summary>
    public unsafe struct Canc {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        Meaning = Value,
        InternalCross = 5,
        InternalBtf = 6,
        CommittedCross = 7,
        CommittedBtf = 8,
    };


    /// <summary>
    ///  Currency
    /// </summary>
    public unsafe struct Currency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Display Quantity
    /// </summary>
    public unsafe struct DisplayQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        EndOfDay = (byte)'C',
        StartOfDay = (byte)'O',
    };


    /// <summary>
    ///  Executed Quantity
    /// </summary>
    public unsafe struct ExecutedQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Firm Quote
    /// </summary>
    public unsafe struct FirmQuote {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Instrument Id
    /// </summary>
    public unsafe struct InstrumentId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Isin
    /// </summary>
    public unsafe struct Isin {
        public const int Size = 12;

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
    ///  Market Data Group
    /// </summary>
    public unsafe struct MarketDataGroup {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Order
    /// </summary>
    public unsafe struct MarketOrder {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
        TimeMessage = 0x54,
        SystemEventMessage = 0x53,
        SymbolDirectoryMessage = 0x52,
        SymbolStatusMessage = 0x48,
        AddOrderMessage = 0x41,
        AddAttributedOrderMessage = 0x46,
        OrderDeletedMessage = 0x44,
        OrderModifiedMessage = 0x55,
        OrderBookClearMessage = 0x79,
        OrderExecutedMessage = 0x45,
        OrderExecutedWithPriceSizeMessage = 0x43,
        TradeMessage = 0x50,
        AuctionTradeMessage = 0x51,
        AuctionInfoMessage = 0x49,
        StatisticsMessage = 0x77,
        TopOfBookMessage = 0x71,
    };


    /// <summary>
    ///  Nanosecond
    /// </summary>
    public unsafe struct Nanosecond {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New End Time
    /// </summary>
    public unsafe struct NewEndTime {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Price
    /// </summary>
    public struct NewPrice {
        public long Raw;
    };


    /// <summary>
    ///  New Quantity
    /// </summary>
    public unsafe struct NewQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Close Price Indicator Values
    /// </summary>
    public enum OpenClosePriceIndicator : byte {
        Meaning = (byte)'Value',
        Ut = (byte)'A',
        At = (byte)'B',
        MidOfBbo = (byte)'C',
        LastAt = (byte)'D',
        LastUt = (byte)'E',
        Manual = (byte)'F',
        DerivedFromPreviousClose = (byte)'I',
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public unsafe struct OrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Paired Quantity
    /// </summary>
    public unsafe struct PairedQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Previous Close Price
    /// </summary>
    public struct PreviousClosePrice {
        public long Raw;
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public long Raw;
    };


    /// <summary>
    ///  Printable Values
    /// </summary>
    public enum Printable : byte {
        NonPrintable = (byte)'N',
        Printable = (byte)'Y',
    };


    /// <summary>
    ///  Priority Flag
    /// </summary>
    public unsafe struct PriorityFlag {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Private Rfq
    /// </summary>
    public unsafe struct PrivateRfq {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Quantity
    /// </summary>
    public unsafe struct Quantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reason
    /// </summary>
    public unsafe struct Reason {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved A
    /// </summary>
    public unsafe struct ReservedA {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Alpha
    /// </summary>
    public unsafe struct ReservedAlpha {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved B
    /// </summary>
    public unsafe struct ReservedB {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Byte
    /// </summary>
    public unsafe struct ReservedByte {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Uint 32
    /// </summary>
    public unsafe struct ReservedUint32 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seconds
    /// </summary>
    public unsafe struct Seconds {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sedol
    /// </summary>
    public unsafe struct Sedol {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Segment
    /// </summary>
    public unsafe struct Segment {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sell Limit Price
    /// </summary>
    public struct SellLimitPrice {
        public long Raw;
    };


    /// <summary>
    ///  Sell Limit Size
    /// </summary>
    public unsafe struct SellLimitSize {
        public const int Size = 4;

        public int Value;

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
    ///  Session Change Reason Values
    /// </summary>
    public enum SessionChangeReason : byte {
        ScheduledTransition = 0,
        ExtendedByMarketOps = 1,
        ShortenedByMarketOps = 2,
        MarketOrderImbalance = 3,
        PriceOutsideRange = 4,
        UnavailableRecoveryServiceOnly = 9,
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        BuyOrder = (byte)'B',
        SellOrder = (byte)'S',
    };


    /// <summary>
    ///  Statistic Type Values
    /// </summary>
    public enum StatisticType : byte {
        OpeningPrice = (byte)'O',
        ClosingPrice = (byte)'C',
    };


    /// <summary>
    ///  Sub Book Values
    /// </summary>
    public enum SubBook : byte {
        RegularTrades = 0,
        RfqTrades = 11,
    };


    /// <summary>
    ///  Symbol Status Values
    /// </summary>
    public enum SymbolStatus : byte {
        Active = (byte)' ',
        Suspended = (byte)'S',
        Inactive = (byte)'a',
        Halt = (byte)'H',
    };


    /// <summary>
    ///  Trade Match Id
    /// </summary>
    public unsafe struct TradeMatchId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        Active = (byte)' ',
        Meaning = (byte)'Value',
        Halt = (byte)'H',
        RegularTradingStartOfTradeReporting = (byte)'T',
        OpeningFirstAuctionCall = (byte)'a',
        PostClose = (byte)'b',
        MarketCloseSystemShutdown = (byte)'c',
        ClosingAuctionCall = (byte)'d',
        AespAuctionCall = (byte)'e',
        ResumeAuctionCall = (byte)'f',
        Pause = (byte)'l',
        PreMandatory = (byte)'m',
        Mandatory = (byte)'n',
        PostMandatory = (byte)'o',
        EdspAuctionCall = (byte)'q',
        PeriodicAuctionCall = (byte)'r',
        EndTradeReporting = (byte)'t',
        NoActiveSession = (byte)'w',
        EndOfPostClose = (byte)'x',
        ClosingPriceCrossing = (byte)'u',
        ScheduledLevel1OnlyAuction = (byte)'G',
    };


    /// <summary>
    ///  Underlying
    /// </summary>
    public unsafe struct Underlying {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unused 1
    /// </summary>
    public unsafe struct Unused1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Unused 3
    /// </summary>
    public unsafe struct Unused3 {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Unused 6
    /// </summary>
    public unsafe struct Unused6 {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Attributed Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddAttributedOrderMessage {
        Nanosecond Nanosecond;
        OrderId OrderId;
        Side Side;
        Quantity Quantity;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        Price Price;
        Attribution Attribution;
        Flags Flags;
    };


    /// <summary>
    ///  Struct for Add Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessage {
        Nanosecond Nanosecond;
        OrderId OrderId;
        Side Side;
        Quantity Quantity;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        Price Price;
        Flags Flags;
        ReservedAlpha ReservedAlpha;
    };


    /// <summary>
    ///  Struct for Auction Info Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionInfoMessage {
        Nanosecond Nanosecond;
        PairedQuantity PairedQuantity;
        ReservedUint32 ReservedUint32;
        ReservedByte ReservedByte;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        Price Price;
        AuctionType AuctionType;
    };


    /// <summary>
    ///  Struct for Auction Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionTradeMessage {
        Nanosecond Nanosecond;
        Quantity Quantity;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        Price Price;
        TradeMatchId TradeMatchId;
        AuctionType AuctionType;
        PtModFlags PtModFlags;
    };


    /// <summary>
    ///  Struct for Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Flags {
        PriorityFlag PriorityFlag;
        Unused3 Unused3;
        MarketOrder MarketOrder;
        FirmQuote FirmQuote;
        PrivateRfq PrivateRfq;
        Unused1 Unused1;
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
    ///  Struct for Order Book Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderBookClearMessage {
        Nanosecond Nanosecond;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        Flags Flags;
    };


    /// <summary>
    ///  Struct for Order Deleted Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDeletedMessage {
        Nanosecond Nanosecond;
        OrderId OrderId;
        Flags Flags;
        InstrumentId InstrumentId;
    };


    /// <summary>
    ///  Struct for Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedMessage {
        Nanosecond Nanosecond;
        OrderId OrderId;
        ExecutedQuantity ExecutedQuantity;
        TradeMatchId TradeMatchId;
    };


    /// <summary>
    ///  Struct for Order Executed With Price Size Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedWithPriceSizeMessage {
        Nanosecond Nanosecond;
        OrderId OrderId;
        ExecutedQuantity ExecutedQuantity;
        DisplayQuantity DisplayQuantity;
        TradeMatchId TradeMatchId;
        Printable Printable;
        Price Price;
    };


    /// <summary>
    ///  Struct for Order Modified Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedMessage {
        Nanosecond Nanosecond;
        OrderId OrderId;
        NewQuantity NewQuantity;
        NewPrice NewPrice;
        Flags Flags;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        UnitHeader UnitHeader;
    };


    /// <summary>
    ///  Struct for Pt Mod Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PtModFlags {
        Canc Canc;
        Amnd Amnd;
        Unused6 Unused6;
    };


    /// <summary>
    ///  Struct for Statistics Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StatisticsMessage {
        Nanosecond Nanosecond;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        StatisticType StatisticType;
        Price Price;
        OpenClosePriceIndicator OpenClosePriceIndicator;
        ReservedByte ReservedByte;
    };


    /// <summary>
    ///  Struct for Symbol Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolDirectoryMessage {
        Nanosecond Nanosecond;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        SymbolStatus SymbolStatus;
        Isin Isin;
        Sedol Sedol;
        Segment Segment;
        Underlying Underlying;
        Currency Currency;
        ReservedByte ReservedByte;
        ReservedAlpha ReservedAlpha;
        PreviousClosePrice PreviousClosePrice;
    };


    /// <summary>
    ///  Struct for Symbol Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolStatusMessage {
        Nanosecond Nanosecond;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        TradingStatus TradingStatus;
        SymbolStatusFlags SymbolStatusFlags;
        Reason Reason;
        SessionChangeReason SessionChangeReason;
        NewEndTime NewEndTime;
        BookType BookType;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Nanosecond Nanosecond;
        EventCode EventCode;
    };


    /// <summary>
    ///  Struct for Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeMessage {
        Seconds Seconds;
    };


    /// <summary>
    ///  Struct for Top Of Book Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TopOfBookMessage {
        Nanosecond Nanosecond;
        InstrumentId InstrumentId;
        BuyLimitPrice BuyLimitPrice;
        BuyLimitSize BuyLimitSize;
        SellLimitPrice SellLimitPrice;
        SellLimitSize SellLimitSize;
    };


    /// <summary>
    ///  Struct for Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeMessage {
        Nanosecond Nanosecond;
        ExecutedQuantity ExecutedQuantity;
        InstrumentId InstrumentId;
        ReservedA ReservedA;
        ReservedB ReservedB;
        Price Price;
        TradeMatchId TradeMatchId;
        CrossType CrossType;
        SubBook SubBook;
        PtModFlags PtModFlags;
    };


    /// <summary>
    ///  Struct for Unit Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitHeader {
        Length Length;
        MessageCount MessageCount;
        MarketDataGroup MarketDataGroup;
        SequenceNumber SequenceNumber;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
