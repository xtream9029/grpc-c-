using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Helloworld; // 프로토에서 생성된 네임스페이스

class Program
{
    static async Task Main(string[] args)
    {
        // gRPC 서버에 연결
        using var channel = GrpcChannel.ForAddress("http://localhost:50051");
        var client = new Greeter.GreeterClient(channel);

        // 서버에 Hello 요청
        var reply = await client.SayHelloAsync(new HelloRequest { Name = "C# Client" });

        // 응답 출력
        Console.WriteLine("Greeting: " + reply.Message);
    }
}

