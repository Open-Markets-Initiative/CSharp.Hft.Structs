namespace Cboe.Edgx.Options.OrderEntry.Boe.v2.10 {

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
    ///  Alloc Qty
    /// </summary>
    public unsafe struct AllocQty {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Application Message Type Values
    /// </summary>
    public enum ApplicationMessageType : byte {
        OrderAcknowledgment = 0x25,
        CrossOrderAcknowledgment = 0x43,
        OrderRejected = 0x26,
        CrossOrderRejected = 0x44,
        OrderModified = 0x27,
        OrderRestated = 0x28,
        UserModifyRejected = 0x29,
        OrderCancelled = 0x2A,
        CrossOrderCancelled = 0x46,
        CancelRejected = 0x2B,
        OrderExecution = 0x2C,
        TradeCancelOrCorrect = 0x2D,
        PurgeRejected = 0x48,
        ComplexInstrumentAccepted = 0x4D,
        ComplexInstrumentRejected = 0x4E,
    };


    /// <summary>
    ///  Attributed Quote Values
    /// </summary>
    public enum AttributedQuote : byte {
        DoNotAttributeFirmExecutingBrokerId = (byte)'N',
        AttributeFirmExecutingBrokerId = (byte)'Y',
        AttributeClientIdOnly = (byte)'C',
        AttributeBothClearingFirmAndClientId = (byte)'Z',
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public unsafe struct AuctionId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Auto Match Values
    /// </summary>
    public enum AutoMatch : byte {
        Disabled = (byte)'0',
        Market = (byte)'1',
        Limit = (byte)'1',
        AttributeBothClearingFirmAndClientId = (byte)'Z',
    };


    /// <summary>
    ///  Auto Match Price
    /// </summary>
    public struct AutoMatchPrice {
        public long Raw;
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
    ///  Cancel Order Mass Cancel Exists
    /// </summary>
    public unsafe struct CancelOrderMassCancelExists {
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
    ///  Cancel Order Mass Cancel Lockout Exists
    /// </summary>
    public unsafe struct CancelOrderMassCancelLockoutExists {
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
    ///  Cancel Order Risk Root Exists
    /// </summary>
    public unsafe struct CancelOrderRiskRootExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Order Routing Firm Id Exists
    /// </summary>
    public unsafe struct CancelOrderRoutingFirmIdExists {
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
        DuplicateIdentifier = (byte)'D',
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
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        OnlyCloseTransactionsAccepted = (byte)'c',
        RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
        RiskManagementEfidGroupLevel = (byte)'+',
    };


    /// <summary>
    ///  Cancel Reject Reason Values
    /// </summary>
    public enum CancelRejectReason : byte {
        Admin = (byte)'A',
        DuplicateIdentifier = (byte)'D',
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
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        OnlyCloseTransactionsAccepted = (byte)'c',
        RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
        RiskManagementEfidGroupLevel = (byte)'+',
    };


    /// <summary>
    ///  Cancel Rejected Alloc Qty Exists
    /// </summary>
    public unsafe struct CancelRejectedAllocQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Auction Id Exists
    /// </summary>
    public unsafe struct CancelRejectedAuctionIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  Cancel Rejected Corrected Size Exists
    /// </summary>
    public unsafe struct CancelRejectedCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct CancelRejectedCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Cross Id Exists
    /// </summary>
    public unsafe struct CancelRejectedCrossIdExists {
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
    ///  Cancel Rejected Give Up Firm Id Exists
    /// </summary>
    public unsafe struct CancelRejectedGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Market Fee Code Exists
    /// </summary>
    public unsafe struct CancelRejectedMarketFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cancel Rejected Mass Cancel Id Exists
    /// </summary>
    public unsafe struct CancelRejectedMassCancelIdExists {
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
    ///  Cancel Rejected Max Remove Pct Exists
    /// </summary>
    public unsafe struct CancelRejectedMaxRemovePctExists {
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
    ///  Cancel Rejected Put Or Call Exists
    /// </summary>
    public unsafe struct CancelRejectedPutOrCallExists {
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
    ///  Cancel Rejected Routing Firm Id Exists
    /// </summary>
    public unsafe struct CancelRejectedRoutingFirmIdExists {
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
    ///  Cancel Rejected Strike Price Exists
    /// </summary>
    public unsafe struct CancelRejectedStrikePriceExists {
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
    ///  Cancel Rejected Target Party Id Exists
    /// </summary>
    public unsafe struct CancelRejectedTargetPartyIdExists {
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
        MarketMaker = (byte)'M',
        Firm = (byte)'F',
        ProfessionalCustomer = (byte)'U',
        NonCboeMarketMaker = (byte)'N',
        BrokerDealer = (byte)'B',
        JointBackOffice = (byte)'J',
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
    ///  Clearing Optional Data
    /// </summary>
    public unsafe struct ClearingOptionalData {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Client Id Attr
    /// </summary>
    public unsafe struct ClientIdAttr {
        public const int Size = 4;

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
    ///  Complex Instrument Accepted Bitfield Count
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Instrument Accepted Leg Cfi Code Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedLegCfiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Leg Maturity Date Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedLegMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Leg Strike Price Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedLegStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Accepted Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentAcceptedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Bitfield Count
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Complex Instrument Rejected Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct ComplexInstrumentRejectedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Contra Capacity
    /// </summary>
    public unsafe struct ContraCapacity {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contra Trader
    /// </summary>
    public unsafe struct ContraTrader {
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
    ///  Cross Exclusion Indicator Values
    /// </summary>
    public enum CrossExclusionIndicator : byte {
        No = (byte)'N',
        Yes = (byte)'Y',
    };


    /// <summary>
    ///  Cross Id
    /// </summary>
    public unsafe struct CrossId {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Order Acknowledgment Account Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Alloc Qty Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentAllocQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Attributed Quote Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentAttributedQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Auction Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentAuctionIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Bitfield Count
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Order Acknowledgment Capacity Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Clearing Account Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Clearing Optional Data Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Client Id Attr Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentClientIdAttrExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Cmta Number Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Cross Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentCrossIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Cross Prioritization Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentCrossPrioritizationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Cross Type Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentCrossTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Equity Party Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentEquityPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Exec Inst Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Frequent Trader Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Give Up Firm Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Maturity Date Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Open Close Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentOpenCloseExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Order Qty Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Prevent Match Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Price Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Put Or Call Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentPutOrCallExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Routing Firm Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentRoutingFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Side Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentSideExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Strike Price Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Symbol Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Acknowledgment Target Party Id Exists
    /// </summary>
    public unsafe struct CrossOrderAcknowledgmentTargetPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Account Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Alloc Qty Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledAllocQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Attributed Quote Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledAttributedQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Bitfield Count
    /// </summary>
    public unsafe struct CrossOrderCancelledBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Order Cancelled Capacity Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Clearing Firm Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Cmta Number Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Cross Id Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledCrossIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Cross Prioritization Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledCrossPrioritizationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Cross Type Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledCrossTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Equity Party Id Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledEquityPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Exec Inst Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Frequent Trader Id Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Give Up Firm Id Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Maturity Date Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Order Qty Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Prevent Match Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Price Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Put Or Call Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledPutOrCallExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Routing Firm Id Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledRoutingFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Strike Price Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Symbol Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Cancelled Target Party Id Exists
    /// </summary>
    public unsafe struct CrossOrderCancelledTargetPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Attributed Quote Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedAttributedQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Bitfield Count
    /// </summary>
    public unsafe struct CrossOrderRejectedBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cross Order Rejected Cross Id Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedCrossIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Cross Prioritization Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedCrossPrioritizationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Cross Type Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedCrossTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Equity Party Id Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedEquityPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Exec Inst Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Frequent Trader Id Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Maturity Date Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Order Qty Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedOrderQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Prevent Match Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Price Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Put Or Call Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedPutOrCallExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Routing Firm Id Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedRoutingFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Strike Price Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Symbol Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Order Rejected Target Party Id Exists
    /// </summary>
    public unsafe struct CrossOrderRejectedTargetPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cross Prioritization Values
    /// </summary>
    public enum CrossPrioritization : byte {
        Buy = (byte)'1',
        Sell = (byte)'2',
    };


    /// <summary>
    ///  Cross Type
    /// </summary>
    public unsafe struct CrossType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Display Indicator Values
    /// </summary>
    public enum DisplayIndicator : byte {
        DeterminedByPortLevelSetting = (byte)'V',
        PriceAdjust = (byte)'P',
        MultiplePriceAdjust = (byte)'m',
        RejectTheOrderIfItCannotBeBookedAndDisplayedWithoutAdjustment = (byte)'m',
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
    ///  Drill Thru Protection
    /// </summary>
    public struct DrillThruProtection {
        public long Raw;
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
    ///  Equity Buy Clearing Firm
    /// </summary>
    public unsafe struct EquityBuyClearingFirm {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Equity Ex Destination Values
    /// </summary>
    public enum EquityExDestination : byte {
        Cowen = (byte)'C',
    };


    /// <summary>
    ///  Equity Leg Short Sell Values
    /// </summary>
    public enum EquityLegShortSell : byte {
        SellShort = (byte)'5',
        SellShortExempt = (byte)'6',
        Disabled = (byte)'0',
        Enabled = (byte)'1',
    };


    /// <summary>
    ///  Equity Party Id
    /// </summary>
    public unsafe struct EquityPartyId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Equity Sell Clearing Firm
    /// </summary>
    public unsafe struct EquitySellClearingFirm {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Equity Trade Price
    /// </summary>
    public struct EquityTradePrice {
        public long Raw;
    };


    /// <summary>
    ///  Equity Trade Size
    /// </summary>
    public unsafe struct EquityTradeSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Equity Trade Venue Values
    /// </summary>
    public enum EquityTradeVenue : byte {
        NyseAmerican = (byte)'A',
        NasdaqBx = (byte)'B',
        NyseNational = (byte)'C',
        InvestorsExchange = (byte)'I',
        CboeEdgaExchange = (byte)'J',
        CboeEdgxExchange = (byte)'K',
        Chx = (byte)'M',
        Nyse = (byte)'N',
        NyseArca = (byte)'P',
        Nasdaq = (byte)'Q',
        NasdaqPsx = (byte)'X',
        CboeByxExchange = (byte)'Y',
        CboeBzxExchange = (byte)'Z',
    };


    /// <summary>
    ///  Equity Transact Time
    /// </summary>
    public unsafe struct EquityTransactTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ex Destination Values
    /// </summary>
    public enum ExDestination : byte {
        NyseArca = (byte)'A',
        NasdaqIse = (byte)'E',
        Miax = (byte)'F',
        MiaxPearl = (byte)'P',
        MiaxEmerald = (byte)'D',
        EdgxOptions = (byte)'G',
        C2 = (byte)'H',
        Box = (byte)'K',
        Nasdaq = (byte)'N',
        NasdaqBx = (byte)'S',
        NyseAmerican = (byte)'U',
        C1 = (byte)'W',
        NasdaqPhlx = (byte)'X',
        BzxOptions = (byte)'Z',
        NasdaqGemx = (byte)'g',
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
        AllOrNone = (byte)'G',
        Sweep = (byte)'s',
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
    ///  Frequent Trader Id
    /// </summary>
    public unsafe struct FrequentTraderId {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Give Up Firm Id
    /// </summary>
    public unsafe struct GiveUpFirmId {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Priority
    /// </summary>
    public unsafe struct LastPriority {
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
    ///  Leg Cfi Code Values
    /// </summary>
    public enum LegCfiCode : ulong {
        OptionsPut = "OP",
        OptionsCall = "OC",
        Equity = "E",
    };


    /// <summary>
    ///  Leg Maturity Date
    /// </summary>
    public unsafe struct LegMaturityDate {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Strike Price
    /// </summary>
    public struct LegStrikePrice {
        public long Raw;
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
    ///  Marketing Fee Code Values
    /// </summary>
    public enum MarketingFeeCode : ulong {
        PennyPilot = "P",
        NonPennyPilot = "N",
        NotEligible = "X",
    };


    /// <summary>
    ///  Mass Cancel
    /// </summary>
    public unsafe struct MassCancel {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  Mass Cancel Lockout Values
    /// </summary>
    public enum MassCancelLockout : byte {
        NoLockout = (byte)'0',
        Lockout = (byte)'0',
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
    ///  Max Floor
    /// </summary>
    public unsafe struct MaxFloor {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Max Remove Pct
    /// </summary>
    public unsafe struct MaxRemovePct {
        public const int Size = 1;

        public sbyte Value;

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
        LogoutMessage = 0x02,
        ServerHeartbeatMessage = 0x09,
        ReplayCompleteMessage = 0x13,
        NewOrderMessage = 0x38,
        NewOrderCrossMessage = 0x41,
        NewOrderComplexMessage = 0x4B,
        NewOrderCrossMultilegMessage = 0x5A,
        CancelOrderMessage = 0x39,
        ModifyOrderMessage = 0x3A,
        QuoteUpdateMessage = 0x55,
        ShortQuoteUpdateMessage = 0x59,
        PurgeOrderMessage = 0x47,
        RiskResetMessage = 0x56,
        NewComplexInstrumentMessage = 0x4C,
        OrderAcknowledgmentMessage = 0x25,
        CrossOrderAcknowledgmentMessage = 0x43,
        QuoteUpdateAcknowledgmentMessage = 0x25,
        OrderRejectedMessage = 0x26,
        CrossOrderRejectedMessage = 0x44,
        QuoteUpdateRejectedMessage = 0x58,
        OrderModifiedMessage = 0x27,
        OrderRestatedMessage = 0x28,
        QuoteRestatedMessage = 0x52,
        UserModifyRejectedMessage = 0x29,
        OrderCancelledMessage = 0x2a,
        QuoteCancelledMessage = 0x53,
        CrossOrderCancelledMessage = 0x46,
        CancelRejectedMessage = 0x2B,
        QuoteExecutionMessage = 0x54,
        TradeCancelOrCorrectMessage = 0x2D,
        PurgeRejectedMessage = 0x48,
        ResetRiskAcknowledgmentMessage = 0x57,
        MassCancelAcknowledgmentMessage = 0x36,
        ComplexInstrumentAcceptedMessage = 0x4D,
        ComplexInstrumentRejectedMessage = 0x4D,
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
    ///  Modify Order Routing Firm Id Exists
    /// </summary>
    public unsafe struct ModifyOrderRoutingFirmIdExists {
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
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        OnlyCloseTransactionsAccepted = (byte)'c',
        RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
        RiskManagementEfidGroupLevel = (byte)'+',
    };


    /// <summary>
    ///  Multi Class Sprd Values
    /// </summary>
    public enum MultiClassSprd : byte {
        No = (byte)'N',
        Yes = (byte)'Y',
    };


    /// <summary>
    ///  New Complex Instrument Bitfield Count
    /// </summary>
    public unsafe struct NewComplexInstrumentBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Complex Instrument Clearing Firm Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Leg Cfi Code Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentLegCfiCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Leg Maturity Date Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentLegMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Leg Strike Price Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentLegStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Complex Instrument Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct NewComplexInstrumentReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  New Order Auction Id Exists
    /// </summary>
    public unsafe struct NewOrderAuctionIdExists {
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
    ///  New Order Clearing Optional Data Exists
    /// </summary>
    public unsafe struct NewOrderClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Client Id Attr Exists
    /// </summary>
    public unsafe struct NewOrderClientIdAttrExists {
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
    ///  New Order Cross Account Exists
    /// </summary>
    public unsafe struct NewOrderCrossAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Attribute Quote Exists
    /// </summary>
    public unsafe struct NewOrderCrossAttributeQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Auto Match Exists
    /// </summary>
    public unsafe struct NewOrderCrossAutoMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Auto Match Price Exists
    /// </summary>
    public unsafe struct NewOrderCrossAutoMatchPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Bitfield Count
    /// </summary>
    public unsafe struct NewOrderCrossBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Order Cross Clearing Account Exists
    /// </summary>
    public unsafe struct NewOrderCrossClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Clearing Optional Data Exists
    /// </summary>
    public unsafe struct NewOrderCrossClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Client Id Attr Exists
    /// </summary>
    public unsafe struct NewOrderCrossClientIdAttrExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Cmta Number Exists
    /// </summary>
    public unsafe struct NewOrderCrossCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Equity Buy Clearing Firm Exists
    /// </summary>
    public unsafe struct NewOrderCrossEquityBuyClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Equity Sell Clearing Firm Exists
    /// </summary>
    public unsafe struct NewOrderCrossEquitySellClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Equity Trade Price Exists
    /// </summary>
    public unsafe struct NewOrderCrossEquityTradePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Equity Trade Size Exists
    /// </summary>
    public unsafe struct NewOrderCrossEquityTradeSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Equity Trade Venue Exists
    /// </summary>
    public unsafe struct NewOrderCrossEquityTradeVenueExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Equity Transact Time Exists
    /// </summary>
    public unsafe struct NewOrderCrossEquityTransactTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Exec Inst Exists
    /// </summary>
    public unsafe struct NewOrderCrossExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Frequent Trader Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Last Priority Exists
    /// </summary>
    public unsafe struct NewOrderCrossLastPriorityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Maturity Date Exists
    /// </summary>
    public unsafe struct NewOrderCrossMaturityDateExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Account Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Attribute Quote Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegAttributeQuoteExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Auto Match Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegAutoMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Auto Match Price Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegAutoMatchPriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Bitfield Count
    /// </summary>
    public unsafe struct NewOrderCrossMultilegBitfieldCount {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  New Order Cross Multileg Clearing Account Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegClearingAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Clearing Optional Data Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Client Id Attr Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegClientIdAttrExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Cmta Number Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Drill Thru Protection Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegDrillThruProtectionExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Buy Clearing Firm Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityBuyClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Ex Destination Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityExDestinationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Leg Short Sell Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityLegShortSellExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Party Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Sell Clearing Firm Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquitySellClearingFirmExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Trade Price Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityTradePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Trade Size Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityTradeSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Trade Venue Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityTradeVenueExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Equity Transact Time Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegEquityTransactTimeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Exec Inst Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegExecInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Frequent Trader Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Last Priority Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegLastPriorityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Ors Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegOrsExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Prevent Match Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 2 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit2Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 3 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit3Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Routing Firm Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegRoutingFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Session Eligibility Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegSessionEligibilityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Symbol Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Multileg Target Party Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossMultilegTargetPartyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Ors Exists
    /// </summary>
    public unsafe struct NewOrderCrossOrsExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Prevent Match Exists
    /// </summary>
    public unsafe struct NewOrderCrossPreventMatchExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Put Or Call Exists
    /// </summary>
    public unsafe struct NewOrderCrossPutOrCallExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Reserved Bit 1 Exists
    /// </summary>
    public unsafe struct NewOrderCrossReservedBit1Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Reserved Bit 4 Exists
    /// </summary>
    public unsafe struct NewOrderCrossReservedBit4Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Reserved Bit 5 Exists
    /// </summary>
    public unsafe struct NewOrderCrossReservedBit5Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Reserved Bit 6 Exists
    /// </summary>
    public unsafe struct NewOrderCrossReservedBit6Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Reserved Bit 7 Exists
    /// </summary>
    public unsafe struct NewOrderCrossReservedBit7Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Reserved Bit 8 Exists
    /// </summary>
    public unsafe struct NewOrderCrossReservedBit8Exists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Routing Firm Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossRoutingFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Session Eligibility Exists
    /// </summary>
    public unsafe struct NewOrderCrossSessionEligibilityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Strike Price Exists
    /// </summary>
    public unsafe struct NewOrderCrossStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Symbol Exists
    /// </summary>
    public unsafe struct NewOrderCrossSymbolExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Cross Target Party Id Exists
    /// </summary>
    public unsafe struct NewOrderCrossTargetPartyIdExists {
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
    ///  New Order Frequent Trader Id Exists
    /// </summary>
    public unsafe struct NewOrderFrequentTraderIdExists {
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
    ///  New Order Maturity Date Exists
    /// </summary>
    public unsafe struct NewOrderMaturityDateExists {
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
    ///  New Order Max Remove Pct Exists
    /// </summary>
    public unsafe struct NewOrderMaxRemovePctExists {
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
    ///  New Order Order Origin Exists
    /// </summary>
    public unsafe struct NewOrderOrderOriginExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Ors Exists
    /// </summary>
    public unsafe struct NewOrderOrsExists {
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
    ///  New Order Price Type Exists
    /// </summary>
    public unsafe struct NewOrderPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Put Or Call Exists
    /// </summary>
    public unsafe struct NewOrderPutOrCallExists {
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
    ///  New Order Route Delivery Method Exists
    /// </summary>
    public unsafe struct NewOrderRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Route Strategy Exists
    /// </summary>
    public unsafe struct NewOrderRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  New Order Routing Firm Id Exists
    /// </summary>
    public unsafe struct NewOrderRoutingFirmIdExists {
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
    ///  New Order Session Eligibility Exists
    /// </summary>
    public unsafe struct NewOrderSessionEligibilityExists {
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
    ///  New Order Strike Price Exists
    /// </summary>
    public unsafe struct NewOrderStrikePriceExists {
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
    ///  New Order Target Party Id Exists
    /// </summary>
    public unsafe struct NewOrderTargetPartyIdExists {
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
    ///  No Of Securities
    /// </summary>
    public unsafe struct NoOfSecurities {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Number Of Quote Results
    /// </summary>
    public unsafe struct NumberOfQuoteResults {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Quote Updates
    /// </summary>
    public unsafe struct NumberOfQuoteUpdates {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Short Quote Updates
    /// </summary>
    public unsafe struct NumberOfShortQuoteUpdates {
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
        Stop = (byte)'3',
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
    ///  Order Acknowledgment Alloc Qty Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentAllocQtyExists {
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
    ///  Order Acknowledgment Auction Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentAuctionIdExists {
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
    ///  Order Acknowledgment Clearing Optional Data Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Client Id Attr Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentClientIdAttrExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Contra Capacity Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentContraCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Corrected Size Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Cross Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentCrossIdExists {
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
    ///  Order Acknowledgment Drill Thru Protection Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentDrillThruProtectionExists {
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
    ///  Order Acknowledgment Equity Party Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentEquityPartyIdExists {
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
    ///  Order Acknowledgment Floor Routing Inst Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentFloorRoutingInstExists {
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
    ///  Order Acknowledgment Give Up Firm Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentGiveUpFirmIdExists {
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
    ///  Order Acknowledgment Market Fee Code Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMarketFeeCodeExists {
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
    ///  Order Acknowledgment Max Floor Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMaxFloorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Max Remove Pct Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMaxRemovePctExists {
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
    ///  Order Acknowledgment Multi Class Sprd Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentMultiClassSprdExists {
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
    ///  Order Acknowledgment Order Origin Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentOrderOriginExists {
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
    ///  Order Acknowledgment Price Type Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Put Or Call Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentPutOrCallExists {
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
    ///  Order Acknowledgment Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Route Strategy Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Routing Firm Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentRoutingFirmIdExists {
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
    ///  Order Acknowledgment Session Eligibility Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentSessionEligibilityExists {
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
    ///  Order Acknowledgment Strategy Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentStrategyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Acknowledgment Strike Price Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentStrikePriceExists {
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
    ///  Order Acknowledgment Target Party Id Exists
    /// </summary>
    public unsafe struct OrderAcknowledgmentTargetPartyIdExists {
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
    ///  Order Cancelled Alloc Qty Exists
    /// </summary>
    public unsafe struct OrderCancelledAllocQtyExists {
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
    ///  Order Cancelled Auction Id Exists
    /// </summary>
    public unsafe struct OrderCancelledAuctionIdExists {
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
    ///  Order Cancelled Cmta Number Exists
    /// </summary>
    public unsafe struct OrderCancelledCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Contra Capacity Exists
    /// </summary>
    public unsafe struct OrderCancelledContraCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Corrected Size Exists
    /// </summary>
    public unsafe struct OrderCancelledCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct OrderCancelledCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Cross Id Exists
    /// </summary>
    public unsafe struct OrderCancelledCrossIdExists {
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
    ///  Order Cancelled Equity Party Id Exists
    /// </summary>
    public unsafe struct OrderCancelledEquityPartyIdExists {
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
    ///  Order Cancelled Floor Routing Inst Exists
    /// </summary>
    public unsafe struct OrderCancelledFloorRoutingInstExists {
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
    ///  Order Cancelled Give Up Firm Id Exists
    /// </summary>
    public unsafe struct OrderCancelledGiveUpFirmIdExists {
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
    ///  Order Cancelled Market Fee Code Exists
    /// </summary>
    public unsafe struct OrderCancelledMarketFeeCodeExists {
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
    ///  Order Cancelled Max Floor Exists
    /// </summary>
    public unsafe struct OrderCancelledMaxFloorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Max Remove Pct Exists
    /// </summary>
    public unsafe struct OrderCancelledMaxRemovePctExists {
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
    ///  Order Cancelled Multi Class Sprd Exists
    /// </summary>
    public unsafe struct OrderCancelledMultiClassSprdExists {
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
    ///  Order Cancelled Order Origin Exists
    /// </summary>
    public unsafe struct OrderCancelledOrderOriginExists {
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
    ///  Order Cancelled Price Type Exists
    /// </summary>
    public unsafe struct OrderCancelledPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Put Or Call Exists
    /// </summary>
    public unsafe struct OrderCancelledPutOrCallExists {
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
    ///  Order Cancelled Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderCancelledRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Route Strategy Exists
    /// </summary>
    public unsafe struct OrderCancelledRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Routing Firm Id Exists
    /// </summary>
    public unsafe struct OrderCancelledRoutingFirmIdExists {
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
    ///  Order Cancelled Strategy Id Exists
    /// </summary>
    public unsafe struct OrderCancelledStrategyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Cancelled Strike Price Exists
    /// </summary>
    public unsafe struct OrderCancelledStrikePriceExists {
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
    ///  Order Cancelled Target Party Id Exists
    /// </summary>
    public unsafe struct OrderCancelledTargetPartyIdExists {
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
    ///  Order Execution Alloc Qty Exists
    /// </summary>
    public unsafe struct OrderExecutionAllocQtyExists {
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
    ///  Order Execution Auction Id Exists
    /// </summary>
    public unsafe struct OrderExecutionAuctionIdExists {
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
    ///  Order Execution Clearing Optional Data Exists
    /// </summary>
    public unsafe struct OrderExecutionClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Client Id Attr Exists
    /// </summary>
    public unsafe struct OrderExecutionClientIdAttrExists {
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
    ///  Order Execution Contra Capacity Exists
    /// </summary>
    public unsafe struct OrderExecutionContraCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Contra Trader Exists
    /// </summary>
    public unsafe struct OrderExecutionContraTraderExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Corrected Size Exists
    /// </summary>
    public unsafe struct OrderExecutionCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct OrderExecutionCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cross Id Exists
    /// </summary>
    public unsafe struct OrderExecutionCrossIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cross Prioritization Exists
    /// </summary>
    public unsafe struct OrderExecutionCrossPrioritizationExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Cross Type Exists
    /// </summary>
    public unsafe struct OrderExecutionCrossTypeExists {
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
    ///  Order Execution Display Indicator Exists
    /// </summary>
    public unsafe struct OrderExecutionDisplayIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Drill Thru Protection Exists
    /// </summary>
    public unsafe struct OrderExecutionDrillThruProtectionExists {
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
    ///  Order Execution Equity Party Id Exists
    /// </summary>
    public unsafe struct OrderExecutionEquityPartyIdExists {
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
    ///  Order Execution Fee Code Exists
    /// </summary>
    public unsafe struct OrderExecutionFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Floor Routing Inst Exists
    /// </summary>
    public unsafe struct OrderExecutionFloorRoutingInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Floor Trader Acronym Exists
    /// </summary>
    public unsafe struct OrderExecutionFloorTraderAcronymExists {
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
    ///  Order Execution Give Up Firm Id Exists
    /// </summary>
    public unsafe struct OrderExecutionGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Market Fee Code Exists
    /// </summary>
    public unsafe struct OrderExecutionMarketFeeCodeExists {
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
    ///  Order Execution Max Floor Exists
    /// </summary>
    public unsafe struct OrderExecutionMaxFloorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Max Remove Pct Exists
    /// </summary>
    public unsafe struct OrderExecutionMaxRemovePctExists {
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
    ///  Order Execution Multi Class Sprd Exists
    /// </summary>
    public unsafe struct OrderExecutionMultiClassSprdExists {
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
    ///  Order Execution Order Origin Exists
    /// </summary>
    public unsafe struct OrderExecutionOrderOriginExists {
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
    ///  Order Execution Price Type Exists
    /// </summary>
    public unsafe struct OrderExecutionPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Put Or Call Exists
    /// </summary>
    public unsafe struct OrderExecutionPutOrCallExists {
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
    ///  Order Execution Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderExecutionRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Route Strategy Exists
    /// </summary>
    public unsafe struct OrderExecutionRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Routing Firm Id Exists
    /// </summary>
    public unsafe struct OrderExecutionRoutingFirmIdExists {
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
    ///  Order Execution Secondary Exec Id Exists
    /// </summary>
    public unsafe struct OrderExecutionSecondaryExecIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Sender Location Id Exists
    /// </summary>
    public unsafe struct OrderExecutionSenderLocationIdExists {
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
    ///  Order Execution Strategy Id Exists
    /// </summary>
    public unsafe struct OrderExecutionStrategyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Execution Strike Price Exists
    /// </summary>
    public unsafe struct OrderExecutionStrikePriceExists {
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
    ///  Order Execution Target Party Id Exists
    /// </summary>
    public unsafe struct OrderExecutionTargetPartyIdExists {
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
    ///  Order Execution Trade Through Alert Type Exists
    /// </summary>
    public unsafe struct OrderExecutionTradeThroughAlertTypeExists {
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
    ///  Order Modified Alloc Qty Exists
    /// </summary>
    public unsafe struct OrderModifiedAllocQtyExists {
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
    ///  Order Modified Auction Id Exists
    /// </summary>
    public unsafe struct OrderModifiedAuctionIdExists {
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
    ///  Order Modified Clearing Optional Data Exists
    /// </summary>
    public unsafe struct OrderModifiedClearingOptionalDataExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Client Id Attr Exists
    /// </summary>
    public unsafe struct OrderModifiedClientIdAttrExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Contra Capacity Exists
    /// </summary>
    public unsafe struct OrderModifiedContraCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Corrected Size Exists
    /// </summary>
    public unsafe struct OrderModifiedCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct OrderModifiedCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Cross Id Exists
    /// </summary>
    public unsafe struct OrderModifiedCrossIdExists {
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
    ///  Order Modified Drill Thru Protection Exists
    /// </summary>
    public unsafe struct OrderModifiedDrillThruProtectionExists {
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
    ///  Order Modified Equity Party Id Exists
    /// </summary>
    public unsafe struct OrderModifiedEquityPartyIdExists {
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
    ///  Order Modified Floor Routing Inst Exists
    /// </summary>
    public unsafe struct OrderModifiedFloorRoutingInstExists {
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
    ///  Order Modified Give Up Firm Id Exists
    /// </summary>
    public unsafe struct OrderModifiedGiveUpFirmIdExists {
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
    ///  Order Modified Market Fee Code Exists
    /// </summary>
    public unsafe struct OrderModifiedMarketFeeCodeExists {
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
    ///  Order Modified Max Floor Exists
    /// </summary>
    public unsafe struct OrderModifiedMaxFloorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Max Remove Pct Exists
    /// </summary>
    public unsafe struct OrderModifiedMaxRemovePctExists {
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
    ///  Order Modified Multi Class Sprd Exists
    /// </summary>
    public unsafe struct OrderModifiedMultiClassSprdExists {
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
    ///  Order Modified Order Origin Exists
    /// </summary>
    public unsafe struct OrderModifiedOrderOriginExists {
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
    ///  Order Modified Price Type Exists
    /// </summary>
    public unsafe struct OrderModifiedPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Put Or Call Exists
    /// </summary>
    public unsafe struct OrderModifiedPutOrCallExists {
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
    ///  Order Modified Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderModifiedRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Route Strategy Exists
    /// </summary>
    public unsafe struct OrderModifiedRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Routing Firm Id Exists
    /// </summary>
    public unsafe struct OrderModifiedRoutingFirmIdExists {
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
    ///  Order Modified Session Eligibility Exists
    /// </summary>
    public unsafe struct OrderModifiedSessionEligibilityExists {
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
    ///  Order Modified Strategy Id Exists
    /// </summary>
    public unsafe struct OrderModifiedStrategyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Strike Price Exists
    /// </summary>
    public unsafe struct OrderModifiedStrikePriceExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Modified Sub Liquidity Indicator Exists
    /// </summary>
    public unsafe struct OrderModifiedSubLiquidityIndicatorExists {
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
    ///  Order Modified Target Party Id Exists
    /// </summary>
    public unsafe struct OrderModifiedTargetPartyIdExists {
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
    ///  Order Origin
    /// </summary>
    public unsafe struct OrderOrigin {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        OnlyCloseTransactionsAccepted = (byte)'c',
        RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
        RiskManagementEfidGroupLevel = (byte)'+',
    };


    /// <summary>
    ///  Order Rejected Account Exists
    /// </summary>
    public unsafe struct OrderRejectedAccountExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Alloc Qty Exists
    /// </summary>
    public unsafe struct OrderRejectedAllocQtyExists {
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
    ///  Order Rejected Auction Id Exists
    /// </summary>
    public unsafe struct OrderRejectedAuctionIdExists {
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
    ///  Order Rejected Client Id Attr Exists
    /// </summary>
    public unsafe struct OrderRejectedClientIdAttrExists {
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
    ///  Order Rejected Contra Capacity Exists
    /// </summary>
    public unsafe struct OrderRejectedContraCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Corrected Size Exists
    /// </summary>
    public unsafe struct OrderRejectedCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct OrderRejectedCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Cross Id Exists
    /// </summary>
    public unsafe struct OrderRejectedCrossIdExists {
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
    ///  Order Rejected Equity Party Id Exists
    /// </summary>
    public unsafe struct OrderRejectedEquityPartyIdExists {
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
    ///  Order Rejected Floor Routing Inst Exists
    /// </summary>
    public unsafe struct OrderRejectedFloorRoutingInstExists {
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
    ///  Order Rejected Give Up Firm Id Exists
    /// </summary>
    public unsafe struct OrderRejectedGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Market Fee Code Exists
    /// </summary>
    public unsafe struct OrderRejectedMarketFeeCodeExists {
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
    ///  Order Rejected Max Floor Exists
    /// </summary>
    public unsafe struct OrderRejectedMaxFloorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Max Remove Pct Exists
    /// </summary>
    public unsafe struct OrderRejectedMaxRemovePctExists {
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
    ///  Order Rejected Multi Class Sprd Exists
    /// </summary>
    public unsafe struct OrderRejectedMultiClassSprdExists {
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
    ///  Order Rejected Order Origin Exists
    /// </summary>
    public unsafe struct OrderRejectedOrderOriginExists {
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
    ///  Order Rejected Price Type Exists
    /// </summary>
    public unsafe struct OrderRejectedPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Put Or Call Exists
    /// </summary>
    public unsafe struct OrderRejectedPutOrCallExists {
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
    ///  Order Rejected Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderRejectedRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Route Strategy Exists
    /// </summary>
    public unsafe struct OrderRejectedRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Routing Firm Id Exists
    /// </summary>
    public unsafe struct OrderRejectedRoutingFirmIdExists {
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
    ///  Order Rejected Session Eligibility Exists
    /// </summary>
    public unsafe struct OrderRejectedSessionEligibilityExists {
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
    ///  Order Rejected Strategy Id Exists
    /// </summary>
    public unsafe struct OrderRejectedStrategyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Rejected Strike Price Exists
    /// </summary>
    public unsafe struct OrderRejectedStrikePriceExists {
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
    ///  Order Rejected Target Party Id Exists
    /// </summary>
    public unsafe struct OrderRejectedTargetPartyIdExists {
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
    ///  Order Restated Alloc Qty Exists
    /// </summary>
    public unsafe struct OrderRestatedAllocQtyExists {
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
    ///  Order Restated Auction Id Exists
    /// </summary>
    public unsafe struct OrderRestatedAuctionIdExists {
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
    ///  Order Restated Client Id Attr Exists
    /// </summary>
    public unsafe struct OrderRestatedClientIdAttrExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Cmta Number Exists
    /// </summary>
    public unsafe struct OrderRestatedCmtaNumberExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Contra Capacity Exists
    /// </summary>
    public unsafe struct OrderRestatedContraCapacityExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Corrected Size Exists
    /// </summary>
    public unsafe struct OrderRestatedCorrectedSizeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct OrderRestatedCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Cross Id Exists
    /// </summary>
    public unsafe struct OrderRestatedCrossIdExists {
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
    ///  Order Restated Floor Routing Inst Exists
    /// </summary>
    public unsafe struct OrderRestatedFloorRoutingInstExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Frequent Trader Id Exists
    /// </summary>
    public unsafe struct OrderRestatedFrequentTraderIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Give Up Firm Id Exists
    /// </summary>
    public unsafe struct OrderRestatedGiveUpFirmIdExists {
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
    ///  Order Restated Market Fee Code Exists
    /// </summary>
    public unsafe struct OrderRestatedMarketFeeCodeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Maturity Date Exists
    /// </summary>
    public unsafe struct OrderRestatedMaturityDateExists {
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
    ///  Order Restated Max Remove Pct Exists
    /// </summary>
    public unsafe struct OrderRestatedMaxRemovePctExists {
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
    ///  Order Restated Multi Class Sprd Exists
    /// </summary>
    public unsafe struct OrderRestatedMultiClassSprdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Open Close Exists
    /// </summary>
    public unsafe struct OrderRestatedOpenCloseExists {
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
    ///  Order Restated Order Origin Exists
    /// </summary>
    public unsafe struct OrderRestatedOrderOriginExists {
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
    ///  Order Restated Price Type Exists
    /// </summary>
    public unsafe struct OrderRestatedPriceTypeExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Put Or Call Exists
    /// </summary>
    public unsafe struct OrderRestatedPutOrCallExists {
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
    ///  Order Restated Route Delivery Method Exists
    /// </summary>
    public unsafe struct OrderRestatedRouteDeliveryMethodExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Route Strategy Exists
    /// </summary>
    public unsafe struct OrderRestatedRouteStrategyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Routing Firm Id Exists
    /// </summary>
    public unsafe struct OrderRestatedRoutingFirmIdExists {
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
    ///  Order Restated Strategy Id Exists
    /// </summary>
    public unsafe struct OrderRestatedStrategyIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Restated Strike Price Exists
    /// </summary>
    public unsafe struct OrderRestatedStrikePriceExists {
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
    ///  Order Restated Target Party Id Exists
    /// </summary>
    public unsafe struct OrderRestatedTargetPartyIdExists {
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
    ///  Ors Values
    /// </summary>
    public enum Ors : byte {
        No = (byte)'N',
        Yes = (byte)'Y',
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
    ///  Posting Instruction Values
    /// </summary>
    public enum PostingInstruction : byte {
        PostOnly = (byte)'P',
        BookOnly = (byte)'B',
        BookOnlyNoSlide = (byte)'N',
        PostOnlyNoSlide = (byte)'R',
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
    ///  Price Type Values
    /// </summary>
    public enum PriceType : byte {
        FixedCabinetTradePrice = (byte)'0',
        Percentage = (byte)'1',
        PricePerUnit = (byte)'2',
        FixedAmount = (byte)'3',
    };


    /// <summary>
    ///  Purge Reject Reason Values
    /// </summary>
    public enum PurgeRejectReason : byte {
        Admin = (byte)'A',
        DuplicateIdentifier = (byte)'D',
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
        FillWouldTradeThroughTheNbbo = (byte)'T',
        UserRequested = (byte)'U',
        WouldWash = (byte)'V',
        AddLiquidityOnlyOrderWouldRemove = (byte)'W',
        OrderExpired = (byte)'X',
        SymbolNotSupported = (byte)'Y',
        UnforeseenReason = (byte)'Z',
        OnlyCloseTransactionsAccepted = (byte)'c',
        RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
        MarketAccessRiskLimitExceeded = (byte)'m',
        MaxOpenOrdersCountExceeded = (byte)'o',
        ReserveReload = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        WouldRemoveOnUnslide = (byte)'w',
        CrossedMarket = (byte)'x',
        OrderReceivedByCboeDuringReplay = (byte)'y',
        SessionEnd = (byte)'z',
        RiskManagementEfidGroupLevel = (byte)'+',
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
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        Put = (byte)'0',
        Call = (byte)'1',
    };


    /// <summary>
    ///  Quote Liquidity Indicator Values
    /// </summary>
    public enum QuoteLiquidityIndicator : byte {
        Normal = (byte)'N',
        NbboSetter = (byte)'S',
        NbboJoiner = (byte)'J',
        MarketTurner = (byte)'U',
        NoQuoteOnBook = (byte)' ',
    };


    /// <summary>
    ///  Quote Reject Reason Values
    /// </summary>
    public enum QuoteRejectReason : byte {
        InvalidEfid = (byte)'C',
        InvalidWashId = (byte)'D',
        InvalidSessionEligibility = (byte)'E',
        NotEnabledForQuotes = (byte)'F',
        IncorrectDataCenter = (byte)'I',
        InvalidQuoteCnt = (byte)'L',
        SymbolsNotOnSameMatchingEngine = (byte)'M',
        InvalidPostingInstruction = (byte)'P',
        InvalidQuoteUpdateId = (byte)'Q',
        RiskRootDoesNotMatchAcrossQuotes = (byte)'R',
        SymbolNotFound = (byte)'S',
        InvalidWashPreventType = (byte)'W',
        Admin = (byte)'a',
        InvalidCapacity = (byte)'C',
        CloseOnly = (byte)'d',
        RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
        InvalidWashMethod = (byte)'m',
        InvalidOpenClose = (byte)'p',
        RiskManagementRiskRootLevel = (byte)'p',
        InvalidRemove = (byte)'r',
        InvalidSide = (byte)'s',
        SymbolRangeUnreachable = (byte)'u',
        QuoteReceivedByCboeDuringReplay = (byte)'y',
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
        InvalidRemove = (byte)'r',
        RiskManagementRiskRootLevel = (byte)'s',
        RejectedOtherReason = (byte)'u',
        RiskManagementEfidGroupLevel = (byte)'+',
        RejectedClosingOnlySeries = (byte)'c',
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
    ///  Reserved 15
    /// </summary>
    public unsafe struct Reserved15 {
        public const int Size = 15;

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
    ///  Reserved 2
    /// </summary>
    public unsafe struct Reserved2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 3
    /// </summary>
    public unsafe struct Reserved3 {
        public const int Size = 3;

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
    ///  Restatement Reason Values
    /// </summary>
    public enum RestatementReason : byte {
        Reload = (byte)'L',
        PriceSlidingReprice = (byte)'P',
        LiquidityUpdated = (byte)'Q',
        Reroute = (byte)'R',
        ShipAndPost = (byte)'S',
        Wash = (byte)'W',
        Liquidity = (byte)'Q',
    };


    /// <summary>
    ///  Revised Legs Values
    /// </summary>
    public enum RevisedLegs : byte {
        NotReordered = (byte)'1',
        Reordered = (byte)'2',
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
    ///  Risk Reset Result Values
    /// </summary>
    public enum RiskResetResult : byte {
        Ignored = (byte)' ',
        Success = (byte)'Y',
        RejectedExceedsFirmResetLimit = (byte)'F',
        RejectedExceedsCustomGroupIdLimit = (byte)'C',
        RejectedAutomaticRiskResetsAreDisabled = (byte)'D',
        RejectedEmptyResetRiskField = (byte)'E',
        RejectedIncorrectDataCenter = (byte)'I',
        RejectedExceedsRiskRootResetLimit = (byte)'S',
        RejectedInvalidRiskRoot = (byte)'U',
        RejectedInvalidEfidOrClearingFirm = (byte)'c',
        RejectedInReplay = (byte)'y',
    };


    /// <summary>
    ///  Risk Root
    /// </summary>
    public unsafe struct RiskRoot {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
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
    ///  Route Delivery Method Values
    /// </summary>
    public enum RouteDeliveryMethod : ulong {
        RouteToImprove = "RTI",
        RouteToFill = "RTF",
    };


    /// <summary>
    ///  Routing Firm Id
    /// </summary>
    public unsafe struct RoutingFirmId {
        public const int Size = 4;

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
    ///  Send Time
    /// </summary>
    public unsafe struct SendTime {
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
    ///  Session Eligibility Values
    /// </summary>
    public enum SessionEligibility : byte {
        All = (byte)'A',
        Rth = (byte)'R',
        BookOnlyNoSlide = (byte)'N',
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
        Aim = (byte)'1',
        Qcc = (byte)'2',
        Buy = (byte)'1',
        Sell = (byte)'2',
        SellShort = (byte)'5',
        SellShortExempt = (byte)'6',
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
    ///  Strategy Id Values
    /// </summary>
    public enum StrategyId : byte {
        Conversion = (byte)'C',
        Reversal = (byte)'R',
        Merger = (byte)'M',
        ShortStockInterest = (byte)'S',
        JellyRoll = (byte)'J',
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public long Raw;
    };


    /// <summary>
    ///  Sub Liquidity Indicator Values
    /// </summary>
    public enum SubLiquidityIndicator : byte {
        ExecutionFromOrderThatSetTheNbbo = (byte)'S',
        StepUpMechanism = (byte)'B',
        MarketTurner = (byte)'U',
        Aim = (byte)'b',
        Carried = (byte)'C',
        DoneForDay = (byte)'D',
        Qcc = (byte)'q',
        Sam = (byte)'s',
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
    ///  Target Party Id
    /// </summary>
    public unsafe struct TargetPartyId {
        public const int Size = 4;

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
        Ato = (byte)'2',
        Ioc = (byte)'3',
        Fok = (byte)'4',
        Gtd = (byte)'6',
        Atc = (byte)'6',
    };


    /// <summary>
    ///  Trade Cancel Or Correct Auction Id Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectAuctionIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  Trade Cancel Or Correct Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Cross Id Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectCrossIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Give Up Firm Id Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Marketing Fee Code Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectMarketingFeeCodeExists {
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
    ///  Trade Cancel Or Correct Put Or Call Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectPutOrCallExists {
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
    ///  Trade Cancel Or Correct Routing Firm Id Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectRoutingFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Trade Cancel Or Correct Strike Price Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectStrikePriceExists {
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
    ///  Trade Cancel Or Correct Target Party Id Exists
    /// </summary>
    public unsafe struct TradeCancelOrCorrectTargetPartyIdExists {
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
    ///  User Modify Rejected Alloc Qty Exists
    /// </summary>
    public unsafe struct UserModifyRejectedAllocQtyExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  User Modify Rejected Cross Exclusion Indicator Exists
    /// </summary>
    public unsafe struct UserModifyRejectedCrossExclusionIndicatorExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Cross Id Exists
    /// </summary>
    public unsafe struct UserModifyRejectedCrossIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  User Modify Rejected Give Up Firm Id Exists
    /// </summary>
    public unsafe struct UserModifyRejectedGiveUpFirmIdExists {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  User Modify Rejected Routing Firm Id Exists
    /// </summary>
    public unsafe struct UserModifyRejectedRoutingFirmIdExists {
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
        CancelOrderReservedBit8Exists CancelOrderReservedBit8Exists;
        CancelOrderReservedBit7Exists CancelOrderReservedBit7Exists;
        CancelOrderRoutingFirmIdExists CancelOrderRoutingFirmIdExists;
        CancelOrderMassCancelIdExists CancelOrderMassCancelIdExists;
        CancelOrderRiskRootExists CancelOrderRiskRootExists;
        CancelOrderMassCancelExists CancelOrderMassCancelExists;
        CancelOrderMassCancelLockoutExists CancelOrderMassCancelLockoutExists;
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
        CancelRejectedMaxRemovePctExists CancelRejectedMaxRemovePctExists;
        CancelRejectedMinQtyExists CancelRejectedMinQtyExists;
        CancelRejectedTimeInForceExists CancelRejectedTimeInForceExists;
        CancelRejectedOrdTypeExists CancelRejectedOrdTypeExists;
        CancelRejectedExecInstExists CancelRejectedExecInstExists;
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
        CancelRejectedCrossExclusionIndicatorExists CancelRejectedCrossExclusionIndicatorExists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedRoutingFirmIdExists CancelRejectedRoutingFirmIdExists;
        CancelRejectedGiveUpFirmIdExists CancelRejectedGiveUpFirmIdExists;
        CancelRejectedAllocQtyExists CancelRejectedAllocQtyExists;
        CancelRejectedCrossIdExists CancelRejectedCrossIdExists;
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
        CancelRejectedMassCancelIdExists CancelRejectedMassCancelIdExists;
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
        CancelRejectedCorrectedSizeExists CancelRejectedCorrectedSizeExists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedOpenCloseExists CancelRejectedOpenCloseExists;
        CancelRejectedPutOrCallExists CancelRejectedPutOrCallExists;
        CancelRejectedStrikePriceExists CancelRejectedStrikePriceExists;
        CancelRejectedMaturityDateExists CancelRejectedMaturityDateExists;
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
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
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
        CancelRejectedCmtaNumberExists CancelRejectedCmtaNumberExists;
        CancelRejectedReservedBit5Exists CancelRejectedReservedBit5Exists;
        CancelRejectedReservedBit4Exists CancelRejectedReservedBit4Exists;
        CancelRejectedAuctionIdExists CancelRejectedAuctionIdExists;
        CancelRejectedTargetPartyIdExists CancelRejectedTargetPartyIdExists;
        CancelRejectedMarketFeeCodeExists CancelRejectedMarketFeeCodeExists;
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
    ///  Struct for Complex Instrument Accepted Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte1 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte10 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte11 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte12 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte13 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte14 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedLegStrikePriceExists ComplexInstrumentAcceptedLegStrikePriceExists;
        ComplexInstrumentAcceptedLegMaturityDateExists ComplexInstrumentAcceptedLegMaturityDateExists;
        ComplexInstrumentAcceptedLegCfiCodeExists ComplexInstrumentAcceptedLegCfiCodeExists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte15 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte16 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte17 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte2 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte3 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte4 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte5 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte6 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte7 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte8 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedByte9 {
        ComplexInstrumentAcceptedReservedBit8Exists ComplexInstrumentAcceptedReservedBit8Exists;
        ComplexInstrumentAcceptedReservedBit7Exists ComplexInstrumentAcceptedReservedBit7Exists;
        ComplexInstrumentAcceptedReservedBit6Exists ComplexInstrumentAcceptedReservedBit6Exists;
        ComplexInstrumentAcceptedReservedBit5Exists ComplexInstrumentAcceptedReservedBit5Exists;
        ComplexInstrumentAcceptedReservedBit4Exists ComplexInstrumentAcceptedReservedBit4Exists;
        ComplexInstrumentAcceptedReservedBit3Exists ComplexInstrumentAcceptedReservedBit3Exists;
        ComplexInstrumentAcceptedReservedBit2Exists ComplexInstrumentAcceptedReservedBit2Exists;
        ComplexInstrumentAcceptedReservedBit1Exists ComplexInstrumentAcceptedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Accepted Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentAcceptedMessage {
        TransactionTime TransactionTime;
        ClOrdId ClOrdId;
        Symbol Symbol;
        RevisedLegs RevisedLegs;
        NoOfSecurities NoOfSecurities;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte1 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte10 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte11 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte12 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte13 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte14 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte15 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte16 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte17 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte2 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte3 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte4 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte5 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte6 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte7 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte8 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedByte9 {
        ComplexInstrumentRejectedReservedBit8Exists ComplexInstrumentRejectedReservedBit8Exists;
        ComplexInstrumentRejectedReservedBit7Exists ComplexInstrumentRejectedReservedBit7Exists;
        ComplexInstrumentRejectedReservedBit6Exists ComplexInstrumentRejectedReservedBit6Exists;
        ComplexInstrumentRejectedReservedBit5Exists ComplexInstrumentRejectedReservedBit5Exists;
        ComplexInstrumentRejectedReservedBit4Exists ComplexInstrumentRejectedReservedBit4Exists;
        ComplexInstrumentRejectedReservedBit3Exists ComplexInstrumentRejectedReservedBit3Exists;
        ComplexInstrumentRejectedReservedBit2Exists ComplexInstrumentRejectedReservedBit2Exists;
        ComplexInstrumentRejectedReservedBit1Exists ComplexInstrumentRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Complex Instrument Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexInstrumentRejectedMessage {
        TransactionTime TransactionTime;
        OrderRejectReason OrderRejectReason;
        Text Text;
        NoOfSecurities NoOfSecurities;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte1 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentExecInstExists CrossOrderAcknowledgmentExecInstExists;
        CrossOrderAcknowledgmentPriceExists CrossOrderAcknowledgmentPriceExists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentSideExists CrossOrderAcknowledgmentSideExists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte10 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentRoutingFirmIdExists CrossOrderAcknowledgmentRoutingFirmIdExists;
        CrossOrderAcknowledgmentGiveUpFirmIdExists CrossOrderAcknowledgmentGiveUpFirmIdExists;
        CrossOrderAcknowledgmentAllocQtyExists CrossOrderAcknowledgmentAllocQtyExists;
        CrossOrderAcknowledgmentCrossIdExists CrossOrderAcknowledgmentCrossIdExists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte11 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte12 {
        CrossOrderAcknowledgmentClearingOptionalDataExists CrossOrderAcknowledgmentClearingOptionalDataExists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte13 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte14 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte15 {
        CrossOrderAcknowledgmentClientIdAttrExists CrossOrderAcknowledgmentClientIdAttrExists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentEquityPartyIdExists CrossOrderAcknowledgmentEquityPartyIdExists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte16 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentFrequentTraderIdExists CrossOrderAcknowledgmentFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte17 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte2 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentCapacityExists CrossOrderAcknowledgmentCapacityExists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentSymbolExists CrossOrderAcknowledgmentSymbolExists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte3 {
        CrossOrderAcknowledgmentPreventMatchExists CrossOrderAcknowledgmentPreventMatchExists;
        CrossOrderAcknowledgmentOrderQtyExists CrossOrderAcknowledgmentOrderQtyExists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentClearingAccountExists CrossOrderAcknowledgmentClearingAccountExists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentAccountExists CrossOrderAcknowledgmentAccountExists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte4 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentOpenCloseExists CrossOrderAcknowledgmentOpenCloseExists;
        CrossOrderAcknowledgmentPutOrCallExists CrossOrderAcknowledgmentPutOrCallExists;
        CrossOrderAcknowledgmentStrikePriceExists CrossOrderAcknowledgmentStrikePriceExists;
        CrossOrderAcknowledgmentMaturityDateExists CrossOrderAcknowledgmentMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte5 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte6 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentAttributedQuoteExists CrossOrderAcknowledgmentAttributedQuoteExists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte7 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte8 {
        CrossOrderAcknowledgmentReservedBit8Exists CrossOrderAcknowledgmentReservedBit8Exists;
        CrossOrderAcknowledgmentReservedBit7Exists CrossOrderAcknowledgmentReservedBit7Exists;
        CrossOrderAcknowledgmentReservedBit6Exists CrossOrderAcknowledgmentReservedBit6Exists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentReservedBit3Exists CrossOrderAcknowledgmentReservedBit3Exists;
        CrossOrderAcknowledgmentReservedBit2Exists CrossOrderAcknowledgmentReservedBit2Exists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentByte9 {
        CrossOrderAcknowledgmentCrossPrioritizationExists CrossOrderAcknowledgmentCrossPrioritizationExists;
        CrossOrderAcknowledgmentCrossTypeExists CrossOrderAcknowledgmentCrossTypeExists;
        CrossOrderAcknowledgmentCmtaNumberExists CrossOrderAcknowledgmentCmtaNumberExists;
        CrossOrderAcknowledgmentReservedBit5Exists CrossOrderAcknowledgmentReservedBit5Exists;
        CrossOrderAcknowledgmentReservedBit4Exists CrossOrderAcknowledgmentReservedBit4Exists;
        CrossOrderAcknowledgmentAuctionIdExists CrossOrderAcknowledgmentAuctionIdExists;
        CrossOrderAcknowledgmentTargetPartyIdExists CrossOrderAcknowledgmentTargetPartyIdExists;
        CrossOrderAcknowledgmentReservedBit1Exists CrossOrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderAcknowledgmentMessage {
        TransactionTime TransactionTime;
        CrossId CrossId;
        AuctionId AuctionId;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte1 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledExecInstExists CrossOrderCancelledExecInstExists;
        CrossOrderCancelledPriceExists CrossOrderCancelledPriceExists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte10 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledRoutingFirmIdExists CrossOrderCancelledRoutingFirmIdExists;
        CrossOrderCancelledGiveUpFirmIdExists CrossOrderCancelledGiveUpFirmIdExists;
        CrossOrderCancelledAllocQtyExists CrossOrderCancelledAllocQtyExists;
        CrossOrderCancelledCrossIdExists CrossOrderCancelledCrossIdExists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte11 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte12 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte13 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte14 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte15 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledEquityPartyIdExists CrossOrderCancelledEquityPartyIdExists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte16 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledFrequentTraderIdExists CrossOrderCancelledFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte17 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte2 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledCapacityExists CrossOrderCancelledCapacityExists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledSymbolExists CrossOrderCancelledSymbolExists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte3 {
        CrossOrderCancelledPreventMatchExists CrossOrderCancelledPreventMatchExists;
        CrossOrderCancelledOrderQtyExists CrossOrderCancelledOrderQtyExists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledClearingFirmExists CrossOrderCancelledClearingFirmExists;
        CrossOrderCancelledAccountExists CrossOrderCancelledAccountExists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte4 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledPutOrCallExists CrossOrderCancelledPutOrCallExists;
        CrossOrderCancelledStrikePriceExists CrossOrderCancelledStrikePriceExists;
        CrossOrderCancelledMaturityDateExists CrossOrderCancelledMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte5 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte6 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledAttributedQuoteExists CrossOrderCancelledAttributedQuoteExists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte7 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte8 {
        CrossOrderCancelledReservedBit8Exists CrossOrderCancelledReservedBit8Exists;
        CrossOrderCancelledReservedBit7Exists CrossOrderCancelledReservedBit7Exists;
        CrossOrderCancelledReservedBit6Exists CrossOrderCancelledReservedBit6Exists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledReservedBit3Exists CrossOrderCancelledReservedBit3Exists;
        CrossOrderCancelledReservedBit2Exists CrossOrderCancelledReservedBit2Exists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledByte9 {
        CrossOrderCancelledCrossPrioritizationExists CrossOrderCancelledCrossPrioritizationExists;
        CrossOrderCancelledCrossTypeExists CrossOrderCancelledCrossTypeExists;
        CrossOrderCancelledCmtaNumberExists CrossOrderCancelledCmtaNumberExists;
        CrossOrderCancelledReservedBit5Exists CrossOrderCancelledReservedBit5Exists;
        CrossOrderCancelledReservedBit4Exists CrossOrderCancelledReservedBit4Exists;
        CrossOrderCancelledTargetPartyIdExists CrossOrderCancelledTargetPartyIdExists;
        CrossOrderCancelledTargetPartyIdExists CrossOrderCancelledTargetPartyIdExists;
        CrossOrderCancelledReservedBit1Exists CrossOrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Cancelled Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderCancelledMessage {
        TransactionTime TransactionTime;
        CrossId CrossId;
        CancelReason CancelReason;
        ReservedInternal ReservedInternal;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte1 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedExecInstExists CrossOrderRejectedExecInstExists;
        CrossOrderRejectedPriceExists CrossOrderRejectedPriceExists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 10
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte10 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedRoutingFirmIdExists CrossOrderRejectedRoutingFirmIdExists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedCrossIdExists CrossOrderRejectedCrossIdExists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 11
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte11 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 12
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte12 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 13
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte13 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 14
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte14 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte15 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedEquityPartyIdExists CrossOrderRejectedEquityPartyIdExists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte16 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedFrequentTraderIdExists CrossOrderRejectedFrequentTraderIdExists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 17
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte17 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte2 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedSymbolExists CrossOrderRejectedSymbolExists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte3 {
        CrossOrderRejectedPreventMatchExists CrossOrderRejectedPreventMatchExists;
        CrossOrderRejectedOrderQtyExists CrossOrderRejectedOrderQtyExists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte4 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedPutOrCallExists CrossOrderRejectedPutOrCallExists;
        CrossOrderRejectedStrikePriceExists CrossOrderRejectedStrikePriceExists;
        CrossOrderRejectedMaturityDateExists CrossOrderRejectedMaturityDateExists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte5 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte6 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedAttributedQuoteExists CrossOrderRejectedAttributedQuoteExists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 7
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte7 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte8 {
        CrossOrderRejectedReservedBit8Exists CrossOrderRejectedReservedBit8Exists;
        CrossOrderRejectedReservedBit7Exists CrossOrderRejectedReservedBit7Exists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedReservedBit2Exists CrossOrderRejectedReservedBit2Exists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedByte9 {
        CrossOrderRejectedCrossPrioritizationExists CrossOrderRejectedCrossPrioritizationExists;
        CrossOrderRejectedCrossTypeExists CrossOrderRejectedCrossTypeExists;
        CrossOrderRejectedReservedBit6Exists CrossOrderRejectedReservedBit6Exists;
        CrossOrderRejectedReservedBit5Exists CrossOrderRejectedReservedBit5Exists;
        CrossOrderRejectedReservedBit4Exists CrossOrderRejectedReservedBit4Exists;
        CrossOrderRejectedReservedBit3Exists CrossOrderRejectedReservedBit3Exists;
        CrossOrderRejectedTargetPartyIdExists CrossOrderRejectedTargetPartyIdExists;
        CrossOrderRejectedReservedBit1Exists CrossOrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Cross Order Rejected Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderRejectedMessage {
        TransactionTime TransactionTime;
        CrossId CrossId;
        OrderRejectReason OrderRejectReason;
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
        ModifyOrderReservedBit5Exists ModifyOrderReservedBit5Exists;
        ModifyOrderReservedBit4Exists ModifyOrderReservedBit4Exists;
        ModifyOrderRoutingFirmIdExists ModifyOrderRoutingFirmIdExists;
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
    ///  Struct for New Complex Instrument Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewComplexInstrumentByte1 {
        NewComplexInstrumentReservedBit8Exists NewComplexInstrumentReservedBit8Exists;
        NewComplexInstrumentReservedBit7Exists NewComplexInstrumentReservedBit7Exists;
        NewComplexInstrumentReservedBit6Exists NewComplexInstrumentReservedBit6Exists;
        NewComplexInstrumentReservedBit5Exists NewComplexInstrumentReservedBit5Exists;
        NewComplexInstrumentClearingFirmExists NewComplexInstrumentClearingFirmExists;
        NewComplexInstrumentLegStrikePriceExists NewComplexInstrumentLegStrikePriceExists;
        NewComplexInstrumentLegMaturityDateExists NewComplexInstrumentLegMaturityDateExists;
        NewComplexInstrumentLegCfiCodeExists NewComplexInstrumentLegCfiCodeExists;
    };


    /// <summary>
    ///  Struct for New Complex Instrument Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewComplexInstrumentMessage {
        ClOrdId ClOrdId;
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
        NewOrderMaxRemovePctExists NewOrderMaxRemovePctExists;
        NewOrderDisplayIndicatorExists NewOrderDisplayIndicatorExists;
        NewOrderAccountExists NewOrderAccountExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte4 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderTargetPartyIdExists NewOrderTargetPartyIdExists;
        NewOrderCmtaNumberExists NewOrderCmtaNumberExists;
        NewOrderOpenCloseExists NewOrderOpenCloseExists;
        NewOrderRiskResetExists NewOrderRiskResetExists;
        NewOrderPutOrCallExists NewOrderPutOrCallExists;
        NewOrderStrikePriceExists NewOrderStrikePriceExists;
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
        NewOrderExtExecInstExists NewOrderExtExecInstExists;
        NewOrderReservedBit3Exists NewOrderReservedBit3Exists;
        NewOrderAttributedQuoteExists NewOrderAttributedQuoteExists;
        NewOrderSessionEligibilityExists NewOrderSessionEligibilityExists;
    };


    /// <summary>
    ///  Struct for New Order Byte 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte6 {
        NewOrderRoutingFirmIdExists NewOrderRoutingFirmIdExists;
        NewOrderAuctionIdExists NewOrderAuctionIdExists;
        NewOrderEchoTextExists NewOrderEchoTextExists;
        NewOrderExDestinationExists NewOrderExDestinationExists;
        NewOrderRouteDeliveryMethodExists NewOrderRouteDeliveryMethodExists;
        NewOrderRouteStrategyExists NewOrderRouteStrategyExists;
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
    ///  Struct for New Order Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte8 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderFrequentTraderIdExists NewOrderFrequentTraderIdExists;
        NewOrderClientIdAttrExists NewOrderClientIdAttrExists;
        NewOrderClearingOptionalDataExists NewOrderClearingOptionalDataExists;
        NewOrderCustomGroupIdExists NewOrderCustomGroupIdExists;
        NewOrderReservedBit1Exists NewOrderReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Byte 9
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderByte9 {
        NewOrderReservedBit8Exists NewOrderReservedBit8Exists;
        NewOrderReservedBit7Exists NewOrderReservedBit7Exists;
        NewOrderReservedBit6Exists NewOrderReservedBit6Exists;
        NewOrderReservedBit5Exists NewOrderReservedBit5Exists;
        NewOrderReservedBit4Exists NewOrderReservedBit4Exists;
        NewOrderPriceTypeExists NewOrderPriceTypeExists;
        NewOrderOrsExists NewOrderOrsExists;
        NewOrderOrderOriginExists NewOrderOrderOriginExists;
    };


    /// <summary>
    ///  Struct for New Order Complex Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderComplexMessage {
        ClOrdId ClOrdId;
        Side Side;
        OrderQty OrderQty;
    };


    /// <summary>
    ///  Struct for New Order Cross Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossByte1 {
        NewOrderCrossPreventMatchExists NewOrderCrossPreventMatchExists;
        NewOrderCrossTargetPartyIdExists NewOrderCrossTargetPartyIdExists;
        NewOrderCrossAttributeQuoteExists NewOrderCrossAttributeQuoteExists;
        NewOrderCrossExecInstExists NewOrderCrossExecInstExists;
        NewOrderCrossPutOrCallExists NewOrderCrossPutOrCallExists;
        NewOrderCrossStrikePriceExists NewOrderCrossStrikePriceExists;
        NewOrderCrossMaturityDateExists NewOrderCrossMaturityDateExists;
        NewOrderCrossSymbolExists NewOrderCrossSymbolExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossByte2 {
        NewOrderCrossClearingOptionalDataExists NewOrderCrossClearingOptionalDataExists;
        NewOrderCrossRoutingFirmIdExists NewOrderCrossRoutingFirmIdExists;
        NewOrderCrossClearingAccountExists NewOrderCrossClearingAccountExists;
        NewOrderCrossCmtaNumberExists NewOrderCrossCmtaNumberExists;
        NewOrderCrossAccountExists NewOrderCrossAccountExists;
        NewOrderCrossLastPriorityExists NewOrderCrossLastPriorityExists;
        NewOrderCrossAutoMatchPriceExists NewOrderCrossAutoMatchPriceExists;
        NewOrderCrossAutoMatchExists NewOrderCrossAutoMatchExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossByte3 {
        NewOrderCrossSessionEligibilityExists NewOrderCrossSessionEligibilityExists;
        NewOrderCrossEquitySellClearingFirmExists NewOrderCrossEquitySellClearingFirmExists;
        NewOrderCrossEquityBuyClearingFirmExists NewOrderCrossEquityBuyClearingFirmExists;
        NewOrderCrossEquityTransactTimeExists NewOrderCrossEquityTransactTimeExists;
        NewOrderCrossEquityTradeVenueExists NewOrderCrossEquityTradeVenueExists;
        NewOrderCrossEquityTradeSizeExists NewOrderCrossEquityTradeSizeExists;
        NewOrderCrossEquityTradePriceExists NewOrderCrossEquityTradePriceExists;
        NewOrderCrossClientIdAttrExists NewOrderCrossClientIdAttrExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossByte4 {
        NewOrderCrossReservedBit8Exists NewOrderCrossReservedBit8Exists;
        NewOrderCrossReservedBit7Exists NewOrderCrossReservedBit7Exists;
        NewOrderCrossReservedBit6Exists NewOrderCrossReservedBit6Exists;
        NewOrderCrossReservedBit5Exists NewOrderCrossReservedBit5Exists;
        NewOrderCrossReservedBit4Exists NewOrderCrossReservedBit4Exists;
        NewOrderCrossFrequentTraderIdExists NewOrderCrossFrequentTraderIdExists;
        NewOrderCrossOrsExists NewOrderCrossOrsExists;
        NewOrderCrossReservedBit1Exists NewOrderCrossReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for New Order Cross Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMessage {
        CrossId CrossId;
        CrossType CrossType;
        CrossPrioritization CrossPrioritization;
        Price Price;
        OrderQty OrderQty;
    };


    /// <summary>
    ///  Struct for New Order Cross Multileg Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMultilegByte1 {
        NewOrderCrossMultilegPreventMatchExists NewOrderCrossMultilegPreventMatchExists;
        NewOrderCrossMultilegTargetPartyIdExists NewOrderCrossMultilegTargetPartyIdExists;
        NewOrderCrossMultilegAttributeQuoteExists NewOrderCrossMultilegAttributeQuoteExists;
        NewOrderCrossMultilegExecInstExists NewOrderCrossMultilegExecInstExists;
        NewOrderCrossMultilegReservedBit4Exists NewOrderCrossMultilegReservedBit4Exists;
        NewOrderCrossMultilegReservedBit3Exists NewOrderCrossMultilegReservedBit3Exists;
        NewOrderCrossMultilegReservedBit2Exists NewOrderCrossMultilegReservedBit2Exists;
        NewOrderCrossMultilegSymbolExists NewOrderCrossMultilegSymbolExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Multileg Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMultilegByte2 {
        NewOrderCrossMultilegClearingOptionalDataExists NewOrderCrossMultilegClearingOptionalDataExists;
        NewOrderCrossMultilegRoutingFirmIdExists NewOrderCrossMultilegRoutingFirmIdExists;
        NewOrderCrossMultilegClearingAccountExists NewOrderCrossMultilegClearingAccountExists;
        NewOrderCrossMultilegCmtaNumberExists NewOrderCrossMultilegCmtaNumberExists;
        NewOrderCrossMultilegAccountExists NewOrderCrossMultilegAccountExists;
        NewOrderCrossMultilegLastPriorityExists NewOrderCrossMultilegLastPriorityExists;
        NewOrderCrossMultilegAutoMatchPriceExists NewOrderCrossMultilegAutoMatchPriceExists;
        NewOrderCrossMultilegAutoMatchExists NewOrderCrossMultilegAutoMatchExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Multileg Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMultilegByte3 {
        NewOrderCrossMultilegSessionEligibilityExists NewOrderCrossMultilegSessionEligibilityExists;
        NewOrderCrossMultilegEquitySellClearingFirmExists NewOrderCrossMultilegEquitySellClearingFirmExists;
        NewOrderCrossMultilegEquityBuyClearingFirmExists NewOrderCrossMultilegEquityBuyClearingFirmExists;
        NewOrderCrossMultilegEquityTransactTimeExists NewOrderCrossMultilegEquityTransactTimeExists;
        NewOrderCrossMultilegEquityTradeVenueExists NewOrderCrossMultilegEquityTradeVenueExists;
        NewOrderCrossMultilegEquityTradeSizeExists NewOrderCrossMultilegEquityTradeSizeExists;
        NewOrderCrossMultilegEquityTradePriceExists NewOrderCrossMultilegEquityTradePriceExists;
        NewOrderCrossMultilegClientIdAttrExists NewOrderCrossMultilegClientIdAttrExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Multileg Byte 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMultilegByte4 {
        NewOrderCrossMultilegReservedBit8Exists NewOrderCrossMultilegReservedBit8Exists;
        NewOrderCrossMultilegEquityExDestinationExists NewOrderCrossMultilegEquityExDestinationExists;
        NewOrderCrossMultilegReservedBit6Exists NewOrderCrossMultilegReservedBit6Exists;
        NewOrderCrossMultilegDrillThruProtectionExists NewOrderCrossMultilegDrillThruProtectionExists;
        NewOrderCrossMultilegReservedBit4Exists NewOrderCrossMultilegReservedBit4Exists;
        NewOrderCrossMultilegReservedBit3Exists NewOrderCrossMultilegReservedBit3Exists;
        NewOrderCrossMultilegEquityLegShortSellExists NewOrderCrossMultilegEquityLegShortSellExists;
        NewOrderCrossMultilegEquityPartyIdExists NewOrderCrossMultilegEquityPartyIdExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Multileg Byte 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMultilegByte5 {
        NewOrderCrossMultilegReservedBit8Exists NewOrderCrossMultilegReservedBit8Exists;
        NewOrderCrossMultilegReservedBit7Exists NewOrderCrossMultilegReservedBit7Exists;
        NewOrderCrossMultilegReservedBit6Exists NewOrderCrossMultilegReservedBit6Exists;
        NewOrderCrossMultilegReservedBit5Exists NewOrderCrossMultilegReservedBit5Exists;
        NewOrderCrossMultilegReservedBit4Exists NewOrderCrossMultilegReservedBit4Exists;
        NewOrderCrossMultilegReservedBit3Exists NewOrderCrossMultilegReservedBit3Exists;
        NewOrderCrossMultilegFrequentTraderIdExists NewOrderCrossMultilegFrequentTraderIdExists;
        NewOrderCrossMultilegOrsExists NewOrderCrossMultilegOrsExists;
    };


    /// <summary>
    ///  Struct for New Order Cross Multileg Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderCrossMultilegMessage {
        CrossId CrossId;
        CrossType CrossType;
        CrossPrioritization CrossPrioritization;
        Price Price;
        OrderQty OrderQty;
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
        OrderAcknowledgmentMaxRemovePctExists OrderAcknowledgmentMaxRemovePctExists;
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
        OrderAcknowledgmentCrossExclusionIndicatorExists OrderAcknowledgmentCrossExclusionIndicatorExists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentRoutingFirmIdExists OrderAcknowledgmentRoutingFirmIdExists;
        OrderAcknowledgmentGiveUpFirmIdExists OrderAcknowledgmentGiveUpFirmIdExists;
        OrderAcknowledgmentAllocQtyExists OrderAcknowledgmentAllocQtyExists;
        OrderAcknowledgmentCrossIdExists OrderAcknowledgmentCrossIdExists;
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
        OrderAcknowledgmentClearingOptionalDataExists OrderAcknowledgmentClearingOptionalDataExists;
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
        OrderAcknowledgmentDrillThruProtectionExists OrderAcknowledgmentDrillThruProtectionExists;
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
        OrderAcknowledgmentClientIdAttrExists OrderAcknowledgmentClientIdAttrExists;
        OrderAcknowledgmentReservedBit7Exists OrderAcknowledgmentReservedBit7Exists;
        OrderAcknowledgmentReservedBit6Exists OrderAcknowledgmentReservedBit6Exists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentEquityPartyIdExists OrderAcknowledgmentEquityPartyIdExists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Acknowledgment Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderAcknowledgmentByte16 {
        OrderAcknowledgmentOrderOriginExists OrderAcknowledgmentOrderOriginExists;
        OrderAcknowledgmentMultiClassSprdExists OrderAcknowledgmentMultiClassSprdExists;
        OrderAcknowledgmentFloorRoutingInstExists OrderAcknowledgmentFloorRoutingInstExists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentReservedBit4Exists OrderAcknowledgmentReservedBit4Exists;
        OrderAcknowledgmentReservedBit3Exists OrderAcknowledgmentReservedBit3Exists;
        OrderAcknowledgmentSessionEligibilityExists OrderAcknowledgmentSessionEligibilityExists;
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
        OrderAcknowledgmentStrategyIdExists OrderAcknowledgmentStrategyIdExists;
        OrderAcknowledgmentPriceTypeExists OrderAcknowledgmentPriceTypeExists;
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
        OrderAcknowledgmentCorrectedSizeExists OrderAcknowledgmentCorrectedSizeExists;
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentOpenCloseExists OrderAcknowledgmentOpenCloseExists;
        OrderAcknowledgmentPutOrCallExists OrderAcknowledgmentPutOrCallExists;
        OrderAcknowledgmentStrikePriceExists OrderAcknowledgmentStrikePriceExists;
        OrderAcknowledgmentMaturityDateExists OrderAcknowledgmentMaturityDateExists;
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
        OrderAcknowledgmentReservedBit5Exists OrderAcknowledgmentReservedBit5Exists;
        OrderAcknowledgmentAttributedQuoteExists OrderAcknowledgmentAttributedQuoteExists;
        OrderAcknowledgmentContraCapacityExists OrderAcknowledgmentContraCapacityExists;
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
        OrderAcknowledgmentRouteStrategyExists OrderAcknowledgmentRouteStrategyExists;
        OrderAcknowledgmentRoutingInstExists OrderAcknowledgmentRoutingInstExists;
        OrderAcknowledgmentStopPxExists OrderAcknowledgmentStopPxExists;
        OrderAcknowledgmentEchoTextExists OrderAcknowledgmentEchoTextExists;
        OrderAcknowledgmentReservedBit1Exists OrderAcknowledgmentReservedBit1Exists;
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
        OrderAcknowledgmentAuctionIdExists OrderAcknowledgmentAuctionIdExists;
        OrderAcknowledgmentTargetPartyIdExists OrderAcknowledgmentTargetPartyIdExists;
        OrderAcknowledgmentMarketFeeCodeExists OrderAcknowledgmentMarketFeeCodeExists;
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
        OrderCancelledMaxRemovePctExists OrderCancelledMaxRemovePctExists;
        OrderCancelledMinQtyExists OrderCancelledMinQtyExists;
        OrderCancelledTimeInForceExists OrderCancelledTimeInForceExists;
        OrderCancelledOrdTypeExists OrderCancelledOrdTypeExists;
        OrderCancelledExecInstExists OrderCancelledExecInstExists;
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
        OrderCancelledCrossExclusionIndicatorExists OrderCancelledCrossExclusionIndicatorExists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledRoutingFirmIdExists OrderCancelledRoutingFirmIdExists;
        OrderCancelledGiveUpFirmIdExists OrderCancelledGiveUpFirmIdExists;
        OrderCancelledAllocQtyExists OrderCancelledAllocQtyExists;
        OrderCancelledCrossIdExists OrderCancelledCrossIdExists;
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
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledReservedBit3Exists OrderCancelledReservedBit3Exists;
        OrderCancelledEquityPartyIdExists OrderCancelledEquityPartyIdExists;
        OrderCancelledReservedBit1Exists OrderCancelledReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Cancelled Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderCancelledByte16 {
        OrderCancelledOrderOriginExists OrderCancelledOrderOriginExists;
        OrderCancelledMultiClassSprdExists OrderCancelledMultiClassSprdExists;
        OrderCancelledFloorRoutingInstExists OrderCancelledFloorRoutingInstExists;
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
        OrderCancelledStrategyIdExists OrderCancelledStrategyIdExists;
        OrderCancelledPriceTypeExists OrderCancelledPriceTypeExists;
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
        OrderCancelledCorrectedSizeExists OrderCancelledCorrectedSizeExists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledOpenCloseExists OrderCancelledOpenCloseExists;
        OrderCancelledPutOrCallExists OrderCancelledPutOrCallExists;
        OrderCancelledStrikePriceExists OrderCancelledStrikePriceExists;
        OrderCancelledMaturityDateExists OrderCancelledMaturityDateExists;
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
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledAttributedQuoteExists OrderCancelledAttributedQuoteExists;
        OrderCancelledContraCapacityExists OrderCancelledContraCapacityExists;
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
        OrderCancelledRouteStrategyExists OrderCancelledRouteStrategyExists;
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
        OrderCancelledCmtaNumberExists OrderCancelledCmtaNumberExists;
        OrderCancelledReservedBit5Exists OrderCancelledReservedBit5Exists;
        OrderCancelledReservedBit4Exists OrderCancelledReservedBit4Exists;
        OrderCancelledAuctionIdExists OrderCancelledAuctionIdExists;
        OrderCancelledTargetPartyIdExists OrderCancelledTargetPartyIdExists;
        OrderCancelledMarketFeeCodeExists OrderCancelledMarketFeeCodeExists;
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
        OrderExecutionMaxRemovePctExists OrderExecutionMaxRemovePctExists;
        OrderExecutionMinQtyExists OrderExecutionMinQtyExists;
        OrderExecutionTimeInForceExists OrderExecutionTimeInForceExists;
        OrderExecutionOrdTypeExists OrderExecutionOrdTypeExists;
        OrderExecutionExecInstExists OrderExecutionExecInstExists;
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
        OrderExecutionCrossExclusionIndicatorExists OrderExecutionCrossExclusionIndicatorExists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionRoutingFirmIdExists OrderExecutionRoutingFirmIdExists;
        OrderExecutionGiveUpFirmIdExists OrderExecutionGiveUpFirmIdExists;
        OrderExecutionAllocQtyExists OrderExecutionAllocQtyExists;
        OrderExecutionCrossIdExists OrderExecutionCrossIdExists;
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
        OrderExecutionClearingOptionalDataExists OrderExecutionClearingOptionalDataExists;
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
        OrderExecutionMultilegReportingTypeExists OrderExecutionMultilegReportingTypeExists;
        OrderExecutionDrillThruProtectionExists OrderExecutionDrillThruProtectionExists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
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
        OrderExecutionClientIdAttrExists OrderExecutionClientIdAttrExists;
        OrderExecutionReservedBit7Exists OrderExecutionReservedBit7Exists;
        OrderExecutionReservedBit6Exists OrderExecutionReservedBit6Exists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionEquityPartyIdExists OrderExecutionEquityPartyIdExists;
        OrderExecutionReservedBit1Exists OrderExecutionReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte16 {
        OrderExecutionOrderOriginExists OrderExecutionOrderOriginExists;
        OrderExecutionMultiClassSprdExists OrderExecutionMultiClassSprdExists;
        OrderExecutionFloorRoutingInstExists OrderExecutionFloorRoutingInstExists;
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
        OrderExecutionFloorTraderAcronymExists OrderExecutionFloorTraderAcronymExists;
        OrderExecutionSenderLocationIdExists OrderExecutionSenderLocationIdExists;
        OrderExecutionTradeThroughAlertTypeExists OrderExecutionTradeThroughAlertTypeExists;
        OrderExecutionReservedBit3Exists OrderExecutionReservedBit3Exists;
        OrderExecutionStrategyIdExists OrderExecutionStrategyIdExists;
        OrderExecutionPriceTypeExists OrderExecutionPriceTypeExists;
    };


    /// <summary>
    ///  Struct for Order Execution Byte 2
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderExecutionByte2 {
        OrderExecutionContraTraderExists OrderExecutionContraTraderExists;
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
        OrderExecutionCorrectedSizeExists OrderExecutionCorrectedSizeExists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionOpenCloseExists OrderExecutionOpenCloseExists;
        OrderExecutionPutOrCallExists OrderExecutionPutOrCallExists;
        OrderExecutionStrikePriceExists OrderExecutionStrikePriceExists;
        OrderExecutionMaturityDateExists OrderExecutionMaturityDateExists;
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
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionAttributedQuoteExists OrderExecutionAttributedQuoteExists;
        OrderExecutionContraCapacityExists OrderExecutionContraCapacityExists;
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
        OrderExecutionRouteStrategyExists OrderExecutionRouteStrategyExists;
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
        OrderExecutionCrossPrioritizationExists OrderExecutionCrossPrioritizationExists;
        OrderExecutionCrossTypeExists OrderExecutionCrossTypeExists;
        OrderExecutionCmtaNumberExists OrderExecutionCmtaNumberExists;
        OrderExecutionReservedBit5Exists OrderExecutionReservedBit5Exists;
        OrderExecutionReservedBit4Exists OrderExecutionReservedBit4Exists;
        OrderExecutionAuctionIdExists OrderExecutionAuctionIdExists;
        OrderExecutionTargetPartyIdExists OrderExecutionTargetPartyIdExists;
        OrderExecutionMarketFeeCodeExists OrderExecutionMarketFeeCodeExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 1
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte1 {
        OrderModifiedMaxRemovePctExists OrderModifiedMaxRemovePctExists;
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
        OrderModifiedCrossExclusionIndicatorExists OrderModifiedCrossExclusionIndicatorExists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedRoutingFirmIdExists OrderModifiedRoutingFirmIdExists;
        OrderModifiedGiveUpFirmIdExists OrderModifiedGiveUpFirmIdExists;
        OrderModifiedAllocQtyExists OrderModifiedAllocQtyExists;
        OrderModifiedCrossIdExists OrderModifiedCrossIdExists;
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
        OrderModifiedClearingOptionalDataExists OrderModifiedClearingOptionalDataExists;
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
        OrderModifiedDrillThruProtectionExists OrderModifiedDrillThruProtectionExists;
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
        OrderModifiedClientIdAttrExists OrderModifiedClientIdAttrExists;
        OrderModifiedReservedBit7Exists OrderModifiedReservedBit7Exists;
        OrderModifiedReservedBit6Exists OrderModifiedReservedBit6Exists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedEquityPartyIdExists OrderModifiedEquityPartyIdExists;
        OrderModifiedReservedBit1Exists OrderModifiedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte16 {
        OrderModifiedOrderOriginExists OrderModifiedOrderOriginExists;
        OrderModifiedMultiClassSprdExists OrderModifiedMultiClassSprdExists;
        OrderModifiedFloorRoutingInstExists OrderModifiedFloorRoutingInstExists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedReservedBit4Exists OrderModifiedReservedBit4Exists;
        OrderModifiedReservedBit3Exists OrderModifiedReservedBit3Exists;
        OrderModifiedSessionEligibilityExists OrderModifiedSessionEligibilityExists;
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
        OrderModifiedStrategyIdExists OrderModifiedStrategyIdExists;
        OrderModifiedPriceTypeExists OrderModifiedPriceTypeExists;
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
        OrderModifiedCorrectedSizeExists OrderModifiedCorrectedSizeExists;
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedOpenCloseExists OrderModifiedOpenCloseExists;
        OrderModifiedPutOrCallExists OrderModifiedPutOrCallExists;
        OrderModifiedStrikePriceExists OrderModifiedStrikePriceExists;
        OrderModifiedMaturityDateExists OrderModifiedMaturityDateExists;
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
        OrderModifiedReservedBit5Exists OrderModifiedReservedBit5Exists;
        OrderModifiedAttributedQuoteExists OrderModifiedAttributedQuoteExists;
        OrderModifiedContraCapacityExists OrderModifiedContraCapacityExists;
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
        OrderModifiedSubLiquidityIndicatorExists OrderModifiedSubLiquidityIndicatorExists;
    };


    /// <summary>
    ///  Struct for Order Modified Byte 8
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderModifiedByte8 {
        OrderModifiedReservedBit8Exists OrderModifiedReservedBit8Exists;
        OrderModifiedExDestinationExists OrderModifiedExDestinationExists;
        OrderModifiedRouteDeliveryMethodExists OrderModifiedRouteDeliveryMethodExists;
        OrderModifiedRouteStrategyExists OrderModifiedRouteStrategyExists;
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
        OrderModifiedAuctionIdExists OrderModifiedAuctionIdExists;
        OrderModifiedTargetPartyIdExists OrderModifiedTargetPartyIdExists;
        OrderModifiedMarketFeeCodeExists OrderModifiedMarketFeeCodeExists;
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
        OrderRejectedMaxRemovePctExists OrderRejectedMaxRemovePctExists;
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
        OrderRejectedCrossExclusionIndicatorExists OrderRejectedCrossExclusionIndicatorExists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedRoutingFirmIdExists OrderRejectedRoutingFirmIdExists;
        OrderRejectedGiveUpFirmIdExists OrderRejectedGiveUpFirmIdExists;
        OrderRejectedAllocQtyExists OrderRejectedAllocQtyExists;
        OrderRejectedCrossIdExists OrderRejectedCrossIdExists;
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
        OrderRejectedClientIdAttrExists OrderRejectedClientIdAttrExists;
        OrderRejectedReservedBit7Exists OrderRejectedReservedBit7Exists;
        OrderRejectedReservedBit6Exists OrderRejectedReservedBit6Exists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedEquityPartyIdExists OrderRejectedEquityPartyIdExists;
        OrderRejectedReservedBit1Exists OrderRejectedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Rejected Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRejectedByte16 {
        OrderRejectedOrderOriginExists OrderRejectedOrderOriginExists;
        OrderRejectedMultiClassSprdExists OrderRejectedMultiClassSprdExists;
        OrderRejectedFloorRoutingInstExists OrderRejectedFloorRoutingInstExists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedReservedBit3Exists OrderRejectedReservedBit3Exists;
        OrderRejectedSessionEligibilityExists OrderRejectedSessionEligibilityExists;
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
        OrderRejectedStrategyIdExists OrderRejectedStrategyIdExists;
        OrderRejectedPriceTypeExists OrderRejectedPriceTypeExists;
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
        OrderRejectedCorrectedSizeExists OrderRejectedCorrectedSizeExists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedOpenCloseExists OrderRejectedOpenCloseExists;
        OrderRejectedPutOrCallExists OrderRejectedPutOrCallExists;
        OrderRejectedStrikePriceExists OrderRejectedStrikePriceExists;
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
        OrderRejectedAttributedQuoteExists OrderRejectedAttributedQuoteExists;
        OrderRejectedContraCapacityExists OrderRejectedContraCapacityExists;
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
        OrderRejectedRouteStrategyExists OrderRejectedRouteStrategyExists;
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
        OrderRejectedCmtaNumberExists OrderRejectedCmtaNumberExists;
        OrderRejectedReservedBit5Exists OrderRejectedReservedBit5Exists;
        OrderRejectedReservedBit4Exists OrderRejectedReservedBit4Exists;
        OrderRejectedAuctionIdExists OrderRejectedAuctionIdExists;
        OrderRejectedTargetPartyIdExists OrderRejectedTargetPartyIdExists;
        OrderRejectedMarketFeeCodeExists OrderRejectedMarketFeeCodeExists;
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
        OrderRestatedMaxRemovePctExists OrderRestatedMaxRemovePctExists;
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
        OrderRestatedCrossExclusionIndicatorExists OrderRestatedCrossExclusionIndicatorExists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedRoutingFirmIdExists OrderRestatedRoutingFirmIdExists;
        OrderRestatedGiveUpFirmIdExists OrderRestatedGiveUpFirmIdExists;
        OrderRestatedAllocQtyExists OrderRestatedAllocQtyExists;
        OrderRestatedCrossIdExists OrderRestatedCrossIdExists;
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
        OrderRestatedClientIdAttrExists OrderRestatedClientIdAttrExists;
        OrderRestatedReservedBit7Exists OrderRestatedReservedBit7Exists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedReservedBit1Exists OrderRestatedReservedBit1Exists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte16 {
        OrderRestatedOrderOriginExists OrderRestatedOrderOriginExists;
        OrderRestatedMultiClassSprdExists OrderRestatedMultiClassSprdExists;
        OrderRestatedFloorRoutingInstExists OrderRestatedFloorRoutingInstExists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedReservedBit3Exists OrderRestatedReservedBit3Exists;
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedFrequentTraderIdExists OrderRestatedFrequentTraderIdExists;
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
        OrderRestatedStrategyIdExists OrderRestatedStrategyIdExists;
        OrderRestatedPriceTypeExists OrderRestatedPriceTypeExists;
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
        OrderRestatedReservedBit2Exists OrderRestatedReservedBit2Exists;
        OrderRestatedSymbolExists OrderRestatedSymbolExists;
    };


    /// <summary>
    ///  Struct for Order Restated Byte 3
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderRestatedByte3 {
        OrderRestatedPreventMatchExists OrderRestatedPreventMatchExists;
        OrderRestatedOrderQtyExists OrderRestatedOrderQtyExists;
        OrderRestatedReservedBit6Exists OrderRestatedReservedBit6Exists;
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
        OrderRestatedCorrectedSizeExists OrderRestatedCorrectedSizeExists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedOpenCloseExists OrderRestatedOpenCloseExists;
        OrderRestatedPutOrCallExists OrderRestatedPutOrCallExists;
        OrderRestatedStrikePriceExists OrderRestatedStrikePriceExists;
        OrderRestatedMaturityDateExists OrderRestatedMaturityDateExists;
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
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedAttributedQuoteExists OrderRestatedAttributedQuoteExists;
        OrderRestatedContraCapacityExists OrderRestatedContraCapacityExists;
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
        OrderRestatedRouteStrategyExists OrderRestatedRouteStrategyExists;
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
        OrderRestatedCmtaNumberExists OrderRestatedCmtaNumberExists;
        OrderRestatedReservedBit5Exists OrderRestatedReservedBit5Exists;
        OrderRestatedReservedBit4Exists OrderRestatedReservedBit4Exists;
        OrderRestatedAuctionIdExists OrderRestatedAuctionIdExists;
        OrderRestatedTargetPartyIdExists OrderRestatedTargetPartyIdExists;
        OrderRestatedMarketFeeCodeExists OrderRestatedMarketFeeCodeExists;
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
    ///  Struct for Purge Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PurgeOrderMessage {
        MassCancel MassCancel;
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
        ContraTrader ContraTrader;
        ContraCapacity ContraCapacity;
        Side Side;
        BaseLiquidityIndicator BaseLiquidityIndicator;
        SubLiquidityIndicator SubLiquidityIndicator;
        FeeCode FeeCode;
        MarketingFeeCode MarketingFeeCode;
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
    ///  Struct for Quote Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteUpdate {
        Symbol Symbol;
        Side Side;
        OpenClose OpenClose;
        Price Price;
        OrderQty OrderQty;
        Reserved12 Reserved12;
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
        Reserved15 Reserved15;
        SendTime SendTime;
        PostingInstruction PostingInstruction;
        SessionEligibility SessionEligibility;
        NumberOfQuoteUpdates NumberOfQuoteUpdates;
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
    ///  Struct for Reset Risk Acknowledgment Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ResetRiskAcknowledgmentMessage {
        RiskStatusId RiskStatusId;
        RiskResetResult RiskResetResult;
    };


    /// <summary>
    ///  Struct for Return Bitfields
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReturnBitfields {
        ApplicationMessageType ApplicationMessageType;
    };


    /// <summary>
    ///  Struct for Risk Reset Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RiskResetMessage {
        RiskStatusId RiskStatusId;
        RiskReset RiskReset;
        Reserved4 Reserved4;
        ClearingFirm ClearingFirm;
        RiskRoot RiskRoot;
        CustomGroupId CustomGroupId;
    };


    /// <summary>
    ///  Struct for Short Quote Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteUpdate {
        Symbol Symbol;
        Side Side;
        OpenClose OpenClose;
        Price Price;
        OrderQty OrderQty;
        Reserved2 Reserved2;
    };


    /// <summary>
    ///  Struct for Short Quote Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ShortQuoteUpdateMessage {
        QuoteUpdateId QuoteUpdateId;
        ClearingFirm ClearingFirm;
        ClearingAccount ClearingAccount;
        CustomGroupId CustomGroupId;
        Capacity Capacity;
        Reserved3 Reserved3;
        SendTime SendTime;
        PostingInstruction PostingInstruction;
        SessionEligibility SessionEligibility;
        NumberOfShortQuoteUpdates NumberOfShortQuoteUpdates;
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
        TradeCancelOrCorrectCrossExclusionIndicatorExists TradeCancelOrCorrectCrossExclusionIndicatorExists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectRoutingFirmIdExists TradeCancelOrCorrectRoutingFirmIdExists;
        TradeCancelOrCorrectGiveUpFirmIdExists TradeCancelOrCorrectGiveUpFirmIdExists;
        TradeCancelOrCorrectReservedBit2Exists TradeCancelOrCorrectReservedBit2Exists;
        TradeCancelOrCorrectCrossIdExists TradeCancelOrCorrectCrossIdExists;
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
        TradeCancelOrCorrectPutOrCallExists TradeCancelOrCorrectPutOrCallExists;
        TradeCancelOrCorrectStrikePriceExists TradeCancelOrCorrectStrikePriceExists;
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
        TradeCancelOrCorrectCmtaNumberExists TradeCancelOrCorrectCmtaNumberExists;
        TradeCancelOrCorrectReservedBit5Exists TradeCancelOrCorrectReservedBit5Exists;
        TradeCancelOrCorrectReservedBit4Exists TradeCancelOrCorrectReservedBit4Exists;
        TradeCancelOrCorrectAuctionIdExists TradeCancelOrCorrectAuctionIdExists;
        TradeCancelOrCorrectTargetPartyIdExists TradeCancelOrCorrectTargetPartyIdExists;
        TradeCancelOrCorrectMarketingFeeCodeExists TradeCancelOrCorrectMarketingFeeCodeExists;
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
        UserModifyRejectedCrossExclusionIndicatorExists UserModifyRejectedCrossExclusionIndicatorExists;
        UserModifyRejectedReservedBit5Exists UserModifyRejectedReservedBit5Exists;
        UserModifyRejectedRoutingFirmIdExists UserModifyRejectedRoutingFirmIdExists;
        UserModifyRejectedGiveUpFirmIdExists UserModifyRejectedGiveUpFirmIdExists;
        UserModifyRejectedAllocQtyExists UserModifyRejectedAllocQtyExists;
        UserModifyRejectedCrossIdExists UserModifyRejectedCrossIdExists;
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


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
