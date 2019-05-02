namespace Miax.Options.Tom.Mach.v1.9 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Active On Miax
    /// </summary>
    public unsafe struct ActiveOnMiax {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Condition Values
    /// </summary>
    public enum BidCondition : byte {
        Regular = (byte)'A',
        PublicCustomerInterest = (byte)'B',
        NotFirm = (byte)'C',
        TradingHalt = (byte)'T',
    };


    /// <summary>
    ///  Bid Price 2
    /// </summary>
    public unsafe struct BidPrice2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price 4
    /// </summary>
    public unsafe struct BidPrice4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Priority Customer Size 2
    /// </summary>
    public unsafe struct BidPriorityCustomerSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Priority Customer Size 4
    /// </summary>
    public unsafe struct BidPriorityCustomerSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size 2
    /// </summary>
    public unsafe struct BidSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size 4
    /// </summary>
    public unsafe struct BidSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Call Or Put
    /// </summary>
    public unsafe struct CallOrPut {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Time
    /// </summary>
    public unsafe struct ClosingTime {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Correction Number
    /// </summary>
    public unsafe struct CorrectionNumber {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Reason Values
    /// </summary>
    public enum EventReason : byte {
        Automatic = (byte)'A',
        Manual = (byte)'M',
    };


    /// <summary>
    ///  Expected Event Time Nano Seconds Part
    /// </summary>
    public unsafe struct ExpectedEventTimeNanoSecondsPart {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Date
    /// </summary>
    public unsafe struct ExpirationDate {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Liquidity Acceptance Increment Indicator Values
    /// </summary>
    public enum LiquidityAcceptanceIncrementIndicator : byte {
        Penny = (byte)'P',
        Nickel = (byte)'N',
        Dime = (byte)'D',
    };


    /// <summary>
    ///  Long Term Option
    /// </summary>
    public unsafe struct LongTermOption {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mbbo Condition Values
    /// </summary>
    public enum MbboCondition : byte {
        Regular = (byte)'A',
        PublicCustomerInterest = (byte)'B',
        NotFirm = (byte)'C',
        TradingHalt = (byte)'T',
    };


    /// <summary>
    ///  Mbbo Price 2
    /// </summary>
    public unsafe struct MbboPrice2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mbbo Price 4
    /// </summary>
    public unsafe struct MbboPrice4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mbbo Priority Customer Size 2
    /// </summary>
    public unsafe struct MbboPriorityCustomerSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mbbo Priority Customer Size 4
    /// </summary>
    public unsafe struct MbboPriorityCustomerSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mbbo Size 2
    /// </summary>
    public unsafe struct MbboSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mbbo Size 4
    /// </summary>
    public unsafe struct MbboSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemTimeMessage = (byte)'1',
        SeriesUpdate = (byte)'P',
        SystemStateMessage = (byte)'S',
        TopOfMarketBidCompactMessage = (byte)'B',
        TopOfMarketOfferCompactMessage = (byte)'O',
        WideTopOfMarketBidMessage = (byte)'W',
        WideTopOfMarketOfferMessage = (byte)'A',
        DoubleSidedTopOfMarketCompactMessage = (byte)'d',
        WideDoubleSidedTopOfMarketMessage = (byte)'D',
        TradeMessage = (byte)'T',
        TradeCancelMessage = (byte)'X',
        UnderlyingTradingStatusMessage = (byte)'H',
    };


    /// <summary>
    ///  Miax Bbo Posting Increment Indicator Values
    /// </summary>
    public enum MiaxBboPostingIncrementIndicator : byte {
        Penny = (byte)'P',
        Nickel = (byte)'N',
        Dime = (byte)'D',
    };


    /// <summary>
    ///  Notification Time
    /// </summary>
    public unsafe struct NotificationTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Condition Values
    /// </summary>
    public enum OfferCondition : byte {
        Regular = (byte)'A',
        PublicCustomerInterest = (byte)'B',
        NotFirm = (byte)'C',
        TradingHalt = (byte)'T',
    };


    /// <summary>
    ///  Offer Price 2
    /// </summary>
    public unsafe struct OfferPrice2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Price 4
    /// </summary>
    public unsafe struct OfferPrice4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Priority Customer Size 2
    /// </summary>
    public unsafe struct OfferPriorityCustomerSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Priority Customer Size 4
    /// </summary>
    public unsafe struct OfferPriorityCustomerSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size 2
    /// </summary>
    public unsafe struct OfferSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size 4
    /// </summary>
    public unsafe struct OfferSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opening Time
    /// </summary>
    public unsafe struct OpeningTime {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opening Underlying Market Code Values
    /// </summary>
    public enum OpeningUnderlyingMarketCode : byte {
        NyseAmex = (byte)'A',
        NasdaqOmxBx = (byte)'B',
        Nse = (byte)'C',
        FinraAdf = (byte)'D',
        MarketIndependent = (byte)'E',
        Ise = (byte)'I',
        Edga = (byte)'J',
        Edgx = (byte)'K',
        Cse = (byte)'M',
        NyseEuronext = (byte)'N',
        NyseArca = (byte)'P',
        NasdaqOmxUtp = (byte)'Q',
        NasdaqOmxCta = (byte)'T',
        Iex = (byte)'V',
        NasdaqOmxPhlx = (byte)'X',
        BatsY = (byte)'Y',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Packet Length
    /// </summary>
    public unsafe struct PacketLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Type Values
    /// </summary>
    public enum PacketType : byte {
        Heartbeat = 0,
        StartOfSession = 1,
        EndOfSession = 2,
        ApplicationMessage = 3,
    };


    /// <summary>
    ///  Priority Quote Width
    /// </summary>
    public unsafe struct PriorityQuoteWidth {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Add Update Time
    /// </summary>
    public unsafe struct ProductAddUpdateTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public unsafe struct ProductId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Correction Number
    /// </summary>
    public unsafe struct ReferenceCorrectionNumber {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Trade Id
    /// </summary>
    public unsafe struct ReferenceTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Restricted Option
    /// </summary>
    public unsafe struct RestrictedOption {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seconds Part
    /// </summary>
    public unsafe struct SecondsPart {
        public const int Size = 4;

        public int Value;

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
    ///  Sequence Number
    /// </summary>
    public unsafe struct SequenceNumber {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Id
    /// </summary>
    public unsafe struct SessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Number
    /// </summary>
    public unsafe struct SessionNumber {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public unsafe struct StrikePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Status Values
    /// </summary>
    public enum SystemStatus : byte {
        StartOfSystemHours = (byte)'S',
        EndOfSystemHours = (byte)'C',
        StartTestSession = (byte)'1',
        EndOfTestSession = (byte)'2',
        TopBid = (byte)'B',
        TopOffer = (byte)'O',
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  To M Version
    /// </summary>
    public unsafe struct ToMVersion {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        CancelOfTrade = (byte)'A',
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public unsafe struct TradePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Size
    /// </summary>
    public unsafe struct TradeSize {
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
        Resumed = (byte)'R',
        Opened = (byte)'O',
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 11;

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
    ///  Struct for Application Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApplicationMessage {
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Double-Sided Top of Market Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DoubleSidedTopOfMarketCompactMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        BidPriorityCustomerSize2 BidPriorityCustomerSize2;
        BidCondition BidCondition;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        OfferPriorityCustomerSize2 OfferPriorityCustomerSize2;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        SequenceNumber SequenceNumber;
        PacketLength PacketLength;
        PacketType PacketType;
        SessionNumber SessionNumber;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
    };


    /// <summary>
    ///  Struct for Series Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SeriesUpdate {
        ProductAddUpdateTime ProductAddUpdateTime;
        ProductId ProductId;
        UnderlyingSymbol UnderlyingSymbol;
        SecuritySymbol SecuritySymbol;
        ExpirationDate ExpirationDate;
        StrikePrice StrikePrice;
        CallOrPut CallOrPut;
        OpeningTime OpeningTime;
        ClosingTime ClosingTime;
        RestrictedOption RestrictedOption;
        LongTermOption LongTermOption;
        ActiveOnMiax ActiveOnMiax;
        MiaxBboPostingIncrementIndicator MiaxBboPostingIncrementIndicator;
        LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
        OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
        PriorityQuoteWidth PriorityQuoteWidth;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for System State Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemStateMessage {
        NotificationTime NotificationTime;
        ToMVersion ToMVersion;
        SessionId SessionId;
        SystemStatus SystemStatus;
    };


    /// <summary>
    ///  Struct for System Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemTimeMessage {
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for Top of Market Bid Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TopOfMarketBidCompactMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        MbboPrice2 MbboPrice2;
        MbboSize2 MbboSize2;
        MbboPriorityCustomerSize2 MbboPriorityCustomerSize2;
        MbboCondition MbboCondition;
    };


    /// <summary>
    ///  Struct for Top of Market Offer Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TopOfMarketOfferCompactMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        MbboPrice2 MbboPrice2;
        MbboSize2 MbboSize2;
        MbboPriorityCustomerSize2 MbboPriorityCustomerSize2;
        MbboCondition MbboCondition;
    };


    /// <summary>
    ///  Struct for Trade Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        TradeId TradeId;
        CorrectionNumber CorrectionNumber;
        TradePrice TradePrice;
        TradeSize TradeSize;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        TradeId TradeId;
        CorrectionNumber CorrectionNumber;
        ReferenceTradeId ReferenceTradeId;
        ReferenceCorrectionNumber ReferenceCorrectionNumber;
        TradePrice TradePrice;
        TradeSize TradeSize;
        TradeCondition TradeCondition;
    };


    /// <summary>
    ///  Struct for Underlying Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingTradingStatusMessage {
        Timestamp Timestamp;
        UnderlyingSymbol UnderlyingSymbol;
        TradingStatus TradingStatus;
        EventReason EventReason;
        SecondsPart SecondsPart;
        ExpectedEventTimeNanoSecondsPart ExpectedEventTimeNanoSecondsPart;
    };


    /// <summary>
    ///  Struct for Wide Double Sided Top of Market Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideDoubleSidedTopOfMarketMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        BidPriorityCustomerSize4 BidPriorityCustomerSize4;
        BidCondition BidCondition;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        OfferPriorityCustomerSize4 OfferPriorityCustomerSize4;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Wide Top of Market Bid Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideTopOfMarketBidMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        MbboPrice4 MbboPrice4;
        MbboSize4 MbboSize4;
        MbboPriorityCustomerSize4 MbboPriorityCustomerSize4;
        MbboCondition MbboCondition;
    };


    /// <summary>
    ///  Struct for Wide Top of Market Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideTopOfMarketOfferMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        MbboPrice4 MbboPrice4;
        MbboSize4 MbboSize4;
        MbboPriorityCustomerSize4 MbboPriorityCustomerSize4;
        MbboCondition MbboCondition;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
