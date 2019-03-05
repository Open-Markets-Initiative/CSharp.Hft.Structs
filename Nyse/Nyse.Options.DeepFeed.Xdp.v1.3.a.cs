namespace MyNamespace {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

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
    ///  Contract Multiplier
    /// </summary>
    public unsafe struct ContractMultiplier {
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
    ///  Exchange Code Values
    /// </summary>
    public enum ExchangeCode : byte {
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        NyseMkt = (byte)'A',
        GlobalOtc = (byte)'1',
        ArcaLocalNontapebIndex = (byte)'2',
    };


    /// <summary>
    ///  First Level Customer Volume
    /// </summary>
    public unsafe struct FirstLevelCustomerVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  First Level Price
    /// </summary>
    public struct FirstLevelPrice {
        public int Raw;
    };


    /// <summary>
    ///  First Level Volume
    /// </summary>
    public unsafe struct FirstLevelVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  First Volume
    /// </summary>
    public unsafe struct FirstVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Group Id
    /// </summary>
    public unsafe struct GroupId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Halt Condition
    /// </summary>
    public unsafe struct HaltCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Id Values
    /// </summary>
    public enum MarketId : ushort {
        NyseCash = 1,
        EuropeCash = 2,
        NyseArcaCash = 3,
        NyseArcaOptions = 4,
        NyseArcaBonds = 5,
        ArcaEdge = 6,
        Liffe = 7,
        NyseAmericanOptions = 8,
        NyseMktCash = 9,
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
        OutrightMarketDepthBuyMessage = 403,
        OutrightMarketDepthSellMessage = 405,
        UnderlyingStatusMessage = 419,
        OutrightSeriesStatusMessage = 421,
        RefreshOutrightMarketDepthBuyMessage = 503,
        RefreshOutrightMarketDepthSellMessage = 505,
        UnderlyingIndexMappingMessage = 435,
        SeriesIndexMappingMessage = 437,
        StreamIdMessage = 455,
        SequenceNumberResetMessage = 1,
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
    ///  Option Symbol Root
    /// </summary>
    public unsafe struct OptionSymbolRoot {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = 0,
        Call = 1,
    };


    /// <summary>
    ///  Quote Condition Values
    /// </summary>
    public enum QuoteCondition : byte {
        RegularTrading = (byte)'1',
        Rotation = (byte)'2',
        TradingHalted = (byte)'3',
        Preopen = (byte)'4',
        RotationLegalWidthQuotePending = (byte)'5',
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
    ///  Reserved A 1
    /// </summary>
    public unsafe struct ReservedA1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved B 1
    /// </summary>
    public unsafe struct ReservedB1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Second Level Customer Volume
    /// </summary>
    public unsafe struct SecondLevelCustomerVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Second Level Price
    /// </summary>
    public struct SecondLevelPrice {
        public int Raw;
    };


    /// <summary>
    ///  Second Level Volume
    /// </summary>
    public unsafe struct SecondLevelVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Second Volume
    /// </summary>
    public unsafe struct SecondVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        LightUpADarkSeries = (byte)'L',
        OpenADarkSeries = (byte)'N',
        Open = (byte)'O',
        Close = (byte)'X',
        Halt = (byte)'S',
        Unhalt = (byte)'U',
        UnhaltADarkSeries = (byte)'T',
        EndOfRfqAuction = (byte)'Q',
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
        AmericanDepositoryShares = (byte)'H',
        Units = (byte)'I',
        MiscliquidTrust = (byte)'M',
        OrdinaryShares = (byte)'O',
        PreferredStock = (byte)'P',
        Rights = (byte)'R',
        SharesOfBeneficiaryInterest = (byte)'S',
        Test = (byte)'T',
        Units = (byte)'U',
        Warrant = (byte)'W',
        Index = (byte)'X',
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
    ///  Series Index
    /// </summary>
    public unsafe struct SeriesIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Source Ns
    /// </summary>
    public unsafe struct SourceNs {
        public const int Size = 4;

        public int Value;

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
    ///  Stream Id
    /// </summary>
    public unsafe struct StreamId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public unsafe struct StrikePrice {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Third Level Customer Volume
    /// </summary>
    public unsafe struct ThirdLevelCustomerVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Third Level Price
    /// </summary>
    public struct ThirdLevelPrice {
        public int Raw;
    };


    /// <summary>
    ///  Third Level Volume
    /// </summary>
    public unsafe struct ThirdLevelVolume {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Third Volume
    /// </summary>
    public unsafe struct ThirdVolume {
        public const int Size = 2;

        public short Value;

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
    ///  Underlying Index
    /// </summary>
    public unsafe struct UnderlyingIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Seq Num
    /// </summary>
    public unsafe struct UnderlyingSeqNum {
        public const int Size = 4;

        public int Value;

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


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

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
    ///  Struct for Outright Market Depth Buy Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightMarketDepthBuyMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        FirstLevelPrice FirstLevelPrice;
        SecondLevelPrice SecondLevelPrice;
        ThirdLevelPrice ThirdLevelPrice;
        FirstLevelVolume FirstLevelVolume;
        SecondLevelVolume SecondLevelVolume;
        ThirdLevelVolume ThirdLevelVolume;
        QuoteCondition QuoteCondition;
        Reserved1 Reserved1;
        FirstLevelCustomerVolume FirstLevelCustomerVolume;
        SecondLevelCustomerVolume SecondLevelCustomerVolume;
        ThirdLevelCustomerVolume ThirdLevelCustomerVolume;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Outright Market Depth Sell Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightMarketDepthSellMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        FirstLevelPrice FirstLevelPrice;
        SecondLevelPrice SecondLevelPrice;
        ThirdLevelPrice ThirdLevelPrice;
        FirstVolume FirstVolume;
        SecondVolume SecondVolume;
        ThirdVolume ThirdVolume;
        QuoteCondition QuoteCondition;
        Reserved1 Reserved1;
        FirstLevelCustomerVolume FirstLevelCustomerVolume;
        SecondLevelCustomerVolume SecondLevelCustomerVolume;
        ThirdLevelCustomerVolume ThirdLevelCustomerVolume;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Outright Series Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightSeriesStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved2 Reserved2;
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
    ///  Struct for Refresh Outright Market Depth Buy Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshOutrightMarketDepthBuyMessage {
        SourceTime SourceTime;
        SourceNs SourceNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        FirstLevelPrice FirstLevelPrice;
        SecondLevelPrice SecondLevelPrice;
        ThirdLevelPrice ThirdLevelPrice;
        FirstVolume FirstVolume;
        SecondVolume SecondVolume;
        ThirdVolume ThirdVolume;
        QuoteCondition QuoteCondition;
        Reserved1 Reserved1;
        FirstLevelCustomerVolume FirstLevelCustomerVolume;
        SecondLevelCustomerVolume SecondLevelCustomerVolume;
        ThirdLevelCustomerVolume ThirdLevelCustomerVolume;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Refresh Outright Market Depth Sell Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RefreshOutrightMarketDepthSellMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        SeriesIndex SeriesIndex;
        SymbolSeqNum SymbolSeqNum;
        FirstLevelPrice FirstLevelPrice;
        SecondLevelPrice SecondLevelPrice;
        ThirdLevelPrice ThirdLevelPrice;
        FirstVolume FirstVolume;
        SecondVolume SecondVolume;
        ThirdVolume ThirdVolume;
        QuoteCondition QuoteCondition;
        Reserved1 Reserved1;
        FirstLevelCustomerVolume FirstLevelCustomerVolume;
        SecondLevelCustomerVolume SecondLevelCustomerVolume;
        ThirdLevelCustomerVolume ThirdLevelCustomerVolume;
        Reserved2 Reserved2;
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
    ///  Struct for Series Index Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SeriesIndexMappingMessage {
        SeriesIndex SeriesIndex;
        ChannelId ChannelId;
        ReservedA1 ReservedA1;
        MarketId MarketId;
        SystemId SystemId;
        ReservedB1 ReservedB1;
        StreamId StreamId;
        UnderlyingIndex UnderlyingIndex;
        ContractMultiplier ContractMultiplier;
        MaturityDate MaturityDate;
        PutOrCall PutOrCall;
        StrikePrice StrikePrice;
        PriceScaleCode PriceScaleCode;
        UnderlyingSymbol UnderlyingSymbol;
        OptionSymbolRoot OptionSymbolRoot;
        GroupId GroupId;
    };


    /// <summary>
    ///  Struct for Stream Id Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamIdMessage {
        StreamId StreamId;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Underlying Index Mapping Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingIndexMappingMessage {
        UnderlyingIndex UnderlyingIndex;
        UnderlyingSymbol UnderlyingSymbol;
        ChannelId ChannelId;
        MarketId MarketId;
        SystemId SystemId;
        ExchangeCode ExchangeCode;
        PriceScaleCode PriceScaleCode;
        SecurityType SecurityType;
        PriceResolution PriceResolution;
        Reserved1 Reserved1;
    };


    /// <summary>
    ///  Struct for Underlying Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingStatusMessage {
        SourceTime SourceTime;
        SourceTimeNs SourceTimeNs;
        UnderlyingIndex UnderlyingIndex;
        UnderlyingSeqNum UnderlyingSeqNum;
        SecurityStatus SecurityStatus;
        HaltCondition HaltCondition;
        Reserved2 Reserved2;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
