namespace Cboe.Edgx.Equities.OrderEntry.Boe.v2.3 {

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
        OrderRestated = 0x28,
        UserModifyRejected = 0x29,
        OrderCancelled = 0x2A,
        CancelRejected = 0x2B,
        OrderExecution = 0x2C,
        TradeCancelOrCorrect = 0x2D,
        PurgeRejected = 0x48,
    };


    /// <summary>
    ///  Attributed Quote Values
    /// </summary>
    public enum AttributedQuote : byte {
        DoNotAttributeFirmMpid = (byte)'N',
        AttributeFirmMpid = (byte)'Y',
        AttributeRtal = (byte)'R',
    };


    /// <summary>
    ///  Base Liquidity Indicator Values
    /// </summary>
    public enum BaseLiquidityIndicator : byte {
        AddedLiquidity = (byte)'A',
        RemovedLiquidity = (byte)'R',
        RoutedToAnotherMarket = (byte)'X',
        AuctionOrUncrossing = (byte)'C',
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
    ///  Cancel Order Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct CancelOrderReservedBit1Exists {
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
    ///  Cancel Orig On Reject
    /// </summary>
    public unsafe struct CancelOrigOnReject {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cancel Reason Values
    /// </summary>
    public enum CancelReason : byte {
        Admin = (byte)'A',
        DuplicateIdentifier = (byte)'D',
        SizeReductionDueToSwpRestatement = (byte)'E',
        FailedToQuote = (byte)'F',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        OrderWouldLockOrCrossNbbo = (byte)'L',
        OrderSizeExceeded = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        WaitingForFirstTrade = (byte)'Q',
        RoutingUnavailable = (byte)'R',
        ShortSalePriceViolation = (byte)'S',
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        LimitUpLimitDown = (byte)'u',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
    };


    /// <summary>
    ///  Cancel Reject Reason Values
    /// </summary>
    public enum CancelRejectReason : byte {
        Admin = (byte)'A',
        DuplicateIdentifier = (byte)'D',
        SizeReductionDueToSwpRestatement = (byte)'E',
        FailedToQuote = (byte)'F',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        OrderWouldLockOrCrossNbbo = (byte)'L',
        OrderSizeExceeded = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        WaitingForFirstTrade = (byte)'Q',
        RoutingUnavailable = (byte)'R',
        ShortSalePriceViolation = (byte)'S',
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        LimitUpLimitDown = (byte)'u',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
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
    ///  Cancel Rejected Echo Text Exists
    /// </summary>
    public unsafe struct CancelRejectedEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Exec Inst Exists
    /// </summary>
    public unsafe struct CancelRejectedExecInstExists {
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
    ///  Cancel Rejected Ord Type Exists
    /// </summary>
    public unsafe struct CancelRejectedOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Peg Difference Exists
    /// </summary>
    public unsafe struct CancelRejectedPegDifferenceExists {
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
    ///  Cancel Rejected Rout Strategy Exists
    /// </summary>
    public unsafe struct CancelRejectedRoutStrategyExists {
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
    ///  Cancel Rejected Symbol Sfx Exists
    /// </summary>
    public unsafe struct CancelRejectedSymbolSfxExists {
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
        Agency = (byte)'A',
        Principal = (byte)'P',
        RisklessPrincipal = (byte)'R',
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
    ///  Custom Group Id
    /// </summary>
    public unsafe struct CustomGroupId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Discretion Amount
    /// </summary>
    public unsafe struct DiscretionAmount {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Display Indicator Values
    /// </summary>
    public enum DisplayIndicator : byte {
        DeterminedByPortLevelSetting = (byte)'V',
        PriceAdjust = (byte)'P',
        MultiplePriceAdjust = (byte)'m',
        RejectTheOrderIfItCannotBeBookedAndDisplayedWithoutAdjustment = (byte)'m',
        CancelBackTheOrderIfItCannotBeBookedAndDisplayedWithoutAdjustment = (byte)'R',
        HiddenCancelBackTheOrderIfItCannotBeBookedWithoutAdjustment = (byte)'r',
        DisplayPriceSliding = (byte)'S',
        DisplayPriceSlidingButRejectIfOrderCrossesTheNbboOnEntry = (byte)'L',
        MultipleDisplayPriceSliding = (byte)'M',
        Visible = (byte)'v',
        Invisible = (byte)'I',
        NoRescrapeAtLimit = (byte)'N',
    };


    /// <summary>
    ///  Display Price
    /// </summary>
    public struct DisplayPrice {
        public long Raw;
    };


    /// <summary>
    ///  Display Range
    /// </summary>
    public unsafe struct DisplayRange {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Echo Text
    /// </summary>
    public unsafe struct EchoText {
        public const int Size = 64;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ex Destination Values
    /// </summary>
    public enum ExDestination : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        MiaxPearl = (byte)'H',
        InvestorsExchange = (byte)'I',
        Edga = (byte)'J',
        LongTermStockExchange = (byte)'L',
        Chx = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'U',
        Nasdaq = (byte)'Q',
        Memx = (byte)'Q',
        NasdaqPsx = (byte)'X',
        Byx = (byte)'Y',
        Bzx = (byte)'Y',
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
    ///  Exec Inst Values
    /// </summary>
    public enum ExecInst : byte {
        IntermarketSweep = (byte)'f',
        MarketPeg = (byte)'P',
        MarketMarkerPeg = (byte)'Q',
        PrimaryPeg = (byte)'Q',
        SupplementalPegOrder = (byte)'U',
        MidpointPeg = (byte)'M',
        MidpointPegButNoMatchOnNbboLock = (byte)'m',
        AlternateMidpoint = (byte)'L',
        MidpointDiscretionaryOrder = (byte)'d',
        ListingMarketOpening = (byte)'o',
        ListingMarketClose = (byte)'c',
        BothListingMarketOpenAndClose = (byte)'a',
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
    ///  Ext Exec Inst Values
    /// </summary>
    public enum ExtExecInst : byte {
        None = (byte)'N',
        OrderEligibleForRetailRebate = (byte)'R',
        RetailPriorityOrder = (byte)'X',
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
    ///  Max Floor
    /// </summary>
    public unsafe struct MaxFloor {
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
        PurgeOrderMessage = 0x47,
        OrderAcknowledgmentMessage = 0x25,
        OrderRejectedMessage = 0x26,
        OrderModifiedMessage = 0x27,
        OrderRestatedMessage = 0x28,
        UserModifyRejectedMessage = 0x29,
        OrderCancelledMessage = 0x2A,
        CancelRejectedMessage = 0x2B,
        OrderExecutionMessage = 0x2C,
        TradeCancelOrCorrectMessage = 0x2D,
        MassCancelAcknowledgmentMessage = 0x36,
        PurgeRejectedMessage = 0x48,
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
    ///  Modify Order Max Floor Exists
    /// </summary>
    public unsafe struct ModifyOrderMaxFloorExists {
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
    ///  Modify Order Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Modify Order Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct ModifyOrderReservedBit6Exists {
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
        DuplicateIdentifier = (byte)'D',
        SizeReductionDueToSwpRestatement = (byte)'E',
        FailedToQuote = (byte)'F',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        OrderWouldLockOrCrossNbbo = (byte)'L',
        OrderSizeExceeded = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        WaitingForFirstTrade = (byte)'Q',
        RoutingUnavailable = (byte)'R',
        ShortSalePriceViolation = (byte)'S',
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        LimitUpLimitDown = (byte)'u',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
    };


    /// <summary>
    ///  New Order Account Exists
    /// </summary>
    public unsafe struct NewOrderAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Attributed Quote Exists
    /// </summary>
    public unsafe struct NewOrderAttributedQuoteExists {
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
    ///  New Order Custom Group Id Exists
    /// </summary>
    public unsafe struct NewOrderCustomGroupIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Discretion Amount Exists
    /// </summary>
    public unsafe struct NewOrderDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Display Indicator Exists
    /// </summary>
    public unsafe struct NewOrderDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Display Range Exists
    /// </summary>
    public unsafe struct NewOrderDisplayRangeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Echo Text Exists
    /// </summary>
    public unsafe struct NewOrderEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Ex Destination Exists
    /// </summary>
    public unsafe struct NewOrderExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Exec Inst Exists
    /// </summary>
    public unsafe struct NewOrderExecInstExists {
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
    ///  New Order Ext Exec Inst Exists
    /// </summary>
    public unsafe struct NewOrderExtExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Locate Reqd Exists
    /// </summary>
    public unsafe struct NewOrderLocateReqdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Max Floor Exists
    /// </summary>
    public unsafe struct NewOrderMaxFloorExists {
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
    ///  New Order Ord Type Exists
    /// </summary>
    public unsafe struct NewOrderOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Peg Difference Exists
    /// </summary>
    public unsafe struct NewOrderPegDifferenceExists {
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
    ///  New Order Rout Strategy Exists
    /// </summary>
    public unsafe struct NewOrderRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Route Delivery Method Exists
    /// </summary>
    public unsafe struct NewOrderRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Routing Inst Exists
    /// </summary>
    public unsafe struct NewOrderRoutingInstExists {
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
    ///  New Order Symbol Sfx Exists
    /// </summary>
    public unsafe struct NewOrderSymbolSfxExists {
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
        Test = (byte)'T',
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
    ///  Number Of Units
    /// </summary>
    public unsafe struct NumberOfUnits {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ord Type Values
    /// </summary>
    public enum OrdType : byte {
        Market = (byte)'1',
        Limit = (byte)'2',
        Stop = (byte)'3',
        StopLimit = (byte)'4',
        Pegged = (byte)'P',
    };


    /// <summary>
    ///  Order Acknowledgment Account Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Attributed Quote Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentAttributedQuoteExists {
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
    ///  Order Acknowledgment Discretion Amount Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Display Indicator Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Display Price Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDisplayPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Echo Text Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Ex Destination Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Exec Inst Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentExecInstExists {
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
    ///  Order Acknowledgment Ext Exec Inst Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentExtExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Fee Code Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Last Px Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentLastPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Last Shares Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentLastSharesExists {
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
    ///  Order Acknowledgment Mass Cancelled Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMassCancelledExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Max Floor Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMaxFloorExists {
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
    ///  Order Acknowledgment Orig Cl Ord Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentOrigClOrdIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Peg Difference Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentPegDifferenceExists {
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
    ///  Order Acknowledgment Rout Strategy Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Routing Inst Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentRoutingInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Secondary Order Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentSecondaryOrderIdExists {
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
    ///  Order Acknowledgment Symbol Sfx Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentSymbolSfxExists {
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
    ///  Order Acknowledgment Working Price Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentWorkingPriceExists {
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
    ///  Order Cancelled Attributed Quote Exists
    /// </summary>
    public unsafe struct OrderCancelledAttributedQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Base Liquidity Indicator Exists
    /// </summary>
    public unsafe struct OrderCancelledBaseLiquidityIndicatorExists {
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
    ///  Order Cancelled Discretion Amount Exists
    /// </summary>
    public unsafe struct OrderCancelledDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Display Indicator Exists
    /// </summary>
    public unsafe struct OrderCancelledDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Display Price Exists
    /// </summary>
    public unsafe struct OrderCancelledDisplayPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Echo Text Exists
    /// </summary>
    public unsafe struct OrderCancelledEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Ex Destination Exists
    /// </summary>
    public unsafe struct OrderCancelledExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Exec Inst Exists
    /// </summary>
    public unsafe struct OrderCancelledExecInstExists {
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
    ///  Order Cancelled Ext Exec Inst Exists
    /// </summary>
    public unsafe struct OrderCancelledExtExecInstExists {
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
    ///  Order Cancelled Mass Cancelled Exists
    /// </summary>
    public unsafe struct OrderCancelledMassCancelledExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Max Floor Exists
    /// </summary>
    public unsafe struct OrderCancelledMaxFloorExists {
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
    ///  Order Cancelled Orig Cl Ord Id Exists
    /// </summary>
    public unsafe struct OrderCancelledOrigClOrdIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Peg Difference Exists
    /// </summary>
    public unsafe struct OrderCancelledPegDifferenceExists {
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
    ///  Order Cancelled Rout Strategy Exists
    /// </summary>
    public unsafe struct OrderCancelledRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderCancelledRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Routing Inst Exists
    /// </summary>
    public unsafe struct OrderCancelledRoutingInstExists {
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
    ///  Order Cancelled Symbol Sfx Exists
    /// </summary>
    public unsafe struct OrderCancelledSymbolSfxExists {
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
    ///  Order Cancelled Working Price Exists
    /// </summary>
    public unsafe struct OrderCancelledWorkingPriceExists {
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
    ///  Order Execution Attributed Quote Exists
    /// </summary>
    public unsafe struct OrderExecutionAttributedQuoteExists {
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
    ///  Order Execution Discretion Amount Exists
    /// </summary>
    public unsafe struct OrderExecutionDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Display Indicator Exists
    /// </summary>
    public unsafe struct OrderExecutionDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Echo Text Exists
    /// </summary>
    public unsafe struct OrderExecutionEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Ex Destination Exists
    /// </summary>
    public unsafe struct OrderExecutionExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Exec Inst Exists
    /// </summary>
    public unsafe struct OrderExecutionExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Ext Exec Inst Exists
    /// </summary>
    public unsafe struct OrderExecutionExtExecInstExists {
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
    ///  Order Execution Max Floor Exists
    /// </summary>
    public unsafe struct OrderExecutionMaxFloorExists {
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
    ///  Order Execution Peg Difference Exists
    /// </summary>
    public unsafe struct OrderExecutionPegDifferenceExists {
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
    ///  Order Execution Rout Strategy Exists
    /// </summary>
    public unsafe struct OrderExecutionRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderExecutionRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Routing Inst Exists
    /// </summary>
    public unsafe struct OrderExecutionRoutingInstExists {
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
    ///  Order Execution Symbol Sfx Exists
    /// </summary>
    public unsafe struct OrderExecutionSymbolSfxExists {
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
    ///  Order Modified Attributed Quote Exists
    /// </summary>
    public unsafe struct OrderModifiedAttributedQuoteExists {
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
    ///  Order Modified Discretion Amount Exists
    /// </summary>
    public unsafe struct OrderModifiedDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Display Indicator Exists
    /// </summary>
    public unsafe struct OrderModifiedDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Display Price Exists
    /// </summary>
    public unsafe struct OrderModifiedDisplayPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Echo Text Exists
    /// </summary>
    public unsafe struct OrderModifiedEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Ex Destination Exists
    /// </summary>
    public unsafe struct OrderModifiedExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Exec Inst Exists
    /// </summary>
    public unsafe struct OrderModifiedExecInstExists {
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
    ///  Order Modified Ext Exec Inst Exists
    /// </summary>
    public unsafe struct OrderModifiedExtExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Last Px Exists
    /// </summary>
    public unsafe struct OrderModifiedLastPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Last Shares Exists
    /// </summary>
    public unsafe struct OrderModifiedLastSharesExists {
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
    ///  Order Modified Mass Cancelled Exists
    /// </summary>
    public unsafe struct OrderModifiedMassCancelledExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Max Floor Exists
    /// </summary>
    public unsafe struct OrderModifiedMaxFloorExists {
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
    ///  Order Modified Peg Difference Exists
    /// </summary>
    public unsafe struct OrderModifiedPegDifferenceExists {
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
    ///  Order Modified Rout Strategy Exists
    /// </summary>
    public unsafe struct OrderModifiedRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderModifiedRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Routing Inst Exists
    /// </summary>
    public unsafe struct OrderModifiedRoutingInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Secondary Order Id Exists
    /// </summary>
    public unsafe struct OrderModifiedSecondaryOrderIdExists {
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
    ///  Order Modified Symbol Sfx Exists
    /// </summary>
    public unsafe struct OrderModifiedSymbolSfxExists {
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
    ///  Order Modified Working Price Exists
    /// </summary>
    public unsafe struct OrderModifiedWorkingPriceExists {
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
        DuplicateIdentifier = (byte)'D',
        SizeReductionDueToSwpRestatement = (byte)'E',
        FailedToQuote = (byte)'F',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        OrderWouldLockOrCrossNbbo = (byte)'L',
        OrderSizeExceeded = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        WaitingForFirstTrade = (byte)'Q',
        RoutingUnavailable = (byte)'R',
        ShortSalePriceViolation = (byte)'S',
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        LimitUpLimitDown = (byte)'u',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
    };


    /// <summary>
    ///  Order Rejected Account Exists
    /// </summary>
    public unsafe struct OrderRejectedAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Attributed Quote Exists
    /// </summary>
    public unsafe struct OrderRejectedAttributedQuoteExists {
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
    ///  Order Rejected Discretion Amount Exists
    /// </summary>
    public unsafe struct OrderRejectedDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Display Indicator Exists
    /// </summary>
    public unsafe struct OrderRejectedDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Echo Text Exists
    /// </summary>
    public unsafe struct OrderRejectedEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Ex Destination Exists
    /// </summary>
    public unsafe struct OrderRejectedExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Exec Inst Exists
    /// </summary>
    public unsafe struct OrderRejectedExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Ext Exec Inst Exists
    /// </summary>
    public unsafe struct OrderRejectedExtExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Max Floor Exists
    /// </summary>
    public unsafe struct OrderRejectedMaxFloorExists {
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
    ///  Order Rejected Peg Difference Exists
    /// </summary>
    public unsafe struct OrderRejectedPegDifferenceExists {
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
    ///  Order Rejected Rout Strategy Exists
    /// </summary>
    public unsafe struct OrderRejectedRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderRejectedRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Routing Inst Exists
    /// </summary>
    public unsafe struct OrderRejectedRoutingInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Secondary Order Id Exists
    /// </summary>
    public unsafe struct OrderRejectedSecondaryOrderIdExists {
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
    ///  Order Rejected Symbol Sfx Exists
    /// </summary>
    public unsafe struct OrderRejectedSymbolSfxExists {
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
    ///  Order Restated Account Exists
    /// </summary>
    public unsafe struct OrderRestatedAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Attributed Quote Exists
    /// </summary>
    public unsafe struct OrderRestatedAttributedQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Base Liquidity Indicator Exists
    /// </summary>
    public unsafe struct OrderRestatedBaseLiquidityIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Bitfield Count
    /// </summary>
    public unsafe struct OrderRestatedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Restated Capacity Exists
    /// </summary>
    public unsafe struct OrderRestatedCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Clearing Account Exists
    /// </summary>
    public unsafe struct OrderRestatedClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Clearing Firm Exists
    /// </summary>
    public unsafe struct OrderRestatedClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Discretion Amount Exists
    /// </summary>
    public unsafe struct OrderRestatedDiscretionAmountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Display Indicator Exists
    /// </summary>
    public unsafe struct OrderRestatedDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Display Price Exists
    /// </summary>
    public unsafe struct OrderRestatedDisplayPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Echo Text Exists
    /// </summary>
    public unsafe struct OrderRestatedEchoTextExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Ex Destination Exists
    /// </summary>
    public unsafe struct OrderRestatedExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Exec Inst Exists
    /// </summary>
    public unsafe struct OrderRestatedExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Expire Time Exists
    /// </summary>
    public unsafe struct OrderRestatedExpireTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Ext Exec Inst Exists
    /// </summary>
    public unsafe struct OrderRestatedExtExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Last Px Exists
    /// </summary>
    public unsafe struct OrderRestatedLastPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Last Shares Exists
    /// </summary>
    public unsafe struct OrderRestatedLastSharesExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Leaves Qty Exists
    /// </summary>
    public unsafe struct OrderRestatedLeavesQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Mass Cancelled Exists
    /// </summary>
    public unsafe struct OrderRestatedMassCancelledExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Max Floor Exists
    /// </summary>
    public unsafe struct OrderRestatedMaxFloorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Min Qty Exists
    /// </summary>
    public unsafe struct OrderRestatedMinQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Ord Type Exists
    /// </summary>
    public unsafe struct OrderRestatedOrdTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Order Qty Exists
    /// </summary>
    public unsafe struct OrderRestatedOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Orig Cl Ord Id Exists
    /// </summary>
    public unsafe struct OrderRestatedOrigClOrdIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Peg Difference Exists
    /// </summary>
    public unsafe struct OrderRestatedPegDifferenceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Prevent Match Exists
    /// </summary>
    public unsafe struct OrderRestatedPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Price Exists
    /// </summary>
    public unsafe struct OrderRestatedPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct OrderRestatedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Rout Strategy Exists
    /// </summary>
    public unsafe struct OrderRestatedRoutStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderRestatedRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Routing Inst Exists
    /// </summary>
    public unsafe struct OrderRestatedRoutingInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Secondary Order Id Exists
    /// </summary>
    public unsafe struct OrderRestatedSecondaryOrderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Side Exists
    /// </summary>
    public unsafe struct OrderRestatedSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Stop Px Exists
    /// </summary>
    public unsafe struct OrderRestatedStopPxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Symbol Exists
    /// </summary>
    public unsafe struct OrderRestatedSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Symbol Sfx Exists
    /// </summary>
    public unsafe struct OrderRestatedSymbolSfxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Time In Force Exists
    /// </summary>
    public unsafe struct OrderRestatedTimeInForceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Working Price Exists
    /// </summary>
    public unsafe struct OrderRestatedWorkingPriceExists {
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
    ///  Peg Difference
    /// </summary>
    public struct PegDifference {
        public long Raw;
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
    ///  Purge Order Symbol Exists
    /// </summary>
    public unsafe struct PurgeOrderSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Order Symbol Sfx Exists
    /// </summary>
    public unsafe struct PurgeOrderSymbolSfxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Purge Reject Reason Values
    /// </summary>
    public enum PurgeRejectReason : byte {
        Admin = (byte)'A',
        DuplicateIdentifier = (byte)'D',
        SizeReductionDueToSwpRestatement = (byte)'E',
        FailedToQuote = (byte)'F',
        Halted = (byte)'H',
        IncorrectDataCenter = (byte)'I',
        TooLateToCancel = (byte)'J',
        OrderRateThresholdExceeded = (byte)'K',
        OrderWouldLockOrCrossNbbo = (byte)'L',
        OrderSizeExceeded = (byte)'M',
        RanOutOfLiquidityToExecuteAgainst = (byte)'N',
        ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
        CantModifyAnOrderThatIsPendingFill = (byte)'P',
        WaitingForFirstTrade = (byte)'Q',
        RoutingUnavailable = (byte)'R',
        ShortSalePriceViolation = (byte)'S',
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        RiskManagementMpidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        LimitUpLimitDown = (byte)'u',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
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
    ///  Purge Rejected Sub Liquidity Indicator Exists
    /// </summary>
    public unsafe struct PurgeRejectedSubLiquidityIndicatorExists {
        public const int Size = 1;

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
    ///  Restatement Reason Values
    /// </summary>
    public enum RestatementReason : byte {
        CboeMarketClose = (byte)'C',
        Reload = (byte)'L',
        PegOrPriceSlidingReprice = (byte)'P',
        LiquidityUpdated = (byte)'Q',
        Reroute = (byte)'R',
        ReductionOfQuantity = (byte)'S',
        Wash = (byte)'W',
    };


    /// <summary>
    ///  Risk Reset
    /// </summary>
    public unsafe struct RiskReset {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rout Strategy
    /// </summary>
    public unsafe struct RoutStrategy {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Route Delivery Method
    /// </summary>
    public unsafe struct RouteDeliveryMethod {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Routing Inst
    /// </summary>
    public unsafe struct RoutingInst {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
        ShortSell = (byte)'5',
        ShortSellExempt = (byte)'5',
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
        TradeAddedHiddenLiquidity = (byte)'H',
        TradeAddedHiddenLiquidityThatWasPriceImproved = (byte)'I',
        ExecutionFromFirstOrderToJoinTheNbbo = (byte)'J',
        ExecutionFromOrderThatSetTheNbbo = (byte)'S',
        VisibleLiquidityAddTradeThatWasPriceImproved = (byte)'V',
        MidpointPegOrder = (byte)'m',
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 8;

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
        Gtx = (byte)'5',
        Gtd = (byte)'6',
        Pre = (byte)'E',
        Rho = (byte)'R',
        Ptd = (byte)'T',
        Ptx = (byte)'X',
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
    ///  Trade Cancel Or Correct Sub Liquidity Indicator Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectSubLiquidityIndicatorExists {
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
    ///  Trade Cancel Or Correct Symbol Sfx Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectSymbolSfxExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public unsafe struct TransactTime {
        public const int Size = 8;

        public long Value;

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
    ///  User Modify Rejected Sub Liquidity Indicator Exists
    /// </summary>
    public unsafe struct UserModifyRejectedSubLiquidityIndicatorExists {
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
    ///  Working Price
    /// </summary>
    public struct WorkingPrice {
        public long Raw;
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
        CancelOrderReservedBit8Exists CancelOrderReservedBit8Exists;
        CancelOrderReservedBit7Exists CancelOrderReservedBit7Exists;
        CancelOrderReservedBit6Exists CancelOrderReservedBit6Exists;
        CancelOrderReservedBit5Exists CancelOrderReservedBit5Exists;
        CancelOrderReservedBit4Exists CancelOrderReservedBit4Exists;
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
        CancelOrderReservedBit1Exists CancelOrderReservedBit1Exists;
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
        CancelRejectedExecInstExists CancelRejectedExecInstExists;
        CancelRejectedPriceExists CancelRejectedPriceExists;
        CancelRejectedPegDifferenceExists CancelRejectedPegDifferenceExists;
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
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
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
        CancelRejectedSymbolSfxExists CancelRejectedSymbolSfxExists;
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
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedReservedBit3Exists CancelRejectedReservedBit3Exists;
        CancelRejectedReservedBit2Exists CancelRejectedReservedBit2Exists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte5 {
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
        CancelRejectedRoutStrategyExists CancelRejectedRoutStrategyExists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedStopPxExists CancelRejectedStopPxExists;
        CancelRejectedEchoTextExists CancelRejectedEchoTextExists;
        CancelRejectedReservedBit1Exists CancelRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cancel Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRejectedByte9 {
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
        ModifyOrderReservedBit6Exists ModifyOrderReservedBit6Exists;
        ModifyOrderReservedBit5Exists ModifyOrderReservedBit5Exists;
        ModifyOrderReservedBit4Exists ModifyOrderReservedBit4Exists;
        ModifyOrderReservedBit3Exists ModifyOrderReservedBit3Exists;
        ModifyOrderStopPxExists ModifyOrderStopPxExists;
        ModifyOrderMaxFloorExists ModifyOrderMaxFloorExists;
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
        NewOrderMaxFloorExists NewOrderMaxFloorExists;
        NewOrderMinQtyExists NewOrderMinQtyExists;
        NewOrderTimeInForceExists NewOrderTimeInForceExists;
        NewOrderOrdTypeExists NewOrderOrdTypeExists;
        NewOrderExecInstExists NewOrderExecInstExists;
        NewOrderPriceExists NewOrderPriceExists;
        NewOrderClearingAccountExists NewOrderClearingAccountExists;
        NewOrderClearingFirmExists NewOrderClearingFirmExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte2 {
        NewOrderRoutingInstExists NewOrderRoutingInstExists;
        NewOrderCapacityExists NewOrderCapacityExists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderSymbolSfxExists NewOrderSymbolSfxExists;
        NewOrderSymbolExists NewOrderSymbolExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte3 {
        NewOrderExpireTimeExists NewOrderExpireTimeExists;
        NewOrderLocateReqdExists NewOrderLocateReqdExists;
        NewOrderPreventMatchExists NewOrderPreventMatchExists;
        NewOrderPegDifferenceExists NewOrderPegDifferenceExists;
        NewOrderDiscretionAmountExists NewOrderDiscretionAmountExists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderDisplayIndicatorExists NewOrderDisplayIndicatorExists;
        NewOrderAccountExists NewOrderAccountExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte4 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderRiskResetExists NewOrderRiskResetExists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderReservedBit2Exists NewOrderReservedBit2Exists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
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
        NewOrderExtExecInstExists NewOrderExtExecInstExists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderAttributedQuoteExists NewOrderAttributedQuoteExists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte6 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderEchoTextExists NewOrderEchoTextExists;
        NewOrderExDestinationExists NewOrderExDestinationExists;
        NewOrderRouteDeliveryMethodExists NewOrderRouteDeliveryMethodExists;
        NewOrderRoutStrategyExists NewOrderRoutStrategyExists;
        NewOrderStopPxExists NewOrderStopPxExists;
        NewOrderDisplayRangeExists NewOrderDisplayRangeExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte7 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderCustomGroupIdExists NewOrderCustomGroupIdExists;
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
        OrderAcknowledgmentExecInstExists OrderAcknowledgmentExecInstExists;
        OrderAcknowledgmentPriceExists OrderAcknowledgmentPriceExists;
        OrderAcknowledgmentPegDifferenceExists OrderAcknowledgmentPegDifferenceExists;
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
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte13 {
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
        OrderAcknowledgmentMassCancelledExists OrderAcknowledgmentMassCancelledExists;
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
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
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
        OrderAcknowledgmentSymbolSfxExists OrderAcknowledgmentSymbolSfxExists;
        OrderAcknowledgmentSymbolExists OrderAcknowledgmentSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte3 {
        OrderAcknowledgmentPreventMatchExists OrderAcknowledgmentPreventMatchExists;
        OrderAcknowledgmentOrderQtyExists OrderAcknowledgmentOrderQtyExists;
        OrderAcknowledgmentDiscretionAmountExists OrderAcknowledgmentDiscretionAmountExists;
        OrderAcknowledgmentMaxFloorExists OrderAcknowledgmentMaxFloorExists;
        OrderAcknowledgmentDisplayIndicatorExists OrderAcknowledgmentDisplayIndicatorExists;
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
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte5 {
        OrderAcknowledgmentExpireTimeExists OrderAcknowledgmentExpireTimeExists;
        OrderAcknowledgmentBaseLiquidityIndicatorExists OrderAcknowledgmentBaseLiquidityIndicatorExists;
        OrderAcknowledgmentWorkingPriceExists OrderAcknowledgmentWorkingPriceExists;
        OrderAcknowledgmentDisplayPriceExists OrderAcknowledgmentDisplayPriceExists;
        OrderAcknowledgmentLastPxExists OrderAcknowledgmentLastPxExists;
        OrderAcknowledgmentLastSharesExists OrderAcknowledgmentLastSharesExists;
        OrderAcknowledgmentLeavesQtyExists OrderAcknowledgmentLeavesQtyExists;
        OrderAcknowledgmentOrigClOrdIdExists OrderAcknowledgmentOrigClOrdIdExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte6 {
        OrderAcknowledgmentReservedBit8Exists OrderAcknowledgmentReservedBit8Exists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentExtExecInstExists OrderAcknowledgmentExtExecInstExists;
        OrderAcknowledgmentAttributedQuoteExists OrderAcknowledgmentAttributedQuoteExists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentReservedBit2Exists OrderAcknowledgmentReservedBit2Exists;
        OrderAcknowledgmentSecondaryOrderIdExists OrderAcknowledgmentSecondaryOrderIdExists;
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
        OrderAcknowledgmentExDestinationExists OrderAcknowledgmentExDestinationExists;
        OrderAcknowledgmentRouteDeliveryMethodExists OrderAcknowledgmentRouteDeliveryMethodExists;
        OrderAcknowledgmentRoutStrategyExists OrderAcknowledgmentRoutStrategyExists;
        OrderAcknowledgmentRoutingInstExists OrderAcknowledgmentRoutingInstExists;
        OrderAcknowledgmentStopPxExists OrderAcknowledgmentStopPxExists;
        OrderAcknowledgmentEchoTextExists OrderAcknowledgmentEchoTextExists;
        OrderAcknowledgmentFeeCodeExists OrderAcknowledgmentFeeCodeExists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte9 {
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
    ///  Struct for Order Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentMessage {
        TransactTime TransactTime;
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
        OrderCancelledExecInstExists OrderCancelledExecInstExists;
        OrderCancelledPriceExists OrderCancelledPriceExists;
        OrderCancelledPegDifferenceExists OrderCancelledPegDifferenceExists;
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
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
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
        OrderCancelledMassCancelledExists OrderCancelledMassCancelledExists;
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
        OrderCancelledMassCancelledExists OrderCancelledMassCancelledExists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
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
        OrderCancelledSymbolSfxExists OrderCancelledSymbolSfxExists;
        OrderCancelledSymbolExists OrderCancelledSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte3 {
        OrderCancelledPreventMatchExists OrderCancelledPreventMatchExists;
        OrderCancelledOrderQtyExists OrderCancelledOrderQtyExists;
        OrderCancelledDiscretionAmountExists OrderCancelledDiscretionAmountExists;
        OrderCancelledMaxFloorExists OrderCancelledMaxFloorExists;
        OrderCancelledDisplayIndicatorExists OrderCancelledDisplayIndicatorExists;
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
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledReservedBit2Exists OrderCancelledReservedBit2Exists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte5 {
        OrderCancelledExpireTimeExists OrderCancelledExpireTimeExists;
        OrderCancelledBaseLiquidityIndicatorExists OrderCancelledBaseLiquidityIndicatorExists;
        OrderCancelledWorkingPriceExists OrderCancelledWorkingPriceExists;
        OrderCancelledDisplayPriceExists OrderCancelledDisplayPriceExists;
        OrderCancelledLastPxExists OrderCancelledLastPxExists;
        OrderCancelledLastSharesExists OrderCancelledLastSharesExists;
        OrderCancelledLeavesQtyExists OrderCancelledLeavesQtyExists;
        OrderCancelledOrigClOrdIdExists OrderCancelledOrigClOrdIdExists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte6 {
        OrderCancelledReservedBit8Exists OrderCancelledReservedBit8Exists;
        OrderCancelledReservedBit7Exists OrderCancelledReservedBit7Exists;
        OrderCancelledReservedBit6Exists OrderCancelledReservedBit6Exists;
        OrderCancelledExtExecInstExists OrderCancelledExtExecInstExists;
        OrderCancelledAttributedQuoteExists OrderCancelledAttributedQuoteExists;
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
        OrderCancelledExDestinationExists OrderCancelledExDestinationExists;
        OrderCancelledRouteDeliveryMethodExists OrderCancelledRouteDeliveryMethodExists;
        OrderCancelledRoutStrategyExists OrderCancelledRoutStrategyExists;
        OrderCancelledRoutingInstExists OrderCancelledRoutingInstExists;
        OrderCancelledStopPxExists OrderCancelledStopPxExists;
        OrderCancelledEchoTextExists OrderCancelledEchoTextExists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte9 {
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
    ///  Struct for Order Cancelled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledMessage {
        TransactTime TransactTime;
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
        OrderExecutionExecInstExists OrderExecutionExecInstExists;
        OrderExecutionPriceExists OrderExecutionPriceExists;
        OrderExecutionPegDifferenceExists OrderExecutionPegDifferenceExists;
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
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte13 {
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
    ///  Struct for Order Execution Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte14 {
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
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
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
        OrderExecutionSymbolSfxExists OrderExecutionSymbolSfxExists;
        OrderExecutionSymbolExists OrderExecutionSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte3 {
        OrderExecutionPreventMatchExists OrderExecutionPreventMatchExists;
        OrderExecutionOrderQtyExists OrderExecutionOrderQtyExists;
        OrderExecutionDiscretionAmountExists OrderExecutionDiscretionAmountExists;
        OrderExecutionMaxFloorExists OrderExecutionMaxFloorExists;
        OrderExecutionDisplayIndicatorExists OrderExecutionDisplayIndicatorExists;
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
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionReservedBit2Exists OrderExecutionReservedBit2Exists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte5 {
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
    ///  Struct for Order Execution Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte6 {
        OrderExecutionReservedBit8Exists OrderExecutionReservedBit8Exists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionExtExecInstExists OrderExecutionExtExecInstExists;
        OrderExecutionAttributedQuoteExists OrderExecutionAttributedQuoteExists;
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
        OrderExecutionExDestinationExists OrderExecutionExDestinationExists;
        OrderExecutionRouteDeliveryMethodExists OrderExecutionRouteDeliveryMethodExists;
        OrderExecutionRoutStrategyExists OrderExecutionRoutStrategyExists;
        OrderExecutionRoutingInstExists OrderExecutionRoutingInstExists;
        OrderExecutionStopPxExists OrderExecutionStopPxExists;
        OrderExecutionEchoTextExists OrderExecutionEchoTextExists;
        OrderExecutionFeeCodeExists OrderExecutionFeeCodeExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte9 {
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
        OrderModifiedExecInstExists OrderModifiedExecInstExists;
        OrderModifiedPriceExists OrderModifiedPriceExists;
        OrderModifiedPegDifferenceExists OrderModifiedPegDifferenceExists;
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
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
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
        OrderModifiedMassCancelledExists OrderModifiedMassCancelledExists;
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
        OrderModifiedMassCancelledExists OrderModifiedMassCancelledExists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
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
        OrderModifiedSymbolSfxExists OrderModifiedSymbolSfxExists;
        OrderModifiedSymbolExists OrderModifiedSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte3 {
        OrderModifiedPreventMatchExists OrderModifiedPreventMatchExists;
        OrderModifiedOrderQtyExists OrderModifiedOrderQtyExists;
        OrderModifiedDiscretionAmountExists OrderModifiedDiscretionAmountExists;
        OrderModifiedMaxFloorExists OrderModifiedMaxFloorExists;
        OrderModifiedDisplayIndicatorExists OrderModifiedDisplayIndicatorExists;
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
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte5 {
        OrderModifiedExpireTimeExists OrderModifiedExpireTimeExists;
        OrderModifiedBaseLiquidityIndicatorExists OrderModifiedBaseLiquidityIndicatorExists;
        OrderModifiedWorkingPriceExists OrderModifiedWorkingPriceExists;
        OrderModifiedDisplayPriceExists OrderModifiedDisplayPriceExists;
        OrderModifiedLastPxExists OrderModifiedLastPxExists;
        OrderModifiedLastSharesExists OrderModifiedLastSharesExists;
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
        OrderModifiedExtExecInstExists OrderModifiedExtExecInstExists;
        OrderModifiedAttributedQuoteExists OrderModifiedAttributedQuoteExists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedReservedBit2Exists OrderModifiedReservedBit2Exists;
        OrderModifiedSecondaryOrderIdExists OrderModifiedSecondaryOrderIdExists;
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
        OrderModifiedExDestinationExists OrderModifiedExDestinationExists;
        OrderModifiedRouteDeliveryMethodExists OrderModifiedRouteDeliveryMethodExists;
        OrderModifiedRoutStrategyExists OrderModifiedRoutStrategyExists;
        OrderModifiedRoutingInstExists OrderModifiedRoutingInstExists;
        OrderModifiedStopPxExists OrderModifiedStopPxExists;
        OrderModifiedEchoTextExists OrderModifiedEchoTextExists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte9 {
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
        OrderRejectedExecInstExists OrderRejectedExecInstExists;
        OrderRejectedPriceExists OrderRejectedPriceExists;
        OrderRejectedPegDifferenceExists OrderRejectedPegDifferenceExists;
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
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
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
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
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
        OrderRejectedSymbolSfxExists OrderRejectedSymbolSfxExists;
        OrderRejectedSymbolExists OrderRejectedSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte3 {
        OrderRejectedPreventMatchExists OrderRejectedPreventMatchExists;
        OrderRejectedOrderQtyExists OrderRejectedOrderQtyExists;
        OrderRejectedDiscretionAmountExists OrderRejectedDiscretionAmountExists;
        OrderRejectedMaxFloorExists OrderRejectedMaxFloorExists;
        OrderRejectedDisplayIndicatorExists OrderRejectedDisplayIndicatorExists;
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
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
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
        OrderRejectedExtExecInstExists OrderRejectedExtExecInstExists;
        OrderRejectedAttributedQuoteExists OrderRejectedAttributedQuoteExists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedReservedBit2Exists OrderRejectedReservedBit2Exists;
        OrderRejectedSecondaryOrderIdExists OrderRejectedSecondaryOrderIdExists;
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
        OrderRejectedExDestinationExists OrderRejectedExDestinationExists;
        OrderRejectedRouteDeliveryMethodExists OrderRejectedRouteDeliveryMethodExists;
        OrderRejectedRoutStrategyExists OrderRejectedRoutStrategyExists;
        OrderRejectedRoutingInstExists OrderRejectedRoutingInstExists;
        OrderRejectedStopPxExists OrderRejectedStopPxExists;
        OrderRejectedEchoTextExists OrderRejectedEchoTextExists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte9 {
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
    ///  Struct for Order Restated Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte1 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedMinQtyExists OrderRestatedMinQtyExists;
        OrderRestatedTimeInForceExists OrderRestatedTimeInForceExists;
        OrderRestatedOrdTypeExists OrderRestatedOrdTypeExists;
        OrderRestatedExecInstExists OrderRestatedExecInstExists;
        OrderRestatedPriceExists OrderRestatedPriceExists;
        OrderRestatedPegDifferenceExists OrderRestatedPegDifferenceExists;
        OrderRestatedSideExists OrderRestatedSideExists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte10 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte11 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte12 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte13 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte14 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte15 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedMassCancelledExists OrderRestatedMassCancelledExists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte16 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedMassCancelledExists OrderRestatedMassCancelledExists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte17 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte2 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedCapacityExists OrderRestatedCapacityExists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedSymbolSfxExists OrderRestatedSymbolSfxExists;
        OrderRestatedSymbolExists OrderRestatedSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte3 {
        OrderRestatedPreventMatchExists OrderRestatedPreventMatchExists;
        OrderRestatedOrderQtyExists OrderRestatedOrderQtyExists;
        OrderRestatedDiscretionAmountExists OrderRestatedDiscretionAmountExists;
        OrderRestatedMaxFloorExists OrderRestatedMaxFloorExists;
        OrderRestatedDisplayIndicatorExists OrderRestatedDisplayIndicatorExists;
        OrderRestatedClearingAccountExists OrderRestatedClearingAccountExists;
        OrderRestatedClearingFirmExists OrderRestatedClearingFirmExists;
        OrderRestatedAccountExists OrderRestatedAccountExists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte4 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte5 {
        OrderRestatedExpireTimeExists OrderRestatedExpireTimeExists;
        OrderRestatedBaseLiquidityIndicatorExists OrderRestatedBaseLiquidityIndicatorExists;
        OrderRestatedWorkingPriceExists OrderRestatedWorkingPriceExists;
        OrderRestatedDisplayPriceExists OrderRestatedDisplayPriceExists;
        OrderRestatedLastPxExists OrderRestatedLastPxExists;
        OrderRestatedLastSharesExists OrderRestatedLastSharesExists;
        OrderRestatedLeavesQtyExists OrderRestatedLeavesQtyExists;
        OrderRestatedOrigClOrdIdExists OrderRestatedOrigClOrdIdExists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte6 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedExtExecInstExists OrderRestatedExtExecInstExists;
        OrderRestatedAttributedQuoteExists OrderRestatedAttributedQuoteExists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedSecondaryOrderIdExists OrderRestatedSecondaryOrderIdExists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte7 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte8 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedExDestinationExists OrderRestatedExDestinationExists;
        OrderRestatedRouteDeliveryMethodExists OrderRestatedRouteDeliveryMethodExists;
        OrderRestatedRoutStrategyExists OrderRestatedRoutStrategyExists;
        OrderRestatedRoutingInstExists OrderRestatedRoutingInstExists;
        OrderRestatedStopPxExists OrderRestatedStopPxExists;
        OrderRestatedEchoTextExists OrderRestatedEchoTextExists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte9 {
        OrderRestatedReservedBit8Exists OrderRestatedReservedBit8Exists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        OrderId OrderId;
        RestatementReason RestatementReason;
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
        PurgeOrderReservedBit8Exists PurgeOrderReservedBit8Exists;
        PurgeOrderReservedBit7Exists PurgeOrderReservedBit7Exists;
        PurgeOrderReservedBit6Exists PurgeOrderReservedBit6Exists;
        PurgeOrderMassCancelIdExists PurgeOrderMassCancelIdExists;
        PurgeOrderReservedBit4Exists PurgeOrderReservedBit4Exists;
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
        PurgeOrderSymbolSfxExists PurgeOrderSymbolSfxExists;
        PurgeOrderSymbolExists PurgeOrderSymbolExists;
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
        PurgeRejectedSubLiquidityIndicatorExists PurgeRejectedSubLiquidityIndicatorExists;
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
    ///  Struct for Return Bitfields
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReturnBitfields {
        ApplicationMessageType ApplicationMessageType;
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
        TradeCancelOrCorrectSymbolSfxExists TradeCancelOrCorrectSymbolSfxExists;
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
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectReservedBit3Exists TradeCancelOrCorrectReservedBit3Exists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectReservedBit1Exists TradeCancelOrCorrectReservedBit1Exists;
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
        TradeCancelOrCorrectSubLiquidityIndicatorExists TradeCancelOrCorrectSubLiquidityIndicatorExists;
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
        TradeCancelOrCorrectReservedBit6Exists TradeCancelOrCorrectReservedBit6Exists;
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
        UserModifyRejectedSubLiquidityIndicatorExists UserModifyRejectedSubLiquidityIndicatorExists;
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


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
