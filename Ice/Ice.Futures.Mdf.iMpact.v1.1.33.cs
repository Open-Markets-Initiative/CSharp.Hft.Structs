namespace Ice.Futures.Mdf.iMpact.v1.1.33 {

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
    ///  Agg Bid Qty
    /// </summary>
    public struct AggBidQty {
        public int Raw;
    };


    /// <summary>
    ///  Agg Offer Qty
    /// </summary>
    public struct AggOfferQty {
        public int Raw;
    };


    /// <summary>
    ///  Aggressor Side Values
    /// </summary>
    public enum AggressorSide : byte {
        None = (byte)'',
        Buy = (byte)'1',
        Sell = (byte)'2',
    };


    /// <summary>
    ///  Allow Options Values
    /// </summary>
    public enum AllowOptions : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Allows Implied Values
    /// </summary>
    public enum AllowsImplied : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Auction Date
    /// </summary>
    public unsafe struct AuctionDate {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction End Time
    /// </summary>
    public struct AuctionEndTime {
        public long Raw;
    };


    /// <summary>
    ///  Begin Day
    /// </summary>
    public struct BeginDay {
        public short Raw;
    };


    /// <summary>
    ///  Begin Month
    /// </summary>
    public struct BeginMonth {
        public short Raw;
    };


    /// <summary>
    ///  Begin Year
    /// </summary>
    public struct BeginYear {
        public short Raw;
    };


    /// <summary>
    ///  Block Volume
    /// </summary>
    public struct BlockVolume {
        public int Raw;
    };


    /// <summary>
    ///  Cleared Alias
    /// </summary>
    public unsafe struct ClearedAlias {
        public const int Size = 15;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Close Price
    /// </summary>
    public struct ClosePrice {
        public long Raw;
    };


    /// <summary>
    ///  Contract Symbol
    /// </summary>
    public unsafe struct ContractSymbol {
        public const int Size = 35;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Symbol Extra
    /// </summary>
    public unsafe struct ContractSymbolExtra {
        public const int Size = 35;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Cross Order Supported Values
    /// </summary>
    public enum CrossOrderSupported : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Currency
    /// </summary>
    public unsafe struct Currency {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Date Time
    /// </summary>
    public struct DateTime {
        public long Raw;
    };


    /// <summary>
    ///  Deal Price Denominator
    /// </summary>
    public unsafe struct DealPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Delivery Begin Date Time
    /// </summary>
    public struct DeliveryBeginDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Delivery End Date Time
    /// </summary>
    public struct DeliveryEndDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Delta
    /// </summary>
    public struct Delta {
        public long Raw;
    };


    /// <summary>
    ///  Description
    /// </summary>
    public unsafe struct Description {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efp Volume
    /// </summary>
    public struct EfpVolume {
        public int Raw;
    };


    /// <summary>
    ///  Efs Volume
    /// </summary>
    public struct EfsVolume {
        public int Raw;
    };


    /// <summary>
    ///  End Day
    /// </summary>
    public struct EndDay {
        public short Raw;
    };


    /// <summary>
    ///  End Month
    /// </summary>
    public struct EndMonth {
        public short Raw;
    };


    /// <summary>
    ///  End Year
    /// </summary>
    public struct EndYear {
        public short Raw;
    };


    /// <summary>
    ///  Eur Price
    /// </summary>
    public struct EurPrice {
        public long Raw;
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        NormalTrade = (byte)'0',
        CancelledTrade = (byte)'1',
        AdjustedTrade = (byte)'2',
    };


    /// <summary>
    ///  Event Type
    /// </summary>
    public unsafe struct EventType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exchange Silo Values
    /// </summary>
    public enum ExchangeSilo : byte {
        Ice = (byte)'0',
        Endex = (byte)'1',
        Liffe = (byte)'2',
    };


    /// <summary>
    ///  Extra Flags
    /// </summary>
    public struct ExtraFlags {
        public sbyte Raw;
    };


    /// <summary>
    ///  Flex Allowed
    /// </summary>
    public unsafe struct FlexAllowed {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Futures Contract Symbol
    /// </summary>
    public unsafe struct FuturesContractSymbol {
        public const int Size = 70;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Gbp Price
    /// </summary>
    public struct GbpPrice {
        public long Raw;
    };


    /// <summary>
    ///  Gt Allowed Values
    /// </summary>
    public enum GtAllowed : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Guaranteed Cross Supported Values
    /// </summary>
    public enum GuaranteedCrossSupported : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Has Pre Open Volume
    /// </summary>
    public unsafe struct HasPreOpenVolume {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Has Previous Day Settlement Price Values
    /// </summary>
    public enum HasPreviousDaySettlementPrice : byte {
        No = (byte)'N',
        Yes = (byte)'Y',
    };


    /// <summary>
    ///  Hedge Body Length
    /// </summary>
    public unsafe struct HedgeBodyLength {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hedge Delta
    /// </summary>
    public unsafe struct HedgeDelta {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hedge Market Id
    /// </summary>
    public unsafe struct HedgeMarketId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hedge Only Values
    /// </summary>
    public enum HedgeOnly : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Hedge Price
    /// </summary>
    public unsafe struct HedgePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hedge Price Denominator
    /// </summary>
    public unsafe struct HedgePriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hedge Security Type
    /// </summary>
    public unsafe struct HedgeSecurityType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hedge Side Values
    /// </summary>
    public enum HedgeSide : byte {
        None = (byte)'',
        Bid = (byte)'1',
        Offer = (byte)'2',
    };


    /// <summary>
    ///  Hedge Strategy Code
    /// </summary>
    public unsafe struct HedgeStrategyCode {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High
    /// </summary>
    public struct High {
        public long Raw;
    };


    /// <summary>
    ///  Hub Alias
    /// </summary>
    public unsafe struct HubAlias {
        public const int Size = 80;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hub Id
    /// </summary>
    public struct HubId {
        public int Raw;
    };


    /// <summary>
    ///  Iba Currency
    /// </summary>
    public unsafe struct IbaCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Implied Order Count
    /// </summary>
    public struct ImpliedOrderCount {
        public short Raw;
    };


    /// <summary>
    ///  Implied Quantity
    /// </summary>
    public struct ImpliedQuantity {
        public int Raw;
    };


    /// <summary>
    ///  Increment Premium Price
    /// </summary>
    public struct IncrementPremiumPrice {
        public int Raw;
    };


    /// <summary>
    ///  Increment Price
    /// </summary>
    public struct IncrementPrice {
        public int Raw;
    };


    /// <summary>
    ///  Increment Qty
    /// </summary>
    public struct IncrementQty {
        public int Raw;
    };


    /// <summary>
    ///  Investigation Status Values
    /// </summary>
    public enum InvestigationStatus : byte {
        UnderInvestigation = (byte)'1',
        InvestigationCompleted = (byte)'2',
    };


    /// <summary>
    ///  Ipl Down
    /// </summary>
    public struct IplDown {
        public long Raw;
    };


    /// <summary>
    ///  Ipl Hold Duration
    /// </summary>
    public struct IplHoldDuration {
        public int Raw;
    };


    /// <summary>
    ///  Ipl Hold Type Values
    /// </summary>
    public enum IplHoldType : byte {
        IplHoldStart = (byte)'S',
        IplHoldEnd = (byte)'E',
    };


    /// <summary>
    ///  Ipl Up
    /// </summary>
    public struct IplUp {
        public long Raw;
    };


    /// <summary>
    ///  Is Adjusted Trade
    /// </summary>
    public unsafe struct IsAdjustedTrade {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Is Balanced Values
    /// </summary>
    public enum IsBalanced : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is Block Only Values
    /// </summary>
    public enum IsBlockOnly : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is Final Values
    /// </summary>
    public enum IsFinal : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is Implied
    /// </summary>
    public unsafe struct IsImplied {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Is Implied Spread At Market Open
    /// </summary>
    public unsafe struct IsImpliedSpreadAtMarketOpen {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Is Official Values
    /// </summary>
    public enum IsOfficial : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is Rfq
    /// </summary>
    public unsafe struct IsRfq {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Is Settle Price Official Values
    /// </summary>
    public enum IsSettlePriceOfficial : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is System Priced Leg Values
    /// </summary>
    public enum IsSystemPricedLeg : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is Tradable Values
    /// </summary>
    public enum IsTradable : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Is Up Values
    /// </summary>
    public enum IsUp : byte {
        IplUpperBoundViolation = (byte)'Y',
        IplLowerBoundViolation = (byte)'N',
        Final = (byte)'F',
        NonEndexSpotMarket = (byte)'',
    };


    /// <summary>
    ///  Isin
    /// </summary>
    public unsafe struct Isin {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Message Sequence Id
    /// </summary>
    public struct LastMessageSequenceId {
        public int Raw;
    };


    /// <summary>
    ///  Last Trade Date Time
    /// </summary>
    public struct LastTradeDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Last Trade Price
    /// </summary>
    public struct LastTradePrice {
        public long Raw;
    };


    /// <summary>
    ///  Last Trade Quantity
    /// </summary>
    public struct LastTradeQuantity {
        public int Raw;
    };


    /// <summary>
    ///  Leg Body Length
    /// </summary>
    public unsafe struct LegBodyLength {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Deal Suppressed Values
    /// </summary>
    public enum LegDealSuppressed : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Leg Market Id
    /// </summary>
    public unsafe struct LegMarketId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio
    /// </summary>
    public unsafe struct LegRatio {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Price Denominator
    /// </summary>
    public unsafe struct LegRatioPriceDenominator {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Price Numerator
    /// </summary>
    public unsafe struct LegRatioPriceNumerator {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Qty Denominator
    /// </summary>
    public unsafe struct LegRatioQtyDenominator {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Qty Numerator
    /// </summary>
    public unsafe struct LegRatioQtyNumerator {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        None = (byte)'',
        Bid = (byte)'1',
        Offer = (byte)'2',
    };


    /// <summary>
    ///  Leg Strategy Code
    /// </summary>
    public unsafe struct LegStrategyCode {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Underlying Market Id
    /// </summary>
    public unsafe struct LegUnderlyingMarketId {
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
    ///  Lot Size
    /// </summary>
    public struct LotSize {
        public int Raw;
    };


    /// <summary>
    ///  Low
    /// </summary>
    public struct Low {
        public long Raw;
    };


    /// <summary>
    ///  Market Desc
    /// </summary>
    public unsafe struct MarketDesc {
        public const int Size = 120;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Id
    /// </summary>
    public struct MarketId {
        public int Raw;
    };


    /// <summary>
    ///  Market Type
    /// </summary>
    public struct MarketType {
        public short Raw;
    };


    /// <summary>
    ///  Market Type Id Values
    /// </summary>
    public enum MarketTypeId : short {
        FinancialGas = 0,
        FinancialPower = 1,
        Oil = 2,
        IpeNaturalGasFutures = 3,
        IpeGasOilFutures = 4,
        IpeBrentFutures = 5,
        IpeUkElectricityFuturesPeak = 7,
        IpeUkElectricityFuturesBase = 8,
        IceWtiCrudeFutures = 9,
        GCNewcastleCoalFutures = 10,
        IceBrentWtiFuturesSpread = 11,
        IpeecxEuropeanEmissions = 12,
        IceHeatingOilFutures = 13,
        IceHeatingOilWtiFuturesCrack = 14,
        IceNyhRbobGasolineFutures = 15,
        IceNyhRbobGasolineWtiFuturesCrack = 16,
        IceRotterdamCoalFutures = 17,
        IceRichardsBayCoalFutures = 18,
        IceRotterdamRichardsBayCoalFuturesSpread = 19,
        Cocoa = 20,
        CoffeeC = 21,
        CottonNo2 = 22,
        FcojA = 23,
        SugarNo11 = 24,
        HeatRateSpread = 25,
        UsDollarIndex = 26,
        CanadianOilseeds = 36,
        EcxCerFutures = 38,
        ForeignExchange = 39,
        FinancialIndexData = 40,
        SugarNo16 = 41,
        EcxEuacerFuturesSpread = 42,
        HenryHub = 44,
        DutchTtfGasFutures = 48,
        GermanNaturalGasFutures = 50,
        EuropeanGasSpreads = 51,
        CanadianFinancialGas = 53,
        NgxCanadianPhysicalCrude = 54,
        UsCoalFutures = 55,
        FobIndoSubbitCoalFutures = 57,
        HeatingOilBrentFuturesCrack = 58,
        NyhRbobGasolineBrentFuturesCrack = 59,
        WetFreight = 60,
        DryFreight = 61,
        FerrousMetals = 62,
        PlattsVariableOil = 63,
        NyhRbobGasolineHeatingOilSpread = 66,
        PhysicalEnvironmental = 69,
        HeatingOilLsGasoilFuturesSpread = 70,
        LsGasoilBrentFuturesCrack = 71,
        NyhRbobGasolineLsGasoilFuturesSpread = 72,
        EcxEuaaFutures = 84,
        EcxCereuaaFuturesSpread = 85,
        EcxEuaaeuaFuturesSpread = 86,
        Soybean = 89,
        EcxEuaEibAuction = 92,
        FinancialLng = 93,
        EuaUkAuction = 95,
        EuaaUkAuction = 96,
        CfrSouthChinaCoalFutures = 97,
        BelgianPowerFutures = 98,
        DutchPowerFutures = 99,
        GCNewcastleFobIndoSubbitCoalFuturesSpread = 100,
        RichardsBaygCNewcastleCoalFuturesSpread = 101,
        FcojAMini = 102,
        CifUs = 104,
        D6Rin = 108,
        EuropeanPowerSpreads = 111,
        Taqa = 112,
        BelgianZtpGasSpot = 113,
        DutchTtfGasSpot = 114,
        DutchTtfGasStorage = 115,
        EuropeanGasSpotSpreads = 116,
        BelgianZtpGasFutures = 117,
        UkOcmGasSpot = 118,
        BelgianGasSpreads = 119,
        FinancialOlefins = 124,
        FinancialMonomers = 125,
        PlattsVariableOilUrals = 126,
        EndexSpotMarketIndices = 127,
        InterestRateFutures = 131,
        SingaporeEnergy = 133,
        SingaporeFinancials = 134,
        SingaporeMetals = 135,
        ItalianNaturalGasFutures = 136,
        ItalianPowerFutures = 137,
        CreditSwapData = 139,
        GoldFixing = 140,
        NorthSeaPartials = 141,
        EuFinancialPowerSpreads = 142,
        EuFinancialPowerFutures = 143,
        OilCad = 144,
        SilverFixing = 147,
        UkSparkSpread = 149,
        UkOcmPhysicalGasSpot = 150,
        JapanDomesticWaterborne = 152,
        DailyMetals = 154,
        BrixEnergiaFin = 155,
        JapanDomesticRack = 156,
        FinancialUsLng = 157,
        IceRotterdamNewcastleCoalFuturesSpread = 160,
        OilAmericas = 165,
        PlattsPetrochemical = 167,
        PermianWtiFutures = 168,
        EndexEquityIndices = 170,
        EndexSingleStockOptions = 171,
        IfusIceIndices = 172,
        PlattsAsiaBunker = 173,
        SofrFutures = 177,
        DigitalAssetFutures = 178,
        PermianBrentFuturesSpread = 179,
        PermianWtiFuturesSpread = 180,
        LiffeStiRs = 200,
        LiffeBonds = 202,
        LiffeSwapnotes = 203,
        1 = 205,
        Metals = 206,
        IfusEquityIndices = 207,
        GcfRepo = 208,
        LiffeThreeMonthEuroAndEonia = 209,
        Eurodollar = 210,
        LiffeEquityDerivativesNonUsBased = 211,
        LiffeEquityDerivativesUsBased = 212,
        LiffeIndexOptions = 213,
        LiffeIndexFuturesUsRestricted = 214,
        LiffeIndexFuturesNonUsRestricted = 215,
        PhysicalGas = 305,
        Power = 306,
        NgxPhysicalGas = 314,
        NgxFinancialPower = 315,
        NgxFinancialGas = 316,
        FinancialNgl = 317,
        OlefinsPolymers = 318,
        PhysicalNgl = 319,
        PhysicalOil = 320,
        TestIpe = 600,
        TestNybot = 601,
        TestNdex = 602,
        TestLiffeuk1 = 603,
        TestLiffeuk2 = 604,
    };


    /// <summary>
    ///  Maturity Day
    /// </summary>
    public struct MaturityDay {
        public short Raw;
    };


    /// <summary>
    ///  Maturity Month
    /// </summary>
    public struct MaturityMonth {
        public short Raw;
    };


    /// <summary>
    ///  Maturity Year
    /// </summary>
    public struct MaturityYear {
        public short Raw;
    };


    /// <summary>
    ///  Max Options Price
    /// </summary>
    public struct MaxOptionsPrice {
        public long Raw;
    };


    /// <summary>
    ///  Max Price
    /// </summary>
    public struct MaxPrice {
        public long Raw;
    };


    /// <summary>
    ///  Message Timestamp
    /// </summary>
    public struct MessageTimestamp {
        public long Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        MarketSnapshotMessage = (byte)'C',
        TradeMessage = (byte)'G',
        SpotMarketTradeMessage = (byte)'Y',
        InvestigatedTradeMessage = (byte)'H',
        CancelledTradeMessage = (byte)'I',
        MarketStatisticsMessage = (byte)'J',
        MarketStateChangeMessage = (byte)'K',
        SystemTextMessage = (byte)'L',
        OpenInterestMessage = (byte)'M',
        OpenPriceMessage = (byte)'N',
        ClosePriceMessage = (byte)'c',
        SettlementPriceMessage = (byte)'O',
        IndexPricesMessage = (byte)'z',
        EndOfDayMarketSummaryMessage = (byte)'u',
        MarketEventMessage = (byte)'f',
        PreOpenPriceIndicatorMessage = (byte)'g',
        StripInfoMessage = (byte)'i',
        IntervalPriceLimitNotificationMessage = (byte)'V',
        NewFuturesStrategyDefinitionMessage = (byte)'9',
        NewExpiryMessage = (byte)'R',
        SpecialFieldMessage = (byte)'b',
        MarketSnapshotOrderMessage = (byte)'D',
        AddOrModifyOrderMessage = (byte)'E',
        DeleteOrderMessage = (byte)'F',
        MessageBundleMarker = (byte)'T',
        FixingTransitionMessage = (byte)'3',
        FixingLockdownMessage = (byte)'4',
        FixingIndicativePriceMessageMessage = (byte)'0',
        MarketSnapshotPriceLevelMessage = (byte)'m',
        AddPriceLevelMessage = (byte)'t',
        ChangePriceLevelMessage = (byte)'s',
        DeletePriceLevelMessage = (byte)'r',
        NewOptionsStrategyDefinitionMessage = (byte)'U',
        NewOptionsMarketDefinitionMessage = (byte)'l',
        RfqMessage = (byte)'k',
        OptionOpenInterestMessage = (byte)'v',
        OptionSettlementPriceMessage = (byte)'w',
        OldStyleOptionsTradeAndMarketStatsMessage = (byte)'W',
    };


    /// <summary>
    ///  Mic Code
    /// </summary>
    public unsafe struct MicCode {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Regulated Market Values
    /// </summary>
    public enum MifidRegulatedMarket : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Min Options Price
    /// </summary>
    public struct MinOptionsPrice {
        public long Raw;
    };


    /// <summary>
    ///  Min Price
    /// </summary>
    public struct MinPrice {
        public long Raw;
    };


    /// <summary>
    ///  Min Qty
    /// </summary>
    public struct MinQty {
        public int Raw;
    };


    /// <summary>
    ///  Modification Timestamp
    /// </summary>
    public struct ModificationTimestamp {
        public long Raw;
    };


    /// <summary>
    ///  Notification Date Time
    /// </summary>
    public struct NotificationDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Num Decimals Options Price
    /// </summary>
    public unsafe struct NumDecimalsOptionsPrice {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Decimals Price
    /// </summary>
    public struct NumDecimalsPrice {
        public sbyte Raw;
    };


    /// <summary>
    ///  Num Decimals Price In Gram
    /// </summary>
    public struct NumDecimalsPriceInGram {
        public sbyte Raw;
    };


    /// <summary>
    ///  Num Decimals Strike Price
    /// </summary>
    public unsafe struct NumDecimalsStrikePrice {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Of Book Entries
    /// </summary>
    public struct NumOfBookEntries {
        public int Raw;
    };


    /// <summary>
    ///  Number Of Hedge Definitions
    /// </summary>
    public struct NumberOfHedgeDefinitions {
        public sbyte Raw;
    };


    /// <summary>
    ///  Number Of Leg Definitions
    /// </summary>
    public struct NumberOfLegDefinitions {
        public sbyte Raw;
    };


    /// <summary>
    ///  Number Of Special Fields
    /// </summary>
    public struct NumberOfSpecialFields {
        public sbyte Raw;
    };


    /// <summary>
    ///  Number Of Strategy Leg Definitions
    /// </summary>
    public struct NumberOfStrategyLegDefinitions {
        public sbyte Raw;
    };


    /// <summary>
    ///  Off Exchange Increment Option Price
    /// </summary>
    public struct OffExchangeIncrementOptionPrice {
        public int Raw;
    };


    /// <summary>
    ///  Off Exchange Increment Price
    /// </summary>
    public struct OffExchangeIncrementPrice {
        public int Raw;
    };


    /// <summary>
    ///  Off Exchange Increment Qty
    /// </summary>
    public struct OffExchangeIncrementQty {
        public int Raw;
    };


    /// <summary>
    ///  Off Exchange Increment Qty Denominator
    /// </summary>
    public unsafe struct OffExchangeIncrementQtyDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Off Market Trade Indicator Values
    /// </summary>
    public enum OffMarketTradeIndicator : byte {
        Regular = (byte)'',
        Block = (byte)'K',
        Efs = (byte)'S',
        Efp = (byte)'E',
        EfpEfs = (byte)'O',
        Eoo = (byte)'Q',
        Efm = (byte)'I',
        GuaranteedCross = (byte)'5',
        Basis = (byte)'5',
    };


    /// <summary>
    ///  Off Market Trade Type Values
    /// </summary>
    public enum OffMarketTradeType : ulong {
        Regular = "",
        Block = "K",
        Efs = "S",
        Efp = "E",
        EfpEfs = "O",
        Eoo = "Q",
        Efm = "I",
        GuaranteedCross = "5",
        Basis = "5",
        AssetAllocation = "AA",
    };


    /// <summary>
    ///  Old Strip Id
    /// </summary>
    public struct OldStripId {
        public short Raw;
    };


    /// <summary>
    ///  Open Interest
    /// </summary>
    public struct OpenInterest {
        public int Raw;
    };


    /// <summary>
    ///  Open Interest Change
    /// </summary>
    public struct OpenInterestChange {
        public int Raw;
    };


    /// <summary>
    ///  Open Interest Date
    /// </summary>
    public unsafe struct OpenInterestDate {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Price
    /// </summary>
    public struct OpenPrice {
        public long Raw;
    };


    /// <summary>
    ///  Opening Price
    /// </summary>
    public struct OpeningPrice {
        public long Raw;
    };


    /// <summary>
    ///  Option Type Values
    /// </summary>
    public enum OptionType : byte {
        Call = (byte)'C',
        Put = (byte)'P',
    };


    /// <summary>
    ///  Options Expiration Day
    /// </summary>
    public struct OptionsExpirationDay {
        public short Raw;
    };


    /// <summary>
    ///  Options Expiration Month
    /// </summary>
    public struct OptionsExpirationMonth {
        public short Raw;
    };


    /// <summary>
    ///  Options Expiration Type Values
    /// </summary>
    public enum OptionsExpirationType : byte {
        Monthly = (byte)'M',
        Daily = (byte)'D',
    };


    /// <summary>
    ///  Options Expiration Year
    /// </summary>
    public struct OptionsExpirationYear {
        public short Raw;
    };


    /// <summary>
    ///  Options Style Values
    /// </summary>
    public enum OptionsStyle : byte {
        American = (byte)'A',
        European = (byte)'E',
        None = (byte)'0',
        Asian = (byte)'3',
        OneTime = (byte)'4',
    };


    /// <summary>
    ///  Order Count
    /// </summary>
    public struct OrderCount {
        public short Raw;
    };


    /// <summary>
    ///  Order Entry Date Time
    /// </summary>
    public struct OrderEntryDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public struct OrderId {
        public long Raw;
    };


    /// <summary>
    ///  Order Price Denominator
    /// </summary>
    public unsafe struct OrderPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Sequence Id
    /// </summary>
    public struct OrderSequenceId {
        public short Raw;
    };


    /// <summary>
    ///  Pre Open Price
    /// </summary>
    public struct PreOpenPrice {
        public long Raw;
    };


    /// <summary>
    ///  Pre Open Volume
    /// </summary>
    public struct PreOpenVolume {
        public int Raw;
    };


    /// <summary>
    ///  Previous Day Settlement Price
    /// </summary>
    public struct PreviousDaySettlementPrice {
        public long Raw;
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public long Raw;
    };


    /// <summary>
    ///  Price In Gram
    /// </summary>
    public struct PriceInGram {
        public long Raw;
    };


    /// <summary>
    ///  Price Level Position
    /// </summary>
    public struct PriceLevelPosition {
        public sbyte Raw;
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public struct ProductId {
        public int Raw;
    };


    /// <summary>
    ///  Product Name
    /// </summary>
    public unsafe struct ProductName {
        public const int Size = 62;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Published Date Time
    /// </summary>
    public struct PublishedDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Quantity
    /// </summary>
    public struct Quantity {
        public int Raw;
    };


    /// <summary>
    ///  Reserved 2 Bytes
    /// </summary>
    public unsafe struct Reserved2Bytes {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Bytes 4
    /// </summary>
    public struct ReservedBytes4 {
        public int Raw;
    };


    /// <summary>
    ///  Rfq System Id
    /// </summary>
    public struct RfqSystemId {
        public long Raw;
    };


    /// <summary>
    ///  Round
    /// </summary>
    public struct Round {
        public short Raw;
    };


    /// <summary>
    ///  Security Sub Type Values
    /// </summary>
    public enum SecuritySubType : short {
        None = 0,
        Call = 1,
        Put = 2,
        FuturesButterfly = 3,
        CallButterfly = 4,
        PutButterfly = 5,
        CallSpread = 6,
        PutSpread = 7,
        DiagonalCallSpread = 9,
        DiagonalPutSpread = 10,
        GutStrangle = 11,
        1X2CallSpreadToThe2 = 12,
        1X2PutSpreadToThe2 = 13,
        IronButterfly = 14,
        Strangle = 16,
        CallLadderTree = 17,
        PutLadderTree = 18,
        StraddleSpread = 19,
        ReversalConversionToTheCall = 21,
        ReversalConversionToThePut = 21,
        Straddle = 22,
        FuturesCondor = 23,
        CallCondor = 24,
        PutCondor = 25,
        Box = 26,
        SyntheticUnderlying = 33,
        CallSpreadVsPut3Way = 34,
        PutSpreadVsCall3Way = 35,
        StraddleVsCall3Way = 36,
        StraddleVsPut3Way = 37,
        CallCalendarSpread = 38,
        PutCalendarSpread = 39,
        IronCondor = 40,
        JellyRoll = 41,
        Hedged1X2CallSpreadToThe2 = 42,
        Hedged1X2PutSpreadToThe2 = 43,
        CallSpreadVersusSellPutHedge = 44,
        PutSpreadVersusSellCall+Hedge = 45,
        HedgedCallCalendar = 46,
        HedgedPutCalendar = 47,
        HedgedCallLadderTree = 48,
        HedgedPutLadderTree = 49,
        HedgedCallSpread = 50,
        HedgedPutSpread = 51,
        HedgedStraddle = 53,
        HedgedStrangle = 54,
        HedgedCall = 55,
        HedgedPut = 56,
        Custom = 58,
        HedgedStraddleSpread = 59,
        HedgedCallCondor = 60,
        HedgedPutCondor = 61,
        HedgedDiagonalCallSpread = 63,
        HedgedDiagonalPutSpread = 64,
        HedgedCallButterlfy = 65,
        HedgedPutButterlfy = 66,
        HedgedGutsStrangle = 67,
        HedgedIronCondor = 68,
        HedgedIronButterfly = 69,
        FenceToTheCall = 70,
        FenceToThePut = 71,
        HedgedFenceToTheCall = 72,
        HedgedFenceToThePut = 73,
        1X2CallSpreadToThe1 = 74,
        1X2PutSpreadToThe1 = 75,
        Hedged1X2CallSpreadToThe1 = 76,
        Hedged1X2PutSpreadToThe1 = 77,
        DiscountSpreads = 88,
        LocationSpreads = 89,
        PlattsDiffSpread = 90,
        PlattsSpread = 91,
        OtcGasOilCrack = 92,
        BalmoOverMonth = 93,
        RatioSpread = 94,
        VolumetricSpread = 95,
        HeatRate = 96,
        CrackSpread = 97,
        ComboSpread = 98,
        SpreadS = 99,
        PacknoColor = 100,
        PackWhite = 101,
        PackRed = 102,
        PackGreen = 103,
        PackBlue = 104,
        PackGold = 105,
        PackPurple = 106,
        PackOrange = 107,
        PackPink = 108,
        PackSilver = 109,
        PackCopper = 110,
        BundleNoColor = 200,
        Bundle2Yr = 201,
        Bundle3Yr = 202,
        Bundle4Yr = 203,
        Bundle5Yr = 204,
        Bundle6Yr = 205,
        Bundle7Yr = 206,
        Bundle8Yr = 207,
        Bundle9Yr = 208,
        Bundle10Yr = 209,
        Balmo = 400,
        NextDay = 410,
        Cfd = 411,
        Weekend = 412,
        SingleDay = 413,
        CustomDaily = 414,
        Hourly = 415,
        Month = 416,
        Balweek = 450,
        Basket = 500,
        CustomMonthly = 550,
        NextWeek = 600,
        Period = 700,
        CustomDailyCfd = 711,
        CustomDaily7X8 = 712,
        CustomDaily7X16 = 713,
        CustomDaily7X6 = 714,
        CustomDailyOffPeakX16 = 715,
        Quarter = 800,
        Year = 900,
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
    ///  Sequence Within Millis
    /// </summary>
    public struct SequenceWithinMillis {
        public int Raw;
    };


    /// <summary>
    ///  Session
    /// </summary>
    public unsafe struct Session {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settle Price Date Time
    /// </summary>
    public struct SettlePriceDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Settle Price Denominator
    /// </summary>
    public unsafe struct SettlePriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Price
    /// </summary>
    public struct SettlementPrice {
        public long Raw;
    };


    /// <summary>
    ///  Settlement Price With Deal Price Precision
    /// </summary>
    public struct SettlementPriceWithDealPricePrecision {
        public long Raw;
    };


    /// <summary>
    ///  Settlement Type Values
    /// </summary>
    public enum SettlementType : byte {
        Financial = (byte)'0',
        Physical = (byte)'1',
    };


    /// <summary>
    ///  Short Name
    /// </summary>
    public unsafe struct ShortName {
        public const int Size = 30;

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
        None = (byte)'',
        Bid = (byte)'1',
        Offer = (byte)'2',
    };


    /// <summary>
    ///  Special Field Id
    /// </summary>
    public unsafe struct SpecialFieldId {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Special Field Length
    /// </summary>
    public unsafe struct SpecialFieldLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Special Field Value
    /// </summary>
    public unsafe struct SpecialFieldValue {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Start Or End Values
    /// </summary>
    public enum StartOrEnd : byte {
        Start = (byte)'S',
        End = (byte)'E',
    };


    /// <summary>
    ///  Status Values
    /// </summary>
    public enum Status : byte {
        Closed = (byte)'C',
        Preopen = (byte)'P',
        Lockdown = (byte)'L',
    };


    /// <summary>
    ///  Strategy Symbol
    /// </summary>
    public unsafe struct StrategySymbol {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public long Raw;
    };


    /// <summary>
    ///  Strip Id
    /// </summary>
    public struct StripId {
        public int Raw;
    };


    /// <summary>
    ///  Strip Info
    /// </summary>
    public unsafe struct StripInfo {
        public const int Size = 50;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strip Name
    /// </summary>
    public unsafe struct StripName {
        public const int Size = 39;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strip Type
    /// </summary>
    public unsafe struct StripType {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Priced Leg Type Values
    /// </summary>
    public enum SystemPricedLegType : byte {
        SystemPricedCrackSpreadLeg = (byte)'C',
        SystemPricedLeg = (byte)'S',
    };


    /// <summary>
    ///  Test Market Indicator Values
    /// </summary>
    public enum TestMarketIndicator : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Text Message
    /// </summary>
    public unsafe struct TextMessage {
        public const int Size = 200;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Text Message Extra Fld
    /// </summary>
    public unsafe struct TextMessageExtraFld {
        public const int Size = 800;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Threshold Imbalance Qty
    /// </summary>
    public struct ThresholdImbalanceQty {
        public int Raw;
    };


    /// <summary>
    ///  Tick Value
    /// </summary>
    public struct TickValue {
        public long Raw;
    };


    /// <summary>
    ///  Time
    /// </summary>
    public struct Time {
        public long Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public long Raw;
    };


    /// <summary>
    ///  Total Volume
    /// </summary>
    public struct TotalVolume {
        public int Raw;
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public struct TradeId {
        public long Raw;
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        Open = (byte)'O',
        Close = (byte)'C',
        Expired = (byte)'E',
        PreOpen = (byte)'1',
        PreClose = (byte)'2',
    };


    /// <summary>
    ///  Transact Date Time
    /// </summary>
    public struct TransactDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Underlying Isin
    /// </summary>
    public unsafe struct UnderlyingIsin {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Market Id
    /// </summary>
    public struct UnderlyingMarketId {
        public int Raw;
    };


    /// <summary>
    ///  Unit Of Measure
    /// </summary>
    public unsafe struct UnitOfMeasure {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Qty Denominator
    /// </summary>
    public unsafe struct UnitQtyDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Quantity
    /// </summary>
    public struct UnitQuantity {
        public int Raw;
    };


    /// <summary>
    ///  Usd Price
    /// </summary>
    public struct UsdPrice {
        public long Raw;
    };


    /// <summary>
    ///  Valuation Date
    /// </summary>
    public unsafe struct ValuationDate {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Valuation Date Time
    /// </summary>
    public struct ValuationDateTime {
        public long Raw;
    };


    /// <summary>
    ///  Volatility
    /// </summary>
    public struct Volatility {
        public long Raw;
    };


    /// <summary>
    ///  Volume
    /// </summary>
    public struct Volume {
        public int Raw;
    };


    /// <summary>
    ///  Vwap
    /// </summary>
    public struct Vwap {
        public long Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Or Modify Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrModifyOrderMessage {
        MarketId MarketId;
        OrderId OrderId;
        OrderSequenceId OrderSequenceId;
        Side Side;
        Price Price;
        Quantity Quantity;
        IsImplied IsImplied;
        IsRfq IsRfq;
        OrderEntryDateTime OrderEntryDateTime;
        ExtraFlags ExtraFlags;
        SequenceWithinMillis SequenceWithinMillis;
        ModificationTimestamp ModificationTimestamp;
    };


    /// <summary>
    ///  Struct for Add Price Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddPriceLevelMessage {
        MarketId MarketId;
        Side Side;
        PriceLevelPosition PriceLevelPosition;
        Price Price;
        Quantity Quantity;
        OrderCount OrderCount;
        ImpliedQuantity ImpliedQuantity;
        ImpliedOrderCount ImpliedOrderCount;
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for Cancelled Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelledTradeMessage {
        MarketId MarketId;
        TradeId TradeId;
        Price Price;
        Quantity Quantity;
        OffMarketTradeIndicator OffMarketTradeIndicator;
        DateTime DateTime;
        OffMarketTradeType OffMarketTradeType;
    };


    /// <summary>
    ///  Struct for Change Price Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChangePriceLevelMessage {
        MarketId MarketId;
        Side Side;
        PriceLevelPosition PriceLevelPosition;
        Price Price;
        Quantity Quantity;
        OrderCount OrderCount;
        ImpliedQuantity ImpliedQuantity;
        ImpliedOrderCount ImpliedOrderCount;
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for Close Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClosePriceMessage {
        MarketId MarketId;
        ClosePrice ClosePrice;
        DateTime DateTime;
    };


    /// <summary>
    ///  Struct for Delete Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderMessage {
        MarketId MarketId;
        OrderId OrderId;
        DateTime DateTime;
        SequenceWithinMillis SequenceWithinMillis;
    };


    /// <summary>
    ///  Struct for Delete Price Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeletePriceLevelMessage {
        MarketId MarketId;
        Side Side;
        PriceLevelPosition PriceLevelPosition;
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for End Of Day Market Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMarketSummaryMessage {
        MarketId MarketId;
        Volume Volume;
        BlockVolume BlockVolume;
        EfsVolume EfsVolume;
        EfpVolume EfpVolume;
        OpeningPrice OpeningPrice;
        High High;
        Low Low;
        Vwap Vwap;
        SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
        OpenInterest OpenInterest;
        DateTime DateTime;
        SettlementPrice SettlementPrice;
    };


    /// <summary>
    ///  Struct for Fixing Indicative Price Message Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FixingIndicativePriceMessageMessage {
        MarketId MarketId;
        IbaCurrency IbaCurrency;
        Price Price;
        PriceInGram PriceInGram;
        NumDecimalsPrice NumDecimalsPrice;
        NumDecimalsPriceInGram NumDecimalsPriceInGram;
    };


    /// <summary>
    ///  Struct for Fixing Lockdown Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FixingLockdownMessage {
        MarketId MarketId;
        AuctionDate AuctionDate;
        Time Time;
        Description Description;
        Round Round;
        AggBidQty AggBidQty;
        AggOfferQty AggOfferQty;
        UsdPrice UsdPrice;
        IsBalanced IsBalanced;
        IsFinal IsFinal;
        GbpPrice GbpPrice;
        EurPrice EurPrice;
    };


    /// <summary>
    ///  Struct for Fixing Transition Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FixingTransitionMessage {
        MarketId MarketId;
        Status Status;
        AuctionEndTime AuctionEndTime;
        ThresholdImbalanceQty ThresholdImbalanceQty;
        DateTime DateTime;
    };


    /// <summary>
    ///  Struct for Hedge Definition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HedgeDefinition {
        HedgeBodyLength HedgeBodyLength;
        HedgeMarketId HedgeMarketId;
        HedgeSecurityType HedgeSecurityType;
        HedgeSide HedgeSide;
        HedgePrice HedgePrice;
        HedgePriceDenominator HedgePriceDenominator;
        HedgeDelta HedgeDelta;
        HedgeStrategyCode HedgeStrategyCode;
    };


    /// <summary>
    ///  Struct for Index Prices Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IndexPricesMessage {
        MarketId MarketId;
        Price Price;
        ShortName ShortName;
        PublishedDateTime PublishedDateTime;
        ValuationDate ValuationDate;
        Status Status;
    };


    /// <summary>
    ///  Struct for Interval Price Limit Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IntervalPriceLimitNotificationMessage {
        MarketId MarketId;
        IplHoldType IplHoldType;
        NotificationDateTime NotificationDateTime;
        IsUp IsUp;
        IplHoldDuration IplHoldDuration;
        IplUp IplUp;
        IplDown IplDown;
    };


    /// <summary>
    ///  Struct for Investigated Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InvestigatedTradeMessage {
        MarketId MarketId;
        TradeId TradeId;
        Price Price;
        Quantity Quantity;
        OffMarketTradeIndicator OffMarketTradeIndicator;
        DateTime DateTime;
        InvestigationStatus InvestigationStatus;
        OffMarketTradeType OffMarketTradeType;
    };


    /// <summary>
    ///  Struct for Leg Definition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegDefinition {
        LegBodyLength LegBodyLength;
        LegMarketId LegMarketId;
        LegRatio LegRatio;
        LegSide LegSide;
        LegStrategyCode LegStrategyCode;
        LegRatioQtyNumerator LegRatioQtyNumerator;
        LegRatioQtyDenominator LegRatioQtyDenominator;
        LegRatioPriceNumerator LegRatioPriceNumerator;
        LegRatioPriceDenominator LegRatioPriceDenominator;
    };


    /// <summary>
    ///  Struct for Market Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketEventMessage {
        MarketId MarketId;
        EventType EventType;
        DateTime DateTime;
    };


    /// <summary>
    ///  Struct for Market Snapshot Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSnapshotMessage {
        MarketId MarketId;
        MarketType MarketType;
        TradingStatus TradingStatus;
        Volume Volume;
        BlockVolume BlockVolume;
        EfsVolume EfsVolume;
        EfpVolume EfpVolume;
        OpenInterest OpenInterest;
        OpeningPrice OpeningPrice;
        SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
        High High;
        Low Low;
        Vwap Vwap;
        NumOfBookEntries NumOfBookEntries;
        LastTradePrice LastTradePrice;
        LastTradeQuantity LastTradeQuantity;
        LastTradeDateTime LastTradeDateTime;
        SettlePriceDateTime SettlePriceDateTime;
        LastMessageSequenceId LastMessageSequenceId;
        Reserved2Bytes Reserved2Bytes;
        OpenInterestDate OpenInterestDate;
        IsSettlePriceOfficial IsSettlePriceOfficial;
        SettlementPrice SettlementPrice;
        HasPreviousDaySettlementPrice HasPreviousDaySettlementPrice;
        PreviousDaySettlementPrice PreviousDaySettlementPrice;
    };


    /// <summary>
    ///  Struct for Market Snapshot Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSnapshotOrderMessage {
        MarketId MarketId;
        OrderId OrderId;
        OrderSequenceId OrderSequenceId;
        Side Side;
        Price Price;
        Quantity Quantity;
        IsImplied IsImplied;
        IsRfq IsRfq;
        OrderEntryDateTime OrderEntryDateTime;
        SequenceWithinMillis SequenceWithinMillis;
    };


    /// <summary>
    ///  Struct for Market Snapshot Price Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSnapshotPriceLevelMessage {
        MarketId MarketId;
        Side Side;
        PriceLevelPosition PriceLevelPosition;
        Price Price;
        Quantity Quantity;
        OrderCount OrderCount;
        ImpliedQuantity ImpliedQuantity;
        ImpliedOrderCount ImpliedOrderCount;
    };


    /// <summary>
    ///  Struct for Market State Change Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketStateChangeMessage {
        MarketId MarketId;
        TradingStatus TradingStatus;
        DateTime DateTime;
    };


    /// <summary>
    ///  Struct for Market Statistics Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketStatisticsMessage {
        MarketId MarketId;
        Volume Volume;
        BlockVolume BlockVolume;
        EfsVolume EfsVolume;
        EfpVolume EfpVolume;
        High High;
        Low Low;
        Vwap Vwap;
        DateTime DateTime;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Message Bundle Marker
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageBundleMarker {
        StartOrEnd StartOrEnd;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        MessageType MessageType;
        Length Length;
    };


    /// <summary>
    ///  Struct for New Expiry Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewExpiryMessage {
        MarketId MarketId;
        MarketTypeId MarketTypeId;
        OrderPriceDenominator OrderPriceDenominator;
        IncrementPrice IncrementPrice;
        IncrementQty IncrementQty;
        LotSize LotSize;
        MarketDesc MarketDesc;
        MaturityYear MaturityYear;
        MaturityMonth MaturityMonth;
        MaturityDay MaturityDay;
        DealPriceDenominator DealPriceDenominator;
        MinQty MinQty;
        UnitQuantity UnitQuantity;
        Currency Currency;
        ClearedAlias ClearedAlias;
        MinPrice MinPrice;
        MaxPrice MaxPrice;
        ProductId ProductId;
        ProductName ProductName;
        HubId HubId;
        HubAlias HubAlias;
        StripId StripId;
        StripName StripName;
        SettlePriceDenominator SettlePriceDenominator;
        MicCode MicCode;
        UnitQtyDenominator UnitQtyDenominator;
        OffExchangeIncrementQtyDenominator OffExchangeIncrementQtyDenominator;
        OffExchangeIncrementQty OffExchangeIncrementQty;
        OffExchangeIncrementPrice OffExchangeIncrementPrice;
        OffExchangeIncrementOptionPrice OffExchangeIncrementOptionPrice;
        ContractSymbol ContractSymbol;
        Isin Isin;
        NumDecimalsOptionsPrice NumDecimalsOptionsPrice;
        HedgeMarketId HedgeMarketId;
        SettlementType SettlementType;
        GtAllowed GtAllowed;
        CrossOrderSupported CrossOrderSupported;
        UnitOfMeasure UnitOfMeasure;
        MifidRegulatedMarket MifidRegulatedMarket;
    };


    /// <summary>
    ///  Struct for New Options Market Definition Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOptionsMarketDefinitionMessage {
        MarketId MarketId;
        UnderlyingMarketId UnderlyingMarketId;
        FuturesContractSymbol FuturesContractSymbol;
        TradingStatus TradingStatus;
        OrderPriceDenominator OrderPriceDenominator;
        IncrementQty IncrementQty;
        LotSize LotSize;
        MarketDesc MarketDesc;
        OptionType OptionType;
        StrikePrice StrikePrice;
        DealPriceDenominator DealPriceDenominator;
        MinQty MinQty;
        Currency Currency;
        NumDecimalsStrikePrice NumDecimalsStrikePrice;
        MinOptionsPrice MinOptionsPrice;
        MaxOptionsPrice MaxOptionsPrice;
        IncrementPremiumPrice IncrementPremiumPrice;
        OptionsExpirationYear OptionsExpirationYear;
        OptionsExpirationMonth OptionsExpirationMonth;
        OptionsExpirationDay OptionsExpirationDay;
        OptionsStyle OptionsStyle;
        OptionsExpirationType OptionsExpirationType;
        HedgeMarketId HedgeMarketId;
        SettlePriceDenominator SettlePriceDenominator;
        UnitQtyDenominator UnitQtyDenominator;
        TickValue TickValue;
        FlexAllowed FlexAllowed;
        SettlementType SettlementType;
        IsBlockOnly IsBlockOnly;
        GtAllowed GtAllowed;
        CrossOrderSupported CrossOrderSupported;
        GuaranteedCrossSupported GuaranteedCrossSupported;
        UnitOfMeasure UnitOfMeasure;
        MifidRegulatedMarket MifidRegulatedMarket;
    };


    /// <summary>
    ///  Struct for Old Style Options Trade And Market Stats Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OldStyleOptionsTradeAndMarketStatsMessage {
        UnderlyingMarketId UnderlyingMarketId;
        TradeId TradeId;
        Price Price;
        Quantity Quantity;
        OffMarketTradeIndicator OffMarketTradeIndicator;
        TransactDateTime TransactDateTime;
        OptionType OptionType;
        StrikePrice StrikePrice;
        EventCode EventCode;
        TotalVolume TotalVolume;
        BlockVolume BlockVolume;
        EfsVolume EfsVolume;
        EfpVolume EfpVolume;
        High High;
        Low Low;
        Vwap Vwap;
    };


    /// <summary>
    ///  Struct for Open Interest Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenInterestMessage {
        MarketId MarketId;
        OpenInterest OpenInterest;
        OpenInterestChange OpenInterestChange;
        DateTime DateTime;
        OpenInterestDate OpenInterestDate;
    };


    /// <summary>
    ///  Struct for Open Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenPriceMessage {
        MarketId MarketId;
        OpenPrice OpenPrice;
        DateTime DateTime;
    };


    /// <summary>
    ///  Struct for Option Open Interest Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionOpenInterestMessage {
        MarketId MarketId;
        OpenInterest OpenInterest;
        DateTime DateTime;
        OpenInterestDate OpenInterestDate;
    };


    /// <summary>
    ///  Struct for Option Settlement Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionSettlementPriceMessage {
        MarketId MarketId;
        SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
        DateTime DateTime;
        IsOfficial IsOfficial;
        ValuationDateTime ValuationDateTime;
        Volatility Volatility;
        SettlementPrice SettlementPrice;
        Delta Delta;
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
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for Pre Open Price Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PreOpenPriceIndicatorMessage {
        MarketId MarketId;
        PreOpenPrice PreOpenPrice;
        DateTime DateTime;
        HasPreOpenVolume HasPreOpenVolume;
        PreOpenVolume PreOpenVolume;
    };


    /// <summary>
    ///  Struct for Rfq Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqMessage {
        MarketId MarketId;
        MessageTimestamp MessageTimestamp;
        RfqSystemId RfqSystemId;
        MarketTypeId MarketTypeId;
        UnderlyingMarketId UnderlyingMarketId;
        Quantity Quantity;
        Side Side;
    };


    /// <summary>
    ///  Struct for Settlement Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlementPriceMessage {
        MarketId MarketId;
        SettlementPriceWithDealPricePrecision SettlementPriceWithDealPricePrecision;
        DateTime DateTime;
        IsOfficial IsOfficial;
        ValuationDateTime ValuationDateTime;
        SettlementPrice SettlementPrice;
    };


    /// <summary>
    ///  Struct for Special Field
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SpecialField {
        SpecialFieldId SpecialFieldId;
        SpecialFieldLength SpecialFieldLength;
    };


    /// <summary>
    ///  Struct for Special Field Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SpecialFieldMessage {
        NumberOfSpecialFields NumberOfSpecialFields;
    };


    /// <summary>
    ///  Struct for Spot Market Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SpotMarketTradeMessage {
        MarketId MarketId;
        TradeId TradeId;
        Price Price;
        Quantity Quantity;
        TransactDateTime TransactDateTime;
        ExtraFlags ExtraFlags;
        DeliveryBeginDateTime DeliveryBeginDateTime;
        DeliveryEndDateTime DeliveryEndDateTime;
        IsSystemPricedLeg IsSystemPricedLeg;
    };


    /// <summary>
    ///  Struct for Strategy Leg Definition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyLegDefinition {
        LegBodyLength LegBodyLength;
        LegMarketId LegMarketId;
        LegUnderlyingMarketId LegUnderlyingMarketId;
        LegRatio LegRatio;
        LegSide LegSide;
        LegStrategyCode LegStrategyCode;
        LegRatioQtyNumerator LegRatioQtyNumerator;
        LegRatioQtyDenominator LegRatioQtyDenominator;
        LegRatioPriceNumerator LegRatioPriceNumerator;
        LegRatioPriceDenominator LegRatioPriceDenominator;
    };


    /// <summary>
    ///  Struct for Strip Info Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StripInfoMessage {
        OldStripId OldStripId;
        StripType StripType;
        BeginYear BeginYear;
        BeginMonth BeginMonth;
        BeginDay BeginDay;
        EndYear EndYear;
        EndMonth EndMonth;
        EndDay EndDay;
        StripInfo StripInfo;
        StripId StripId;
    };


    /// <summary>
    ///  Struct for System Text Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemTextMessage {
        TextMessage TextMessage;
        DateTime DateTime;
        TextMessageExtraFld TextMessageExtraFld;
    };


    /// <summary>
    ///  Struct for Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeMessage {
        MarketId MarketId;
        TradeId TradeId;
        IsSystemPricedLeg IsSystemPricedLeg;
        Price Price;
        Quantity Quantity;
        OffMarketTradeIndicator OffMarketTradeIndicator;
        TransactDateTime TransactDateTime;
        SystemPricedLegType SystemPricedLegType;
        IsImpliedSpreadAtMarketOpen IsImpliedSpreadAtMarketOpen;
        IsAdjustedTrade IsAdjustedTrade;
        AggressorSide AggressorSide;
        ExtraFlags ExtraFlags;
        OffMarketTradeType OffMarketTradeType;
        SequenceWithinMillis SequenceWithinMillis;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
