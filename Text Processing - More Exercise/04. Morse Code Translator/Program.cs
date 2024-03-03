using System;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morse = Console.ReadLine().Split(" | ",StringSplitOptions.RemoveEmptyEntries);
            string decryption = string.Empty;
            foreach (var item in morse)
            {
                string[] current = item.Split();
                foreach (var IntoCurr in current)
                {
                    if (IntoCurr.Length==1)
                    {
                        if (IntoCurr[0] == '.')
                        {
                            decryption += "E";
                        }
                        else if(IntoCurr[0] == '-')
                        {
                            decryption += "T";
                        }
                    }
                    else if (IntoCurr.Length == 2)
                    {
                        if (IntoCurr[0] == '.')
                        {
                            if (IntoCurr[1] == '.')
                            {
                                decryption += "I";
                            }
                            else if (IntoCurr[1] == '-')
                            {
                                decryption += "A";
                            }
                        }
                        else if (IntoCurr[0] == '-')
                        {
                            if (IntoCurr[1] == '.')
                            {
                                decryption += "N";
                            }
                            else if (IntoCurr[1] == '-')
                            {
                                decryption += "M";
                            }
                        }
                    }
                    else if(IntoCurr.Length == 3)
                    {
                        if (IntoCurr[0] == '.') //.
                        {
                            if (IntoCurr[1] == '.') //..
                            {
                                if (IntoCurr[2] == '.') //...
                                {
                                    decryption += "S";
                                }
                                else if (IntoCurr[2] == '-') //..-
                                {
                                    decryption += "U";
                                }
                            }
                            else if (IntoCurr[1] == '-')//.-
                            {
                                if (IntoCurr[2] == '.')//.-.
                                {
                                    decryption += "R";
                                }
                                else if (IntoCurr[2] == '-')//.--
                                {
                                    decryption += "W";
                                }
                            }
                        }
                        else if (IntoCurr[0] == '-')//-
                        {
                            if (IntoCurr[1] == '.')//-.
                            {
                                if (IntoCurr[2] == '.')//-..
                                {
                                    decryption += "D";
                                }
                                else if (IntoCurr[2] == '-')//-.-
                                {
                                    decryption += "K";
                                }
                            }
                            else if (IntoCurr[1] == '-')//--
                            {
                                if (IntoCurr[2] == '.')//--.
                                {
                                    decryption += "G";
                                }
                                else if (IntoCurr[2] == '-')//---
                                {
                                    decryption += "O";
                                }
                            }
                        }
                    }
                    else if(IntoCurr.Length == 4)
                    {
                        if (IntoCurr[0] == '.') //.
                        {
                            if (IntoCurr[1] == '.') //..
                            {
                                if (IntoCurr[2] == '.') //...
                                {
                                    if (IntoCurr[3] == '.')//....
                                    {
                                        decryption += "H";
                                    }
                                    else if (IntoCurr[3] == '-')//...-
                                    {
                                        decryption += "V";
                                    }
                                }
                                else if (IntoCurr[2] == '-') //..-
                                {
                                    if (IntoCurr[3] == '.')//..-.
                                    {
                                        decryption += "F";
                                    }
                                }
                            }
                            else if (IntoCurr[1] == '-')//.-
                            {
                                if (IntoCurr[2] == '.')//.-.
                                {
                                    if (IntoCurr[3] == '.')//.-..
                                    {
                                        decryption += "L";
                                    }
                                }
                                else if (IntoCurr[2] == '-')//.--
                                {
                                    if (IntoCurr[3] == '.')//.--.
                                    {
                                        decryption += "P";
                                    }
                                    else if (IntoCurr[3] == '-')//.---
                                    {
                                        decryption += "J";
                                    }
                                }
                            }
                        }
                        else if (IntoCurr[0] == '-')//-
                        {
                            if (IntoCurr[1] == '.')//-.
                            {
                                if (IntoCurr[2] == '.')//-..
                                {
                                    if (IntoCurr[3] == '.')//-..-
                                    {
                                        decryption += "X";
                                    }
                                    else if (IntoCurr[3] == '-')//-...
                                    {
                                        decryption += "B";
                                    }
                                }
                                else if (IntoCurr[2] == '-')//-.-
                                {
                                    if (IntoCurr[3] == '.')//-.-.
                                    {
                                        decryption += "C";
                                    }
                                    else if (IntoCurr[3] == '-')//-.--
                                    {
                                        decryption += "Y";
                                    }
                                }
                            }
                            else if (IntoCurr[1] == '-')//--
                            {
                                if (IntoCurr[2] == '.')//--.
                                {
                                    if (IntoCurr[3] == '.')//--..
                                    {
                                        decryption += "Z";
                                    }
                                    else if (IntoCurr[3] == '-')//--.-
                                    {
                                        decryption += "Q";
                                    }
                                }
                            }
                        }
                    }
                }
                decryption += " ";
            }
            Console.WriteLine(decryption);
        }
    }
}
