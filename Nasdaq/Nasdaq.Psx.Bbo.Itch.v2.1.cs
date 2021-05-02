namespace Nasdaq.Psx.Bbo.Itch.v2.1 {

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
    ///  Authenticity Values
    /// </summary>
    public enum Authenticity : byte {
        LiveProduction = (byte)'P',
        Test = (byte)'T',
    };


    /// <summary>
    ///  Breached Level Values
    /// </summary>
    public enum BreachedLevel : byte {
        Level1 = (byte)'1',
        Level2 = (byte)'2',
        Level3 = (byte)'3',
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
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        Halted = (byte)'H',
        Paused = (byte)'P',
        QuotationOnlyPeriod = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Etp Flag Values
    /// </summary>
    public enum EtpFlag : byte {
        Etp = (byte)'Y',
        NotEtp = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Etp Leverage Factor
    /// </summary>
    public unsafe struct EtpLeverageFactor {
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
        StartOfTransmissions = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfMarketHours = (byte)'Q',
        EndOfMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        Deficient = (byte)'D',
        Delinquent = (byte)'E',
        Bankrupt = (byte)'Q',
        Suspended = (byte)'S',
        DeficientAndBankrupt = (byte)'G',
        DeficientAndDelinquent = (byte)'H',
        DelinquentAndBankrupt = (byte)'J',
        DeficientDelinquentAndBankrupt = (byte)'K',
        CreationsAndRedemptionsSuspended = (byte)'C',
        Normal = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Inverse Indicator Values
    /// </summary>
    public enum InverseIndicator : byte {
        InverseEtp = (byte)'Y',
        NotInverseEtp = (byte)'N',
    };


    /// <summary>
    ///  Ipo Flag Values
    /// </summary>
    public enum IpoFlag : byte {
        NasdaqListedInstrument = (byte)'Y',
        NasdaqListedInstrument = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Issue Classification
    /// </summary>
    public unsafe struct IssueClassification {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Sub Type
    /// </summary>
    public unsafe struct IssueSubType {
        public const int Size = 2;

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

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Level 1
    /// </summary>
    public struct Level1 {
        public long Raw;
    };


    /// <summary>
    ///  Level 2
    /// </summary>
    public struct Level2 {
        public long Raw;
    };


    /// <summary>
    ///  Level 3
    /// </summary>
    public struct Level3 {
        public long Raw;
    };


    /// <summary>
    ///  Luld Reference Price Tier Values
    /// </summary>
    public enum LuldReferencePriceTier : byte {
        Tier1 = (byte)'1',
        Tier2 = (byte)'2',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Market Category Values
    /// </summary>
    public enum MarketCategory : byte {
        NasdaqGlobalSelectMarket = (byte)'Q',
        NasdaqGlobalMarket = (byte)'G',
        NasdaqCapitalMarket = (byte)'S',
        Nyse = (byte)'N',
        NyseAmex = (byte)'A',
        NyseArca = (byte)'P',
        BatsBzx = (byte)'Z',
        InvestorsExchange = (byte)'V',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Market Code Values
    /// </summary>
    public enum MarketCode : byte {
        Nasdaq = (byte)'Q',
        Bx = (byte)'B',
        Psx = (byte)'X',
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        StockDirectoryMessage = (byte)'R',
        StockTradingActionMessage = (byte)'H',
        RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
        MwcbDeclineLevelMessage = (byte)'V',
        MwcbStatusMessage = (byte)'W',
        OperationalHaltMessage = (byte)'h',
        QuotationMessage = (byte)'Q',
        NextSharesQuotationMessage = (byte)'A',
    };


    /// <summary>
    ///  Nasdaq Best Bid
    /// </summary>
    public struct NasdaqBestBid {
        public int Raw;
    };


    /// <summary>
    ///  Next Shares Symbol
    /// </summary>
    public unsafe struct NextSharesSymbol {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Operational Halt Action Values
    /// </summary>
    public enum OperationalHaltAction : byte {
        Halted = (byte)'H',
        Resumed = (byte)'T',
    };


    /// <summary>
    ///  Psx Best Bid Price
    /// </summary>
    public struct PsxBestBidPrice {
        public int Raw;
    };


    /// <summary>
    ///  Psx Best Bid Size
    /// </summary>
    public unsafe struct PsxBestBidSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Psx Best Offer Price
    /// </summary>
    public struct PsxBestOfferPrice {
        public int Raw;
    };


    /// <summary>
    ///  Psx Best Offer Size
    /// </summary>
    public unsafe struct PsxBestOfferSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
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
    ///  Reg Sho Action Values
    /// </summary>
    public enum RegShoAction : byte {
        NoPriceTest = (byte)'0',
        RegShoShortSalePriceTestRestriction = (byte)'1',
        TestRestrictionRemains = (byte)'2',
    };


    /// <summary>
    ///  Round Lot Size
    /// </summary>
    public unsafe struct RoundLotSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Round Lots Only Values
    /// </summary>
    public enum RoundLotsOnly : byte {
        RoundLotsOnly = (byte)'Y',
        OddMixedAllowed = (byte)'N',
    };


    /// <summary>
    ///  Security Class Values
    /// </summary>
    public enum SecurityClass : byte {
        NasdaqListedIssue = (byte)'Q',
        Nyse = (byte)'N',
        NyseMkt = (byte)'A',
        NyseArca = (byte)'P',
        Bats = (byte)'Z',
        Iexg = (byte)'V',
        Na = (byte)' ',
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
    ///  Short Sale Threshold Indicator Values
    /// </summary>
    public enum ShortSaleThresholdIndicator : byte {
        Restricted = (byte)'Y',
        NotRestricted = (byte)'N',
        Na = (byte)' ',
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
        public const int Size = 6;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tracking Number
    /// </summary>
    public unsafe struct TrackingNumber {
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
    ///  Struct for Mwcb Decline Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbDeclineLevelMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Level1 Level1;
        Level2 Level2;
        Level3 Level3;
    };


    /// <summary>
    ///  Struct for Mwcb Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbStatusMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BreachedLevel BreachedLevel;
    };


    /// <summary>
    ///  Struct for Next Shares Quotation Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NextSharesQuotationMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        NextSharesSymbol NextSharesSymbol;
        SecurityClass SecurityClass;
        NasdaqBestBid NasdaqBestBid;
    };


    /// <summary>
    ///  Struct for Operational Halt Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OperationalHaltMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        MarketCode MarketCode;
        OperationalHaltAction OperationalHaltAction;
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
    ///  Struct for Quotation Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuotationMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        SecurityClass SecurityClass;
        PsxBestBidPrice PsxBestBidPrice;
        PsxBestBidSize PsxBestBidSize;
        PsxBestOfferPrice PsxBestOfferPrice;
        PsxBestOfferSize PsxBestOfferSize;
    };


    /// <summary>
    ///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Stock Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockDirectoryMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        MarketCategory MarketCategory;
        FinancialStatusIndicator FinancialStatusIndicator;
        RoundLotSize RoundLotSize;
        RoundLotsOnly RoundLotsOnly;
        IssueClassification IssueClassification;
        IssueSubType IssueSubType;
        Authenticity Authenticity;
        ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
        IpoFlag IpoFlag;
        LuldReferencePriceTier LuldReferencePriceTier;
        EtpFlag EtpFlag;
        EtpLeverageFactor EtpLeverageFactor;
        InverseIndicator InverseIndicator;
    };


    /// <summary>
    ///  Struct for Stock Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockTradingActionMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        SecurityClass SecurityClass;
        CurrentTradingState CurrentTradingState;
        Reason Reason;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        EventCode EventCode;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
