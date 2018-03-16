// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AElfDemo.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace AElf.RPC {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class AElfRPC
  {
    static readonly string __ServiceName = "AElf.RPC.AElfRPC";

    static readonly grpc::Marshaller<global::AElf.RPC.InvokeOption> __Marshaller_InvokeOption = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.RPC.InvokeOption.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AElf.RPC.Result> __Marshaller_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.RPC.Result.Parser.ParseFrom);

    static readonly grpc::Method<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result> __Method_Invoke = new grpc::Method<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Invoke",
        __Marshaller_InvokeOption,
        __Marshaller_Result);

    static readonly grpc::Method<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result> __Method_ListResults = new grpc::Method<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListResults",
        __Marshaller_InvokeOption,
        __Marshaller_Result);

    static readonly grpc::Method<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result> __Method_ListInvoke = new grpc::Method<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ListInvoke",
        __Marshaller_InvokeOption,
        __Marshaller_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.RPC.AElfDemoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AElfRPC</summary>
    public abstract partial class AElfRPCBase
    {
      /// <summary>
      /// invoke SmartContract with rpc
      /// return something in string meaning result
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::AElf.RPC.Result> Invoke(global::AElf.RPC.InvokeOption request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A server-to-client streaming RPC.
      /// Results are streamed rather than returned at once 
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task ListResults(global::AElf.RPC.InvokeOption request, grpc::IServerStreamWriter<global::AElf.RPC.Result> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A client-to-server streaming RPC
      /// request stream and return one result 
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::AElf.RPC.Result> ListInvoke(grpc::IAsyncStreamReader<global::AElf.RPC.InvokeOption> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AElfRPC</summary>
    public partial class AElfRPCClient : grpc::ClientBase<AElfRPCClient>
    {
      /// <summary>Creates a new client for AElfRPC</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AElfRPCClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AElfRPC that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AElfRPCClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AElfRPCClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AElfRPCClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// invoke SmartContract with rpc
      /// return something in string meaning result
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::AElf.RPC.Result Invoke(global::AElf.RPC.InvokeOption request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Invoke(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// invoke SmartContract with rpc
      /// return something in string meaning result
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::AElf.RPC.Result Invoke(global::AElf.RPC.InvokeOption request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Invoke, null, options, request);
      }
      /// <summary>
      /// invoke SmartContract with rpc
      /// return something in string meaning result
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::AElf.RPC.Result> InvokeAsync(global::AElf.RPC.InvokeOption request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return InvokeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// invoke SmartContract with rpc
      /// return something in string meaning result
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::AElf.RPC.Result> InvokeAsync(global::AElf.RPC.InvokeOption request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Invoke, null, options, request);
      }
      /// <summary>
      /// A server-to-client streaming RPC.
      /// Results are streamed rather than returned at once 
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::AElf.RPC.Result> ListResults(global::AElf.RPC.InvokeOption request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A server-to-client streaming RPC.
      /// Results are streamed rather than returned at once 
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::AElf.RPC.Result> ListResults(global::AElf.RPC.InvokeOption request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListResults, null, options, request);
      }
      /// <summary>
      /// A client-to-server streaming RPC
      /// request stream and return one result 
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result> ListInvoke(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListInvoke(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A client-to-server streaming RPC
      /// request stream and return one result 
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::AElf.RPC.InvokeOption, global::AElf.RPC.Result> ListInvoke(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ListInvoke, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AElfRPCClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AElfRPCClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AElfRPCBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Invoke, serviceImpl.Invoke)
          .AddMethod(__Method_ListResults, serviceImpl.ListResults)
          .AddMethod(__Method_ListInvoke, serviceImpl.ListInvoke).Build();
    }

  }
}
#endregion