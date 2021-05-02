namespace Euronext.Optiq.OrderEntryGateway.Sbe.v4.2.2 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Account Number
    /// </summary>
    public unsafe struct AccountNumber {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Account Number Cross
    /// </summary>
    public unsafe struct AccountNumberCross {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Account Type
    /// </summary>
    public unsafe struct AccountType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Account Type Cross
    /// </summary>
    public unsafe struct AccountTypeCross {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ack Phase
    /// </summary>
    public unsafe struct AckPhase {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ack Qualifiers
    /// </summary>
    public unsafe struct AckQualifiers {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ack Type
    /// </summary>
    public unsafe struct AckType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Action Type
    /// </summary>
    public unsafe struct ActionType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Afq Reason
    /// </summary>
    public unsafe struct AfqReason {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Length
    /// </summary>
    public unsafe struct BlockLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Book In
    /// </summary>
    public unsafe struct BookIn {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Book Out Time
    /// </summary>
    public unsafe struct BookOutTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bypass Indicator
    /// </summary>
    public unsafe struct BypassIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ccpid
    /// </summary>
    public unsafe struct Ccpid {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Centralisation Date
    /// </summary>
    public unsafe struct CentralisationDate {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cl Msg Seq Num
    /// </summary>
    public unsafe struct ClMsgSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Firm Id
    /// </summary>
    public unsafe struct ClearingFirmId {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Clearing Instruction
    /// </summary>
    public unsafe struct ClearingInstruction {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Client Identification Short Code Cross
    /// </summary>
    public struct ClientIdentificationShortCodeCross {
        public int Raw;
    };


    /// <summary>
    ///  Client Identification Shortcode
    /// </summary>
    public struct ClientIdentificationShortcode {
        public int Raw;
    };


    /// <summary>
    ///  Client Order Id
    /// </summary>
    public struct ClientOrderId {
        public long Raw;
    };


    /// <summary>
    ///  Contract Id
    /// </summary>
    public unsafe struct ContractId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Symbol Index
    /// </summary>
    public unsafe struct ContractSymbolIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Counterpart Firm Id
    /// </summary>
    public unsafe struct CounterpartFirmId {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dark Execution Instruction
    /// </summary>
    public unsafe struct DarkExecutionInstruction {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Declaration Id
    /// </summary>
    public unsafe struct DeclarationId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Declaration Status
    /// </summary>
    public unsafe struct DeclarationStatus {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Emm
    /// </summary>
    public unsafe struct Emm {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  End Client
    /// </summary>
    public unsafe struct EndClient {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  End Time Vwap
    /// </summary>
    public unsafe struct EndTimeVwap {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Entering Counterparty
    /// </summary>
    public unsafe struct EnteringCounterparty {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Error Code
    /// </summary>
    public unsafe struct ErrorCode {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Escb Membership
    /// </summary>
    public unsafe struct EscbMembership {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exchange Id
    /// </summary>
    public unsafe struct ExchangeId {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Execution Id
    /// </summary>
    public unsafe struct ExecutionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Execution Instruction
    /// </summary>
    public unsafe struct ExecutionInstruction {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Execution Phase
    /// </summary>
    public unsafe struct ExecutionPhase {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Execution Within Firm Short Code
    /// </summary>
    public struct ExecutionWithinFirmShortCode {
        public int Raw;
    };


    /// <summary>
    ///  Family Id
    /// </summary>
    public unsafe struct FamilyId {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Firm Id
    /// </summary>
    public unsafe struct FirmId {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Firm Id Publication
    /// </summary>
    public unsafe struct FirmIdPublication {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Frame
    /// </summary>
    public unsafe struct Frame {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Free Text
    /// </summary>
    public unsafe struct FreeText {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Free Text Cross
    /// </summary>
    public unsafe struct FreeTextCross {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Gross Trade Amount
    /// </summary>
    public struct GrossTradeAmount {
        public long Raw;
    };


    /// <summary>
    ///  Guarantee Flag
    /// </summary>
    public unsafe struct GuaranteeFlag {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Input Price Type
    /// </summary>
    public unsafe struct InputPriceType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Instrument Group Code
    /// </summary>
    public unsafe struct InstrumentGroupCode {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Investment Decision W Firm Short Code
    /// </summary>
    public struct InvestmentDecisionWFirmShortCode {
        public int Raw;
    };


    /// <summary>
    ///  Kill Reason
    /// </summary>
    public unsafe struct KillReason {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Book In Time
    /// </summary>
    public unsafe struct LastBookInTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Cl Msg Seq Num
    /// </summary>
    public unsafe struct LastClMsgSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Msg Seq Num
    /// </summary>
    public unsafe struct LastMsgSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Shares
    /// </summary>
    public unsafe struct LastShares {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Traded Px
    /// </summary>
    public struct LastTradedPx {
        public long Raw;
    };


    /// <summary>
    ///  Leaves Qty
    /// </summary>
    public unsafe struct LeavesQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lis Transaction Id
    /// </summary>
    public unsafe struct LisTransactionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Log Out Reason Code
    /// </summary>
    public unsafe struct LogOutReasonCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Logical Access Id
    /// </summary>
    public unsafe struct LogicalAccessId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Logon Reject Code
    /// </summary>
    public unsafe struct LogonRejectCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Long Client Id
    /// </summary>
    public unsafe struct LongClientId {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lp Action Code
    /// </summary>
    public unsafe struct LpActionCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lp Role
    /// </summary>
    public unsafe struct LpRole {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity
    /// </summary>
    public unsafe struct Maturity {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Price Notation
    /// </summary>
    public unsafe struct MessagePriceNotation {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mi Cof Secondary Listing
    /// </summary>
    public unsafe struct MiCofSecondaryListing {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mi Fid Indicators
    /// </summary>
    public unsafe struct MiFidIndicators {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Min Order Qty
    /// </summary>
    public unsafe struct MinOrderQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Miscellaneous Fee Amount
    /// </summary>
    public struct MiscellaneousFeeAmount {
        public long Raw;
    };


    /// <summary>
    ///  Mmp Execution Type
    /// </summary>
    public unsafe struct MmpExecutionType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Msg Seq Num
    /// </summary>
    public unsafe struct MsgSeqNum {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Non Executing Client Id
    /// </summary>
    public unsafe struct NonExecutingClientId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of L Ps
    /// </summary>
    public unsafe struct NumberOfLPs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Oe Partition Id
    /// </summary>
    public unsafe struct OePartitionId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Oegin From Me
    /// </summary>
    public unsafe struct OeginFromMe {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Oegin From Member
    /// </summary>
    public unsafe struct OeginFromMember {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Oegout Time To Me
    /// </summary>
    public unsafe struct OegoutTimeToMe {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Oegout To Member
    /// </summary>
    public unsafe struct OegoutToMember {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Open Close
    /// </summary>
    public unsafe struct OpenClose {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Operation Type
    /// </summary>
    public unsafe struct OperationType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Option Type
    /// </summary>
    public unsafe struct OptionType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Actor Type
    /// </summary>
    public unsafe struct OrderActorType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Category
    /// </summary>
    public unsafe struct OrderCategory {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Order Priority
    /// </summary>
    public unsafe struct OrderPriority {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Px
    /// </summary>
    public struct OrderPx {
        public long Raw;
    };


    /// <summary>
    ///  Order Qty
    /// </summary>
    public unsafe struct OrderQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Side
    /// </summary>
    public unsafe struct OrderSide {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Size Limit
    /// </summary>
    public unsafe struct OrderSizeLimit {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Type
    /// </summary>
    public unsafe struct OrderType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Orig Client Order Id
    /// </summary>
    public struct OrigClientOrderId {
        public long Raw;
    };


    /// <summary>
    ///  Parent Exec Id
    /// </summary>
    public unsafe struct ParentExecId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Parent Symbol Index
    /// </summary>
    public unsafe struct ParentSymbolIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Potential Matching Px
    /// </summary>
    public struct PotentialMatchingPx {
        public long Raw;
    };


    /// <summary>
    ///  Potential Matching Qty
    /// </summary>
    public unsafe struct PotentialMatchingQty {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pre Matching Type
    /// </summary>
    public unsafe struct PreMatchingType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Previous Day Indicator
    /// </summary>
    public unsafe struct PreviousDayIndicator {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Principal Code
    /// </summary>
    public unsafe struct PrincipalCode {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Principal Code Cross
    /// </summary>
    public unsafe struct PrincipalCodeCross {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quantity
    /// </summary>
    public unsafe struct Quantity {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Queueing Indicator
    /// </summary>
    public unsafe struct QueueingIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Req Id
    /// </summary>
    public unsafe struct QuoteReqId {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Recipient Type
    /// </summary>
    public unsafe struct RecipientType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rejected Client Message Sequence Number
    /// </summary>
    public unsafe struct RejectedClientMessageSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rejected Message
    /// </summary>
    public unsafe struct RejectedMessage {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rejected Message Id
    /// </summary>
    public unsafe struct RejectedMessageId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Request Type
    /// </summary>
    public unsafe struct RequestType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Response Type
    /// </summary>
    public unsafe struct ResponseType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Resynchronization Id
    /// </summary>
    public unsafe struct ResynchronizationId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rfe Answer
    /// </summary>
    public unsafe struct RfeAnswer {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rfq Update Type
    /// </summary>
    public unsafe struct RfqUpdateType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public unsafe struct SchemaId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Req Id
    /// </summary>
    public struct SecurityReqId {
        public long Raw;
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public unsafe struct SendingTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Flag
    /// </summary>
    public unsafe struct SettlementFlag {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Period
    /// </summary>
    public unsafe struct SettlementPeriod {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side
    /// </summary>
    public unsafe struct Side {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Software Provider
    /// </summary>
    public unsafe struct SoftwareProvider {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Start Time Vwap
    /// </summary>
    public unsafe struct StartTimeVwap {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stpid
    /// </summary>
    public unsafe struct Stpid {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Code
    /// </summary>
    public unsafe struct StrategyCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Symbol Index
    /// </summary>
    public unsafe struct SymbolIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Target Execution Within Firm Short Code
    /// </summary>
    public struct TargetExecutionWithinFirmShortCode {
        public int Raw;
    };


    /// <summary>
    ///  Technical Origin
    /// </summary>
    public unsafe struct TechnicalOrigin {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : ushort {
        NewOrderMessage = 1,
        AckMessage = 3,
        FillMessage = 4,
        KillMessage = 5,
        CancelReplaceMessage = 6,
        RejectMessage = 7,
        QuotesMessage = 8,
        QuoteAckMessage = 9,
        QuoteRequestMessage = 10,
        CancelRequestMessage = 12,
        MassCancelMessage = 13,
        MassCancelAckMessage = 14,
        OpenOrderRequestMessage = 15,
        OwnershipRequestAckMessage = 17,
        OwnershipRequestMessage = 18,
        TradeBustNotificationMessage = 19,
        CollarBreachConfirmationMessage = 20,
        PriceInputMessage = 28,
        LiquidityProviderCommandMessage = 32,
        AskForQuoteMessage = 33,
        RequestForExecutionMessage = 34,
        RfqNotificationMessage = 35,
        RfqMatchingStatusMessage = 36,
        RfqlpMatchingStatusMessage = 37,
        UserNotificationMessage = 39,
        MmSignInMessage = 47,
        MmSignInAckMessage = 48,
        InstrumentSynchronizationListMessage = 50,
        SynchronizationTimeMessage = 51,
        SecurityDefinitionRequestMessage = 60,
        SecurityDefinitionAckMessage = 61,
        MmProtectionRequestMessage = 62,
        MmProtectionAckMessage = 63,
        NewWholesaleOrderMessage = 64,
        WholesaleOrderAckMessage = 65,
        RequestForImpliedExecutionMessage = 66,
        CrossOrderMessage = 67,
        LogonMessage = 100,
        LogonAckMessage = 101,
        LogonRejectMessage = 102,
        LogoutMessage = 103,
        HeartbeatMessage = 106,
        TestRequestMessage = 107,
        TechnicalRejectMessage = 108,
        DeclarationEntryMessage = 40,
        DeclarationEntryAckMessage = 41,
        DeclarationNoticeMessage = 42,
        DeclarationCancelAndRefusalMessage = 43,
        FundPriceInputMessage = 44,
        FundPriceInputAckMessage = 45,
        DeclarationEntryRejectMessage = 46,
    };


    /// <summary>
    ///  Time In Force
    /// </summary>
    public unsafe struct TimeInForce {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Total Affected Orders
    /// </summary>
    public struct TotalAffectedOrders {
        public int Raw;
    };


    /// <summary>
    ///  Trade Qualifier
    /// </summary>
    public unsafe struct TradeQualifier {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Time
    /// </summary>
    public unsafe struct TradeTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Type
    /// </summary>
    public unsafe struct TradeType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Capacity
    /// </summary>
    public unsafe struct TradingCapacity {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Capacity Cross
    /// </summary>
    public unsafe struct TradingCapacityCross {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transaction Price Type
    /// </summary>
    public unsafe struct TransactionPriceType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  User Status
    /// </summary>
    public unsafe struct UserStatus {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Waiver Indicator
    /// </summary>
    public unsafe struct WaiverIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wholesale Side
    /// </summary>
    public unsafe struct WholesaleSide {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wholesale Trade Type
    /// </summary>
    public unsafe struct WholesaleTradeType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        OrigClientOrderId OrigClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        AckType AckType;
        AckPhase AckPhase;
        OrderId OrderId;
        OrderPriority OrderPriority;
        OrderPx OrderPx;
        OrderQty OrderQty;
        AckQualifiers AckQualifiers;
    };


    /// <summary>
    ///  Struct for Ask For Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AskForQuoteMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        AfqReason AfqReason;
    };


    /// <summary>
    ///  Struct for Cancel Replace Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelReplaceMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        OrderId OrderId;
        OrigClientOrderId OrigClientOrderId;
        OrderPx OrderPx;
        OrderQty OrderQty;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        OrderType OrderType;
        TimeInForce TimeInForce;
        AccountType AccountType;
        LpRole LpRole;
        ExecutionInstruction ExecutionInstruction;
        DarkExecutionInstruction DarkExecutionInstruction;
        MiFidIndicators MiFidIndicators;
        Stpid Stpid;
    };


    /// <summary>
    ///  Struct for Cancel Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CancelRequestMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        OrderId OrderId;
        OrigClientOrderId OrigClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        OrderType OrderType;
        OrderCategory OrderCategory;
    };


    /// <summary>
    ///  Struct for Collar Breach Confirmation Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CollarBreachConfirmationMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderId OrderId;
        OrigClientOrderId OrigClientOrderId;
    };


    /// <summary>
    ///  Struct for Cross Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CrossOrderMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        OrderType OrderType;
        OrderPx OrderPx;
        OrderQty OrderQty;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        MiFidIndicators MiFidIndicators;
        NonExecutingClientId NonExecutingClientId;
        OrderActorType OrderActorType;
        MessagePriceNotation MessagePriceNotation;
    };


    /// <summary>
    ///  Struct for Declaration Cancel And Refusal Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeclarationCancelAndRefusalMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        DeclarationId DeclarationId;
        ActionType ActionType;
    };


    /// <summary>
    ///  Struct for Declaration Entry Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeclarationEntryAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        DeclarationId DeclarationId;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        MiCofSecondaryListing MiCofSecondaryListing;
        OperationType OperationType;
        PreMatchingType PreMatchingType;
        WaiverIndicator WaiverIndicator;
    };


    /// <summary>
    ///  Struct for Declaration Entry Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeclarationEntryMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        OperationType OperationType;
        SymbolIndex SymbolIndex;
        Emm Emm;
        EnteringCounterparty EnteringCounterparty;
        Side Side;
        Quantity Quantity;
        Price Price;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        MiCofSecondaryListing MiCofSecondaryListing;
        CentralisationDate CentralisationDate;
        ClearingFirmId ClearingFirmId;
        AccountType AccountType;
        AccountTypeCross AccountTypeCross;
        TradingCapacity TradingCapacity;
        TradingCapacityCross TradingCapacityCross;
        SettlementPeriod SettlementPeriod;
        SettlementFlag SettlementFlag;
        GuaranteeFlag GuaranteeFlag;
        MiFidIndicators MiFidIndicators;
        TransactionPriceType TransactionPriceType;
        PrincipalCode PrincipalCode;
        PrincipalCodeCross PrincipalCodeCross;
        StartTimeVwap StartTimeVwap;
        EndTimeVwap EndTimeVwap;
        GrossTradeAmount GrossTradeAmount;
        AccountNumber AccountNumber;
        AccountNumberCross AccountNumberCross;
        FreeText FreeText;
        FreeTextCross FreeTextCross;
        InvestmentDecisionWFirmShortCode InvestmentDecisionWFirmShortCode;
        ClientIdentificationShortCodeCross ClientIdentificationShortCodeCross;
    };


    /// <summary>
    ///  Struct for Declaration Entry Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeclarationEntryRejectMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        MiCofSecondaryListing MiCofSecondaryListing;
        OperationType OperationType;
        ErrorCode ErrorCode;
        RejectedMessage RejectedMessage;
        RejectedMessageId RejectedMessageId;
    };


    /// <summary>
    ///  Struct for Declaration Notice Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct DeclarationNoticeMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        ClientOrderId ClientOrderId;
        DeclarationId DeclarationId;
        DeclarationStatus DeclarationStatus;
        OperationType OperationType;
        SymbolIndex SymbolIndex;
        Emm Emm;
        EnteringCounterparty EnteringCounterparty;
        Side Side;
        Quantity Quantity;
        Price Price;
        PreMatchingType PreMatchingType;
        TradeTime TradeTime;
        MiCofSecondaryListing MiCofSecondaryListing;
        CentralisationDate CentralisationDate;
        ClearingFirmId ClearingFirmId;
        AccountType AccountType;
        AccountTypeCross AccountTypeCross;
        TradingCapacity TradingCapacity;
        TradingCapacityCross TradingCapacityCross;
        SettlementFlag SettlementFlag;
        SettlementPeriod SettlementPeriod;
        GuaranteeFlag GuaranteeFlag;
        TransactionPriceType TransactionPriceType;
        PrincipalCode PrincipalCode;
        PrincipalCodeCross PrincipalCodeCross;
        StartTimeVwap StartTimeVwap;
        EndTimeVwap EndTimeVwap;
        GrossTradeAmount GrossTradeAmount;
        AccountNumber AccountNumber;
        AccountNumberCross AccountNumberCross;
        FreeText FreeText;
        FreeTextCross FreeTextCross;
        WaiverIndicator WaiverIndicator;
        PreviousDayIndicator PreviousDayIndicator;
        MiscellaneousFeeAmount MiscellaneousFeeAmount;
        Ccpid Ccpid;
    };


    /// <summary>
    ///  Struct for Fill Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FillMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        TradeTime TradeTime;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        TradeType TradeType;
        TradeQualifier TradeQualifier;
        OrderId OrderId;
        LastTradedPx LastTradedPx;
        LastShares LastShares;
        LeavesQty LeavesQty;
        ExecutionId ExecutionId;
        ExecutionPhase ExecutionPhase;
        LisTransactionId LisTransactionId;
        EscbMembership EscbMembership;
    };


    /// <summary>
    ///  Struct for Fund Price Input Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FundPriceInputAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        Price Price;
        BypassIndicator BypassIndicator;
    };


    /// <summary>
    ///  Struct for Fund Price Input Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FundPriceInputMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        Price Price;
        BypassIndicator BypassIndicator;
    };


    /// <summary>
    ///  Struct for Instrument Synchronization List Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstrumentSynchronizationListMessage {
        MsgSeqNum MsgSeqNum;
        OegoutToMember OegoutToMember;
        ResynchronizationId ResynchronizationId;
    };


    /// <summary>
    ///  Struct for Kill Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct KillMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        OrigClientOrderId OrigClientOrderId;
        OrderId OrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        KillReason KillReason;
        AckQualifiers AckQualifiers;
    };


    /// <summary>
    ///  Struct for Liquidity Provider Command Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LiquidityProviderCommandMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        LpActionCode LpActionCode;
    };


    /// <summary>
    ///  Struct for Logon Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogonAckMessage {
        ExchangeId ExchangeId;
        LastClMsgSeqNum LastClMsgSeqNum;
    };


    /// <summary>
    ///  Struct for Logon Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogonMessage {
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        LastMsgSeqNum LastMsgSeqNum;
        SoftwareProvider SoftwareProvider;
        QueueingIndicator QueueingIndicator;
    };


    /// <summary>
    ///  Struct for Logon Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogonRejectMessage {
        ExchangeId ExchangeId;
        LogonRejectCode LogonRejectCode;
        LastClMsgSeqNum LastClMsgSeqNum;
        LastMsgSeqNum LastMsgSeqNum;
    };


    /// <summary>
    ///  Struct for Logout Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LogoutMessage {
        LogOutReasonCode LogOutReasonCode;
    };


    /// <summary>
    ///  Struct for Mass Cancel Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassCancelAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        TotalAffectedOrders TotalAffectedOrders;
        SymbolIndex SymbolIndex;
        Emm Emm;
        InstrumentGroupCode InstrumentGroupCode;
        OrderSide OrderSide;
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        ContractId ContractId;
        Maturity Maturity;
        AccountType AccountType;
        OptionType OptionType;
        OrderCategory OrderCategory;
        AckQualifiers AckQualifiers;
        TargetExecutionWithinFirmShortCode TargetExecutionWithinFirmShortCode;
    };


    /// <summary>
    ///  Struct for Mass Cancel Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MassCancelMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        InstrumentGroupCode InstrumentGroupCode;
        OrderSide OrderSide;
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        ContractId ContractId;
        Maturity Maturity;
        AccountType AccountType;
        OptionType OptionType;
        OrderCategory OrderCategory;
        TargetExecutionWithinFirmShortCode TargetExecutionWithinFirmShortCode;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        Frame Frame;
        MessageHeader MessageHeader;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Mm Protection Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmProtectionAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        SymbolIndex SymbolIndex;
        Emm Emm;
        MmpExecutionType MmpExecutionType;
    };


    /// <summary>
    ///  Struct for Mm Protection Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmProtectionRequestMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        SymbolIndex SymbolIndex;
        Emm Emm;
        RequestType RequestType;
    };


    /// <summary>
    ///  Struct for Mm Sign In Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmSignInAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClearingFirmId ClearingFirmId;
        AccountNumber AccountNumber;
        TechnicalOrigin TechnicalOrigin;
        OpenClose OpenClose;
        ClearingInstruction ClearingInstruction;
        FreeText FreeText;
        LongClientId LongClientId;
    };


    /// <summary>
    ///  Struct for Mm Sign In Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MmSignInMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClearingFirmId ClearingFirmId;
        AccountNumber AccountNumber;
        TechnicalOrigin TechnicalOrigin;
        OpenClose OpenClose;
        ClearingInstruction ClearingInstruction;
        FreeText FreeText;
        LongClientId LongClientId;
    };


    /// <summary>
    ///  Struct for New Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewOrderMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        OrderType OrderType;
        TimeInForce TimeInForce;
        OrderPx OrderPx;
        OrderQty OrderQty;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        TradingCapacity TradingCapacity;
        AccountType AccountType;
        LpRole LpRole;
        ExecutionInstruction ExecutionInstruction;
        DarkExecutionInstruction DarkExecutionInstruction;
        MiFidIndicators MiFidIndicators;
        Stpid Stpid;
        NonExecutingClientId NonExecutingClientId;
    };


    /// <summary>
    ///  Struct for New Wholesale Order Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct NewWholesaleOrderMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        ContractSymbolIndex ContractSymbolIndex;
        WholesaleTradeType WholesaleTradeType;
        LisTransactionId LisTransactionId;
        StrategyCode StrategyCode;
        Price Price;
        Quantity Quantity;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        MiFidIndicators MiFidIndicators;
        WholesaleSide WholesaleSide;
        EscbMembership EscbMembership;
        MessagePriceNotation MessagePriceNotation;
    };


    /// <summary>
    ///  Struct for Open Order Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpenOrderRequestMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        OrderId OrderId;
        OrigClientOrderId OrigClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderCategory OrderCategory;
    };


    /// <summary>
    ///  Struct for Ownership Request Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OwnershipRequestAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        ClientOrderId ClientOrderId;
        OrderId OrderId;
        SymbolIndex SymbolIndex;
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        TotalAffectedOrders TotalAffectedOrders;
        OrderCategory OrderCategory;
    };


    /// <summary>
    ///  Struct for Ownership Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OwnershipRequestMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        OrderId OrderId;
        OrigClientOrderId OrigClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        LogicalAccessId LogicalAccessId;
        OePartitionId OePartitionId;
        OrderCategory OrderCategory;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
    };


    /// <summary>
    ///  Struct for Price Input Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriceInputMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        InputPriceType InputPriceType;
        Price Price;
    };


    /// <summary>
    ///  Struct for Quote Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        AccountType AccountType;
        LpRole LpRole;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        AckQualifiers AckQualifiers;
    };


    /// <summary>
    ///  Struct for Quote Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteRequestMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        ClientOrderId ClientOrderId;
        OrderQty OrderQty;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        FirmIdPublication FirmIdPublication;
        EndClient EndClient;
        DarkExecutionInstruction DarkExecutionInstruction;
        MinOrderQty MinOrderQty;
    };


    /// <summary>
    ///  Struct for Quotes Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuotesMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        TradingCapacity TradingCapacity;
        AccountType AccountType;
        LpRole LpRole;
        MiFidIndicators MiFidIndicators;
        RfeAnswer RfeAnswer;
        ExecutionInstruction ExecutionInstruction;
    };


    /// <summary>
    ///  Struct for Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RejectMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        OrderId OrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        RejectedMessage RejectedMessage;
        ErrorCode ErrorCode;
        RejectedMessageId RejectedMessageId;
        AckQualifiers AckQualifiers;
    };


    /// <summary>
    ///  Struct for Request For Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestForExecutionMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SymbolIndex SymbolIndex;
        Emm Emm;
    };


    /// <summary>
    ///  Struct for Request For Implied Execution Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RequestForImpliedExecutionMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        ClientOrderId ClientOrderId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderId OrderId;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        MiFidIndicators MiFidIndicators;
    };


    /// <summary>
    ///  Struct for Rfq Matching Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqMatchingStatusMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        QuoteReqId QuoteReqId;
        PotentialMatchingPx PotentialMatchingPx;
        PotentialMatchingQty PotentialMatchingQty;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
        NumberOfLPs NumberOfLPs;
        RecipientType RecipientType;
    };


    /// <summary>
    ///  Struct for Rfq Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqNotificationMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        QuoteReqId QuoteReqId;
        OrderQty OrderQty;
        CounterpartFirmId CounterpartFirmId;
        SymbolIndex SymbolIndex;
        Emm Emm;
        RfqUpdateType RfqUpdateType;
        OrderSide OrderSide;
        EndClient EndClient;
        DarkExecutionInstruction DarkExecutionInstruction;
        MinOrderQty MinOrderQty;
    };


    /// <summary>
    ///  Struct for Rfqlp Matching Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RfqlpMatchingStatusMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        QuoteReqId QuoteReqId;
        PotentialMatchingQty PotentialMatchingQty;
        SymbolIndex SymbolIndex;
        Emm Emm;
        OrderSide OrderSide;
    };


    /// <summary>
    ///  Struct for Security Definition Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        SecurityReqId SecurityReqId;
        SymbolIndex SymbolIndex;
    };


    /// <summary>
    ///  Struct for Security Definition Request Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityDefinitionRequestMessage {
        ClMsgSeqNum ClMsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        SecurityReqId SecurityReqId;
        ContractSymbolIndex ContractSymbolIndex;
        StrategyCode StrategyCode;
    };


    /// <summary>
    ///  Struct for Synchronization Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SynchronizationTimeMessage {
        MsgSeqNum MsgSeqNum;
        OegoutToMember OegoutToMember;
        ResynchronizationId ResynchronizationId;
        LastBookInTime LastBookInTime;
    };


    /// <summary>
    ///  Struct for Technical Reject Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TechnicalRejectMessage {
        OegoutToMember OegoutToMember;
        RejectedClientMessageSequenceNumber RejectedClientMessageSequenceNumber;
        RejectedMessage RejectedMessage;
        ErrorCode ErrorCode;
        RejectedMessageId RejectedMessageId;
    };


    /// <summary>
    ///  Struct for Trade Bust Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeBustNotificationMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        SymbolIndex SymbolIndex;
        Emm Emm;
        ExecutionId ExecutionId;
        LastTradedPx LastTradedPx;
        LastShares LastShares;
        LisTransactionId LisTransactionId;
        ParentExecId ParentExecId;
        ParentSymbolIndex ParentSymbolIndex;
    };


    /// <summary>
    ///  Struct for User Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UserNotificationMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        ClientIdentificationShortcode ClientIdentificationShortcode;
        FamilyId FamilyId;
        SymbolIndex SymbolIndex;
        UserStatus UserStatus;
        LogicalAccessId LogicalAccessId;
        OrderSizeLimit OrderSizeLimit;
    };


    /// <summary>
    ///  Struct for Wholesale Order Ack Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WholesaleOrderAckMessage {
        MsgSeqNum MsgSeqNum;
        FirmId FirmId;
        SendingTime SendingTime;
        OeginFromMember OeginFromMember;
        OegoutTimeToMe OegoutTimeToMe;
        BookIn BookIn;
        BookOutTime BookOutTime;
        OeginFromMe OeginFromMe;
        OegoutToMember OegoutToMember;
        ClientOrderId ClientOrderId;
        ContractSymbolIndex ContractSymbolIndex;
        WholesaleTradeType WholesaleTradeType;
        LisTransactionId LisTransactionId;
        StrategyCode StrategyCode;
        Price Price;
        Quantity Quantity;
        ExecutionWithinFirmShortCode ExecutionWithinFirmShortCode;
        MiFidIndicators MiFidIndicators;
        WholesaleSide WholesaleSide;
        EscbMembership EscbMembership;
        ResponseType ResponseType;
        ErrorCode ErrorCode;
        AckQualifiers AckQualifiers;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
