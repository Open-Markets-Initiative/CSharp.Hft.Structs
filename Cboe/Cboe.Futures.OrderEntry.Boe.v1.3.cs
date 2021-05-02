namespace Cboe.Futures.OrderEntry.Boe.v1.3 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Account
    /// </summary>
    public unsafe struct Account {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Application Message Type Values
    /// </summary>
    public enum ApplicationMessageType : byte {
        NewOrder = 0x38,
        CancelOrder = 0x39,
        ModifyOrder = 0x3A,
        PurgeOrder = 0x47,
        OrderAcknowledgment = 0x25,
        OrderRejected = 0x26,
        OrderModified = 0x27,
        UserModifyRejected = 0x29,
        OrderCancelled = 0x2A,
        CancelRejected = 0x2B,
        OrderExecution = 0x2C,
        TradeCancelOrCorrect = 0x2D,
        PurgeRejected = 0x48,
        TasRestatement = 0x49,
        VarianceRestatement = 0x4A,
    };


    /// <summary>
    ///  Avg Px
    /// </summary>
    public struct AvgPx {
        public long Raw;
    };


    /// <summary>
    ///  Base Liquidity Indicator Values
    /// </summary>
    public enum BaseLiquidityIndicator : byte {
        AddedLiquidity = (byte)'A',
        RemovedLiquidity = (byte)'R',
        MarketOpening = (byte)'C',
    };


    /// <summary>
    ///  Cancel Order Bitfield Count
    /// </summary>
    public unsafe struct CancelOrderBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancel Order Clearing Firm Exists
    /// </summary>
    public unsafe struct CancelOrderClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Manual Order Indicator Exists
    /// </summary>
    public unsafe struct CancelOrderManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Mass Cancel Id Exists
    /// </summary>
    public unsafe struct CancelOrderMassCancelIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Mass Cancel Inst Exists
    /// </summary>
    public unsafe struct CancelOrderMassCancelInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Oeoid Exists
    /// </summary>
    public unsafe struct CancelOrderOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Product Name Exists
    /// </summary>
    public unsafe struct CancelOrderProductNameExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Orig On Reject Values
    /// </summary>
    public enum CancelOrigOnReject : byte {
        LeaveOriginalOrderAlone = (byte)'N',
        CancelOriginalOrderIfModificationFails = (byte)'Y',
    };


    /// <summary>
    ///  Cancel Reason Values
    /// </summary>
    public enum CancelReason : byte {
        Admin = (byte)'A',
        UnknownMaturityDate = (byte)'B',
        UnknownProductName = (byte)'C',
        DuplicateIdentifier = (byte)'D',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        LiquidityAvailableExceedsOrderSize = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        RiskManagementConfigurationIsInsufficient = (byte)'n',
        MaxOpenOrdersCountExceeded = (byte)'o',
        RiskManagementProductLevel = (byte)'s',
        OrderReceivedByCfeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
    };


    /// <summary>
    ///  Cancel Reject Reason Values
    /// </summary>
    public enum CancelRejectReason : byte {
        Admin = (byte)'A',
        UnknownMaturityDate = (byte)'B',
        UnknownProductName = (byte)'C',
        DuplicateIdentifier = (byte)'D',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        LiquidityAvailableExceedsOrderSize = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        RiskManagementConfigurationIsInsufficient = (byte)'n',
        MaxOpenOrdersCountExceeded = (byte)'o',
        RiskManagementProductLevel = (byte)'s',
        OrderReceivedByCfeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
    };


    /// <summary>
    ///  Cancel Rejected Bitfield Count
    /// </summary>
    public unsafe struct CancelRejectedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancel Rejected Capacity Exists
    /// </summary>
    public unsafe struct CancelRejectedCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Cmta Number Exists
    /// </summary>
    public unsafe struct CancelRejectedCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Cti Code Exists
    /// </summary>
    public unsafe struct CancelRejectedCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Expire Time Exists
    /// </summary>
    public unsafe struct CancelRejectedExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Manual Order Indicator Exists
    /// </summary>
    public unsafe struct CancelRejectedManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Maturity Date Exists
    /// </summary>
    public unsafe struct CancelRejectedMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Min Qty Exists
    /// </summary>
    public unsafe struct CancelRejectedMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Oeoid Exists
    /// </summary>
    public unsafe struct CancelRejectedOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Open Close Exists
    /// </summary>
    public unsafe struct CancelRejectedOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Ord Type Exists
    /// </summary>
    public unsafe struct CancelRejectedOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Price Exists
    /// </summary>
    public unsafe struct CancelRejectedPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct CancelRejectedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Side Exists
    /// </summary>
    public unsafe struct CancelRejectedSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Stop Px Exists
    /// </summary>
    public unsafe struct CancelRejectedStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Symbol Exists
    /// </summary>
    public unsafe struct CancelRejectedSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Time In Force Exists
    /// </summary>
    public unsafe struct CancelRejectedTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancelled Order Count
    /// </summary>
    public unsafe struct CancelledOrderCount {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Capacity Values
    /// </summary>
    public enum Capacity : byte {
        Customer = (byte)'C',
        Firm = (byte)'F',
    };


    /// <summary>
    ///  Cl Ord Id
    /// </summary>
    public unsafe struct ClOrdId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Account
    /// </summary>
    public unsafe struct ClearingAccount {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Firm
    /// </summary>
    public unsafe struct ClearingFirm {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Price
    /// </summary>
    public struct ClearingPrice {
        public long Raw;
    };


    /// <summary>
    ///  Clearing Size
    /// </summary>
    public unsafe struct ClearingSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Symbol
    /// </summary>
    public unsafe struct ClearingSymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cmta Number
    /// </summary>
    public unsafe struct CmtaNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contra Broker
    /// </summary>
    public unsafe struct ContraBroker {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Corrected Price
    /// </summary>
    public struct CorrectedPrice {
        public long Raw;
    };


    /// <summary>
    ///  Corrected Size
    /// </summary>
    public unsafe struct CorrectedSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cti Code Values
    /// </summary>
    public enum CtiCode : byte {
        Cti2 = (byte)'1',
        Cti2 = (byte)'2',
        Cti3 = (byte)'3',
        Cti4 = (byte)'4',
    };


    /// <summary>
    ///  Cum Qty
    /// </summary>
    public unsafe struct CumQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Custom Group Id
    /// </summary>
    public unsafe struct CustomGroupId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Day Cum Qty
    /// </summary>
    public unsafe struct DayCumQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Day Order Qty
    /// </summary>
    public unsafe struct DayOrderQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Id
    /// </summary>
    public unsafe struct ExecId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exec Ref Id
    /// </summary>
    public unsafe struct ExecRefId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expire Time
    /// </summary>
    public unsafe struct ExpireTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Fee Code
    /// </summary>
    public unsafe struct FeeCode {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Last Received Sequence Number
    /// </summary>
    public unsafe struct LastReceivedSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Shares
    /// </summary>
    public unsafe struct LastShares {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leaves Qty
    /// </summary>
    public unsafe struct LeavesQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Login Response Status Values
    /// </summary>
    public enum LoginResponseStatus : byte {
        LoginAccepted = (byte)'A',
        NotAuthorized = (byte)'N',
        SessionIsDisabled = (byte)'D',
        SessionInUse = (byte)'B',
        InvalidSession = (byte)'S',
        SequenceAheadInLoginMessage = (byte)'Q',
        InvalidUnitGivenInLoginMessage = (byte)'I',
        InvalidReturnBitFieldInLoginMessage = (byte)'F',
        InvalidLoginRequestMessageStructure = (byte)'M',
    };


    /// <summary>
    ///  Login Response Text
    /// </summary>
    public unsafe struct LoginResponseText {
        public const int Size = 60;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Logout Reason Values
    /// </summary>
    public enum LogoutReason : byte {
        UserRequested = (byte)'U',
        EndOfDay = (byte)'E',
        Administrative = (byte)'A',
        ProtocolViolation = (byte)'!',
    };


    /// <summary>
    ///  Logout Reason Text
    /// </summary>
    public unsafe struct LogoutReasonText {
        public const int Size = 60;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Manual Order Indicator Values
    /// </summary>
    public enum ManualOrderIndicator : byte {
        ManualOrderEntry = (byte)'Y',
        AutomatedOrderEntry = (byte)'N',
        SimpleInstrumentExecution = (byte)'1',
        SimpleInstrumentExecutionThatIsPartOfASpreadExecution = (byte)'2',
        SpreadInstrumentExecution = (byte)'3',
    };


    /// <summary>
    ///  Mass Cancel Id
    /// </summary>
    public unsafe struct MassCancelId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mass Cancel Inst
    /// </summary>
    public unsafe struct MassCancelInst {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Matching Unit
    /// </summary>
    public unsafe struct MatchingUnit {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Length
    /// </summary>
    public unsafe struct MessageLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        LoginRequestMessage = 0x37,
        LogoutRequestMessage = 0x02,
        ClientHeartbeatMessage = 0x03,
        LoginResponseMessage = 0x24,
        LogoutMessage = 0x08,
        ServerHeartbeatMessage = 0x09,
        ReplayCompleteMessage = 0x13,
        NewOrderMessage = 0x38,
        CancelOrderMessage = 0x39,
        ModifyOrderMessage = 0x3A,
        QuoteUpdateMessage = 0x70,
        PurgeOrderMessage = 0x47,
        ResetRiskMessage = 0x56,
        OrderAcknowledgmentMessage = 0x25,
        QuoteUpdateAcknowledgmentMessage = 0x71,
        OrderRejectedMessage = 0x26,
        QuoteUpdateRejectedMessage = 0x78,
        OrderModifiedMessage = 0x27,
        QuoteRestatedMessage = 0x72,
        UserModifyRejectedMessage = 0x29,
        OrderCancelledMessage = 0x2A,
        QuoteCancelledMessage = 0x73,
        CancelRejectedMessage = 0x2B,
        OrderExecutionMessage = 0x2C,
        QuoteExecutionMessage = 0x74,
        TradeCancelOrCorrectMessage = 0x2D,
        PurgeRejectedMessage = 0x48,
        RiskResetAcknowledgmentMessage = 0x57,
        MassCancelAcknowledgmentMessage = 0x36,
        TasRestatementMessage = 0x49,
        VarianceRestatementMessage = 0x4A,
        TasQuoteRestatementMessage = 0x75,
        VarianceQuoteRestatementMessage = 0x76,
    };


    /// <summary>
    ///  Min Qty
    /// </summary>
    public unsafe struct MinQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Modify Order Bitfield Count
    /// </summary>
    public unsafe struct ModifyOrderBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Modify Order Cancel Orig On Reject Exists
    /// </summary>
    public unsafe struct ModifyOrderCancelOrigOnRejectExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Clearing Firm Exists
    /// </summary>
    public unsafe struct ModifyOrderClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Exec Inst Exists
    /// </summary>
    public unsafe struct ModifyOrderExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Frequent Trader Id Exists
    /// </summary>
    public unsafe struct ModifyOrderFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Manual Order Indicator Exists
    /// </summary>
    public unsafe struct ModifyOrderManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Oeoid Exists
    /// </summary>
    public unsafe struct ModifyOrderOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Ord Type Exists
    /// </summary>
    public unsafe struct ModifyOrderOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Order Qty Exists
    /// </summary>
    public unsafe struct ModifyOrderOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Price Exists
    /// </summary>
    public unsafe struct ModifyOrderPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Side Exists
    /// </summary>
    public unsafe struct ModifyOrderSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Stop Px Exists
    /// </summary>
    public unsafe struct ModifyOrderStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Reject Reason Values
    /// </summary>
    public enum ModifyRejectReason : byte {
        Admin = (byte)'A',
        UnknownMaturityDate = (byte)'B',
        UnknownProductName = (byte)'C',
        DuplicateIdentifier = (byte)'D',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        LiquidityAvailableExceedsOrderSize = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        RiskManagementConfigurationIsInsufficient = (byte)'n',
        MaxOpenOrdersCountExceeded = (byte)'o',
        RiskManagementProductLevel = (byte)'s',
        OrderReceivedByCfeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
    };


    /// <summary>
    ///  Multileg Reporting Type
    /// </summary>
    public unsafe struct MultilegReportingType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Order Account Exists
    /// </summary>
    public unsafe struct NewOrderAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Bitfield Count
    /// </summary>
    public unsafe struct NewOrderBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Order Capacity Exists
    /// </summary>
    public unsafe struct NewOrderCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Clearing Account Exists
    /// </summary>
    public unsafe struct NewOrderClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Clearing Firm Exists
    /// </summary>
    public unsafe struct NewOrderClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cmta Number Exists
    /// </summary>
    public unsafe struct NewOrderCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cti Code Exists
    /// </summary>
    public unsafe struct NewOrderCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Custom Group Id Exists
    /// </summary>
    public unsafe struct NewOrderCustomGroupIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Expire Time Exists
    /// </summary>
    public unsafe struct NewOrderExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Frequent Trader Id Exists
    /// </summary>
    public unsafe struct NewOrderFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Manual Order Indicator Exists
    /// </summary>
    public unsafe struct NewOrderManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Maturity Date Exists
    /// </summary>
    public unsafe struct NewOrderMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Min Qty Exists
    /// </summary>
    public unsafe struct NewOrderMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Oeoid Exists
    /// </summary>
    public unsafe struct NewOrderOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Open Close Exists
    /// </summary>
    public unsafe struct NewOrderOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Ord Type Exists
    /// </summary>
    public unsafe struct NewOrderOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Prevent Match Exists
    /// </summary>
    public unsafe struct NewOrderPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Price Exists
    /// </summary>
    public unsafe struct NewOrderPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct NewOrderReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Risk Reset Exists
    /// </summary>
    public unsafe struct NewOrderRiskResetExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Stop Px Exists
    /// </summary>
    public unsafe struct NewOrderStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Symbol Exists
    /// </summary>
    public unsafe struct NewOrderSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Time In Force Exists
    /// </summary>
    public unsafe struct NewOrderTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  No Unspecified Unit Replay Values
    /// </summary>
    public enum NoUnspecifiedUnitReplay : byte {
        False = (byte)'0',
        True = (byte)'1',
    };


    /// <summary>
    ///  Number Of Param Groups
    /// </summary>
    public unsafe struct NumberOfParamGroups {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Quote Results
    /// </summary>
    public unsafe struct NumberOfQuoteResults {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Quotes
    /// </summary>
    public unsafe struct NumberOfQuotes {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Units
    /// </summary>
    public unsafe struct NumberOfUnits {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Oeoid
    /// </summary>
    public unsafe struct Oeoid {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Close Values
    /// </summary>
    public enum OpenClose : byte {
        Open = (byte)'O',
        Close = (byte)'C',
        None = (byte)'N',
    };


    /// <summary>
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        Market = (byte)'1',
        Limit = (byte)'2',
        StopLimit = (byte)'4',
    };


    /// <summary>
    ///  Order Acknowledgment Account Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Avg Px Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentAvgPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Base Liquidity Indicator Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentBaseLiquidityIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Bitfield Count
    /// </summary>
    public unsafe struct OrderAcknowledgmentBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Acknowledgment Capacity Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Clearing Account Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Clearing Firm Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Cmta Number Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Cti Code Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Cum Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCumQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Day Avg Px Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDayAvgPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Day Cum Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDayCumQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Day Order Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDayOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Expire Time Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Frequent Trader Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Leaves Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentLeavesQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Manual Order Indicator Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Maturity Date Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Min Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Oeoid Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Open Close Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Ord Type Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Order Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Prevent Match Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Price Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Side Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Stop Px Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Sub Liquidity Indicator Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentSubLiquidityIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Symbol Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Time In Force Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Account Exists
    /// </summary>
    public unsafe struct OrderCancelledAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Bitfield Count
    /// </summary>
    public unsafe struct OrderCancelledBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Cancelled Capacity Exists
    /// </summary>
    public unsafe struct OrderCancelledCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Clearing Account Exists
    /// </summary>
    public unsafe struct OrderCancelledClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Clearing Firm Exists
    /// </summary>
    public unsafe struct OrderCancelledClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Cmta Number Exists
    /// </summary>
    public unsafe struct OrderCancelledCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Cti Code Exists
    /// </summary>
    public unsafe struct OrderCancelledCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Expire Time Exists
    /// </summary>
    public unsafe struct OrderCancelledExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Frequent Trader Id Exists
    /// </summary>
    public unsafe struct OrderCancelledFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Last Px Exists
    /// </summary>
    public unsafe struct OrderCancelledLastPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Last Shares Exists
    /// </summary>
    public unsafe struct OrderCancelledLastSharesExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Leaves Qty Exists
    /// </summary>
    public unsafe struct OrderCancelledLeavesQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Manual Order Indicator Exists
    /// </summary>
    public unsafe struct OrderCancelledManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Maturity Date Exists
    /// </summary>
    public unsafe struct OrderCancelledMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Min Qty Exists
    /// </summary>
    public unsafe struct OrderCancelledMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Oeoid Exists
    /// </summary>
    public unsafe struct OrderCancelledOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Open Close Exists
    /// </summary>
    public unsafe struct OrderCancelledOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Ord Type Exists
    /// </summary>
    public unsafe struct OrderCancelledOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Order Qty Exists
    /// </summary>
    public unsafe struct OrderCancelledOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Prevent Match Exists
    /// </summary>
    public unsafe struct OrderCancelledPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Price Exists
    /// </summary>
    public unsafe struct OrderCancelledPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct OrderCancelledReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Secondary Order Id Exists
    /// </summary>
    public unsafe struct OrderCancelledSecondaryOrderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Side Exists
    /// </summary>
    public unsafe struct OrderCancelledSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Stop Px Exists
    /// </summary>
    public unsafe struct OrderCancelledStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Symbol Exists
    /// </summary>
    public unsafe struct OrderCancelledSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Time In Force Exists
    /// </summary>
    public unsafe struct OrderCancelledTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Account Exists
    /// </summary>
    public unsafe struct OrderExecutionAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Avg Px Exists
    /// </summary>
    public unsafe struct OrderExecutionAvgPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Bitfield Count
    /// </summary>
    public unsafe struct OrderExecutionBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Execution Capacity Exists
    /// </summary>
    public unsafe struct OrderExecutionCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Clearing Account Exists
    /// </summary>
    public unsafe struct OrderExecutionClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Clearing Firm Exists
    /// </summary>
    public unsafe struct OrderExecutionClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Clearing Size Exists
    /// </summary>
    public unsafe struct OrderExecutionClearingSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cmta Number Exists
    /// </summary>
    public unsafe struct OrderExecutionCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cti Code Exists
    /// </summary>
    public unsafe struct OrderExecutionCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cum Qty Exists
    /// </summary>
    public unsafe struct OrderExecutionCumQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Day Avg Px Exists
    /// </summary>
    public unsafe struct OrderExecutionDayAvgPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Day Cum Qty Exists
    /// </summary>
    public unsafe struct OrderExecutionDayCumQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Day Order Qty Exists
    /// </summary>
    public unsafe struct OrderExecutionDayOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Expire Time Exists
    /// </summary>
    public unsafe struct OrderExecutionExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Fee Code Exists
    /// </summary>
    public unsafe struct OrderExecutionFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Frequent Trader Id Exists
    /// </summary>
    public unsafe struct OrderExecutionFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Manual Order Indicator Exists
    /// </summary>
    public unsafe struct OrderExecutionManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Maturity Date Exists
    /// </summary>
    public unsafe struct OrderExecutionMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Min Qty Exists
    /// </summary>
    public unsafe struct OrderExecutionMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Multileg Reporting Type Exists
    /// </summary>
    public unsafe struct OrderExecutionMultilegReportingTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Oeoid Exists
    /// </summary>
    public unsafe struct OrderExecutionOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Open Close Exists
    /// </summary>
    public unsafe struct OrderExecutionOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Ord Type Exists
    /// </summary>
    public unsafe struct OrderExecutionOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Order Qty Exists
    /// </summary>
    public unsafe struct OrderExecutionOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Pending Status Exists
    /// </summary>
    public unsafe struct OrderExecutionPendingStatusExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Prevent Match Exists
    /// </summary>
    public unsafe struct OrderExecutionPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Price Exists
    /// </summary>
    public unsafe struct OrderExecutionPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct OrderExecutionReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Secondary Exec Id Exists
    /// </summary>
    public unsafe struct OrderExecutionSecondaryExecIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Side Exists
    /// </summary>
    public unsafe struct OrderExecutionSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Stop Px Exists
    /// </summary>
    public unsafe struct OrderExecutionStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Symbol Exists
    /// </summary>
    public unsafe struct OrderExecutionSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Time In Force Exists
    /// </summary>
    public unsafe struct OrderExecutionTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Trade Date Exists
    /// </summary>
    public unsafe struct OrderExecutionTradeDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  Order Modified Account Exists
    /// </summary>
    public unsafe struct OrderModifiedAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Base Liquidity Indicator Exists
    /// </summary>
    public unsafe struct OrderModifiedBaseLiquidityIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Bitfield Count
    /// </summary>
    public unsafe struct OrderModifiedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Modified Capacity Exists
    /// </summary>
    public unsafe struct OrderModifiedCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Clearing Account Exists
    /// </summary>
    public unsafe struct OrderModifiedClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Clearing Firm Exists
    /// </summary>
    public unsafe struct OrderModifiedClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Cmta Number Exists
    /// </summary>
    public unsafe struct OrderModifiedCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Cti Code Exists
    /// </summary>
    public unsafe struct OrderModifiedCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Expire Time Exists
    /// </summary>
    public unsafe struct OrderModifiedExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Frequent Trader Id Exists
    /// </summary>
    public unsafe struct OrderModifiedFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Leaves Qty Exists
    /// </summary>
    public unsafe struct OrderModifiedLeavesQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Manual Order Indicator Exists
    /// </summary>
    public unsafe struct OrderModifiedManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Maturity Date Exists
    /// </summary>
    public unsafe struct OrderModifiedMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Min Qty Exists
    /// </summary>
    public unsafe struct OrderModifiedMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Oeoid Exists
    /// </summary>
    public unsafe struct OrderModifiedOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Open Close Exists
    /// </summary>
    public unsafe struct OrderModifiedOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Ord Type Exists
    /// </summary>
    public unsafe struct OrderModifiedOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Order Qty Exists
    /// </summary>
    public unsafe struct OrderModifiedOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Orig Cl Ord Id Exists
    /// </summary>
    public unsafe struct OrderModifiedOrigClOrdIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Prevent Match Exists
    /// </summary>
    public unsafe struct OrderModifiedPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Price Exists
    /// </summary>
    public unsafe struct OrderModifiedPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct OrderModifiedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Side Exists
    /// </summary>
    public unsafe struct OrderModifiedSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Stop Px Exists
    /// </summary>
    public unsafe struct OrderModifiedStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Symbol Exists
    /// </summary>
    public unsafe struct OrderModifiedSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Time In Force Exists
    /// </summary>
    public unsafe struct OrderModifiedTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Qty
    /// </summary>
    public unsafe struct OrderQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Reject Reason Values
    /// </summary>
    public enum OrderRejectReason : byte {
        Admin = (byte)'A',
        UnknownMaturityDate = (byte)'B',
        UnknownProductName = (byte)'C',
        DuplicateIdentifier = (byte)'D',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        LiquidityAvailableExceedsOrderSize = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        RiskManagementConfigurationIsInsufficient = (byte)'n',
        MaxOpenOrdersCountExceeded = (byte)'o',
        RiskManagementProductLevel = (byte)'s',
        OrderReceivedByCfeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
    };


    /// <summary>
    ///  Order Rejected Account Exists
    /// </summary>
    public unsafe struct OrderRejectedAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Bitfield Count
    /// </summary>
    public unsafe struct OrderRejectedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Rejected Capacity Exists
    /// </summary>
    public unsafe struct OrderRejectedCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Clearing Account Exists
    /// </summary>
    public unsafe struct OrderRejectedClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Clearing Firm Exists
    /// </summary>
    public unsafe struct OrderRejectedClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Cmta Number Exists
    /// </summary>
    public unsafe struct OrderRejectedCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Cti Code Exists
    /// </summary>
    public unsafe struct OrderRejectedCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Frequent Trader Id Exists
    /// </summary>
    public unsafe struct OrderRejectedFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Manual Order Indicator Exists
    /// </summary>
    public unsafe struct OrderRejectedManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Maturity Date Exists
    /// </summary>
    public unsafe struct OrderRejectedMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Min Qty Exists
    /// </summary>
    public unsafe struct OrderRejectedMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Oeoid Exists
    /// </summary>
    public unsafe struct OrderRejectedOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Open Close Exists
    /// </summary>
    public unsafe struct OrderRejectedOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Ord Type Exists
    /// </summary>
    public unsafe struct OrderRejectedOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Order Qty Exists
    /// </summary>
    public unsafe struct OrderRejectedOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Prevent Match Exists
    /// </summary>
    public unsafe struct OrderRejectedPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Price Exists
    /// </summary>
    public unsafe struct OrderRejectedPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct OrderRejectedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Side Exists
    /// </summary>
    public unsafe struct OrderRejectedSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Stop Px Exists
    /// </summary>
    public unsafe struct OrderRejectedStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Symbol Exists
    /// </summary>
    public unsafe struct OrderRejectedSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Time In Force Exists
    /// </summary>
    public unsafe struct OrderRejectedTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Orig Cl Ord Id
    /// </summary>
    public unsafe struct OrigClOrdId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Orig Time
    /// </summary>
    public unsafe struct OrigTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Param Group Length
    /// </summary>
    public unsafe struct ParamGroupLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Param Group Type Values
    /// </summary>
    public enum ParamGroupType : byte {
        UnitSequences = 0x80,
        ReturnBitfields = 0x81,
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
    ///  Pending Status Values
    /// </summary>
    public enum PendingStatus : byte {
        NotApplicable = (byte)'N',
        Pending = (byte)'P',
    };


    /// <summary>
    ///  Prevent Match
    /// </summary>
    public unsafe struct PreventMatch {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Product Name
    /// </summary>
    public unsafe struct ProductName {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Purge Order Bitfield Count
    /// </summary>
    public unsafe struct PurgeOrderBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Purge Order Clearing Firm Exists
    /// </summary>
    public unsafe struct PurgeOrderClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Manual Order Indicator Exists
    /// </summary>
    public unsafe struct PurgeOrderManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Mass Cancel Id Exists
    /// </summary>
    public unsafe struct PurgeOrderMassCancelIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Mass Cancel Inst Exists
    /// </summary>
    public unsafe struct PurgeOrderMassCancelInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Oeoid Exists
    /// </summary>
    public unsafe struct PurgeOrderOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Product Name Exists
    /// </summary>
    public unsafe struct PurgeOrderProductNameExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct PurgeOrderReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Reject Reason Values
    /// </summary>
    public enum PurgeRejectReason : byte {
        Admin = (byte)'A',
        UnknownMaturityDate = (byte)'B',
        UnknownProductName = (byte)'C',
        DuplicateIdentifier = (byte)'D',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        LiquidityAvailableExceedsOrderSize = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        RiskManagementConfigurationIsInsufficient = (byte)'n',
        MaxOpenOrdersCountExceeded = (byte)'o',
        RiskManagementProductLevel = (byte)'s',
        OrderReceivedByCfeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
    };


    /// <summary>
    ///  Purge Rejected Bitfield Count
    /// </summary>
    public unsafe struct PurgeRejectedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Purge Rejected Mass Cancel Id Exists
    /// </summary>
    public unsafe struct PurgeRejectedMassCancelIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Rejected Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct PurgeRejectedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Quote Liquidity Indicator Values
    /// </summary>
    public enum QuoteLiquidityIndicator : byte {
        CarriedOrderIndicator = (byte)'C',
        MarketTurner = (byte)'U',
        Normal = (byte)'N',
    };


    /// <summary>
    ///  Quote Reject Reason
    /// </summary>
    public unsafe struct QuoteRejectReason {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Restatement Reason
    /// </summary>
    public unsafe struct QuoteRestatementReason {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Result Values
    /// </summary>
    public enum QuoteResult : byte {
        NewQuote = (byte)'A',
        ModifiedLossOfPriority = (byte)'L',
        ModifiedRetainsPriority = (byte)'R',
        NoChangeMatchesExistingQuote = (byte)'N',
        NewQuoteButMayRemoveLiquidity = (byte)'D',
        ModifiedButMayRemoveLiquidity = (byte)'d',
        UserCancelled = (byte)'U',
        AdminRejection = (byte)'a',
        RejectedCantPost = (byte)'P',
        RiskManagementFirmOrCustomGroupIdLevel = (byte)'f',
        RejectedSymbolNotFound = (byte)'S',
        RejectedInvalidPrice = (byte)'p',
        RiskManagementRiskRootLevel = (byte)'s',
        RejectedOtherReason = (byte)'u',
    };


    /// <summary>
    ///  Quote Update Id
    /// </summary>
    public unsafe struct QuoteUpdateId {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 12
    /// </summary>
    public unsafe struct Reserved12 {
        public const int Size = 12;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 16
    /// </summary>
    public unsafe struct Reserved16 {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 17
    /// </summary>
    public unsafe struct Reserved17 {
        public const int Size = 17;

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
    ///  Reserved 6
    /// </summary>
    public unsafe struct Reserved6 {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Internal
    /// </summary>
    public unsafe struct ReservedInternal {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Risk Reset Values
    /// </summary>
    public enum RiskReset : ulong {
        ProductlevelRiskLockoutReset = "S",
        FirmlevelLockoutReset = "F",
        CustomGroupIdLockoutReset = "C",
    };


    /// <summary>
    ///  Risk Reset Result Values
    /// </summary>
    public enum RiskResetResult : byte {
        Ignored = (byte)' ',
        Success = (byte)'Y',
        RejectedExceedsFirmResetLimit = (byte)'F',
        RejectedExceedsCustomGroupIdLimit = (byte)'C',
        RejectedEmptyResetRiskField = (byte)'E',
        RejectedIncorrectDataCenter = (byte)'I',
        RejectedExceedsProductLevelResetLimit = (byte)'S',
        RejectedInvalidRiskRoot = (byte)'U',
        RejectedInvalidEfidOrClearingFirm = (byte)'c',
        RejectedInReplay = (byte)'y',
    };


    /// <summary>
    ///  Risk Status Id
    /// </summary>
    public unsafe struct RiskStatusId {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secondary Exec Id
    /// </summary>
    public unsafe struct SecondaryExecId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Secondary Order Id
    /// </summary>
    public unsafe struct SecondaryOrderId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Session Sub Id
    /// </summary>
    public unsafe struct SessionSubId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Buy = (byte)'1',
        Sell = (byte)'2',
    };


    /// <summary>
    ///  Size Modifier Values
    /// </summary>
    public enum SizeModifier : byte {
        Reduce = (byte)'R',
    };


    /// <summary>
    ///  Start Of Message
    /// </summary>
    public unsafe struct StartOfMessage {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stop Px
    /// </summary>
    public struct StopPx {
        public long Raw;
    };


    /// <summary>
    ///  Sub Liquidity Indicator Values
    /// </summary>
    public enum SubLiquidityIndicator : byte {
        CarriedOrderIndicator = (byte)'C',
        QualifyingMarketTurnerOrder = (byte)'U',
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
    ///  Tas Restatement Account Exists
    /// </summary>
    public unsafe struct TasRestatementAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Bitfield Count
    /// </summary>
    public unsafe struct TasRestatementBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tas Restatement Capacity Exists
    /// </summary>
    public unsafe struct TasRestatementCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Clearing Account Exists
    /// </summary>
    public unsafe struct TasRestatementClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Clearing Firm Exists
    /// </summary>
    public unsafe struct TasRestatementClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Clearing Price Exists
    /// </summary>
    public unsafe struct TasRestatementClearingPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Clearing Size Exists
    /// </summary>
    public unsafe struct TasRestatementClearingSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Clearing Symbol Exists
    /// </summary>
    public unsafe struct TasRestatementClearingSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Cmta Number Exists
    /// </summary>
    public unsafe struct TasRestatementCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Cti Code Exists
    /// </summary>
    public unsafe struct TasRestatementCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Fee Code Exists
    /// </summary>
    public unsafe struct TasRestatementFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Frequent Trader Id Exists
    /// </summary>
    public unsafe struct TasRestatementFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Last Px Exists
    /// </summary>
    public unsafe struct TasRestatementLastPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Last Shares Exists
    /// </summary>
    public unsafe struct TasRestatementLastSharesExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Manual Order Indicator Exists
    /// </summary>
    public unsafe struct TasRestatementManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Maturity Date Exists
    /// </summary>
    public unsafe struct TasRestatementMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Min Qty Exists
    /// </summary>
    public unsafe struct TasRestatementMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Multileg Reporting Type Exists
    /// </summary>
    public unsafe struct TasRestatementMultilegReportingTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Oeoid Exists
    /// </summary>
    public unsafe struct TasRestatementOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Open Close Exists
    /// </summary>
    public unsafe struct TasRestatementOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Ord Type Exists
    /// </summary>
    public unsafe struct TasRestatementOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Order Qty Exists
    /// </summary>
    public unsafe struct TasRestatementOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Orig Cl Ord Id Exists
    /// </summary>
    public unsafe struct TasRestatementOrigClOrdIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Prevent Match Exists
    /// </summary>
    public unsafe struct TasRestatementPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Price Exists
    /// </summary>
    public unsafe struct TasRestatementPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct TasRestatementReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Secondary Exec Id Exists
    /// </summary>
    public unsafe struct TasRestatementSecondaryExecIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Side Exists
    /// </summary>
    public unsafe struct TasRestatementSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Stop Px Exists
    /// </summary>
    public unsafe struct TasRestatementStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Symbol Exists
    /// </summary>
    public unsafe struct TasRestatementSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Time In Force Exists
    /// </summary>
    public unsafe struct TasRestatementTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tas Restatement Trade Date Exists
    /// </summary>
    public unsafe struct TasRestatementTradeDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Text
    /// </summary>
    public unsafe struct Text {
        public const int Size = 60;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Time In Force Values
    /// </summary>
    public enum TimeInForce : byte {
        Day = (byte)'0',
        Gtc = (byte)'1',
        Ioc = (byte)'3',
        Fok = (byte)'4',
        Gtd = (byte)'6',
    };


    /// <summary>
    ///  Trade Cancel Or Correct Bitfield Count
    /// </summary>
    public unsafe struct TradeCancelOrCorrectBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Cancel Or Correct Capacity Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Cmta Number Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Corrected Size Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Maturity Date Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Open Close Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Symbol Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Date
    /// </summary>
    public unsafe struct TradeDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transaction Time
    /// </summary>
    public unsafe struct TransactionTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Number
    /// </summary>
    public unsafe struct UnitNumber {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  User Modify Rejected Bitfield Count
    /// </summary>
    public unsafe struct UserModifyRejectedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct UserModifyRejectedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Username
    /// </summary>
    public unsafe struct Username {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Variance Restatement Account Exists
    /// </summary>
    public unsafe struct VarianceRestatementAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Bitfield Count
    /// </summary>
    public unsafe struct VarianceRestatementBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Variance Restatement Capacity Exists
    /// </summary>
    public unsafe struct VarianceRestatementCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Clearing Account Exists
    /// </summary>
    public unsafe struct VarianceRestatementClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Clearing Firm Exists
    /// </summary>
    public unsafe struct VarianceRestatementClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Clearing Price Exists
    /// </summary>
    public unsafe struct VarianceRestatementClearingPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Clearing Size Exists
    /// </summary>
    public unsafe struct VarianceRestatementClearingSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Clearing Symbol Exists
    /// </summary>
    public unsafe struct VarianceRestatementClearingSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Cmta Number Exists
    /// </summary>
    public unsafe struct VarianceRestatementCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Cti Code Exists
    /// </summary>
    public unsafe struct VarianceRestatementCtiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Fee Code Exists
    /// </summary>
    public unsafe struct VarianceRestatementFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Frequent Trader Id Exists
    /// </summary>
    public unsafe struct VarianceRestatementFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Last Px Exists
    /// </summary>
    public unsafe struct VarianceRestatementLastPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Last Shares Exists
    /// </summary>
    public unsafe struct VarianceRestatementLastSharesExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Manual Order Indicator Exists
    /// </summary>
    public unsafe struct VarianceRestatementManualOrderIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Maturity Date Exists
    /// </summary>
    public unsafe struct VarianceRestatementMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Min Qty Exists
    /// </summary>
    public unsafe struct VarianceRestatementMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Multileg Reporting Type Exists
    /// </summary>
    public unsafe struct VarianceRestatementMultilegReportingTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Oeoid Exists
    /// </summary>
    public unsafe struct VarianceRestatementOeoidExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Open Close Exists
    /// </summary>
    public unsafe struct VarianceRestatementOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Ord Type Exists
    /// </summary>
    public unsafe struct VarianceRestatementOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Orig Cl Ord Id Exists
    /// </summary>
    public unsafe struct VarianceRestatementOrigClOrdIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Prevent Match Exists
    /// </summary>
    public unsafe struct VarianceRestatementPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Price Exists
    /// </summary>
    public unsafe struct VarianceRestatementPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct VarianceRestatementReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Secondary Exec Id Exists
    /// </summary>
    public unsafe struct VarianceRestatementSecondaryExecIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Side Exists
    /// </summary>
    public unsafe struct VarianceRestatementSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Stop Px Exists
    /// </summary>
    public unsafe struct VarianceRestatementStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Symbol Exists
    /// </summary>
    public unsafe struct VarianceRestatementSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Time In Force Exists
    /// </summary>
    public unsafe struct VarianceRestatementTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Variance Restatement Trade Date Exists
    /// </summary>
    public unsafe struct VarianceRestatementTradeDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Working Price
    /// </summary>
    public unsafe struct WorkingPrice {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Cancel Order Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelOrderByte1 {
        CancelOrderOeoidExists CancelOrderOeoidExists;
        CancelOrderManualOrderIndicatorExists CancelOrderManualOrderIndicatorExists;
        CancelOrderReservedBit6Exists CancelOrderReservedBit6Exists;
        CancelOrderMassCancelIdExists CancelOrderMassCancelIdExists;
        CancelOrderProductNameExists CancelOrderProductNameExists;
        CancelOrderReservedBit3Exists CancelOrderReservedBit3Exists;
        CancelOrderReservedBit2Exists CancelOrderReservedBit2Exists;
        CancelOrderClearingFirmExists CancelOrderClearingFirmExists;
    };


    /// <summary>
    ///  Struct for Cancel Order Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelOrderByte2 {
        CancelOrderReservedBit8Exists CancelOrderReservedBit8Exists;
        CancelOrderReservedBit7Exists CancelOrderReservedBit7Exists;
        CancelOrderReservedBit6Exists CancelOrderReservedBit6Exists;
        CancelOrderReservedBit5Exists CancelOrderReservedBit5Exists;
        CancelOrderReservedBit4Exists CancelOrderReservedBit4Exists;
        CancelOrderReservedBit3Exists CancelOrderReservedBit3Exists;
        CancelOrderReservedBit2Exists CancelOrderReservedBit2Exists;
        CancelOrderMassCancelInstExists CancelOrderMassCancelInstExists;
    };


    /// <summary>
    ///  Struct for Cancel Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelOrderMessage {
        OrigClOrdId OrigClOrdId;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte1 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedMinQtyExists CancelRejectedMinQtyExists;
        CancelRejectedTimeInForceExists CancelRejectedTimeInForceExists;
        CancelRejectedOrdTypeExists CancelRejectedOrdTypeExists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedPriceExists CancelRejectedPriceExists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedSideExists CancelRejectedSideExists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte10 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte11 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte12 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedOeoidExists CancelRejectedOeoidExists;
        CancelRejectedManualOrderIndicatorExists CancelRejectedManualOrderIndicatorExists;
        CancelRejectedCtiCodeExists CancelRejectedCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte13 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte14 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte15 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte16 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte17 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte2 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedCapacityExists CancelRejectedCapacityExists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedSymbolExists CancelRejectedSymbolExists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte3 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte4 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedOpenCloseExists CancelRejectedOpenCloseExists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedMaturityDateExists CancelRejectedMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte5 {
        CancelRejectedExpireTimeExists CancelRejectedExpireTimeExists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte6 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte7 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte8 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedReservedBit6Exists CancelRejectedReservedBit6Exists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedStopPxExists CancelRejectedStopPxExists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte9 {
        CancelRejectedReservedBit8Exists CancelRejectedReservedBit8Exists;
        CancelRejectedReservedBit7Exists CancelRejectedReservedBit7Exists;
        CancelRejectedCmtaNumberExists CancelRejectedCmtaNumberExists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        CancelRejectReason CancelRejectReason;
        Text Text;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Login Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LoginRequestMessage {
        SessionSubId SessionSubId;
        Username Username;
        Password Password;
        NumberOfParamGroups NumberOfParamGroups;
    };


    /// <summary>
    ///  Struct for Logout Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogoutMessage {
        LogoutReason LogoutReason;
        LogoutReasonText LogoutReasonText;
        LastReceivedSequenceNumber LastReceivedSequenceNumber;
        NumberOfUnits NumberOfUnits;
    };


    /// <summary>
    ///  Struct for Mass Cancel Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassCancelAcknowledgmentMessage {
        TransactionTime TransactionTime;
        MassCancelId MassCancelId;
        CancelledOrderCount CancelledOrderCount;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        StartOfMessage StartOfMessage;
        MessageLength MessageLength;
        MessageType MessageType;
        MatchingUnit MatchingUnit;
        SequenceNumber SequenceNumber;
    };


    /// <summary>
    ///  Struct for Modify Order Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderByte1 {
        ModifyOrderSideExists ModifyOrderSideExists;
        ModifyOrderExecInstExists ModifyOrderExecInstExists;
        ModifyOrderCancelOrigOnRejectExists ModifyOrderCancelOrigOnRejectExists;
        ModifyOrderOrdTypeExists ModifyOrderOrdTypeExists;
        ModifyOrderPriceExists ModifyOrderPriceExists;
        ModifyOrderOrderQtyExists ModifyOrderOrderQtyExists;
        ModifyOrderReservedBit2Exists ModifyOrderReservedBit2Exists;
        ModifyOrderClearingFirmExists ModifyOrderClearingFirmExists;
    };


    /// <summary>
    ///  Struct for Modify Order Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderByte2 {
        ModifyOrderReservedBit8Exists ModifyOrderReservedBit8Exists;
        ModifyOrderReservedBit7Exists ModifyOrderReservedBit7Exists;
        ModifyOrderFrequentTraderIdExists ModifyOrderFrequentTraderIdExists;
        ModifyOrderOeoidExists ModifyOrderOeoidExists;
        ModifyOrderManualOrderIndicatorExists ModifyOrderManualOrderIndicatorExists;
        ModifyOrderReservedBit3Exists ModifyOrderReservedBit3Exists;
        ModifyOrderStopPxExists ModifyOrderStopPxExists;
        ModifyOrderReservedBit1Exists ModifyOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Modify Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ModifyOrderMessage {
        ClOrdId ClOrdId;
        OrigClOrdId OrigClOrdId;
    };


    /// <summary>
    ///  Struct for New Order Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte1 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderMinQtyExists NewOrderMinQtyExists;
        NewOrderTimeInForceExists NewOrderTimeInForceExists;
        NewOrderOrdTypeExists NewOrderOrdTypeExists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderPriceExists NewOrderPriceExists;
        NewOrderClearingAccountExists NewOrderClearingAccountExists;
        NewOrderClearingFirmExists NewOrderClearingFirmExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte2 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderCapacityExists NewOrderCapacityExists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderReservedBit2Exists NewOrderReservedBit2Exists;
        NewOrderSymbolExists NewOrderSymbolExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte3 {
        NewOrderExpireTimeExists NewOrderExpireTimeExists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderPreventMatchExists NewOrderPreventMatchExists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderReservedBit2Exists NewOrderReservedBit2Exists;
        NewOrderAccountExists NewOrderAccountExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte4 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderCmtaNumberExists NewOrderCmtaNumberExists;
        NewOrderOpenCloseExists NewOrderOpenCloseExists;
        NewOrderRiskResetExists NewOrderRiskResetExists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderReservedBit2Exists NewOrderReservedBit2Exists;
        NewOrderMaturityDateExists NewOrderMaturityDateExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte5 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderReservedBit2Exists NewOrderReservedBit2Exists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte6 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderStopPxExists NewOrderStopPxExists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte7 {
        NewOrderOeoidExists NewOrderOeoidExists;
        NewOrderManualOrderIndicatorExists NewOrderManualOrderIndicatorExists;
        NewOrderCtiCodeExists NewOrderCtiCodeExists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderCustomGroupIdExists NewOrderCustomGroupIdExists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte8 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderFrequentTraderIdExists NewOrderFrequentTraderIdExists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderReservedBit2Exists NewOrderReservedBit2Exists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderMessage {
        ClOrdId ClOrdId;
        Side Side;
        OrderQty OrderQty;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte1 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentMinQtyExists OrderAcknowledgmentMinQtyExists;
        OrderAcknowledgmentTimeInForceExists OrderAcknowledgmentTimeInForceExists;
        OrderAcknowledgmentOrdTypeExists OrderAcknowledgmentOrdTypeExists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentPriceExists OrderAcknowledgmentPriceExists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentSideExists OrderAcknowledgmentSideExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte10 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte11 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte12 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentOeoidExists OrderAcknowledgmentOeoidExists;
        OrderAcknowledgmentManualOrderIndicatorExists OrderAcknowledgmentManualOrderIndicatorExists;
        OrderAcknowledgmentCtiCodeExists OrderAcknowledgmentCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte13 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentDayAvgPxExists OrderAcknowledgmentDayAvgPxExists;
        OrderAcknowledgmentAvgPxExists OrderAcknowledgmentAvgPxExists;
        OrderAcknowledgmentDayCumQtyExists OrderAcknowledgmentDayCumQtyExists;
        OrderAcknowledgmentDayOrderQtyExists OrderAcknowledgmentDayOrderQtyExists;
        OrderAcknowledgmentCumQtyExists OrderAcknowledgmentCumQtyExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte14 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte15 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte16 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentFrequentTraderIdExists OrderAcknowledgmentFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte17 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte2 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentCapacityExists OrderAcknowledgmentCapacityExists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentSymbolExists OrderAcknowledgmentSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte3 {
        OrderAcknowledgmentPreventMatchExists OrderAcknowledgmentPreventMatchExists;
        OrderAcknowledgmentOrderQtyExists OrderAcknowledgmentOrderQtyExists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentClearingAccountExists OrderAcknowledgmentClearingAccountExists;
        OrderAcknowledgmentClearingFirmExists OrderAcknowledgmentClearingFirmExists;
        OrderAcknowledgmentAccountExists OrderAcknowledgmentAccountExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte4 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentOpenCloseExists OrderAcknowledgmentOpenCloseExists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentMaturityDateExists OrderAcknowledgmentMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte5 {
        OrderAcknowledgmentExpireTimeExists OrderAcknowledgmentExpireTimeExists;
        OrderAcknowledgmentBaseLiquidityIndicatorExists OrderAcknowledgmentBaseLiquidityIndicatorExists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentLeavesQtyExists OrderAcknowledgmentLeavesQtyExists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte6 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte7 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentSubLiquidityIndicatorExists OrderAcknowledgmentSubLiquidityIndicatorExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte8 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentStopPxExists OrderAcknowledgmentStopPxExists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte9 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentCmtaNumberExists OrderAcknowledgmentCmtaNumberExists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        OrderId OrderId;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte1 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledMinQtyExists OrderCancelledMinQtyExists;
        OrderCancelledTimeInForceExists OrderCancelledTimeInForceExists;
        OrderCancelledOrdTypeExists OrderCancelledOrdTypeExists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledPriceExists OrderCancelledPriceExists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledSideExists OrderCancelledSideExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte10 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte11 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte12 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledOeoidExists OrderCancelledOeoidExists;
        OrderCancelledManualOrderIndicatorExists OrderCancelledManualOrderIndicatorExists;
        OrderCancelledCtiCodeExists OrderCancelledCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte13 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte14 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte15 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte16 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledFrequentTraderIdExists OrderCancelledFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte17 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte2 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledCapacityExists OrderCancelledCapacityExists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledSymbolExists OrderCancelledSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte3 {
        OrderCancelledPreventMatchExists OrderCancelledPreventMatchExists;
        OrderCancelledOrderQtyExists OrderCancelledOrderQtyExists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledClearingAccountExists OrderCancelledClearingAccountExists;
        OrderCancelledClearingFirmExists OrderCancelledClearingFirmExists;
        OrderCancelledAccountExists OrderCancelledAccountExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte4 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledOpenCloseExists OrderCancelledOpenCloseExists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledMaturityDateExists OrderCancelledMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte5 {
        OrderCancelledExpireTimeExists OrderCancelledExpireTimeExists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledLastPxExists OrderCancelledLastPxExists;
        OrderCancelledLastSharesExists OrderCancelledLastSharesExists;
        OrderCancelledLeavesQtyExists OrderCancelledLeavesQtyExists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte6 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledSecondaryOrderIdExists OrderCancelledSecondaryOrderIdExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte7 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte8 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledStopPxExists OrderCancelledStopPxExists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte9 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledCmtaNumberExists OrderCancelledCmtaNumberExists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        CancelReason CancelReason;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte1 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionMinQtyExists OrderExecutionMinQtyExists;
        OrderExecutionTimeInForceExists OrderExecutionTimeInForceExists;
        OrderExecutionOrdTypeExists OrderExecutionOrdTypeExists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionPriceExists OrderExecutionPriceExists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionSideExists OrderExecutionSideExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte10 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte11 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte12 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionClearingSizeExists OrderExecutionClearingSizeExists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionTradeDateExists OrderExecutionTradeDateExists;
        OrderExecutionOeoidExists OrderExecutionOeoidExists;
        OrderExecutionManualOrderIndicatorExists OrderExecutionManualOrderIndicatorExists;
        OrderExecutionCtiCodeExists OrderExecutionCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte13 {
        OrderExecutionMultilegReportingTypeExists OrderExecutionMultilegReportingTypeExists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionPendingStatusExists OrderExecutionPendingStatusExists;
        OrderExecutionDayAvgPxExists OrderExecutionDayAvgPxExists;
        OrderExecutionAvgPxExists OrderExecutionAvgPxExists;
        OrderExecutionDayCumQtyExists OrderExecutionDayCumQtyExists;
        OrderExecutionDayOrderQtyExists OrderExecutionDayOrderQtyExists;
        OrderExecutionCumQtyExists OrderExecutionCumQtyExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte14 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionSecondaryExecIdExists OrderExecutionSecondaryExecIdExists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte15 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte16 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionFrequentTraderIdExists OrderExecutionFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte17 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte2 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionCapacityExists OrderExecutionCapacityExists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionSymbolExists OrderExecutionSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte3 {
        OrderExecutionPreventMatchExists OrderExecutionPreventMatchExists;
        OrderExecutionOrderQtyExists OrderExecutionOrderQtyExists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionClearingAccountExists OrderExecutionClearingAccountExists;
        OrderExecutionClearingFirmExists OrderExecutionClearingFirmExists;
        OrderExecutionAccountExists OrderExecutionAccountExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte4 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionOpenCloseExists OrderExecutionOpenCloseExists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionMaturityDateExists OrderExecutionMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte5 {
        OrderExecutionExpireTimeExists OrderExecutionExpireTimeExists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte6 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte7 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte8 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionStopPxExists OrderExecutionStopPxExists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionFeeCodeExists OrderExecutionFeeCodeExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte9 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionCmtaNumberExists OrderExecutionCmtaNumberExists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        ExecId ExecId;
        LastShares LastShares;
        LastPx LastPx;
        LeavesQty LeavesQty;
        BaseLiquidityIndicator BaseLiquidityIndicator;
        SubLiquidityIndicator SubLiquidityIndicator;
        ContraBroker ContraBroker;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte1 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedMinQtyExists OrderModifiedMinQtyExists;
        OrderModifiedTimeInForceExists OrderModifiedTimeInForceExists;
        OrderModifiedOrdTypeExists OrderModifiedOrdTypeExists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedPriceExists OrderModifiedPriceExists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedSideExists OrderModifiedSideExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte10 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte11 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte12 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedOeoidExists OrderModifiedOeoidExists;
        OrderModifiedManualOrderIndicatorExists OrderModifiedManualOrderIndicatorExists;
        OrderModifiedCtiCodeExists OrderModifiedCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte13 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte14 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte15 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte16 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedFrequentTraderIdExists OrderModifiedFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte17 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte2 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedCapacityExists OrderModifiedCapacityExists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedSymbolExists OrderModifiedSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte3 {
        OrderModifiedPreventMatchExists OrderModifiedPreventMatchExists;
        OrderModifiedOrderQtyExists OrderModifiedOrderQtyExists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedClearingAccountExists OrderModifiedClearingAccountExists;
        OrderModifiedClearingFirmExists OrderModifiedClearingFirmExists;
        OrderModifiedAccountExists OrderModifiedAccountExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte4 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedOpenCloseExists OrderModifiedOpenCloseExists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedMaturityDateExists OrderModifiedMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte5 {
        OrderModifiedExpireTimeExists OrderModifiedExpireTimeExists;
        OrderModifiedBaseLiquidityIndicatorExists OrderModifiedBaseLiquidityIndicatorExists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedLeavesQtyExists OrderModifiedLeavesQtyExists;
        OrderModifiedOrigClOrdIdExists OrderModifiedOrigClOrdIdExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte6 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte7 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte8 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedStopPxExists OrderModifiedStopPxExists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte9 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedCmtaNumberExists OrderModifiedCmtaNumberExists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        OrderId OrderId;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte1 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedMinQtyExists OrderRejectedMinQtyExists;
        OrderRejectedTimeInForceExists OrderRejectedTimeInForceExists;
        OrderRejectedOrdTypeExists OrderRejectedOrdTypeExists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedPriceExists OrderRejectedPriceExists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedSideExists OrderRejectedSideExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte10 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte11 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte12 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedOeoidExists OrderRejectedOeoidExists;
        OrderRejectedManualOrderIndicatorExists OrderRejectedManualOrderIndicatorExists;
        OrderRejectedCtiCodeExists OrderRejectedCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte13 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte14 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte15 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte16 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedFrequentTraderIdExists OrderRejectedFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte17 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte2 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedCapacityExists OrderRejectedCapacityExists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedSymbolExists OrderRejectedSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte3 {
        OrderRejectedPreventMatchExists OrderRejectedPreventMatchExists;
        OrderRejectedOrderQtyExists OrderRejectedOrderQtyExists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedClearingAccountExists OrderRejectedClearingAccountExists;
        OrderRejectedClearingFirmExists OrderRejectedClearingFirmExists;
        OrderRejectedAccountExists OrderRejectedAccountExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte4 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedOpenCloseExists OrderRejectedOpenCloseExists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedMaturityDateExists OrderRejectedMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte5 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte6 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte7 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte8 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedStopPxExists OrderRejectedStopPxExists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte9 {
        OrderRejectedReservedBit8Exists OrderRejectedReservedBit8Exists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedCmtaNumberExists OrderRejectedCmtaNumberExists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        OrderRejectReason OrderRejectReason;
        Text Text;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Param Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParamGroup {
        ParamHeader ParamHeader;
    };


    /// <summary>
    ///  Struct for Param Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ParamHeader {
        ParamGroupLength ParamGroupLength;
        ParamGroupType ParamGroupType;
    };


    /// <summary>
    ///  Struct for Purge Order Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeOrderByte1 {
        PurgeOrderOeoidExists PurgeOrderOeoidExists;
        PurgeOrderManualOrderIndicatorExists PurgeOrderManualOrderIndicatorExists;
        PurgeOrderReservedBit6Exists PurgeOrderReservedBit6Exists;
        PurgeOrderMassCancelIdExists PurgeOrderMassCancelIdExists;
        PurgeOrderProductNameExists PurgeOrderProductNameExists;
        PurgeOrderMassCancelInstExists PurgeOrderMassCancelInstExists;
        PurgeOrderReservedBit2Exists PurgeOrderReservedBit2Exists;
        PurgeOrderClearingFirmExists PurgeOrderClearingFirmExists;
    };


    /// <summary>
    ///  Struct for Purge Order Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeOrderByte2 {
        PurgeOrderReservedBit8Exists PurgeOrderReservedBit8Exists;
        PurgeOrderReservedBit7Exists PurgeOrderReservedBit7Exists;
        PurgeOrderReservedBit6Exists PurgeOrderReservedBit6Exists;
        PurgeOrderReservedBit5Exists PurgeOrderReservedBit5Exists;
        PurgeOrderReservedBit4Exists PurgeOrderReservedBit4Exists;
        PurgeOrderReservedBit3Exists PurgeOrderReservedBit3Exists;
        PurgeOrderReservedBit2Exists PurgeOrderReservedBit2Exists;
        PurgeOrderReservedBit1Exists PurgeOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeOrderMessage {
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte1 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte10 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte11 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte12 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte13 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte14 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte15 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedMassCancelIdExists PurgeRejectedMassCancelIdExists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte16 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte17 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte2 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte3 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte4 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte5 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte6 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte7 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte8 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedByte9 {
        PurgeRejectedReservedBit8Exists PurgeRejectedReservedBit8Exists;
        PurgeRejectedReservedBit7Exists PurgeRejectedReservedBit7Exists;
        PurgeRejectedReservedBit6Exists PurgeRejectedReservedBit6Exists;
        PurgeRejectedReservedBit5Exists PurgeRejectedReservedBit5Exists;
        PurgeRejectedReservedBit4Exists PurgeRejectedReservedBit4Exists;
        PurgeRejectedReservedBit3Exists PurgeRejectedReservedBit3Exists;
        PurgeRejectedReservedBit2Exists PurgeRejectedReservedBit2Exists;
        PurgeRejectedReservedBit1Exists PurgeRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Purge Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeRejectedMessage {
        TransactionTime TransactionTime;
        PurgeRejectReason PurgeRejectReason;
        Text Text;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Quote Cancelled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteCancelledMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        OrderId OrderId;
        Symbol Symbol;
        Side Side;
        CancelReason CancelReason;
    };


    /// <summary>
    ///  Struct for Quote Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteExecutionMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        OrderId OrderId;
        ExecId ExecId;
        Symbol Symbol;
        ClearingFirm ClearingFirm;
        LastShares LastShares;
        LastPx LastPx;
        LeavesQty LeavesQty;
        Side Side;
        BaseLiquidityIndicator BaseLiquidityIndicator;
        SubLiquidityIndicator SubLiquidityIndicator;
        FeeCode FeeCode;
    };


    /// <summary>
    ///  Struct for Quote Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteGroup {
        Symbol Symbol;
        Side Side;
        OpenClose OpenClose;
        Price Price;
        OrderQty OrderQty;
        Reserved12 Reserved12;
    };


    /// <summary>
    ///  Struct for Quote Restated Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteRestatedMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        OrderId OrderId;
        LeavesQty LeavesQty;
        WorkingPrice WorkingPrice;
        Symbol Symbol;
        Side Side;
        QuoteRestatementReason QuoteRestatementReason;
    };


    /// <summary>
    ///  Struct for Quote Result Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteResultGroup {
        OrderId OrderId;
        QuoteResult QuoteResult;
        QuoteLiquidityIndicator QuoteLiquidityIndicator;
        Reserved6 Reserved6;
    };


    /// <summary>
    ///  Struct for Quote Update Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteUpdateAcknowledgmentMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        QuoteRejectReason QuoteRejectReason;
        Reserved17 Reserved17;
        NumberOfQuoteResults NumberOfQuoteResults;
    };


    /// <summary>
    ///  Struct for Quote Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteUpdateMessage {
        QuoteUpdateId QuoteUpdateId;
        ClearingFirm ClearingFirm;
        ClearingAccount ClearingAccount;
        CmtaNumber CmtaNumber;
        Account Account;
        CustomGroupId CustomGroupId;
        Capacity Capacity;
        CtiCode CtiCode;
        ManualOrderIndicator ManualOrderIndicator;
        Oeoid Oeoid;
        SizeModifier SizeModifier;
        Reserved6 Reserved6;
        NumberOfQuotes NumberOfQuotes;
    };


    /// <summary>
    ///  Struct for Quote Update Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteUpdateRejectedMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        QuoteRejectReason QuoteRejectReason;
        Reserved17 Reserved17;
    };


    /// <summary>
    ///  Struct for Reset Risk Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResetRiskMessage {
        RiskStatusId RiskStatusId;
        RiskReset RiskReset;
        RiskReset RiskReset;
        Reserved4 Reserved4;
        ClearingFirm ClearingFirm;
        ProductName ProductName;
        CustomGroupId CustomGroupId;
    };


    /// <summary>
    ///  Struct for Return Bitfields
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReturnBitfields {
        ApplicationMessageType ApplicationMessageType;
    };


    /// <summary>
    ///  Struct for Risk Reset Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskResetAcknowledgmentMessage {
        RiskStatusId RiskStatusId;
        RiskResetResult RiskResetResult;
    };


    /// <summary>
    ///  Struct for Tas Quote Restatement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasQuoteRestatementMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        ExecId ExecId;
        Symbol Symbol;
        ClearingSymbol ClearingSymbol;
        ClearingPrice ClearingPrice;
        Reserved16 Reserved16;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte1 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementMinQtyExists TasRestatementMinQtyExists;
        TasRestatementTimeInForceExists TasRestatementTimeInForceExists;
        TasRestatementOrdTypeExists TasRestatementOrdTypeExists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementPriceExists TasRestatementPriceExists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementSideExists TasRestatementSideExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte10 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte11 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte12 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementClearingSymbolExists TasRestatementClearingSymbolExists;
        TasRestatementClearingSizeExists TasRestatementClearingSizeExists;
        TasRestatementClearingPriceExists TasRestatementClearingPriceExists;
        TasRestatementTradeDateExists TasRestatementTradeDateExists;
        TasRestatementOeoidExists TasRestatementOeoidExists;
        TasRestatementManualOrderIndicatorExists TasRestatementManualOrderIndicatorExists;
        TasRestatementCtiCodeExists TasRestatementCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte13 {
        TasRestatementMultilegReportingTypeExists TasRestatementMultilegReportingTypeExists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte14 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementSecondaryExecIdExists TasRestatementSecondaryExecIdExists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte15 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte16 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementFrequentTraderIdExists TasRestatementFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte17 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte2 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementCapacityExists TasRestatementCapacityExists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementSymbolExists TasRestatementSymbolExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte3 {
        TasRestatementPreventMatchExists TasRestatementPreventMatchExists;
        TasRestatementOrderQtyExists TasRestatementOrderQtyExists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementClearingAccountExists TasRestatementClearingAccountExists;
        TasRestatementClearingFirmExists TasRestatementClearingFirmExists;
        TasRestatementAccountExists TasRestatementAccountExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte4 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementOpenCloseExists TasRestatementOpenCloseExists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementMaturityDateExists TasRestatementMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte5 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementLastPxExists TasRestatementLastPxExists;
        TasRestatementLastSharesExists TasRestatementLastSharesExists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementOrigClOrdIdExists TasRestatementOrigClOrdIdExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte6 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte7 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte8 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementReservedBit6Exists TasRestatementReservedBit6Exists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementStopPxExists TasRestatementStopPxExists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementFeeCodeExists TasRestatementFeeCodeExists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementByte9 {
        TasRestatementReservedBit8Exists TasRestatementReservedBit8Exists;
        TasRestatementReservedBit7Exists TasRestatementReservedBit7Exists;
        TasRestatementCmtaNumberExists TasRestatementCmtaNumberExists;
        TasRestatementReservedBit5Exists TasRestatementReservedBit5Exists;
        TasRestatementReservedBit4Exists TasRestatementReservedBit4Exists;
        TasRestatementReservedBit3Exists TasRestatementReservedBit3Exists;
        TasRestatementReservedBit2Exists TasRestatementReservedBit2Exists;
        TasRestatementReservedBit1Exists TasRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Tas Restatement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TasRestatementMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        ExecId ExecId;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte1 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte10 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte11 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte12 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte13 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte14 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte15 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte16 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte17 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte2 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectCapacityExists TradeCancelOrCorrectCapacityExists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectSymbolExists TradeCancelOrCorrectSymbolExists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte3 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte4 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectCorrectedSizeExists TradeCancelOrCorrectCorrectedSizeExists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectOpenCloseExists TradeCancelOrCorrectOpenCloseExists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectMaturityDateExists TradeCancelOrCorrectMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte5 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte6 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte7 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte8 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectByte9 {
        TradeCancelOrCorrectReservedBit8Exists TradeCancelOrCorrectReservedBit8Exists;
        TradeCancelOrCorrectReservedBit7Exists TradeCancelOrCorrectReservedBit7Exists;
        TradeCancelOrCorrectCmtaNumberExists TradeCancelOrCorrectCmtaNumberExists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Trade Cancel Or Correct Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeCancelOrCorrectMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        OrderId OrderId;
        ExecRefId ExecRefId;
        Side Side;
        BaseLiquidityIndicator BaseLiquidityIndicator;
        ClearingFirm ClearingFirm;
        ClearingAccount ClearingAccount;
        LastShares LastShares;
        LastPx LastPx;
        CorrectedPrice CorrectedPrice;
        OrigTime OrigTime;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Unit Sequence
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitSequence {
        UnitNumber UnitNumber;
        SequenceNumber SequenceNumber;
    };


    /// <summary>
    ///  Struct for Unit Sequences
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnitSequences {
        NoUnspecifiedUnitReplay NoUnspecifiedUnitReplay;
        NumberOfUnits NumberOfUnits;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte1 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte10 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte11 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte12 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte13 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte14 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte15 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte16 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte17 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte2 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte3 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte4 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte5 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte6 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte7 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte8 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedByte9 {
        UserModifyRejectedReservedBit8Exists UserModifyRejectedReservedBit8Exists;
        UserModifyRejectedReservedBit7Exists UserModifyRejectedReservedBit7Exists;
        UserModifyRejectedReservedBit6Exists UserModifyRejectedReservedBit6Exists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedReservedBit4Exists UserModifyRejectedReservedBit4Exists;
        UserModifyRejectedReservedBit3Exists UserModifyRejectedReservedBit3Exists;
        UserModifyRejectedReservedBit2Exists UserModifyRejectedReservedBit2Exists;
        UserModifyRejectedReservedBit1Exists UserModifyRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for User Modify Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserModifyRejectedMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        ModifyRejectReason ModifyRejectReason;
        Text Text;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Variance Quote Restatement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceQuoteRestatementMessage {
        TransactionTime TransactionTime;
        QuoteUpdateId QuoteUpdateId;
        ExecId ExecId;
        Symbol Symbol;
        ClearingSymbol ClearingSymbol;
        ClearingPrice ClearingPrice;
        ClearingSize ClearingSize;
        Reserved16 Reserved16;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte1 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementMinQtyExists VarianceRestatementMinQtyExists;
        VarianceRestatementTimeInForceExists VarianceRestatementTimeInForceExists;
        VarianceRestatementOrdTypeExists VarianceRestatementOrdTypeExists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementPriceExists VarianceRestatementPriceExists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementSideExists VarianceRestatementSideExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte10 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte11 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte12 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementClearingSymbolExists VarianceRestatementClearingSymbolExists;
        VarianceRestatementClearingSizeExists VarianceRestatementClearingSizeExists;
        VarianceRestatementClearingPriceExists VarianceRestatementClearingPriceExists;
        VarianceRestatementTradeDateExists VarianceRestatementTradeDateExists;
        VarianceRestatementOeoidExists VarianceRestatementOeoidExists;
        VarianceRestatementManualOrderIndicatorExists VarianceRestatementManualOrderIndicatorExists;
        VarianceRestatementCtiCodeExists VarianceRestatementCtiCodeExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte13 {
        VarianceRestatementMultilegReportingTypeExists VarianceRestatementMultilegReportingTypeExists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte14 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementSecondaryExecIdExists VarianceRestatementSecondaryExecIdExists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte15 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte16 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementFrequentTraderIdExists VarianceRestatementFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte17 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte2 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementCapacityExists VarianceRestatementCapacityExists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementSymbolExists VarianceRestatementSymbolExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte3 {
        VarianceRestatementPreventMatchExists VarianceRestatementPreventMatchExists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementClearingAccountExists VarianceRestatementClearingAccountExists;
        VarianceRestatementClearingFirmExists VarianceRestatementClearingFirmExists;
        VarianceRestatementAccountExists VarianceRestatementAccountExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte4 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementOpenCloseExists VarianceRestatementOpenCloseExists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementMaturityDateExists VarianceRestatementMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte5 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementLastPxExists VarianceRestatementLastPxExists;
        VarianceRestatementLastSharesExists VarianceRestatementLastSharesExists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementOrigClOrdIdExists VarianceRestatementOrigClOrdIdExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte6 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte7 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte8 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementReservedBit6Exists VarianceRestatementReservedBit6Exists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementStopPxExists VarianceRestatementStopPxExists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementFeeCodeExists VarianceRestatementFeeCodeExists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementByte9 {
        VarianceRestatementReservedBit8Exists VarianceRestatementReservedBit8Exists;
        VarianceRestatementReservedBit7Exists VarianceRestatementReservedBit7Exists;
        VarianceRestatementCmtaNumberExists VarianceRestatementCmtaNumberExists;
        VarianceRestatementReservedBit5Exists VarianceRestatementReservedBit5Exists;
        VarianceRestatementReservedBit4Exists VarianceRestatementReservedBit4Exists;
        VarianceRestatementReservedBit3Exists VarianceRestatementReservedBit3Exists;
        VarianceRestatementReservedBit2Exists VarianceRestatementReservedBit2Exists;
        VarianceRestatementReservedBit1Exists VarianceRestatementReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Variance Restatement Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct VarianceRestatementMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        ExecId ExecId;
        ReservedInternal ReservedInternal;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
