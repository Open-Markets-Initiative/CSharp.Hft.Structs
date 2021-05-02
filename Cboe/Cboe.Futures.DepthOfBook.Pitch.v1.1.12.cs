namespace Cboe.Futures.DepthOfBook.Pitch.v1.1.12 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Block Volume
    /// </summary>
    public unsafe struct BlockVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Canceled Long Quantity
    /// </summary>
    public unsafe struct CanceledLongQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Canceled Short Quantity
    /// </summary>
    public unsafe struct CanceledShortQuantity {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Close Price
    /// </summary>
    public unsafe struct ClosePrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Date
    /// </summary>
    public unsafe struct ContractDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Size
    /// </summary>
    public unsafe struct ContractSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Discount Factor
    /// </summary>
    public struct DiscountFactor {
        public long Raw;
    };


    /// <summary>
    ///  Ecrp Volume
    /// </summary>
    public unsafe struct EcrpVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Epoch
    /// </summary>
    public unsafe struct Epoch {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Expiration Date
    /// </summary>
    public unsafe struct ExpirationDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fed Funds Rate
    /// </summary>
    public struct FedFundsRate {
        public long Raw;
    };


    /// <summary>
    ///  Futures Flags Values
    /// </summary>
    public enum FuturesFlags : byte {
        Standard = 0,
        Variance = 1,
    };


    /// <summary>
    ///  High Price
    /// </summary>
    public unsafe struct HighPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Price Is Bid
    /// </summary>
    public unsafe struct HighPriceIsBid {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  High Price Valid
    /// </summary>
    public unsafe struct HighPriceValid {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Initial Strike
    /// </summary>
    public unsafe struct InitialStrike {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Values
    /// </summary>
    public enum Issue : byte {
        InitialSettlement = (byte)'S',
        ReissuedSettlement = (byte)'R',
        IndicativeSettlement = (byte)'I',
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
    ///  Leg Offset
    /// </summary>
    public unsafe struct LegOffset {
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
    ///  Leg Symbol
    /// </summary>
    public unsafe struct LegSymbol {
        public const int Size = 6;

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
    ///  Listing State Values
    /// </summary>
    public enum ListingState : byte {
        Active = (byte)'A',
        Inactive = (byte)'I',
        Test = (byte)'T',
    };


    /// <summary>
    ///  Long Price
    /// </summary>
    public unsafe struct LongPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Long Quantity
    /// </summary>
    public unsafe struct LongQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Low Price
    /// </summary>
    public unsafe struct LowPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Low Price Is Offer
    /// </summary>
    public unsafe struct LowPriceIsOffer {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Low Price Valid
    /// </summary>
    public unsafe struct LowPriceValid {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
        TimeReferenceMessage = 0xB1,
        FuturesInstrumentDefinitionMessage = 0xBB,
        AddOrderLongMessage = 0x21,
        AddOrderShortMessage = 0x22,
        OrderExecutedMessage = 0x23,
        ReduceSizeLongMessage = 0x25,
        ReduceSizeShortMessage = 0x26,
        ModifyOrderLongMessage = 0x27,
        ModifyOrderShortMessage = 0x28,
        DeleteOrderMessage = 0x29,
        TradeLongMessage = 0x2A,
        TradeShortMessage = 0x2B,
        TransactionBegin = 0xBC,
        TransactionEnd = 0xBD,
        TradeBreakMessage = 0x2C,
        SettlementMessage = 0xB9,
        EndOfDaySummaryMessage = 0xBA,
        TradingStatusMessage = 0x31,
        EndOfSessionMessage = 0x2D,
    };


    /// <summary>
    ///  Midnight Reference
    /// </summary>
    public unsafe struct MidnightReference {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Elapsed Returns
    /// </summary>
    public unsafe struct NumElapsedReturns {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Expected Prices
    /// </summary>
    public unsafe struct NumExpectedPrices {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Close Valid
    /// </summary>
    public unsafe struct OfferCloseValid {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Open Interest
    /// </summary>
    public unsafe struct OpenInterest {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Price
    /// </summary>
    public unsafe struct OpenPrice {
        public const int Size = 8;

        public long Value;

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
    ///  Previous Armvm
    /// </summary>
    public struct PreviousArmvm {
        public long Raw;
    };


    /// <summary>
    ///  Previous Settlement
    /// </summary>
    public unsafe struct PreviousSettlement {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Increment
    /// </summary>
    public unsafe struct PriceIncrement {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Realized Variance
    /// </summary>
    public struct RealizedVariance {
        public long Raw;
    };


    /// <summary>
    ///  Report Symbol
    /// </summary>
    public unsafe struct ReportSymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 2
    /// </summary>
    public unsafe struct Reserved2 {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 3
    /// </summary>
    public unsafe struct Reserved3 {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Flags
    /// </summary>
    public unsafe struct ReservedFlags {
        public const int Size = 7;

        public fixed byte Bytes[Size];
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
    ///  Settlement Price
    /// </summary>
    public unsafe struct SettlementPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Short Price
    /// </summary>
    public unsafe struct ShortPrice {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Short Quantity
    /// </summary>
    public unsafe struct ShortQuantity {
        public const int Size = 2;

        public short Value;

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
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Total Volume
    /// </summary>
    public unsafe struct TotalVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        NormalTrade = (byte)' ',
        OpeningTrade = (byte)'O',
        SpreadTrade = (byte)'S',
        BlockTrade = (byte)'B',
        EcrpTrade = (byte)'E',
    };


    /// <summary>
    ///  Trade Date
    /// </summary>
    public unsafe struct TradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        Halted = (byte)'H',
        QuoteOnly = (byte)'Q',
        ExchangeSpecificSuspension = (byte)'S',
        Trading = (byte)'T',
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
    ///  Unit Timestamp
    /// </summary>
    public unsafe struct UnitTimestamp {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Variance Block Offset
    /// </summary>
    public unsafe struct VarianceBlockOffset {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Order Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        LongQuantity LongQuantity;
        Symbol Symbol;
        LongPrice LongPrice;
    };


    /// <summary>
    ///  Struct for Add Order Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        ShortQuantity ShortQuantity;
        Symbol Symbol;
        ShortPrice ShortPrice;
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
    ///  Struct for End Of Day Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDaySummaryMessage {
        TimeOffset TimeOffset;
        Symbol Symbol;
        TradeDate TradeDate;
        OpenInterest OpenInterest;
        HighPrice HighPrice;
        LowPrice LowPrice;
        OpenPrice OpenPrice;
        ClosePrice ClosePrice;
        TotalVolume TotalVolume;
        BlockVolume BlockVolume;
        EcrpVolume EcrpVolume;
        SummaryFlags SummaryFlags;
    };


    /// <summary>
    ///  Struct for End Of Session Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfSessionMessage {
        TimeOffset TimeOffset;
    };


    /// <summary>
    ///  Struct for Future Leg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FutureLeg {
        LegRatio LegRatio;
        LegSymbol LegSymbol;
    };


    /// <summary>
    ///  Struct for Futures Instrument Definition Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FuturesInstrumentDefinitionMessage {
        TimeOffset TimeOffset;
        Symbol Symbol;
        UnitTimestamp UnitTimestamp;
        ReportSymbol ReportSymbol;
        FuturesFlags FuturesFlags;
        ExpirationDate ExpirationDate;
        ContractSize ContractSize;
        ListingState ListingState;
        PriceIncrement PriceIncrement;
        LegCount LegCount;
        LegOffset LegOffset;
        VarianceBlockOffset VarianceBlockOffset;
        ContractDate ContractDate;
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
        LongQuantity LongQuantity;
        LongPrice LongPrice;
    };


    /// <summary>
    ///  Struct for Modify Order Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        ShortQuantity ShortQuantity;
        ShortPrice ShortPrice;
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
        CanceledLongQuantity CanceledLongQuantity;
    };


    /// <summary>
    ///  Struct for Reduce Size Short Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReduceSizeShortMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        CanceledShortQuantity CanceledShortQuantity;
    };


    /// <summary>
    ///  Struct for Settlement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlementMessage {
        TimeOffset TimeOffset;
        Symbol Symbol;
        TradeDate TradeDate;
        SettlementPrice SettlementPrice;
        Issue Issue;
    };


    /// <summary>
    ///  Struct for Standard
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Standard {
    };


    /// <summary>
    ///  Struct for Summary Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SummaryFlags {
        ReservedFlags ReservedFlags;
        OfferCloseValid OfferCloseValid;
        LowPriceIsOffer LowPriceIsOffer;
        LowPriceValid LowPriceValid;
        HighPriceIsBid HighPriceIsBid;
        HighPriceValid HighPriceValid;
    };


    /// <summary>
    ///  Struct for Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeMessage {
        Time Time;
        Epoch Epoch;
    };


    /// <summary>
    ///  Struct for Time Reference Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeReferenceMessage {
        MidnightReference MidnightReference;
        Time Time;
        TimeOffset TimeOffset;
        TradeDate TradeDate;
    };


    /// <summary>
    ///  Struct for Trade Break Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeBreakMessage {
        TimeOffset TimeOffset;
        ExecutionId ExecutionId;
    };


    /// <summary>
    ///  Struct for Trade Long Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeLongMessage {
        TimeOffset TimeOffset;
        OrderId OrderId;
        SideIndicator SideIndicator;
        LongQuantity LongQuantity;
        Symbol Symbol;
        LongPrice LongPrice;
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
        ShortQuantity ShortQuantity;
        Symbol Symbol;
        ShortPrice ShortPrice;
        ExecutionId ExecutionId;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingStatusMessage {
        TimeOffset TimeOffset;
        Symbol Symbol;
        Reserved2 Reserved2;
        TradingStatus TradingStatus;
        Reserved3 Reserved3;
    };


    /// <summary>
    ///  Struct for Transaction Begin
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TransactionBegin {
        TimeOffset TimeOffset;
    };


    /// <summary>
    ///  Struct for Transaction End
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TransactionEnd {
        TimeOffset TimeOffset;
    };


    /// <summary>
    ///  Struct for Unit Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitClearMessage {
        TimeOffset TimeOffset;
    };


    /// <summary>
    ///  Struct for Variance
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Variance {
        RealizedVariance RealizedVariance;
        NumExpectedPrices NumExpectedPrices;
        NumElapsedReturns NumElapsedReturns;
        PreviousSettlement PreviousSettlement;
        DiscountFactor DiscountFactor;
        InitialStrike InitialStrike;
        PreviousArmvm PreviousArmvm;
        FedFundsRate FedFundsRate;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
