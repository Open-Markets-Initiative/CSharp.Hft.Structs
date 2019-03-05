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
    ///  Activated Values
    /// </summary>
    public enum Activated : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Aot Lower Price
    /// </summary>
    public struct AotLowerPrice {
        public int Raw;
    };


    /// <summary>
    ///  Aot Price
    /// </summary>
    public struct AotPrice {
        public int Raw;
    };


    /// <summary>
    ///  Aot Upper Price
    /// </summary>
    public struct AotUpperPrice {
        public int Raw;
    };


    /// <summary>
    ///  Best Ask Price
    /// </summary>
    public struct BestAskPrice {
        public int Raw;
    };


    /// <summary>
    ///  Best Ask Quantity
    /// </summary>
    public unsafe struct BestAskQuantity {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Price
    /// </summary>
    public struct BestBidPrice {
        public int Raw;
    };


    /// <summary>
    ///  Best Bid Quantity
    /// </summary>
    public unsafe struct BestBidQuantity {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Buyer
    /// </summary>
    public unsafe struct Buyer {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Buyer Order Number
    /// </summary>
    public unsafe struct BuyerOrderNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Buyer Quantity Remaining
    /// </summary>
    public unsafe struct BuyerQuantityRemaining {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Buying Order Number
    /// </summary>
    public unsafe struct BuyingOrderNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number
    /// </summary>
    public unsafe struct ContractNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number Leg 1
    /// </summary>
    public unsafe struct ContractNumberLeg1 {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number Leg 2
    /// </summary>
    public unsafe struct ContractNumberLeg2 {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number Leg 3
    /// </summary>
    public unsafe struct ContractNumberLeg3 {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number Leg 4
    /// </summary>
    public unsafe struct ContractNumberLeg4 {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number Leg 5
    /// </summary>
    public unsafe struct ContractNumberLeg5 {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Number Leg 6
    /// </summary>
    public unsafe struct ContractNumberLeg6 {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Type Values
    /// </summary>
    public enum ContractType : byte {
        Cfut = (byte)'F',
        Copta = (byte)'O',
        Eopta = (byte)'E',
        Oopt = (byte)'N',
        Csprd = (byte)'S',
        Sprd = (byte)'A',
        Sfut = (byte)'D',
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
    ///  Coupon Rate
    /// </summary>
    public unsafe struct CouponRate {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cumulative Volume
    /// </summary>
    public unsafe struct CumulativeVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Currency
    /// </summary>
    public unsafe struct Currency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Custom Market Order Number
    /// </summary>
    public unsafe struct CustomMarketOrderNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Custom Market Quantity Remaining
    /// </summary>
    public unsafe struct CustomMarketQuantityRemaining {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Equilibrium Price
    /// </summary>
    public struct EquilibriumPrice {
        public int Raw;
    };


    /// <summary>
    ///  Etr Lower Price
    /// </summary>
    public struct EtrLowerPrice {
        public int Raw;
    };


    /// <summary>
    ///  Etr Price
    /// </summary>
    public struct EtrPrice {
        public int Raw;
    };


    /// <summary>
    ///  Etr Upper Price
    /// </summary>
    public struct EtrUpperPrice {
        public int Raw;
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        Open = (byte)'O',
        Start = (byte)'S',
        End = (byte)'C',
        Paused = (byte)'P',
        Resumed = (byte)'R',
    };


    /// <summary>
    ///  Exchange
    /// </summary>
    public unsafe struct Exchange {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Executed Quantity
    /// </summary>
    public unsafe struct ExecutedQuantity {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiry Month
    /// </summary>
    public unsafe struct ExpiryMonth {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiry Year
    /// </summary>
    public unsafe struct ExpiryYear {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Financial Type Values
    /// </summary>
    public enum FinancialType : byte {
        Commodity = (byte)'C',
        Cfd = (byte)'D',
        Equity = (byte)'E',
        GovernmentBond = (byte)'X',
        BankBill = (byte)'B',
    };


    /// <summary>
    ///  First Leg Contract Number
    /// </summary>
    public unsafe struct FirstLegContractNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Highest Trade
    /// </summary>
    public struct HighestTrade {
        public int Raw;
    };


    /// <summary>
    ///  Highest Traded Price
    /// </summary>
    public unsafe struct HighestTradedPrice {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Instrument
    /// </summary>
    public unsafe struct Instrument {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Trade
    /// </summary>
    public struct LastTrade {
        public int Raw;
    };


    /// <summary>
    ///  Last Traded Price
    /// </summary>
    public unsafe struct LastTradedPrice {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Traded Volume
    /// </summary>
    public unsafe struct LastTradedVolume {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Trading Date
    /// </summary>
    public unsafe struct LastTradingDate {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Volume
    /// </summary>
    public unsafe struct LastVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Legs
    /// </summary>
    public unsafe struct Legs {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
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
    ///  Lot Size Or Face Value
    /// </summary>
    public unsafe struct LotSizeOrFaceValue {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lowest Trade
    /// </summary>
    public struct LowestTrade {
        public int Raw;
    };


    /// <summary>
    ///  Lowest Traded Price
    /// </summary>
    public unsafe struct LowestTradedPrice {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Market Updates
    /// </summary>
    public unsafe struct MarketUpdates {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Maturity Value
    /// </summary>
    public unsafe struct MaturityValue {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        TimeMessage = (byte)'T',
        SystemEvent = (byte)'S',
        FutureSymbolDirectory = (byte)'f',
        SpreadSymbolDirectory = (byte)'g',
        OptionSymbolDirectory = (byte)'h',
        OrderBookState = (byte)'O',
        OrderAdded = (byte)'A',
        OrderReplaced = (byte)'U',
        OrderVolumeCancelled = (byte)'X',
        OrderDeleted = (byte)'D',
        ImpliedOrderAdded = (byte)'j',
        ImpliedOrderReplaced = (byte)'l',
        ImpliedOrderDeleted = (byte)'k',
        CustomMarketOrderAdded = (byte)'m',
        CustomMarketOrderReplaced = (byte)'n',
        CustomMarketOrderDeleted = (byte)'r',
        OrderExecuted = (byte)'E',
        OrderExecutedWithPrice = (byte)'C',
        SpreadExecuted = (byte)'e',
        TradeSpreadExecutionChain = (byte)'P',
        CustomMarketExecuted = (byte)'u',
        CustomMarketTrade = (byte)'p',
        TradeCancellation = (byte)'B',
        EquilibriumPriceAuctionInfo = (byte)'Z',
        OpenHighLowLastTradeAdjustment = (byte)'t',
        MarketSettlement = (byte)'Y',
        AdHocText = (byte)'x',
        RequestForQuote = (byte)'q',
        AnomalousOrderThresholdPublish = (byte)'W',
        VolumeAndOpenInterest = (byte)'V',
    };


    /// <summary>
    ///  Open Interest
    /// </summary>
    public unsafe struct OpenInterest {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opening Trade
    /// </summary>
    public struct OpeningTrade {
        public int Raw;
    };


    /// <summary>
    ///  Opening Trade Price
    /// </summary>
    public unsafe struct OpeningTradePrice {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Option Type Values
    /// </summary>
    public enum OptionType : byte {
        Put = (byte)'P',
        Call = (byte)'C',
    };


    /// <summary>
    ///  Order Book Priority
    /// </summary>
    public unsafe struct OrderBookPriority {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Number
    /// </summary>
    public unsafe struct OrderNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Payments Per Year
    /// </summary>
    public unsafe struct PaymentsPerYear {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
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
    ///  Price Decimal Position
    /// </summary>
    public unsafe struct PriceDecimalPosition {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Fractional Denominator
    /// </summary>
    public unsafe struct PriceFractionalDenominator {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Leg 1
    /// </summary>
    public struct PriceLeg1 {
        public int Raw;
    };


    /// <summary>
    ///  Price Leg 2
    /// </summary>
    public struct PriceLeg2 {
        public int Raw;
    };


    /// <summary>
    ///  Price Leg 3
    /// </summary>
    public struct PriceLeg3 {
        public int Raw;
    };


    /// <summary>
    ///  Price Leg 4
    /// </summary>
    public struct PriceLeg4 {
        public int Raw;
    };


    /// <summary>
    ///  Price Leg 5
    /// </summary>
    public struct PriceLeg5 {
        public int Raw;
    };


    /// <summary>
    ///  Price Leg 6
    /// </summary>
    public struct PriceLeg6 {
        public int Raw;
    };


    /// <summary>
    ///  Price Minimum Tick
    /// </summary>
    public unsafe struct PriceMinimumTick {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Primary Ratio
    /// </summary>
    public unsafe struct PrimaryRatio {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Printable Values
    /// </summary>
    public enum Printable : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Prior Day Settlement
    /// </summary>
    public struct PriorDaySettlement {
        public int Raw;
    };


    /// <summary>
    ///  Protocol Version
    /// </summary>
    public unsafe struct ProtocolVersion {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quantity
    /// </summary>
    public unsafe struct Quantity {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quantity Remaining
    /// </summary>
    public unsafe struct QuantityRemaining {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Leg 1
    /// </summary>
    public unsafe struct RatioLeg1 {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Leg 2
    /// </summary>
    public unsafe struct RatioLeg2 {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Leg 3
    /// </summary>
    public unsafe struct RatioLeg3 {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Leg 4
    /// </summary>
    public unsafe struct RatioLeg4 {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Leg 5
    /// </summary>
    public unsafe struct RatioLeg5 {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Leg 6
    /// </summary>
    public unsafe struct RatioLeg6 {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 2;

        public fixed byte Bytes[Size];
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
    ///  Second Leg Contract Number
    /// </summary>
    public unsafe struct SecondLegContractNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secondary Ratio
    /// </summary>
    public unsafe struct SecondaryRatio {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seller Contract Number
    /// </summary>
    public unsafe struct SellerContractNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seller Quantity Remaining
    /// </summary>
    public unsafe struct SellerQuantityRemaining {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Selling Order Number
    /// </summary>
    public unsafe struct SellingOrderNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
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
    ///  Session Week
    /// </summary>
    public unsafe struct SessionWeek {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Year
    /// </summary>
    public unsafe struct SessionYear {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Price
    /// </summary>
    public struct SettlementPrice {
        public int Raw;
    };


    /// <summary>
    ///  Settlement Type
    /// </summary>
    public unsafe struct SettlementType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Sell = (byte)'S',
        Buy = (byte)'B',
    };


    /// <summary>
    ///  Side Leg 1
    /// </summary>
    public unsafe struct SideLeg1 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Leg 2
    /// </summary>
    public unsafe struct SideLeg2 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Leg 3
    /// </summary>
    public unsafe struct SideLeg3 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Leg 4
    /// </summary>
    public unsafe struct SideLeg4 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Leg 5
    /// </summary>
    public unsafe struct SideLeg5 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Leg 6
    /// </summary>
    public unsafe struct SideLeg6 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Of Buyer
    /// </summary>
    public unsafe struct SideOfBuyer {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Of Seller
    /// </summary>
    public unsafe struct SideOfSeller {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Id
    /// </summary>
    public unsafe struct SourceId {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Spread Trade Price
    /// </summary>
    public struct SpreadTradePrice {
        public int Raw;
    };


    /// <summary>
    ///  Strike
    /// </summary>
    public unsafe struct Strike {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Decimal Position
    /// </summary>
    public unsafe struct StrikePriceDecimalPosition {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Fractional Denominator
    /// </summary>
    public unsafe struct StrikePriceFractionalDenominator {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Minimum Tick
    /// </summary>
    public unsafe struct StrikePriceMinimumTick {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Text Message
    /// </summary>
    public unsafe struct TextMessage {
        public const int Size = 100;

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
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Traded Volume
    /// </summary>
    public unsafe struct TotalTradedVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Traded Volume and Total Trades
    /// </summary>
    public unsafe struct TotalTradedVolumeAndTotalTrades {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Total Trades
    /// </summary>
    public unsafe struct TotalTrades {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Date
    /// </summary>
    public unsafe struct TradeDate {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public struct TradePrice {
        public int Raw;
    };


    /// <summary>
    ///  Trade Side Of Leg
    /// </summary>
    public unsafe struct TradeSideOfLeg {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Side Of Non Custom Order
    /// </summary>
    public unsafe struct TradeSideOfNonCustomOrder {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Type Values
    /// </summary>
    public enum TradeType : byte {
        Normal = (byte)'T',
        CrossingNormal = (byte)'t',
        Sweeping = (byte)'W',
        CrossingSweeping = (byte)'w',
        Levelling = (byte)'L',
        CrossingLevelling = (byte)'l',
        SpreadToUnderlying = (byte)'S',
        CrossingSpreadToUnderlying = (byte)'s',
        IntraSpread = (byte)'R',
        CrossingIntraSpread = (byte)'r',
        InterSpread = (byte)'Q',
        CrossingInterSpread = (byte)'q',
        Custom = (byte)'U',
        CrossingCustom = (byte)'u',
    };


    /// <summary>
    ///  Traded Contract Number
    /// </summary>
    public unsafe struct TradedContractNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Service
    /// </summary>
    public unsafe struct TradingService {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        Pending = (byte)'p',
        Halted = (byte)'H',
        PreOpen = (byte)'P',
        Closed = (byte)'C',
        Levelling = (byte)'l',
        Locked = (byte)'L',
        Opened = (byte)'O',
        Unavailable = (byte)'U',
        PrePriceDiscovery = (byte)'d',
        Inactive = (byte)'I',
        PriceDiscovery = (byte)'D',
        Activated = (byte)'A',
        RegulatoryHalt = (byte)'R',
    };


    /// <summary>
    ///  Underlying Contract Number
    /// </summary>
    public unsafe struct UnderlyingContractNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Voi Trade Date
    /// </summary>
    public unsafe struct VoiTradeDate {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Volatility
    /// </summary>
    public unsafe struct Volatility {
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
    ///  Struct for Ad Hoc Text
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdHocText {
        Timestamp Timestamp;
        TradeDate TradeDate;
        SourceId SourceId;
        TextMessage TextMessage;
    };


    /// <summary>
    ///  Struct for Anomalous Order Threshold Publish
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AnomalousOrderThresholdPublish {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        AotPrice AotPrice;
        AotUpperPrice AotUpperPrice;
        AotLowerPrice AotLowerPrice;
        EtrPrice EtrPrice;
        EtrUpperPrice EtrUpperPrice;
        EtrLowerPrice EtrLowerPrice;
    };


    /// <summary>
    ///  Struct for Custom Market Executed
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CustomMarketExecuted {
        Timestamp Timestamp;
        TradeDate TradeDate;
        OrderNumber OrderNumber;
        QuantityRemaining QuantityRemaining;
        TradeType TradeType;
        MatchNumber MatchNumber;
        ExecutedQuantity ExecutedQuantity;
        TradePrice TradePrice;
        TradedContractNumber TradedContractNumber;
        TradeSideOfLeg TradeSideOfLeg;
        Printable Printable;
    };


    /// <summary>
    ///  Struct for Custom Market Order Added
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CustomMarketOrderAdded {
        Timestamp Timestamp;
        TradeDate TradeDate;
        OrderNumber OrderNumber;
        OrderBookPriority OrderBookPriority;
        Quantity Quantity;
        Legs Legs;
        ContractNumberLeg1 ContractNumberLeg1;
        SideLeg1 SideLeg1;
        RatioLeg1 RatioLeg1;
        PriceLeg1 PriceLeg1;
        ContractNumberLeg2 ContractNumberLeg2;
        SideLeg2 SideLeg2;
        RatioLeg2 RatioLeg2;
        PriceLeg2 PriceLeg2;
        ContractNumberLeg3 ContractNumberLeg3;
        SideLeg3 SideLeg3;
        RatioLeg3 RatioLeg3;
        PriceLeg3 PriceLeg3;
        ContractNumberLeg4 ContractNumberLeg4;
        SideLeg4 SideLeg4;
        RatioLeg4 RatioLeg4;
        PriceLeg4 PriceLeg4;
        ContractNumberLeg5 ContractNumberLeg5;
        SideLeg5 SideLeg5;
        RatioLeg5 RatioLeg5;
        PriceLeg5 PriceLeg5;
        ContractNumberLeg6 ContractNumberLeg6;
        SideLeg6 SideLeg6;
        RatioLeg6 RatioLeg6;
        PriceLeg6 PriceLeg6;
    };


    /// <summary>
    ///  Struct for Custom Market Order Deleted
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CustomMarketOrderDeleted {
        Timestamp Timestamp;
        TradeDate TradeDate;
        OrderNumber OrderNumber;
    };


    /// <summary>
    ///  Struct for Custom Market Order Replaced
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CustomMarketOrderReplaced {
        Timestamp Timestamp;
        TradeDate TradeDate;
        OrderNumber OrderNumber;
        OrderBookPriority OrderBookPriority;
        Quantity Quantity;
    };


    /// <summary>
    ///  Struct for Custom Market Trade
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CustomMarketTrade {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        QuantityRemaining QuantityRemaining;
        CustomMarketOrderNumber CustomMarketOrderNumber;
        CustomMarketQuantityRemaining CustomMarketQuantityRemaining;
        TradeType TradeType;
        MatchNumber MatchNumber;
        ExecutedQuantity ExecutedQuantity;
        TradePrice TradePrice;
        TradedContractNumber TradedContractNumber;
        TradeSideOfNonCustomOrder TradeSideOfNonCustomOrder;
        Printable Printable;
    };


    /// <summary>
    ///  Struct for Equilibrium Price Auction Info
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquilibriumPriceAuctionInfo {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        EquilibriumPrice EquilibriumPrice;
        BestBidPrice BestBidPrice;
        BestAskPrice BestAskPrice;
        BestBidQuantity BestBidQuantity;
        BestAskQuantity BestAskQuantity;
    };


    /// <summary>
    ///  Struct for Future Symbol Directory
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FutureSymbolDirectory {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Exchange Exchange;
        Instrument Instrument;
        ContractType ContractType;
        ExpiryYear ExpiryYear;
        ExpiryMonth ExpiryMonth;
        PriceDecimalPosition PriceDecimalPosition;
        PriceFractionalDenominator PriceFractionalDenominator;
        PriceMinimumTick PriceMinimumTick;
        LastTradingDate LastTradingDate;
        PriorDaySettlement PriorDaySettlement;
        FinancialType FinancialType;
        Currency Currency;
        LotSizeOrFaceValue LotSizeOrFaceValue;
        MaturityValue MaturityValue;
        CouponRate CouponRate;
        PaymentsPerYear PaymentsPerYear;
    };


    /// <summary>
    ///  Struct for Implied Order Added
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ImpliedOrderAdded {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        OrderBookPriority OrderBookPriority;
        Quantity Quantity;
        Price Price;
    };


    /// <summary>
    ///  Struct for Implied Order Deleted
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ImpliedOrderDeleted {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
    };


    /// <summary>
    ///  Struct for Implied Order Replaced
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ImpliedOrderReplaced {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        OrderBookPriority OrderBookPriority;
        Quantity Quantity;
        Price Price;
    };


    /// <summary>
    ///  Struct for Market Settlement
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSettlement {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        SettlementPrice SettlementPrice;
        Volatility Volatility;
        SettlementType SettlementType;
    };


    /// <summary>
    ///  Struct for Market Updates
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketUpdates {
        Reserved Reserved;
        LastTradedVolume LastTradedVolume;
        LastTradedPrice LastTradedPrice;
        TotalTradedVolumeAndTotalTrades TotalTradedVolumeAndTotalTrades;
        LowestTradedPrice LowestTradedPrice;
        HighestTradedPrice HighestTradedPrice;
        OpeningTradePrice OpeningTradePrice;
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
    ///  Struct for Open High Low Last Trade Adjustment
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenHighLowLastTradeAdjustment {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        OpeningTrade OpeningTrade;
        HighestTrade HighestTrade;
        LowestTrade LowestTrade;
        LastTrade LastTrade;
        LastVolume LastVolume;
        TotalTradedVolume TotalTradedVolume;
        TotalTrades TotalTrades;
        MarketUpdates MarketUpdates;
    };


    /// <summary>
    ///  Struct for Option Symbol Directory
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionSymbolDirectory {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Exchange Exchange;
        Instrument Instrument;
        ContractType ContractType;
        ExpiryYear ExpiryYear;
        ExpiryMonth ExpiryMonth;
        OptionType OptionType;
        Strike Strike;
        UnderlyingContractNumber UnderlyingContractNumber;
        PriceDecimalPosition PriceDecimalPosition;
        PriceFractionalDenominator PriceFractionalDenominator;
        PriceMinimumTick PriceMinimumTick;
        StrikePriceDecimalPosition StrikePriceDecimalPosition;
        StrikePriceFractionalDenominator StrikePriceFractionalDenominator;
        StrikePriceMinimumTick StrikePriceMinimumTick;
        LastTradingDate LastTradingDate;
        PriorDaySettlement PriorDaySettlement;
        Volatility Volatility;
        FinancialType FinancialType;
        Currency Currency;
        LotSizeOrFaceValue LotSizeOrFaceValue;
        MaturityValue MaturityValue;
        CouponRate CouponRate;
        PaymentsPerYear PaymentsPerYear;
        Activated Activated;
    };


    /// <summary>
    ///  Struct for Order Added
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAdded {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        OrderBookPriority OrderBookPriority;
        Quantity Quantity;
        Price Price;
    };


    /// <summary>
    ///  Struct for Order Book State
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderBookState {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        TradingStatus TradingStatus;
    };


    /// <summary>
    ///  Struct for Order Deleted
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDeleted {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
    };


    /// <summary>
    ///  Struct for Order Executed
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecuted {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        QuantityRemaining QuantityRemaining;
        TradeType TradeType;
        MatchNumber MatchNumber;
        ExecutedQuantity ExecutedQuantity;
        TradePrice TradePrice;
    };


    /// <summary>
    ///  Struct for Order Executed With Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedWithPrice {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        BuyingOrderNumber BuyingOrderNumber;
        BuyerQuantityRemaining BuyerQuantityRemaining;
        SellingOrderNumber SellingOrderNumber;
        SellerQuantityRemaining SellerQuantityRemaining;
        TradeType TradeType;
        MatchNumber MatchNumber;
        ExecutedQuantity ExecutedQuantity;
        TradePrice TradePrice;
    };


    /// <summary>
    ///  Struct for Order Replaced
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderReplaced {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        OrderBookPriority OrderBookPriority;
        Quantity Quantity;
        Price Price;
    };


    /// <summary>
    ///  Struct for Order Volume Cancelled
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderVolumeCancelled {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        Quantity Quantity;
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
    ///  Struct for Request For Quote
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestForQuote {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Price Price;
        Quantity Quantity;
    };


    /// <summary>
    ///  Struct for Session
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Session {
        ProtocolVersion ProtocolVersion;
        SessionYear SessionYear;
        SessionWeek SessionWeek;
        TradingService TradingService;
    };


    /// <summary>
    ///  Struct for Spread Executed
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SpreadExecuted {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Side Side;
        OrderNumber OrderNumber;
        QuantityRemaining QuantityRemaining;
        TradeType TradeType;
        MatchNumber MatchNumber;
        ExecutedQuantity ExecutedQuantity;
        TradePrice TradePrice;
        TradedContractNumber TradedContractNumber;
        SpreadTradePrice SpreadTradePrice;
        TradeSideOfLeg TradeSideOfLeg;
        Printable Printable;
    };


    /// <summary>
    ///  Struct for Spread Symbol Directory
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SpreadSymbolDirectory {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        Exchange Exchange;
        ContractType ContractType;
        FirstLegContractNumber FirstLegContractNumber;
        SecondLegContractNumber SecondLegContractNumber;
        PrimaryRatio PrimaryRatio;
        SecondaryRatio SecondaryRatio;
        PriceDecimalPosition PriceDecimalPosition;
        PriceFractionalDenominator PriceFractionalDenominator;
        PriceMinimumTick PriceMinimumTick;
    };


    /// <summary>
    ///  Struct for System Event
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEvent {
        Timestamp Timestamp;
        TradeDate TradeDate;
        EventCode EventCode;
    };


    /// <summary>
    ///  Struct for Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimeMessage {
        Second Second;
    };


    /// <summary>
    ///  Struct for Trade Cancellation
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancellation {
        Timestamp Timestamp;
        TradeDate TradeDate;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Trade Spread Execution Chain
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeSpreadExecutionChain {
        Timestamp Timestamp;
        TradeDate TradeDate;
        Buyer Buyer;
        SideOfBuyer SideOfBuyer;
        BuyerOrderNumber BuyerOrderNumber;
        BuyerQuantityRemaining BuyerQuantityRemaining;
        SellerContractNumber SellerContractNumber;
        SideOfSeller SideOfSeller;
        SellingOrderNumber SellingOrderNumber;
        SellerQuantityRemaining SellerQuantityRemaining;
        TradeType TradeType;
        MatchNumber MatchNumber;
        ExecutedQuantity ExecutedQuantity;
        TradePrice TradePrice;
        TradedContractNumber TradedContractNumber;
        SpreadTradePrice SpreadTradePrice;
        Printable Printable;
    };


    /// <summary>
    ///  Struct for Volume And Open Interest
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VolumeAndOpenInterest {
        Timestamp Timestamp;
        TradeDate TradeDate;
        ContractNumber ContractNumber;
        CumulativeVolume CumulativeVolume;
        OpenInterest OpenInterest;
        VoiTradeDate VoiTradeDate;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
