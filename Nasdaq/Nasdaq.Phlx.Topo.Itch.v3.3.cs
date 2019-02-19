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
    ///  Ask Price 2
    /// </summary>
    public struct AskPrice2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Ask Price 4
    /// </summary>
    public struct AskPrice4 {
        public uint Raw;
    };


    /// <summary>
    ///  Ask Size 2
    /// </summary>
    public struct AskSize2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Ask Size 4
    /// </summary>
    public struct AskSize4 {
        public uint Raw;
    };


    /// <summary>
    ///  Bid Price 2
    /// </summary>
    public struct BidPrice2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Bid Price 4
    /// </summary>
    public struct BidPrice4 {
        public uint Raw;
    };


    /// <summary>
    ///  Bid Size 2
    /// </summary>
    public struct BidSize2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Bid Size 4
    /// </summary>
    public struct BidSize4 {
        public uint Raw;
    };


    /// <summary>
    ///  Count
    /// </summary>
    public struct Count {
        public ushort Raw;
    };


    /// <summary>
    ///  Cross Id
    /// </summary>
    public struct CrossId {
        public uint Raw;
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        HaltInEffect = (byte)'H',
        TradingResumed = (byte)'T',
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfMessages = "O",
        StartOfSystemHours = "S",
        StartOfOpeningProcess = "Q",
        StartOfNormalHoursClosingProcess = "N",
        StartOfLateHoursClosingProcess = "L",
        EndOfSystemHours = "E",
        EndOfMessages = "C",
        EndOfWcoEarlyClosing = "W",
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
    ///  Length
    /// </summary>
    public struct Length {
        public ushort Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        TimestampMessage = (byte)'T',
        SystemEventMessage = (byte)'S',
        OptionsDirectoryMessage = (byte)'D',
        TradingActionMessage = (byte)'H',
        SecurityOpenClosedMessage = (byte)'O',
        ShortBestBidAndAskUpdateMessage = (byte)'q',
        LongBestBidAndAskUpdateMessage = (byte)'Q',
        ShortBestAskUpdateMessage = (byte)'a',
        ShortBestBidUpdateMessage = (byte)'b',
        LongBestAskUpdateMessage = (byte)'A',
        LongBestBidUpdateMessage = (byte)'B',
        TradeReportMessage = (byte)'R',
        BrokenTradeReportMessage = (byte)'X',
    };


    /// <summary>
    ///  Mpv Values
    /// </summary>
    public enum Mpv : byte {
        PennyEverywhere = (byte)'E',
        Scaled = (byte)'S',
        PennyPilot = (byte)'P',
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public struct Nanoseconds {
        public uint Raw;
    };


    /// <summary>
    ///  Open State Values
    /// </summary>
    public enum OpenState : byte {
        OpenForAutoExecution = (byte)'Y',
        ClosedForAutoExecution = (byte)'N',
    };


    /// <summary>
    ///  Option Closing Type Values
    /// </summary>
    public enum OptionClosingType : byte {
        Normal = (byte)'N',
        Late = (byte)'L',
        WcoEarlyClosing = (byte)'W',
    };


    /// <summary>
    ///  Option Id
    /// </summary>
    public struct OptionId {
        public uint Raw;
    };


    /// <summary>
    ///  Option Type Values
    /// </summary>
    public enum OptionType : byte {
        Call = (byte)'C',
        Put = (byte)'P',
    };


    /// <summary>
    ///  Original Cross Id
    /// </summary>
    public struct OriginalCrossId {
        public uint Raw;
    };


    /// <summary>
    ///  Original Price
    /// </summary>
    public struct OriginalPrice {
        public uint Raw;
    };


    /// <summary>
    ///  Original Volume
    /// </summary>
    public struct OriginalVolume {
        public uint Raw;
    };


    /// <summary>
    ///  Price 2
    /// </summary>
    public struct Price2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Price 4
    /// </summary>
    public struct Price4 {
        public uint Raw;
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        RegularQuoteautoxEligible = (byte)'',
        NonFirmQuote = (byte)'F',
        RotationalQuote = (byte)'R',
        BidSideFirm = (byte)'X',
        AskSideFirm = (byte)'Y',
    };


    /// <summary>
    ///  Second
    /// </summary>
    public struct Second {
        public uint Raw;
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
    public struct Sequence {
        public ulong Raw;
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
    ///  Size 2
    /// </summary>
    public struct Size2 {
        public ushort Raw;
    };


    /// <summary>
    ///  Size 4
    /// </summary>
    public struct Size4 {
        public uint Raw;
    };


    /// <summary>
    ///  Source
    /// </summary>
    public struct Source {
        public byte Raw;
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public uint Raw;
    };


    /// <summary>
    ///  Subversion
    /// </summary>
    public struct Subversion {
        public byte Raw;
    };


    /// <summary>
    ///  Tradable Values
    /// </summary>
    public enum Tradable : byte {
        Tradable = (byte)'Y',
        NotTradable = (byte)'N',
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
    public struct Volume {
        public uint Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Broken Trade Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeReportMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        OriginalCrossId OriginalCrossId;
        OriginalPrice OriginalPrice;
        OriginalVolume OriginalVolume;
    };


    /// <summary>
    ///  Struct for Long Best Ask Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongBestAskUpdateMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        QuoteCondition QuoteCondition;
        Price4 Price4;
        Size4 Size4;
    };


    /// <summary>
    ///  Struct for Long Best Bid And Ask Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongBestBidAndAskUpdateMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        QuoteCondition QuoteCondition;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        AskPrice4 AskPrice4;
        AskSize4 AskSize4;
    };


    /// <summary>
    ///  Struct for Long Best Bid Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongBestBidUpdateMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        QuoteCondition QuoteCondition;
        Price4 Price4;
        Size4 Size4;
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
    ///  Struct for Options Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionsDirectoryMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        ExpirationYear ExpirationYear;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        StrikePrice StrikePrice;
        OptionType OptionType;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        OptionClosingType OptionClosingType;
        Tradable Tradable;
        Mpv Mpv;
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
    ///  Struct for Security Open Closed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityOpenClosedMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for Short Best Ask Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortBestAskUpdateMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        QuoteCondition QuoteCondition;
        Price2 Price2;
        Size2 Size2;
    };


    /// <summary>
    ///  Struct for Short Best Bid And Ask Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortBestBidAndAskUpdateMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        QuoteCondition QuoteCondition;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        AskPrice2 AskPrice2;
        AskSize2 AskSize2;
    };


    /// <summary>
    ///  Struct for Short Best Bid Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortBestBidUpdateMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        QuoteCondition QuoteCondition;
        Price2 Price2;
        Size2 Size2;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Nanoseconds Nanoseconds;
        EventCode EventCode;
        Version Version;
        Subversion Subversion;
    };


    /// <summary>
    ///  Struct for Timestamp Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimestampMessage {
        Second Second;
    };


    /// <summary>
    ///  Struct for Trade Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        CrossId CrossId;
        TradeCondition TradeCondition;
        Price4 Price4;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingActionMessage {
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        CurrentTradingState CurrentTradingState;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
