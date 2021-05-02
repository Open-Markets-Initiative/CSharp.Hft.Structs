namespace Nasdaq.Psx.Orders.Ouch.v4.2 {

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
    ///  Aiq Canceled Reason
    /// </summary>
    public unsafe struct AiqCanceledReason {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bbo Weight Indicator Values
    /// </summary>
    public enum BboWeightIndicator : byte {
        002 = (byte)'0',
        021 = (byte)'1',
        12 = (byte)'2',
        GreaterThan2 = (byte)'3',
        SetsTheQbbo = (byte)'S',
        ImprovesTheNbbo = (byte)'N',
    };


    /// <summary>
    ///  Broken Trade Reason Values
    /// </summary>
    public enum BrokenTradeReason : byte {
        Erroneous = (byte)'E',
        Consent = (byte)'C',
        Supervisory = (byte)'S',
        External = (byte)'X',
    };


    /// <summary>
    ///  Buy Sell Indicator Values
    /// </summary>
    public enum BuySellIndicator : byte {
        Buy = (byte)'B',
        Sell = (byte)'S',
        SellShort = (byte)'T',
        SellShortExempt = (byte)'E',
    };


    /// <summary>
    ///  Canceled Reason Values
    /// </summary>
    public enum CanceledReason : byte {
        UserRequestedCancel = (byte)'U',
        ImmediateOrCancelOrder = (byte)'I',
        Timeout = (byte)'T',
        Supervisory = (byte)'S',
        ThisOrderCannotBeExecutedBecauseOfARegulatoryRestriction = (byte)'D',
        SelfMatchPrevention = (byte)'Q',
        SystemCancel = (byte)'Z',
        Closed = (byte)'E',
    };


    /// <summary>
    ///  Capacity Values
    /// </summary>
    public enum Capacity : byte {
        Other = (byte)'O',
        Agency = (byte)'A',
        Principal = (byte)'P',
        Riskless = (byte)'R',
    };


    /// <summary>
    ///  Cross Type Values
    /// </summary>
    public enum CrossType : byte {
        NoCross = (byte)'N',
        Opening = (byte)'O',
        Closing = (byte)'C',
    };


    /// <summary>
    ///  Decrement Shares
    /// </summary>
    public unsafe struct DecrementShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Display Values
    /// </summary>
    public enum Display : byte {
        AttributablePrice = (byte)'A',
        AnonymousPrice = (byte)'Y',
        NonDisplay = (byte)'N',
        PostOnly = (byte)'P',
        ChangedToNondisplayed = (byte)'Z',
        ImbalanceOnly = (byte)'I',
        MidPoint = (byte)'M',
        MidPoint = (byte)'W',
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfDay = (byte)'S',
        EndOfDay = (byte)'E',
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
    public unsafe struct ExecutionPrice {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Existing Order Token
    /// </summary>
    public unsafe struct ExistingOrderToken {
        public const int Size = 14;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Firm
    /// </summary>
    public unsafe struct Firm {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Intermarket Sweep Eligibility Values
    /// </summary>
    public enum IntermarketSweepEligibility : byte {
        Eligible = (byte)'Y',
        NotEligible = (byte)'N',
        Tradeat = (byte)'y',
    };


    /// <summary>
    ///  Liquidity Flag Values
    /// </summary>
    public enum LiquidityFlag : byte {
        Added = (byte)'A',
        Removed = (byte)'R',
        Opening = (byte)'O',
        OpeningCross = (byte)'M',
        Closing = (byte)'C',
        ClosingCross = (byte)'L',
        HaltIpo = (byte)'H',
        Halt = (byte)'K',
        Nondisplayed = (byte)'J',
        Removed = (byte)'m',
        Added = (byte)'k',
        DisplayedAddedLiquidity = (byte)'V',
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
        EnterOrderMessage = (byte)'O',
        ReplaceOrderMessage = (byte)'U',
        CancelOrderMessage = (byte)'X',
        ModifyOrderMessage = (byte)'M',
        SystemEventMessage = (byte)'S',
        AcceptedMessage = (byte)'A',
        ReplacedMessage = (byte)'U',
        CanceledMessage = (byte)'C',
        AiqCanceledMessage = (byte)'D',
        ExecutedMessage = (byte)'E',
        BrokenTradeMessage = (byte)'B',
        RejectedMessage = (byte)'J',
        CancelPendingMessage = (byte)'P',
        CancelRejectMessage = (byte)'I',
        OrderPriorityUpdateMessage = (byte)'T',
        OrderModifiedMessage = (byte)'M',
    };


    /// <summary>
    ///  Minimum Quantity
    /// </summary>
    public unsafe struct MinimumQuantity {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
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
    ///  Order State Values
    /// </summary>
    public enum OrderState : byte {
        Live = (byte)'L',
        Dead = (byte)'D',
    };


    /// <summary>
    ///  Order Token
    /// </summary>
    public unsafe struct OrderToken {
        public const int Size = 14;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Length
    /// </summary>
    public unsafe struct PacketLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Type Values
    /// </summary>
    public enum PacketType : byte {
        DebugPacket = (byte)'+',
        LoginAcceptedPacket = (byte)'A',
        LoginRejectedPacket = (byte)'J',
        SequencedDataPacket = (byte)'S',
        ServerHeartbeatPacket = (byte)'H',
        EndOfSessionPacket = (byte)'Z',
        LoginRequestPacket = (byte)'L',
        UnsequencedDataPacket = (byte)'U',
        ClientHeartbeatPacket = (byte)'R',
        LogoutRequestPacket = (byte)'O',
    };


    /// <summary>
    ///  Password
    /// </summary>
    public unsafe struct Password {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Previous Order Token
    /// </summary>
    public unsafe struct PreviousOrderToken {
        public const int Size = 14;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quantity Prevented From Trading
    /// </summary>
    public unsafe struct QuantityPreventedFromTrading {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reject Reason Code
    /// </summary>
    public unsafe struct RejectReasonCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rejected Reason Values
    /// </summary>
    public enum RejectedReason : byte {
        TestMode = (byte)'T',
        Halted = (byte)'H',
        SharesExceedsConfiguredSafetyThreshold = (byte)'Z',
        InvalidStock = (byte)'S',
        InvalidDisplayType = (byte)'D',
        NasdaqOmxPsxIsClosed = (byte)'C',
        RequestedFirmNotAuthorizedForRequestedClearingTypeOnThisAccount = (byte)'L',
        OutsideOfPermittedTimes = (byte)'M',
        ThisOrderIsNotAllowedInThisTypeOfCross = (byte)'R',
        InvalidPrice = (byte)'X',
        InvalidMinimum = (byte)'N',
        InvalidMidpoint = (byte)'W',
        Reject = (byte)'a',
        EasyToBorrowEtb = (byte)'b',
        Restricted = (byte)'c',
        Iso = (byte)'d',
        Odd = (byte)'e',
        MidPoint = (byte)'f',
        PreMarket = (byte)'g',
        PostMarket = (byte)'h',
        ShortSale = (byte)'i',
        OnOpen = (byte)'j',
        OnClose = (byte)'k',
        TwoSided = (byte)'l',
        Exceeded = (byte)'m',
        Exceeded = (byte)'n',
    };


    /// <summary>
    ///  Replacement Order Token
    /// </summary>
    public unsafe struct ReplacementOrderToken {
        public const int Size = 14;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requested Sequence Number
    /// </summary>
    public unsafe struct RequestedSequenceNumber {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Requested Session
    /// </summary>
    public unsafe struct RequestedSession {
        public const int Size = 10;

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
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Text
    /// </summary>
    public unsafe struct Text {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Time In Force
    /// </summary>
    public unsafe struct TimeInForce {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Username
    /// </summary>
    public unsafe struct Username {
        public const int Size = 6;

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
    ///  Struct for Accepted Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AcceptedMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
        TimeInForce TimeInForce;
        Firm Firm;
        Display Display;
        OrderReferenceNumber OrderReferenceNumber;
        Capacity Capacity;
        IntermarketSweepEligibility IntermarketSweepEligibility;
        MinimumQuantity MinimumQuantity;
        CrossType CrossType;
        OrderState OrderState;
        BboWeightIndicator BboWeightIndicator;
    };


    /// <summary>
    ///  Struct for Aiq Canceled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AiqCanceledMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        DecrementShares DecrementShares;
        AiqCanceledReason AiqCanceledReason;
        QuantityPreventedFromTrading QuantityPreventedFromTrading;
        ExecutionPrice ExecutionPrice;
        LiquidityFlag LiquidityFlag;
    };


    /// <summary>
    ///  Struct for Broken Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BrokenTradeMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        MatchNumber MatchNumber;
        BrokenTradeReason BrokenTradeReason;
    };


    /// <summary>
    ///  Struct for Cancel Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelOrderMessage {
        OrderToken OrderToken;
        Shares Shares;
    };


    /// <summary>
    ///  Struct for Cancel Pending Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelPendingMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
    };


    /// <summary>
    ///  Struct for Cancel Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
    };


    /// <summary>
    ///  Struct for Canceled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CanceledMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        DecrementShares DecrementShares;
        CanceledReason CanceledReason;
    };


    /// <summary>
    ///  Struct for Debug Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DebugPacket {
        Text Text;
    };


    /// <summary>
    ///  Struct for Enter Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EnterOrderMessage {
        OrderToken OrderToken;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
        TimeInForce TimeInForce;
        Firm Firm;
        Display Display;
        Capacity Capacity;
        IntermarketSweepEligibility IntermarketSweepEligibility;
        MinimumQuantity MinimumQuantity;
        CrossType CrossType;
    };


    /// <summary>
    ///  Struct for Executed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutedMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        ExecutedShares ExecutedShares;
        ExecutionPrice ExecutionPrice;
        LiquidityFlag LiquidityFlag;
        MatchNumber MatchNumber;
    };


    /// <summary>
    ///  Struct for Login Accepted Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginAcceptedPacket {
        Session Session;
        SequenceNumber SequenceNumber;
    };


    /// <summary>
    ///  Struct for Login Rejected Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginRejectedPacket {
        RejectReasonCode RejectReasonCode;
    };


    /// <summary>
    ///  Struct for Login Request Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginRequestPacket {
        Username Username;
        Password Password;
        RequestedSession RequestedSession;
        RequestedSequenceNumber RequestedSequenceNumber;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Modify Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderMessage {
        OrderToken OrderToken;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
    };


    /// <summary>
    ///  Struct for Order Modified Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
    };


    /// <summary>
    ///  Struct for Order Priority Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderPriorityUpdateMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        Price Price;
        Display Display;
        OrderReferenceNumber OrderReferenceNumber;
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
        PacketLength PacketLength;
        PacketType PacketType;
    };


    /// <summary>
    ///  Struct for Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RejectedMessage {
        Timestamp Timestamp;
        OrderToken OrderToken;
        RejectedReason RejectedReason;
    };


    /// <summary>
    ///  Struct for Replace Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplaceOrderMessage {
        ExistingOrderToken ExistingOrderToken;
        ReplacementOrderToken ReplacementOrderToken;
        Shares Shares;
        Price Price;
        TimeInForce TimeInForce;
        Display Display;
        IntermarketSweepEligibility IntermarketSweepEligibility;
        MinimumQuantity MinimumQuantity;
    };


    /// <summary>
    ///  Struct for Replaced Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplacedMessage {
        Timestamp Timestamp;
        ReplacementOrderToken ReplacementOrderToken;
        BuySellIndicator BuySellIndicator;
        Shares Shares;
        Stock Stock;
        Price Price;
        TimeInForce TimeInForce;
        Firm Firm;
        Display Display;
        OrderReferenceNumber OrderReferenceNumber;
        Capacity Capacity;
        IntermarketSweepEligibility IntermarketSweepEligibility;
        MinimumQuantity MinimumQuantity;
        CrossType CrossType;
        OrderState OrderState;
        PreviousOrderToken PreviousOrderToken;
        BboWeightIndicator BboWeightIndicator;
    };


    /// <summary>
    ///  Struct for Sequenced Data Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequencedDataPacket {
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Timestamp Timestamp;
        EventCode EventCode;
    };


    /// <summary>
    ///  Struct for Unsequenced Data Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnsequencedDataPacket {
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
