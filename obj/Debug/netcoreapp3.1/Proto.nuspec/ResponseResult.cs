// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto.nuspec/responseResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcToolkit.Proto {

  /// <summary>Holder for reflection information generated from Proto.nuspec/responseResult.proto</summary>
  public static partial class ResponseResultReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto.nuspec/responseResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResponseResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQcm90by5udXNwZWMvcmVzcG9uc2VSZXN1bHQucHJvdG8iZQoPUmVzcG9u",
            "c2VNZXNzYWdlEhQKDEhhc0V4Y2VwdGlvbhgBIAEoCBISCgpTdGF0dXNDb2Rl",
            "GAIgASgFEhgKEEV4Y2VwdGlvbk1lc3NhZ2UYAyABKAkSDgoGUmVzdWx0GAQg",
            "ASgJQhSqAhFHcnBjVG9vbGtpdC5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcToolkit.Proto.ResponseMessage), global::GrpcToolkit.Proto.ResponseMessage.Parser, new[]{ "HasException", "StatusCode", "ExceptionMessage", "Result" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResponseMessage : pb::IMessage<ResponseMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResponseMessage> _parser = new pb::MessageParser<ResponseMessage>(() => new ResponseMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResponseMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcToolkit.Proto.ResponseResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseMessage(ResponseMessage other) : this() {
      hasException_ = other.hasException_;
      statusCode_ = other.statusCode_;
      exceptionMessage_ = other.exceptionMessage_;
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseMessage Clone() {
      return new ResponseMessage(this);
    }

    /// <summary>Field number for the "HasException" field.</summary>
    public const int HasExceptionFieldNumber = 1;
    private bool hasException_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasException {
      get { return hasException_; }
      set {
        hasException_ = value;
      }
    }

    /// <summary>Field number for the "StatusCode" field.</summary>
    public const int StatusCodeFieldNumber = 2;
    private int statusCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "ExceptionMessage" field.</summary>
    public const int ExceptionMessageFieldNumber = 3;
    private string exceptionMessage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExceptionMessage {
      get { return exceptionMessage_; }
      set {
        exceptionMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 4;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResponseMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResponseMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HasException != other.HasException) return false;
      if (StatusCode != other.StatusCode) return false;
      if (ExceptionMessage != other.ExceptionMessage) return false;
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasException != false) hash ^= HasException.GetHashCode();
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (ExceptionMessage.Length != 0) hash ^= ExceptionMessage.GetHashCode();
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasException != false) {
        output.WriteRawTag(8);
        output.WriteBool(HasException);
      }
      if (StatusCode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(StatusCode);
      }
      if (ExceptionMessage.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ExceptionMessage);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasException != false) {
        output.WriteRawTag(8);
        output.WriteBool(HasException);
      }
      if (StatusCode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(StatusCode);
      }
      if (ExceptionMessage.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ExceptionMessage);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasException != false) {
        size += 1 + 1;
      }
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
      }
      if (ExceptionMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExceptionMessage);
      }
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResponseMessage other) {
      if (other == null) {
        return;
      }
      if (other.HasException != false) {
        HasException = other.HasException;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.ExceptionMessage.Length != 0) {
        ExceptionMessage = other.ExceptionMessage;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            HasException = input.ReadBool();
            break;
          }
          case 16: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 26: {
            ExceptionMessage = input.ReadString();
            break;
          }
          case 34: {
            Result = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            HasException = input.ReadBool();
            break;
          }
          case 16: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 26: {
            ExceptionMessage = input.ReadString();
            break;
          }
          case 34: {
            Result = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code