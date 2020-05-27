// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: router.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Routerrpc {
  public static partial class Router
  {
    static readonly string __ServiceName = "routerrpc.Router";

    static readonly grpc::Marshaller<global::Routerrpc.SendPaymentRequest> __Marshaller_routerrpc_SendPaymentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.SendPaymentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.PaymentStatus> __Marshaller_routerrpc_PaymentStatus = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.PaymentStatus.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.TrackPaymentRequest> __Marshaller_routerrpc_TrackPaymentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.TrackPaymentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.RouteFeeRequest> __Marshaller_routerrpc_RouteFeeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.RouteFeeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.RouteFeeResponse> __Marshaller_routerrpc_RouteFeeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.RouteFeeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.SendToRouteRequest> __Marshaller_routerrpc_SendToRouteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.SendToRouteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.SendToRouteResponse> __Marshaller_routerrpc_SendToRouteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.SendToRouteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.ResetMissionControlRequest> __Marshaller_routerrpc_ResetMissionControlRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.ResetMissionControlRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.ResetMissionControlResponse> __Marshaller_routerrpc_ResetMissionControlResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.ResetMissionControlResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.QueryMissionControlRequest> __Marshaller_routerrpc_QueryMissionControlRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.QueryMissionControlRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.QueryMissionControlResponse> __Marshaller_routerrpc_QueryMissionControlResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.QueryMissionControlResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.QueryProbabilityRequest> __Marshaller_routerrpc_QueryProbabilityRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.QueryProbabilityRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.QueryProbabilityResponse> __Marshaller_routerrpc_QueryProbabilityResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.QueryProbabilityResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.BuildRouteRequest> __Marshaller_routerrpc_BuildRouteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.BuildRouteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Routerrpc.BuildRouteResponse> __Marshaller_routerrpc_BuildRouteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Routerrpc.BuildRouteResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Routerrpc.SendPaymentRequest, global::Routerrpc.PaymentStatus> __Method_SendPayment = new grpc::Method<global::Routerrpc.SendPaymentRequest, global::Routerrpc.PaymentStatus>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SendPayment",
        __Marshaller_routerrpc_SendPaymentRequest,
        __Marshaller_routerrpc_PaymentStatus);

    static readonly grpc::Method<global::Routerrpc.TrackPaymentRequest, global::Routerrpc.PaymentStatus> __Method_TrackPayment = new grpc::Method<global::Routerrpc.TrackPaymentRequest, global::Routerrpc.PaymentStatus>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "TrackPayment",
        __Marshaller_routerrpc_TrackPaymentRequest,
        __Marshaller_routerrpc_PaymentStatus);

    static readonly grpc::Method<global::Routerrpc.RouteFeeRequest, global::Routerrpc.RouteFeeResponse> __Method_EstimateRouteFee = new grpc::Method<global::Routerrpc.RouteFeeRequest, global::Routerrpc.RouteFeeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EstimateRouteFee",
        __Marshaller_routerrpc_RouteFeeRequest,
        __Marshaller_routerrpc_RouteFeeResponse);

    static readonly grpc::Method<global::Routerrpc.SendToRouteRequest, global::Routerrpc.SendToRouteResponse> __Method_SendToRoute = new grpc::Method<global::Routerrpc.SendToRouteRequest, global::Routerrpc.SendToRouteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendToRoute",
        __Marshaller_routerrpc_SendToRouteRequest,
        __Marshaller_routerrpc_SendToRouteResponse);

    static readonly grpc::Method<global::Routerrpc.ResetMissionControlRequest, global::Routerrpc.ResetMissionControlResponse> __Method_ResetMissionControl = new grpc::Method<global::Routerrpc.ResetMissionControlRequest, global::Routerrpc.ResetMissionControlResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ResetMissionControl",
        __Marshaller_routerrpc_ResetMissionControlRequest,
        __Marshaller_routerrpc_ResetMissionControlResponse);

    static readonly grpc::Method<global::Routerrpc.QueryMissionControlRequest, global::Routerrpc.QueryMissionControlResponse> __Method_QueryMissionControl = new grpc::Method<global::Routerrpc.QueryMissionControlRequest, global::Routerrpc.QueryMissionControlResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryMissionControl",
        __Marshaller_routerrpc_QueryMissionControlRequest,
        __Marshaller_routerrpc_QueryMissionControlResponse);

    static readonly grpc::Method<global::Routerrpc.QueryProbabilityRequest, global::Routerrpc.QueryProbabilityResponse> __Method_QueryProbability = new grpc::Method<global::Routerrpc.QueryProbabilityRequest, global::Routerrpc.QueryProbabilityResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryProbability",
        __Marshaller_routerrpc_QueryProbabilityRequest,
        __Marshaller_routerrpc_QueryProbabilityResponse);

    static readonly grpc::Method<global::Routerrpc.BuildRouteRequest, global::Routerrpc.BuildRouteResponse> __Method_BuildRoute = new grpc::Method<global::Routerrpc.BuildRouteRequest, global::Routerrpc.BuildRouteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BuildRoute",
        __Marshaller_routerrpc_BuildRouteRequest,
        __Marshaller_routerrpc_BuildRouteResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Routerrpc.RouterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Router</summary>
    public partial class RouterClient : grpc::ClientBase<RouterClient>
    {
      /// <summary>Creates a new client for Router</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RouterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Router that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RouterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RouterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RouterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///*
      ///SendPayment attempts to route a payment described by the passed
      ///PaymentRequest to the final destination. The call returns a stream of
      ///payment status updates.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Routerrpc.PaymentStatus> SendPayment(global::Routerrpc.SendPaymentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendPayment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///SendPayment attempts to route a payment described by the passed
      ///PaymentRequest to the final destination. The call returns a stream of
      ///payment status updates.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Routerrpc.PaymentStatus> SendPayment(global::Routerrpc.SendPaymentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_SendPayment, null, options, request);
      }
      /// <summary>
      ///*
      ///TrackPayment returns an update stream for the payment identified by the
      ///payment hash.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Routerrpc.PaymentStatus> TrackPayment(global::Routerrpc.TrackPaymentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TrackPayment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///TrackPayment returns an update stream for the payment identified by the
      ///payment hash.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Routerrpc.PaymentStatus> TrackPayment(global::Routerrpc.TrackPaymentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_TrackPayment, null, options, request);
      }
      /// <summary>
      ///*
      ///EstimateRouteFee allows callers to obtain a lower bound w.r.t how much it
      ///may cost to send an HTLC to the target end destination.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.RouteFeeResponse EstimateRouteFee(global::Routerrpc.RouteFeeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EstimateRouteFee(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///EstimateRouteFee allows callers to obtain a lower bound w.r.t how much it
      ///may cost to send an HTLC to the target end destination.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.RouteFeeResponse EstimateRouteFee(global::Routerrpc.RouteFeeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EstimateRouteFee, null, options, request);
      }
      /// <summary>
      ///*
      ///EstimateRouteFee allows callers to obtain a lower bound w.r.t how much it
      ///may cost to send an HTLC to the target end destination.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.RouteFeeResponse> EstimateRouteFeeAsync(global::Routerrpc.RouteFeeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EstimateRouteFeeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///EstimateRouteFee allows callers to obtain a lower bound w.r.t how much it
      ///may cost to send an HTLC to the target end destination.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.RouteFeeResponse> EstimateRouteFeeAsync(global::Routerrpc.RouteFeeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EstimateRouteFee, null, options, request);
      }
      /// <summary>
      ///*
      ///SendToRoute attempts to make a payment via the specified route. This method
      ///differs from SendPayment in that it allows users to specify a full route
      ///manually. This can be used for things like rebalancing, and atomic swaps.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.SendToRouteResponse SendToRoute(global::Routerrpc.SendToRouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendToRoute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///SendToRoute attempts to make a payment via the specified route. This method
      ///differs from SendPayment in that it allows users to specify a full route
      ///manually. This can be used for things like rebalancing, and atomic swaps.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.SendToRouteResponse SendToRoute(global::Routerrpc.SendToRouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendToRoute, null, options, request);
      }
      /// <summary>
      ///*
      ///SendToRoute attempts to make a payment via the specified route. This method
      ///differs from SendPayment in that it allows users to specify a full route
      ///manually. This can be used for things like rebalancing, and atomic swaps.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.SendToRouteResponse> SendToRouteAsync(global::Routerrpc.SendToRouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendToRouteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///SendToRoute attempts to make a payment via the specified route. This method
      ///differs from SendPayment in that it allows users to specify a full route
      ///manually. This can be used for things like rebalancing, and atomic swaps.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.SendToRouteResponse> SendToRouteAsync(global::Routerrpc.SendToRouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendToRoute, null, options, request);
      }
      /// <summary>
      ///*
      ///ResetMissionControl clears all mission control state and starts with a clean
      ///slate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.ResetMissionControlResponse ResetMissionControl(global::Routerrpc.ResetMissionControlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ResetMissionControl(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///ResetMissionControl clears all mission control state and starts with a clean
      ///slate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.ResetMissionControlResponse ResetMissionControl(global::Routerrpc.ResetMissionControlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ResetMissionControl, null, options, request);
      }
      /// <summary>
      ///*
      ///ResetMissionControl clears all mission control state and starts with a clean
      ///slate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.ResetMissionControlResponse> ResetMissionControlAsync(global::Routerrpc.ResetMissionControlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ResetMissionControlAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///ResetMissionControl clears all mission control state and starts with a clean
      ///slate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.ResetMissionControlResponse> ResetMissionControlAsync(global::Routerrpc.ResetMissionControlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ResetMissionControl, null, options, request);
      }
      /// <summary>
      ///*
      ///QueryMissionControl exposes the internal mission control state to callers.
      ///It is a development feature.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.QueryMissionControlResponse QueryMissionControl(global::Routerrpc.QueryMissionControlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryMissionControl(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///QueryMissionControl exposes the internal mission control state to callers.
      ///It is a development feature.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.QueryMissionControlResponse QueryMissionControl(global::Routerrpc.QueryMissionControlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryMissionControl, null, options, request);
      }
      /// <summary>
      ///*
      ///QueryMissionControl exposes the internal mission control state to callers.
      ///It is a development feature.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.QueryMissionControlResponse> QueryMissionControlAsync(global::Routerrpc.QueryMissionControlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryMissionControlAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///QueryMissionControl exposes the internal mission control state to callers.
      ///It is a development feature.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.QueryMissionControlResponse> QueryMissionControlAsync(global::Routerrpc.QueryMissionControlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryMissionControl, null, options, request);
      }
      /// <summary>
      ///*
      ///QueryProbability returns the current success probability estimate for a
      ///given node pair and amount.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.QueryProbabilityResponse QueryProbability(global::Routerrpc.QueryProbabilityRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryProbability(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///QueryProbability returns the current success probability estimate for a
      ///given node pair and amount.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.QueryProbabilityResponse QueryProbability(global::Routerrpc.QueryProbabilityRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryProbability, null, options, request);
      }
      /// <summary>
      ///*
      ///QueryProbability returns the current success probability estimate for a
      ///given node pair and amount.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.QueryProbabilityResponse> QueryProbabilityAsync(global::Routerrpc.QueryProbabilityRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryProbabilityAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///QueryProbability returns the current success probability estimate for a
      ///given node pair and amount.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.QueryProbabilityResponse> QueryProbabilityAsync(global::Routerrpc.QueryProbabilityRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryProbability, null, options, request);
      }
      /// <summary>
      ///*
      ///BuildRoute builds a fully specified route based on a list of hop public
      ///keys. It retrieves the relevant channel policies from the graph in order to
      ///calculate the correct fees and time locks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.BuildRouteResponse BuildRoute(global::Routerrpc.BuildRouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BuildRoute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///BuildRoute builds a fully specified route based on a list of hop public
      ///keys. It retrieves the relevant channel policies from the graph in order to
      ///calculate the correct fees and time locks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Routerrpc.BuildRouteResponse BuildRoute(global::Routerrpc.BuildRouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BuildRoute, null, options, request);
      }
      /// <summary>
      ///*
      ///BuildRoute builds a fully specified route based on a list of hop public
      ///keys. It retrieves the relevant channel policies from the graph in order to
      ///calculate the correct fees and time locks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.BuildRouteResponse> BuildRouteAsync(global::Routerrpc.BuildRouteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BuildRouteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///*
      ///BuildRoute builds a fully specified route based on a list of hop public
      ///keys. It retrieves the relevant channel policies from the graph in order to
      ///calculate the correct fees and time locks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Routerrpc.BuildRouteResponse> BuildRouteAsync(global::Routerrpc.BuildRouteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BuildRoute, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RouterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RouterClient(configuration);
      }
    }

  }
}
#endregion
