namespace Miax.Pearl.Equities.DepthOfMarket.Mach.v1.3.a {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Attributable Id
    /// </summary>
    public unsafe struct AttributableId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Correction Number
    /// </summary>
    public unsafe struct CorrectionNumber {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Do M Version
    /// </summary>
    public unsafe struct DoMVersion {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Market State Values
    /// </summary>
    public enum MarketState : byte {
        PreOpening = 1,
        EarlyTrading = 2,
        RegularTrading = 3,
        AfterHoursTrading = 4,
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemTimeMessage = (byte)'49',
        SymbolUpdateMessage = (byte)'1',
        SystemStateMessage = (byte)'83',
        SecurityTradingStatusNotificationMessage = (byte)'4',
        SymbolClearMessage = (byte)'5',
        AddOrderMessage = (byte)'20',
        ModifyOrderMessage = (byte)'21',
        DeleteOrderMessage = (byte)'23',
        OrderExecutionMessage = (byte)'24',
        TradeMessage = (byte)'10',
        TradeCancelMessage = (byte)'11',
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
    ///  Order Id
    /// </summary>
    public unsafe struct OrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Position
    /// </summary>
    public unsafe struct OrderPosition {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Side Values
    /// </summary>
    public enum OrderSide : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
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
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Primary Market Code Values
    /// </summary>
    public enum PrimaryMarketCode : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        MiaxPearlEquities = (byte)'H',
        NasdaqIse = (byte)'I',
        CboeEdgaExchange = (byte)'J',
        CboeEdgxExchange = (byte)'K',
        LongTermStockExchange = (byte)'L',
        NyseChicago = (byte)'M',
        NewYorkStockExchange = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        MembersExchange = (byte)'U',
        InvestorsExchange = (byte)'V',
        CboeStockExchange = (byte)'W',
        NasdaqPhlx = (byte)'X',
        CboeByxExchange = (byte)'Y',
        CboeBzxExchange = (byte)'Z',
    };


    /// <summary>
    ///  Reportable
    /// </summary>
    public unsafe struct Reportable {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public sbyte Value;

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
        public const int Size = 1;

        public sbyte Value;

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
    ///  Short Sale Restriction Values
    /// </summary>
    public enum ShortSaleRestriction : byte {
        SsrInEffect = (byte)'Y',
        SsrNotInEffect = (byte)'N',
    };


    /// <summary>
    ///  Size
    /// </summary>
    public unsafe struct Size {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Id
    /// </summary>
    public unsafe struct SymbolId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Status Values
    /// </summary>
    public enum SystemStatus : byte {
        Start = (byte)'S',
        End = (byte)'C',
        Start = (byte)'1',
        End = (byte)'2',
    };


    /// <summary>
    ///  Test Security Indicator Values
    /// </summary>
    public enum TestSecurityIndicator : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Ticker Symbol
    /// </summary>
    public unsafe struct TickerSymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        PreOpen = 1,
        Trading = 2,
        Halt = 3,
        OperationalHalt = 4,
        Closed = 5,
    };


    /// <summary>
    ///  Undefined
    /// </summary>
    public unsafe struct Undefined {
        public const int Size = 7;

        public fixed byte Bytes[Size];
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
        Timestamp Timestamp;
        SymbolId SymbolId;
        OrderId OrderId;
        OrderSide OrderSide;
        Price Price;
        Size Size;
        AttributableId AttributableId;
    };


    /// <summary>
    ///  Struct for Application Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApplicationMessage {
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Delete Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeleteOrderMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        OrderId OrderId;
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
    ///  Struct for Modify Order Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderFlags {
        Undefined Undefined;
        OrderPosition OrderPosition;
    };


    /// <summary>
    ///  Struct for Modify Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        OrderId OrderId;
        Price Price;
        Size Size;
        ModifyOrderFlags ModifyOrderFlags;
    };


    /// <summary>
    ///  Struct for Order Execution Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionFlags {
        Undefined Undefined;
        Reportable Reportable;
    };


    /// <summary>
    ///  Struct for Order Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        OrderId OrderId;
        TradeId TradeId;
        Price Price;
        Size Size;
        OrderExecutionFlags OrderExecutionFlags;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
    };


    /// <summary>
    ///  Struct for Security Trading Status Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityTradingStatusNotificationMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        TradingStatus TradingStatus;
        MarketState MarketState;
        ShortSaleRestriction ShortSaleRestriction;
    };


    /// <summary>
    ///  Struct for Symbol Clear Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolClearMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
    };


    /// <summary>
    ///  Struct for Symbol Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SymbolUpdateMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        TickerSymbol TickerSymbol;
        Reserved Reserved;
        TestSecurityIndicator TestSecurityIndicator;
        Reserved Reserved;
        LotSize LotSize;
        OpeningTime OpeningTime;
        ClosingTime ClosingTime;
        PrimaryMarketCode PrimaryMarketCode;
    };


    /// <summary>
    ///  Struct for System State Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemStateMessage {
        Timestamp Timestamp;
        DoMVersion DoMVersion;
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
    ///  Struct for Trade Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        TradeId TradeId;
        CorrectionNumber CorrectionNumber;
        Price Price;
        Size Size;
    };


    /// <summary>
    ///  Struct for Trade Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeFlags {
        Undefined Undefined;
        Reportable Reportable;
    };


    /// <summary>
    ///  Struct for Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeMessage {
        Timestamp Timestamp;
        SymbolId SymbolId;
        TradeId TradeId;
        CorrectionNumber CorrectionNumber;
        Price Price;
        Size Size;
        TradeFlags TradeFlags;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
