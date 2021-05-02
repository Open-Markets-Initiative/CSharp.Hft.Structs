namespace Iex.Equities.Deep.IexTp.v1.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Adjusted Poc Price
    /// </summary>
    public struct AdjustedPocPrice {
        public long Raw;
    };


    /// <summary>
    ///  Auction Book Clearing Price
    /// </summary>
    public struct AuctionBookClearingPrice {
        public long Raw;
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        OpeningAuction = (byte)'O',
        ClosingAuction = (byte)'C',
        IpoAuction = (byte)'I',
        HaltAuction = (byte)'H',
        VolatilityAuction = (byte)'V',
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public unsafe struct ChannelId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Collar Reference Price
    /// </summary>
    public struct CollarReferencePrice {
        public long Raw;
    };


    /// <summary>
    ///  Detail Values
    /// </summary>
    public enum Detail : byte {
        NoPriceTestInPlace = (byte)' ',
        ShortSalePriceTestRestrictionInEffectDueToAnIntradayPriceDropInTheSecurity = (byte)'A',
        ShortSalePriceTestRestrictionRemainsInEffectFromPriorDay = (byte)'C',
        ShortSalePriceTestRestrictionDeactivated = (byte)'D',
        DetailNotAvailable = (byte)'N',
    };


    /// <summary>
    ///  Etp
    /// </summary>
    public unsafe struct Etp {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Event Flags Values
    /// </summary>
    public enum EventFlags : byte {
        OrderBookIsProcessingAnEvent = 0,
        EventProcessingComplete = 1,
    };


    /// <summary>
    ///  Extended Hours
    /// </summary>
    public unsafe struct ExtendedHours {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Extension Number
    /// </summary>
    public unsafe struct ExtensionNumber {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  First Message Sequence Number
    /// </summary>
    public unsafe struct FirstMessageSequenceNumber {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Imbalance Shares
    /// </summary>
    public unsafe struct ImbalanceShares {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Imbalance Side Values
    /// </summary>
    public enum ImbalanceSide : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        None = (byte)'N',
    };


    /// <summary>
    ///  Indicative Clearing Price
    /// </summary>
    public struct IndicativeClearingPrice {
        public long Raw;
    };


    /// <summary>
    ///  Intermarket Sweep
    /// </summary>
    public unsafe struct IntermarketSweep {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Lower Auction Collar
    /// </summary>
    public struct LowerAuctionCollar {
        public long Raw;
    };


    /// <summary>
    ///  Luld Tier Values
    /// </summary>
    public enum LuldTier : byte {
        NotApplicable = 0,
        Tier1NmsStock = 1,
        Tier2NmsStock = 2,
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Protocol Id
    /// </summary>
    public unsafe struct MessageProtocolId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        SecurityDirectoryMessage = (byte)'D',
        TradingStatusMessage = (byte)'H',
        OperationalHaltStatusMessage = (byte)'O',
        ShortSalePriceTestStatusMessage = (byte)'P',
        SecurityEventMessage = (byte)'E',
        PriceLevelBuyUpdateMessage = (byte)'8',
        PriceLevelSellUpdateMessage = (byte)'5',
        TradeReportMessage = (byte)'T',
        OfficialPriceMessage = (byte)'X',
        TradeBreakMessage = (byte)'B',
        AuctionInformationMessage = (byte)'A',
    };


    /// <summary>
    ///  Odd Lot
    /// </summary>
    public unsafe struct OddLot {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Official Price
    /// </summary>
    public struct OfficialPrice {
        public long Raw;
    };


    /// <summary>
    ///  Operational Halt Status Values
    /// </summary>
    public enum OperationalHaltStatus : byte {
        IexSpecificOperationalTradingHalt = (byte)'O',
        NotOperationallyHaltedOnIex = (byte)'N',
    };


    /// <summary>
    ///  Paired Shares
    /// </summary>
    public unsafe struct PairedShares {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Payload Length
    /// </summary>
    public unsafe struct PayloadLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public long Raw;
    };


    /// <summary>
    ///  Price Type Values
    /// </summary>
    public enum PriceType : byte {
        IexOfficialOpeningPrice = (byte)'Q',
        IexOfficialClosingPrice = (byte)'M',
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
    ///  Reference Price
    /// </summary>
    public struct ReferencePrice {
        public long Raw;
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Round Lot Size
    /// </summary>
    public unsafe struct RoundLotSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sale Condition Flags
    /// </summary>
    public unsafe struct SaleConditionFlags {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Scheduled Auction Time
    /// </summary>
    public unsafe struct ScheduledAuctionTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Event Values
    /// </summary>
    public enum SecurityEvent : byte {
        OpeningProcessComplete = (byte)'O',
        ClosingProcessComplete = (byte)'C',
    };


    /// <summary>
    ///  Send Time
    /// </summary>
    public unsafe struct SendTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Id
    /// </summary>
    public unsafe struct SessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Short Sale Price Test Status Values
    /// </summary>
    public enum ShortSalePriceTestStatus : byte {
        NotInEffect = 0,
        InEffect = 1,
    };


    /// <summary>
    ///  Singleprice Cross Trade
    /// </summary>
    public unsafe struct SinglepriceCrossTrade {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Size
    /// </summary>
    public unsafe struct Size {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stream Offset
    /// </summary>
    public unsafe struct StreamOffset {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Event Values
    /// </summary>
    public enum SystemEvent : byte {
        StartOfSystemHours = (byte)'S',
        StartOfRegularMarketHours = (byte)'R',
        EndOfRegularMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
    };


    /// <summary>
    ///  Test Security
    /// </summary>
    public unsafe struct TestSecurity {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public long Raw;
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Through Exempt
    /// </summary>
    public unsafe struct TradeThroughExempt {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        TradingHaltedAcrossAllUsEquityMarkets = (byte)'H',
        TradingPausedAndOrderAcceptancePeriodOnIex = (byte)'P',
        TradingOnIex = (byte)'T',
    };


    /// <summary>
    ///  Unused 3
    /// </summary>
    public unsafe struct Unused3 {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Unused 5
    /// </summary>
    public unsafe struct Unused5 {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Upper Auction Collar
    /// </summary>
    public struct UpperAuctionCollar {
        public long Raw;
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  When Issued
    /// </summary>
    public unsafe struct WhenIssued {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Auction Information Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionInformationMessage {
        AuctionType AuctionType;
        Timestamp Timestamp;
        Symbol Symbol;
        PairedShares PairedShares;
        ReferencePrice ReferencePrice;
        IndicativeClearingPrice IndicativeClearingPrice;
        ImbalanceShares ImbalanceShares;
        ImbalanceSide ImbalanceSide;
        ExtensionNumber ExtensionNumber;
        ScheduledAuctionTime ScheduledAuctionTime;
        AuctionBookClearingPrice AuctionBookClearingPrice;
        CollarReferencePrice CollarReferencePrice;
        LowerAuctionCollar LowerAuctionCollar;
        UpperAuctionCollar UpperAuctionCollar;
    };


    /// <summary>
    ///  Struct for Iex Tp Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IexTpHeader {
        Version Version;
        Reserved Reserved;
        MessageProtocolId MessageProtocolId;
        ChannelId ChannelId;
        SessionId SessionId;
        PayloadLength PayloadLength;
        MessageCount MessageCount;
        StreamOffset StreamOffset;
        FirstMessageSequenceNumber FirstMessageSequenceNumber;
        SendTime SendTime;
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
    ///  Struct for Official Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OfficialPriceMessage {
        PriceType PriceType;
        Timestamp Timestamp;
        Symbol Symbol;
        OfficialPrice OfficialPrice;
    };


    /// <summary>
    ///  Struct for Operational Halt Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OperationalHaltStatusMessage {
        OperationalHaltStatus OperationalHaltStatus;
        Timestamp Timestamp;
        Symbol Symbol;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        IexTpHeader IexTpHeader;
    };


    /// <summary>
    ///  Struct for Price Level Buy Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriceLevelBuyUpdateMessage {
        EventFlags EventFlags;
        Timestamp Timestamp;
        Symbol Symbol;
        Size Size;
        Price Price;
    };


    /// <summary>
    ///  Struct for Price Level Sell Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriceLevelSellUpdateMessage {
        EventFlags EventFlags;
        Timestamp Timestamp;
        Symbol Symbol;
        Size Size;
        Price Price;
    };


    /// <summary>
    ///  Struct for Sale Condition Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SaleConditionFlags {
        IntermarketSweep IntermarketSweep;
        ExtendedHours ExtendedHours;
        OddLot OddLot;
        TradeThroughExempt TradeThroughExempt;
        SinglepriceCrossTrade SinglepriceCrossTrade;
        Unused3 Unused3;
    };


    /// <summary>
    ///  Struct for Security Directory Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDirectoryFlags {
        Etp Etp;
        WhenIssued WhenIssued;
        TestSecurity TestSecurity;
        Unused5 Unused5;
    };


    /// <summary>
    ///  Struct for Security Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDirectoryMessage {
        SecurityDirectoryFlags SecurityDirectoryFlags;
        Timestamp Timestamp;
        Symbol Symbol;
        RoundLotSize RoundLotSize;
        AdjustedPocPrice AdjustedPocPrice;
        LuldTier LuldTier;
    };


    /// <summary>
    ///  Struct for Security Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityEventMessage {
        SecurityEvent SecurityEvent;
        Timestamp Timestamp;
        Symbol Symbol;
    };


    /// <summary>
    ///  Struct for Short Sale Price Test Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortSalePriceTestStatusMessage {
        ShortSalePriceTestStatus ShortSalePriceTestStatus;
        Timestamp Timestamp;
        Symbol Symbol;
        Detail Detail;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        SystemEvent SystemEvent;
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for Trade Break Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeBreakMessage {
        SaleConditionFlags SaleConditionFlags;
        Timestamp Timestamp;
        Symbol Symbol;
        Size Size;
        Price Price;
        TradeId TradeId;
    };


    /// <summary>
    ///  Struct for Trade Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportMessage {
        SaleConditionFlags SaleConditionFlags;
        Timestamp Timestamp;
        Symbol Symbol;
        Size Size;
        Price Price;
        TradeId TradeId;
    };


    /// <summary>
    ///  Struct for Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingStatusMessage {
        TradingStatus TradingStatus;
        Timestamp Timestamp;
        Symbol Symbol;
        Reason Reason;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
