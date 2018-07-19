using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            //throw new NotImplementedException("You need to implement this function.");
            string result = "";
            if (shiftKey < 26 && shiftKey > 0)
            {
                for (int k=0; k<text.Length; k++)
	            {
                    int i = (int)text[k];

                    if(i > 64 && i < 91)
                    {
                        i += shiftKey;
                        if (i > 90 && i < 117)
                        {
                             i = i - 90 + 64;  
                        }
                    }
                    else if (i > 96 && i < 123)
                    {
                        i += shiftKey;
                        if (i > 122 && i < 149)
                        {
                            i = i - 122 + 96;
                        }
                    } 
                    result += (char)i;
	            }
            }

            else if (shiftKey == 0 || shiftKey == 26)
                result = text;

            return result;

        }
    }
}
