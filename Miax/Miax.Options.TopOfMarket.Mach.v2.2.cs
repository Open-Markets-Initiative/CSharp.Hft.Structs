namespace Miax.Options.TopOfMarket.Mach.v2.2 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

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
    ///  Packet Length
    /// </summary>
    public unsafe struct PacketLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Type Values
    /// </summary>
    public enum PacketType : byte {
        Heartbeat = 0,
        StartOfSession = 1,
        EndOfSession = 2,
        ApplicationMessage = 3,
    };


    /// <summary>
    ///  Sequence Number
    /// </summary>
    public unsafe struct SequenceNumber {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Number
    /// </summary>
    public unsafe struct SessionNumber {
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
    ///  Struct for Application Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApplicationMessage {
        MessageType MessageType;
        Data Data;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        SequenceNumber SequenceNumber;
        PacketLength PacketLength;
        PacketType PacketType;
        SessionNumber SessionNumber;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
