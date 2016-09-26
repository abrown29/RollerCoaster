using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RollercoasterChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Hamlet.txt");
            using (reader)
            {
                string soliloquy = reader.ReadToEnd();

               while(soliloquy != null)
                {
                    char[] pieces = soliloquy.ToCharArray();
                    int bit = 0;

                    for(int i = 0; i <pieces.Length; i++)
                    {
                        char letter = pieces[i];
                        if(char.IsLetter(letter))
                        {
                            if (bit % 2 == 0)
                            {
                                pieces[i] = char.ToUpper(letter);
                            }
                            else
                            {
                                pieces[i] = char.ToLower(letter);
                            }

                            bit++;
                        }
                    }
                    string rollerCoaster = new string(pieces);
                    Console.WriteLine(rollerCoaster);
                }
                    
              
            }

        }
    }
}

