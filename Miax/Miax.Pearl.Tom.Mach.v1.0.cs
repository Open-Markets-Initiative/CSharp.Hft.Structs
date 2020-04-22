namespace Miax.Pearl.Tom.Mach.v1.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Active On Pearl Values
    /// </summary>
    public enum ActiveOnPearl : byte {
        ActiveTradable = (byte)'A',
        InactiveNotTradable = (byte)'I',
    };


    /// <summary>
    ///  Bid Condition Values
    /// </summary>
    public enum BidCondition : byte {
        Regular = (byte)'A',
        QuoteContainsPublicCustomerInterest = (byte)'B',
        QuoteIsNotFirm = (byte)'C',
        ReservedForFutureUse = (byte)'R',
        TradingHalt = (byte)'T',
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public unsafe struct BidPrice {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Priority Customer Size
    /// </summary>
    public unsafe struct BidPriorityCustomerSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Call Or Put Values
    /// </summary>
    public enum CallOrPut : byte {
        Call = (byte)'C',
        Put = (byte)'P',
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
        ResultedFromAutomaticmarketDrivenEvent = (byte)'A',
        ManuallyInitiated = (byte)'M',
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
    ///  Expected Event Time Seconds Part
    /// </summary>
    public unsafe struct ExpectedEventTimeSecondsPart {
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
        Penny001 = (byte)'P',
        Penny001 = (byte)'N',
        Nickel005 = (byte)'D',
    };


    /// <summary>
    ///  Long Term Option Values
    /// </summary>
    public enum LongTermOption : byte {
        FarMonth = (byte)'“Y',
        NearMonth = (byte)'N',
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        PearlSystemTimeMessage = (byte)'1',
        SeriesUpdateMessage = (byte)'P',
        SystemStateMessage = (byte)'S',
        CompactTopOfMarketBidMessage = (byte)'B',
        CompactTopOfMarketBestOfferMessage = (byte)'O',
        WideTopOfMarketBestBidMessage = (byte)'W',
        WideTopOfMarketBestOfferMessage = (byte)'A',
        CompactDoubleSidedTopOfMarketMessage = (byte)'d',
        WideDoubleSidedTopOfMarketMessage = (byte)'D',
        LastSaleMessage = (byte)'T',
        TradeCancelMessage = (byte)'X',
        UnderlyingTradingStatusNotification = (byte)'H',
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
        QuoteContainsPublicCustomerInterest = (byte)'B',
        QuoteIsNotFirm = (byte)'C',
        ReservedForFutureUse = (byte)'R',
        TradingHalt = (byte)'T',
        CancelOfTrade = (byte)'A',
        TradeThatIsLateAndIsOutOfSequence = (byte)'B',
        CancelOfTheLastReportedTrade = (byte)'C',
        TradeThatIsLateAndIsInCorrectSequence = (byte)'D',
        CancelOfTheFirstOpeningReportedTrade = (byte)'E',
        TradeThatIsLateReportOfTheOpeningTradeAndIsOutOfSequence = (byte)'F',
        CancelOfTheOnlyReportedTrade = (byte)'G',
        TradeThatIsLateReportOfTheOpeningTradeAndIsInCorrectSequence = (byte)'H',
        ReservedForFutureUse = (byte)'I',
        TradeDueToReopeningOfAnOptionInWhichTradingHasBeenPreviouslyHalted = (byte)'J',
        ReservedForFutureUse = (byte)'K',
        ReservedForFutureUse = (byte)'L',
        ReservedForFutureUse = (byte)'M',
        ReservedForFutureUse = (byte)'N',
        ReservedForFutureUse = (byte)'O',
        ReservedForFutureUse = (byte)'P',
        ReservedForFutureUse = (byte)'Q',
        TradeWasTheExecutionOfAnOrderWhichWasStoppedAtAPriceThatDidNotConstituteATradeThroughOnAnotherMarketAtTheTimeOfTheStop = (byte)'R',
        TradeWasTheExecutionOfAnOrderIdentified = (byte)'S',
        ReservedForFutureUse = (byte)'T',
        TradeThatIsTradeThroughExempt = (byte)'X',
    };


    /// <summary>
    ///  Offer Price
    /// </summary>
    public unsafe struct OfferPrice {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Priority Customer Size
    /// </summary>
    public unsafe struct OfferPriorityCustomerSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size
    /// </summary>
    public unsafe struct OfferSize {
        public const int Size = 2;

        public short Value;

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
        NationalStock = (byte)'C',
        FinraAdf = (byte)'D',
        MarketIndependent = (byte)'E',
        InternationalSecurities = (byte)'I',
        EdgaExchange = (byte)'J',
        EdgxExchange = (byte)'K',
        ChicagoStock = (byte)'M',
        NyseEuronext = (byte)'N',
        NyseArca = (byte)'P',
        NasdaqOmx = (byte)'Q',
        NasdaqOmx = (byte)'T',
        Iex = (byte)'V',
        NasdaqOmxPhlx = (byte)'X',
        BatsYExchange = (byte)'Y',
        BatsExchange = (byte)'Z',
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
    ///  Pbbo Condition Values
    /// </summary>
    public enum PbboCondition : byte {
        Regular = (byte)'A',
        QuoteContainsPublicCustomerInterest = (byte)'B',
        QuoteIsNotFirm = (byte)'C',
        ReservedForFutureUse = (byte)'R',
        TradingHalt = (byte)'T',
    };


    /// <summary>
    ///  Pbbo Price
    /// </summary>
    public unsafe struct PbboPrice {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pbbo Priority Customer Size
    /// </summary>
    public unsafe struct PbboPriorityCustomerSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pbbo Size
    /// </summary>
    public unsafe struct PbboSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pearl Bbo Posting Increment Indicator Values
    /// </summary>
    public enum PearlBboPostingIncrementIndicator : byte {
        Penny001 = (byte)'P',
        Penny001 = (byte)'N',
        Nickel005 = (byte)'D',
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
        public const int Size = 12;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Restricted Option Values
    /// </summary>
    public enum RestrictedOption : byte {
        PositionClosingOrdersOnly = (byte)'Y',
        OpenAndClosePositions = (byte)'N',
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
        Start = (byte)'S',
        End = (byte)'C',
        Start = (byte)'1',
        End = (byte)'2',
    };


    /// <summary>
    ///  Time Stamp
    /// </summary>
    public unsafe struct TimeStamp {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Trade Condition
    /// </summary>
    public unsafe struct TradeCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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
    ///  Trading Status
    /// </summary>
    public unsafe struct TradingStatus {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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


    /// <summary>
    ///  Wide Bid Price
    /// </summary>
    public unsafe struct WideBidPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Bid Priority Customer Size
    /// </summary>
    public unsafe struct WideBidPriorityCustomerSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Bid Size
    /// </summary>
    public unsafe struct WideBidSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Offer Price
    /// </summary>
    public unsafe struct WideOfferPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Offer Priority Customer Size
    /// </summary>
    public unsafe struct WideOfferPriorityCustomerSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Offer Size
    /// </summary>
    public unsafe struct WideOfferSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Pbbo Price
    /// </summary>
    public unsafe struct WidePbboPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Pbbo Priority Customer Size
    /// </summary>
    public unsafe struct WidePbboPriorityCustomerSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Pbbo Size
    /// </summary>
    public unsafe struct WidePbboSize {
        public const int Size = 4;

        public int Value;

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
    ///  Struct for Compact Double Sided Top Of Market Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CompactDoubleSidedTopOfMarketMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        BidPrice BidPrice;
        BidSize BidSize;
        BidPriorityCustomerSize BidPriorityCustomerSize;
        BidCondition BidCondition;
        OfferPrice OfferPrice;
        OfferSize OfferSize;
        OfferPriorityCustomerSize OfferPriorityCustomerSize;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Compact Top Of Market Best Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CompactTopOfMarketBestOfferMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        PbboPrice PbboPrice;
        PbboSize PbboSize;
        PbboPriorityCustomerSize PbboPriorityCustomerSize;
        PbboCondition PbboCondition;
    };


    /// <summary>
    ///  Struct for Compact Top Of Market Bid Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CompactTopOfMarketBidMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        PbboPrice PbboPrice;
        PbboSize PbboSize;
        PbboPriorityCustomerSize PbboPriorityCustomerSize;
        PbboCondition PbboCondition;
    };


    /// <summary>
    ///  Struct for Last Sale Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LastSaleMessage {
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
    ///  Struct for Pearl System Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PearlSystemTimeMessage {
        TimeStamp TimeStamp;
    };


    /// <summary>
    ///  Struct for Series Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SeriesUpdateMessage {
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
        ActiveOnPearl ActiveOnPearl;
        PearlBboPostingIncrementIndicator PearlBboPostingIncrementIndicator;
        LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
        OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
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
    ///  Struct for Underlying Trading Status Notification
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingTradingStatusNotification {
        Timestamp Timestamp;
        UnderlyingSymbol UnderlyingSymbol;
        TradingStatus TradingStatus;
        EventReason EventReason;
        ExpectedEventTimeSecondsPart ExpectedEventTimeSecondsPart;
        ExpectedEventTimeNanoSecondsPart ExpectedEventTimeNanoSecondsPart;
    };


    /// <summary>
    ///  Struct for Wide Double Sided Top Of Market Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideDoubleSidedTopOfMarketMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        WideBidPrice WideBidPrice;
        WideBidSize WideBidSize;
        WideBidPriorityCustomerSize WideBidPriorityCustomerSize;
        BidCondition BidCondition;
        WideOfferPrice WideOfferPrice;
        WideOfferSize WideOfferSize;
        WideOfferPriorityCustomerSize WideOfferPriorityCustomerSize;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Wide Top Of Market Best Bid Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideTopOfMarketBestBidMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        WidePbboPrice WidePbboPrice;
        WidePbboSize WidePbboSize;
        WidePbboPriorityCustomerSize WidePbboPriorityCustomerSize;
        PbboCondition PbboCondition;
    };


    /// <summary>
    ///  Struct for Wide Top Of Market Best Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideTopOfMarketBestOfferMessage {
        Timestamp Timestamp;
        ProductId ProductId;
        WidePbboPrice WidePbboPrice;
        WidePbboSize WidePbboSize;
        WidePbboPriorityCustomerSize WidePbboPriorityCustomerSize;
        PbboCondition PbboCondition;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
