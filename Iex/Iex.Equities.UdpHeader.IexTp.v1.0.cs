namespace Iex.Equities.UdpHeader.IexTp.v1.0 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Channel Id
    /// </summary>
    public unsafe struct ChannelId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  First Message Sequence Number
    /// </summary>
    public unsafe struct FirstMessageSequenceNumber {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Count
    /// </summary>
    public unsafe struct MessageCount {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Data
    /// </summary>
    public unsafe struct MessageData {
        public const int Size = 0;

        public fixed byte Bytes[Size];
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
    ///  Message Protocol Id
    /// </summary>
    public unsafe struct MessageProtocolId {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Message Type
    /// </summary>
    public unsafe struct MessageType {
        public const int Size = 1;

        public byte Byte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Value
                => (char)Bytes;
        
        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Payload Length
    /// </summary>
    public unsafe struct PayloadLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed byte Bytes[Size];
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
    ///  Session Id
    /// </summary>
    public unsafe struct SessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Stream Offset
    /// </summary>
    public unsafe struct StreamOffset {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
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
    ///  Struct for Iex Tp Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct IexTpHeader {
        Version Version;
        Reserved Reserved;
        MessageProtocolId MessageProtocolId;
        ChannelId ChannelId;
        SessionId SessionId;
        PayloadLength PayloadLength;
        MessageCount MessageCount;
        StreamOffset StreamOffset;
        FirstMessageSequenceNumber FirstMessageSequenceNumber;
        SendTime SendTime;
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
        MessageLength MessageLength;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
        IexTpHeader IexTpHeader;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
