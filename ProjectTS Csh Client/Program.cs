using ProjectTS_Csh_Client;

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Collections;
using System.Linq;


public class client
{   

    public static void Main()
    {
        
        try
        {
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Connecting.....");

            tcpclnt.Connect("192.168.31.115", 8001);
            // use the ipaddress as in the server program

            Console.WriteLine("Connected");
            
            Stream stm = tcpclnt.GetStream();
            
            //Create the Packet variable,
            //there should be a code that serializes the Packet 
            
            Console.WriteLine("Transmitting.....");
            stm.Write(/* data, 0, data.Length */);

            //there should be a conversion from BitArray to byte[]
            byte[] bb = new byte[/* packet1.Length */];
            int k = stm.Read(bb, 0, /* packet1.Length */);

            for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(bb[i]));

            tcpclnt.Close();
        }

        catch (Exception e)
        {
            Console.WriteLine("Error..... " + e.StackTrace);
        }
        String wait = Console.ReadLine();
    }

}
