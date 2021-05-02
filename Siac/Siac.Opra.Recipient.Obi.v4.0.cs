namespace Siac.Opra.Recipient.Obi.v4.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Bbo Indicator Values
    /// </summary>
    public enum BboIndicator : byte {
        NoBestBidChangeOrBestOfferChange = (byte)'A',
        NoBestBidChangeQuoteContainsBestOffer = (byte)'B',
        NoBestBidChangeBestOfferAppendage = (byte)'C',
        NoBestBidChangeNoBestOffer = (byte)'D',
        QuoteContainsBestBidNoBestOfferChange = (byte)'E',
        QuoteContainsBestBidQuoteContainsBestOffer = (byte)'F',
        QuoteContainsBestBidBestOfferAppendage = (byte)'G',
        QuoteContainsBestBidNoBestOffer = (byte)'H',
        NoBestBidNoBestOfferChange = (byte)'I',
        NoBestBidQuoteContainsBestOffer = (byte)'J',
        NoBestBidBestOfferAppendage = (byte)'K',
        NoBestBidNoBestOffer = (byte)'L',
        BestBidAppendageNoBestOfferChange = (byte)'M',
        BestBidAppendageQuoteContainsBestOffer = (byte)'N',
        BestBidAppendageBestOfferAppendage = (byte)'O',
        BestBidAppendageNoBestOffer = (byte)'P',
        NotIncludedInTheBbo = (byte)' ',
    };


    /// <summary>
    ///  Bid Index Value
    /// </summary>
    public struct BidIndexValue {
        public int Raw;
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public struct BidPrice {
        public int Raw;
    };


    /// <summary>
    ///  Bid Price Short
    /// </summary>
    public struct BidPriceShort {
        public short Raw;
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Size Short
    /// </summary>
    public unsafe struct BidSizeShort {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Checksum
    /// </summary>
    public unsafe struct BlockChecksum {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Pad Byte
    /// </summary>
    public unsafe struct BlockPadByte {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Sequence Number
    /// </summary>
    public unsafe struct BlockSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Size
    /// </summary>
    public unsafe struct BlockSize {
        public const int Size = 2;

        public short Value;

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
    ///  Index Value Denominator Code Values
    /// </summary>
    public enum IndexValueDenominatorCode : byte {
        Ten = (byte)'A',
        Hundred = (byte)'B',
        Thousand = (byte)'C',
        TenThousand = (byte)'D',
        HundredThousand = (byte)'E',
        Million = (byte)'F',
        TenMillion = (byte)'G',
        NoFraction = (byte)'I',
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
        EquityAndIndexEndOfDaySummaryMessage = (byte)'f',
        LongEquityAndIndexQuoteMessage = (byte)'k',
        ShortEquityAndIndexQuoteMessage = (byte)'q',
        AdministrativeMessage = (byte)'C',
        ControlMessage = (byte)'H',
        UnderlyingValueMessage = (byte)'Y',
    };


    /// <summary>
    ///  Message Data
    /// </summary>
    public unsafe struct MessageData {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Message Indicator
    /// </summary>
    public unsafe struct MessageIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type
    /// </summary>
    public unsafe struct MessageType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Messages In Block
    /// </summary>
    public unsafe struct MessagesInBlock {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Net Change
    /// </summary>
    public struct NetChange {
        public int Raw;
    };


    /// <summary>
    ///  Offer Index Value
    /// </summary>
    public struct OfferIndexValue {
        public long Raw;
    };


    /// <summary>
    ///  Offer Price
    /// </summary>
    public struct OfferPrice {
        public int Raw;
    };


    /// <summary>
    ///  Offer Price Short
    /// </summary>
    public struct OfferPriceShort {
        public short Raw;
    };


    /// <summary>
    ///  Offer Size
    /// </summary>
    public unsafe struct OfferSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Size Short
    /// </summary>
    public unsafe struct OfferSizeShort {
        public const int Size = 2;

        public short Value;

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
        CboeOptionsExchange = (byte)'C',
        MiaxEmerald = (byte)'D',
        CboeEdgxOptions = (byte)'E',
        NasdaqGemx = (byte)'H',
        NasdaqIse = (byte)'I',
        NasdaqMrx = (byte)'J',
        MiamiInternationalSecuritiesExchange = (byte)'M',
        NyseArca = (byte)'N',
        OptionsPriceReportingAuthority = (byte)'O',
        MiaxPearl = (byte)'P',
        NasdaqOptionsMarket = (byte)'Q',
        NasdaqBxOptions = (byte)'T',
        CboeC2Options = (byte)'W',
        NasdaqPhlx = (byte)'X',
        CboeBzxOptionsExchange = (byte)'Z',
    };


    /// <summary>
    ///  Premium Price
    /// </summary>
    public struct PremiumPrice {
        public int Raw;
    };


    /// <summary>
    ///  Premium Price Denominator Code Values
    /// </summary>
    public enum PremiumPriceDenominatorCode : byte {
        Ten = (byte)'A',
        Hundred = (byte)'B',
        Thousand = (byte)'C',
        TenThousand = (byte)'D',
        HundredThousand = (byte)'E',
        Million = (byte)'F',
        TenMillion = (byte)'G',
        NoFraction = (byte)'I',
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
    ///  Seconds
    /// </summary>
    public unsafe struct Seconds {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol Short
    /// </summary>
    public unsafe struct SecuritySymbolShort {
        public const int Size = 4;

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
    ///  Strike Price
    /// </summary>
    public unsafe struct StrikePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Denominator Code Values
    /// </summary>
    public enum StrikePriceDenominatorCode : byte {
        Ten = (byte)'A',
        Hundred = (byte)'B',
        Thousand = (byte)'C',
        TenThousand = (byte)'D',
        HundredThousand = (byte)'E',
        NoFraction = (byte)'I',
    };


    /// <summary>
    ///  Strike Price Short
    /// </summary>
    public unsafe struct StrikePriceShort {
        public const int Size = 2;

        public short Value;

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
    ///  Transaction Id
    /// </summary>
    public unsafe struct TransactionId {
        public const int Size = 8;

        public long Value;

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
    ///  Underlying Price Denominator Code Values
    /// </summary>
    public enum UnderlyingPriceDenominatorCode : byte {
        Ten = (byte)'A',
        Hundred = (byte)'B',
        Thousand = (byte)'C',
        TenThousand = (byte)'D',
        HundredThousand = (byte)'E',
        Million = (byte)'F',
        TenMillion = (byte)'G',
        HundredMillion = (byte)'H',
        NoFraction = (byte)'I',
    };


    /// <summary>
    ///  Underlying Value Message Type Values
    /// </summary>
    public enum UnderlyingValueMessageType : byte {
        UnderlyingValueLastSaleMessage = (byte)' ',
        UnderlyingValueBidAndOfferMessage = (byte)'I',
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Struct for Administrative Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdministrativeMessage {
        MessageType MessageType;
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        MessageDataLength MessageDataLength;
    };


    /// <summary>
    ///  Struct for Best Bid Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestBidAppendage {
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Best Offer Appendage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BestOfferAppendage {
        ParticipantId ParticipantId;
        DenominatorCode DenominatorCode;
        Price Price;
        Size Size;
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
        SessionIndicator SessionIndicator;
        BlockSequenceNumber BlockSequenceNumber;
        MessagesInBlock MessagesInBlock;
        BlockTimestamp BlockTimestamp;
        BlockChecksum BlockChecksum;
    };


    /// <summary>
    ///  Struct for Block Timestamp
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BlockTimestamp {
        Seconds Seconds;
        Nanoseconds Nanoseconds;
    };


    /// <summary>
    ///  Struct for Control Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ControlMessage {
        ControlMessageType ControlMessageType;
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        MessageDataLength MessageDataLength;
    };


    /// <summary>
    ///  Struct for Equity And Index End Of Day Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquityAndIndexEndOfDaySummaryMessage {
        MessageType MessageType;
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        SecuritySymbol SecuritySymbol;
        Reserved1 Reserved1;
        ExpirationBlock ExpirationBlock;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice StrikePrice;
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
        BidPrice BidPrice;
        OfferPrice OfferPrice;
    };


    /// <summary>
    ///  Struct for Equity And Index Last Sale Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EquityAndIndexLastSaleMessage {
        TradeMessageType TradeMessageType;
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        SecuritySymbol SecuritySymbol;
        Reserved1 Reserved1;
        ExpirationBlock ExpirationBlock;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice StrikePrice;
        Volume Volume;
        PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        PremiumPrice PremiumPrice;
        TradeIdentifier TradeIdentifier;
        Reserved4 Reserved4;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        ParticipantId ParticipantId;
        MessageCategory MessageCategory;
    };


    /// <summary>
    ///  Struct for Open Interest Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenInterestMessage {
        MessageType MessageType;
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        SecuritySymbol SecuritySymbol;
        Reserved1 Reserved1;
        ExpirationBlock ExpirationBlock;
        StrikePriceDenominatorCode StrikePriceDenominatorCode;
        StrikePrice StrikePrice;
        OpenInterestVolume OpenInterestVolume;
    };


    /// <summary>
    ///  Struct for Underlying Value Bid And Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingValueBidAndOfferMessage {
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        SecuritySymbol SecuritySymbol;
        Reserved1 Reserved1;
        IndexValueDenominatorCode IndexValueDenominatorCode;
        BidIndexValue BidIndexValue;
        OfferIndexValue OfferIndexValue;
    };


    /// <summary>
    ///  Struct for Underlying Value Last Sale Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingValueLastSaleMessage {
        MessageIndicator MessageIndicator;
        TransactionId TransactionId;
        SecuritySymbol SecuritySymbol;
        Reserved1 Reserved1;
        IndexValueDenominatorCode IndexValueDenominatorCode;
        IndexValue IndexValue;
        Reserved4 Reserved4;
    };


    /// <summary>
    ///  Struct for Underlying Value Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingValueMessage {
        UnderlyingValueMessageType UnderlyingValueMessageType;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
