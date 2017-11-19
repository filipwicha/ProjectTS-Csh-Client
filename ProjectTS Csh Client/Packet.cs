using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ProjectTS_Csh_Client
{
    class Packet
    {
        enum Operation
        {
            addition = 0b000,
            substraction = 0b001,
            multiplication = 0b010,
            division = 0b011,
            action1 = 0b100,
            action2 = 0b101,
            action3 = 0b110,
            action4 = 0b111
        }

        enum Status
        {
            everything_ok = 0b00,
            division_by_0 = 0b01,
            overrange = 0b10,
            something1 = 0b11
        };

        class FileToSendReceive
        {
            Operation operation; //has 3 bits
            int num1; //has 32 bits
            int num2; //has 32 bits
            Status status; //has 2 bits
            sbyte id; //has 8 bits

            BitArray serialize(FileToSendReceive ob)
            {
                FileStream fileStream = new FileStream("DataFile.dat", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    formatter.Serialize(fileStream, ob);
                    BitArray bitmap;
                    //add code that converts file into stream, and than saves the stream to BitArray
                    return bitmap;
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize because of: " + e.Message);
                }
                finally
                {
                    fileStream.Close();
                }

            }
            FileToSendReceive deserialize(BitArray bitmap)
            {
                FileToSendReceive ob;

                //add code that converts BitArray into stream, and than saves the stream to file

                FileStream fileStream = new FileStream("DataFile.dat", FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    return ob = (FileToSendReceive)formatter.Deserialize(fileStream);


                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize because of: " + e.Message);
                }
                finally
                {
                    fileStream.Close();
                }
            }
        }
        
        
        
    }
}

