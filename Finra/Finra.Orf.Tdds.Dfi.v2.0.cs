namespace Finra.Orf.Tdds.Dfi.v2.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Action Values
    /// </summary>
    public enum Action : byte {
        TradingHalt = (byte)'H',
        QuotationResumption = (byte)'Q',
        TradingResumption = (byte)'T',
        QuotationAndTradingResumption = (byte)'X',
    };


    /// <summary>
    ///  Administrative Message Type Values
    /// </summary>
    public enum AdministrativeMessageType : byte {
        GeneralAdministrativeMessage = (byte)'A',
        ClosingTradeSummaryReportMessage = (byte)'2',
        TradingActionMessage = (byte)'H',
        MarketWideCircuitBreakerEventMessage = (byte)'M',
    };


    /// <summary>
    ///  As Of Indicator Values
    /// </summary>
    public enum AsOfIndicator : byte {
        AsOf = (byte)'A',
        Reversal = (byte)'R',
        CurrentDayTransaction = (byte)' ',
    };


    /// <summary>
    ///  Block Soh
    /// </summary>
    public unsafe struct BlockSoh {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Price
    /// </summary>
    public unsafe struct ClosingPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Price Denominator
    /// </summary>
    public unsafe struct ClosingPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Price Market Center Values
    /// </summary>
    public enum ClosingPriceMarketCenter : byte {
        Otcbb = (byte)'U',
        Ootc = (byte)'u',
        NotApplicable = (byte)' ',
    };


    /// <summary>
    ///  Control Message Type Values
    /// </summary>
    public enum ControlMessageType : byte {
        StartOfDayMessage = (byte)'I',
        EndOfDayMessage = (byte)'J',
        MarketSessionOpenMessage = (byte)'O',
        MarketSessionCloseMessage = (byte)'O',
        EndOfRetransmissionRequestsMessage = (byte)'K',
        EndOfTransmissionsMessage = (byte)'Z',
        LineIntegrityMessage = (byte)'T',
        SequenceNumberResetMessage = (byte)'L',
        EndOfTradeReportingMessage = (byte)'X',
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
    ///  Daily High Price
    /// </summary>
    public unsafe struct DailyHighPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily High Price Denominator
    /// </summary>
    public unsafe struct DailyHighPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Low Price
    /// </summary>
    public unsafe struct DailyLowPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Low Price Denominator
    /// </summary>
    public unsafe struct DailyLowPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Day
    /// </summary>
    public unsafe struct Day {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Price
    /// </summary>
    public unsafe struct HighPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Price Denominator
    /// </summary>
    public unsafe struct HighPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Hour
    /// </summary>
    public unsafe struct Hour {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Sale Price
    /// </summary>
    public unsafe struct LastSalePrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Sale Price Denominator
    /// </summary>
    public unsafe struct LastSalePriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Sale Price Market Center Values
    /// </summary>
    public enum LastSalePriceMarketCenter : byte {
        Otcbb = (byte)'U',
        Ootc = (byte)'u',
        NotApplicable = (byte)' ',
    };


    /// <summary>
    ///  Low Price
    /// </summary>
    public unsafe struct LowPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Low Price Denominator
    /// </summary>
    public unsafe struct LowPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Center Originator Id Values
    /// </summary>
    public enum MarketCenterOriginatorId : ulong {
        MarketCenterIndependent = "E",
        OtcBulletinBoard = "U",
        OtherOtcSecurity = "u",
        OtcbbAndOotc = "F",
    };


    /// <summary>
    ///  Message Category Values
    /// </summary>
    public enum MessageCategory : byte {
        Trade = (byte)'T',
        Administrative = (byte)'A',
        Control = (byte)'C',
    };


    /// <summary>
    ///  Message Separator
    /// </summary>
    public unsafe struct MessageSeparator {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public unsafe struct MessageSequenceNumber {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Millisecond
    /// </summary>
    public unsafe struct Millisecond {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Minute
    /// </summary>
    public unsafe struct Minute {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Month
    /// </summary>
    public unsafe struct Month {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Net Change Amount
    /// </summary>
    public unsafe struct NetChangeAmount {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Net Change Denominator
    /// </summary>
    public unsafe struct NetChangeDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Net Change Direction Values
    /// </summary>
    public enum NetChangeDirection : byte {
        PositiveOrZeroNetChange = (byte)'+',
        NegativeNetChange = (byte)'-',
        NoTradeOrUnaffected = (byte)' ',
    };


    /// <summary>
    ///  Original Message Sequence Number
    /// </summary>
    public unsafe struct OriginalMessageSequenceNumber {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Change Indicator Values
    /// </summary>
    public enum PriceChangeIndicator : byte {
        NoPriceChange = (byte)'0',
        LastPriceChanged = (byte)'1',
        LowPriceChanged = (byte)'2',
        LastAndLowPricesChanged = (byte)'3',
        HighPriceChanged = (byte)'4',
        LastAndHighPricesChanged = (byte)'5',
        HighAndLowPricesChanged = (byte)'6',
        AllPricesChanged = (byte)'7',
    };


    /// <summary>
    ///  Reason Code
    /// </summary>
    public unsafe struct ReasonCode {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Report Function Values
    /// </summary>
    public enum ReportFunction : byte {
        Cancel = (byte)'C',
        Error = (byte)'E',
        Correction = (byte)'N',
    };


    /// <summary>
    ///  Report Volume
    /// </summary>
    public unsafe struct ReportVolume {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Report Volume Short
    /// </summary>
    public unsafe struct ReportVolumeShort {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Retransmission Requester
    /// </summary>
    public unsafe struct RetransmissionRequester {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sale Condition Level 1 Values
    /// </summary>
    public enum SaleConditionLevel1 : byte {
        RegularTrade = (byte)'@',
        CashTrade = (byte)'C',
        NextDay = (byte)'N',
        Seller = (byte)'R',
    };


    /// <summary>
    ///  Sale Condition Level 2
    /// </summary>
    public unsafe struct SaleConditionLevel2 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sale Condition Level 3 Values
    /// </summary>
    public enum SaleConditionLevel3 : byte {
        ExecutedOutsideNormalMarketHours = (byte)'T',
        ExecutedOutsideNormalMarketHoursAndTradeReportedLate = (byte)'U',
        ExecutedDuringNormalMarketHoursAndTradeReportedLate = (byte)'Z',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Sale Condition Level 4 Values
    /// </summary>
    public enum SaleConditionLevel4 : byte {
        OddLotTrade = (byte)'I',
        PriorReferencePrice = (byte)'P',
        AveragePriceTrade = (byte)'W',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Second
    /// </summary>
    public unsafe struct Second {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 14;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol Short
    /// </summary>
    public unsafe struct SecuritySymbolShort {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sellers Sale Days
    /// </summary>
    public unsafe struct SellersSaleDays {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Identifier Values
    /// </summary>
    public enum SessionIdentifier : byte {
        AllMarketSessionsOrSessionIndependent = (byte)'A',
        UsMarketSession = (byte)'U',
    };


    /// <summary>
    ///  Text
    /// </summary>
    public unsafe struct Text {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Security Volume
    /// </summary>
    public unsafe struct TotalSecurityVolume {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Message Type Values
    /// </summary>
    public enum TradeMessageType : byte {
        TradeReportShortFormMessage = (byte)'5',
        TradeReportLongFormMessage = (byte)'6',
        TradeCancelErrorMessage = (byte)'7',
        TradeCorrectionMessage = (byte)'8',
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public unsafe struct TradePrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price Denominator
    /// </summary>
    public unsafe struct TradePriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price Short
    /// </summary>
    public unsafe struct TradePriceShort {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Year
    /// </summary>
    public unsafe struct Year {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Action Datetime
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ActionDatetime {
        Year Year;
        Month Month;
        Day Day;
        Hour Hour;
        Minute Minute;
        Second Second;
        Millisecond Millisecond;
    };


    /// <summary>
    ///  Struct for Administrative
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Administrative {
        AdministrativeMessageType AdministrativeMessageType;
    };


    /// <summary>
    ///  Struct for Closing Trade Summary Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClosingTradeSummaryReportMessage {
        MessageHeader MessageHeader;
        SecuritySymbol SecuritySymbol;
        DailyHighPriceDenominator DailyHighPriceDenominator;
        DailyHighPrice DailyHighPrice;
        DailyLowPriceDenominator DailyLowPriceDenominator;
        DailyLowPrice DailyLowPrice;
        ClosingPriceMarketCenter ClosingPriceMarketCenter;
        ClosingPriceDenominator ClosingPriceDenominator;
        ClosingPrice ClosingPrice;
        Reserved Reserved;
        NetChangeDenominator NetChangeDenominator;
        NetChangeAmount NetChangeAmount;
        NetChangeDirection NetChangeDirection;
        Currency Currency;
        TotalSecurityVolume TotalSecurityVolume;
    };


    /// <summary>
    ///  Struct for Control
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Control {
        ControlMessageType ControlMessageType;
    };


    /// <summary>
    ///  Struct for Corrected Trade Information
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CorrectedTradeInformation {
        ReportVolume ReportVolume;
        TradePriceDenominator TradePriceDenominator;
        TradePrice TradePrice;
        Currency Currency;
        AsOfIndicator AsOfIndicator;
        ExecutionDatetime ExecutionDatetime;
        SaleConditionLevel1 SaleConditionLevel1;
        SaleConditionLevel2 SaleConditionLevel2;
        SaleConditionLevel3 SaleConditionLevel3;
        SaleConditionLevel4 SaleConditionLevel4;
        SellersSaleDays SellersSaleDays;
    };


    /// <summary>
    ///  Struct for Datetime
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Datetime {
        Year Year;
        Month Month;
        Day Day;
        Hour Hour;
        Minute Minute;
        Second Second;
        Millisecond Millisecond;
    };


    /// <summary>
    ///  Struct for End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for End Of Retransmission Requests Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfRetransmissionRequestsMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for End Of Trade Reporting Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfTradeReportingMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for End Of Transmissions Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfTransmissionsMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Execution Datetime
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionDatetime {
        Year Year;
        Month Month;
        Day Day;
        Hour Hour;
        Minute Minute;
        Second Second;
        Millisecond Millisecond;
    };


    /// <summary>
    ///  Struct for General Administrative Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GeneralAdministrativeMessage {
        MessageHeader MessageHeader;
        Text Text;
    };


    /// <summary>
    ///  Struct for Line Integrity Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LineIntegrityMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Market Session Close Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSessionCloseMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Market Session Open Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSessionOpenMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Market Wide Circuit Breaker Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketWideCircuitBreakerEventMessage {
        MessageHeader MessageHeader;
        Action Action;
        ActionDatetime ActionDatetime;
        ReasonCode ReasonCode;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        SessionIdentifier SessionIdentifier;
        RetransmissionRequester RetransmissionRequester;
        MessageSequenceNumber MessageSequenceNumber;
        MarketCenterOriginatorId MarketCenterOriginatorId;
        Datetime Datetime;
    };


    /// <summary>
    ///  Struct for Original Dissemination Date
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OriginalDisseminationDate {
        Year Year;
        Month Month;
        Day Day;
    };


    /// <summary>
    ///  Struct for Original Trade Information
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OriginalTradeInformation {
        ReportVolume ReportVolume;
        TradePriceDenominator TradePriceDenominator;
        TradePrice TradePrice;
        Currency Currency;
        AsOfIndicator AsOfIndicator;
        ExecutionDatetime ExecutionDatetime;
        SaleConditionLevel1 SaleConditionLevel1;
        SaleConditionLevel2 SaleConditionLevel2;
        SaleConditionLevel3 SaleConditionLevel3;
        SaleConditionLevel4 SaleConditionLevel4;
        SellersSaleDays SellersSaleDays;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        BlockSoh BlockSoh;
    };


    /// <summary>
    ///  Struct for Sequence Number Reset Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequenceNumberResetMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfDayMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Trade
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Trade {
        TradeMessageType TradeMessageType;
    };


    /// <summary>
    ///  Struct for Trade Cancel Error Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelErrorMessage {
        MessageHeader MessageHeader;
        SecuritySymbol SecuritySymbol;
        OriginalDisseminationDate OriginalDisseminationDate;
        OriginalMessageSequenceNumber OriginalMessageSequenceNumber;
        ReportFunction ReportFunction;
        OriginalTradeInformation OriginalTradeInformation;
        TradeSummaryInformation TradeSummaryInformation;
    };


    /// <summary>
    ///  Struct for Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCorrectionMessage {
        MessageHeader MessageHeader;
        SecuritySymbol SecuritySymbol;
        OriginalDisseminationDate OriginalDisseminationDate;
        OriginalMessageSequenceNumber OriginalMessageSequenceNumber;
        ReportFunction ReportFunction;
        OriginalTradeInformation OriginalTradeInformation;
        CorrectedTradeInformation CorrectedTradeInformation;
        TradeSummaryInformation TradeSummaryInformation;
    };


    /// <summary>
    ///  Struct for Trade Information
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeInformation {
        ReportVolume ReportVolume;
        TradePriceDenominator TradePriceDenominator;
        TradePrice TradePrice;
        Currency Currency;
        AsOfIndicator AsOfIndicator;
        ExecutionDatetime ExecutionDatetime;
        SaleConditionLevel1 SaleConditionLevel1;
        SaleConditionLevel2 SaleConditionLevel2;
        SaleConditionLevel3 SaleConditionLevel3;
        SaleConditionLevel4 SaleConditionLevel4;
        SellersSaleDays SellersSaleDays;
        PriceChangeIndicator PriceChangeIndicator;
    };


    /// <summary>
    ///  Struct for Trade Report Long Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportLongFormMessage {
        MessageHeader MessageHeader;
        SecuritySymbol SecuritySymbol;
        OriginalDisseminationDate OriginalDisseminationDate;
        TradeInformation TradeInformation;
    };


    /// <summary>
    ///  Struct for Trade Report Short Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportShortFormMessage {
        MessageHeader MessageHeader;
        SecuritySymbolShort SecuritySymbolShort;
        SaleConditionLevel1 SaleConditionLevel1;
        TradePriceDenominator TradePriceDenominator;
        TradePriceShort TradePriceShort;
        ReportVolumeShort ReportVolumeShort;
        PriceChangeIndicator PriceChangeIndicator;
    };


    /// <summary>
    ///  Struct for Trade Summary Information
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeSummaryInformation {
        HighPriceDenominator HighPriceDenominator;
        HighPrice HighPrice;
        LowPriceDenominator LowPriceDenominator;
        LowPrice LowPrice;
        LastSalePriceDenominator LastSalePriceDenominator;
        LastSalePrice LastSalePrice;
        LastSalePriceMarketCenter LastSalePriceMarketCenter;
        TotalSecurityVolume TotalSecurityVolume;
        PriceChangeIndicator PriceChangeIndicator;
    };


    /// <summary>
    ///  Struct for Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingActionMessage {
        MessageHeader MessageHeader;
        SecuritySymbol SecuritySymbol;
        Action Action;
        ActionDatetime ActionDatetime;
        ReasonCode ReasonCode;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
