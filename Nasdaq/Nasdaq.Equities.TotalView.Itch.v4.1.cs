namespace Nasdaq.Equities.TotalView.Itch.v4.1 {

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
    ///  Attribution
    /// </summary>
    public unsafe struct Attribution {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Canceled Shares
    /// </summary>
    public unsafe struct CanceledShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Count
    /// </summary>
    public unsafe struct Count {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Price
    /// </summary>
    public unsafe struct CrossPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Shares
    /// </summary>
    public unsafe struct CrossShares {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        Opening = (byte)'O',
        Closing = (byte)'C',
        CrossForIpoAndHalted = (byte)'H',
        NasdaqCrossNetwork = (byte)'I',
    };


    /// <summary>
    ///  Current Reference Price
    /// </summary>
    public unsafe struct CurrentReferencePrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfMessages = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfMarketHours = (byte)'Q',
        EndOfMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
        EndOfMessage = (byte)'C',
        Halt = (byte)'A',
        QuoteOnlyPeriod = (byte)'R',
        Resumption = (byte)'B',
    };


    /// <summary>
    ///  Executed Shares
    /// </summary>
    public unsafe struct ExecutedShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Execution Price
    /// </summary>
    public unsafe struct ExecutionPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Far Price
    /// </summary>
    public unsafe struct FarPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        Delinquent = (byte)'D',
        Deficient = (byte)'E',
        Bankrupt = (byte)'Q',
        Suspended = (byte)'S',
        DeficientAndBankrupt = (byte)'G',
        DeficientAndDelinquent = (byte)'H',
        DelinquentAndBankrupt = (byte)'J',
        DeficientDelinquentAndBankrupt = (byte)'K',
    };


    /// <summary>
    ///  Imbalance Direction Values
    /// </summary>
    public enum ImbalanceDirection : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        No = (byte)'N',
        InsufficientOrders = (byte)'O',
    };


    /// <summary>
    ///  Imbalance Shares
    /// </summary>
    public unsafe struct ImbalanceShares {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Interest Flag Values
    /// </summary>
    public enum InterestFlag : byte {
        RpiBuy = (byte)'B',
        RpiSell = (byte)'S',
        RpiBoth = (byte)'A',
        NoRpi = (byte)'N',
    };


    /// <summary>
    ///  Length
    /// </summary>
    public unsafe struct Length {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Category Values
    /// </summary>
    public enum MarketCategory : byte {
        Nyse = (byte)'N',
        Amex = (byte)'A',
        Arca = (byte)'P',
        NasdaqGsm = (byte)'Q',
        NasdaqGm = (byte)'G',
        NasdaqCm = (byte)'G',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Market Maker Mode Values
    /// </summary>
    public enum MarketMakerMode : byte {
        Normal = (byte)'N',
        Passive = (byte)'P',
        Syndicate = (byte)'S',
        Penalty = (byte)'L',
    };


    /// <summary>
    ///  Market Participant State Values
    /// </summary>
    public enum MarketParticipantState : byte {
        Active = (byte)'A',
        ExcusedWithdrawn = (byte)'E',
        Withdrawn = (byte)'W',
        Suspended = (byte)'S',
        Deleted = (byte)'D',
    };


    /// <summary>
    ///  Match Number
    /// </summary>
    public unsafe struct MatchNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        TimeStampMessage = (byte)'T',
        SystemEventMessage = (byte)'S',
        StockDirectoryMessage = (byte)'R',
        RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
        MarketParticipantPositionMessage = (byte)'L',
        AddOrderMessage = (byte)'A',
        AddOrderWithMpidMessage = (byte)'F',
        OrderExecutedMessage = (byte)'E',
        OrderExecutedWithPriceMessage = (byte)'C',
        OrderCancelMessage = (byte)'X',
        OrderDeleteMessage = (byte)'D',
        OrderReplaceMessage = (byte)'D',
        TradeMessage = (byte)'P',
        CrossTradeMessage = (byte)'Q',
        BrokenTradeMessage = (byte)'B',
        NetOrderImbalanceIndicatorMessage = (byte)'I',
        RetailPriceImprovementIndicatorMessage = (byte)'N',
    };


    /// <summary>
    ///  Mpid
    /// </summary>
    public unsafe struct Mpid {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Near Price
    /// </summary>
    public unsafe struct NearPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Order Reference Number
    /// </summary>
    public unsafe struct NewOrderReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Reference Number
    /// </summary>
    public unsafe struct OrderReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Order Reference Number
    /// </summary>
    public unsafe struct OriginalOrderReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Paired Shares
    /// </summary>
    public unsafe struct PairedShares {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Variation Indicator Values
    /// </summary>
    public enum PriceVariationIndicator : byte {
        Less = (byte)'L',
        1To199 = (byte)'1',
        2To299 = (byte)'2',
        3To399 = (byte)'3',
        4To499 = (byte)'4',
        5To599 = (byte)'5',
        6To699 = (byte)'6',
        7To799 = (byte)'7',
        8To899 = (byte)'8',
        9To999 = (byte)'9',
        10To1999 = (byte)'A',
        20To2999 = (byte)'B',
        30OrGreater = (byte)'C',
        NoCalculation = (byte)' ',
    };


    /// <summary>
    ///  Primary Market Maker Values
    /// </summary>
    public enum PrimaryMarketMaker : byte {
        Primary = (byte)'Y',
        Nonprimary = (byte)'N',
    };


    /// <summary>
    ///  Printable Values
    /// </summary>
    public enum Printable : byte {
        Nonprintable = (byte)'N',
        Printable = (byte)'Y',
    };


    /// <summary>
    ///  Reg Sho Action Values
    /// </summary>
    public enum RegShoAction : byte {
        NoPrice = (byte)'0',
        RegShoShortSalePriceTestRestriction = (byte)'1',
        RegShoShortSalePriceTest = (byte)'2',
    };


    /// <summary>
    ///  Second
    /// </summary>
    public unsafe struct Second {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public unsafe struct Sequence {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session
    /// </summary>
    public unsafe struct Session {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Shares
    /// </summary>
    public unsafe struct Shares {
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
    ///  Stock
    /// </summary>
    public unsafe struct Stock {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Timestamp Nanoseconds
    /// </summary>
    public unsafe struct TimestampNanoseconds {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        Side Side;
        Shares Shares;
        Stock Stock;
        Price Price;
    };


    /// <summary>
    ///  Struct for Add Order With Mpid Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderWithMpidMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        Side Side;
        Shares Shares;
        Stock Stock;
        Price Price;
        Attribution Attribution;
    };


    /// <summary>
    ///  Struct for Broken Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeMessage {
        Timestamp Timestamp;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossTradeMessage {
        Timestamp Timestamp;
        CrossShares CrossShares;
        Stock Stock;
        CrossPrice CrossPrice;
        MatchNumber MatchNumber;
        CrossType CrossType;
    };


    /// <summary>
    ///  Struct for Market Participant Position Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketParticipantPositionMessage {
        Timestamp Timestamp;
        Mpid Mpid;
        Stock Stock;
        PrimaryMarketMaker PrimaryMarketMaker;
        MarketMakerMode MarketMakerMode;
        MarketParticipantState MarketParticipantState;
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
        Length Length;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Net Order Imbalance Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetOrderImbalanceIndicatorMessage {
        Timestamp Timestamp;
        PairedShares PairedShares;
        ImbalanceShares ImbalanceShares;
        ImbalanceDirection ImbalanceDirection;
        Stock Stock;
        FarPrice FarPrice;
        NearPrice NearPrice;
        CurrentReferencePrice CurrentReferencePrice;
        CrossType CrossType;
        PriceVariationIndicator PriceVariationIndicator;
    };


    /// <summary>
    ///  Struct for Order Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        CanceledShares CanceledShares;
    };


    /// <summary>
    ///  Struct for Order Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDeleteMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
    };


    /// <summary>
    ///  Struct for Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        ExecutedShares ExecutedShares;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Order Executed With Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedWithPriceMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        ExecutedShares ExecutedShares;
        MatchNumber MatchNumber;
        Printable Printable;
        ExecutionPrice ExecutionPrice;
    };


    /// <summary>
    ///  Struct for Order Replace Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderReplaceMessage {
        TimestampNanoseconds TimestampNanoseconds;
        OriginalOrderReferenceNumber OriginalOrderReferenceNumber;
        NewOrderReferenceNumber NewOrderReferenceNumber;
        Shares Shares;
        Price Price;
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
        Session Session;
        Sequence Sequence;
        Count Count;
    };


    /// <summary>
    ///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
        Timestamp Timestamp;
        Stock Stock;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Retail Price Improvement Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetailPriceImprovementIndicatorMessage {
        Timestamp Timestamp;
        Stock Stock;
        InterestFlag InterestFlag;
    };


    /// <summary>
    ///  Struct for Stock Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockDirectoryMessage {
        Timestamp Timestamp;
        Stock Stock;
        MarketCategory MarketCategory;
        FinancialStatusIndicator FinancialStatusIndicator;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Timestamp Timestamp;
        EventCode EventCode;
    };


    /// <summary>
    ///  Struct for Time Stamp Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeStampMessage {
        Second Second;
    };


    /// <summary>
    ///  Struct for Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeMessage {
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        Side Side;
        Shares Shares;
        Stock Stock;
        Price Price;
        MatchNumber MatchNumber;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
