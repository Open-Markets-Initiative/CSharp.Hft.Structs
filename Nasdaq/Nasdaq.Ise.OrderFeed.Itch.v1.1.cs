namespace MyNamespace {

    #region Methods
    ///////////////////////////////////////////////////////////////////////

    public static class Endian {

        /// <summary>
        ///  Swap byte order for 2 byte unsigned short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ushort value)
            => value << 8 | value >> 8 
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ulong value)
            => (0x00000000000000FF) & (value >> 56) |
               (0x000000000000FF00) & (value >> 40) |
               (0x0000000000FF0000) & (value >> 24) |
               (0x00000000FF000000) & (value >> 8)  |
               (0x000000FF00000000) & (value << 8)  |
               (0x0000FF0000000000) & (value << 24) |
               (0x00FF000000000000) & (value << 40) |
               (0xFF00000000000000) & (value << 56);
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction Event Values
    /// </summary>
    public enum AuctionEvent : byte {
        Start = (byte)'S',
        AuctionUpdate = (byte)'U',
        EndOfAuction = (byte)'E',
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public struct AuctionId {
        public uint Raw;
    };


    /// <summary>
    ///  Closing Only Values
    /// </summary>
    public enum ClosingOnly : byte {
        ClosingPositionOnly = (byte)'Y',
        NotClosingPositionOnly = (byte)'N',
    };


    /// <summary>
    ///  Cmta
    /// </summary>
    public unsafe struct Cmta {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Contract Size
    /// </summary>
    public struct ContractSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Count
    /// </summary>
    public struct Count {
        public ushort Raw;
    };


    /// <summary>
    ///  Current Day
    /// </summary>
    public struct CurrentDay {
        public byte Raw;
    };


    /// <summary>
    ///  Current Month
    /// </summary>
    public struct CurrentMonth {
        public byte Raw;
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        HaltInEffect = (byte)'H',
        TradingOnTheOptionsSystem = (byte)'T',
    };


    /// <summary>
    ///  Current Year
    /// </summary>
    public struct CurrentYear {
        public ushort Raw;
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfMessages = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfOpeningProcess = (byte)'Q',
        StartOfNormalHoursClosingProcess = (byte)'N',
        StartOfLateHoursClosingProcess = (byte)'L',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
        EndOfWcoEarlyClosing = (byte)'W',
    };


    /// <summary>
    ///  Exec Flag Values
    /// </summary>
    public enum ExecFlag : byte {
        None = (byte)'N',
        Aon = (byte)'A',
        Hidden = (byte)' ',
    };


    /// <summary>
    ///  Expiration Day
    /// </summary>
    public struct ExpirationDay {
        public byte Raw;
    };


    /// <summary>
    ///  Expiration Month
    /// </summary>
    public struct ExpirationMonth {
        public byte Raw;
    };


    /// <summary>
    ///  Expiration Year
    /// </summary>
    public struct ExpirationYear {
        public byte Raw;
    };


    /// <summary>
    ///  Giveup
    /// </summary>
    public unsafe struct Giveup {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Imbalance Direction Values
    /// </summary>
    public enum ImbalanceDirection : byte {
        BuyImbalance = (byte)'B',
        SellImbalance = (byte)'S',
    };


    /// <summary>
    ///  Imbalance Price
    /// </summary>
    public struct ImbalancePrice {
        public uint Raw;
    };


    /// <summary>
    ///  Imbalance Volume
    /// </summary>
    public struct ImbalanceVolume {
        public uint Raw;
    };


    /// <summary>
    ///  Length
    /// </summary>
    public struct Length {
        public ushort Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        OptionDirectoryMessage = (byte)'D',
        TradingActionMessage = (byte)'H',
        SecurityOpenClosedMessage = (byte)'O',
        OpeningImbalanceMessage = (byte)'N',
        OrderOnBookMessage = (byte)'B',
        AuctionMessage = (byte)'A',
    };


    /// <summary>
    ///  Mpv Values
    /// </summary>
    public enum Mpv : byte {
        PennyEverywhere = (byte)'E',
        Scaled = (byte)'S',
        PennyPilot = (byte)'P',
    };


    /// <summary>
    ///  Number Of Responses
    /// </summary>
    public struct NumberOfResponses {
        public byte Raw;
    };


    /// <summary>
    ///  Open State Values
    /// </summary>
    public enum OpenState : byte {
        OpenForAutoExecution = (byte)'Y',
        ClosedForAutoExecution = (byte)'N',
    };


    /// <summary>
    ///  Option Closing Type Values
    /// </summary>
    public enum OptionClosingType : byte {
        Normal = (byte)'N',
        Late = (byte)'L',
    };


    /// <summary>
    ///  Option Id
    /// </summary>
    public struct OptionId {
        public uint Raw;
    };


    /// <summary>
    ///  Option Type Values
    /// </summary>
    public enum OptionType : byte {
        Call = (byte)'C',
        Put = (byte)'P',
    };


    /// <summary>
    ///  Order Capacity Values
    /// </summary>
    public enum OrderCapacity : byte {
        Customer = (byte)'C',
        CustomerProfessional = (byte)'D',
        Firm = (byte)'F',
        BrokerDealerCustomer = (byte)'B',
        BrokerDealerFirm = (byte)'K',
        Proprietary = (byte)'E',
        AwayMarketMaker = (byte)'N',
        MarketMaker = (byte)'M',
    };


    /// <summary>
    ///  Order Type Values
    /// </summary>
    public enum OrderType : byte {
        Market = (byte)'M',
        Limit = (byte)'L',
    };


    /// <summary>
    ///  Owner Id
    /// </summary>
    public unsafe struct OwnerId {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Paired Contracts
    /// </summary>
    public struct PairedContracts {
        public uint Raw;
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public uint Raw;
    };


    /// <summary>
    ///  Response Price
    /// </summary>
    public struct ResponsePrice {
        public uint Raw;
    };


    /// <summary>
    ///  Response Size
    /// </summary>
    public struct ResponseSize {
        public uint Raw;
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sequence
    /// </summary>
    public struct Sequence {
        public ulong Raw;
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
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Bid = (byte)'B',
        OfferAsk = (byte)'A',
        Hidden = (byte)' ',
    };


    /// <summary>
    ///  Size
    /// </summary>
    public struct Size {
        public uint Raw;
    };


    /// <summary>
    ///  Source
    /// </summary>
    public struct Source {
        public byte Raw;
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Subversion
    /// </summary>
    public struct Subversion {
        public byte Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public ulong Raw;
    };


    /// <summary>
    ///  Tradable Values
    /// </summary>
    public enum Tradable : byte {
        Tradable = (byte)'Y',
        NotTradable = (byte)'N',
    };


    /// <summary>
    ///  Trading Type Values
    /// </summary>
    public enum TradingType : byte {
        Equity = (byte)'E',
        Index = (byte)'I',
        Etf = (byte)'F',
        Currency = (byte)'C',
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 13;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public struct Version {
        public byte Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Auction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        AuctionId AuctionId;
        OrderType OrderType;
        Side Side;
        Price Price;
        Size Size;
        ExecFlag ExecFlag;
        OrderCapacity OrderCapacity;
        OwnerId OwnerId;
        Giveup Giveup;
        Cmta Cmta;
        AuctionEvent AuctionEvent;
        NumberOfResponses NumberOfResponses;
    };


    /// <summary>
    ///  Struct for Auction Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionResponse {
        ResponsePrice ResponsePrice;
        ResponseSize ResponseSize;
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
        Length Length;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Opening Imbalance Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OpeningImbalanceMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        PairedContracts PairedContracts;
        ImbalanceDirection ImbalanceDirection;
        ImbalancePrice ImbalancePrice;
        ImbalanceVolume ImbalanceVolume;
    };


    /// <summary>
    ///  Struct for Option Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OptionDirectoryMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        ExpirationYear ExpirationYear;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        StrikePrice StrikePrice;
        OptionType OptionType;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        TradingType TradingType;
        ContractSize ContractSize;
        OptionClosingType OptionClosingType;
        Tradable Tradable;
        Mpv Mpv;
        ClosingOnly ClosingOnly;
    };


    /// <summary>
    ///  Struct for Order On Book Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct OrderOnBookMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        OrderType OrderType;
        Side Side;
        Price Price;
        Size Size;
        ExecFlag ExecFlag;
        OrderCapacity OrderCapacity;
        OwnerId OwnerId;
        Giveup Giveup;
        Cmta Cmta;
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
        Session Session;
        Sequence Sequence;
        Count Count;
    };


    /// <summary>
    ///  Struct for Security Open Closed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityOpenClosedMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Timestamp Timestamp;
        EventCode EventCode;
        CurrentYear CurrentYear;
        CurrentMonth CurrentMonth;
        CurrentDay CurrentDay;
        Version Version;
        Subversion Subversion;
    };


    /// <summary>
    ///  Struct for Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TradingActionMessage {
        Timestamp Timestamp;
        OptionId OptionId;
        CurrentTradingState CurrentTradingState;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}