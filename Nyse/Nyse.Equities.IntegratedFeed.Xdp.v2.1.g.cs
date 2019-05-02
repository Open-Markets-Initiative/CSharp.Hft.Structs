namespace Nyse.Equities.IntegratedFeed.Xdp.v2.1.g {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction Status Values
    /// </summary>
    public enum AuctionStatus : byte {
        WillRunOpenClose = 0,
        WillRunInterest = 1,
        WillNotRunImbalance = 2,
        WillNotRunTransitionToClosing = 3,
    };


    /// <summary>
    ///  Auction Time
    /// </summary>
    public unsafe struct AuctionTime {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        EarlyOpening = (byte)'O',
        CoreOpening = (byte)'M',
        Reopening = (byte)'H',
        Closing = (byte)'C',
        RegulatoryImbalance = (byte)'R',
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
    ///  Channel Id
    /// </summary>
    public unsafe struct ChannelId {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Close
    /// </summary>
    public unsafe struct Close {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Only Clearing Price
    /// </summary>
    public unsafe struct ClosingOnlyClearingPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Continuous Book Clearing Price
    /// </summary>
    public unsafe struct ContinuousBookClearingPrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Id
    /// </summary>
    public unsafe struct CrossId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        EarlyOpening = (byte)'E',
        Opening = (byte)'O',
        Reopening = (byte)'5',
        Closing = (byte)'6',
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
    ///  Db Exec Id
    /// </summary>
    public unsafe struct DbExecId {
        public const int Size = 4;

        public int Value;

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
        NyseNational = (byte)'C',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        Iex = (byte)'V',
        Bats = (byte)'Z',
        GlobalOtc = (byte)'B',
        Otcbb = (byte)'U',
        OtherOtc = (byte)'V',
    };


    /// <summary>
    ///  Firm Id
    /// </summary>
    public unsafe struct FirmId {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Freeze Status Values
    /// </summary>
    public enum FreezeStatus : byte {
        NoImbalanceFreeze = 0,
        ImbalanceFreeze = 1,
    };


    /// <summary>
    ///  Halt Condition Values
    /// </summary>
    public enum HaltCondition : byte {
        SecurityNotDelayedhalted = (byte)'~',
        NotDelayedhaltedNyseTapeAOnly = (byte)' ',
        NewsDissemination = (byte)'D',
        OrderImbalance = (byte)'I',
        NewsPending = (byte)'P',
        LuldPause = (byte)'M',
        RelatedSecurityNotUsed = (byte)'S',
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
    ///  Id
    /// </summary>
    public unsafe struct Id {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Imbalance Side Values
    /// </summary>
    public enum ImbalanceSide : byte {
        NoImbalance = (byte)' ',
        BuySide = (byte)'B',
        SellSide = (byte)'S',
    };


    /// <summary>
    ///  Indicative Match Price
    /// </summary>
    public unsafe struct IndicativeMatchPrice {
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
    ///  Lower Collar
    /// </summary>
    public unsafe struct LowerCollar {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        NyseEquities = 1,
        NyseArcaEquities = 3,
        NyseArcaOptions = 4,
        NyseBonds = 5,
        GlobalOtc = 6,
        NyseAmexOptions = 8,
        NyseAmericanEquities = 9,
        NyseNationalEquities = 10,
    };


    /// <summary>
    ///  Market Imbalance Qty
    /// </summary>
    public unsafe struct MarketImbalanceQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
        SourceTimeReferenceMessage = 2,
        SymbolIndexMappingMessage = 3,
        RetransmissionRequestMessage = 10,
        RequestResponseMessage = 11,
        HeartbeatResponseMessage = 12,
        SymbolIndexMappingRequestMessage = 13,
        RefreshRequestMessage = 15,
        MessageUnavailableMessage = 31,
        SymbolClearMessage = 32,
        SecurityStatusMessage = 34,
        RefreshHeaderMessage = 35,
        AddOrderMessage = 100,
        ModifyOrderMessage = 101,
        ReplaceOrderMessage = 104,
        DeleteOrderMessage = 102,
        TradeCancelMessage = 112,
        CrossTradeMessage = 111,
        CrossCorrectionMessage = 113,
        RetailPriceImprovementMessage = 114,
        AddOrderRefreshMessage = 106,
        ImbalanceMessage = 105,
        OrderExecutionMessage = 103,
        NonDisplayedTradeMessage = 110,
        StockSummaryMessage = 223,
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
    ///  New Order Id
    /// </summary>
    public unsafe struct NewOrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Price Parity Splits
    /// </summary>
    public unsafe struct NewPriceParitySplits {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Num Extensions
    /// </summary>
    public unsafe struct NumExtensions {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Parity Splits
    /// </summary>
    public unsafe struct NumParitySplits {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Order Id
    /// </summary>
    public unsafe struct OrderId {
        public const int Size = 8;

        public long Value;

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
    ///  Paired Qty
    /// </summary>
    public unsafe struct PairedQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Position Change Values
    /// </summary>
    public enum PositionChange : byte {
        Kept = 0,
        Lost = 1,
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
    ///  Prev Price Parity Splits
    /// </summary>
    public unsafe struct PrevPriceParitySplits {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Printable Flag Values
    /// </summary>
    public enum PrintableFlag : byte {
        NotPrinted = O,
        Printed = 1,
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
    ///  Reference Price
    /// </summary>
    public unsafe struct ReferencePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Reserved 4
    /// </summary>
    public unsafe struct Reserved4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
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
    ///  Session State
    /// </summary>
    public unsafe struct SessionState {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
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
    ///  Ssr Filing Price
    /// </summary>
    public unsafe struct SsrFilingPrice {
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
        1InvalidMsgTypeOr2MismatchBetweenMsgTypeAndMsgSize = (byte)'9',
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
    ///  Total Imbalance Qty
    /// </summary>
    public unsafe struct TotalImbalanceQty {
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
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 4;

        public int Value;

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
    ///  Upper Collar
    /// </summary>
    public unsafe struct UpperCollar {
        public const int Size = 4;

        public int Value;

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
    ///  Struct for Add Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        OrderId OrderId;
        Price Price;
        Volume Volume;
        Side Side;
        FirmId FirmId;
        NumParitySplits NumParitySplits;
    };


    /// <summary>
    ///  Struct for Add Order Refresh Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderRefreshMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        OrderId OrderId;
        Price Price;
        Volume Volume;
        Side Side;
        FirmId FirmId;
        NumParitySplits NumParitySplits;
    };


    /// <summary>
    ///  Struct for Cross Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossCorrectionMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        CrossId CrossId;
        Volume Volume;
    };


    /// <summary>
    ///  Struct for Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossTradeMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        CrossId CrossId;
        Price Price;
        Volume Volume;
        CrossType CrossType;
    };


    /// <summary>
    ///  Struct for Delete Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        OrderId OrderId;
        NumParitySplits NumParitySplits;
    };


    /// <summary>
    ///  Struct for Heartbeat Response Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HeartbeatResponseMessage {
        SourceId SourceId;
    };


    /// <summary>
    ///  Struct for Imbalance Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ImbalanceMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        ReferencePrice ReferencePrice;
        PairedQty PairedQty;
        TotalImbalanceQty TotalImbalanceQty;
        MarketImbalanceQty MarketImbalanceQty;
        AuctionTime AuctionTime;
        AuctionType AuctionType;
        ImbalanceSide ImbalanceSide;
        ContinuousBookClearingPrice ContinuousBookClearingPrice;
        ClosingOnlyClearingPrice ClosingOnlyClearingPrice;
        SsrFilingPrice SsrFilingPrice;
        IndicativeMatchPrice IndicativeMatchPrice;
        UpperCollar UpperCollar;
        LowerCollar LowerCollar;
        AuctionStatus AuctionStatus;
        FreezeStatus FreezeStatus;
        NumExtensions NumExtensions;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageHeader MessageHeader;
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
    ///  Struct for Modify Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        OrderId OrderId;
        Price Price;
        Volume Volume;
        PositionChange PositionChange;
        PrevPriceParitySplits PrevPriceParitySplits;
        NewPriceParitySplits NewPriceParitySplits;
    };


    /// <summary>
    ///  Struct for Non Displayed Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NonDisplayedTradeMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeId TradeId;
        Price Price;
        Volume Volume;
        PrintableFlag PrintableFlag;
        DbExecId DbExecId;
    };


    /// <summary>
    ///  Struct for Order Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        OrderId OrderId;
        TradeId TradeId;
        Price Price;
        Volume Volume;
        PrintableFlag PrintableFlag;
        NumParitySplits NumParitySplits;
        DbExecId DbExecId;
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
    ///  Struct for Replace Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplaceOrderMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        OrderId OrderId;
        NewOrderId NewOrderId;
        Price Price;
        Volume Volume;
        PrevPriceParitySplits PrevPriceParitySplits;
        NewPriceParitySplits NewPriceParitySplits;
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
    ///  Struct for Retail Price Improvement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetailPriceImprovementMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        RpiIndicator RpiIndicator;
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
    ///  Struct for Security Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved4 Reserved4;
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
    ///  Struct for Source Time Reference Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SourceTimeReferenceMessage {
        Id Id;
        SymbolSeqNum SymbolSeqNum;
        SourceTime SourceTime;
    };


    /// <summary>
    ///  Struct for Stock Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockSummaryMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        HighPrice HighPrice;
        LowPrice LowPrice;
        Open Open;
        Close Close;
        TotalVolume TotalVolume;
    };


    /// <summary>
    ///  Struct for Symbol Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolClearMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        NextSourceSeqNum NextSourceSeqNum;
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
    ///  Struct for Trade Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelMessage {
        SourceTimeNs SourceTimeNs;
        SymbolIndex SymbolIndex;
        SymbolSeqNum SymbolSeqNum;
        TradeId TradeId;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
