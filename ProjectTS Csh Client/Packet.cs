using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Wszystko jest ok
            everything_ok = 0b00,
	        // Błąd dzielenia przez zero
	        division_by_0 = 0b01,
	        // Wynik wykracza poza zakres, OVERFLOW
	        overrange = 0b10,
	        // Nieokreślony status jeszcze
	        something1 = 0b11
        };

        Operation operation; //has 3 bits
        int num1; //has 32 bits
        int num2; //has 32 bits
        Status status; //has 2 bits
        sbyte id; //has 8 bits

        IList<bool> packet;

        void serialize()
        {
            
                    
        }

        void deserialize()
        {

        }

    }
}
