using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

public class server {

    private const int BUFFER_SIZE = 1024;
    private const int PORT_NUMBER = 9999;

    static ASCIIEncoding encoding = new ASCIIEncoding();
    public static void Main() {
        try{
            IPAddress address = IPAddress.Parse("127.0.0.1");

            TcpListener listener = new TcpListener(address, PORT_NUMBER);
            
            // 1.Listen
            listener.Start();

            Console.WriteLine("Server started on " + listener.LocalEndpoint);
            Console.WriteLine("Waiting for a connectionn...");

            Socket socket =  listener.AcceptSocket();
            Console.WriteLine("Connection received from " + socket.RemoteEndPoint);

            // 2.Receive
            byte[] data = new byte[BUFFER_SIZE];
            socket.Receive(data);

            string str = encoding.GetString(data);

            // 3.send
            socket.Send(encoding.GetBytes("Hello " + str));

            // 4.close
            socket.Close();
            listener.Stop();
            
        } catch(Exception ex){
            Console.WriteLine("Error: " + ex);
        }
        Console.Read();
    }

}