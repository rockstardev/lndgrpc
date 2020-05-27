# Be sure to update path to nuget package depending on platform / username

~/.nuget/packages/grpc.tools/2.27.0/tools/macosx_x64/protoc --csharp_out . --grpc_out . rpc.proto --plugin=protoc-gen-grpc=/Users/tom/.nuget/packages/grpc.tools/2.27.0/tools/macosx_x64/grpc_csharp_plugin --grpc_opt=no_server
~/.nuget/packages/grpc.tools/2.27.0/tools/macosx_x64/protoc --csharp_out . --grpc_out . router.proto --plugin=protoc-gen-grpc=/Users/tom/.nuget/packages/grpc.tools/2.27.0/tools/macosx_x64/grpc_csharp_plugin --grpc_opt=no_server
~/.nuget/packages/grpc.tools/2.27.0/tools/macosx_x64/protoc --csharp_out . --grpc_out . invoices.proto --plugin=protoc-gen-grpc=/Users/tom/.nuget/packages/grpc.tools/2.27.0/tools/macosx_x64/grpc_csharp_plugin --grpc_opt=no_server