namespace Opra.Options.Recipient.Obdi.v2.9 {

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
    ///  Best Bid Denominator Code
    /// </summary>
    public unsafe struct BestBidDenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Bid Participant Id
    /// </summary>
    public unsafe struct BestBidParticipantId {
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
    public struct BestBidPrice {
        public int Raw;
    };


    /// <summary>
    ///  Best Bid Size
    /// </summary>
    public unsafe struct BestBidSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Denominator Code
    /// </summary>
    public unsafe struct BestOfferDenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Participant Id
    /// </summary>
    public unsafe struct BestOfferParticipantId {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Best Offer Price
    /// </summary>
    public struct BestOfferPrice {
        public int Raw;
    };


    /// <summary>
    ///  Best Offer Size
    /// </summary>
    public unsafe struct BestOfferSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price 2
    /// </summary>
    public struct BidPrice2 {
        public short Raw;
    };


    /// <summary>
    ///  Bid Price 4
    /// </summary>
    public struct BidPrice4 {
        public int Raw;
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
    ///  Block Seq Num
    /// </summary>
    public unsafe struct BlockSeqNum {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Checksum
    /// </summary>
    public unsafe struct Checksum {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Denominator Code
    /// </summary>
    public unsafe struct DenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Day
    /// </summary>
    public unsafe struct ExpirationDay {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Month Values
    /// </summary>
    public enum ExpirationMonth : byte {
        January = (byte)'A',
        January = (byte)'M',
        February = (byte)'B',
        February = (byte)'N',
        March = (byte)'C',
        March = (byte)'O',
        April = (byte)'D',
        April = (byte)'P',
        May = (byte)'E',
        May = (byte)'Q',
        June = (byte)'F',
        June = (byte)'R',
        July = (byte)'G',
        July = (byte)'S',
        August = (byte)'H',
        August = (byte)'T',
        September = (byte)'I',
        September = (byte)'U',
        October = (byte)'J',
        October = (byte)'V',
        November = (byte)'K',
        November = (byte)'W',
        December = (byte)'L',
        December = (byte)'X',
    };


    /// <summary>
    ///  Expiration Year
    /// </summary>
    public unsafe struct ExpirationYear {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  High Price
    /// </summary>
    public struct HighPrice {
        public int Raw;
    };


    /// <summary>
    ///  Index Value
    /// </summary>
    public struct IndexValue {
        public int Raw;
    };


    /// <summary>
    ///  Index Value Denominator Code
    /// </summary>
    public unsafe struct IndexValueDenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Price
    /// </summary>
    public struct LastPrice {
        public int Raw;
    };


    /// <summary>
    ///  Low Price
    /// </summary>
    public struct LowPrice {
        public int Raw;
    };


    /// <summary>
    ///  Message Category Values
    /// </summary>
    public enum MessageCategory : byte {
        EquityAndIndexLastSaleMessage = (byte)'a',
        OpenInterestMessage = (byte)'d',
        EquityEodMessage = (byte)'f',
        LongQuoteAMessage = (byte)'k',
        LongQuoteBMessage = (byte)'k',
        LongQuoteCMessage = (byte)'k',
        LongQuoteDMessage = (byte)'k',
        LongQuoteEMessage = (byte)'k',
        LongQuoteFMessage = (byte)'k',
        LongQuoteGMessage = (byte)'k',
        LongQuoteHMessage = (byte)'k',
        LongQuoteIMessage = (byte)'k',
        LongQuoteJMessage = (byte)'k',
        LongQuoteKMessage = (byte)'k',
        LongQuoteLMessage = (byte)'k',
        LongQuoteMMessage = (byte)'k',
        LongQuoteNMessage = (byte)'k',
        LongQuoteOMessage = (byte)'k',
        LongQuotePMessage = (byte)'k',
        LongQuoteSpaceMessage = (byte)'k',
        ShortQuoteAMessage = (byte)'q',
        ShortQuoteBMessage = (byte)'q',
        ShortQuoteCMessage = (byte)'q',
        ShortQuoteDMessage = (byte)'q',
        ShortQuoteEMessage = (byte)'q',
        ShortQuoteFMessage = (byte)'q',
        ShortQuoteGMessage = (byte)'q',
        ShortQuoteHMessage = (byte)'q',
        ShortQuoteIMessage = (byte)'q',
        ShortQuoteJMessage = (byte)'q',
        ShortQuoteKMessage = (byte)'q',
        ShortQuoteLMessage = (byte)'q',
        ShortQuoteMMessage = (byte)'q',
        ShortQuoteNMessage = (byte)'q',
        ShortQuoteOMessage = (byte)'q',
        ShortQuotePMessage = (byte)'q',
        ShortQuoteSpaceMessage = (byte)'q',
        AdministrativeMessage = (byte)'C',
        ControlMessage = (byte)'H',
        UnderlyingValueMessage = (byte)'Y',
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Data
    /// </summary>
    public unsafe struct MessageData {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Data Length
    /// </summary>
    public unsafe struct MessageDataLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Net Change
    /// </summary>
    public struct NetChange {
        public int Raw;
    };


    /// <summary>
    ///  Offer Price 2
    /// </summary>
    public struct OfferPrice2 {
        public short Raw;
    };


    /// <summary>
    ///  Offer Price 4
    /// </summary>
    public struct OfferPrice4 {
        public int Raw;
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
    ///  Open Interest Volume
    /// </summary>
    public unsafe struct OpenInterestVolume {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Price
    /// </summary>
    public struct OpenPrice {
        public int Raw;
    };


    /// <summary>
    ///  Participant Id Values
    /// </summary>
    public enum ParticipantId : byte {
        NyseAmerican = (byte)'A',
        BostonOptionsExchange = (byte)'B',
        ChicagoBoardOptionsExchange = (byte)'C',
        MiaxEmerald = (byte)'D',
        EdgxOptions = (byte)'E',
        IseGemini = (byte)'H',
        InternationalSecuritiesExchange = (byte)'I',
        IseMercuryExchange = (byte)'J',
        MiamiInternationalSecuritiesExchange = (byte)'M',
        NyseArca = (byte)'N',
        OptionsPriceReportingAuthority = (byte)'O',
        MiaxPearl = (byte)'P',
        NasdaqStockMarket = (byte)'Q',
        NasdaqOmxBxOptions = (byte)'T',
        C2 = (byte)'W',
        NasdaqOmxPhlx = (byte)'X',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Premium Price
    /// </summary>
    public struct PremiumPrice {
        public int Raw;
    };


    /// <summary>
    ///  Premium Price Denominator Code
    /// </summary>
    public unsafe struct PremiumPriceDenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

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
    ///  Retransmission Indicator
    /// </summary>
    public unsafe struct RetransmissionIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol 4
    /// </summary>
    public unsafe struct SecuritySymbol4 {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol 5
    /// </summary>
    public unsafe struct SecuritySymbol5 {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Indicator Values
    /// </summary>
    public enum SessionIndicator : byte {
        Regular = 0,
        PreMarket = 88,
    };


    /// <summary>
    ///  Size
    /// </summary>
    public unsafe struct Size {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price 2
    /// </summary>
    public unsafe struct StrikePrice2 {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price 4
    /// </summary>
    public unsafe struct StrikePrice4 {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Denominator Code
    /// </summary>
    public unsafe struct StrikePriceDenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Identifier
    /// </summary>
    public unsafe struct TradeIdentifier {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transaction ID
    /// </summary>
    public unsafe struct TransactionId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Price
    /// </summary>
    public struct UnderlyingPrice {
        public long Raw;
    };


    /// <summary>
    ///  Underlying Price Denominator Code
    /// </summary>
    public unsafe struct UnderlyingPriceDenominatorCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Volume Values
    /// </summary>
    public enum Volume : uint {
        NyseAmerican = A,
        Box = B,
        Cboe = C,
        Edgx = E,
        Gemini = H,
        Ise = I,
        Mercury = J,
        Miax = M,
        NyseArca = N,
        Opra = O,
        MiaxPearl = P,
        Nasdaq = Q,
        C2 = W,
        NasdaqBx = T,
        NasdaqPhlx = X,
        Bats = Z,
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for ADMINISTRATIVE Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdministrativeCategory {
        AdministrativeMessageType AdministrativeMessageType;
        AdministrativeMessageIndicator AdministrativeMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Administrative Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdministrativeMessage {
        MessageDataLength MessageDataLength;
    };


    /// <summary>
    ///  Struct for CONTROL Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ControlCategory {
        ControlMessageType ControlMessageType;
        ControlMessageIndicator ControlMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Control Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ControlMessage {
        MessageDataLength MessageDataLength;
    };


    /// <summary>
    ///  Struct for Equity And Index Last Sale Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquityAndIndexLastSaleMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        Volume Volume;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        PremiumPrice PremiumPrice;
        TradeIdentifier TradeIdentifier;
        Reserved4 Reserved4;
    };


    /// <summary>
    ///  Struct for Equity EOD Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquityEodCategory {
        EquityEodMessageType EquityEodMessageType;
        EquityEodMessageIndicator EquityEodMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Equity Eod Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquityEodMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        Volume Volume;
        OpenInterestVolume OpenInterestVolume;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        OpenPrice OpenPrice;
        HighPrice HighPrice;
        LowPrice LowPrice;
        LastPrice LastPrice;
        NetChange NetChange;
        UnderlyingPriceDenominatorCode UnderlyingPriceDenominatorCode;
        UnderlyingPrice UnderlyingPrice;
        BidPrice4 BidPrice4;
        OfferPrice4 OfferPrice4;
    };


    /// <summary>
    ///  Struct for Equity Index Last Sale Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquityIndexLastSaleCategory {
        EquityIndexLastSaleMessageType EquityIndexLastSaleMessageType;
        EquityIndexLastSaleMessageIndicator EquityIndexLastSaleMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Long Quote A Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteAMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote B Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteBMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote C Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteCMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Long Quote Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteCategory {
        LongQuoteMessageType LongQuoteMessageType;
        LongQuoteMessageIndicator LongQuoteMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Long Quote D Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteDMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote E Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteEMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote F Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteFMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote G Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteGMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Long Quote H Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteHMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote I Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteIMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote J Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteJMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote K Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteKMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Long Quote L Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteLMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote M Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteMMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        BestBidParticipantId BestBidParticipantId;
        BestBidDenominatorCode BestBidDenominatorCode;
        BestBidPrice4 BestBidPrice4;
        BestBidSize BestBidSize;
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferDenominatorCode BestOfferDenominatorCode;
        BestOfferPrice BestOfferPrice;
        BestOfferSize BestOfferSize;
    };


    /// <summary>
    ///  Struct for Long Quote N Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteNMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        BestBidParticipantId BestBidParticipantId;
        BestBidDenominatorCode BestBidDenominatorCode;
        BestBidPrice BestBidPrice;
        BestBidSize BestBidSize;
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferDenominatorCode BestOfferDenominatorCode;
        BestOfferPrice BestOfferPrice;
        BestOfferSize BestOfferSize;
    };


    /// <summary>
    ///  Struct for Long Quote O Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteOMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Long Quote P Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuotePMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
        BestBidParticipantId BestBidParticipantId;
        BestBidDenominatorCode BestBidDenominatorCode;
        BestBidPrice BestBidPrice;
        BestBidSize BestBidSize;
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferDenominatorCode BestOfferDenominatorCode;
        BestOfferPrice BestOfferPrice;
        BestOfferSize BestOfferSize;
    };


    /// <summary>
    ///  Struct for Long Quote Space Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongQuoteSpaceMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        BidPrice4 BidPrice4;
        BidSize4 BidSize4;
        OfferPrice4 OfferPrice4;
        OfferSize4 OfferSize4;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        ParticipantId ParticipantId;
        MessageCategory MessageCategory;
    };


    /// <summary>
    ///  Struct for Open Interest Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenInterestCategory {
        OpenInterestMessageType OpenInterestMessageType;
        OpenInterestMessageIndicator OpenInterestMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Open Interest Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenInterestMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice4 StrikePrice4;
        OpenInterestVolume OpenInterestVolume;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        Version Version;
        Size Size;
        DataFeedIndicator DataFeedIndicator;
        RetransmissionIndicator RetransmissionIndicator;
        SessionIndicator SessionIndicator;
        BlockSeqNum BlockSeqNum;
        MessageCount MessageCount;
        BlockTimestamp BlockTimestamp;
        Checksum Checksum;
    };


    /// <summary>
    ///  Struct for Short Quote A Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteAMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote B Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteBMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote C Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteCMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Short Quote Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteCategory {
        ShortQuoteMessageType ShortQuoteMessageType;
        ShortQuoteMessageIndicator ShortQuoteMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Short Quote D Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteDMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote E Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteEMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote F Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteFMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote G Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteGMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Short Quote H Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteHMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote I Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteIMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote J Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteJMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote K Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteKMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Short Quote L Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteLMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote M Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteMMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        BestBidParticipantId BestBidParticipantId;
        BestBidDenominatorCode BestBidDenominatorCode;
        BestBidPrice BestBidPrice;
        BestBidSize BestBidSize;
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferDenominatorCode BestOfferDenominatorCode;
        BestOfferPrice BestOfferPrice;
        BestOfferSize BestOfferSize;
    };


    /// <summary>
    ///  Struct for Short Quote N Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteNMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice BidPrice;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        BestBidParticipantId BestBidParticipantId;
        BestBidDenominatorCode BestBidDenominatorCode;
        BestBidPrice BestBidPrice;
        BestBidSize BestBidSize;
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferDenominatorCode BestOfferDenominatorCode;
        BestOfferPrice BestOfferPrice;
        BestOfferSize BestOfferSize;
    };


    /// <summary>
    ///  Struct for Short Quote O Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteOMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for Short Quote P Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuotePMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
        BestBidParticipantId BestBidParticipantId;
        BestBidDenominatorCode BestBidDenominatorCode;
        BestBidPrice BestBidPrice;
        BestBidSize BestBidSize;
        BestOfferParticipantId BestOfferParticipantId;
        BestOfferDenominatorCode BestOfferDenominatorCode;
        BestOfferPrice BestOfferPrice;
        BestOfferSize BestOfferSize;
    };


    /// <summary>
    ///  Struct for Short Quote Space Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteSpaceMessage {
        SecuritySymbol4 SecuritySymbol4;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExpirationYear ExpirationYear;
        StrikePrice2 StrikePrice2;
        BidPrice2 BidPrice2;
        BidSize2 BidSize2;
        OfferPrice2 OfferPrice2;
        OfferSize2 OfferSize2;
    };


    /// <summary>
    ///  Struct for UNDERLYING VALUE Category
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingValueCategory {
        UnderlyingValueMessageType UnderlyingValueMessageType;
        UnderlyingValueMessageIndicator UnderlyingValueMessageIndicator;
        TransactionId TransactionId;
    };


    /// <summary>
    ///  Struct for Underlying Value Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingValueMessage {
        SecuritySymbol5 SecuritySymbol5;
        Reserved1 Reserved1;
        IndexValueDenominatorCode IndexValueDenominatorCode;
        IndexValue IndexValue;
        Reserved4 Reserved4;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
