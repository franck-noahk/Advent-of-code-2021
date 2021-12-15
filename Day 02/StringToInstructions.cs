using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;


namespace Day_02
{
    static class StringToInstructions
    {
        public static void GetInstructionSet(String input, Ship ToOpperate)
        {
            char[] charInput = input.ToCharArray();

            for (int i = 0; i < charInput.Length; i++)
            {
                if (charInput[i] == 'f')
                {
                    i += 8;
                    ToOpperate.forward((int)char.GetNumericValue(charInput[i]));
                    Console.WriteLine("position +" +charInput[i]);
                }
                else if (charInput[i] == 'u')
                { 
                    i += 3;
                    ToOpperate.up((int) char.GetNumericValue(charInput[i]));
                    Console.WriteLine("Depth - " + charInput[i]);
                } else if( charInput[i] == 'd'){
                    i += 5;
                    ToOpperate.down((int)char.GetNumericValue( charInput[i]));
                    Console.WriteLine("Depth + " + charInput[i]);
                }
                
            }
        }

       
    }
}
