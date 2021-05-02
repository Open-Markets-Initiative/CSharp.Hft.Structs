namespace Cboe.Options.ComplexDepthOfBook.Pitch.v2.1.18 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction End Offset
    /// </summary>
    public unsafe struct AuctionEndOffset {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public unsafe struct AuctionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Only Price
    /// </summary>
    public struct AuctionOnlyPrice {
        public long Raw;
    };


    /// <summary>
    ///  Auction Opening Type Values
    /// </summary>
    public enum AuctionOpeningType : byte {
        Gth = (byte)'G',
        Rth = (byte)'O',
        HaltReopening = (byte)'H',
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        ComplexAuction = (byte)'C',
        ComplexSolicitationAuction = (byte)'S',
        ComplexAim = (byte)'B',
        CoaAllOrNone = (byte)'O',
    };


    /// <summary>
    ///  Buy Contracts
    /// </summary>
    public unsafe struct BuyContracts {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Canceled Quantity
    /// </summary>
    public unsafe struct CanceledQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Canceled Quantity Short
    /// </summary>
    public unsafe struct CanceledQuantityShort {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Client Id
    /// </summary>
    public unsafe struct ClientId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Auction Reserved Bytes
    /// </summary>
    public unsafe struct ComplexAuctionReservedBytes {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Auction Type
    /// </summary>
    public unsafe struct ComplexAuctionType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Instrument Id
    /// </summary>
    public unsafe struct ComplexInstrumentId {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Instrument Id 8
    /// </summary>
    public unsafe struct ComplexInstrumentId8 {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Instrument Type
    /// </summary>
    public unsafe struct ComplexInstrumentType {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Instrument Underlying
    /// </summary>
    public unsafe struct ComplexInstrumentUnderlying {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Symbol Id
    /// </summary>
    public unsafe struct ComplexSymbolId {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Composite Market Bid Price
    /// </summary>
    public struct CompositeMarketBidPrice {
        public long Raw;
    };


    /// <summary>
    ///  Composite Market Offer Price
    /// </summary>
    public struct CompositeMarketOfferPrice {
        public long Raw;
    };


    /// <summary>
    ///  Count
    /// </summary>
    public unsafe struct Count {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Customer Indicator Values
    /// </summary>
    public enum CustomerIndicator : byte {
        NonCustomer = (byte)'N',
        Customer = (byte)'C',
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
    ///  Execution Id
    /// </summary>
    public unsafe struct ExecutionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Feed Symbol
    /// </summary>
    public unsafe struct FeedSymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Gth Trading Status Values
    /// </summary>
    public enum GthTradingStatus : byte {
        Halted = (byte)'H',
        QuoteOnly = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Indicative Price
    /// </summary>
    public struct IndicativePrice {
        public long Raw;
    };


    /// <summary>
    ///  Leg Count
    /// </summary>
    public unsafe struct LegCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio
    /// </summary>
    public struct LegRatio {
        public int Raw;
    };


    /// <summary>
    ///  Leg Security Type Values
    /// </summary>
    public enum LegSecurityType : byte {
        Option = (byte)'O',
        Equity = (byte)'E',
    };


    /// <summary>
    ///  Leg Symbol
    /// </summary>
    public unsafe struct LegSymbol {
        public const int Size = 8;

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
        TimeMessage = 0x20,
        UnitClearMessage = 0x97,
        TransactionBegin = 0xBC,
        TransactionEndMessage = 0xBD,
        ComplexInstrumentDefinitionExpandedMessage = 0x9A,
        SymbolMappingMessage = 0x2E,
        AddOrderLongMessage = 0x21,
        AddOrderShortMessage = 0x22,
        AddOrderExpandedMessage = 0x2F,
        OrderExecutedMessage = 0x23,
        OrderExecutedAtPriceSizeMessage = 0x24,
        ReduceSizeLongMessage = 0x25,
        ReduceSizeShortMessage = 0x26,
        ModifyOrderLongMessage = 0x27,
        ModifyOrderShortMessage = 0x28,
        DeleteOrderMessage = 0x29,
        TradeLongMessage = 0x2A,
        TradeShortMessage = 0x2B,
        AuctionNotificationMessage = 0xAD,
        AuctionCancelMessage = 0xAE,
        AuctionTradeMessage = 0xAF,
        TradingStatusMessage = 0x31,
        AuctionUpdateMessage = 0xD1,
        AuctionSummaryMessage = 0x96,
        EndOfSessionMessage = 0x2D,
    };


    /// <summary>
    ///  Opening Condition
    /// </summary>
    public unsafe struct OpeningCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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
    ///  Osi Symbol
    /// </summary>
    public unsafe struct OsiSymbol {
        public const int Size = 21;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Padding
    /// </summary>
    public unsafe struct Padding {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Participant Id
    /// </summary>
    public unsafe struct ParticipantId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Price Short
    /// </summary>
    public struct PriceShort {
        public short Raw;
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
    ///  Quantity Short
    /// </summary>
    public unsafe struct QuantityShort {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Price
    /// </summary>
    public unsafe struct ReferencePrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Remaining Quantity
    /// </summary>
    public unsafe struct RemainingQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Sell Contracts
    /// </summary>
    public unsafe struct SellContracts {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public unsafe struct Sequence {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Indicator Values
    /// </summary>
    public enum SideIndicator : byte {
        BuyOrder = (byte)'B',
        SellOrder = (byte)'S',
    };


    /// <summary>
    ///  Symbol Condition Values
    /// </summary>
    public enum SymbolCondition : byte {
        Normal = (byte)'N',
        ClosingOnly = (byte)'C',
    };


    /// <summary>
    ///  Time
    /// </summary>
    public unsafe struct Time {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Time Offset
    /// </summary>
    public unsafe struct TimeOffset {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        ComplexToComplexElectronicTrade = (byte)'f',
        ComplexAuctionTrade = (byte)'g',
        ComplexCross = (byte)'h',
        ComplexElectronicTradeAgainstSingle = (byte)'j',
        ComplexWithStockOptionsAuctionTrade = (byte)'k',
        ComplexWithStockElectronicTrade = (byte)'n',
        ComplexWithStockCross = (byte)'o',
        ElectronicTrade = (byte)'l',
        OpeningTrade = (byte)'O',
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        Halted = (byte)'H',
        QuoteOnly = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Underlying
    /// </summary>
    public unsafe struct Underlying {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit
    /// </summary>
    public unsafe struct Unit {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unused
    /// </summary>
    public unsafe struct Unused {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Order Expanded Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderExpandedMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        Quantity Quantity;
        ComplexInstrumentId8 ComplexInstrumentId8;
        Price Price;
        Reserved Reserved;
        ParticipantId ParticipantId;
        CustomerIndicator CustomerIndicator;
        ClientId ClientId;
    };


    /// <summary>
    ///  Struct for Add Order Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        Quantity Quantity;
        ComplexInstrumentId ComplexInstrumentId;
        Price Price;
        Padding Padding;
    };


    /// <summary>
    ///  Struct for Add Order Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        QuantityShort QuantityShort;
        ComplexInstrumentId ComplexInstrumentId;
        PriceShort PriceShort;
        Padding Padding;
    };


    /// <summary>
    ///  Struct for Auction Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionCancelMessage {
        TimeOffset TimeOffset;
        AuctionId AuctionId;
    };


    /// <summary>
    ///  Struct for Auction Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionNotificationMessage {
        TimeOffset TimeOffset;
        ComplexInstrumentId ComplexInstrumentId;
        AuctionId AuctionId;
        AuctionType AuctionType;
        SideIndicator SideIndicator;
        Price Price;
        Quantity Quantity;
        CustomerIndicator CustomerIndicator;
        ParticipantId ParticipantId;
        AuctionEndOffset AuctionEndOffset;
        ClientId ClientId;
    };


    /// <summary>
    ///  Struct for Auction Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionSummaryMessage {
        TimeOffset TimeOffset;
        ComplexInstrumentId8 ComplexInstrumentId8;
        AuctionOpeningType AuctionOpeningType;
        Price Price;
        Quantity Quantity;
    };


    /// <summary>
    ///  Struct for Auction Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionTradeMessage {
        TimeOffset TimeOffset;
        AuctionId AuctionId;
        ExecutionId ExecutionId;
        Price Price;
        Quantity Quantity;
    };


    /// <summary>
    ///  Struct for Auction Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionUpdateMessage {
        TimeOffset TimeOffset;
        ComplexInstrumentId8 ComplexInstrumentId8;
        AuctionOpeningType AuctionOpeningType;
        ReferencePrice ReferencePrice;
        BuyContracts BuyContracts;
        SellContracts SellContracts;
        IndicativePrice IndicativePrice;
        AuctionOnlyPrice AuctionOnlyPrice;
        OpeningCondition OpeningCondition;
        CompositeMarketBidPrice CompositeMarketBidPrice;
        CompositeMarketOfferPrice CompositeMarketOfferPrice;
    };


    /// <summary>
    ///  Struct for Complex Instrument Definition Expanded Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentDefinitionExpandedMessage {
        TimeOffset TimeOffset;
        ComplexInstrumentId ComplexInstrumentId;
        ComplexInstrumentUnderlying ComplexInstrumentUnderlying;
        ComplexInstrumentType ComplexInstrumentType;
        LegCount LegCount;
    };


    /// <summary>
    ///  Struct for Complex Instrument Leg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentLeg {
        LegSymbol LegSymbol;
        LegRatio LegRatio;
        LegSecurityType LegSecurityType;
    };


    /// <summary>
    ///  Struct for Complex Instrument Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentType {
        ComplexAuctionType ComplexAuctionType;
        ComplexAuctionReservedBytes ComplexAuctionReservedBytes;
    };


    /// <summary>
    ///  Struct for Delete Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
    };


    /// <summary>
    ///  Struct for End Of Session Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfSessionMessage {
        TimeOffset TimeOffset;
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
    ///  Struct for Modify Order Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        Quantity Quantity;
        Price Price;
        Padding Padding;
    };


    /// <summary>
    ///  Struct for Modify Order Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        QuantityShort QuantityShort;
        PriceShort PriceShort;
        Padding Padding;
    };


    /// <summary>
    ///  Struct for Order Executed At Price Size Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedAtPriceSizeMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        ExecutedQuantity ExecutedQuantity;
        RemainingQuantity RemainingQuantity;
        ExecutionId ExecutionId;
        Price Price;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        ExecutedQuantity ExecutedQuantity;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
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
        Length Length;
        Count Count;
        Unit Unit;
        Sequence Sequence;
    };


    /// <summary>
    ///  Struct for Reduce Size Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReduceSizeLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        CanceledQuantity CanceledQuantity;
    };


    /// <summary>
    ///  Struct for Reduce Size Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReduceSizeShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        CanceledQuantityShort CanceledQuantityShort;
    };


    /// <summary>
    ///  Struct for Symbol Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolMappingMessage {
        FeedSymbol FeedSymbol;
        OsiSymbol OsiSymbol;
        SymbolCondition SymbolCondition;
        Underlying Underlying;
    };


    /// <summary>
    ///  Struct for Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeMessage {
        Time Time;
    };


    /// <summary>
    ///  Struct for Trade Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        Quantity Quantity;
        ComplexInstrumentId ComplexInstrumentId;
        Price Price;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trade Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        QuantityShort QuantityShort;
        ComplexInstrumentId ComplexInstrumentId;
        PriceShort PriceShort;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingStatusMessage {
        TimeOffset TimeOffset;
        ComplexSymbolId ComplexSymbolId;
        Unused Unused;
        TradingStatus TradingStatus;
        Reserved Reserved;
        GthTradingStatus GthTradingStatus;
        Padding Padding;
    };


    /// <summary>
    ///  Struct for Transaction Begin
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TransactionBegin {
        TimeOffset TimeOffset;
    };


    /// <summary>
    ///  Struct for Transaction End Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TransactionEndMessage {
        TimeOffset TimeOffset;
    };


    /// <summary>
    ///  Struct for Unit Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitClearMessage {
        TimeOffset TimeOffset;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
