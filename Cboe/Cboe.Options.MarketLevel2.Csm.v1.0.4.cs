namespace MyNamespace {

    #region Methods
    ///////////////////////////////////////////////////////////////////////

    public static class Endian {

        /// <summary>
        ///  Swap byte order for 2 byte unsigned short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ushort value)
            => value << 8 | value >> 8 
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ulong value)
            => (0x00000000000000FF) & (value >> 56) |
               (0x000000000000FF00) & (value >> 40) |
               (0x0000000000FF0000) & (value >> 24) |
               (0x00000000FF000000) & (value >> 8)  |
               (0x000000FF00000000) & (value << 8)  |
               (0x0000FF0000000000) & (value << 24) |
               (0x00FF000000000000) & (value << 40) |
               (0xFF00000000000000) & (value << 56);
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Class Key
    /// </summary>
    public struct ClassKey {
        public uint Raw;
    };


    /// <summary>
    ///  Contract Size
    /// </summary>
    public struct ContractSize {
        public uint Raw;
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

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exercise Style Values
    /// </summary>
    public enum ExerciseStyle : byte {
        American = "0",
        European = "1",
    };


    /// <summary>
    ///  first Msg Seq Num
    /// </summary>
    public struct FirstMsgSeqNum {
        public uint Raw;
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public struct LegRatioQty {
        public uint Raw;
    };


    /// <summary>
    ///  Leg Security Id
    /// </summary>
    public struct LegSecurityId {
        public uint Raw;
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        BuyBid = (byte)'B',
        SellAsk = (byte)'S',
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public struct MaturityDate {
        public ulong Raw;
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
    public struct MdEntrySize {
        public uint Raw;
    };


    /// <summary>
    ///  Md Entry Type Values
    /// </summary>
    public enum MdEntryType : byte {
        BuyBid = (byte)'0',
        SellAsk = (byte)'1',
    };


    /// <summary>
    ///  Md Price Level
    /// </summary>
    public struct MdPriceLevel {
        public byte Raw;
    };


    /// <summary>
    ///  Md Update Action Values
    /// </summary>
    public enum MdUpdateAction : byte {
        Insert = "0",
        Change = "1",
        Delete = "2",
        Overlay = "5",
    };


    /// <summary>
    ///  Md Volume Type Values
    /// </summary>
    public enum MdVolumeType : byte {
        TotalLimit = "0",
        CustomerLimit = "1",
        TotalContingencyAllOrNone = "2",
        CustomerContingencyAllOrNone = "3",
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public struct MessageCount {
        public byte Raw;
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public struct MessageLength {
        public ushort Raw;
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public struct MessageSequenceNumber {
        public uint Raw;
    };


    /// <summary>
    ///  Message Type
    /// </summary>
    public unsafe struct MessageType {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  No Entries
    /// </summary>
    public struct NoEntries {
        public byte Raw;
    };


    /// <summary>
    ///  No Legs
    /// </summary>
    public struct NoLegs {
        public byte Raw;
    };


    /// <summary>
    ///  Packet Length
    /// </summary>
    public struct PacketLength {
        public ushort Raw;
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
    ///  Price Type
    /// </summary>
    public struct PriceType {
        public byte Raw;
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = "0",
        Call = "1",
    };


    /// <summary>
    ///  Refresh Indicator Values
    /// </summary>
    public enum RefreshIndicator : byte {
        MandatoryRefresh = (byte)'Y',
        ProcessIfNecessary = (byte)'N',
    };


    /// <summary>
    ///  Rpt Seq
    /// </summary>
    public struct RptSeq {
        public uint Raw;
    };


    /// <summary>
    ///  Security Exchange Values
    /// </summary>
    public enum SecurityExchange : byte {
        Cboe = (byte)'C',
        OneChicagoNotSupported = (byte)'O',
        CbsxNotSupported = (byte)'W',
        CfecofNotSupported = (byte)'F',
        Cboe2OptionsNotSupported = (byte)'2',
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public struct SecurityId {
        public uint Raw;
    };


    /// <summary>
    ///  Security Trading Status Values
    /// </summary>
    public enum SecurityTradingStatus : byte {
        Halted = "2",
        Open = "17",
        Closed = "18",
        PreOpen = "21",
        OpeningRotation = "22",
        FastMarket = "23",
        StrategyMarketInOpeningRotation = "24",
        StrategyMarketQuotesNonFirm = "25",
        Suspended = "26",
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

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public struct SendingTime {
        public ulong Raw;
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

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : byte {
        SecurityDefinitionMessage = "13",
        SnapshotFullRefreshMessage = "17",
        IncrementalRefreshMessage = "18",
        SecurityStatusMessage = "19",
        HeartbeatMessage = "16",
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

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Struct for Incremental Refresh Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IncrementalRefreshMdEntry {
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        MdPriceLevel MdPriceLevel;
        MdEntryPx MdEntryPx;
        NoLegs NoLegs;
    };


    /// <summary>
    ///  Struct for Incremental Refresh Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IncrementalRefreshMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        RptSeq RptSeq;
        SecurityTradingStatus SecurityTradingStatus;
        PriceType PriceType;
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
    ///  Struct for Md Entry Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdEntryPx {
        MdEntryPxExponent MdEntryPxExponent;
        MdEntryPxMantissa MdEntryPxMantissa;
    };


    /// <summary>
    ///  Struct for Md Volume Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdVolumeEntry {
        MdVolumeType MdVolumeType;
        MdEntrySize MdEntrySize;
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
    ///  Struct for Security Definition Leg
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionLeg {
        LegRatioQty LegRatioQty;
        LegSecurityId LegSecurityId;
        LegSide LegSide;
    };


    /// <summary>
    ///  Struct for Security Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatusMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        RptSeq RptSeq;
        SecurityTradingStatus SecurityTradingStatus;
    };


    /// <summary>
    ///  Struct for Security Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityType {
        SecurityTypeLength SecurityTypeLength;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Md Entry
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshMdEntry {
        MdEntryType MdEntryType;
        MdPriceLevel MdPriceLevel;
        MdEntryPx MdEntryPx;
        NoLegs NoLegs;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshMessage {
        ClassKey ClassKey;
        SecurityId SecurityId;
        RptSeq RptSeq;
        SecurityTradingStatus SecurityTradingStatus;
        PriceType PriceType;
        RefreshIndicator RefreshIndicator;
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
