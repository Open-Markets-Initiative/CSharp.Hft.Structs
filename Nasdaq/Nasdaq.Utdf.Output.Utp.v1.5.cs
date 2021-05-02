namespace Nasdaq.Utdf.Output.Utp.v1.5 {

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
    ///  Action Timestamp
    /// </summary>
    public unsafe struct ActionTimestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Administrative Message Type Values
    /// </summary>
    public enum AdministrativeMessageType : byte {
        GeneralAdministrativeMessage = (byte)'A',
        CrossSroTradingActionMessage = (byte)'H',
        MarketCenterTradingActionMessage = (byte)'H',
        IssueSymbolDirectoryMessage = (byte)'B',
        RegulationShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'V',
        LimitUpLimitDownPriceBandMessage = (byte)'P',
        MarketWideCircuitBreakerDeclineLevelMessage = (byte)'C',
        MarketWideCircuitBreakerDeclineLevelMessage = (byte)'D',
        AuctionCollarMessage = (byte)'E',
        ClosingTradeSummaryReportMessage = (byte)'Z',
    };


    /// <summary>
    ///  As Of Action Values
    /// </summary>
    public enum AsOfAction : byte {
        TradeAddition = (byte)'A',
        TradeCancel = (byte)'C',
    };


    /// <summary>
    ///  Authenticity Values
    /// </summary>
    public enum Authenticity : byte {
        Production = (byte)'P',
        Test = (byte)'T',
        Demo = (byte)'D',
        Deleted = (byte)'X',
    };


    /// <summary>
    ///  Collar Down Price
    /// </summary>
    public unsafe struct CollarDownPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Collar Extension Indicator
    /// </summary>
    public unsafe struct CollarExtensionIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Collar Reference Price
    /// </summary>
    public unsafe struct CollarReferencePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Collar Up Price
    /// </summary>
    public unsafe struct CollarUpPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Consolidated High Price
    /// </summary>
    public unsafe struct ConsolidatedHighPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Consolidated Last Price
    /// </summary>
    public unsafe struct ConsolidatedLastPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Consolidated Low Price
    /// </summary>
    public unsafe struct ConsolidatedLowPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Consolidated Price Change Indicator Values
    /// </summary>
    public enum ConsolidatedPriceChangeIndicator : byte {
        NoPricesChanged = (byte)'0',
        ConsolidatedLastPriceChanged = (byte)'1',
        ConsolidatedLowPriceChanged = (byte)'2',
        ConsolidatedLastAndConsolidatedLowPricesChanged = (byte)'3',
        ConsolidatedHighPriceChanged = (byte)'4',
        ConsolidatedLastAndConsolidatedHighPricesChanged = (byte)'5',
        ConsolidatedHighAndConsolidatedLowPricesChanged = (byte)'6',
        AllConsolidatedPricesChanged = (byte)'7',
    };


    /// <summary>
    ///  Consolidated Volume
    /// </summary>
    public unsafe struct ConsolidatedVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
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
        MarketSessionCloseMessage = (byte)'C',
        EndOfTransmissionsMessage = (byte)'Z',
        EndOfTradeReportingMessage = (byte)'X',
        EndOfConsolidatedLastSaleEligibility = (byte)'S',
    };


    /// <summary>
    ///  Corrected Sellers Sale Days
    /// </summary>
    public unsafe struct CorrectedSellersSaleDays {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Trade Id
    /// </summary>
    public unsafe struct CorrectedTradeId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Trade Price
    /// </summary>
    public unsafe struct CorrectedTradePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Trade Through Exempt Flag
    /// </summary>
    public unsafe struct CorrectedTradeThroughExemptFlag {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Volume
    /// </summary>
    public unsafe struct CorrectedVolume {
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
    ///  Current Market Center Volume
    /// </summary>
    public unsafe struct CurrentMarketCenterVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Consolidated Closing Price
    /// </summary>
    public unsafe struct DailyConsolidatedClosingPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Consolidated High Price
    /// </summary>
    public unsafe struct DailyConsolidatedHighPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Consolidated Low Price
    /// </summary>
    public unsafe struct DailyConsolidatedLowPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        CreationsAndOrRedemptionsSuspended = (byte)'C',
        Deficient = (byte)'D',
        Delinquent = (byte)'E',
        Bankrupt = (byte)'Q',
        Normal = (byte)'Q',
        Normal = (byte)'G',
        DeficientAndDelinquent = (byte)'H',
        DelinquentAndBankrupt = (byte)'J',
        DeficientDelinquentAndBankrupt = (byte)'K',
    };


    /// <summary>
    ///  Finra Timestamp
    /// </summary>
    public unsafe struct FinraTimestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Name
    /// </summary>
    public unsafe struct IssueName {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Subtype
    /// </summary>
    public unsafe struct IssueSubtype {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Type Values
    /// </summary>
    public enum IssueType : byte {
        AmericanDepositoryReceipt = (byte)'A',
        Bond = (byte)'B',
        CommonStock = (byte)'C',
        DepositoryReceipt = (byte)'F',
        Rule144A = (byte)'I',
        LimitedPartnership = (byte)'L',
        Note = (byte)'N',
        OrdinaryShares = (byte)'O',
        PreferredStock = (byte)'P',
        OtherSecurities = (byte)'Q',
        Rights = (byte)'R',
        SharesOfBeneficialInterest = (byte)'S',
        ConvertibleDebenture = (byte)'T',
        Unit = (byte)'U',
        UnitsOfBeneficialInterest = (byte)'V',
        Warrant = (byte)'W',
    };


    /// <summary>
    ///  Level 1 Values
    /// </summary>
    public enum Level1 : byte {
        RegularTrade = (byte)'@',
        Cash = (byte)'C',
        NextDay = (byte)'N',
        Seller = (byte)'R',
        YellowFlag = (byte)'Y',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Level 2 Values
    /// </summary>
    public enum Level2 : byte {
        IntermarketSweep = (byte)'F',
        OpeningPrints = (byte)'O',
        DerivativelyPriced = (byte)'4',
        ReOpeningPrints = (byte)'5',
        ClosingPrints = (byte)'6',
        QualifiedContingentTrade = (byte)'7',
        PlaceholderFor611Exempt = (byte)'8',
        CorrectedConsolidatedClose = (byte)'9',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Level 3 Values
    /// </summary>
    public enum Level3 : byte {
        FormT = (byte)'T',
        SoldLast = (byte)'L',
        SoldOutOfSequence = (byte)'Z',
        ExtendedTradingHours = (byte)'U',
        NotAvailable = (byte)' ',
        StoppedStock = (byte)'1',
        Acquisition = (byte)'A',
        Bunched = (byte)'B',
        Distribution = (byte)'D',
        PlaceholderFuture = (byte)'E',
        BunchedSoldTrade = (byte)'G',
        PriceVariation = (byte)'H',
        OddLotTrade = (byte)'I',
        Rule155 = (byte)'K',
        MarketCenterOfficialClosePrice = (byte)'M',
        PriorReferencePrice = (byte)'P',
        MarketCenterOfficialOpenPrice = (byte)'Q',
        SplitTrade = (byte)'S',
        ContingentTrade = (byte)'V',
        AveragePriceTrade = (byte)'W',
        CrossTrade = (byte)'X',
    };


    /// <summary>
    ///  Level 4
    /// </summary>
    public unsafe struct Level4 {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Limit Down Price
    /// </summary>
    public unsafe struct LimitDownPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Limit Up Price
    /// </summary>
    public unsafe struct LimitUpPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Luld Price Band Indicator Values
    /// </summary>
    public enum LuldPriceBandIndicator : byte {
        OpeningUpdate = (byte)'A',
        IntraDayUpdate = (byte)'B',
        RestatedValue = (byte)'C',
        SuspendedDuringTradingHaltOrTradingPause = (byte)'D',
        ReOpeningUpdate = (byte)'E',
        OutsidePriceBandRuleHours = (byte)'F',
        NoneProvided = (byte)' ',
    };


    /// <summary>
    ///  Luld Timestamp
    /// </summary>
    public unsafe struct LuldTimestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Center Close Indicator Values
    /// </summary>
    public enum MarketCenterCloseIndicator : byte {
        BasedOnMSaleCondition = (byte)'M',
        NotBasedOnMSaleCondition = (byte)' ',
    };


    /// <summary>
    ///  Market Center Closing Price
    /// </summary>
    public unsafe struct MarketCenterClosingPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Center Identifier
    /// </summary>
    public unsafe struct MarketCenterIdentifier {
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
    public enum MarketCenterOriginatorId : byte {
        Byx = (byte)'Y',
        Bzx = (byte)'Z',
        Edga = (byte)'J',
        Edgx = (byte)'K',
        Cboe = (byte)'W',
        Bx = (byte)'B',
        Phlx = (byte)'X',
        Nasdaq = (byte)'Q',
        Ise = (byte)'I',
        Nyse = (byte)'N',
        Arca = (byte)'P',
        American = (byte)'A',
        National = (byte)'C',
        Chicago = (byte)'M',
        Finra = (byte)'D',
        Iex = (byte)'V',
        Ltse = (byte)'L',
        Pearl = (byte)'H',
        Memx = (byte)'U',
        MarketIndependent = (byte)'E',
    };


    /// <summary>
    ///  Market Center Volume
    /// </summary>
    public unsafe struct MarketCenterVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Participant High Price
    /// </summary>
    public unsafe struct MarketParticipantHighPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Participant Last Price
    /// </summary>
    public unsafe struct MarketParticipantLastPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Participant Low Price
    /// </summary>
    public unsafe struct MarketParticipantLowPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Participant Volume
    /// </summary>
    public unsafe struct MarketParticipantVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Tier Values
    /// </summary>
    public enum MarketTier : byte {
        NasdaqGlobalSelectMarket = (byte)'Q',
        NasdaqGlobalMarket = (byte)'G',
        NasdaqCapitalMarket = (byte)'S',
    };


    /// <summary>
    ///  Message Category
    /// </summary>
    public unsafe struct MessageCategory {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mwcb Level 1
    /// </summary>
    public unsafe struct MwcbLevel1 {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mwcb Level 2
    /// </summary>
    public unsafe struct MwcbLevel2 {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mwcb Level 3
    /// </summary>
    public unsafe struct MwcbLevel3 {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Market Center Summaries
    /// </summary>
    public unsafe struct NumberOfMarketCenterSummaries {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Market Center Volumes
    /// </summary>
    public unsafe struct NumberOfMarketCenterVolumes {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Old Symbol
    /// </summary>
    public unsafe struct OldSymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Sellers Sale Days
    /// </summary>
    public unsafe struct OriginalSellersSaleDays {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Id
    /// </summary>
    public unsafe struct OriginalTradeId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Price
    /// </summary>
    public unsafe struct OriginalTradePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Trade Through Exempt Flag
    /// </summary>
    public unsafe struct OriginalTradeThroughExemptFlag {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Volume
    /// </summary>
    public unsafe struct OriginalVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Participant Price Change Indicator Values
    /// </summary>
    public enum ParticipantPriceChangeIndicator : byte {
        NoPricesChanged = (byte)'0',
        ParticipantLastPriceChanged = (byte)'1',
        ParticipantLowPriceChanged = (byte)'2',
        ParticipantLastAndLowPricesChanged = (byte)'3',
        ParticipantHighPriceChanged = (byte)'4',
        ParticipantLastAndHighPricesChanged = (byte)'5',
        ParticipantHighAndLowPricesChanged = (byte)'6',
        AllParticipantPricesChanged = (byte)'7',
    };


    /// <summary>
    ///  Participant Timestamp
    /// </summary>
    public unsafe struct ParticipantTimestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Participant Token
    /// </summary>
    public unsafe struct ParticipantToken {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reg Sho Action Values
    /// </summary>
    public enum RegShoAction : byte {
        NoPriceTestInEffect = (byte)'0',
        RegShoInEffectDueToAnIntraDayPriceDrop = (byte)'1',
        RegShoRestrictionRemainsInEffect = (byte)'2',
    };


    /// <summary>
    ///  Round Lot Size
    /// </summary>
    public unsafe struct RoundLotSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sellers Sale Days
    /// </summary>
    public unsafe struct SellersSaleDays {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Short Sale Threshold Indicator Values
    /// </summary>
    public enum ShortSaleThresholdIndicator : byte {
        IssueIsRestricted = (byte)'Y',
        IssueIsNotRestricted = (byte)'N',
        NotAvailable = (byte)' ',
    };


    /// <summary>
    ///  Sip Timestamp
    /// </summary>
    public unsafe struct SipTimestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sub Market Center Id Values
    /// </summary>
    public enum SubMarketCenterId : byte {
        NyseTrf = (byte)'N',
        NasdaqTrfCarteret = (byte)'Q',
        NasdaqTrfChicago = (byte)'B',
        FinraAlternativeDisplayFacility = (byte)' ',
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Text
    /// </summary>
    public unsafe struct Text {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Text Length
    /// </summary>
    public unsafe struct TextLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Timestamp Of Trade
    /// </summary>
    public unsafe struct TimestampOfTrade {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Consolidated Volume
    /// </summary>
    public unsafe struct TotalConsolidatedVolume {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Cancellation Type
    /// </summary>
    public unsafe struct TradeCancellationType {
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
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Message Type Values
    /// </summary>
    public enum TradeMessageType : byte {
        TradeReportMessageShortFormMessage = (byte)'A',
        TradeReportMessageLongFormMessage = (byte)'W',
        TradeCancelErrorMessage = (byte)'Z',
        TradeCorrectionMessage = (byte)'Y',
        PriorDayAsOfTradeMessage = (byte)'H',
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public unsafe struct TradePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price Short
    /// </summary>
    public unsafe struct TradePriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Through Exempt Flag
    /// </summary>
    public unsafe struct TradeThroughExemptFlag {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Volume
    /// </summary>
    public unsafe struct TradeVolume {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Volume Short
    /// </summary>
    public unsafe struct TradeVolumeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Action Code Values
    /// </summary>
    public enum TradingActionCode : byte {
        TradingHalt = (byte)'H',
        QuotationResumptionIncludingAfterEma = (byte)'Q',
        TradingResumption = (byte)'T',
        VolatilityTradingPause = (byte)'P',
    };


    /// <summary>
    ///  Trading Action Indicator Values
    /// </summary>
    public enum TradingActionIndicator : byte {
        TradingHalt = (byte)'H',
        RegularTrading = (byte)' ',
    };


    /// <summary>
    ///  Trading Action Reason
    /// </summary>
    public unsafe struct TradingActionReason {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Action Sequence Number
    /// </summary>
    public unsafe struct TradingActionSequenceNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Volume Message Type Values
    /// </summary>
    public enum VolumeMessageType : byte {
        TotalConsolidatedAndMarketCenterVolumeMessage = (byte)'M',
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Administrative
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Administrative {
        AdministrativeMessageType AdministrativeMessageType;
    };


    /// <summary>
    ///  Struct for Auction Collar Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionCollarMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        TradingActionSequenceNumber TradingActionSequenceNumber;
        CollarReferencePrice CollarReferencePrice;
        CollarUpPrice CollarUpPrice;
        CollarDownPrice CollarDownPrice;
        CollarExtensionIndicator CollarExtensionIndicator;
    };


    /// <summary>
    ///  Struct for Closing Trade Summary Report Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClosingTradeSummaryReportMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        DailyConsolidatedHighPrice DailyConsolidatedHighPrice;
        DailyConsolidatedLowPrice DailyConsolidatedLowPrice;
        DailyConsolidatedClosingPrice DailyConsolidatedClosingPrice;
        MarketCenterOriginatorId MarketCenterOriginatorId;
        ConsolidatedVolume ConsolidatedVolume;
        TradingActionIndicator TradingActionIndicator;
        NumberOfMarketCenterSummaries NumberOfMarketCenterSummaries;
    };


    /// <summary>
    ///  Struct for Control
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Control {
        ControlMessageType ControlMessageType;
    };


    /// <summary>
    ///  Struct for Cross Sro Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossSroTradingActionMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        TradingActionCode TradingActionCode;
        TradingActionSequenceNumber TradingActionSequenceNumber;
        ActionTimestamp ActionTimestamp;
        TradingActionReason TradingActionReason;
    };


    /// <summary>
    ///  Struct for End Of Consolidated Last Sale Eligibility
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfConsolidatedLastSaleEligibility {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMessage {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for End Of Trade Reporting Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfTradeReportingMessage {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for End Of Transmissions Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfTransmissionsMessage {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for General Administrative Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GeneralAdministrativeMessage {
        MessageInfo MessageInfo;
        TextLength TextLength;
    };


    /// <summary>
    ///  Struct for Issue Symbol Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IssueSymbolDirectoryMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        OldSymbol OldSymbol;
        IssueName IssueName;
        IssueType IssueType;
        IssueSubtype IssueSubtype;
        MarketTier MarketTier;
        Authenticity Authenticity;
        ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
        RoundLotSize RoundLotSize;
        FinancialStatusIndicator FinancialStatusIndicator;
    };


    /// <summary>
    ///  Struct for Limit Up Limit Down Price Band Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LimitUpLimitDownPriceBandMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        LuldPriceBandIndicator LuldPriceBandIndicator;
        LuldTimestamp LuldTimestamp;
        LimitDownPrice LimitDownPrice;
        LimitUpPrice LimitUpPrice;
    };


    /// <summary>
    ///  Struct for Market Center Closing Price And Volume Summary
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketCenterClosingPriceAndVolumeSummary {
        MarketCenterIdentifier MarketCenterIdentifier;
        MarketCenterClosingPrice MarketCenterClosingPrice;
        MarketCenterVolume MarketCenterVolume;
        MarketCenterCloseIndicator MarketCenterCloseIndicator;
        MarketParticipantHighPrice MarketParticipantHighPrice;
        MarketParticipantLowPrice MarketParticipantLowPrice;
    };


    /// <summary>
    ///  Struct for Market Center Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketCenterTradingActionMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        TradingActionCode TradingActionCode;
        ActionTimestamp ActionTimestamp;
        MarketCenterIdentifier MarketCenterIdentifier;
    };


    /// <summary>
    ///  Struct for Market Center Volume Attachment
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketCenterVolumeAttachment {
        MarketCenterIdentifier MarketCenterIdentifier;
        CurrentMarketCenterVolume CurrentMarketCenterVolume;
    };


    /// <summary>
    ///  Struct for Market Session Close Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSessionCloseMessage {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for Market Session Open Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketSessionOpenMessage {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for Market Wide Circuit Breaker Decline Level Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketWideCircuitBreakerDeclineLevelMessage {
        MessageInfo MessageInfo;
        MwcbLevel1 MwcbLevel1;
        MwcbLevel2 MwcbLevel2;
        MwcbLevel3 MwcbLevel3;
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
        MessageLength MessageLength;
        Version Version;
        MessageCategory MessageCategory;
    };


    /// <summary>
    ///  Struct for Message Info
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageInfo {
        MarketCenterOriginatorId MarketCenterOriginatorId;
        SubMarketCenterId SubMarketCenterId;
        SipTimestamp SipTimestamp;
        ParticipantTimestamp ParticipantTimestamp;
        ParticipantToken ParticipantToken;
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
    ///  Struct for Prior Day As Of Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriorDayAsOfTradeMessage {
        MessageInfo MessageInfo;
        FinraTimestamp FinraTimestamp;
        Symbol Symbol;
        TradeId TradeId;
        TradePrice TradePrice;
        TradeVolume TradeVolume;
        SaleCondition SaleCondition;
        TradeThroughExemptFlag TradeThroughExemptFlag;
        SellersSaleDays SellersSaleDays;
        AsOfAction AsOfAction;
        TimestampOfTrade TimestampOfTrade;
    };


    /// <summary>
    ///  Struct for Regulation Sho Short Sale Price Test Restricted Indicator Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RegulationShoShortSalePriceTestRestrictedIndicatorMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        RegShoAction RegShoAction;
    };


    /// <summary>
    ///  Struct for Sale Condition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SaleCondition {
        Level1 Level1;
        Level2 Level2;
        Level3 Level3;
        Level4 Level4;
    };


    /// <summary>
    ///  Struct for Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfDayMessage {
        MessageInfo MessageInfo;
    };


    /// <summary>
    ///  Struct for Total Consolidated And Market Center Volume Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TotalConsolidatedAndMarketCenterVolumeMessage {
        MessageInfo MessageInfo;
        TotalConsolidatedVolume TotalConsolidatedVolume;
        NumberOfMarketCenterVolumes NumberOfMarketCenterVolumes;
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
        MessageInfo MessageInfo;
        FinraTimestamp FinraTimestamp;
        Symbol Symbol;
        TradeCancellationType TradeCancellationType;
        OriginalTradeId OriginalTradeId;
        OriginalTradePrice OriginalTradePrice;
        OriginalVolume OriginalVolume;
        OriginalSaleCondition OriginalSaleCondition;
        OriginalTradeThroughExemptFlag OriginalTradeThroughExemptFlag;
        OriginalSellersSaleDays OriginalSellersSaleDays;
        ConsolidatedHighPrice ConsolidatedHighPrice;
        ConsolidatedLowPrice ConsolidatedLowPrice;
        ConsolidatedLastPrice ConsolidatedLastPrice;
        ConsolidatedVolume ConsolidatedVolume;
        ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
        MarketCenterOriginatorId MarketCenterOriginatorId;
        MarketParticipantHighPrice MarketParticipantHighPrice;
        MarketParticipantLowPrice MarketParticipantLowPrice;
        MarketParticipantLastPrice MarketParticipantLastPrice;
        MarketParticipantVolume MarketParticipantVolume;
    };


    /// <summary>
    ///  Struct for Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCorrectionMessage {
        MessageInfo MessageInfo;
        FinraTimestamp FinraTimestamp;
        Symbol Symbol;
        OriginalTradeId OriginalTradeId;
        OriginalTradePrice OriginalTradePrice;
        OriginalVolume OriginalVolume;
        OriginalSaleCondition OriginalSaleCondition;
        OriginalTradeThroughExemptFlag OriginalTradeThroughExemptFlag;
        OriginalSellersSaleDays OriginalSellersSaleDays;
        CorrectedTradeId CorrectedTradeId;
        CorrectedTradePrice CorrectedTradePrice;
        CorrectedVolume CorrectedVolume;
        CorrectedSaleCondition CorrectedSaleCondition;
        CorrectedTradeThroughExemptFlag CorrectedTradeThroughExemptFlag;
        CorrectedSellersSaleDays CorrectedSellersSaleDays;
        ConsolidatedHighPrice ConsolidatedHighPrice;
        ConsolidatedLowPrice ConsolidatedLowPrice;
        ConsolidatedLastPrice ConsolidatedLastPrice;
        ConsolidatedVolume ConsolidatedVolume;
        ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
        MarketCenterOriginatorId MarketCenterOriginatorId;
        MarketParticipantHighPrice MarketParticipantHighPrice;
        MarketParticipantLowPrice MarketParticipantLowPrice;
        MarketParticipantLastPrice MarketParticipantLastPrice;
        MarketParticipantVolume MarketParticipantVolume;
    };


    /// <summary>
    ///  Struct for Trade Report Message Long Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportMessageLongFormMessage {
        MessageInfo MessageInfo;
        FinraTimestamp FinraTimestamp;
        Symbol Symbol;
        TradeId TradeId;
        TradePrice TradePrice;
        TradeVolume TradeVolume;
        SaleCondition SaleCondition;
        TradeThroughExemptFlag TradeThroughExemptFlag;
        SellersSaleDays SellersSaleDays;
        ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
        ParticipantPriceChangeIndicator ParticipantPriceChangeIndicator;
    };


    /// <summary>
    ///  Struct for Trade Report Message Short Form Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeReportMessageShortFormMessage {
        MessageInfo MessageInfo;
        FinraTimestamp FinraTimestamp;
        Symbol Symbol;
        TradeId TradeId;
        TradePriceShort TradePriceShort;
        TradeVolumeShort TradeVolumeShort;
        SaleCondition SaleCondition;
        TradeThroughExemptFlag TradeThroughExemptFlag;
        ConsolidatedPriceChangeIndicator ConsolidatedPriceChangeIndicator;
        ParticipantPriceChangeIndicator ParticipantPriceChangeIndicator;
    };


    /// <summary>
    ///  Struct for Volume
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Volume {
        VolumeMessageType VolumeMessageType;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
