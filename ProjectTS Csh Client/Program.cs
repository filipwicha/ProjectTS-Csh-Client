
/*       Client Program      */

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Collections;
using System.Linq;

//REMEMBER TO WRITE AN IP ADRESS DOWN THERE 

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
            Console.Write("Enter the string to be transmitted : ");

            //int in c# is always 32bit
            String operation = Console.ReadLine();
            Stream stm = tcpclnt.GetStream();

            string num1 = Console.ReadLine();
            byte[] firstNum = Encoding.ASCII.GetBytes(num1);
            
            ASCIIEncoding asen = new ASCIIEncoding();
            Console.WriteLine("Transmitting.....");

            stm.Write(firstNum, 0, firstNum.Length);

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

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

//