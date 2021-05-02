namespace Euronext.Optiq.MarketDataGateway.Sbe.v4.3.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Amount Decimals
    /// </summary>
    public unsafe struct AmountDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Offer Date Time
    /// </summary>
    public unsafe struct BidOfferDateTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public struct BidPrice {
        public long Raw;
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
    ///  Block Trade Code
    /// </summary>
    public unsafe struct BlockTradeCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cfi
    /// </summary>
    public unsafe struct Cfi {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Channel Id
    /// </summary>
    public unsafe struct ChannelId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Closing Price
    /// </summary>
    public struct ClosingPrice {
        public long Raw;
    };


    /// <summary>
    ///  Closing Reference Level
    /// </summary>
    public struct ClosingReferenceLevel {
        public long Raw;
    };


    /// <summary>
    ///  Closing Reference Time
    /// </summary>
    public unsafe struct ClosingReferenceTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Collar Expansion Factor
    /// </summary>
    public unsafe struct CollarExpansionFactor {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Compression
    /// </summary>
    public unsafe struct Compression {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Confirmed Reference Level
    /// </summary>
    public struct ConfirmedReferenceLevel {
        public long Raw;
    };


    /// <summary>
    ///  Confirmed Reference Time
    /// </summary>
    public unsafe struct ConfirmedReferenceTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Event Date
    /// </summary>
    public unsafe struct ContractEventDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Name
    /// </summary>
    public unsafe struct ContractName {
        public const int Size = 60;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Contract Trading Type
    /// </summary>
    public unsafe struct ContractTradingType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Type
    /// </summary>
    public unsafe struct ContractType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Country Of Exchange
    /// </summary>
    public unsafe struct CountryOfExchange {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Coupon
    /// </summary>
    public struct Coupon {
        public long Raw;
    };


    /// <summary>
    ///  Currency
    /// </summary>
    public unsafe struct Currency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Currency Coefficient
    /// </summary>
    public unsafe struct CurrencyCoefficient {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dark Eligibility
    /// </summary>
    public unsafe struct DarkEligibility {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dark Lis Threshold
    /// </summary>
    public unsafe struct DarkLisThreshold {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dark Min Quantity
    /// </summary>
    public unsafe struct DarkMinQuantity {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Date Of Initial Listing
    /// </summary>
    public unsafe struct DateOfInitialListing {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Date Of Last Trade
    /// </summary>
    public unsafe struct DateOfLastTrade {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Days To Expiry
    /// </summary>
    public unsafe struct DaysToExpiry {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Depositary List
    /// </summary>
    public unsafe struct DepositaryList {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Derivatives Instrument Trading Code
    /// </summary>
    public unsafe struct DerivativesInstrumentTradingCode {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Derivatives Instrument Type
    /// </summary>
    public unsafe struct DerivativesInstrumentType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Derivatives Market Model
    /// </summary>
    public unsafe struct DerivativesMarketModel {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dividend Currency
    /// </summary>
    public unsafe struct DividendCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dividend Payment Date
    /// </summary>
    public unsafe struct DividendPaymentDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dividend Rate
    /// </summary>
    public unsafe struct DividendRate {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Dividend Record Date
    /// </summary>
    public unsafe struct DividendRecordDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Edsp Tick Size
    /// </summary>
    public unsafe struct EdspTickSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Effective Date Indicator
    /// </summary>
    public unsafe struct EffectiveDateIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Agency Cross Trade Indicator
    /// </summary>
    public unsafe struct EfficientMmtAgencyCrossTradeIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Algorithmic Indicator
    /// </summary>
    public unsafe struct EfficientMmtAlgorithmicIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Benchmark Indicator
    /// </summary>
    public unsafe struct EfficientMmtBenchmarkIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Contributionto Price
    /// </summary>
    public unsafe struct EfficientMmtContributiontoPrice {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Duplicative Indicator
    /// </summary>
    public unsafe struct EfficientMmtDuplicativeIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Market Mechanism
    /// </summary>
    public unsafe struct EfficientMmtMarketMechanism {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Modification Indicator
    /// </summary>
    public unsafe struct EfficientMmtModificationIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Negotiation Indicator
    /// </summary>
    public unsafe struct EfficientMmtNegotiationIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Off Book Automated Indicator
    /// </summary>
    public unsafe struct EfficientMmtOffBookAutomatedIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Post Trade Deferral
    /// </summary>
    public unsafe struct EfficientMmtPostTradeDeferral {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Publication Mode
    /// </summary>
    public unsafe struct EfficientMmtPublicationMode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Special Dividend Indicator
    /// </summary>
    public unsafe struct EfficientMmtSpecialDividendIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Trading Mode
    /// </summary>
    public unsafe struct EfficientMmtTradingMode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Efficient Mmt Transaction Category
    /// </summary>
    public unsafe struct EfficientMmtTransactionCategory {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
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
    ///  End Time Vwap
    /// </summary>
    public unsafe struct EndTimeVwap {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Evaluated Price
    /// </summary>
    public struct EvaluatedPrice {
        public long Raw;
    };


    /// <summary>
    ///  Event Time
    /// </summary>
    public unsafe struct EventTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ex Dividend Date
    /// </summary>
    public unsafe struct ExDividendDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exchange Code
    /// </summary>
    public unsafe struct ExchangeCode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Exer Style
    /// </summary>
    public unsafe struct ExerStyle {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiry Cycle Type
    /// </summary>
    public unsafe struct ExpiryCycleType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiry Date
    /// </summary>
    public unsafe struct ExpiryDate {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  First Settlement Date
    /// </summary>
    public unsafe struct FirstSettlementDate {
        public const int Size = 2;

        public short Value;

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
    ///  Full Instrument Name
    /// </summary>
    public unsafe struct FullInstrumentName {
        public const int Size = 102;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Gross Dividend In Euros
    /// </summary>
    public struct GrossDividendInEuros {
        public long Raw;
    };


    /// <summary>
    ///  Gross Dividend Payable Per Unit
    /// </summary>
    public struct GrossDividendPayablePerUnit {
        public long Raw;
    };


    /// <summary>
    ///  Gross Of Cdsc Indicator
    /// </summary>
    public unsafe struct GrossOfCdscIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Guarantee Indicator
    /// </summary>
    public unsafe struct GuaranteeIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Has End Of Day Snapshot
    /// </summary>
    public unsafe struct HasEndOfDaySnapshot {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Has Start Of Day Snapshot
    /// </summary>
    public unsafe struct HasStartOfDaySnapshot {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Has Status Message
    /// </summary>
    public unsafe struct HasStatusMessage {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  High Level
    /// </summary>
    public struct HighLevel {
        public long Raw;
    };


    /// <summary>
    ///  High Time
    /// </summary>
    public unsafe struct HighTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Icb
    /// </summary>
    public unsafe struct Icb {
        public const int Size = 16;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Icb Code
    /// </summary>
    public unsafe struct IcbCode {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Index Level
    /// </summary>
    public struct IndexLevel {
        public long Raw;
    };


    /// <summary>
    ///  Index Level Type
    /// </summary>
    public unsafe struct IndexLevelType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Index Price Code
    /// </summary>
    public unsafe struct IndexPriceCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inst Unit Exp
    /// </summary>
    public unsafe struct InstUnitExp {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Instrument Category
    /// </summary>
    public unsafe struct InstrumentCategory {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Instrument Event Date
    /// </summary>
    public unsafe struct InstrumentEventDate {
        public const int Size = 2;

        public short Value;

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
    ///  Instrument Name
    /// </summary>
    public unsafe struct InstrumentName {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Instrument Trading Code
    /// </summary>
    public unsafe struct InstrumentTradingCode {
        public const int Size = 15;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Isin Code
    /// </summary>
    public unsafe struct IsinCode {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Date
    /// </summary>
    public unsafe struct IssueDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issue Price
    /// </summary>
    public struct IssuePrice {
        public long Raw;
    };


    /// <summary>
    ///  Issue Price Decimals
    /// </summary>
    public unsafe struct IssuePriceDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Issuing Country
    /// </summary>
    public unsafe struct IssuingCountry {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Adjusted Closing Price
    /// </summary>
    public struct LastAdjustedClosingPrice {
        public long Raw;
    };


    /// <summary>
    ///  Last Md Seq Num
    /// </summary>
    public unsafe struct LastMdSeqNum {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Nav Price
    /// </summary>
    public struct LastNavPrice {
        public long Raw;
    };


    /// <summary>
    ///  Last Trading Date
    /// </summary>
    public unsafe struct LastTradingDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Lei Code
    /// </summary>
    public unsafe struct LeiCode {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Liquid Instrument Indicator
    /// </summary>
    public unsafe struct LiquidInstrumentIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Liquidation Level
    /// </summary>
    public struct LiquidationLevel {
        public long Raw;
    };


    /// <summary>
    ///  Liquidation Time
    /// </summary>
    public unsafe struct LiquidationTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Long Instrument Name
    /// </summary>
    public unsafe struct LongInstrumentName {
        public const int Size = 250;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Long Issuer Name
    /// </summary>
    public unsafe struct LongIssuerName {
        public const int Size = 250;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Long Trade Reference
    /// </summary>
    public unsafe struct LongTradeReference {
        public const int Size = 52;

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
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Low Level
    /// </summary>
    public struct LowLevel {
        public long Raw;
    };


    /// <summary>
    ///  Low Time
    /// </summary>
    public unsafe struct LowTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Main Depositary
    /// </summary>
    public unsafe struct MainDepositary {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Of Reference Mic
    /// </summary>
    public unsafe struct MarketOfReferenceMic {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity Date
    /// </summary>
    public unsafe struct MaturityDate {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maximum Decimals In Quantity
    /// </summary>
    public unsafe struct MaximumDecimalsInQuantity {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Seq Num
    /// </summary>
    public unsafe struct MdSeqNum {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mdg Restart Count
    /// </summary>
    public unsafe struct MdgRestartCount {
        public const int Size = 3;

        public fixed byte Bytes[Size];
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
    ///  Mi Fid Clearing Flag
    /// </summary>
    public unsafe struct MiFidClearingFlag {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mi Fid Emission Allowance Type
    /// </summary>
    public unsafe struct MiFidEmissionAllowanceType {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mi Fid Notional Amount
    /// </summary>
    public unsafe struct MiFidNotionalAmount {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mi Fid Qtyin Msrmt Unit Notation
    /// </summary>
    public unsafe struct MiFidQtyinMsrmtUnitNotation {
        public const int Size = 25;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mi Fid Transaction Id
    /// </summary>
    public unsafe struct MiFidTransactionId {
        public const int Size = 52;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mic
    /// </summary>
    public unsafe struct Mic {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mic List
    /// </summary>
    public unsafe struct MicList {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Currency
    /// </summary>
    public unsafe struct MifidCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Execution Id
    /// </summary>
    public unsafe struct MifidExecutionId {
        public const int Size = 52;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Instrument Id
    /// </summary>
    public unsafe struct MifidInstrumentId {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Instrument Id Type
    /// </summary>
    public unsafe struct MifidInstrumentIdType {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Price
    /// </summary>
    public unsafe struct MifidPrice {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Price Notation
    /// </summary>
    public unsafe struct MifidPriceNotation {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Quantity
    /// </summary>
    public unsafe struct MifidQuantity {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifid Quantity Measurement Unit
    /// </summary>
    public unsafe struct MifidQuantityMeasurementUnit {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mifidii Liquid Flag
    /// </summary>
    public unsafe struct MifidiiLiquidFlag {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Minimum Amount
    /// </summary>
    public struct MinimumAmount {
        public long Raw;
    };


    /// <summary>
    ///  Mm Protections
    /// </summary>
    public unsafe struct MmProtections {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Agency Cross Trade Indicator
    /// </summary>
    public unsafe struct MmtAgencyCrossTradeIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Algorithmic Indicator
    /// </summary>
    public unsafe struct MmtAlgorithmicIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Benchmark Indicator
    /// </summary>
    public unsafe struct MmtBenchmarkIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Contributionto Price
    /// </summary>
    public unsafe struct MmtContributiontoPrice {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Duplicative Indicator
    /// </summary>
    public unsafe struct MmtDuplicativeIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Market Mechanism
    /// </summary>
    public unsafe struct MmtMarketMechanism {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Modification Indicator
    /// </summary>
    public unsafe struct MmtModificationIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Negotiation Indicator
    /// </summary>
    public unsafe struct MmtNegotiationIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Off Book Automated Indicator
    /// </summary>
    public unsafe struct MmtOffBookAutomatedIndicator {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Post Trade Deferral
    /// </summary>
    public unsafe struct MmtPostTradeDeferral {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Publication Mode
    /// </summary>
    public unsafe struct MmtPublicationMode {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Special Dividend Indicator
    /// </summary>
    public unsafe struct MmtSpecialDividendIndicator {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Trading Mode
    /// </summary>
    public unsafe struct MmtTradingMode {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mmt Transaction Category
    /// </summary>
    public unsafe struct MmtTransactionCategory {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mnemonic
    /// </summary>
    public unsafe struct Mnemonic {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Mother Stock Isin
    /// </summary>
    public unsafe struct MotherStockIsin {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Nav Bid Price
    /// </summary>
    public struct NavBidPrice {
        public long Raw;
    };


    /// <summary>
    ///  Nav Offer Price
    /// </summary>
    public struct NavOfferPrice {
        public long Raw;
    };


    /// <summary>
    ///  Nav Price
    /// </summary>
    public struct NavPrice {
        public long Raw;
    };


    /// <summary>
    ///  Next Meeting
    /// </summary>
    public unsafe struct NextMeeting {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Nominal Currency
    /// </summary>
    public unsafe struct NominalCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Notional Amount Traded
    /// </summary>
    public struct NotionalAmountTraded {
        public long Raw;
    };


    /// <summary>
    ///  Notional Currency
    /// </summary>
    public unsafe struct NotionalCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Num Traded Instruments
    /// </summary>
    public unsafe struct NumTradedInstruments {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Instrument Circulating
    /// </summary>
    public unsafe struct NumberInstrumentCirculating {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Price
    /// </summary>
    public struct OfferPrice {
        public long Raw;
    };


    /// <summary>
    ///  Opened Closed Fund
    /// </summary>
    public unsafe struct OpenedClosedFund {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opening Level
    /// </summary>
    public struct OpeningLevel {
        public long Raw;
    };


    /// <summary>
    ///  Opening Time
    /// </summary>
    public unsafe struct OpeningTime {
        public const int Size = 8;

        public long Value;

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
    ///  Optiq Segment
    /// </summary>
    public unsafe struct OptiqSegment {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Order Type Rules
    /// </summary>
    public unsafe struct OrderTypeRules {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Original Report Timestamp
    /// </summary>
    public unsafe struct OriginalReportTimestamp {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Sequence Number
    /// </summary>
    public unsafe struct PacketSequenceNumber {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Time
    /// </summary>
    public unsafe struct PacketTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Par Value
    /// </summary>
    public unsafe struct ParValue {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Partition Id
    /// </summary>
    public unsafe struct PartitionId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pattern Id
    /// </summary>
    public unsafe struct PatternId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Payment Frequency
    /// </summary>
    public unsafe struct PaymentFrequency {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pctg Of Capitalization
    /// </summary>
    public unsafe struct PctgOfCapitalization {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Prct Varfrom Prev Close
    /// </summary>
    public struct PrctVarfromPrevClose {
        public long Raw;
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public long Raw;
    };


    /// <summary>
    ///  Price Decimals
    /// </summary>
    public unsafe struct PriceDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Index Level Decimals
    /// </summary>
    public unsafe struct PriceIndexLevelDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Multiplier
    /// </summary>
    public unsafe struct PriceMultiplier {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price Multiplier Decimals
    /// </summary>
    public unsafe struct PriceMultiplierDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Pricing Algorithm
    /// </summary>
    public unsafe struct PricingAlgorithm {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Code
    /// </summary>
    public unsafe struct ProductCode {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Psn High Weight
    /// </summary>
    public unsafe struct PsnHighWeight {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Publication Date Time
    /// </summary>
    public unsafe struct PublicationDateTime {
        public const int Size = 27;

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
    ///  Quantity Decimals
    /// </summary>
    public unsafe struct QuantityDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quantity Notation
    /// </summary>
    public unsafe struct QuantityNotation {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Update Type
    /// </summary>
    public unsafe struct QuoteUpdateType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Decimals
    /// </summary>
    public unsafe struct RatioDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ratio Multiplier Decimals
    /// </summary>
    public unsafe struct RatioMultiplierDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Rebroadcast Indicator
    /// </summary>
    public unsafe struct RebroadcastIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Price Origin In Continuous
    /// </summary>
    public unsafe struct ReferencePriceOriginInContinuous {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Price Origin In Opening Call
    /// </summary>
    public unsafe struct ReferencePriceOriginInOpeningCall {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Price Origin In Trading Interruption
    /// </summary>
    public unsafe struct ReferencePriceOriginInTradingInterruption {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Spread Table Id
    /// </summary>
    public unsafe struct ReferenceSpreadTableId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Repo Indicator
    /// </summary>
    public unsafe struct RepoIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Repo Settlement Date
    /// </summary>
    public unsafe struct RepoSettlementDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved Bits
    /// </summary>
    public unsafe struct ReservedBits {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Retransmission End Time
    /// </summary>
    public unsafe struct RetransmissionEndTime {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Retransmission Start Time
    /// </summary>
    public unsafe struct RetransmissionStartTime {
        public const int Size = 8;

        public long Value;

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
    ///  Second Notional Currency
    /// </summary>
    public unsafe struct SecondNotionalCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Condition
    /// </summary>
    public unsafe struct SecurityCondition {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sedol Code
    /// </summary>
    public unsafe struct SedolCode {
        public const int Size = 7;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Trading Day
    /// </summary>
    public unsafe struct SessionTradingDay {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Date
    /// </summary>
    public unsafe struct SettlementDate {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Delay
    /// </summary>
    public unsafe struct SettlementDelay {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Method
    /// </summary>
    public unsafe struct SettlementMethod {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Settlement Tick Size
    /// </summary>
    public unsafe struct SettlementTickSize {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Share Amount In Issue
    /// </summary>
    public struct ShareAmountInIssue {
        public long Raw;
    };


    /// <summary>
    ///  Snapshot Time
    /// </summary>
    public unsafe struct SnapshotTime {
        public const int Size = 8;

        public long Value;

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
    ///  Strike Currency
    /// </summary>
    public unsafe struct StrikeCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Currency Indicator
    /// </summary>
    public unsafe struct StrikeCurrencyIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public long Raw;
    };


    /// <summary>
    ///  Strike Price Decimals
    /// </summary>
    public unsafe struct StrikePriceDecimals {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price Decimals Ratio
    /// </summary>
    public unsafe struct StrikePriceDecimalsRatio {
        public const int Size = 1;

        public sbyte Value;

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
    ///  Tax Code
    /// </summary>
    public unsafe struct TaxCode {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tax Description Attaching To A Dividend
    /// </summary>
    public unsafe struct TaxDescriptionAttachingToADividend {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Technical Notification Type
    /// </summary>
    public unsafe struct TechnicalNotificationType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : ushort {
        StartOfDayMessage = 1101,
        EndOfDayMessage = 1102,
        HealthStatusMessage = 1103,
        TechnicalNotificationMessage = 1106,
        MarketUpdateMessage = 1001,
        OrderUpdateMessage = 1002,
        PriceUpdateMessage = 1003,
        FullTradeInformationMessage = 1004,
        MarketStatusChangeMessage = 1005,
        TimetableMessage = 1006,
        StandingDataMessage = 1007,
        RealTimeIndexMessage = 1008,
        StatisticsMessage = 1009,
        IndexSummaryMessage = 1011,
        StrategyStandingDataMessage = 1012,
        ContractStandingDataMessage = 1013,
        OutrightStandingDataMessage = 1014,
        LongOrderUpdateMessage = 1015,
        LisPackageStructureMessage = 1016,
        ApaQuotesMessage = 1026,
        ApaStandingDataMessage = 1027,
        ApaFullTradeInformationMessage = 1028,
        BfInstrumentReferenceMessage = 1201,
        BfTradeMessage = 1202,
        BfnaVMessage = 1203,
        BfInstrumentSuspensionMessage = 1204,
        StartOfSnapshotMessage = 2101,
        EndOfSnapshotMessage = 2102,
    };


    /// <summary>
    ///  Threshold Lis Post Trade 120mn
    /// </summary>
    public unsafe struct ThresholdLisPostTrade120Mn {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Threshold Lis Post Trade 60mn
    /// </summary>
    public unsafe struct ThresholdLisPostTrade60Mn {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Threshold Lis Post Trade Eod
    /// </summary>
    public unsafe struct ThresholdLisPostTradeEod {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
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
    ///  Trade Reference
    /// </summary>
    public unsafe struct TradeReference {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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
    ///  Trading Currency
    /// </summary>
    public unsafe struct TradingCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Currency Indicator
    /// </summary>
    public unsafe struct TradingCurrencyIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Date Time
    /// </summary>
    public unsafe struct TradingDateTime {
        public const int Size = 27;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Policy
    /// </summary>
    public unsafe struct TradingPolicy {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Unit
    /// </summary>
    public unsafe struct TradingUnit {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transaction Type
    /// </summary>
    public unsafe struct TransactionType {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Transparency Indicator
    /// </summary>
    public unsafe struct TransparencyIndicator {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Type Of Corporate Event
    /// </summary>
    public unsafe struct TypeOfCorporateEvent {
        public const int Size = 2;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Type Of Market Admission
    /// </summary>
    public unsafe struct TypeOfMarketAdmission {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Derivatives Instrument Trading Code
    /// </summary>
    public unsafe struct UnderlyingDerivativesInstrumentTradingCode {
        public const int Size = 18;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Expiry
    /// </summary>
    public unsafe struct UnderlyingExpiry {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Index Name
    /// </summary>
    public unsafe struct UnderlyingIndexName {
        public const int Size = 25;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Index Term
    /// </summary>
    public unsafe struct UnderlyingIndexTerm {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Isin Code
    /// </summary>
    public unsafe struct UnderlyingIsinCode {
        public const int Size = 12;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Mic
    /// </summary>
    public unsafe struct UnderlyingMic {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Subtype
    /// </summary>
    public unsafe struct UnderlyingSubtype {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Symbol Index
    /// </summary>
    public unsafe struct UnderlyingSymbolIndex {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Underlying Type
    /// </summary>
    public unsafe struct UnderlyingType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Venue
    /// </summary>
    public unsafe struct Venue {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

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


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Apa Full Trade Information Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApaFullTradeInformationMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
        TradingDateTime TradingDateTime;
        PublicationDateTime PublicationDateTime;
        TradeType TradeType;
        MifidInstrumentIdType MifidInstrumentIdType;
        MifidInstrumentId MifidInstrumentId;
        MiFidTransactionId MiFidTransactionId;
        MifidPrice MifidPrice;
        MifidQuantity MifidQuantity;
        MifidPriceNotation MifidPriceNotation;
        MifidCurrency MifidCurrency;
        MiFidQtyinMsrmtUnitNotation MiFidQtyinMsrmtUnitNotation;
        MifidQuantityMeasurementUnit MifidQuantityMeasurementUnit;
        MiFidNotionalAmount MiFidNotionalAmount;
        NotionalCurrency NotionalCurrency;
        MiFidClearingFlag MiFidClearingFlag;
        EfficientMmtMarketMechanism EfficientMmtMarketMechanism;
        EfficientMmtTradingMode EfficientMmtTradingMode;
        EfficientMmtTransactionCategory EfficientMmtTransactionCategory;
        EfficientMmtNegotiationIndicator EfficientMmtNegotiationIndicator;
        EfficientMmtAgencyCrossTradeIndicator EfficientMmtAgencyCrossTradeIndicator;
        EfficientMmtModificationIndicator EfficientMmtModificationIndicator;
        EfficientMmtBenchmarkIndicator EfficientMmtBenchmarkIndicator;
        EfficientMmtSpecialDividendIndicator EfficientMmtSpecialDividendIndicator;
        EfficientMmtOffBookAutomatedIndicator EfficientMmtOffBookAutomatedIndicator;
        EfficientMmtContributiontoPrice EfficientMmtContributiontoPrice;
        EfficientMmtAlgorithmicIndicator EfficientMmtAlgorithmicIndicator;
        EfficientMmtPublicationMode EfficientMmtPublicationMode;
        EfficientMmtPostTradeDeferral EfficientMmtPostTradeDeferral;
        EfficientMmtDuplicativeIndicator EfficientMmtDuplicativeIndicator;
        TradeReference TradeReference;
        OriginalReportTimestamp OriginalReportTimestamp;
        PriceMultiplier PriceMultiplier;
        PriceMultiplierDecimals PriceMultiplierDecimals;
        Venue Venue;
        MiFidEmissionAllowanceType MiFidEmissionAllowanceType;
        LongTradeReference LongTradeReference;
    };


    /// <summary>
    ///  Struct for Apa Quotes Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApaQuotesMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        MifidInstrumentIdType MifidInstrumentIdType;
        MifidInstrumentId MifidInstrumentId;
        Mic Mic;
        Currency Currency;
        LeiCode LeiCode;
        EventTime EventTime;
        QuoteUpdateType QuoteUpdateType;
        MifidPrice MifidPrice;
        MifidQuantity MifidQuantity;
    };


    /// <summary>
    ///  Struct for Apa Standing Data Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApaStandingDataMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        MifidInstrumentIdType MifidInstrumentIdType;
        MifidInstrumentId MifidInstrumentId;
        FullInstrumentName FullInstrumentName;
        Cfi Cfi;
        NotionalCurrency NotionalCurrency;
        SecondNotionalCurrency SecondNotionalCurrency;
        PriceMultiplier PriceMultiplier;
        PriceMultiplierDecimals PriceMultiplierDecimals;
        UnderlyingIsinCode UnderlyingIsinCode;
        UnderlyingIndexName UnderlyingIndexName;
        UnderlyingIndexTerm UnderlyingIndexTerm;
        OptionType OptionType;
        StrikePrice StrikePrice;
        StrikePriceDecimals StrikePriceDecimals;
        ExerStyle ExerStyle;
        MaturityDate MaturityDate;
        ExpiryDate ExpiryDate;
        SettlementMethod SettlementMethod;
    };


    /// <summary>
    ///  Struct for Bf Instrument Reference Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BfInstrumentReferenceMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        OptiqSegment OptiqSegment;
        IsinCode IsinCode;
        SedolCode SedolCode;
        LongIssuerName LongIssuerName;
        LongInstrumentName LongInstrumentName;
        Currency Currency;
        DateOfInitialListing DateOfInitialListing;
        ShareAmountInIssue ShareAmountInIssue;
        OpenedClosedFund OpenedClosedFund;
        LastNavPrice LastNavPrice;
        GrossOfCdscIndicator GrossOfCdscIndicator;
        Coupon Coupon;
        MaturityDate MaturityDate;
        ClosingPrice ClosingPrice;
        Mic Mic;
        GrossDividendPayablePerUnit GrossDividendPayablePerUnit;
        DividendCurrency DividendCurrency;
        DividendRecordDate DividendRecordDate;
        DividendRate DividendRate;
        ExDividendDate ExDividendDate;
        DividendPaymentDate DividendPaymentDate;
        TaxDescriptionAttachingToADividend TaxDescriptionAttachingToADividend;
        NextMeeting NextMeeting;
        GrossDividendInEuros GrossDividendInEuros;
        IssueDate IssueDate;
        IssuingCountry IssuingCountry;
        Cfi Cfi;
        PaymentFrequency PaymentFrequency;
        MinimumAmount MinimumAmount;
        InstrumentCategory InstrumentCategory;
        SecurityCondition SecurityCondition;
        MifidPriceNotation MifidPriceNotation;
        PriceIndexLevelDecimals PriceIndexLevelDecimals;
        QuantityDecimals QuantityDecimals;
        AmountDecimals AmountDecimals;
        RatioMultiplierDecimals RatioMultiplierDecimals;
    };


    /// <summary>
    ///  Struct for Bf Instrument Suspension Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BfInstrumentSuspensionMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        EventTime EventTime;
        SecurityCondition SecurityCondition;
    };


    /// <summary>
    ///  Struct for Bf Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BfTradeMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        MiFidTransactionId MiFidTransactionId;
        EventTime EventTime;
        BidOfferDateTime BidOfferDateTime;
        MmtModificationIndicator MmtModificationIndicator;
        Price Price;
        BidPrice BidPrice;
        OfferPrice OfferPrice;
        Quantity Quantity;
        MmtAgencyCrossTradeIndicator MmtAgencyCrossTradeIndicator;
        MmtBenchmarkIndicator MmtBenchmarkIndicator;
        MmtSpecialDividendIndicator MmtSpecialDividendIndicator;
        MmtTradingMode MmtTradingMode;
        MifidPriceNotation MifidPriceNotation;
        QuantityNotation QuantityNotation;
        NotionalAmountTraded NotionalAmountTraded;
        TradingCurrency TradingCurrency;
    };


    /// <summary>
    ///  Struct for Bfna V Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct BfnaVMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        BidOfferDateTime BidOfferDateTime;
        MiFidTransactionId MiFidTransactionId;
        MmtModificationIndicator MmtModificationIndicator;
        NavPrice NavPrice;
        EventTime EventTime;
        NavBidPrice NavBidPrice;
        NavOfferPrice NavOfferPrice;
    };


    /// <summary>
    ///  Struct for Contract Standing Data Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ContractStandingDataMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        OptiqSegment OptiqSegment;
        PartitionId PartitionId;
        ContractEventDate ContractEventDate;
        ExchangeCode ExchangeCode;
        ExerStyle ExerStyle;
        ContractName ContractName;
        ContractType ContractType;
        UnderlyingType UnderlyingType;
        PriceDecimals PriceDecimals;
        QuantityDecimals QuantityDecimals;
        AmountDecimals AmountDecimals;
        RatioDecimals RatioDecimals;
        MainDepositary MainDepositary;
        Mic Mic;
        CountryOfExchange CountryOfExchange;
        ProductCode ProductCode;
        UnderlyingMic UnderlyingMic;
        UnderlyingIsinCode UnderlyingIsinCode;
        UnderlyingExpiry UnderlyingExpiry;
        OrderTypeRules OrderTypeRules;
        SettlementMethod SettlementMethod;
        TradingCurrency TradingCurrency;
        StrikePriceDecimalsRatio StrikePriceDecimalsRatio;
        MmProtections MmProtections;
        ContractTradingType ContractTradingType;
        InstUnitExp InstUnitExp;
        UnderlyingSubtype UnderlyingSubtype;
        MotherStockIsin MotherStockIsin;
        SettlementTickSize SettlementTickSize;
        EdspTickSize EdspTickSize;
        UnderlyingSymbolIndex UnderlyingSymbolIndex;
        TradingPolicy TradingPolicy;
        ReferenceSpreadTableId ReferenceSpreadTableId;
        DerivativesMarketModel DerivativesMarketModel;
        TradingUnit TradingUnit;
        ReferencePriceOriginInOpeningCall ReferencePriceOriginInOpeningCall;
        ReferencePriceOriginInContinuous ReferencePriceOriginInContinuous;
        ReferencePriceOriginInTradingInterruption ReferencePriceOriginInTradingInterruption;
        CollarExpansionFactor CollarExpansionFactor;
        MifidiiLiquidFlag MifidiiLiquidFlag;
        PricingAlgorithm PricingAlgorithm;
    };


    /// <summary>
    ///  Struct for End Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfDayMessage {
        MdSeqNum MdSeqNum;
        SessionTradingDay SessionTradingDay;
    };


    /// <summary>
    ///  Struct for End Of Snapshot Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfSnapshotMessage {
        LastMdSeqNum LastMdSeqNum;
        SnapshotTime SnapshotTime;
    };


    /// <summary>
    ///  Struct for Full Trade Information Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FullTradeInformationMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
        SymbolIndex SymbolIndex;
        TradingDateTime TradingDateTime;
        PublicationDateTime PublicationDateTime;
        TradeType TradeType;
        MifidInstrumentIdType MifidInstrumentIdType;
        MifidInstrumentId MifidInstrumentId;
        MifidExecutionId MifidExecutionId;
        MifidPrice MifidPrice;
        MifidQuantity MifidQuantity;
        MifidPriceNotation MifidPriceNotation;
        MifidCurrency MifidCurrency;
        MiFidQtyinMsrmtUnitNotation MiFidQtyinMsrmtUnitNotation;
        MifidQuantityMeasurementUnit MifidQuantityMeasurementUnit;
        MiFidNotionalAmount MiFidNotionalAmount;
        NotionalCurrency NotionalCurrency;
        MiFidClearingFlag MiFidClearingFlag;
        MmtMarketMechanism MmtMarketMechanism;
        MmtTradingMode MmtTradingMode;
        MmtTransactionCategory MmtTransactionCategory;
        MmtNegotiationIndicator MmtNegotiationIndicator;
        MmtAgencyCrossTradeIndicator MmtAgencyCrossTradeIndicator;
        MmtModificationIndicator MmtModificationIndicator;
        MmtBenchmarkIndicator MmtBenchmarkIndicator;
        MmtSpecialDividendIndicator MmtSpecialDividendIndicator;
        MmtOffBookAutomatedIndicator MmtOffBookAutomatedIndicator;
        MmtContributiontoPrice MmtContributiontoPrice;
        MmtAlgorithmicIndicator MmtAlgorithmicIndicator;
        MmtPublicationMode MmtPublicationMode;
        MmtPostTradeDeferral MmtPostTradeDeferral;
        MmtDuplicativeIndicator MmtDuplicativeIndicator;
        TradeQualifier TradeQualifier;
        TransactionType TransactionType;
        EffectiveDateIndicator EffectiveDateIndicator;
        BlockTradeCode BlockTradeCode;
        TradeReference TradeReference;
        OriginalReportTimestamp OriginalReportTimestamp;
        TransparencyIndicator TransparencyIndicator;
        CurrencyCoefficient CurrencyCoefficient;
        PriceMultiplier PriceMultiplier;
        PriceMultiplierDecimals PriceMultiplierDecimals;
        Venue Venue;
        StartTimeVwap StartTimeVwap;
        EndTimeVwap EndTimeVwap;
        MiFidEmissionAllowanceType MiFidEmissionAllowanceType;
        MarketOfReferenceMic MarketOfReferenceMic;
        EvaluatedPrice EvaluatedPrice;
        MessagePriceNotation MessagePriceNotation;
        SettlementDate SettlementDate;
        RepoSettlementDate RepoSettlementDate;
    };


    /// <summary>
    ///  Struct for Health Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct HealthStatusMessage {
        MdSeqNum MdSeqNum;
        EventTime EventTime;
    };


    /// <summary>
    ///  Struct for Index Summary Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IndexSummaryMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
        SymbolIndex SymbolIndex;
        OpeningLevel OpeningLevel;
        OpeningTime OpeningTime;
        ConfirmedReferenceLevel ConfirmedReferenceLevel;
        ConfirmedReferenceTime ConfirmedReferenceTime;
        ClosingReferenceLevel ClosingReferenceLevel;
        ClosingReferenceTime ClosingReferenceTime;
        PrctVarfromPrevClose PrctVarfromPrevClose;
        HighLevel HighLevel;
        HighTime HighTime;
        LowLevel LowLevel;
        LowTime LowTime;
        LiquidationLevel LiquidationLevel;
        LiquidationTime LiquidationTime;
    };


    /// <summary>
    ///  Struct for Lis Package Structure Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LisPackageStructureMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
        ContractSymbolIndex ContractSymbolIndex;
        MifidExecutionId MifidExecutionId;
        StrategyCode StrategyCode;
    };


    /// <summary>
    ///  Struct for Long Order Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LongOrderUpdateMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
    };


    /// <summary>
    ///  Struct for Market Data Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketDataPacketHeader {
        PacketTime PacketTime;
        PacketSequenceNumber PacketSequenceNumber;
        PacketFlags PacketFlags;
        ChannelId ChannelId;
    };


    /// <summary>
    ///  Struct for Market Status Change Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketStatusChangeMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
    };


    /// <summary>
    ///  Struct for Market Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketUpdateMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
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
    ///  Struct for Order Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderUpdateMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
    };


    /// <summary>
    ///  Struct for Outright Standing Data Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OutrightStandingDataMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        ContractSymbolIndex ContractSymbolIndex;
        InstrumentEventDate InstrumentEventDate;
        IsinCode IsinCode;
        Cfi Cfi;
        MaturityDate MaturityDate;
        LotSize LotSize;
        StrikePrice StrikePrice;
        LastTradingDate LastTradingDate;
        DaysToExpiry DaysToExpiry;
        DerivativesInstrumentTradingCode DerivativesInstrumentTradingCode;
        DerivativesInstrumentType DerivativesInstrumentType;
        ExpiryCycleType ExpiryCycleType;
        UnderlyingDerivativesInstrumentTradingCode UnderlyingDerivativesInstrumentTradingCode;
        UnderlyingSymbolIndex UnderlyingSymbolIndex;
        TradingUnit TradingUnit;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        MarketDataPacketHeader MarketDataPacketHeader;
    };


    /// <summary>
    ///  Struct for Packet Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketFlags {
        ReservedBits ReservedBits;
        HasStatusMessage HasStatusMessage;
        HasEndOfDaySnapshot HasEndOfDaySnapshot;
        HasStartOfDaySnapshot HasStartOfDaySnapshot;
        PsnHighWeight PsnHighWeight;
        MdgRestartCount MdgRestartCount;
        Compression Compression;
    };


    /// <summary>
    ///  Struct for Price Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PriceUpdateMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
    };


    /// <summary>
    ///  Struct for Real Time Index Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RealTimeIndexMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        EventTime EventTime;
        SymbolIndex SymbolIndex;
        IndexLevel IndexLevel;
        PctgOfCapitalization PctgOfCapitalization;
        PrctVarfromPrevClose PrctVarfromPrevClose;
        NumTradedInstruments NumTradedInstruments;
        IndexLevelType IndexLevelType;
        IndexPriceCode IndexPriceCode;
    };


    /// <summary>
    ///  Struct for Standing Data Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StandingDataMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
        OptiqSegment OptiqSegment;
        PartitionId PartitionId;
        FullInstrumentName FullInstrumentName;
        InstrumentName InstrumentName;
        InstrumentTradingCode InstrumentTradingCode;
        InstrumentGroupCode InstrumentGroupCode;
        IsinCode IsinCode;
        PriceDecimals PriceDecimals;
        QuantityDecimals QuantityDecimals;
        AmountDecimals AmountDecimals;
        RatioDecimals RatioDecimals;
        Cfi Cfi;
        InstrumentEventDate InstrumentEventDate;
        StrikePrice StrikePrice;
        DarkEligibility DarkEligibility;
        DarkLisThreshold DarkLisThreshold;
        DarkMinQuantity DarkMinQuantity;
        DateOfLastTrade DateOfLastTrade;
        DepositaryList DepositaryList;
        MainDepositary MainDepositary;
        FirstSettlementDate FirstSettlementDate;
        GuaranteeIndicator GuaranteeIndicator;
        Icb Icb;
        IssuingCountry IssuingCountry;
        LastAdjustedClosingPrice LastAdjustedClosingPrice;
        LotSize LotSize;
        MaturityDate MaturityDate;
        MaximumDecimalsInQuantity MaximumDecimalsInQuantity;
        Mic Mic;
        MicList MicList;
        CountryOfExchange CountryOfExchange;
        Mnemonic Mnemonic;
        UnderlyingMic UnderlyingMic;
        UnderlyingIsinCode UnderlyingIsinCode;
        TradingCurrency TradingCurrency;
        CurrencyCoefficient CurrencyCoefficient;
        TradingCurrencyIndicator TradingCurrencyIndicator;
        StrikeCurrencyIndicator StrikeCurrencyIndicator;
        NumberInstrumentCirculating NumberInstrumentCirculating;
        ParValue ParValue;
        QuantityNotation QuantityNotation;
        InstUnitExp InstUnitExp;
        SettlementDelay SettlementDelay;
        StrikeCurrency StrikeCurrency;
        TaxCode TaxCode;
        TypeOfCorporateEvent TypeOfCorporateEvent;
        TypeOfMarketAdmission TypeOfMarketAdmission;
        RepoIndicator RepoIndicator;
        IssuePrice IssuePrice;
        NominalCurrency NominalCurrency;
        IssuePriceDecimals IssuePriceDecimals;
        StrikePriceDecimals StrikePriceDecimals;
        LiquidInstrumentIndicator LiquidInstrumentIndicator;
        MarketOfReferenceMic MarketOfReferenceMic;
        IcbCode IcbCode;
        ThresholdLisPostTrade60Mn ThresholdLisPostTrade60Mn;
        ThresholdLisPostTrade120Mn ThresholdLisPostTrade120Mn;
        ThresholdLisPostTradeEod ThresholdLisPostTradeEod;
    };


    /// <summary>
    ///  Struct for Start Of Day Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfDayMessage {
        MdSeqNum MdSeqNum;
        SessionTradingDay SessionTradingDay;
    };


    /// <summary>
    ///  Struct for Start Of Snapshot Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfSnapshotMessage {
        LastMdSeqNum LastMdSeqNum;
        SnapshotTime SnapshotTime;
    };


    /// <summary>
    ///  Struct for Statistics Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StatisticsMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        SymbolIndex SymbolIndex;
    };


    /// <summary>
    ///  Struct for Strategy Standing Data Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyStandingDataMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        SymbolIndex SymbolIndex;
        DerivativesInstrumentTradingCode DerivativesInstrumentTradingCode;
        ExchangeCode ExchangeCode;
        MaturityDate MaturityDate;
        StrategyCode StrategyCode;
        ContractSymbolIndex ContractSymbolIndex;
        Cfi Cfi;
    };


    /// <summary>
    ///  Struct for Technical Notification Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TechnicalNotificationMessage {
        MdSeqNum MdSeqNum;
        TechnicalNotificationType TechnicalNotificationType;
        RebroadcastIndicator RebroadcastIndicator;
        RetransmissionStartTime RetransmissionStartTime;
        RetransmissionEndTime RetransmissionEndTime;
        SymbolIndex SymbolIndex;
    };


    /// <summary>
    ///  Struct for Timetable Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TimetableMessage {
        MdSeqNum MdSeqNum;
        RebroadcastIndicator RebroadcastIndicator;
        Emm Emm;
        PatternId PatternId;
        SymbolIndex SymbolIndex;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
