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
    ///  Appl Seq Num
    /// </summary>
    public unsafe struct ApplSeqNum {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Class Key
    /// </summary>
    public unsafe struct ClassKey {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Size
    /// </summary>
    public unsafe struct ContractSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Currency Code Length
    /// </summary>
    public struct CurrencyCodeLength {
        public byte Raw;
    };


    /// <summary>
    ///  Currency Code Text
    /// </summary>
    public unsafe struct CurrencyCodeText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Eop Exponent
    /// </summary>
    public struct EopExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Eop Mantissa
    /// </summary>
    public struct EopMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Eop Type Values
    /// </summary>
    public enum EopType : byte {
        Undefined = 0,
        OpeningPrice = 1,
        NeedMoreSellers = 2,
        NeedMoreBuyers = 3,
        NoOpeningTrades = 4,
        MultipleOpeningPrices = 5,
        NeedQuoteToOpen = 6,
        PriceNotInQuoteRange = 7,
        NeedDpmQuoteToOpen = 8,
        DpmQuoteInvalid = 9,
        PriceNotInBotrRange = 10,
    };


    /// <summary>
    ///  Eos
    /// </summary>
    public unsafe struct Eos {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exercise Style Values
    /// </summary>
    public enum ExerciseStyle : byte {
        American = 0,
        European = 1,
    };


    /// <summary>
    ///  first Msg Seq Num
    /// </summary>
    public unsafe struct FirstMsgSeqNum {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public unsafe struct LegRatioQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Security Id
    /// </summary>
    public unsafe struct LegSecurityId {
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
        BuyBid = (byte)'B',
        SellAsk = (byte)'S',
    };


    /// <summary>
    ///  Legal Market Values
    /// </summary>
    public enum LegalMarket : byte {
        NotALegalMarket = 0,
        LegalMarket = 1,
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Max Strike Price Exponent
    /// </summary>
    public struct MaxStrikePriceExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Max Strike Price Mantissa
    /// </summary>
    public struct MaxStrikePriceMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Md Control Type Values
    /// </summary>
    public enum MdControlType : byte {
        StartOfSummary = 0,
        EndOfSummary = 1,
        StartOfSettlement = 2,
        EndOfSettlement = 3,
    };


    /// <summary>
    ///  Md Entry Px Exponent
    /// </summary>
    public struct MdEntryPxExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Md Entry Px Mantissa
    /// </summary>
    public struct MdEntryPxMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Size
    /// </summary>
    public unsafe struct MdEntrySize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Entry Type Values
    /// </summary>
    public enum MdEntryType : byte {
        Bid = (byte)'0',
        Ask = (byte)'1',
        Trade = (byte)'2',
        IndexValue = (byte)'3',
        OpeningPrice = (byte)'4',
        SettlementValue = (byte)'6',
        High = (byte)'7',
        Low = (byte)'8',
    };


    /// <summary>
    ///  Md Volume Type Values
    /// </summary>
    public enum MdVolumeType : byte {
        TotalLimit = 0,
        CustomerLimit = 1,
        TotalContingencyAllOrNone = 2,
        CustomerContingencyAllOrNone = 3,
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public unsafe struct MessageSequenceNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type
    /// </summary>
    public unsafe struct MessageType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Minimum Above Premium Fraction Exponent
    /// </summary>
    public struct MinimumAbovePremiumFractionExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Minimum Above Premium Fraction Mantissa
    /// </summary>
    public struct MinimumAbovePremiumFractionMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Minimum Below Premium Fraction Exponent
    /// </summary>
    public struct MinimumBelowPremiumFractionExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Minimum Below Premium Fraction Mantissa
    /// </summary>
    public struct MinimumBelowPremiumFractionMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Minimum Strike Price Fraction Exponent
    /// </summary>
    public struct MinimumStrikePriceFractionExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Minimum Strike Price Fraction Mantissa
    /// </summary>
    public struct MinimumStrikePriceFractionMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Net Chg Prev Day Exponent
    /// </summary>
    public struct NetChgPrevDayExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Net Chg Prev Day Mantissa
    /// </summary>
    public struct NetChgPrevDayMantissa {
        public int Raw;
    };


    /// <summary>
    ///  No Entries
    /// </summary>
    public unsafe struct NoEntries {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  No Legs
    /// </summary>
    public unsafe struct NoLegs {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Packet Length
    /// </summary>
    public unsafe struct PacketLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Premium Break Point Exponent
    /// </summary>
    public struct PremiumBreakPointExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Premium Break Point Mantissa
    /// </summary>
    public struct PremiumBreakPointMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Prev Close Px Exponent
    /// </summary>
    public struct PrevClosePxExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Prev Close Px Mantissa
    /// </summary>
    public struct PrevClosePxMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Price Type
    /// </summary>
    public unsafe struct PriceType {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = 0,
        Call = 1,
    };


    /// <summary>
    ///  Security Exchange Values
    /// </summary>
    public enum SecurityExchange : byte {
        Cboe = (byte)'C',
        OneChicagoNotSupported = (byte)'O',
        CbsxNotSupported = (byte)'W',
        Cfecof = (byte)'F',
        Cboe2Options = (byte)'2',
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public unsafe struct SecurityId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Trading Status Values
    /// </summary>
    public enum SecurityTradingStatus : byte {
        Halted = 2,
        Open = 17,
        Closed = 18,
        PreOpen = 21,
        OpeningRotation = 22,
        FastMarket = 23,
        StrategyMarketInOpeningRotation = 24,
        StrategyMarketQuotesNonFirm = 25,
        Suspended = 26,
    };


    /// <summary>
    ///  Security Type Length
    /// </summary>
    public struct SecurityTypeLength {
        public byte Raw;
    };


    /// <summary>
    ///  Security Type Text
    /// </summary>
    public unsafe struct SecurityTypeText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public unsafe struct SendingTime {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Exponent
    /// </summary>
    public struct StrikePriceExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Strike Price Mantissa
    /// </summary>
    public struct StrikePriceMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Symbol Length
    /// </summary>
    public struct SymbolLength {
        public byte Raw;
    };


    /// <summary>
    ///  Symbol Text
    /// </summary>
    public unsafe struct SymbolText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Target Location Id Length
    /// </summary>
    public struct TargetLocationIdLength {
        public byte Raw;
    };


    /// <summary>
    ///  Target Location Id Text
    /// </summary>
    public unsafe struct TargetLocationIdText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : byte {
        SecurityDefinitionMessage = 13,
        CurrentMarketRefreshMessage = 11,
        MarketDataRefreshMessage = 20,
        CurrentMarketUpdateMessage = 12,
        RecapUpdateMessage = 21,
        TickerMessage = 14,
        ExpectedOpeningPriceAndSizeMessage = 15,
        IndexValueMessage = 22,
        SettlementValueMessage = 23,
        SummaryMessage = 24,
        MarketDataControlMessage = 25,
        HeartbeatMessage = 16,
    };


    /// <summary>
    ///  Trade Condition Length
    /// </summary>
    public struct TradeConditionLength {
        public byte Raw;
    };


    /// <summary>
    ///  Trade Condition Text
    /// </summary>
    public unsafe struct TradeConditionText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Volume
    /// </summary>
    public unsafe struct TradeVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Px Exponent
    /// </summary>
    public struct UnderlyingPxExponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Underlying Px Mantissa
    /// </summary>
    public struct UnderlyingPxMantissa {
        public int Raw;
    };


    /// <summary>
    ///  Underlying Symbol Length
    /// </summary>
    public struct UnderlyingSymbolLength {
        public byte Raw;
    };


    /// <summary>
    ///  Underlying Symbol Text
    /// </summary>
    public unsafe struct UnderlyingSymbolText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Underlying Type Length
    /// </summary>
    public struct UnderlyingTypeLength {
        public byte Raw;
    };


    /// <summary>
    ///  Underlying Type Text
    /// </summary>
    public unsafe struct UnderlyingTypeText {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Currency Code
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CurrencyCode {
        CurrencyCodeLength CurrencyCodeLength;
    };


    /// <summary>
    ///  Struct for Current Market Refresh Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CurrentMarketRefreshMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        SecurityTradingStatus SecurityTradingStatus;
        PriceType PriceType;
        ApplSeqNum ApplSeqNum;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Current Market Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CurrentMarketUpdateMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        SecurityTradingStatus SecurityTradingStatus;
        PriceType PriceType;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Eop
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Eop {
        EopExponent EopExponent;
        EopMantissa EopMantissa;
    };


    /// <summary>
    ///  Struct for Expected Opening Price And Size Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExpectedOpeningPriceAndSizeMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        Eop Eop;
        Eos Eos;
        EopType EopType;
        LegalMarket LegalMarket;
    };


    /// <summary>
    ///  Struct for Index Value Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IndexValueMdEntry {
        MdEntryType MdEntryType;
        MdEntryPx MdEntryPx;
    };


    /// <summary>
    ///  Struct for Market Data Control Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketDataControlMessage {
        MdControlType MdControlType;
    };


    /// <summary>
    ///  Struct for Market Data Refresh Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketDataRefreshMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        SecurityTradingStatus SecurityTradingStatus;
        PriceType PriceType;
        ApplSeqNum ApplSeqNum;
        PrevClosePx PrevClosePx;
        TradeVolume TradeVolume;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Max Strike Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MaxStrikePrice {
        MaxStrikePriceExponent MaxStrikePriceExponent;
        MaxStrikePriceMantissa MaxStrikePriceMantissa;
    };


    /// <summary>
    ///  Struct for Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdEntry {
        MdEntryType MdEntryType;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        MdVolumeType MdVolumeType;
    };


    /// <summary>
    ///  Struct for Md Entry Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdEntryPx {
        MdEntryPxExponent MdEntryPxExponent;
        MdEntryPxMantissa MdEntryPxMantissa;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        MessageLength MessageLength;
        TemplateId TemplateId;
        MessageType MessageType;
        MessageSequenceNumber MessageSequenceNumber;
    };


    /// <summary>
    ///  Struct for Minimum Above Premium Fraction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MinimumAbovePremiumFraction {
        MinimumAbovePremiumFractionExponent MinimumAbovePremiumFractionExponent;
        MinimumAbovePremiumFractionMantissa MinimumAbovePremiumFractionMantissa;
    };


    /// <summary>
    ///  Struct for Minimum Below Premium Fraction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MinimumBelowPremiumFraction {
        MinimumBelowPremiumFractionExponent MinimumBelowPremiumFractionExponent;
        MinimumBelowPremiumFractionMantissa MinimumBelowPremiumFractionMantissa;
    };


    /// <summary>
    ///  Struct for Minimum Strike Price Fraction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MinimumStrikePriceFraction {
        MinimumStrikePriceFractionExponent MinimumStrikePriceFractionExponent;
        MinimumStrikePriceFractionMantissa MinimumStrikePriceFractionMantissa;
    };


    /// <summary>
    ///  Struct for Net Chg Prev Day
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetChgPrevDay {
        NetChgPrevDayExponent NetChgPrevDayExponent;
        NetChgPrevDayMantissa NetChgPrevDayMantissa;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        Version Version;
        PacketLength PacketLength;
        SendingTime SendingTime;
        MessageCount MessageCount;
        FirstMsgSeqNum FirstMsgSeqNum;
    };


    /// <summary>
    ///  Struct for Premium Break Point
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PremiumBreakPoint {
        PremiumBreakPointExponent PremiumBreakPointExponent;
        PremiumBreakPointMantissa PremiumBreakPointMantissa;
    };


    /// <summary>
    ///  Struct for Prev Close Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PrevClosePx {
        PrevClosePxExponent PrevClosePxExponent;
        PrevClosePxMantissa PrevClosePxMantissa;
    };


    /// <summary>
    ///  Struct for Recap Update Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RecapUpdateMdEntry {
        MdEntryType MdEntryType;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
    };


    /// <summary>
    ///  Struct for Recap Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RecapUpdateMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        PriceType PriceType;
        PrevClosePx PrevClosePx;
        TradeVolume TradeVolume;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Security Definition Leg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionLeg {
        LegRatioQty LegRatioQty;
        LegSecurityId LegSecurityId;
        LegSide LegSide;
    };


    /// <summary>
    ///  Struct for Security Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityType {
        SecurityTypeLength SecurityTypeLength;
    };


    /// <summary>
    ///  Struct for Settlement Value Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlementValueMdEntry {
        MdEntryType MdEntryType;
        MdEntryPx MdEntryPx;
    };


    /// <summary>
    ///  Struct for Settlement Value Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlementValueMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        PriceType PriceType;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Strike Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrikePrice {
        StrikePriceExponent StrikePriceExponent;
        StrikePriceMantissa StrikePriceMantissa;
    };


    /// <summary>
    ///  Struct for Summary Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SummaryMdEntry {
        MdEntryType MdEntryType;
        MdEntryPx MdEntryPx;
    };


    /// <summary>
    ///  Struct for Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SummaryMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        PriceType PriceType;
        TradeVolume TradeVolume;
        OpenInterest OpenInterest;
        NetChgPrevDay NetChgPrevDay;
        UnderlyingPx UnderlyingPx;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Symbol
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Symbol {
        SymbolLength SymbolLength;
    };


    /// <summary>
    ///  Struct for Target Location Id
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TargetLocationId {
        TargetLocationIdLength TargetLocationIdLength;
    };


    /// <summary>
    ///  Struct for Ticker Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TickerMdEntry {
        MdEntryType MdEntryType;
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
    };


    /// <summary>
    ///  Struct for Ticker Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TickerMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        PriceType PriceType;
        NoEntries NoEntries;
    };


    /// <summary>
    ///  Struct for Trade Condition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCondition {
        TradeConditionLength TradeConditionLength;
    };


    /// <summary>
    ///  Struct for Underlying Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingPx {
        UnderlyingPxExponent UnderlyingPxExponent;
        UnderlyingPxMantissa UnderlyingPxMantissa;
    };


    /// <summary>
    ///  Struct for Underlying Symbol
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingSymbol {
        UnderlyingSymbolLength UnderlyingSymbolLength;
    };


    /// <summary>
    ///  Struct for Underlying Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingType {
        UnderlyingTypeLength UnderlyingTypeLength;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
