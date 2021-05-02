namespace Otc.Markets.Multicast.Ats.v4.3 {

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
    ///  Adr Level
    /// </summary>
    public unsafe struct AdrLevel {
        public const int Size = 15;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Adr Ratio
    /// </summary>
    public unsafe struct AdrRatio {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Bid Wanted
    /// </summary>
    public unsafe struct AskBidWanted {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Ask Price
    /// </summary>
    public unsafe struct AskPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Priced
    /// </summary>
    public unsafe struct AskPriced {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Ask Qap
    /// </summary>
    public struct AskQap {
        public sbyte Raw;
    };


    /// <summary>
    ///  Ask Size
    /// </summary>
    public unsafe struct AskSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Time Milli
    /// </summary>
    public unsafe struct AskTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Ask Unsolicited
    /// </summary>
    public unsafe struct AskUnsolicited {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Asset Class Values
    /// </summary>
    public enum AssetClass : byte {
        Equity = 1,
        FixedIncome = 2,
    };


    /// <summary>
    ///  Bb Quoted
    /// </summary>
    public unsafe struct BbQuoted {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Bid Ask Wanted
    /// </summary>
    public unsafe struct BidAskWanted {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Bid Auto Ex
    /// </summary>
    public unsafe struct BidAutoEx {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Bid Price
    /// </summary>
    public unsafe struct BidPrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Priced
    /// </summary>
    public unsafe struct BidPriced {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Bid Qap
    /// </summary>
    public struct BidQap {
        public sbyte Raw;
    };


    /// <summary>
    ///  Bid Size
    /// </summary>
    public unsafe struct BidSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Time Milli
    /// </summary>
    public unsafe struct BidTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Bid Unsolicited
    /// </summary>
    public unsafe struct BidUnsolicited {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Callable Date Milli
    /// </summary>
    public unsafe struct CallableDateMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Caveat Emptor Warning
    /// </summary>
    public unsafe struct CaveatEmptorWarning {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Channel Seq Num
    /// </summary>
    public unsafe struct ChannelSeqNum {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Coupon
    /// </summary>
    public unsafe struct Coupon {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cusip
    /// </summary>
    public unsafe struct Cusip {
        public const int Size = 9;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Deprecated
    /// </summary>
    public unsafe struct Deprecated {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Disclosure Status Values
    /// </summary>
    public enum DisclosureStatus : byte {
        NoDisclosureStatus = 0,
        CurrentInformation = 2,
        LimitedInformation = 3,
        NoInformation = 4,
    };


    /// <summary>
    ///  Heartbeat
    /// </summary>
    public unsafe struct Heartbeat {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Inside Id
    /// </summary>
    public unsafe struct InsideId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Inside Time Milli
    /// </summary>
    public unsafe struct InsideTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Irregular
    /// </summary>
    public unsafe struct Irregular {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Issuer Name
    /// </summary>
    public unsafe struct IssuerName {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Issuer Size
    /// </summary>
    public unsafe struct IssuerSize {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Last Update Milli
    /// </summary>
    public unsafe struct LastUpdateMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Close
    /// </summary>
    public unsafe struct MarketClose {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Close Time Milli
    /// </summary>
    public unsafe struct MarketCloseTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Msg Ct
    /// </summary>
    public unsafe struct MarketMsgCt {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Market Open
    /// </summary>
    public unsafe struct MarketOpen {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Maturity Date Milli
    /// </summary>
    public unsafe struct MaturityDateMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Size
    /// </summary>
    public unsafe struct MessageSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type
    /// </summary>
    public unsafe struct MessageType {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Messages
    /// </summary>
    public unsafe struct Messages {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
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
    ///  Nms Conditional Quote
    /// </summary>
    public unsafe struct NmsConditionalQuote {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Num Priced Mp
    /// </summary>
    public unsafe struct NumPricedMp {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Auto Ex
    /// </summary>
    public unsafe struct OfferAutoEx {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Otc Issuer Id
    /// </summary>
    public unsafe struct OtcIssuerId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Otc Link Ecn Eligible
    /// </summary>
    public unsafe struct OtcLinkEcnEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Otc Link Messaging Disabled
    /// </summary>
    public unsafe struct OtcLinkMessagingDisabled {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Packet Milli
    /// </summary>
    public unsafe struct PacketMilli {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Size
    /// </summary>
    public unsafe struct PacketSize {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Par Value
    /// </summary>
    public unsafe struct ParValue {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Piggyback
    /// </summary>
    public unsafe struct Piggyback {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Price
    /// </summary>
    public unsafe struct Price {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Primary Market
    /// </summary>
    public unsafe struct PrimaryMarket {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Qap
    /// </summary>
    public struct Qap {
        public sbyte Raw;
    };


    /// <summary>
    ///  Qualified Institutional Buyers Only
    /// </summary>
    public unsafe struct QualifiedInstitutionalBuyersOnly {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Quote Action
    /// </summary>
    public unsafe struct QuoteAction {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Id
    /// </summary>
    public unsafe struct QuoteId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Reference Id
    /// </summary>
    public unsafe struct QuoteReferenceId {
        public const int Size = 2;

        public ushort Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Saturated
    /// </summary>
    public unsafe struct QuoteSaturated {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Quote Time Milli
    /// </summary>
    public unsafe struct QuoteTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reference Price Action Values
    /// </summary>
    public enum ReferencePriceAction : byte {
        Add = 2,
        Delete = 3,
        Spin = 4,
    };


    /// <summary>
    ///  Reference Price Id
    /// </summary>
    public unsafe struct ReferencePriceId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Replay
    /// </summary>
    public unsafe struct Replay {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reporting Status Values
    /// </summary>
    public enum ReportingStatus : byte {
        AlternativeReportingStandard = (byte)'A',
        BankThrift = (byte)'B',
        SecReporting = (byte)'F',
        InternationalReporting = (byte)'G',
        InsuranceCompany = (byte)'I',
        NoReporting = (byte)'N',
        OtherReportingStandard = (byte)'O',
        FinraReporting = (byte)'R',
        SecReportingInvestmentCompany = (byte)'V',
        SecReportingRegA = (byte)'W',
    };


    /// <summary>
    ///  Reserved Extended Quote Flag Bits
    /// </summary>
    public unsafe struct ReservedExtendedQuoteFlagBits {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Packet Flags
    /// </summary>
    public unsafe struct ReservedPacketFlags {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Trade Status Bits
    /// </summary>
    public unsafe struct ReservedTradeStatusBits {
        public const int Size = 7;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Saturation Eligible
    /// </summary>
    public unsafe struct SaturationEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Security Action Values
    /// </summary>
    public enum SecurityAction : byte {
        Update = 1,
        Add = 2,
        Delete = 3,
        Spin = 4,
    };


    /// <summary>
    ///  Security Desc
    /// </summary>
    public unsafe struct SecurityDesc {
        public const int Size = 25;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Detail
    /// </summary>
    public unsafe struct SecurityDetail {
        public const int Size = 0;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Security Detail Size
    /// </summary>
    public unsafe struct SecurityDetailSize {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public unsafe struct SecurityId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Status Values
    /// </summary>
    public enum SecurityStatus : byte {
        Active = (byte)'A',
        QuoteOnly = (byte)'Q',
        Suspended = (byte)'S',
        Halted = (byte)'H',
        InternalHalt = (byte)'I',
        Revoked = (byte)'R',
        Deleted = (byte)'D',
    };


    /// <summary>
    ///  Security Type
    /// </summary>
    public unsafe struct SecurityType {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seq Num
    /// </summary>
    public unsafe struct SeqNum {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Seq Num Reset
    /// </summary>
    public unsafe struct SeqNumReset {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Short Name
    /// </summary>
    public unsafe struct ShortName {
        public const int Size = 25;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Size
    /// </summary>
    public unsafe struct Size {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Spin End Time Milli
    /// </summary>
    public unsafe struct SpinEndTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Spin Last Seq Num
    /// </summary>
    public unsafe struct SpinLastSeqNum {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Spin Msg Ct
    /// </summary>
    public unsafe struct SpinMsgCt {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Spin Start Time Milli
    /// </summary>
    public unsafe struct SpinStartTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Spin Type Values
    /// </summary>
    public enum SpinType : byte {
        Reference = 1,
        MarketData = 2,
        Opening = 3,
    };


    /// <summary>
    ///  State
    /// </summary>
    public unsafe struct State {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Test
    /// </summary>
    public unsafe struct Test {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Tier Values
    /// </summary>
    public enum Tier : byte {
        NoTier = 0,
        OtcqxUsPremier = 1,
        OtcqxUs = 2,
        OtcqxInternationalPremier = 5,
        OtcqxInternational = 6,
        Otcqb = 10,
        OtcbbOnly = 11,
        PinkCurrent = 20,
        PinkLimited = 21,
        PinkNoInformation = 22,
        GreyMarket = 30,
        ExpertMarket = 40,
        OtcBonds = 50,
    };


    /// <summary>
    ///  Time Milli
    /// </summary>
    public unsafe struct TimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Action Values
    /// </summary>
    public enum TradeAction : byte {
        Add = 2,
    };


    /// <summary>
    ///  Trade Flags
    /// </summary>
    public unsafe struct TradeFlags {
        public const int Size = 1;

        public byte Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Price
    /// </summary>
    public unsafe struct TradePrice {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Size
    /// </summary>
    public unsafe struct TradeSize {
        public const int Size = 4;

        public uint Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Time Milli
    /// </summary>
    public unsafe struct TradeTimeMilli {
        public const int Size = 8;

        public ulong Bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Value
            => Swap(Bytes);
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unsolicited Only
    /// </summary>
    public unsafe struct UnsolicitedOnly {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Update Side
    /// </summary>
    public unsafe struct UpdateSide {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for End Of Spin Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EndOfSpinMessage {
        ChannelSeqNum ChannelSeqNum;
        SpinType SpinType;
        SpinMsgCt SpinMsgCt;
        SpinEndTimeMilli SpinEndTimeMilli;
        SpinLastSeqNum SpinLastSeqNum;
    };


    /// <summary>
    ///  Struct for Extended Quote Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ExtendedQuoteFlags {
        ReservedExtendedQuoteFlagBits ReservedExtendedQuoteFlagBits;
        NmsConditionalQuote NmsConditionalQuote;
        OfferAutoEx OfferAutoEx;
        BidAutoEx BidAutoEx;
        QuoteSaturated QuoteSaturated;
    };


    /// <summary>
    ///  Struct for Inside Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InsideUpdateMessage {
        ChannelSeqNum ChannelSeqNum;
        InsideId InsideId;
        QuoteFlags QuoteFlags;
        Price Price;
        Size Size;
        InsideTimeMilli InsideTimeMilli;
        NumPricedMp NumPricedMp;
    };


    /// <summary>
    ///  Struct for Market Close Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketCloseMessage {
        ChannelSeqNum ChannelSeqNum;
        MarketCloseTimeMilli MarketCloseTimeMilli;
        MarketMsgCt MarketMsgCt;
    };


    /// <summary>
    ///  Struct for Market Open Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MarketOpenMessage {
        ChannelSeqNum ChannelSeqNum;
        MarketOpen MarketOpen;
        MarketClose MarketClose;
    };


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
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        PacketHeader PacketHeader;
    };


    /// <summary>
    ///  Struct for Packet Flag
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketFlag {
        Test Test;
        Replay Replay;
        ReservedPacketFlags ReservedPacketFlags;
        SeqNumReset SeqNumReset;
        Heartbeat Heartbeat;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        PacketSize PacketSize;
        SeqNum SeqNum;
        PacketFlag PacketFlag;
        Messages Messages;
        PacketMilli PacketMilli;
    };


    /// <summary>
    ///  Struct for Quote Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteFlags {
        BidAskWanted BidAskWanted;
        BidPriced BidPriced;
        BidUnsolicited BidUnsolicited;
        AskBidWanted AskBidWanted;
        AskPriced AskPriced;
        AskUnsolicited AskUnsolicited;
        State State;
        UpdateSide UpdateSide;
    };


    /// <summary>
    ///  Struct for Quote Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteMessage {
        ChannelSeqNum ChannelSeqNum;
        QuoteId QuoteId;
        QuoteAction QuoteAction;
        QuoteFlags QuoteFlags;
        SecurityId SecurityId;
        Mpid Mpid;
        AskPrice AskPrice;
        AskSize AskSize;
        AskQap AskQap;
        AskTimeMilli AskTimeMilli;
        BidPrice BidPrice;
        BidSize BidSize;
        BidQap BidQap;
        BidTimeMilli BidTimeMilli;
        QuoteReferenceId QuoteReferenceId;
        ExtendedQuoteFlags ExtendedQuoteFlags;
    };


    /// <summary>
    ///  Struct for Quote Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteUpdateMessage {
        ChannelSeqNum ChannelSeqNum;
        QuoteId QuoteId;
        QuoteFlags QuoteFlags;
        Price Price;
        Size Size;
        Qap Qap;
        QuoteTimeMilli QuoteTimeMilli;
        QuoteReferenceId QuoteReferenceId;
        ExtendedQuoteFlags ExtendedQuoteFlags;
    };


    /// <summary>
    ///  Struct for Reference Price Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReferencePriceMessage {
        ChannelSeqNum ChannelSeqNum;
        ReferencePriceId ReferencePriceId;
        ReferencePriceAction ReferencePriceAction;
        QuoteFlags QuoteFlags;
        SecurityId SecurityId;
        AskPrice AskPrice;
        AskSize AskSize;
        AskTimeMilli AskTimeMilli;
        BidPrice BidPrice;
        BidSize BidSize;
        BidTimeMilli BidTimeMilli;
    };


    /// <summary>
    ///  Struct for Reference Price Update Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ReferencePriceUpdateMessage {
        ChannelSeqNum ChannelSeqNum;
        ReferencePriceId ReferencePriceId;
        QuoteFlags QuoteFlags;
        Price Price;
        Size Size;
        TimeMilli TimeMilli;
    };


    /// <summary>
    ///  Struct for Security Flags
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityFlags {
        SaturationEligible SaturationEligible;
        OtcLinkMessagingDisabled OtcLinkMessagingDisabled;
        OtcLinkEcnEligible OtcLinkEcnEligible;
        BbQuoted BbQuoted;
        UnsolicitedOnly UnsolicitedOnly;
        QualifiedInstitutionalBuyersOnly QualifiedInstitutionalBuyersOnly;
        CaveatEmptorWarning CaveatEmptorWarning;
        Piggyback Piggyback;
    };


    /// <summary>
    ///  Struct for Security Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityMessage {
        ChannelSeqNum ChannelSeqNum;
        Symbol Symbol;
        LastUpdateMilli LastUpdateMilli;
        SecurityAction SecurityAction;
        AssetClass AssetClass;
        SecurityId SecurityId;
        SecurityFlags SecurityFlags;
        Tier Tier;
        ReportingStatus ReportingStatus;
        SecurityStatus SecurityStatus;
    };


    /// <summary>
    ///  Struct for Start Of Spin Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StartOfSpinMessage {
        ChannelSeqNum ChannelSeqNum;
        SpinType SpinType;
        SpinStartTimeMilli SpinStartTimeMilli;
        SpinLastSeqNum SpinLastSeqNum;
    };


    /// <summary>
    ///  Struct for Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeMessage {
        ChannelSeqNum ChannelSeqNum;
        TradeId TradeId;
        TradeAction TradeAction;
        TradeFlags TradeFlags;
        SecurityId SecurityId;
        TradeStatus TradeStatus;
        Deprecated Deprecated;
        TradePrice TradePrice;
        TradeSize TradeSize;
        TradeTimeMilli TradeTimeMilli;
    };


    /// <summary>
    ///  Struct for Trade Status
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradeStatus {
        ReservedTradeStatusBits ReservedTradeStatusBits;
        Irregular Irregular;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
