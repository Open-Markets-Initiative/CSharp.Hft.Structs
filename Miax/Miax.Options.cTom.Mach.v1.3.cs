namespace Miax.Options.cTom.Mach.v1.3 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Active On Miax Values
    /// </summary>
    public enum ActiveOnMiax : byte {
        Active = (byte)'A',
        Inactive = (byte)'I',
    };


    /// <summary>
    ///  Bid Condition Values
    /// </summary>
    public enum BidCondition : byte {
        Regular = (byte)'A',
        TradingHalt = (byte)'T',
        Wide = (byte)'W',
        SimpleAuction = (byte)'S',
        ComplexAuction = (byte)'C',
        SimpleMarketProtection = (byte)'M',
        LegMarketProtection = (byte)'L',
    };


    /// <summary>
    ///  Bid Price 2
    /// </summary>
    public struct BidPrice2 {
        public short Raw;
    };


    /// <summary>
    ///  Bid Price 8
    /// </summary>
    public struct BidPrice8 {
        public long Raw;
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
    ///  Event Reason Values
    /// </summary>
    public enum EventReason : byte {
        Automatic = (byte)'A',
        Manual = (byte)'M',
    };


    /// <summary>
    ///  Expected Event Time Nano Seconds
    /// </summary>
    public unsafe struct ExpectedEventTimeNanoSeconds {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expected Event Time Seconds
    /// </summary>
    public unsafe struct ExpectedEventTimeSeconds {
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
    ///  Leg Ratio Qty
    /// </summary>
    public unsafe struct LegRatioQty {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : ulong {
        Bid = B,
        Ask = A,
    };


    /// <summary>
    ///  Liquidity Acceptance Increment Indicator Values
    /// </summary>
    public enum LiquidityAcceptanceIncrementIndicator : byte {
        Penny = (byte)'P',
        PennyOrNickel = (byte)'N',
        NickelOrDime = (byte)'D',
    };


    /// <summary>
    ///  Long Term Option Values
    /// </summary>
    public enum LongTermOption : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemTimeMessage = (byte)'1',
        SimpleSeriesUpdateMessage = (byte)'P',
        ComplexStrategyDefinitionMessage = (byte)'C',
        SystemStateMessage = (byte)'S',
        ComplexTopOfMarketBidCompactMessage = (byte)'b',
        ComplexTopOfMarketOfferCompactMessage = (byte)'o',
        ComplexTopOfMarketBidWideMessage = (byte)'e',
        ComplexTopOfMarketOfferWideMessage = (byte)'f',
        ComplexDoubleSidedTopOfMarketCompactMessage = (byte)'m',
        ComplexDoubleSidedTopOfMarketWideMessage = (byte)'w',
        StrategyLastSaleMessage = (byte)'t',
        UnderlyingTradingStatusNotificationMessage = (byte)'H',
    };


    /// <summary>
    ///  Miax Bbo Posting Increment Indicator Values
    /// </summary>
    public enum MiaxBboPostingIncrementIndicator : byte {
        Penny = (byte)'P',
        PennyOrNickel = (byte)'N',
        NickelOrDime = (byte)'D',
    };


    /// <summary>
    ///  Net Price
    /// </summary>
    public struct NetPrice {
        public long Raw;
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
    ///  Number Of Legs
    /// </summary>
    public unsafe struct NumberOfLegs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Condition Values
    /// </summary>
    public enum OfferCondition : byte {
        Regular = (byte)'A',
        TradingHalt = (byte)'T',
        Wide = (byte)'W',
        SimpleAuction = (byte)'S',
        ComplexAuction = (byte)'C',
        SimpleMarketProtection = (byte)'M',
        LegMarketProtection = (byte)'L',
    };


    /// <summary>
    ///  Offer Price 2
    /// </summary>
    public struct OfferPrice2 {
        public short Raw;
    };


    /// <summary>
    ///  Offer Price 8
    /// </summary>
    public struct OfferPrice8 {
        public long Raw;
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
    ///  Price 2
    /// </summary>
    public struct Price2 {
        public short Raw;
    };


    /// <summary>
    ///  Price 8
    /// </summary>
    public struct Price8 {
        public long Raw;
    };


    /// <summary>
    ///  Priority Customer Size 2
    /// </summary>
    public unsafe struct PriorityCustomerSize2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Priority Customer Size 4
    /// </summary>
    public unsafe struct PriorityCustomerSize4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 10
    /// </summary>
    public unsafe struct Reserved10 {
        public const int Size = 10;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 16
    /// </summary>
    public unsafe struct Reserved16 {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 8
    /// </summary>
    public unsafe struct Reserved8 {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved8
    /// </summary>
    public unsafe struct Reserved8 {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Restricted Option Values
    /// </summary>
    public enum RestrictedOption : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
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
    ///  Size 2
    /// </summary>
    public unsafe struct Size2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Size 4
    /// </summary>
    public unsafe struct Size4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Add Time
    /// </summary>
    public unsafe struct StrategyAddTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Id
    /// </summary>
    public unsafe struct StrategyId {
        public const int Size = 4;

        public int Value;

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
    ///  Top Of Market Quote Condition Values
    /// </summary>
    public enum TopOfMarketQuoteCondition : byte {
        Regular = (byte)'A',
        TradingHalt = (byte)'T',
        Wide = (byte)'W',
        SimpleAuction = (byte)'S',
        ComplexAuction = (byte)'C',
        SimpleMarketProtection = (byte)'M',
        LegMarketProtection = (byte)'L',
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        Matched = (byte)'S',
        Legged = (byte)'L',
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


    /// <summary>
    ///  Update Reason Values
    /// </summary>
    public enum UpdateReason : byte {
        NewStrategyCreated = (byte)'N',
        Updated = (byte)'U',
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 8;

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
    ///  Struct for Complex Double Sided Top Of Market Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexDoubleSidedTopOfMarketCompactMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
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
    ///  Struct for Complex Double Sided Top Of Market Wide Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexDoubleSidedTopOfMarketWideMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        BidPrice8 BidPrice8;
        BidSize4 BidSize4;
        BidPriorityCustomerSize4 BidPriorityCustomerSize4;
        BidCondition BidCondition;
        OfferPrice8 OfferPrice8;
        OfferSize4 OfferSize4;
        OfferPriorityCustomerSize4 OfferPriorityCustomerSize4;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Complex Strategy Definition Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyDefinitionMessage {
        StrategyAddTime StrategyAddTime;
        StrategyId StrategyId;
        UnderlyingSymbol UnderlyingSymbol;
        ActiveOnMiax ActiveOnMiax;
        Reserved1 Reserved1;
        UpdateReason UpdateReason;
        Reserved10 Reserved10;
        NumberOfLegs NumberOfLegs;
        LegDefinition LegDefinition;
    };


    /// <summary>
    ///  Struct for Complex Top Of Market Bid Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTopOfMarketBidCompactMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        Price2 Price2;
        Size2 Size2;
        PriorityCustomerSize2 PriorityCustomerSize2;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Complex Top Of Market Bid Wide Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTopOfMarketBidWideMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        Price8 Price8;
        Size4 Size4;
        PriorityCustomerSize4 PriorityCustomerSize4;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Complex Top Of Market Offer Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTopOfMarketOfferCompactMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        Price2 Price2;
        Size2 Size2;
        PriorityCustomerSize2 PriorityCustomerSize2;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Complex Top Of Market Offer Wide Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTopOfMarketOfferWideMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        Price8 Price8;
        Size4 Size4;
        PriorityCustomerSize4 PriorityCustomerSize4;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Leg Definition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegDefinition {
        ProductId ProductId;
        LegRatioQty LegRatioQty;
        LegSide LegSide;
        Reserved8 Reserved8;
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
    ///  Struct for Simple Series Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SimpleSeriesUpdateMessage {
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
        Reserved8 Reserved8;
    };


    /// <summary>
    ///  Struct for Strategy Last Sale Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyLastSaleMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        TradeId TradeId;
        NetPrice NetPrice;
        TradeSize TradeSize;
        TradeCondition TradeCondition;
        Reserved16 Reserved16;
    };


    /// <summary>
    ///  Struct for System State Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemStateMessage {
        NotificationTime NotificationTime;
        Version Version;
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
    ///  Struct for Underlying Trading Status Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingTradingStatusNotificationMessage {
        Timestamp Timestamp;
        UnderlyingSymbol UnderlyingSymbol;
        TradingStatus TradingStatus;
        EventReason EventReason;
        ExpectedEventTimeSeconds ExpectedEventTimeSeconds;
        ExpectedEventTimeNanoSeconds ExpectedEventTimeNanoSeconds;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
