// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatGeobuf
{

using global::System;
using global::FlatBuffers;

public struct Srs : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Srs GetRootAsSrs(ByteBuffer _bb) { return GetRootAsSrs(_bb, new Srs()); }
  public static Srs GetRootAsSrs(ByteBuffer _bb, Srs obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Srs __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Code { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Org { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOrgBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetOrgBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetOrgArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<Srs> CreateSrs(FlatBufferBuilder builder,
      int code = 0,
      StringOffset orgOffset = default(StringOffset)) {
    builder.StartObject(2);
    Srs.AddOrg(builder, orgOffset);
    Srs.AddCode(builder, code);
    return Srs.EndSrs(builder);
  }

  public static void StartSrs(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddCode(FlatBufferBuilder builder, int code) { builder.AddInt(0, code, 0); }
  public static void AddOrg(FlatBufferBuilder builder, StringOffset orgOffset) { builder.AddOffset(1, orgOffset.Value, 0); }
  public static Offset<Srs> EndSrs(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Srs>(o);
  }
};


}
