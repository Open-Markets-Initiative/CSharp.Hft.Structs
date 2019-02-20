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
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Action Values
    /// </summary>
    public enum Action : byte {
        Add = (byte)'A',
        Delete = (byte)'D',
    };


    /// <summary>
    ///  All Or None Values
    /// </summary>
    public enum AllOrNone : byte {
        AllOrNoneOrder = (byte)'Y',
        NotAllOrNoneOrder = (byte)'N',
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public unsafe struct AuctionId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Side Values
    /// </summary>
    public enum AuctionSide : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        SolicitationAuction = (byte)'*',
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        Cola = (byte)'C',
        Opening = (byte)'O',
        Reopening = (byte)'R',
        Pixl = (byte)'P',
        Solicitation = (byte)'S',
        OrderExposure = (byte)'I',
    };


    /// <summary>
    ///  Count
    /// </summary>
    public struct Count {
        public ushort Raw;
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        HaltInEffect = "H",
        PhlxTradingResumed = "T",
    };


    /// <summary>
    ///  Customer Firm Indicator Values
    /// </summary>
    public enum CustomerFirmIndicator : byte {
        CustomerOrder = (byte)'C',
        FirmOrder = (byte)'F',
        OnfloorMarketMaker = (byte)'M',
        BrokerDealerOrder = (byte)'B',
        ProfessionalOrder = (byte)'P',
        NaForImpliedOrder = (byte)' ',
    };


    /// <summary>
    ///  Day
    /// </summary>
    public unsafe struct Day {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Debit Or Credit Values
    /// </summary>
    public enum DebitOrCredit : byte {
        NetDebit = (byte)'D',
        NetCredit = (byte)'C',
        EvenOrMarketOrder = (byte)' ',
        Anonymous = (byte)'*',
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
    ///  Executable Order Volume
    /// </summary>
    public unsafe struct ExecutableOrderVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Explicit Strike Price
    /// </summary>
    public unsafe struct ExplicitStrikePrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Imbalance Volume
    /// </summary>
    public unsafe struct ImbalanceVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Open Close Indicator Values
    /// </summary>
    public enum LegOpenCloseIndicator : byte {
        OpensPosition = (byte)'O',
        ClosesPosition = (byte)'C',
        StockLeg = (byte)' ',
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
    ///  Limit Price
    /// </summary>
    public unsafe struct LimitPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Qualifier Values
    /// </summary>
    public enum MarketQualifier : byte {
        OpeningOrder = (byte)'O',
        ImpliedOrder = (byte)'I',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Matched Volume
    /// </summary>
    public unsafe struct MatchedVolume {
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
        OptionsDirectoryMessage = (byte)'D',
        ComplexOrderStrategyMessage = (byte)'R',
        SecurityTradingActionMessage = (byte)'H',
        ComplexTradingActionMessage = (byte)'I',
        SecurityOpenClosedMessage = (byte)'P',
        StrategyOpenClosedMessage = (byte)'Q',
        SimpleOrderMessage = (byte)'O',
        ComplexOrderMessage = (byte)'X',
        AuctionNotificationMessage = (byte)'A',
        ComplexAuctionNotificationMessage = (byte)'C',
    };


    /// <summary>
    ///  Month
    /// </summary>
    public unsafe struct Month {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public unsafe struct Nanoseconds {
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
    ///  Open Close Indicator Values
    /// </summary>
    public enum OpenCloseIndicator : byte {
        OpensPosition = (byte)'O',
        ClosesPosition = (byte)'C',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Open State Values
    /// </summary>
    public enum OpenState : byte {
        OpenForAutoExecution = "Y",
        ClosedForAutoExecution = "N",
    };


    /// <summary>
    ///  Option Closing Type Values
    /// </summary>
    public enum OptionClosingType : byte {
        Normal = "N",
        Late = "L",
        WcoEarlyClosing = "W",
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
        Stock = (byte)' ',
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public unsafe struct OrderId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Status Values
    /// </summary>
    public enum OrderStatus : byte {
        Open = (byte)'O',
        Filled = (byte)'F',
        Cancelled = (byte)'C',
        Renotification = (byte)'R',
    };


    /// <summary>
    ///  Order Type Values
    /// </summary>
    public enum OrderType : byte {
        Market = (byte)'M',
        Limit = (byte)'L',
        Anonymous = (byte)'*',
    };


    /// <summary>
    ///  Original Order Volume
    /// </summary>
    public unsafe struct OriginalOrderVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Phlx Tradable Values
    /// </summary>
    public enum PhlxTradable : byte {
        Tradable = "Y",
        NotTradable = "N",
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
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seconds
    /// </summary>
    public unsafe struct Seconds {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 5;

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
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
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
        Hidden = (byte)'*',
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
    ///  Time In Force Values
    /// </summary>
    public enum TimeInForce : byte {
        DayOrder = (byte)'D',
        Gtc = (byte)'G',
        Ioc = (byte)'I',
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


    /// <summary>
    ///  Year
    /// </summary>
    public unsafe struct Year {
        public const int Size = 7;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Auction Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionNotificationMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        AuctionId AuctionId;
        AuctionType AuctionType;
        Price Price;
        AuctionSide AuctionSide;
        MatchedVolume MatchedVolume;
        ImbalanceVolume ImbalanceVolume;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Complex Auction Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexAuctionNotificationMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        StrategyId StrategyId;
        AuctionId AuctionId;
        AuctionType AuctionType;
        Price Price;
        AuctionSide AuctionSide;
        DebitOrCredit DebitOrCredit;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Complex Order Leg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexOrderLeg {
        LegOpenCloseIndicator LegOpenCloseIndicator;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        Side Side;
        LegRatio LegRatio;
    };


    /// <summary>
    ///  Struct for Complex Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexOrderMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        StrategyId StrategyId;
        OrderId OrderId;
        Side Side;
        OriginalOrderVolume OriginalOrderVolume;
        ExecutableOrderVolume ExecutableOrderVolume;
        OrderStatus OrderStatus;
        OrderType OrderType;
        LimitPrice LimitPrice;
        DebitOrCredit DebitOrCredit;
        AllOrNone AllOrNone;
        TimeInForce TimeInForce;
        CustomerFirmIndicator CustomerFirmIndicator;
        UnderlyingSymbol UnderlyingSymbol;
        NumberOfLegs NumberOfLegs;
    };


    /// <summary>
    ///  Struct for Complex Order Strategy Leg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexOrderStrategyLeg {
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        Side Side;
        LegRatio LegRatio;
    };


    /// <summary>
    ///  Struct for Complex Order Strategy Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexOrderStrategyMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        StrategyId StrategyId;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        Action Action;
        NumberOfLegs NumberOfLegs;
    };


    /// <summary>
    ///  Struct for Complex Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTradingActionMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        StrategyId StrategyId;
        CurrentTradingState CurrentTradingState;
    };


    /// <summary>
    ///  Struct for Expiration
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Expiration {
        Year Year;
        Month Month;
        Day Day;
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
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        OptionClosingType OptionClosingType;
        PhlxTradable PhlxTradable;
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
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for Security Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityTradingActionMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        CurrentTradingState CurrentTradingState;
    };


    /// <summary>
    ///  Struct for Simple Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SimpleOrderMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        Expiration Expiration;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        OrderId OrderId;
        Side Side;
        OriginalOrderVolume OriginalOrderVolume;
        ExecutableOrderVolume ExecutableOrderVolume;
        OrderStatus OrderStatus;
        OrderType OrderType;
        MarketQualifier MarketQualifier;
        LimitPrice LimitPrice;
        AllOrNone AllOrNone;
        TimeInForce TimeInForce;
        CustomerFirmIndicator CustomerFirmIndicator;
        OpenCloseIndicator OpenCloseIndicator;
    };


    /// <summary>
    ///  Struct for Strategy Open Closed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyOpenClosedMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        StrategyId StrategyId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
        EventCode EventCode;
        Version Version;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
