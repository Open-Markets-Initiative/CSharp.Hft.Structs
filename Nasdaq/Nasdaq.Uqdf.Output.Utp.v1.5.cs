namespace Nasdaq.Uqdf.Output.Utp.v1.5 {

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
        SessionCloseRecapMessage = (byte)'R',
    };


    /// <summary>
    ///  Ask Adf Mpid
    /// </summary>
    public unsafe struct AskAdfMpid {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Price
    /// </summary>
    public unsafe struct AskPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Price Short
    /// </summary>
    public unsafe struct AskPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Size
    /// </summary>
    public unsafe struct AskSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Size Short
    /// </summary>
    public unsafe struct AskSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Best Ask Market Center
    /// </summary>
    public unsafe struct BestAskMarketCenter {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Ask Price
    /// </summary>
    public unsafe struct BestAskPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Ask Size
    /// </summary>
    public unsafe struct BestAskSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Market Center
    /// </summary>
    public unsafe struct BestBidMarketCenter {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Price
    /// </summary>
    public unsafe struct BestBidPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Size
    /// </summary>
    public unsafe struct BestBidSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Adf Mpid
    /// </summary>
    public unsafe struct BidAdfMpid {
        public const int Size = 4;

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
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price Short
    /// </summary>
    public unsafe struct BidPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size Short
    /// </summary>
    public unsafe struct BidSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Control Message Type Values
    /// </summary>
    public enum ControlMessageType : byte {
        StartOfDayMessage = (byte)'I',
        EndOfDayMessage = (byte)'J',
        MarketSessionOpenMessage = (byte)'O',
        MarketSessionCloseMessage = (byte)'C',
        EndOfTransmissionsMessage = (byte)'Z',
        QuoteWipeOutMessage = (byte)'P',
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
    ///  Finra Adf Mpid Appendage Indicator Values
    /// </summary>
    public enum FinraAdfMpidAppendageIndicator : byte {
        NotApplicable = (byte)' ',
        NoAdfMpidChanges = (byte)'0',
        NoAdfMpidExists = (byte)'1',
        AdfMpiDsAttached = (byte)'2',
    };


    /// <summary>
    ///  Finra Market Participant
    /// </summary>
    public unsafe struct FinraMarketParticipant {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Luld Bbo Indicator Values
    /// </summary>
    public enum LuldBboIndicator : byte {
        NotApplicable = (byte)' ',
        BidPriceAboveUpperLimitPriceBand = (byte)'A',
        AskPriceBelowLowerLimitPriceBand = (byte)'B',
        BidAndAskOutsidePriceBand = (byte)'C',
    };


    /// <summary>
    ///  Luld National Bbo Indicator Values
    /// </summary>
    public enum LuldNationalBboIndicator : byte {
        NotApplicable = (byte)' ',
        NationalBestBidAndNationalBestAskAreExecutable = (byte)'A',
        NationalBestBidBelowLowerLimitPriceBand = (byte)'B',
        NationalBestAskAboveUpperLimitPriceBand = (byte)'C',
        NationalBestBidBelowLowerLimitPriceBandAndNationalBestAskAboveUpperLimitPriceBand = (byte)'D',
        NationalBestBidEqualsUpperLimitPriceBand = (byte)'E',
        NationalBestOfferEqualsLowerLimitPriceBand = (byte)'F',
        NationalBestBidEqualsUpperLimitPriceBand = (byte)'G',
        NationalBestAskEqualsLowerLimitPriceBand = (byte)'H',
        NationalBestBidEqualsUpperLimitPriceBandAndNationalBestAskEqualsLowerLimitPriceBand = (byte)'I',
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
    ///  Market Center Ask Price
    /// </summary>
    public unsafe struct MarketCenterAskPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Center Ask Size
    /// </summary>
    public unsafe struct MarketCenterAskSize {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Center Bid Price
    /// </summary>
    public unsafe struct MarketCenterBidPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Center Bid Size
    /// </summary>
    public unsafe struct MarketCenterBidSize {
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
    ///  National Best Ask Market Center
    /// </summary>
    public unsafe struct NationalBestAskMarketCenter {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Ask Price
    /// </summary>
    public unsafe struct NationalBestAskPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Ask Price Short
    /// </summary>
    public unsafe struct NationalBestAskPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Ask Size
    /// </summary>
    public unsafe struct NationalBestAskSize {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Ask Size Short
    /// </summary>
    public unsafe struct NationalBestAskSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Bid Market Center
    /// </summary>
    public unsafe struct NationalBestBidMarketCenter {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Bid Price
    /// </summary>
    public unsafe struct NationalBestBidPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Bid Price Short
    /// </summary>
    public unsafe struct NationalBestBidPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Bid Size
    /// </summary>
    public unsafe struct NationalBestBidSize {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Best Bid Size Short
    /// </summary>
    public unsafe struct NationalBestBidSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Nbbo Appendage Indicator Values
    /// </summary>
    public enum NbboAppendageIndicator : byte {
        NoNationalBboChange = (byte)'0',
        NoNationalBboCanBeCalculated = (byte)'1',
        ShortFormNationalBboAppendage = (byte)'2',
        LongFormNationalBboAppendage = (byte)'3',
        QuoteContainsAllNationalBboInformation = (byte)'4',
    };


    /// <summary>
    ///  Nbbo Quote Condition Values
    /// </summary>
    public enum NbboQuoteCondition : byte {
        ManualAskAutomatedBid = (byte)'A',
        ManualBidAutomatedAsk = (byte)'B',
        FastTrading = (byte)'F',
        ManualBidAndAsk = (byte)'H',
        OrderImbalance = (byte)'I',
        ClosedQuote = (byte)'L',
        NonFirmQuote = (byte)'N',
        OpeningQuoteAutomated = (byte)'O',
        RegularTwoSidedOpenQuoteAutomated = (byte)'R',
        ManualBidAndAskNonFirm = (byte)'U',
        OrderInflux = (byte)'X',
        AutomatedBidNoOfferOrAutomatedOfferNoBid = (byte)'Y',
        NoOpenNoResume = (byte)'Z',
        IntradayAuction = (byte)'4',
    };


    /// <summary>
    ///  Number Of Market Center Attachments
    /// </summary>
    public unsafe struct NumberOfMarketCenterAttachments {
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
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        ManualAskAutomatedBid = (byte)'A',
        ManualBidAutomatedAsk = (byte)'B',
        FastTrading = (byte)'F',
        ManualBidAndAsk = (byte)'H',
        OrderImbalance = (byte)'I',
        ClosedQuote = (byte)'L',
        NonFirmQuote = (byte)'N',
        OpeningQuoteAutomated = (byte)'O',
        RegularTwoSidedOpenQuoteAutomated = (byte)'R',
        ManualBidAndAskNonFirm = (byte)'U',
        OrderInflux = (byte)'X',
        AutomatedBidNoOfferOrAutomatedOfferNoBid = (byte)'Y',
        NoOpenNoResume = (byte)'Z',
        IntradayAuction = (byte)'4',
    };


    /// <summary>
    ///  Quote Message Type Values
    /// </summary>
    public enum QuoteMessageType : byte {
        QuoteShortFormMessage = (byte)'E',
        QuoteLongFormMessage = (byte)'F',
        FinraAdfMarketParticipantQuotationMessage = (byte)'M',
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
    ///  Retail Interest Indicator Values
    /// </summary>
    public enum RetailInterestIndicator : byte {
        NotApplicable = (byte)' ',
        OnBidQuote = (byte)'A',
        OnAskQuote = (byte)'B',
        OnBothBidAndAskQuote = (byte)'C',
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
    ///  Sip Generated Update Values
    /// </summary>
    public enum SipGeneratedUpdate : byte {
        OriginatedFromTheMarketParticipant = (byte)' ',
        SiPgeneratedTransaction = (byte)'E',
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
    ///  Special Condition Values
    /// </summary>
    public enum SpecialCondition : byte {
        OneSidedNationalBboAtMarketClose = (byte)'O',
        TradingHaltInEffectAtMarketClose = (byte)'H',
        NoEligibleMarketParticipantQuotesInIssueAtMarketClose = (byte)'M',
        NoSpecialConditionExists = (byte)' ',
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
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Short
    /// </summary>
    public unsafe struct SymbolShort {
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
    ///  Trading Action Code Values
    /// </summary>
    public enum TradingActionCode : byte {
        TradingHalt = (byte)'H',
        QuotationResumptionIncludingAfterEma = (byte)'Q',
        TradingResumption = (byte)'T',
        VolatilityTradingPause = (byte)'P',
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
    ///  Struct for End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMessage {
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
    ///  Struct for Finra Adf Market Participant Quotation Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FinraAdfMarketParticipantQuotationMessage {
        MessageInfo MessageInfo;
        FinraTimestamp FinraTimestamp;
        Symbol Symbol;
        BidPrice BidPrice;
        BidSize BidSize;
        AskPrice AskPrice;
        AskSize AskSize;
        QuoteCondition QuoteCondition;
        FinraMarketParticipant FinraMarketParticipant;
    };


    /// <summary>
    ///  Struct for Finra Adf Mpid Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FinraAdfMpidAppendage {
        BidAdfMpid BidAdfMpid;
        AskAdfMpid AskAdfMpid;
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
    ///  Struct for Long Form National Bbo Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongFormNationalBboAppendage {
        NbboQuoteCondition NbboQuoteCondition;
        BestBidMarketCenter BestBidMarketCenter;
        BestBidPrice BestBidPrice;
        BestBidSize BestBidSize;
        BestAskMarketCenter BestAskMarketCenter;
        BestAskPrice BestAskPrice;
        BestAskSize BestAskSize;
    };


    /// <summary>
    ///  Struct for Market Center Close Recap
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketCenterCloseRecap {
        MarketCenterIdentifier MarketCenterIdentifier;
        MarketCenterBidPrice MarketCenterBidPrice;
        MarketCenterBidSize MarketCenterBidSize;
        MarketCenterAskPrice MarketCenterAskPrice;
        MarketCenterAskSize MarketCenterAskSize;
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
    ///  Struct for Quote
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Quote {
        QuoteMessageType QuoteMessageType;
    };


    /// <summary>
    ///  Struct for Quote Wipe Out Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteWipeOutMessage {
        MessageInfo MessageInfo;
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
    ///  Struct for Session Close Recap Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SessionCloseRecapMessage {
        MessageInfo MessageInfo;
        Symbol Symbol;
        NationalBestBidMarketCenter NationalBestBidMarketCenter;
        NationalBestBidPrice NationalBestBidPrice;
        NationalBestBidSize NationalBestBidSize;
        NationalBestAskMarketCenter NationalBestAskMarketCenter;
        NationalBestAskPrice NationalBestAskPrice;
        NationalBestAskSize NationalBestAskSize;
        SpecialCondition SpecialCondition;
        NumberOfMarketCenterAttachments NumberOfMarketCenterAttachments;
    };


    /// <summary>
    ///  Struct for Short Form National Bbo Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortFormNationalBboAppendage {
        NbboQuoteCondition NbboQuoteCondition;
        NationalBestBidMarketCenter NationalBestBidMarketCenter;
        NationalBestBidPriceShort NationalBestBidPriceShort;
        NationalBestBidSizeShort NationalBestBidSizeShort;
        NationalBestAskMarketCenter NationalBestAskMarketCenter;
        NationalBestAskPriceShort NationalBestAskPriceShort;
        NationalBestAskSizeShort NationalBestAskSizeShort;
    };


    /// <summary>
    ///  Struct for Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfDayMessage {
        MessageInfo MessageInfo;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
