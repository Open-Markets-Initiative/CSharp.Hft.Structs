namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Ask Price
    /// </summary>
    public unsafe struct AskPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Quote Condition Values
    /// </summary>
    public enum AskQuoteCondition : byte {
        Closing = (byte)'C',
        OpeningQuote = (byte)'O',
        RegularQuote = (byte)'R',
        SlowOnTheBidAndAsk = (byte)'W',
    };


    /// <summary>
    ///  Ask Volume
    /// </summary>
    public unsafe struct AskVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Begin Seq Num
    /// </summary>
    public unsafe struct BeginSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public unsafe struct BidPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Quote Condition Values
    /// </summary>
    public enum BidQuoteCondition : byte {
        Closing = (byte)'C',
        OpeningQuote = (byte)'O',
        RegularQuote = (byte)'R',
        SlowOnTheBidAndAsk = (byte)'W',
    };


    /// <summary>
    ///  Bid Volume
    /// </summary>
    public unsafe struct BidVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public unsafe struct ChannelId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Price
    /// </summary>
    public unsafe struct ClosingPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complete Values
    /// </summary>
    public enum Complete : byte {
        Normal = 0,
        Abnormal = 1,
    };


    /// <summary>
    ///  Current Refresh Pkt
    /// </summary>
    public unsafe struct CurrentRefreshPkt {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Delivery Flag Values
    /// </summary>
    public enum DeliveryFlag : byte {
        Heartbeat = 1,
        XdpFailover = 10,
        OriginalMessage = 11,
        SequenceNumberResetMessage = 12,
        OneRetransmissionPacket = 13,
        RetransmissionSequenceMessage = 15,
        OneRefreshPacket = 17,
        RefreshSequenceStart = 18,
        RefreshSequenceMessage = 19,
        RefreshSequenceEnd = 20,
        MessageUnavailable = 21,
    };


    /// <summary>
    ///  End Seq Num
    /// </summary>
    public unsafe struct EndSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exchange Code Values
    /// </summary>
    public enum ExchangeCode : byte {
        NyseAmerican = (byte)'A',
        GlobalOtc = (byte)'B',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        Otcbb = (byte)'U',
        OtherOtc = (byte)'V',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Halt Condition Values
    /// </summary>
    public enum HaltCondition : byte {
        SecurityNotDelayedhalted = (byte)'~',
        NotApplicable = (byte)' ',
        NewsDissemination = (byte)'D',
        OrderImbalance = (byte)'I',
        NewsPending = (byte)'P',
        VolatilityTradingPause = (byte)'M',
        EquipmentChangeover = (byte)'X',
        NoOpenNoResume = (byte)'Z',
        MarketWideCircuitBreakerHaltLevel1 = (byte)'1',
        MarketWideCircuitBreakerHaltLevel2 = (byte)'2',
        MarketWideCircuitBreakerHaltLevel3 = (byte)'3',
    };


    /// <summary>
    ///  High Price
    /// </summary>
    public unsafe struct HighPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Seq Num
    /// </summary>
    public unsafe struct LastSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Symbol Seq Num
    /// </summary>
    public unsafe struct LastSymbolSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lot Size
    /// </summary>
    public unsafe struct LotSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Low Price
    /// </summary>
    public unsafe struct LowPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseArcaOptions = 4,
        NyseBonds = 5,
        GlobalOtc = 6,
        NyseAmexOptions = 8,
        NyseAmerican = 9,
        NyseNational = 10,
    };


    /// <summary>
    ///  Market Id Of Best Ask Values
    /// </summary>
    public enum MarketIdOfBestAsk : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseAmerican = 9,
    };


    /// <summary>
    ///  Market Id Of Best Bid Values
    /// </summary>
    public enum MarketIdOfBestBid : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseAmerican = 9,
    };


    /// <summary>
    ///  Market Id Of High Price Values
    /// </summary>
    public enum MarketIdOfHighPrice : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseAmerican = 9,
    };


    /// <summary>
    ///  Market Id Of Low Price Values
    /// </summary>
    public enum MarketIdOfLowPrice : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseAmerican = 9,
    };


    /// <summary>
    ///  Market Id Of Open Price Values
    /// </summary>
    public enum MarketIdOfOpenPrice : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseAmerican = 9,
    };


    /// <summary>
    ///  Market ID of the Close Values
    /// </summary>
    public enum MarketIdOfTheClose : ushort {
        NyseGroupBqt = 0,
        Nyse = 1,
        NyseArca = 3,
        NyseAmerican = 9,
    };


    /// <summary>
    ///  Market State Values
    /// </summary>
    public enum MarketState : byte {
        Preopening = (byte)'P',
        EarlySession = (byte)'E',
        CoreSession = (byte)'O',
        LateSession = (byte)'L',
        Closed = (byte)'X',
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Message Type Values
    /// </summary>
    public enum MessageType : ushort {
        SequenceNumberResetMessage = 1,
        SymbolIndexMappingMessage = 3,
        RetransmissionRequestMessage = 10,
        RequestResponseMessage = 11,
        HeartbeatResponseMessage = 12,
        SymbolIndexMappingRequestMessage = 13,
        RefreshRequestMessage = 15,
        MessageUnavailableMessage = 31,
        ConsolidatedSymbolClearMessage = 32,
        ConsolidatedTradingSessionChangeMessage = 33,
        ConsolidatedSecurityStatusMessage = 34,
        RefreshHeaderMessage = 35,
        BqtMessage = 142,
        ConsolidatedSingleSidedQuoteMessage = 143,
        ConsolidatedTradeMessage = 220,
        ConsolidatedTradeCancelMessage = 221,
        ConsolidatedTradeCorrectionMessage = 222,
        ConsolidatedStockSummaryMessage = 229,
        ConsolidatedVolumeMessage = 240,
    };


    /// <summary>
    ///  Mpv
    /// </summary>
    public unsafe struct Mpv {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public unsafe struct Nanoseconds {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Next Source Seq Num
    /// </summary>
    public unsafe struct NextSourceSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Close Prices
    /// </summary>
    public unsafe struct NumberOfClosePrices {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ok for late hours
    /// </summary>
    public unsafe struct OkForLateHours {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Ok for morning hours
    /// </summary>
    public unsafe struct OkForMorningHours {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Ok for national hours
    /// </summary>
    public unsafe struct OkForNationalHours {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Open
    /// </summary>
    public unsafe struct Open {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Id
    /// </summary>
    public unsafe struct OriginalTradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public unsafe struct PacketSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Prev Close Price
    /// </summary>
    public unsafe struct PrevClosePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Prev Close Volume
    /// </summary>
    public unsafe struct PrevCloseVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price 1
    /// </summary>
    public unsafe struct Price1 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price 2
    /// </summary>
    public unsafe struct Price2 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Resolution Values
    /// </summary>
    public enum PriceResolution : byte {
        AllPenny = 0,
        PennyNickel = 1,
        NickelDime = 5,
    };


    /// <summary>
    ///  Price Scale Code
    /// </summary>
    public unsafe struct PriceScaleCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public unsafe struct ProductId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        Closing = (byte)'C',
        OpeningQuote = (byte)'O',
        RegularQuote = (byte)'R',
        SlowOnTheBidAndAsk = (byte)'W',
        EmptyQuote = (byte)'OxOO',
    };


    /// <summary>
    ///  Reason Values
    /// </summary>
    public enum Reason : byte {
        NewTrade = 0,
        TradeCancellation = 1,
        TradeError = 2,
        TradeCorrection = 3,
        ClosingEndTradeSummary = 4,
    };


    /// <summary>
    ///  Request Seq Num
    /// </summary>
    public unsafe struct RequestSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 2
    /// </summary>
    public unsafe struct Reserved2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Retail Pricing Indicator Values
    /// </summary>
    public enum RetailPricingIndicator : byte {
        NoRetailInterest = 0x00,
        RetailInterestOnTheBidSide = 0x01,
        RetailInterestOnTheAskSide = 0x02,
        CombinationOfRetailInterestOnBidAndAskSide = 0x04,
    };


    /// <summary>
    ///  Retransmit Method Values
    /// </summary>
    public enum RetransmitMethod : byte {
        Udp = 0,
    };


    /// <summary>
    ///  Round Lot Values
    /// </summary>
    public enum RoundLot : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Rpi Indicator Values
    /// </summary>
    public enum RpiIndicator : byte {
        NoRetailInterest = (byte)' ',
        InterestOnBid = (byte)'A',
        InterestOnOffer = (byte)'B',
        InterestOnBidAndOffer = (byte)'C',
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        OpeningDelay = (byte)'3',
        TradingHalt = (byte)'4',
        Resume = (byte)'5',
        NoOpennoResume = (byte)'6',
        ShortSaleRestrictionActivatedDay1 = (byte)'A',
        ShortSaleRestrictionContinuedDay2 = (byte)'C',
        ShortSaleRestrictionDeactivated = (byte)'D',
        Preopening = (byte)'P',
        EarlySession = (byte)'E',
        CoreSession = (byte)'O',
        LateSessionNonNyseOnly = (byte)'L',
        Closed = (byte)'X',
        Time = (byte)'T',
        PriceIndication = (byte)'I',
        PreOpeningPriceIndication = (byte)'G',
        Rule15Indication = (byte)'R',
    };


    /// <summary>
    ///  Security Type Values
    /// </summary>
    public enum SecurityType : byte {
        Adr = (byte)'A',
        CommonStock = (byte)'C',
        Debentures = (byte)'D',
        Etf = (byte)'E',
        Foreign = (byte)'F',
        UsDepositaryShares = (byte)'H',
        Units = (byte)'I',
        IndexLinkedNotes = (byte)'L',
        MiscliquidTrust = (byte)'M',
        OrdinaryShares = (byte)'O',
        PreferredStock = (byte)'P',
        Rights = (byte)'R',
        SharesOfBeneficiaryInterest = (byte)'S',
        Test = (byte)'T',
        Units = (byte)'U',
        Warrant = (byte)'W',
    };


    /// <summary>
    ///  Sequence Number
    /// </summary>
    public unsafe struct SequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session State Values
    /// </summary>
    public enum SessionState : byte {
        EarlySessionState = (byte)'X',
        CoreSessionState = (byte)'Y',
        LateSessionState = (byte)'Z',
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Source Id
    /// </summary>
    public unsafe struct SourceId {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Time
    /// </summary>
    public unsafe struct SourceTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Time Ns
    /// </summary>
    public unsafe struct SourceTimeNs {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ssr State Values
    /// </summary>
    public enum SsrState : byte {
        NoShortSaleRestrictionInEffect = (byte)'~',
        ShortSaleRestrictionInEffect = (byte)'E',
    };


    /// <summary>
    ///  Ssr Triggering Exchange Id Values
    /// </summary>
    public enum SsrTriggeringExchangeId : byte {
        NyseAmerican = (byte)'A',
        NasdaqOmxBx = (byte)'B',
        NyseNational = (byte)'C',
        Finra = (byte)'D',
        Ise = (byte)'I',
        Edga = (byte)'J',
        Edgx = (byte)'K',
        Chx = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        Cts = (byte)'S',
        NasdaqOmx = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqOmxPsx = (byte)'X',
        BatsY = (byte)'Y',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Ssr Triggering Volume
    /// </summary>
    public unsafe struct SsrTriggeringVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Status Values
    /// </summary>
    public enum Status : byte {
        MessageWasAccepted = (byte)'0',
        RejectedDueToAnInvalidSourceId = (byte)'1',
        InvalidSequenceRange = (byte)'2',
        MaximumSequenceRange = (byte)'3',
        MaximumRequestInADay = (byte)'4',
        MaximumRefreshRequestsInADay = (byte)'5',
        OldSeqNumTtl = (byte)'6',
        InvalidChannelId = (byte)'7',
        InvalidProductId = (byte)'8',
        InvalidMsgTypeOrMismatchBetweenMsgTypeAndMsgSize = (byte)'9',
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Index
    /// </summary>
    public unsafe struct SymbolIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Seq Num
    /// </summary>
    public unsafe struct SymbolSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Seq Number
    /// </summary>
    public unsafe struct SymbolSeqNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Id
    /// </summary>
    public unsafe struct SystemId {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Refresh Pkts
    /// </summary>
    public unsafe struct TotalRefreshPkts {
        public const int Size = 2;

        public short Value;

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
    ///  Trade Condition 1 Values
    /// </summary>
    public enum TradeCondition1 : byte {
        RegularSale = (byte)'@',
        Cash = (byte)'C',
        NextDayTrade = (byte)'N',
        Seller = (byte)'R',
    };


    /// <summary>
    ///  Trade Condition 2 Values
    /// </summary>
    public enum TradeCondition2 : byte {
        Na = (byte)' ',
        IntermarketSweepOrder = (byte)'F',
        MarketCenterOpeningTrade = (byte)'O',
        DerivativelyPriced = (byte)'4',
        MarketCenterReopeningTrade = (byte)'5',
        MarketCenterClosingTrade = (byte)'6',
        CorrectedLastSalePrice = (byte)'9',
    };


    /// <summary>
    ///  Trade Condition 3 Values
    /// </summary>
    public enum TradeCondition3 : byte {
        Na = (byte)' ',
        SoldLast = (byte)'L',
        ExtendedHoursTrade = (byte)'T',
        ExtendedHoursSoldOutOfSequence = (byte)'U',
        Sold = (byte)'Z',
    };


    /// <summary>
    ///  Trade Condition 4 Values
    /// </summary>
    public enum TradeCondition4 : byte {
        Na = (byte)' ',
        RegularSale = (byte)'@',
        AveragePriceTrade = (byte)'B',
        AutomaticExecution = (byte)'E',
        PriceVariationTrade = (byte)'H',
        OddLotTrade = (byte)'I',
        Rule127NyseOnlyOrRule155NyseAmericanOnly = (byte)'K',
        OfficialClosingPrice = (byte)'M',
        PriorReferencePrice = (byte)'P',
        OfficialOpenPrice = (byte)'Q',
        StockOptionTrade = (byte)'V',
        CrossTrade = (byte)'X',
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
    ///  Trade Session
    /// </summary>
    public unsafe struct TradeSession {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Trade
    /// </summary>
    public unsafe struct UnitOfTrade {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Volume
    /// </summary>
    public unsafe struct Volume {
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
    ///  Struct for Bqt Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BqtMessage {
        SymbolIndex SymbolIndex;
        SymbolSeqNumber SymbolSeqNumber;
        AskPrice AskPrice;
        AskVolume AskVolume;
        BidPrice BidPrice;
        BidVolume BidVolume;
        AskQuoteCondition AskQuoteCondition;
        BidQuoteCondition BidQuoteCondition;
        RetailPricingIndicator RetailPricingIndicator;
        MarketIdOfBestAsk MarketIdOfBestAsk;
        MarketIdOfBestBid MarketIdOfBestBid;
    };


    /// <summary>
    ///  Struct for Close Price
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClosePrice {
        MarketIdOfTheClose MarketIdOfTheClose;
        ClosingPrice ClosingPrice;
    };


    /// <summary>
    ///  Struct for Consolidated Security Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedSecurityStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        MarketId MarketId;
        Reserved2 Reserved2;
        Price1 Price1;
        Price2 Price2;
        SsrTriggeringExchangeId SsrTriggeringExchangeId;
        SsrTriggeringVolume SsrTriggeringVolume;
        Time Time;
        SsrState SsrState;
        MarketState MarketState;
        SessionState SessionState;
    };


    /// <summary>
    ///  Struct for Consolidated Single Sided Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedSingleSidedQuoteMessage {
        SymbolIndex SymbolIndex;
        SymbolSeqNumber SymbolSeqNumber;
        Side Side;
        Price Price;
        Volume Volume;
        QuoteCondition QuoteCondition;
        RpiIndicator RpiIndicator;
        MarketId MarketId;
    };


    /// <summary>
    ///  Struct for Consolidated Stock Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedStockSummaryMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        HighPrice HighPrice;
        LowPrice LowPrice;
        Open Open;
        TotalVolume TotalVolume;
        MarketIdOfHighPrice MarketIdOfHighPrice;
        MarketIdOfLowPrice MarketIdOfLowPrice;
        MarketIdOfOpenPrice MarketIdOfOpenPrice;
        NumberOfClosePrices NumberOfClosePrices;
    };


    /// <summary>
    ///  Struct for Consolidated Symbol Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedSymbolClearMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        NextSourceSeqNum NextSourceSeqNum;
        MarketId MarketId;
    };


    /// <summary>
    ///  Struct for Consolidated Trade Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedTradeCancelMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNumber SymbolSeqNumber;
        TradeId TradeId;
        MarketId MarketId;
    };


    /// <summary>
    ///  Struct for Consolidated Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedTradeCorrectionMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNumber SymbolSeqNumber;
        OriginalTradeId OriginalTradeId;
        TradeId TradeId;
        Price Price;
        Volume Volume;
        TradeCondition1 TradeCondition1;
        TradeCondition2 TradeCondition2;
        TradeCondition3 TradeCondition3;
        TradeCondition4 TradeCondition4;
        MarketId MarketId;
    };


    /// <summary>
    ///  Struct for Consolidated Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedTradeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeId TradeId;
        Price Price;
        Volume Volume;
        TradeCondition1 TradeCondition1;
        TradeCondition2 TradeCondition2;
        TradeCondition3 TradeCondition3;
        TradeCondition4 TradeCondition4;
        MarketId MarketId;
    };


    /// <summary>
    ///  Struct for Consolidated Trading Session Change Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedTradingSessionChangeMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeSession TradeSession;
        MarketId MarketId;
    };


    /// <summary>
    ///  Struct for Consolidated Volume Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ConsolidatedVolumeMessage {
        SymbolIndex SymbolIndex;
        SymbolSeqNumber SymbolSeqNumber;
        TotalVolume TotalVolume;
        Reason Reason;
        Complete Complete;
    };


    /// <summary>
    ///  Struct for Heartbeat Response Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HeartbeatResponseMessage {
        SourceId SourceId;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        MessageSize MessageSize;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Message Unavailable Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageUnavailableMessage {
        BeginSeqNum BeginSeqNum;
        EndSeqNum EndSeqNum;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        PacketSize PacketSize;
        DeliveryFlag DeliveryFlag;
        MessageCount MessageCount;
        SequenceNumber SequenceNumber;
        Timestamp Timestamp;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Refresh Header Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshHeaderMessage {
        CurrentRefreshPkt CurrentRefreshPkt;
        TotalRefreshPkts TotalRefreshPkts;
        LastSeqNum LastSeqNum;
        LastSymbolSeqNum LastSymbolSeqNum;
    };


    /// <summary>
    ///  Struct for Refresh Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshRequestMessage {
        SymbolIndex SymbolIndex;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Request Response Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestResponseMessage {
        RequestSeqNum RequestSeqNum;
        BeginSeqNum BeginSeqNum;
        EndSeqNum EndSeqNum;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
        Status Status;
    };


    /// <summary>
    ///  Struct for Retransmission Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetransmissionRequestMessage {
        BeginSeqNum BeginSeqNum;
        EndSeqNum EndSeqNum;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Sequence Number Reset Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequenceNumberResetMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        ProductId ProductId;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Symbol Index Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolIndexMappingMessage {
        SymbolIndex SymbolIndex;
        Symbol Symbol;
        Reserved1 Reserved1;
        MarketId MarketId;
        SystemId SystemId;
        ExchangeCode ExchangeCode;
        PriceScaleCode PriceScaleCode;
        SecurityType SecurityType;
        LotSize LotSize;
        PrevClosePrice PrevClosePrice;
        PrevCloseVolume PrevCloseVolume;
        PriceResolution PriceResolution;
        RoundLot RoundLot;
        Mpv Mpv;
        UnitOfTrade UnitOfTrade;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Symbol Index Mapping Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolIndexMappingRequestMessage {
        SymbolIndex SymbolIndex;
        SourceId SourceId;
        ProductId ProductId;
        ChannelId ChannelId;
        RetransmitMethod RetransmitMethod;
    };


    /// <summary>
    ///  Struct for Trade Session
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeSession {
        Reserved Reserved;
        OkForLateHours OkForLateHours;
        OkForNationalHours OkForNationalHours;
        OkForMorningHours OkForMorningHours;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
