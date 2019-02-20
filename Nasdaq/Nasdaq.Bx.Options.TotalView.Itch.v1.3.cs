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
    ///  Ask Reference Delta Number
    /// </summary>
    public unsafe struct AskReferenceDeltaNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Reference Number Delta
    /// </summary>
    public unsafe struct AskReferenceNumberDelta {
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
        Exposure = (byte)'I',
        PriceImprovement = (byte)'P',
    };


    /// <summary>
    ///  Base Reference Number
    /// </summary>
    public unsafe struct BaseReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Bid Reference Number Delta
    /// </summary>
    public unsafe struct BidReferenceNumberDelta {
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
        BxOpeningReopening = (byte)'O',
        BxOpeningReopening = (byte)'P',
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        Halt = (byte)'H',
        Trading = (byte)'T',
        BuySideTradingSuspended = (byte)'B',
        SellSideTradingSuspended = (byte)'S',
        Open = (byte)'Y',
        Closed = (byte)'N',
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
        StartOfSystemHoursThisMessageIndicatesThatBxIsOpenAndReadyToStartAcceptingOrders = (byte)'S',
        StartOfOpeningProcessThisMessageIsIntendedToIndicateThatBxHasStartedItsOpeningAuctionProcess = (byte)'Q',
        EndOfNormalHoursProcessingThisMessageIsIntendedToIndicateThatBxWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringNormalTradingHours = (byte)'N',
        EndOfLateHoursProcessingThisMessageIsIntendedToIndicateThatBxWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringExtendedHours = (byte)'L',
        EndOfSystemHoursThisMessageIndicatesThatBxOptionsSystemIsNowClosed = (byte)'E',
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
    public struct ExpirationDate {
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
        SecondsMessage = (byte)'T',
        SystemEventMessage = (byte)'S',
        BaseReferenceMessage = (byte)'L',
        OptionDirectoryMessage = (byte)'R',
        TradingActionMessage = (byte)'H',
        OptionOpenMessage = (byte)'O',
        AddOrderMessageShortForm = (byte)'a',
        AddOrderMessageLongForm = (byte)'A',
        AddQuoteMessageShortForm = (byte)'j',
        AddQuoteMessageLongForm = (byte)'J',
        SingleSideExecutedMessage = (byte)'E',
        SingleSideOrderExecutedWithPriceMessage = (byte)'C',
        OrderCancelMessage = (byte)'X',
        SingleSideReplaceMessageShortForm = (byte)'u',
        SingleSideReplaceMessageLongForm = (byte)'U',
        SingleSideDeleteMessage = (byte)'D',
        SingleSideUpdateMessage = (byte)'G',
        QuoteReplaceMessageShortForm = (byte)'k',
        QuoteReplaceMessageLongForm = (byte)'K',
        QuoteDeleteMessage = (byte)'Y',
        BlockDeleteMessage = (byte)'Z',
        NonAuctionOptionsTradeMessage = (byte)'P',
        OptionsCrossTradeMessage = (byte)'Q',
        BrokenTradeOrOrderExecutionMessage = (byte)'B',
        NetOrderImbalanceIndicatorMessage = (byte)'I',
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
    ///  New Reference Number Delta
    /// </summary>
    public unsafe struct NewReferenceNumberDelta {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open State
    /// </summary>
    public unsafe struct OpenState {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Order Reference Number Delta
    /// </summary>
    public unsafe struct OrderReferenceNumberDelta {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Ask Reference Number Delta
    /// </summary>
    public unsafe struct OriginalAskReferenceNumberDelta {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Bid Reference Number Delta
    /// </summary>
    public unsafe struct OriginalBidReferenceNumberDelta {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Reference Number Delta
    /// </summary>
    public unsafe struct OriginalReferenceNumberDelta {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
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
    ///  Reference Number Delta
    /// </summary>
    public unsafe struct ReferenceNumberDelta {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Number Deltan
    /// </summary>
    public unsafe struct ReferenceNumberDeltan {
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
    public struct Reserved {
        public ulong Raw;
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
    public struct Source {
        public byte Raw;
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
    ///  Total Number Of Reference Number Deltas
    /// </summary>
    public unsafe struct TotalNumberOfReferenceNumberDeltas {
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
    ///  Struct for Add Order Message Long Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessageLongForm {
        Timestamp Timestamp;
        OrderReferenceNumberDelta OrderReferenceNumberDelta;
        MarketSide MarketSide;
        OptionId OptionId;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Add Order Message Short Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessageShortForm {
        Timestamp Timestamp;
        OrderReferenceNumberDelta OrderReferenceNumberDelta;
        MarketSide MarketSide;
        OptionId OptionId;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Add Quote Message Long Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddQuoteMessageLongForm {
        Timestamp Timestamp;
        BidReferenceNumberDelta BidReferenceNumberDelta;
        AskReferenceNumberDelta AskReferenceNumberDelta;
        OptionId OptionId;
        Bid Bid;
        BidSize BidSize;
        Ask Ask;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Add Quote Message Short Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddQuoteMessageShortForm {
        Timestamp Timestamp;
        BidReferenceNumberDelta BidReferenceNumberDelta;
        AskReferenceNumberDelta AskReferenceNumberDelta;
        OptionId OptionId;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPrice AskPrice;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Base Reference Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BaseReferenceMessage {
        Timestamp Timestamp;
        BaseReferenceNumber BaseReferenceNumber;
    };


    /// <summary>
    ///  Struct for Block Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BlockDeleteMessage {
        Timestamp Timestamp;
        TotalNumberOfReferenceNumberDeltas TotalNumberOfReferenceNumberDeltas;
        ReferenceNumberDeltan ReferenceNumberDeltan;
    };


    /// <summary>
    ///  Struct for Broken Trade Or Order Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeOrOrderExecutionMessage {
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
    ///  Struct for Net Order Imbalance Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetOrderImbalanceIndicatorMessage {
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
    ///  Struct for Non Auction Options Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NonAuctionOptionsTradeMessage {
        Timestamp Timestamp;
        BuySellIndicator BuySellIndicator;
        OptionId OptionId;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Option Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionDirectoryMessage {
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
    ///  Struct for Option Open Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionOpenMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for Options Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionsCrossTradeMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
        CrossType CrossType;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Order Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelMessage {
        Timestamp Timestamp;
        OrderReferenceNumberDelta OrderReferenceNumberDelta;
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
        Timestamp Timestamp;
        BidReferenceNumberDelta BidReferenceNumberDelta;
        AskReferenceNumberDelta AskReferenceNumberDelta;
    };


    /// <summary>
    ///  Struct for Quote Replace Message Long Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteReplaceMessageLongForm {
        Timestamp Timestamp;
        OriginalBidReferenceNumberDelta OriginalBidReferenceNumberDelta;
        BidReferenceNumberDelta BidReferenceNumberDelta;
        OriginalAskReferenceNumberDelta OriginalAskReferenceNumberDelta;
        AskReferenceDeltaNumber AskReferenceDeltaNumber;
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
        Timestamp Timestamp;
        OriginalBidReferenceNumberDelta OriginalBidReferenceNumberDelta;
        BidReferenceNumberDelta BidReferenceNumberDelta;
        OriginalAskReferenceNumberDelta OriginalAskReferenceNumberDelta;
        AskReferenceDeltaNumber AskReferenceDeltaNumber;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPrice AskPrice;
        AskSize AskSize;
    };


    /// <summary>
    ///  Struct for Seconds Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecondsMessage {
        Second Second;
    };


    /// <summary>
    ///  Struct for Single Side Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideDeleteMessage {
        Timestamp Timestamp;
        ReferenceNumberDelta ReferenceNumberDelta;
    };


    /// <summary>
    ///  Struct for Single Side Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideExecutedMessage {
        Timestamp Timestamp;
        ReferenceNumberDelta ReferenceNumberDelta;
        ExecutedContracts ExecutedContracts;
        CrossNumber CrossNumber;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Single Side Order Executed With Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideOrderExecutedWithPriceMessage {
        Timestamp Timestamp;
        ReferenceNumberDelta ReferenceNumberDelta;
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
        Timestamp Timestamp;
        OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
        NewReferenceNumberDelta NewReferenceNumberDelta;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Single Side Replace Message Short Form
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideReplaceMessageShortForm {
        Timestamp Timestamp;
        OriginalReferenceNumberDelta OriginalReferenceNumberDelta;
        NewReferenceNumberDelta NewReferenceNumberDelta;
        Price Price;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Single Side Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SingleSideUpdateMessage {
        Timestamp Timestamp;
        ReferenceNumberDelta ReferenceNumberDelta;
        ChangeReason ChangeReason;
        Price Price;
        Volume Volume;
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
    ///  Struct for Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingActionMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        CurrentTradingState CurrentTradingState;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
