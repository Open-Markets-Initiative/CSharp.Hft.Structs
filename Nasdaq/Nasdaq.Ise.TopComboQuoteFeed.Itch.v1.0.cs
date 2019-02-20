namespace MyNamespace {

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
    ///  Ask Cust Size
    /// </summary>
    public unsafe struct AskCustSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Market Size
    /// </summary>
    public unsafe struct AskMarketSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Ntt Market Size
    /// </summary>
    public unsafe struct AskNttMarketSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Ntt Size
    /// </summary>
    public unsafe struct AskNttSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Price
    /// </summary>
    public unsafe struct AskPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Pro Cust Size
    /// </summary>
    public unsafe struct AskProCustSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Size
    /// </summary>
    public unsafe struct AskSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Cust Size
    /// </summary>
    public unsafe struct BidCustSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Market Size
    /// </summary>
    public unsafe struct BidMarketSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Ntt Market Size
    /// </summary>
    public unsafe struct BidNttMarketSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Ntt Size
    /// </summary>
    public unsafe struct BidNttSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public unsafe struct BidPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Pro Cust Size
    /// </summary>
    public unsafe struct BidProCustSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Current Day
    /// </summary>
    public struct CurrentDay {
        public byte Raw;
    };


    /// <summary>
    ///  Current Month
    /// </summary>
    public struct CurrentMonth {
        public byte Raw;
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        HaltInEffect = (byte)'H',
        TradingResumed = (byte)'T',
    };


    /// <summary>
    ///  Current Year
    /// </summary>
    public unsafe struct CurrentYear {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cust Size
    /// </summary>
    public unsafe struct CustSize {
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
        StartOfOpeningProcess = (byte)'Q',
        StartOfNormalHoursClosingProcess = (byte)'N',
        StartOfLateHoursClosingProcess = (byte)'L',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
        EndOfWcoEarlyClosing = (byte)'W',
    };


    /// <summary>
    ///  Expiration Day
    /// </summary>
    public struct ExpirationDay {
        public byte Raw;
    };


    /// <summary>
    ///  Expiration Month
    /// </summary>
    public struct ExpirationMonth {
        public byte Raw;
    };


    /// <summary>
    ///  Expiration Year
    /// </summary>
    public struct ExpirationYear {
        public byte Raw;
    };


    /// <summary>
    ///  Explicit Strike Price
    /// </summary>
    public unsafe struct ExplicitStrikePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  First
    /// </summary>
    public unsafe struct First {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High
    /// </summary>
    public unsafe struct High {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Price
    /// </summary>
    public unsafe struct LastPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Id
    /// </summary>
    public struct LegId {
        public byte Raw;
    };


    /// <summary>
    ///  Leg Ratio
    /// </summary>
    public unsafe struct LegRatio {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Low
    /// </summary>
    public unsafe struct Low {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Size
    /// </summary>
    public unsafe struct MarketSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        ComplexStrategyDirectoryMessage = (byte)'R',
        StrategyOpenClosedMessage = (byte)'O',
        StrategyTradingActionMessage = (byte)'H',
        StrategyBestBidAndAskUpdate = (byte)'C',
        StrategyBestBidUpdate = (byte)'D',
        StrategyBestAskUpdate = (byte)'E',
        ComplexStrategyTickerMessage = (byte)'t',
    };


    /// <summary>
    ///  Ntt Market Size
    /// </summary>
    public unsafe struct NttMarketSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ntt Size
    /// </summary>
    public unsafe struct NttSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Legs
    /// </summary>
    public struct NumberOfLegs {
        public byte Raw;
    };


    /// <summary>
    ///  Open State Values
    /// </summary>
    public enum OpenState : byte {
        Open = (byte)'Y',
        Closed = (byte)'N',
    };


    /// <summary>
    ///  Option Id
    /// </summary>
    public unsafe struct OptionId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Option Type Values
    /// </summary>
    public enum OptionType : byte {
        Call = (byte)'C',
        Put = (byte)'P',
        Na = (byte)' ',
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
    ///  Pro Cust Size
    /// </summary>
    public unsafe struct ProCustSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        RegularQuote = (byte)' ',
        Halted = (byte)'X',
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        Hidden = (byte)'',
    };


    /// <summary>
    ///  Size
    /// </summary>
    public unsafe struct Size {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source
    /// </summary>
    public struct Source {
        public byte Raw;
    };


    /// <summary>
    ///  Strategy Id
    /// </summary>
    public unsafe struct StrategyId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Type Values
    /// </summary>
    public enum StrategyType : byte {
        VerticalSpread = (byte)'V',
        TimeSpread = (byte)'T',
        DiagonalSpread = (byte)'D',
        Straddle = (byte)'S',
        Strangle = (byte)'G',
        Combo = (byte)'C',
        RiskReversal = (byte)'R',
        RatioSpread = (byte)'A',
        Custom = (byte)'U',
    };


    /// <summary>
    ///  Subversion
    /// </summary>
    public struct Subversion {
        public byte Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public ulong Raw;
    };


    /// <summary>
    ///  Trade Condition
    /// </summary>
    public unsafe struct TradeCondition {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 13;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public struct Version {
        public byte Raw;
    };


    /// <summary>
    ///  Volume
    /// </summary>
    public unsafe struct Volume {
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
    ///  Struct for Complex Strategy Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyDirectoryMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        StrategyType StrategyType;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        NumberOfLegs NumberOfLegs;
    };


    /// <summary>
    ///  Struct for Complex Strategy Ticker Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyTickerMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        LastPrice LastPrice;
        Size Size;
        Volume Volume;
        High High;
        Low Low;
        First First;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Leg Information
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegInformation {
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        LegId LegId;
        ExpirationYear ExpirationYear;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        Side Side;
        LegRatio LegRatio;
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
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        Session Session;
        Sequence Sequence;
        Count Count;
    };


    /// <summary>
    ///  Struct for Strategy Best Ask Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyBestAskUpdate {
        Timestamp Timestamp;
        StrategyId StrategyId;
        QuoteCondition QuoteCondition;
        Price Price;
        Size Size;
        CustSize CustSize;
        ProCustSize ProCustSize;
        NttSize NttSize;
        MarketSize MarketSize;
        NttMarketSize NttMarketSize;
    };


    /// <summary>
    ///  Struct for Strategy Best Bid And Ask Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyBestBidAndAskUpdate {
        Timestamp Timestamp;
        StrategyId StrategyId;
        QuoteCondition QuoteCondition;
        BidPrice BidPrice;
        BidSize BidSize;
        BidCustSize BidCustSize;
        BidProCustSize BidProCustSize;
        BidNttSize BidNttSize;
        BidMarketSize BidMarketSize;
        BidNttMarketSize BidNttMarketSize;
        AskPrice AskPrice;
        AskSize AskSize;
        AskCustSize AskCustSize;
        AskProCustSize AskProCustSize;
        AskNttSize AskNttSize;
        AskMarketSize AskMarketSize;
        AskNttMarketSize AskNttMarketSize;
    };


    /// <summary>
    ///  Struct for Strategy Best Bid Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyBestBidUpdate {
        Timestamp Timestamp;
        StrategyId StrategyId;
        QuoteCondition QuoteCondition;
        Price Price;
        Size Size;
        CustSize CustSize;
        ProCustSize ProCustSize;
        NttSize NttSize;
        MarketSize MarketSize;
        NttMarketSize NttMarketSize;
    };


    /// <summary>
    ///  Struct for Strategy Open Closed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyOpenClosedMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for Strategy Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyTradingActionMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        CurrentTradingState CurrentTradingState;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Timestamp Timestamp;
        EventCode EventCode;
        CurrentYear CurrentYear;
        CurrentMonth CurrentMonth;
        CurrentDay CurrentDay;
        Version Version;
        Subversion Subversion;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
