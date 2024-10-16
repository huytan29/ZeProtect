using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

public class client{

    private const int BUFFER_SIZE = 1024;
    private const int PORT_NUMBER = 9999;

    static ASCIIEncoding encoding = new ASCIIEncoding();

    public static void Main(){
        try {
            TcpClient client = new TcpClient();

            // 1.connect
            client.Connect("127.0.0.1", PORT_NUMBER);
            Stream stream = client.GetStream();

            
        } catch(Exception ex){

        }
    }
}