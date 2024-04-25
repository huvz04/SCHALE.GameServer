// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentSpineDialogOffsetExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentSpineDialogOffsetExcel GetRootAsEventContentSpineDialogOffsetExcel(ByteBuffer _bb) { return GetRootAsEventContentSpineDialogOffsetExcel(_bb, new EventContentSpineDialogOffsetExcel()); }
  public static EventContentSpineDialogOffsetExcel GetRootAsEventContentSpineDialogOffsetExcel(ByteBuffer _bb, EventContentSpineDialogOffsetExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentSpineDialogOffsetExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EventContentType EventContentType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.EventContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EventContentType.Stage; } }
  public long CostumeUniqueId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float SpineOffsetX { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SpineOffsetY { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DialogOffsetX { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DialogOffsetY { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<SCHALE.Common.FlatData.EventContentSpineDialogOffsetExcel> CreateEventContentSpineDialogOffsetExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      SCHALE.Common.FlatData.EventContentType EventContentType = SCHALE.Common.FlatData.EventContentType.Stage,
      long CostumeUniqueId = 0,
      float SpineOffsetX = 0.0f,
      float SpineOffsetY = 0.0f,
      float DialogOffsetX = 0.0f,
      float DialogOffsetY = 0.0f) {
    builder.StartTable(7);
    EventContentSpineDialogOffsetExcel.AddCostumeUniqueId(builder, CostumeUniqueId);
    EventContentSpineDialogOffsetExcel.AddEventContentId(builder, EventContentId);
    EventContentSpineDialogOffsetExcel.AddDialogOffsetY(builder, DialogOffsetY);
    EventContentSpineDialogOffsetExcel.AddDialogOffsetX(builder, DialogOffsetX);
    EventContentSpineDialogOffsetExcel.AddSpineOffsetY(builder, SpineOffsetY);
    EventContentSpineDialogOffsetExcel.AddSpineOffsetX(builder, SpineOffsetX);
    EventContentSpineDialogOffsetExcel.AddEventContentType(builder, EventContentType);
    return EventContentSpineDialogOffsetExcel.EndEventContentSpineDialogOffsetExcel(builder);
  }

  public static void StartEventContentSpineDialogOffsetExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddEventContentType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventContentType eventContentType) { builder.AddInt(1, (int)eventContentType, 0); }
  public static void AddCostumeUniqueId(FlatBufferBuilder builder, long costumeUniqueId) { builder.AddLong(2, costumeUniqueId, 0); }
  public static void AddSpineOffsetX(FlatBufferBuilder builder, float spineOffsetX) { builder.AddFloat(3, spineOffsetX, 0.0f); }
  public static void AddSpineOffsetY(FlatBufferBuilder builder, float spineOffsetY) { builder.AddFloat(4, spineOffsetY, 0.0f); }
  public static void AddDialogOffsetX(FlatBufferBuilder builder, float dialogOffsetX) { builder.AddFloat(5, dialogOffsetX, 0.0f); }
  public static void AddDialogOffsetY(FlatBufferBuilder builder, float dialogOffsetY) { builder.AddFloat(6, dialogOffsetY, 0.0f); }
  public static Offset<SCHALE.Common.FlatData.EventContentSpineDialogOffsetExcel> EndEventContentSpineDialogOffsetExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentSpineDialogOffsetExcel>(o);
  }
}


static public class EventContentSpineDialogOffsetExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentType*/, 4 /*SCHALE.Common.FlatData.EventContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*CostumeUniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*SpineOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*SpineOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*DialogOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*DialogOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}