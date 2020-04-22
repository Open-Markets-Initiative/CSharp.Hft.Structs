namespace Siac.Cqs.Output.Cta.v1.91 {

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
    ///  Administrative Message Type Values
    /// </summary>
    public enum AdministrativeMessageType : byte {
        AdministrativeUnformattedMessage = (byte)'H',
    };


    /// <summary>
    ///  Best Bid Participant Id Values
    /// </summary>
    public enum BestBidParticipantId : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        Ltse = (byte)'L',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Cqs = (byte)'S',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Best Bid Price Long
    /// </summary>
    public unsafe struct BestBidPriceLong {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Price Short
    /// </summary>
    public unsafe struct BestBidPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Quote Condition
    /// </summary>
    public unsafe struct BestBidQuoteCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Size Long
    /// </summary>
    public unsafe struct BestBidSizeLong {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Size Short
    /// </summary>
    public unsafe struct BestBidSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Participant Id Values
    /// </summary>
    public enum BestOfferParticipantId : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        Ltse = (byte)'L',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Cqs = (byte)'S',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Best Offer Price Long
    /// </summary>
    public unsafe struct BestOfferPriceLong {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Price Short
    /// </summary>
    public unsafe struct BestOfferPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Quote Condition
    /// </summary>
    public unsafe struct BestOfferQuoteCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Size Long
    /// </summary>
    public unsafe struct BestOfferSizeLong {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Size Short
    /// </summary>
    public unsafe struct BestOfferSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price Long
    /// </summary>
    public unsafe struct BidPriceLong {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price Lower Limit Price Band
    /// </summary>
    public unsafe struct BidPriceLowerLimitPriceBand {
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
    ///  Bid Size Long
    /// </summary>
    public unsafe struct BidSizeLong {
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
    ///  Block Checksum
    /// </summary>
    public unsafe struct BlockChecksum {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Pad Byte
    /// </summary>
    public unsafe struct BlockPadByte {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Sequence Number
    /// </summary>
    public unsafe struct BlockSequenceNumber {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Size
    /// </summary>
    public unsafe struct BlockSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Control Message Type Values
    /// </summary>
    public enum ControlMessageType : byte {
        StartOfDayMessage = (byte)'A',
        FinraCloseMessage = (byte)'C',
        ResetBlockSequenceNumberMessage = (byte)'L',
        StartOfTestCycleMessage = (byte)'M',
        EndOfTestCycleMessage = (byte)'N',
        FinraOpenMessage = (byte)'O',
        DisasterRecoveryDataCenterActivationMessage = (byte)'P',
        LineIntegrityMessage = (byte)'T',
        EndOfDayMessage = (byte)'Z',
    };


    /// <summary>
    ///  Data Feed Indicator
    /// </summary>
    public unsafe struct DataFeedIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Financial Status Indicator Values
    /// </summary>
    public enum FinancialStatusIndicator : byte {
        FinancialStatusNotApplicable = (byte)'0',
        Bankrupt = (byte)'1',
        BelowContinuingListingStandards = (byte)'2',
        BankruptAndBelowContinuingListingStandards = (byte)'3',
        LateFiling = (byte)'4',
        BankruptAndLateFiling = (byte)'5',
        BelowContinuingListingStandardsAndLateFiling = (byte)'6',
        BankruptBelowContinuingListingStandardsAndLateFiling = (byte)'7',
        CreationsSuspended = (byte)'8',
        RedemptionsSuspended = (byte)'9',
        Liquidation = (byte)'A',
    };


    /// <summary>
    ///  Finra Bbo Indicator Values
    /// </summary>
    public enum FinraBboIndicator : byte {
        NotApplicable = (byte)' ',
        NoFinraBboChange = (byte)'A',
        NoFinraBboExists = (byte)'B',
    };


    /// <summary>
    ///  Finra Bbo Luld Indicator Values
    /// </summary>
    public enum FinraBboLuldIndicator : byte {
        LimitUpLimitDownNotApplicable = (byte)'',
        FinraBestBidAndOrFinraBestOfferAreExecutable = (byte)'A',
        FinraBestBidBelowLowerLimitPriceBandAndFinraBestBidIsNonExecutable = (byte)'B',
        FinraBestOfferAboveUpperLimitPriceBandAndFinraBestOfferIsNonExecutable = (byte)'C',
        BestBidBelowLowerLimitPriceBandAndBestOfferAboveUpperLimitPriceBandBestBidAndBestOfferAreNonExecutableForFinra = (byte)'D',
    };


    /// <summary>
    ///  Finra Best Bid Market Maker Id
    /// </summary>
    public unsafe struct FinraBestBidMarketMakerId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Bid Price
    /// </summary>
    public unsafe struct FinraBestBidPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Bid Quote Condition
    /// </summary>
    public unsafe struct FinraBestBidQuoteCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Bid Size
    /// </summary>
    public unsafe struct FinraBestBidSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Offer Market Maker Id
    /// </summary>
    public unsafe struct FinraBestOfferMarketMakerId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Offer Price
    /// </summary>
    public unsafe struct FinraBestOfferPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Offer Quote Condition
    /// </summary>
    public unsafe struct FinraBestOfferQuoteCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Best Offer Size
    /// </summary>
    public unsafe struct FinraBestOfferSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Finra Market Maker Id
    /// </summary>
    public unsafe struct FinraMarketMakerId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Future
    /// </summary>
    public unsafe struct Future {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Instrument Type Values
    /// </summary>
    public enum InstrumentType : byte {
        CtaEligibleEquity = (byte)'0',
        LocalIssue = (byte)'1',
        CorporateBond = (byte)'2',
        GovernmentBond = (byte)'3',
    };


    /// <summary>
    ///  Luld Indicator
    /// </summary>
    public unsafe struct LuldIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Condition Values
    /// </summary>
    public enum MarketCondition : byte {
        NormalAuctionMarket = (byte)' ',
        CrossedMarket = (byte)'A',
        LockedMarket = (byte)'B',
    };


    /// <summary>
    ///  Market Status Message Type Values
    /// </summary>
    public enum MarketStatusMessageType : byte {
        MarketWideCircuitBreakerDeclineLevelStatusMessage = (byte)'M',
        MarketWideCircuitBreakerStatusMessage = (byte)'L',
    };


    /// <summary>
    ///  Message Category Values
    /// </summary>
    public enum MessageCategory : byte {
        Administrative = (byte)'A',
        Control = (byte)'C',
        MarketStatus = (byte)'M',
        Quote = (byte)'Q',
    };


    /// <summary>
    ///  Message Id
    /// </summary>
    public unsafe struct MessageId {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
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
    ///  Messages In Block
    /// </summary>
    public unsafe struct MessagesInBlock {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mwcb Level 2
    /// </summary>
    public struct MwcbLevel2 {
        public long Raw;
    };


    /// <summary>
    ///  Mwcb Level 3
    /// </summary>
    public struct MwcbLevel3 {
        public long Raw;
    };


    /// <summary>
    ///  Nanoseconds
    /// </summary>
    public unsafe struct Nanoseconds {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  National Bbo Indicator Values
    /// </summary>
    public enum NationalBboIndicator : byte {
        NotIncluded = (byte)' ',
        NoBestBidChangeOrBestOfferChange = (byte)'A',
        NoBestBidChangeQuoteContainsBestOffer = (byte)'B',
        NoBestBidChangeBestOfferShortAppendage = (byte)'C',
        NoBestBidChangeBestOfferLongAppendage = (byte)'D',
        NoBestBidChangeNoBestOffer = (byte)'E',
        QuoteContainsBestBidNoBestOfferChange = (byte)'F',
        QuoteContainsBestBidQuoteContainsBestOffer = (byte)'G',
        QuoteContainsBestBidBestOfferShortAppendage = (byte)'H',
        QuoteContainsBestBidBestOfferLongAppendage = (byte)'I',
        QuoteContainsBestBidNoBestOffer = (byte)'J',
        NoBestBidNoBestOfferChange = (byte)'K',
        NoBestBidQuoteContainsBestOffer = (byte)'L',
        NoBestBidBestOfferShortAppendage = (byte)'M',
        NoBestBidBestOfferLongAppendage = (byte)'N',
        NoBestBidNoBestOffer = (byte)'O',
        BestBidShortAppendageNoBestOfferChange = (byte)'P',
        BestBidLongAppendageNoBestOfferChange = (byte)'Q',
        BestBidShortAppendageQuoteContainsBestOffer = (byte)'R',
        BestBidLongAppendageQuoteContainsBestOffer = (byte)'S',
        BestBidShortAppendageBestOfferShortAppendage = (byte)'T',
        BestBidLongAppendageBestOfferLongAppendage = (byte)'U',
        BestBidShortAppendageNoBestOffer = (byte)'V',
        BestBidLongAppendageNoBestOffer = (byte)'W',
    };


    /// <summary>
    ///  National Bbo Luld Indicator Values
    /// </summary>
    public enum NationalBboLuldIndicator : byte {
        NotApplicable = (byte)' ',
        NationalBestBidAndOrNationalBestOfferAreExecutable = (byte)'A',
        NationalBestBidBelowLowerLimitPriceBandAndIsNonExecutable = (byte)'B',
        NationalBestOfferAboveUpperLimitPriceBandAndIsNonExecutable = (byte)'C',
        NationalBestBidBelowLowerLimitPriceBandAndNationalBestOfferAboveUpperLimitPriceBandBothAreNonExecutable = (byte)'D',
        NationalBestBidEqualsUpperLimitPriceBandAndIsInLimitState = (byte)'E',
        NationalBestOfferEqualsLowerLimitPriceBandAndIsInLimitState = (byte)'F',
        NationalBestBidEqualsUpperLimitPriceBandAndIsInLimitStateAndNationalBestOfferAboveUpperLimitPriceBandAndIsNonExecutable = (byte)'G',
        NationalBestBidBelowLowerLimitPriceBandAndIsNonExecutableAndNationalBestOfferEqualsLowerLimitPriceBandAndIsInLimitState = (byte)'H',
        NationalBestBidEqualsUpperLimitPriceBandAndNationalBestOfferEqualsLowerLimitPriceBand = (byte)'I',
    };


    /// <summary>
    ///  Number Of Extensions
    /// </summary>
    public unsafe struct NumberOfExtensions {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Price Long
    /// </summary>
    public unsafe struct OfferPriceLong {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Price Short
    /// </summary>
    public unsafe struct OfferPriceShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Price Upper Limit Price Band
    /// </summary>
    public unsafe struct OfferPriceUpperLimitPriceBand {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size Long
    /// </summary>
    public unsafe struct OfferSizeLong {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size Short
    /// </summary>
    public unsafe struct OfferSizeShort {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Participant Id Values
    /// </summary>
    public enum ParticipantId : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        Ltse = (byte)'L',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Cqs = (byte)'S',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Participant Reference Number
    /// </summary>
    public struct ParticipantReferenceNumber {
        public long Raw;
    };


    /// <summary>
    ///  Primary Listing Market Participant Id Values
    /// </summary>
    public enum PrimaryListingMarketParticipantId : byte {
        PrimaryListingMarketParticipantIdNotApplicable = (byte)'Space',
        NyseAmerican = (byte)'A',
        NasdaqOmxBx = (byte)'B',
        NyseNational = (byte)'C',
        FinraAdf = (byte)'D',
        Ise = (byte)'I',
        CboeEdga = (byte)'J',
        CboeEdgx = (byte)'K',
        NyseChicago = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'T',
        Iex = (byte)'V',
        Cbsx = (byte)'W',
        NasdaqOmxPsx = (byte)'X',
        CboeByx = (byte)'Y',
        CboeBzx = (byte)'Z',
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        QuoteConditionNotApplicable = (byte)' ',
        SlowQuoteOnOfferSide = (byte)'A',
        SlowQuoteOnBidSide = (byte)'B',
        Closing = (byte)'C',
        SlowQuoteDueToLrpOrGapQuoteOnTheBidSide = (byte)'E',
        SlowQuoteDueToLrpOrGapQuoteOnTheOfferSide = (byte)'F',
        SlowQuoteOnTheBidAndOfferSides = (byte)'H',
        ClosedMarketMaker = (byte)'L',
        NonFirmQuote = (byte)'N',
        OpeningQuote = (byte)'O',
        RegularFinraOpen = (byte)'R',
        SlowQuoteDueToLiquidityReplenishmentPointOrGapQuoteOnBothTheBidAndOfferSides = (byte)'U',
        SlowQuoteDueToSetSlowListOnBothTheBidAndOfferSides = (byte)'W',
        OnDemandIntraDayAuction = (byte)'4',
    };


    /// <summary>
    ///  Quote Message Type Values
    /// </summary>
    public enum QuoteMessageType : byte {
        AuctionStatusMessage = (byte)'A',
        LongQuoteMessage = (byte)'L',
        ShortQuoteMessage = (byte)'Q',
        SpecialLongQuoteMessage = (byte)'S',
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Retail Interest Indicator Values
    /// </summary>
    public enum RetailInterestIndicator : byte {
        NotApplicable = (byte)' ',
        RetailInterestOnBidQuote = (byte)'A',
        RetailInterestOnOfferQuote = (byte)'B',
        RetailInterestOnBothTheBidAndOfferQuotes = (byte)'C',
    };


    /// <summary>
    ///  Retransmission Indicator Values
    /// </summary>
    public enum RetransmissionIndicator : byte {
        Original = (byte)'O',
        Retransmitted = (byte)'V',
    };


    /// <summary>
    ///  Seconds
    /// </summary>
    public unsafe struct Seconds {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Status Indicator Values
    /// </summary>
    public enum SecurityStatusIndicator : byte {
        NotApplicable = (byte)' ',
        NewsDissemination = (byte)'D',
        TradingRangeIndication = (byte)'G',
        OrderImbalance = (byte)'I',
        LuldTradingPause = (byte)'M',
        NewsPending = (byte)'P',
        Resume = (byte)'T',
        Operational = (byte)'X',
        SupPennyTrading = (byte)'Y',
        NoOpenNoResume = (byte)'Z',
        LuldPriceBand = (byte)'0',
        MarketWideCircuitBreakerLevel1Breached = (byte)'1',
        MarketWideCircuitBreakerLevel2Breached = (byte)'2',
        MarketWideCircuitBreakerLevel3Breached = (byte)'3',
        RepublishedLuldPriceBand = (byte)'9',
    };


    /// <summary>
    ///  Security Symbol Long
    /// </summary>
    public unsafe struct SecuritySymbolLong {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Condition Values
    /// </summary>
    public enum SettlementCondition : byte {
        RegularWaySettlement = (byte)' ',
        CashOnlySettlement = (byte)'A',
        NextDayOnlySettlement = (byte)'B',
    };


    /// <summary>
    ///  Short Sale Restriction Indicator Values
    /// </summary>
    public enum ShortSaleRestrictionIndicator : byte {
        NotInEffect = (byte)' ',
        ShortSaleRestrictionActivated = (byte)'A',
        ShortSaleRestrictionContinued = (byte)'C',
        ShortSaleRestrictionDeactivated = (byte)'D',
        ShortSaleRestrictionInEffect = (byte)'E',
    };


    /// <summary>
    ///  Sip Generated Message Identifier Values
    /// </summary>
    public enum SipGeneratedMessageIdentifier : byte {
        NotApplicable = (byte)' ',
        ConsolidatedQuotationSystem = (byte)'S',
    };


    /// <summary>
    ///  Transaction Id
    /// </summary>
    public unsafe struct TransactionId {
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
    ///  Struct for Adf Timestamp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdfTimestamp {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Administrative
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Administrative {
        AdministrativeMessageType AdministrativeMessageType;
    };


    /// <summary>
    ///  Struct for Administrative Unformatted Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdministrativeUnformattedMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        Text Text;
    };


    /// <summary>
    ///  Struct for Auction Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionStatusMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        SecuritySymbolLong SecuritySymbolLong;
        InstrumentType InstrumentType;
        AuctionCollarReferencePrice AuctionCollarReferencePrice;
        AuctionCollarUpperThresholdPrice AuctionCollarUpperThresholdPrice;
        AuctionCollarLowerThresholdPrice AuctionCollarLowerThresholdPrice;
        NumberOfExtensions NumberOfExtensions;
        ShortSaleRestrictionIndicator ShortSaleRestrictionIndicator;
        PrimaryListingMarketParticipantId PrimaryListingMarketParticipantId;
        FinancialStatusIndicator FinancialStatusIndicator;
        Future Future;
    };


    /// <summary>
    ///  Struct for Block Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BlockHeader {
        Version Version;
        BlockSize BlockSize;
        DataFeedIndicator DataFeedIndicator;
        RetransmissionIndicator RetransmissionIndicator;
        BlockSequenceNumber BlockSequenceNumber;
        MessagesInBlock MessagesInBlock;
        SipBlockTimestamp SipBlockTimestamp;
        BlockChecksum BlockChecksum;
    };


    /// <summary>
    ///  Struct for Disaster Recovery Data Center Activation Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DisasterRecoveryDataCenterActivationMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for End Of Test Cycle Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfTestCycleMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Finra Close Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FinraCloseMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Finra Open Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FinraOpenMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Line Integrity Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LineIntegrityMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Market Wide Circuit Breaker Decline Level Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketWideCircuitBreakerDeclineLevelStatusMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        MwcbLevel1 MwcbLevel1;
        MwcbLevel2 MwcbLevel2;
        MwcbLevel3 MwcbLevel3;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Market Wide Circuit Breaker Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketWideCircuitBreakerStatusMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
        MarketWideCircuitBreakerLevelIndicator MarketWideCircuitBreakerLevelIndicator;
        Reserved Reserved;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        MessageLength MessageLength;
        MessageCategory MessageCategory;
    };


    /// <summary>
    ///  Struct for National Best Bid Long Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NationalBestBidLongAppendage {
        BestBidParticipantId BestBidParticipantId;
        BestBidQuoteCondition BestBidQuoteCondition;
        BestBidPriceLong BestBidPriceLong;
        BestBidSizeLong BestBidSizeLong;
        FinraBestBidMarketMakerId FinraBestBidMarketMakerId;
    };


    /// <summary>
    ///  Struct for National Best Bid Short Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NationalBestBidShortAppendage {
        BestBidParticipantId BestBidParticipantId;
        BestBidPriceShort BestBidPriceShort;
        BestBidSizeShort BestBidSizeShort;
    };


    /// <summary>
    ///  Struct for National Best Offer Long Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NationalBestOfferLongAppendage {
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferQuoteCondition BestOfferQuoteCondition;
        BestOfferPriceLong BestOfferPriceLong;
        BestOfferSizeLong BestOfferSizeLong;
        FinraBestOfferMarketMakerId FinraBestOfferMarketMakerId;
    };


    /// <summary>
    ///  Struct for National Best Offer Short Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NationalBestOfferShortAppendage {
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferPriceShort BestOfferPriceShort;
        BestOfferSizeShort BestOfferSizeShort;
    };


    /// <summary>
    ///  Struct for Participant Timestamp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParticipantTimestamp {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Reset Block Sequence Number Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResetBlockSequenceNumberMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Sip Block Timestamp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SipBlockTimestamp {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfDayMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    /// <summary>
    ///  Struct for Start Of Test Cycle Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfTestCycleMessage {
        ParticipantId ParticipantId;
        ParticipantTimestamp ParticipantTimestamp;
        MessageId MessageId;
        TransactionId TransactionId;
        ParticipantReferenceNumber ParticipantReferenceNumber;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
