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
    ///  Ask
    /// </summary>
    public unsafe struct Ask {
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
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Reference Number
    /// </summary>
    public unsafe struct AskReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Size
    /// </summary>
    public unsafe struct AskSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        Opening = (byte)'O',
        Reopening = (byte)'R',
        PriceImprovement = (byte)'P',
        Exposure = (byte)'I',
    };


    /// <summary>
    ///  Bid
    /// </summary>
    public unsafe struct Bid {
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
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Reference Number
    /// </summary>
    public unsafe struct BidReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Buy Sell Indicator Values
    /// </summary>
    public enum BuySellIndicator : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Cancelled Contracts
    /// </summary>
    public unsafe struct CancelledContracts {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Change Reason Values
    /// </summary>
    public enum ChangeReason : byte {
        User = (byte)'U',
        Reprice = (byte)'R',
        Suspend = (byte)'S',
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
    ///  Cross Number
    /// </summary>
    public unsafe struct CrossNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        NasdaqOpeningReopening = (byte)'O',
        PriceImprovement = (byte)'P',
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        Halt = (byte)'H',
        Trading = (byte)'T',
        BuySideTradingSuspended = (byte)'B',
        SellSideTradingSuspended = (byte)'S',
    };


    /// <summary>
    ///  Customer Firm Indicator Values
    /// </summary>
    public enum CustomerFirmIndicator : byte {
        Customer = (byte)'C',
        FirmJoint = (byte)'F',
        Onfloor = (byte)'M',
        Professional = (byte)'P',
        BrokerDealerNonRegistered = (byte)'B',
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfMessagesThisIsAlwaysTheFirstMessageSentInAnyTradingDay = (byte)'O',
        StartOfSystemHoursThisMessageIndicatesThatNasdaqIsOpenAndReadyToStartAcceptingOrders = (byte)'S',
        StartOfOpeningProcessThisMessageIsIntendedToIndicateThatNasdaqHasStartedItsOpeningAuctionProcess = (byte)'Q',
        EndOfNormalHoursProcessingThisMessageIsIntendedToIndicateThatNasdaqWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringNormalTradingHours = (byte)'N',
        EndOfLateHoursProcessingThisMessageIsIntendedToIndicateThatNasdaqWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringExtendedHours = (byte)'L',
        EndOfSystemHoursThisMessageIndicatesThatNasdaqOptionsSystemIsNowClosed = (byte)'E',
        EndOfMessagesThisIsAlwaysTheLastMessageSentInAnyTradingDay = (byte)'C',
    };


    /// <summary>
    ///  Executed Contracts
    /// </summary>
    public unsafe struct ExecutedContracts {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Date
    /// </summary>
    public unsafe struct ExpirationDate {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Month
    /// </summary>
    public unsafe struct ExpirationMonth {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Year
    /// </summary>
    public unsafe struct ExpirationYear {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
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
    ///  Imbalance Direction Values
    /// </summary>
    public enum ImbalanceDirection : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Imbalance Price
    /// </summary>
    public unsafe struct ImbalancePrice {
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
    ///  Market Side Values
    /// </summary>
    public enum MarketSide : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Match Number
    /// </summary>
    public unsafe struct MatchNumber {
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
        OptionsDirectoryMessage = (byte)'R',
        TradingActionMessage = (byte)'H',
        SecurityOpenMessage = (byte)'O',
        AddOrderMessageShortMessageForm = (byte)'a',
        AddOrderMessageLongFormMessage = (byte)'A',
        AddQuoteMessageShortFormMessage = (byte)'j',
        AddQuoteMessageLongFormMessage = (byte)'J',
        SingleSideExecutedMessage = (byte)'E',
        SingleSideExecutedWithPriceMessage = (byte)'C',
        OrderCancelMessage = (byte)'X',
        SingleSideReplaceMessageShortForm = (byte)'u',
        SingleSideReplaceMessageLongForm = (byte)'U',
        SingleSideDeleteMessage = (byte)'D',
        SingleSideChangeMessage = (byte)'G',
        QuoteReplaceMessageShortForm = (byte)'k',
        QuoteReplaceMessageLongForm = (byte)'K',
        QuoteDeleteMessage = (byte)'Y',
        OptionsTradeMessagesNonAuction = (byte)'P',
        OptionsCrossTradeMessage = (byte)'Q',
        BrokenTradeOrderExecutedMessage = (byte)'B',
        NoiiMessage = (byte)'I',
    };


    /// <summary>
    ///  Mpv Values
    /// </summary>
    public enum Mpv : byte {
        Everywhere = (byte)'E',
        Scaled = (byte)'S',
        Pilot = (byte)'P',
    };


    /// <summary>
    ///  New Reference Number
    /// </summary>
    public unsafe struct NewReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    };


    /// <summary>
    ///  Options Closing Type Values
    /// </summary>
    public enum OptionsClosingType : byte {
        Normal = (byte)'N',
        Late = (byte)'L',
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
    ///  Original Ask Reference Number
    /// </summary>
    public unsafe struct OriginalAskReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Bid Reference Number
    /// </summary>
    public unsafe struct OriginalBidReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Reference Number
    /// </summary>
    public unsafe struct OriginalReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Paired Contracts
    /// </summary>
    public unsafe struct PairedContracts {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Printable Values
    /// </summary>
    public enum Printable : byte {
        Nonprintable = (byte)'N',
        Printable = (byte)'Y',
    };


    /// <summary>
    ///  Reference Number
    /// </summary>
    public unsafe struct ReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 3;

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
    ///  Source
    /// </summary>
    public unsafe struct Source {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
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
    ///  Tradable Values
    /// </summary>
    public enum Tradable : byte {
        NotTradable = (byte)'N',
        IsTradable = (byte)'Y',
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
    ///  Volume
    /// </summary>
    public unsafe struct Volume {
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
    ///  Struct for Add Order Message Long Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessageLongFormMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        MarketSide MarketSide;
        OptionId OptionId;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Add Order Message Short Message Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessageShortMessageForm {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        MarketSide MarketSide;
        OptionId OptionId;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Add Quote Message Long Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddQuoteMessageLongFormMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BidReferenceNumber BidReferenceNumber;
        AskReferenceNumber AskReferenceNumber;
        OptionId OptionId;
        Bid Bid;
        BidSize BidSize;
        Ask Ask;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Add Quote Message Short Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddQuoteMessageShortFormMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BidReferenceNumber BidReferenceNumber;
        AskReferenceNumber AskReferenceNumber;
        OptionId OptionId;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPrice AskPrice;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Broken Trade Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeOrderExecutedMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
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
    ///  Struct for Noii Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NoiiMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        AuctionId AuctionId;
        AuctionType AuctionType;
        PairedContracts PairedContracts;
        ImbalanceDirection ImbalanceDirection;
        OptionId OptionId;
        ImbalancePrice ImbalancePrice;
        ImbalanceVolume ImbalanceVolume;
        CustomerFirmIndicator CustomerFirmIndicator;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Options Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionsCrossTradeMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OptionId OptionId;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
        CrossType CrossType;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Options Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionsDirectoryMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        ExpirationYear ExpirationYear;
        ExpirationMonth ExpirationMonth;
        ExpirationDate ExpirationDate;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        OptionsClosingType OptionsClosingType;
        Tradable Tradable;
        Mpv Mpv;
    };


    /// <summary>
    ///  Struct for Options Trade Messages Non Auction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionsTradeMessagesNonAuction {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BuySellIndicator BuySellIndicator;
        OptionId OptionId;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Order Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        CancelledContracts CancelledContracts;
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
    ///  Struct for Quote Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteDeleteMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BidReferenceNumber BidReferenceNumber;
        AskReferenceNumber AskReferenceNumber;
    };


    /// <summary>
    ///  Struct for Quote Replace Message Long Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteReplaceMessageLongForm {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OriginalBidReferenceNumber OriginalBidReferenceNumber;
        BidReferenceNumber BidReferenceNumber;
        OriginalAskReferenceNumber OriginalAskReferenceNumber;
        AskReferenceNumber AskReferenceNumber;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPrice AskPrice;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Quote Replace Message Short Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteReplaceMessageShortForm {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OriginalBidReferenceNumber OriginalBidReferenceNumber;
        BidReferenceNumber BidReferenceNumber;
        OriginalAskReferenceNumber OriginalAskReferenceNumber;
        AskReferenceNumber AskReferenceNumber;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPrice AskPrice;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Security Open Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityOpenMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OptionId OptionId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for Single Side Change Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideChangeMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        ReferenceNumber ReferenceNumber;
        ChangeReason ChangeReason;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Single Side Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideDeleteMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        ReferenceNumber ReferenceNumber;
    };


    /// <summary>
    ///  Struct for Single Side Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideExecutedMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        ReferenceNumber ReferenceNumber;
        ExecutedContracts ExecutedContracts;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Single Side Executed With Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideExecutedWithPriceMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        ReferenceNumber ReferenceNumber;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
        Printable Printable;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Single Side Replace Message Long Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideReplaceMessageLongForm {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OriginalReferenceNumber OriginalReferenceNumber;
        NewReferenceNumber NewReferenceNumber;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Single Side Replace Message Short Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideReplaceMessageShortForm {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OriginalReferenceNumber OriginalReferenceNumber;
        NewReferenceNumber NewReferenceNumber;
        Price Price;
        Volume Volume;
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


    /// <summary>
    ///  Struct for Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingActionMessage {
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OptionId OptionId;
        CurrentTradingState CurrentTradingState;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
