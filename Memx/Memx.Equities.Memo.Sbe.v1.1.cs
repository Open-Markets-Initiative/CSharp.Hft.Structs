namespace Memx.Equities.Memo.Sbe.v1.1 {

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
    ///  Block Length
    /// </summary>
    public unsafe struct BlockLength {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancel Group Id
    /// </summary>
    public unsafe struct CancelGroupId {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancel Reason
    /// </summary>
    public unsafe struct CancelReason {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cl Ord Id
    /// </summary>
    public unsafe struct ClOrdId {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Count
    /// </summary>
    public unsafe struct Count {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cum Qty
    /// </summary>
    public unsafe struct CumQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cust Order Capacity
    /// </summary>
    public unsafe struct CustOrderCapacity {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cxl Rej Reason
    /// </summary>
    public unsafe struct CxlRejReason {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cxl Rej Response To
    /// </summary>
    public unsafe struct CxlRejResponseTo {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Display Method
    /// </summary>
    public unsafe struct DisplayMethod {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Display Min Incr
    /// </summary>
    public unsafe struct DisplayMinIncr {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Display Qty
    /// </summary>
    public unsafe struct DisplayQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Id
    /// </summary>
    public unsafe struct ExecId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Inst
    /// </summary>
    public unsafe struct ExecInst {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Ref Id
    /// </summary>
    public unsafe struct ExecRefId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Restatement Reason
    /// </summary>
    public unsafe struct ExecRestatementReason {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expire Time
    /// </summary>
    public unsafe struct ExpireTime {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Higher Than Price
    /// </summary>
    public struct HigherThanPrice {
        public long Raw;
    };


    /// <summary>
    ///  Last Liquidity Ind
    /// </summary>
    public unsafe struct LastLiquidityInd {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Mkt
    /// </summary>
    public unsafe struct LastMkt {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Px
    /// </summary>
    public struct LastPx {
        public long Raw;
    };


    /// <summary>
    ///  Last Qty
    /// </summary>
    public unsafe struct LastQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Shares
    /// </summary>
    public unsafe struct LastShares {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leaves Qty
    /// </summary>
    public unsafe struct LeavesQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Locate Reqd
    /// </summary>
    public unsafe struct LocateReqd {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Login Reject Code Values
    /// </summary>
    public enum LoginRejectCode : byte {
        MalformedToken = (byte)'T',
        TokenTypeUnsupported = (byte)'U',
        TokenTypeInvalid = (byte)'V',
        AuthorizationFailed = (byte)'A',
    };


    /// <summary>
    ///  Lower Than Price
    /// </summary>
    public struct LowerThanPrice {
        public long Raw;
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
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
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        LoginRequest = 100,
        ReplayRequest = 101,
        ReplayAllRequest = 102,
        StreamRequest = 103,
        UnsequencedMessage = 104,
        LoginAccepted = 1,
        LoginRejected = 2,
        StartOfSession = 3,
        EndOfSession = 3,
        ReplayBegin = 5,
        ReplayRejected = 6,
        ReplayComplete = 7,
        StreamBegin = 8,
        StreamRejected = 9,
        StreamComplete = 10,
        SequencedMessage = 11,
    };


    /// <summary>
    ///  Min Qty
    /// </summary>
    public unsafe struct MinQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
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
    ///  Next Sequence Number
    /// </summary>
    public unsafe struct NextSequenceNumber {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ord Status
    /// </summary>
    public unsafe struct OrdStatus {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        Market = 1,
        Limit = 2,
        Pegged = 3,
        NullValue = 255,
    };


    /// <summary>
    ///  Order Capacity
    /// </summary>
    public unsafe struct OrderCapacity {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public unsafe struct OrderId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Qty
    /// </summary>
    public unsafe struct OrderQty {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Orig Cl Ord Id
    /// </summary>
    public unsafe struct OrigClOrdId {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Peg Offset Value
    /// </summary>
    public struct PegOffsetValue {
        public long Raw;
    };


    /// <summary>
    ///  Peg Price Type
    /// </summary>
    public unsafe struct PegPriceType {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pending Message Count
    /// </summary>
    public unsafe struct PendingMessageCount {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public long Raw;
    };


    /// <summary>
    ///  Reject Reason
    /// </summary>
    public unsafe struct RejectReason {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Replay Reject Code Values
    /// </summary>
    public enum ReplayRejectCode : byte {
        ReplayRequestsAreNotAllowed = (byte)'R',
        ReplayAllRequestsAreNotAllowed = (byte)'A',
        NotTheActiveSession = (byte)'P',
        SequenceNumberOutOfRange = (byte)'S',
    };


    /// <summary>
    ///  Reprice Behavior
    /// </summary>
    public unsafe struct RepriceBehavior {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reprice Frequency
    /// </summary>
    public unsafe struct RepriceFrequency {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserve Replenish Timing
    /// </summary>
    public unsafe struct ReserveReplenishTiming {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Group Id
    /// </summary>
    public unsafe struct RiskGroupId {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public unsafe struct SchemaId {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Self Trade Prevention
    /// </summary>
    public unsafe struct SelfTradePrevention {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public unsafe struct SendingTime {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Id
    /// </summary>
    public unsafe struct SessionId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side
    /// </summary>
    public unsafe struct Side {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stp Group Id
    /// </summary>
    public unsafe struct StpGroupId {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stream Reject Code Values
    /// </summary>
    public enum StreamRejectCode : byte {
        StreamRequestsAreNotAllowed = (byte)'R',
        NotTheActiveSession = (byte)'P',
        SequenceNumberOutOfRange = (byte)'S',
    };


    /// <summary>
    ///  Supported Request Mode Values
    /// </summary>
    public enum SupportedRequestMode : byte {
        Stream = (byte)'S',
        Replay = (byte)'R',
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Sfx
    /// </summary>
    public unsafe struct SymbolSfx {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : byte {
        NewOrderSingleMessage = 1,
        OrderCancelReplaceRequestMessage = 2,
        OrderCancelRequestMessage = 3,
        MassCancelRequestMessage = 4,
        ExecutionReportPendingNewMessage = 5,
        ExecutionReportNewMessage = 6,
        ExecutionReportRejectedMessage = 7,
        ExecutionReportTradeMessage = 8,
        ExecutionReportPendingCancelMessage = 9,
        PendingMassCancelMessage = 10,
        ExecutionReportCanceledMessage = 11,
        MassCancelDoneMessage = 12,
        ExecutionReportPendingReplaceMessage = 13,
        ExecutionReportReplacedMessage = 14,
        ExecutionReportTradeCorrectionMessage = 15,
        ExecutionReportTradeBreakMessage = 16,
        ExecutionReportRestatementMessage = 17,
        OrderCancelRejectMessage = 18,
        MassCancelRejectMessage = 20,
    };


    /// <summary>
    ///  Time In Force
    /// </summary>
    public unsafe struct TimeInForce {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Token
    /// </summary>
    public unsafe struct Token {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Token Type
    /// </summary>
    public unsafe struct TokenType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Sequence Count
    /// </summary>
    public unsafe struct TotalSequenceCount {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public unsafe struct TransactTime {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Match Id
    /// </summary>
    public unsafe struct TrdMatchId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trd Matching Id
    /// </summary>
    public unsafe struct TrdMatchingId {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Common Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CommonHeader {
        MessageType MessageType;
        MessageLength MessageLength;
    };


    /// <summary>
    ///  Struct for Execution Report Canceled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportCanceledMessage {
        SendingTime SendingTime;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        OrderId OrderId;
        ExecId ExecId;
        OrdStatus OrdStatus;
        LeavesQty LeavesQty;
        CumQty CumQty;
        CancelReason CancelReason;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Execution Report New Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportNewMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        ExecId ExecId;
        Mpid Mpid;
        OrdStatus OrdStatus;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        OrdType OrdType;
        OrderQty OrderQty;
        Price Price;
        TimeInForce TimeInForce;
        OrderCapacity OrderCapacity;
        CustOrderCapacity CustOrderCapacity;
        ExecInst ExecInst;
        PegOffsetValue PegOffsetValue;
        PegPriceType PegPriceType;
        ExpireTime ExpireTime;
        MinQty MinQty;
        DisplayQty DisplayQty;
        DisplayMethod DisplayMethod;
        ReserveReplenishTiming ReserveReplenishTiming;
        DisplayMinIncr DisplayMinIncr;
        LocateReqd LocateReqd;
        RepriceFrequency RepriceFrequency;
        RepriceBehavior RepriceBehavior;
        CancelGroupId CancelGroupId;
        StpGroupId StpGroupId;
        SelfTradePrevention SelfTradePrevention;
        RiskGroupId RiskGroupId;
        LeavesQty LeavesQty;
        CumQty CumQty;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Execution Report Pending Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportPendingCancelMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        ExecId ExecId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        OrdStatus OrdStatus;
        LeavesQty LeavesQty;
        CumQty CumQty;
    };


    /// <summary>
    ///  Struct for Execution Report Pending New Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportPendingNewMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        ExecId ExecId;
        Mpid Mpid;
        OrdStatus OrdStatus;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        OrdType OrdType;
        OrderQty OrderQty;
        Price Price;
        TimeInForce TimeInForce;
        OrderCapacity OrderCapacity;
        CustOrderCapacity CustOrderCapacity;
        ExecInst ExecInst;
        PegOffsetValue PegOffsetValue;
        PegPriceType PegPriceType;
        ExpireTime ExpireTime;
        MinQty MinQty;
        DisplayQty DisplayQty;
        DisplayMethod DisplayMethod;
        ReserveReplenishTiming ReserveReplenishTiming;
        DisplayMinIncr DisplayMinIncr;
        LocateReqd LocateReqd;
        RepriceFrequency RepriceFrequency;
        RepriceBehavior RepriceBehavior;
        CancelGroupId CancelGroupId;
        StpGroupId StpGroupId;
        SelfTradePrevention SelfTradePrevention;
        RiskGroupId RiskGroupId;
        LeavesQty LeavesQty;
        CumQty CumQty;
    };


    /// <summary>
    ///  Struct for Execution Report Pending Replace Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportPendingReplaceMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        ExecId ExecId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        OrderQty OrderQty;
        OrdType OrdType;
        Price Price;
        DisplayQty DisplayQty;
        LocateReqd LocateReqd;
        OrdStatus OrdStatus;
        LeavesQty LeavesQty;
        CumQty CumQty;
    };


    /// <summary>
    ///  Struct for Execution Report Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportRejectedMessage {
        SendingTime SendingTime;
        ClOrdId ClOrdId;
        ExecId ExecId;
        OrdStatus OrdStatus;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        RejectReason RejectReason;
    };


    /// <summary>
    ///  Struct for Execution Report Replaced Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportReplacedMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
        ExecId ExecId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        OrderQty OrderQty;
        OrdType OrdType;
        Price Price;
        DisplayQty DisplayQty;
        LocateReqd LocateReqd;
        OrdStatus OrdStatus;
        LeavesQty LeavesQty;
        CumQty CumQty;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Execution Report Restatement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportRestatementMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        ExecId ExecId;
        OrdStatus OrdStatus;
        LastPx LastPx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        LastShares LastShares;
        ExecRestatementReason ExecRestatementReason;
        TransactTime TransactTime;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Break Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeBreakMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        ExecId ExecId;
        ExecRefId ExecRefId;
        TrdMatchId TrdMatchId;
        OrdStatus OrdStatus;
        LeavesQty LeavesQty;
        CumQty CumQty;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Correction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeCorrectionMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        ExecId ExecId;
        ExecRefId ExecRefId;
        TrdMatchId TrdMatchId;
        OrdStatus OrdStatus;
        LastPx LastPx;
        LastQty LastQty;
        LeavesQty LeavesQty;
        CumQty CumQty;
    };


    /// <summary>
    ///  Struct for Execution Report Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExecutionReportTradeMessage {
        SendingTime SendingTime;
        OrderId OrderId;
        ClOrdId ClOrdId;
        ExecId ExecId;
        OrdStatus OrdStatus;
        LastQty LastQty;
        LastPx LastPx;
        LeavesQty LeavesQty;
        CumQty CumQty;
        TransactTime TransactTime;
        LastLiquidityInd LastLiquidityInd;
        LastMkt LastMkt;
        TrdMatchingId TrdMatchingId;
    };


    /// <summary>
    ///  Struct for Login Accepted Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginAcceptedMessage {
        SupportedRequestMode SupportedRequestMode;
    };


    /// <summary>
    ///  Struct for Login Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginRejectedMessage {
        LoginRejectCode LoginRejectCode;
    };


    /// <summary>
    ///  Struct for Login Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginRequestMessage {
        TokenType TokenType;
        Token Token;
    };


    /// <summary>
    ///  Struct for Mass Cancel Done Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassCancelDoneMessage {
        SendingTime SendingTime;
        ClOrdId ClOrdId;
    };


    /// <summary>
    ///  Struct for Mass Cancel Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassCancelRejectMessage {
        SendingTime SendingTime;
        ClOrdId ClOrdId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        LowerThanPrice LowerThanPrice;
        HigherThanPrice HigherThanPrice;
        CancelGroupId CancelGroupId;
        RejectReason RejectReason;
    };


    /// <summary>
    ///  Struct for Mass Cancel Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassCancelRequestMessage {
        ClOrdId ClOrdId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        LowerThanPrice LowerThanPrice;
        HigherThanPrice HigherThanPrice;
        CancelGroupId CancelGroupId;
    };


    /// <summary>
    ///  Struct for New Order Single Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderSingleMessage {
        ClOrdId ClOrdId;
        Mpid Mpid;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        OrderQty OrderQty;
        OrdType OrdType;
        Price Price;
        TimeInForce TimeInForce;
        OrderCapacity OrderCapacity;
        CustOrderCapacity CustOrderCapacity;
        ExecInst ExecInst;
        PegOffsetValue PegOffsetValue;
        PegPriceType PegPriceType;
        ExpireTime ExpireTime;
        MinQty MinQty;
        DisplayQty DisplayQty;
        DisplayMethod DisplayMethod;
        ReserveReplenishTiming ReserveReplenishTiming;
        DisplayMinIncr DisplayMinIncr;
        LocateReqd LocateReqd;
        RepriceFrequency RepriceFrequency;
        RepriceBehavior RepriceBehavior;
        CancelGroupId CancelGroupId;
        StpGroupId StpGroupId;
        SelfTradePrevention SelfTradePrevention;
        RiskGroupId RiskGroupId;
    };


    /// <summary>
    ///  Struct for Order Cancel Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelRejectMessage {
        SendingTime SendingTime;
        ClOrdId ClOrdId;
        CxlRejResponseTo CxlRejResponseTo;
        CxlRejReason CxlRejReason;
    };


    /// <summary>
    ///  Struct for Order Cancel Replace Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelReplaceRequestMessage {
        OrigClOrdId OrigClOrdId;
        ClOrdId ClOrdId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        OrderQty OrderQty;
        OrdType OrdType;
        Price Price;
        DisplayQty DisplayQty;
        LocateReqd LocateReqd;
    };


    /// <summary>
    ///  Struct for Order Cancel Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelRequestMessage {
        OrigClOrdId OrigClOrdId;
        OrderId OrderId;
        ClOrdId ClOrdId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        CommonHeader CommonHeader;
    };


    /// <summary>
    ///  Struct for Pending Mass Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PendingMassCancelMessage {
        SendingTime SendingTime;
        ClOrdId ClOrdId;
        Symbol Symbol;
        SymbolSfx SymbolSfx;
        Side Side;
        LowerThanPrice LowerThanPrice;
        HigherThanPrice HigherThanPrice;
        CancelGroupId CancelGroupId;
    };


    /// <summary>
    ///  Struct for Replay All Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplayAllRequestMessage {
        SessionId SessionId;
    };


    /// <summary>
    ///  Struct for Replay Begin Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplayBeginMessage {
        NextSequenceNumber NextSequenceNumber;
        PendingMessageCount PendingMessageCount;
    };


    /// <summary>
    ///  Struct for Replay Complete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplayCompleteMessage {
        MessageCount MessageCount;
    };


    /// <summary>
    ///  Struct for Replay Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplayRejectedMessage {
        ReplayRejectCode ReplayRejectCode;
    };


    /// <summary>
    ///  Struct for Replay Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReplayRequestMessage {
        SessionId SessionId;
        NextSequenceNumber NextSequenceNumber;
        Count Count;
    };


    /// <summary>
    ///  Struct for Sbe Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SbeHeader {
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Sbe Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SbeMessage {
        SbeHeader SbeHeader;
    };


    /// <summary>
    ///  Struct for Sequenced Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SequencedMessage {
    };


    /// <summary>
    ///  Struct for Stream Begin Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamBeginMessage {
        NextSequenceNumber NextSequenceNumber;
        MaxSequenceNumber MaxSequenceNumber;
    };


    /// <summary>
    ///  Struct for Stream Complete Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamCompleteMessage {
        TotalSequenceCount TotalSequenceCount;
    };


    /// <summary>
    ///  Struct for Stream Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamRejectedMessage {
        StreamRejectCode StreamRejectCode;
    };


    /// <summary>
    ///  Struct for Stream Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StreamRequestMessage {
        SessionId SessionId;
        NextSequenceNumber NextSequenceNumber;
    };


    /// <summary>
    ///  Struct for Unsequenced Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnsequencedMessage {
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
