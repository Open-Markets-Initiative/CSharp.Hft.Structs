namespace Cme.Futures.Settlements.Sbe.v7.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Actual
    /// </summary>
    public unsafe struct Actual {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Block Length
    /// </summary>
    public unsafe struct BlockLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cabinet
    /// </summary>
    public unsafe struct Cabinet {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cleared Volume
    /// </summary>
    public unsafe struct ClearedVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Product Code
    /// </summary>
    public unsafe struct ClearingProductCode {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Day
    /// </summary>
    public unsafe struct Day {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exponent
    /// </summary>
    public struct Exponent {
        public sbyte Raw;
    };


    /// <summary>
    ///  Final Daily
    /// </summary>
    public unsafe struct FinalDaily {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  High Px Ind Values
    /// </summary>
    public enum HighPxInd : byte {
        Ask = (byte)'A',
        Bid = (byte)'B',
        Trade = (byte)'T',
    };


    /// <summary>
    ///  Instrument Guid
    /// </summary>
    public unsafe struct InstrumentGuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Intraday
    /// </summary>
    public unsafe struct Intraday {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Low Px Ind Values
    /// </summary>
    public enum LowPxInd : byte {
        Ask = (byte)'A',
        Bid = (byte)'B',
        Trade = (byte)'T',
    };


    /// <summary>
    ///  Mantissa
    /// </summary>
    public struct Mantissa {
        public long Raw;
    };


    /// <summary>
    ///  Md Entry Px
    /// </summary>
    public struct MdEntryPx {
        public long Raw;
    };


    /// <summary>
    ///  Md Entry Type
    /// </summary>
    public unsafe struct MdEntryType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Statistic Desc
    /// </summary>
    public unsafe struct MdStatisticDesc {
        public const int Size = 40;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Update Action Values
    /// </summary>
    public enum MdUpdateAction : byte {
        New = 0,
        Change = 1,
        Delete = 2,
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public unsafe struct MessageSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Size
    /// </summary>
    public unsafe struct MessageSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Month
    /// </summary>
    public unsafe struct Month {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Null Value
    /// </summary>
    public unsafe struct NullValue {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Num In Group uint 8
    /// </summary>
    public unsafe struct NumInGroupUint8 {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Close Settl Flag Values
    /// </summary>
    public enum OpenCloseSettlFlag : byte {
        Estimated = 3,
        ActualAdjusted = 4,
    };


    /// <summary>
    ///  Open Interest Qty
    /// </summary>
    public unsafe struct OpenInterestQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Guid
    /// </summary>
    public unsafe struct ProductGuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        NoValue = 255,
        Put = 0,
        Call = 1,
    };


    /// <summary>
    ///  Reserved Bits
    /// </summary>
    public unsafe struct ReservedBits {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rounded
    /// </summary>
    public unsafe struct Rounded {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public unsafe struct SchemaId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Exchange
    /// </summary>
    public unsafe struct SecurityExchange {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public unsafe struct SecurityId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Type
    /// </summary>
    public unsafe struct SecurityType {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public unsafe struct SendingTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : ushort {
        MdIncrementalRefreshSettle = 401,
        MdIncrementalRefreshVoi = 402,
        MdIncrementalRefreshHighLow = 403,
        AdminHeartbeat = 407,
    };


    /// <summary>
    ///  Trading Reference Date
    /// </summary>
    public unsafe struct TradingReferenceDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public unsafe struct TransactTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Clearing Product Code
    /// </summary>
    public unsafe struct UnderlyingClearingProductCode {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Product Guid
    /// </summary>
    public unsafe struct UnderlyingProductGuid {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Security Exchange
    /// </summary>
    public unsafe struct UnderlyingSecurityExchange {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Security Type
    /// </summary>
    public unsafe struct UnderlyingSecurityType {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Week
    /// </summary>
    public unsafe struct Week {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Year
    /// </summary>
    public unsafe struct Year {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Binary Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BinaryPacketHeader {
        MessageSequenceNumber MessageSequenceNumber;
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Formatted Last Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FormattedLastPx {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Group Size
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GroupSize {
        BlockLength BlockLength;
        NumInGroupUint8 NumInGroupUint8;
    };


    /// <summary>
    ///  Struct for High Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HighPx {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Low Px
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LowPx {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh High Low Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshHighLowGroup {
        ProductGuid ProductGuid;
        ClearingProductCode ClearingProductCode;
        SecurityType SecurityType;
        SecurityExchange SecurityExchange;
        MaturityMonthYear MaturityMonthYear;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        UnderlyingProductGuid UnderlyingProductGuid;
        UnderlyingClearingProductCode UnderlyingClearingProductCode;
        UnderlyingSecurityType UnderlyingSecurityType;
        UnderlyingSecurityExchange UnderlyingSecurityExchange;
        UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear;
        Symbol Symbol;
        InstrumentGuid InstrumentGuid;
        SecurityId SecurityId;
        LowPx LowPx;
        LowPxInd LowPxInd;
        HighPx HighPx;
        HighPxInd HighPxInd;
        TradingReferenceDate TradingReferenceDate;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh High Low Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshHighLowGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Settle Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshSettleGroup {
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        ProductGuid ProductGuid;
        ClearingProductCode ClearingProductCode;
        SecurityType SecurityType;
        SecurityExchange SecurityExchange;
        MaturityMonthYear MaturityMonthYear;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        UnderlyingProductGuid UnderlyingProductGuid;
        UnderlyingClearingProductCode UnderlyingClearingProductCode;
        UnderlyingSecurityType UnderlyingSecurityType;
        UnderlyingSecurityExchange UnderlyingSecurityExchange;
        UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear;
        Symbol Symbol;
        InstrumentGuid InstrumentGuid;
        SecurityId SecurityId;
        FormattedLastPx FormattedLastPx;
        MdEntryPx MdEntryPx;
        SettlPriceType SettlPriceType;
        TradingReferenceDate TradingReferenceDate;
        MdStatisticDesc MdStatisticDesc;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Settle Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshSettleGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Voi Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshVoiGroup {
        ProductGuid ProductGuid;
        ClearingProductCode ClearingProductCode;
        SecurityType SecurityType;
        SecurityExchange SecurityExchange;
        MaturityMonthYear MaturityMonthYear;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        UnderlyingProductGuid UnderlyingProductGuid;
        UnderlyingClearingProductCode UnderlyingClearingProductCode;
        UnderlyingSecurityType UnderlyingSecurityType;
        UnderlyingSecurityExchange UnderlyingSecurityExchange;
        UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear;
        Symbol Symbol;
        InstrumentGuid InstrumentGuid;
        SecurityId SecurityId;
        ClearedVolume ClearedVolume;
        OpenInterestQty OpenInterestQty;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        TradingReferenceDate TradingReferenceDate;
    };


    /// <summary>
    ///  Struct for M D Incremental Refresh Voi Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MDIncrementalRefreshVoiGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Maturity Month Year
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MaturityMonthYear {
        Year Year;
        Month Month;
        Day Day;
        Week Week;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh High Low 403
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshHighLow403 {
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Settle 401
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshSettle401 {
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Vo I 402
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshVoI402 {
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageSize MessageSize;
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        BinaryPacketHeader BinaryPacketHeader;
    };


    /// <summary>
    ///  Struct for Settl Price Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlPriceType {
        NullValue NullValue;
        ReservedBits ReservedBits;
        Cabinet Cabinet;
        Intraday Intraday;
        Rounded Rounded;
        Actual Actual;
        FinalDaily FinalDaily;
    };


    /// <summary>
    ///  Struct for Strike Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrikePrice {
        Mantissa Mantissa;
        Exponent Exponent;
    };


    /// <summary>
    ///  Struct for Underlying Maturity Month Year
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingMaturityMonthYear {
        Year Year;
        Month Month;
        Day Day;
        Week Week;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
