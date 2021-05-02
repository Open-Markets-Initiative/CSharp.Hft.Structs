namespace Finra.Otc.Bbds.Dfi.v2018.1A {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Action Values
    /// </summary>
    public enum Action : byte {
        TradingHalt = (byte)'H',
        QuotationResumption = (byte)'Q',
        TradingResumption = (byte)'T',
    };


    /// <summary>
    ///  Administrative Message Type Values
    /// </summary>
    public enum AdministrativeMessageType : byte {
        GeneralAdministrativeMessage = (byte)'A',
        TradingActionMessage = (byte)'H',
    };


    /// <summary>
    ///  Ask Price
    /// </summary>
    public unsafe struct AskPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Price Denominator
    /// </summary>
    public unsafe struct AskPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Size
    /// </summary>
    public unsafe struct AskSize {
        public const int Size = 7;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public unsafe struct BidPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price Denominator
    /// </summary>
    public unsafe struct BidPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 7;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Day
    /// </summary>
    public unsafe struct Day {
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
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Appendage Indicator Values
    /// </summary>
    public enum InsideAppendageIndicator : byte {
        NoChangeToInsideQuote = (byte)'1',
        NoInsideExists = (byte)'2',
        InsideQuoteAppendageIsAttached = (byte)'3',
    };


    /// <summary>
    ///  Inside Ask Price
    /// </summary>
    public unsafe struct InsideAskPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Ask Price Denominator
    /// </summary>
    public unsafe struct InsideAskPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Ask Size
    /// </summary>
    public unsafe struct InsideAskSize {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Bid Price
    /// </summary>
    public unsafe struct InsideBidPrice {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Bid Price Denominator
    /// </summary>
    public unsafe struct InsideBidPriceDenominator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Bid Size
    /// </summary>
    public unsafe struct InsideBidSize {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Quote Condition Values
    /// </summary>
    public enum InsideQuoteCondition : byte {
        Open = (byte)'O',
        Closed = (byte)'C',
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
    ///  Market Participant Identifier
    /// </summary>
    public unsafe struct MarketParticipantIdentifier {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Participant Location Id
    /// </summary>
    public unsafe struct MarketParticipantLocationId {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Participant Quote Condition Values
    /// </summary>
    public enum MarketParticipantQuoteCondition : byte {
        Open = (byte)'O',
        Closed = (byte)'C',
        Bid = (byte)'B',
        NotApplicable = (byte)'N',
        Offer = (byte)'O',
        BidAndOffer = (byte)'W',
        PeriodicIndicativeOtherSecurities = (byte)'I',
        RealtimeQuotes = (byte)'K',
        PeriodicIndicativeQuotes = (byte)'L',
    };


    /// <summary>
    ///  Market Participant Status Values
    /// </summary>
    public enum MarketParticipantStatus : byte {
        Active = (byte)'A',
        Deleted = (byte)'D',
        Excused = (byte)'E',
        Withdrawn = (byte)'W',
        Suspended = (byte)'S',
    };


    /// <summary>
    ///  Message Category Values
    /// </summary>
    public enum MessageCategory : byte {
        Quotation = (byte)'Q',
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
    ///  Minute
    /// </summary>
    public unsafe struct Minute {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Month
    /// </summary>
    public unsafe struct Month {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Otcbb Symbol
    /// </summary>
    public unsafe struct OtcbbSymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Otcbb Type
    /// </summary>
    public unsafe struct OtcbbType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quotation Message Type Values
    /// </summary>
    public enum QuotationMessageType : byte {
        MarketParticipantQuoteUpdateMessage = (byte)'1',
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
    ///  Second
    /// </summary>
    public unsafe struct Second {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Unsolicited Indicator Values
    /// </summary>
    public enum UnsolicitedIndicator : byte {
        UnsolicitedAsk = (byte)'A',
        UnsolicitedBid = (byte)'B',
        UnsolicitedBidAndAsk = (byte)'U',
        NotApplicable = (byte)' ',
    };


    /// <summary>
    ///  Wanted Indicator
    /// </summary>
    public unsafe struct WantedIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Year
    /// </summary>
    public unsafe struct Year {
        public const int Size = 2;

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
    };


    /// <summary>
    ///  Struct for Administrative
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Administrative {
        AdministrativeMessageType AdministrativeMessageType;
    };


    /// <summary>
    ///  Struct for Control
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Control {
        ControlMessageType ControlMessageType;
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
    ///  Struct for General Administrative Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GeneralAdministrativeMessage {
        MessageHeader MessageHeader;
        Text Text;
    };


    /// <summary>
    ///  Struct for Inside Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InsideAppendage {
        InsideQuoteCondition InsideQuoteCondition;
        InsideBidPriceDenominator InsideBidPriceDenominator;
        InsideBidPrice InsideBidPrice;
        InsideBidSize InsideBidSize;
        InsideAskPriceDenominator InsideAskPriceDenominator;
        InsideAskPrice InsideAskPrice;
        InsideAskSize InsideAskSize;
    };


    /// <summary>
    ///  Struct for Line Integrity Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LineIntegrityMessage {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Market Participant Quote Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketParticipantQuoteUpdateMessage {
        OtcbbSymbol OtcbbSymbol;
        OtcbbType OtcbbType;
        MarketParticipantIdentifier MarketParticipantIdentifier;
        MarketParticipantLocationId MarketParticipantLocationId;
        MarketParticipantStatus MarketParticipantStatus;
        MarketParticipantQuoteCondition MarketParticipantQuoteCondition;
        Reserved Reserved;
        WantedIndicator WantedIndicator;
        UnsolicitedIndicator UnsolicitedIndicator;
        BidPriceDenominator BidPriceDenominator;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPriceDenominator AskPriceDenominator;
        AskPrice AskPrice;
        AskSize AskSize;
        Currency Currency;
        InsideAppendageIndicator InsideAppendageIndicator;
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
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        SessionIdentifier SessionIdentifier;
        RetransmissionRequester RetransmissionRequester;
        MessageSequenceNumber MessageSequenceNumber;
        MarketCenterOriginatorId MarketCenterOriginatorId;
        Datetime Datetime;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        BlockSoh BlockSoh;
    };


    /// <summary>
    ///  Struct for Quotation
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Quotation {
        QuotationMessageType QuotationMessageType;
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
