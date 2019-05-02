namespace Nasdaq.Bx.Equities.TotalView.Itch.v5.0 {

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
    ///  Auction Collar Extension
    /// </summary>
    public unsafe struct AuctionCollarExtension {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Collar Reference Price
    /// </summary>
    public struct AuctionCollarReferencePrice {
        public int Raw;
    };


    /// <summary>
    ///  Authenticity Values
    /// </summary>
    public enum Authenticity : byte {
        Production = (byte)'P',
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
    ///  Buy Sell Indicator Values
    /// </summary>
    public enum BuySellIndicator : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Cancelled Shares
    /// </summary>
    public unsafe struct CancelledShares {
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
    public struct CrossPrice {
        public int Raw;
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        Opening = (byte)'O',
        Closing = (byte)'C',
        CrossForIpoAndHalted = (byte)'H',
        NasdaqBxCrossNetwork = (byte)'I',
    };


    /// <summary>
    ///  Current Reference Price
    /// </summary>
    public struct CurrentReferencePrice {
        public int Raw;
    };


    /// <summary>
    ///  Etp Flag Values
    /// </summary>
    public enum EtpFlag : byte {
        Etp = (byte)'Y',
        NotEtp = (byte)'N',
        NotAvailable = (byte)'',
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
        StartOfMessages = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfMarketHours = (byte)'Q',
        EndOfMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
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
    public struct ExecutionPrice {
        public int Raw;
    };


    /// <summary>
    ///  Far Price
    /// </summary>
    public struct FarPrice {
        public int Raw;
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
        CreationsAndOrRedemptionsSuspended = (byte)'C',
        Normal = (byte)'N',
    };


    /// <summary>
    ///  Imbalance Direction Values
    /// </summary>
    public enum ImbalanceDirection : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        No = (byte)'N',
        Insufficient = (byte)'O',
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
        BuySide = (byte)'B',
        SellSide = (byte)'S',
        BothSides = (byte)'A',
        NoPi = (byte)'N',
    };


    /// <summary>
    ///  Inverse Indicator Values
    /// </summary>
    public enum InverseIndicator : byte {
        IsAnInverseEtp = (byte)'Y',
        NotAnInverseEtp = (byte)'N',
    };


    /// <summary>
    ///  Ipo Flag Values
    /// </summary>
    public enum IpoFlag : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
        NotAvailable = (byte)'',
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
    ///  Lower Auction Collar Price
    /// </summary>
    public struct LowerAuctionCollarPrice {
        public int Raw;
    };


    /// <summary>
    ///  Luld Reference Price Tier Values
    /// </summary>
    public enum LuldReferencePriceTier : byte {
        Tier1 = (byte)'1',
        Tier2 = (byte)'2',
        NotAvailable = (byte)'',
    };


    /// <summary>
    ///  Market Category Values
    /// </summary>
    public enum MarketCategory : byte {
        NasdaqGlobalSelectMarket = (byte)'Q',
        NasdaqGlobalMarket = (byte)'G',
        NasdaqCapitalMarket = (byte)'S',
        Nyse = (byte)'N',
        NyseMkt = (byte)'A',
        NyseArca = (byte)'P',
        BatsZ = (byte)'Z',
        Iex = (byte)'V',
        NotAvailable = (byte)' ',
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
    ///  Market Maker Mode Values
    /// </summary>
    public enum MarketMakerMode : byte {
        Normal = (byte)'N',
        Passive = (byte)'P',
        Syndicate = (byte)'S',
        Presyndicate = (byte)'R',
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
        SystemEventMessage = (byte)'S',
        StockDirectoryMessage = (byte)'R',
        StockTradingActionMessage = (byte)'H',
        RegShoRestrictionMessage = (byte)'Y',
        MarketParticipantPositionMessage = (byte)'L',
        MwcbDeclineLevelMessage = (byte)'V',
        MwcbStatusMessage = (byte)'W',
        LuldAuctionCollarMessage = (byte)'J',
        OperationalHaltMessage = (byte)'h',
        AddOrderNoMpidAttributionMessage = (byte)'A',
        AddOrderMpidAttributionMessage = (byte)'F',
        OrderExecutedMessage = (byte)'E',
        OrderExecutedWithPriceMessage = (byte)'C',
        OrderCancelMessage = (byte)'X',
        OrderDeleteMessage = (byte)'D',
        OrderReplaceMessage = (byte)'U',
        NonCrossTradeMessage = (byte)'P',
        CrossTradeMessage = (byte)'Q',
        BrokenTradeMessage = (byte)'B',
        NetOrderImbalanceIndicatorMessage = (byte)'I',
        RetailInterestMessage = (byte)'N',
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
    public struct NearPrice {
        public int Raw;
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
    ///  Operational Halt Action Values
    /// </summary>
    public enum OperationalHaltAction : byte {
        OperationallyHalted = (byte)'H',
        OperationalHaltHasBeenLifted = (byte)'B',
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
    public struct Price {
        public int Raw;
    };


    /// <summary>
    ///  Price Variation Indicator Values
    /// </summary>
    public enum PriceVariationIndicator : byte {
        LessThan1 = (byte)'L',
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
        NotAvailable = (byte)'',
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
        NoPrice = (byte)'0',
        RegShoShortSalePriceTestRestrictionInEffectDue = (byte)'1',
        TestRestrictionRemainsInEffect = (byte)'2',
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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
        NoOrderSizeRestrictions = (byte)'N',
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
    ///  Short Sale Threshold Indicator Values
    /// </summary>
    public enum ShortSaleThresholdIndicator : byte {
        Restricted = (byte)'Y',
        NotRestricted = (byte)'N',
        NotAvailable = (byte)'',
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
    ///  Stock Locate
    /// </summary>
    public unsafe struct StockLocate {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
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


    /// <summary>
    ///  Trading State Values
    /// </summary>
    public enum TradingState : byte {
        Halted = (byte)'H',
        Paused = (byte)'P',
        QuotationOnly = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Upper Auction Collar Price
    /// </summary>
    public struct UpperAuctionCollarPrice {
        public int Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Order Mpid Attribution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMpidAttributionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
    };


    /// <summary>
    ///  Struct for Add Order No Mpid Attribution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderNoMpidAttributionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
    };


    /// <summary>
    ///  Struct for Broken Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossTradeMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Shares Shares;
        Stock Stock;
        CrossPrice CrossPrice;
        MatchNumber MatchNumber;
        CrossType CrossType;
    };


    /// <summary>
    ///  Struct for Luld Auction Collar Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LuldAuctionCollarMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        AuctionCollarReferencePrice AuctionCollarReferencePrice;
        UpperAuctionCollarPrice UpperAuctionCollarPrice;
        LowerAuctionCollarPrice LowerAuctionCollarPrice;
        AuctionCollarExtension AuctionCollarExtension;
    };


    /// <summary>
    ///  Struct for Market Participant Position Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketParticipantPositionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
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
    ///  Struct for Mwcb Decline Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbDeclineLevelMessage {
        StockLocate StockLocate;
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
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BreachedLevel BreachedLevel;
    };


    /// <summary>
    ///  Struct for Net Order Imbalance Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetOrderImbalanceIndicatorMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
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
    ///  Struct for Non Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NonCrossTradeMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Operational Halt Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OperationalHaltMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        MarketCode MarketCode;
        OperationalHaltAction OperationalHaltAction;
    };


    /// <summary>
    ///  Struct for Order Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        CancelledShares CancelledShares;
    };


    /// <summary>
    ///  Struct for Order Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDeleteMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
    };


    /// <summary>
    ///  Struct for Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
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
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
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
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
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
    ///  Struct for Reg Sho Restriction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoRestrictionMessage {
        Timestamp Timestamp;
        Stock Stock;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Retail Interest Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetailInterestMessage {
        InterestFlag InterestFlag;
    };


    /// <summary>
    ///  Struct for Stock Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockDirectoryMessage {
        StockLocate StockLocate;
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
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        TradingState TradingState;
        Reserved Reserved;
        Reason Reason;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        EventCode EventCode;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
