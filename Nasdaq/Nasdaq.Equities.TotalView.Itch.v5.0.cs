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
    ///  Attribution
    /// </summary>
    public unsafe struct Attribution {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Collar Extension
    /// </summary>
    public unsafe struct AuctionCollarExtension {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auction Collar Reference Price
    /// </summary>
    public struct AuctionCollarReferencePrice {
        public int Raw;
    };


    /// <summary>
    ///  Authenticity Values
    /// </summary>
    public enum Authenticity : byte {
        LiveProduction = (byte)'P',
        Test = (byte)'T',
    };


    /// <summary>
    ///  Breached Level Values
    /// </summary>
    public enum BreachedLevel : byte {
        Level1 = (byte)'1',
        Level2 = (byte)'2',
        Level3 = (byte)'3',
    };


    /// <summary>
    ///  Buy Sell Indicator Values
    /// </summary>
    public enum BuySellIndicator : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
    };


    /// <summary>
    ///  Canceled Shares
    /// </summary>
    public unsafe struct CanceledShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Count
    /// </summary>
    public unsafe struct Count {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Price
    /// </summary>
    public struct CrossPrice {
        public int Raw;
    };


    /// <summary>
    ///  Cross Shares
    /// </summary>
    public unsafe struct CrossShares {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        OpeningCross = (byte)'O',
        ClosingCross = (byte)'C',
        CrossHaltedOrPaused = (byte)'H',
        IntradayCrossAndPostCloseCross = (byte)'I',
    };


    /// <summary>
    ///  Current Reference Price
    /// </summary>
    public struct CurrentReferencePrice {
        public int Raw;
    };


    /// <summary>
    ///  Etp Flag Values
    /// </summary>
    public enum EtpFlag : byte {
        Etp = (byte)'Y',
        NotEtp = (byte)'N',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Etp Leverage Factor
    /// </summary>
    public unsafe struct EtpLeverageFactor {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfMessages = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfMarketHours = (byte)'Q',
        EndOfMarketHours = (byte)'M',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
    };


    /// <summary>
    ///  Executed Shares
    /// </summary>
    public unsafe struct ExecutedShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Execution Price
    /// </summary>
    public struct ExecutionPrice {
        public int Raw;
    };


    /// <summary>
    ///  Far Price
    /// </summary>
    public struct FarPrice {
        public int Raw;
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        Deficient = (byte)'D',
        Delinquent = (byte)'E',
        Bankrupt = (byte)'Q',
        Suspended = (byte)'S',
        DeficientAndBankrupt = (byte)'G',
        DeficientAndDelinquent = (byte)'H',
        DelinquentAndBankrupt = (byte)'J',
        DeficientDelinquentAndBankrupt = (byte)'K',
        CreationsAndRedemptionsSuspended = (byte)'C',
        Normal = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Imbalance Direction Values
    /// </summary>
    public enum ImbalanceDirection : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        NoImbalance = (byte)'N',
        InsufficientOrders = (byte)'O',
    };


    /// <summary>
    ///  Imbalance Shares
    /// </summary>
    public unsafe struct ImbalanceShares {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Interest Flag Values
    /// </summary>
    public enum InterestFlag : byte {
        BuySideRpiOrdersAvailable = (byte)'B',
        SellSideRpiOrdersAvailable = (byte)'S',
        BothSidesRpiOrdersAvailable = (byte)'A',
        NoRpiOrdersAvailable = (byte)'N',
    };


    /// <summary>
    ///  Inverse Indicator Values
    /// </summary>
    public enum InverseIndicator : byte {
        InverseEtp = (byte)'Y',
        NotInverseEtp = (byte)'N',
    };


    /// <summary>
    ///  Ipo Flag Values
    /// </summary>
    public enum IpoFlag : byte {
        SetUpForIpoRealease = (byte)'Y',
        NotSetUpForIpoRealease = (byte)'N',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Ipo Price
    /// </summary>
    public struct IpoPrice {
        public int Raw;
    };


    /// <summary>
    ///  Ipo Quotation Release Qualifier Values
    /// </summary>
    public enum IpoQuotationReleaseQualifier : byte {
        AnticipatedQuotationReleaseTime = (byte)'A',
        IpoReleaseCanceledOrPostponed = (byte)'C',
    };


    /// <summary>
    ///  Ipo Quotation Release Time
    /// </summary>
    public unsafe struct IpoQuotationReleaseTime {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Classification Values
    /// </summary>
    public enum IssueClassification : byte {
        AmericanDepositaryShare = (byte)'A',
        Bond = (byte)'B',
        Common = (byte)'C',
        Depository = (byte)'F',
        144A = (byte)'I',
        Limited = (byte)'L',
        Notes = (byte)'N',
        OrdinaryShare = (byte)'O',
        Preferred = (byte)'P',
        Other = (byte)'Q',
        Right = (byte)'R',
        Shares = (byte)'S',
        Convertible = (byte)'T',
        Unit = (byte)'U',
        UnitsBenifInt = (byte)'V',
        Warrant = (byte)'W',
    };


    /// <summary>
    ///  Issue Sub Type Values
    /// </summary>
    public enum IssueSubType : ulong {
        PreferredTrustSecurities = A,
        AlphaIndexEtNs = AI,
        IndexBasedDerivative = B,
        CommonShares = C,
        CommodityBasedTrustShares = CB,
        CommodityFuturesTrustShares = CF,
        CurrencyTrustShares = CL,
        CommodityIndexTrustShares = CM,
        CollateralizedMortgageObligation = CO,
        CurrencyTrustShares = CT,
        Commodity­Currency = CU,
        CurrencyWarrants = CW,
        GlobalDepositary = D,
        Etf­PortfolioDepositaryReceipt = E,
        EquityGoldShares = EG,
        EtnEquity = EI,
        NextSharesExchange = EM,
        ExchangeTradedNotes = EN,
        EquityUnits = EU,
        Holdrs = F,
        EtnFixedIncome = FI,
        EtnFutures = FL,
        GlobalShares = G,
        Etf = I,
        Interest = IR,
        Index = IW,
        Index = IX,
        Corporate = J,
        Contingent = L,
        Warrant = W,
        IdentifiesSecurities = LL,
        EquityBasedDerivative = M,
        ManagedFundShares = MF,
        Etn = ML,
        ManagedTrustSecurities = MT,
        NyRegistryShares = N,
        OpenEndedMutualFund = O,
        PrivatelyHeldSecurity = P,
        PoisonPill = PP,
        PartnershipUnits = PU,
        ClosedEndFunds = Q,
        RegS = R,
        CommodityRedeemable = RC,
        Etn = RF,
        Reit = RT,
        Commodity­Redeemable = RU,
        Seed = S,
        SpotRateClosing = SC,
        SpotRateIntraday = SI,
        TrackingStock = T,
        TrustCertificates = TC,
        TrustUnits = TU,
        Portal = U,
        ContingentValueRight = V,
        TrustIssuedReceipts = W,
        WorldCurrencyOption = WC,
        Trust = X,
        Other = Y,
        NotApplicable = Z,
    };


    /// <summary>
    ///  Length
    /// </summary>
    public unsafe struct Length {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Level 1
    /// </summary>
    public struct Level1 {
        public long Raw;
    };


    /// <summary>
    ///  Level 2
    /// </summary>
    public struct Level2 {
        public long Raw;
    };


    /// <summary>
    ///  Level 3
    /// </summary>
    public struct Level3 {
        public long Raw;
    };


    /// <summary>
    ///  Locate Code
    /// </summary>
    public unsafe struct LocateCode {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lower Auction Collar Price
    /// </summary>
    public struct LowerAuctionCollarPrice {
        public int Raw;
    };


    /// <summary>
    ///  Luld Reference Price Tier Values
    /// </summary>
    public enum LuldReferencePriceTier : byte {
        Tier1 = (byte)'1',
        Tier2 = (byte)'2',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Market Category Values
    /// </summary>
    public enum MarketCategory : byte {
        NasdaqGlobalSelectMarket = (byte)'Q',
        NasdaqGlobalMarket = (byte)'G',
        NasdaqCapitalMarket = (byte)'S',
        Nyse = (byte)'N',
        NyseMkt = (byte)'A',
        NyseArca = (byte)'P',
        BatsZ = (byte)'Z',
        InvestorsExchange = (byte)'V',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Market Maker Mode Values
    /// </summary>
    public enum MarketMakerMode : byte {
        Normal = (byte)'N',
        Passive = (byte)'P',
        Syndicate = (byte)'S',
        PreSyndicate = (byte)'R',
        Penalty = (byte)'L',
    };


    /// <summary>
    ///  Market Participant State Values
    /// </summary>
    public enum MarketParticipantState : byte {
        Active = (byte)'A',
        Excused = (byte)'E',
        Withdrawn = (byte)'W',
        Suspended = (byte)'S',
        Deleted = (byte)'D',
    };


    /// <summary>
    ///  Match Number
    /// </summary>
    public unsafe struct MatchNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        StockDirectoryMessage = (byte)'R',
        StockTradingActionMessage = (byte)'H',
        RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
        MarketParticipantPositionMessage = (byte)'L',
        MwcbDeclineLevelMessage = (byte)'V',
        MwcbStatusLevelMessage = (byte)'W',
        IpoQuotingPeriodUpdate = (byte)'K',
        AddOrderNoMpidAttributionMessage = (byte)'A',
        LuldAuctionCollarMessage = (byte)'J',
        AddOrderWithMpidAttributionMessage = (byte)'F',
        OrderExecutedMessage = (byte)'E',
        OrderExecutedWithPriceMessage = (byte)'C',
        OrderCancelMessage = (byte)'X',
        OrderDeleteMessage = (byte)'D',
        OrderReplaceMessage = (byte)'U',
        NonCrossTradeMessage = (byte)'P',
        CrossTradeMessage = (byte)'Q',
        BrokenTradeMessage = (byte)'B',
        NetOrderImbalanceIndicatorMessage = (byte)'I',
        RetailInterestMessage = (byte)'N',
    };


    /// <summary>
    ///  Mpid
    /// </summary>
    public unsafe struct Mpid {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Near Price
    /// </summary>
    public struct NearPrice {
        public int Raw;
    };


    /// <summary>
    ///  New Order Reference Number
    /// </summary>
    public unsafe struct NewOrderReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Reference Number
    /// </summary>
    public unsafe struct OrderReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Order Reference Number
    /// </summary>
    public unsafe struct OriginalOrderReferenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Paired Shares
    /// </summary>
    public unsafe struct PairedShares {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public int Raw;
    };


    /// <summary>
    ///  Price Variation Indicator Values
    /// </summary>
    public enum PriceVariationIndicator : byte {
        Less = (byte)'L',
        1To199 = (byte)'1',
        2To299 = (byte)'2',
        3To399 = (byte)'3',
        4To499 = (byte)'4',
        5To599 = (byte)'5',
        6To699 = (byte)'6',
        7To799 = (byte)'7',
        8To899 = (byte)'8',
        9To999 = (byte)'9',
        10To1999 = (byte)'A',
        20To2999 = (byte)'B',
        30OrGreater = (byte)'C',
        NoCalculation = (byte)' ',
    };


    /// <summary>
    ///  Primary Market Maker Values
    /// </summary>
    public enum PrimaryMarketMaker : byte {
        Primary = (byte)'Y',
        NonPrimary = (byte)'N',
    };


    /// <summary>
    ///  Printable Values
    /// </summary>
    public enum Printable : byte {
        NonPrintable = (byte)'N',
        Printable = (byte)'Y',
    };


    /// <summary>
    ///  Reason
    /// </summary>
    public unsafe struct Reason {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reg Sho Action Values
    /// </summary>
    public enum RegShoAction : byte {
        NoPriceTest = (byte)'0',
        RegShoShortSalePriceTestRestriction = (byte)'1',
        TestRestrictionRemains = (byte)'2',
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Round Lot Size
    /// </summary>
    public unsafe struct RoundLotSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Round Lots Only Values
    /// </summary>
    public enum RoundLotsOnly : byte {
        RoundLotsOnly = (byte)'Y',
        NoRestrictions = (byte)'N',
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public unsafe struct Sequence {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session
    /// </summary>
    public unsafe struct Session {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Shares
    /// </summary>
    public unsafe struct Shares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Short Sale Threshold Indicator Values
    /// </summary>
    public enum ShortSaleThresholdIndicator : byte {
        Restricted = (byte)'Y',
        NotRestricted = (byte)'N',
        Na = (byte)' ',
    };


    /// <summary>
    ///  Stock
    /// </summary>
    public unsafe struct Stock {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stock Locate
    /// </summary>
    public unsafe struct StockLocate {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public ulong Raw;
    };


    /// <summary>
    ///  Tracking Number
    /// </summary>
    public unsafe struct TrackingNumber {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading State Values
    /// </summary>
    public enum TradingState : byte {
        Halted = (byte)'H',
        Paused = (byte)'P',
        QuotationOnlyPeriod = (byte)'Q',
        Trading = (byte)'T',
    };


    /// <summary>
    ///  Upper Auction Collar Price
    /// </summary>
    public struct UpperAuctionCollarPrice {
        public int Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Add Order No Mpid Attribution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderNoMpidAttributionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
    };


    /// <summary>
    ///  Struct for Add Order With Mpid Attribution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AddOrderWithMpidAttributionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
        Attribution Attribution;
    };


    /// <summary>
    ///  Struct for Broken Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossTradeMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        CrossShares CrossShares;
        Stock Stock;
        CrossPrice CrossPrice;
        MatchNumber MatchNumber;
        CrossType CrossType;
    };


    /// <summary>
    ///  Struct for Ipo Quoting Period Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IpoQuotingPeriodUpdate {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        IpoQuotationReleaseTime IpoQuotationReleaseTime;
        IpoQuotationReleaseQualifier IpoQuotationReleaseQualifier;
        IpoPrice IpoPrice;
    };


    /// <summary>
    ///  Struct for Luld Auction Collar Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LuldAuctionCollarMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        AuctionCollarReferencePrice AuctionCollarReferencePrice;
        UpperAuctionCollarPrice UpperAuctionCollarPrice;
        LowerAuctionCollarPrice LowerAuctionCollarPrice;
        AuctionCollarExtension AuctionCollarExtension;
    };


    /// <summary>
    ///  Struct for Market Participant Position Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketParticipantPositionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Mpid Mpid;
        Stock Stock;
        PrimaryMarketMaker PrimaryMarketMaker;
        MarketMakerMode MarketMakerMode;
        MarketParticipantState MarketParticipantState;
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
        Length Length;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Mwcb Decline Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbDeclineLevelMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Level1 Level1;
        Level2 Level2;
        Level3 Level3;
    };


    /// <summary>
    ///  Struct for Mwcb Status Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MwcbStatusLevelMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        BreachedLevel BreachedLevel;
    };


    /// <summary>
    ///  Struct for Net Order Imbalance Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NetOrderImbalanceIndicatorMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        PairedShares PairedShares;
        ImbalanceShares ImbalanceShares;
        ImbalanceDirection ImbalanceDirection;
        Stock Stock;
        FarPrice FarPrice;
        NearPrice NearPrice;
        CurrentReferencePrice CurrentReferencePrice;
        CrossType CrossType;
        PriceVariationIndicator PriceVariationIndicator;
    };


    /// <summary>
    ///  Struct for Non Cross Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NonCrossTradeMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Order Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        CanceledShares CanceledShares;
    };


    /// <summary>
    ///  Struct for Order Delete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderDeleteMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
    };


    /// <summary>
    ///  Struct for Order Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        ExecutedShares ExecutedShares;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Order Executed With Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutedWithPriceMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OrderReferenceNumber OrderReferenceNumber;
        ExecutedShares ExecutedShares;
        MatchNumber MatchNumber;
        Printable Printable;
        ExecutionPrice ExecutionPrice;
    };


    /// <summary>
    ///  Struct for Order Replace Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderReplaceMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        OriginalOrderReferenceNumber OriginalOrderReferenceNumber;
        NewOrderReferenceNumber NewOrderReferenceNumber;
        Shares Shares;
        Price Price;
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
        Session Session;
        Sequence Sequence;
        Count Count;
    };


    /// <summary>
    ///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
        LocateCode LocateCode;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Retail Interest Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RetailInterestMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        InterestFlag InterestFlag;
    };


    /// <summary>
    ///  Struct for Stock Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockDirectoryMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        MarketCategory MarketCategory;
        FinancialStatusIndicator FinancialStatusIndicator;
        RoundLotSize RoundLotSize;
        RoundLotsOnly RoundLotsOnly;
        IssueClassification IssueClassification;
        IssueSubType IssueSubType;
        Authenticity Authenticity;
        ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
        IpoFlag IpoFlag;
        LuldReferencePriceTier LuldReferencePriceTier;
        EtpFlag EtpFlag;
        EtpLeverageFactor EtpLeverageFactor;
        InverseIndicator InverseIndicator;
    };


    /// <summary>
    ///  Struct for Stock Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StockTradingActionMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        Stock Stock;
        TradingState TradingState;
        Reserved Reserved;
        Reason Reason;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        StockLocate StockLocate;
        TrackingNumber TrackingNumber;
        Timestamp Timestamp;
        EventCode EventCode;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
