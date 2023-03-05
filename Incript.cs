using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Incripter1._1
{
    /// <summary>
    /// Script which encodes the text file
    /// </summary>

    class Incript
    {
        private static string textToConvert;
        private static string incodedText;

        private static char[] alfabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        private static char[] characters = new char[] { '☥', '⁋', '☭', '♢', '©', '⚐', '⍾', '⟰', '☪', '₿', '⊜', '⅊', '☽', '☨', '☃', '☮', '♔', '☢', '☼', '♜', '⚸', '∀', '☸', '⁜', '☯', '∻' };

        
        //idea for encripton identification with tuple/dictionary for enconding
        /*minValue would be = | (int)Math.Round(userFile.Lenght / 5) + 1 |
        -exemple: 70char text to encript 74/5=14.8, cast int(14.2) = 14, and at string.index 14 we would start the sypher-*/
        private static (string, int)[] KeyIndexPair = new (string, int)[] { ("<%#´Key`#%>", minValue), ("<#--&__Key__&--#>", minValue) };
        //not implemented
        
        private static string[] TrypleCombinationValue = new string[] { "aaa", "bbb", "ccc", "ddd" };
        private static string[] CapsVarientTrypleCombinationValue = new string[] { "yyT", "aPw", "fhD", "LkE" };
        private static string[] MaxCharValue = new string[] { "0", "266", "2 766", "12 766", "32 766" };
        //not implemented
        
        public static string Incript(string userFile, int randomMethod)
        {
            if(string.IsNullOrEmpty(userFile))
                throw new Excepetion("Failed to get text file string!");
            
            switch (randomMethod)
            {
                case 1:
                    processedFile = Incript1(text);
                    break;
                case 2:
                    processedFile = Incript2(text);
                    break;
                case 3:
                    processedFile = Incript3(text);
                    break;
                default:
                    //throw new Excepetion("Failed to find the right method!");
            }
            
            
            return processedFile;
        }
        
        public static string Incript1(string userfile/*, string replace*/)
        {
            //selfConfiguring value with caracteristic rules
            //for (int r = 0; r < userfile.Lenght; r + (userfile.Lenght/(const /*constant value derivied from information of the string (lenght, bit size, byte size, (pi - a percentage of the lenght, number os letter "a" in the string), distance to the sun in km, etc...)*/));)
            //{
                //userfile = userfile.Replace(replace, (replace.Lenth) * userfile.Size());
            //}
            
            textToConvert = userfile;
            textToConvert = textToConvert.Replace('a', '§').Replace(' ', '£');

            for (int i = 1; i <= 25; i++)
            {
               textToConvert = textToConvert.Replace(alfabet[i], alfabet[i-1]);
            }

            incodedText = textToConvert.Insert(0, "<INT1>");

            return incodedText;
        }

        public static string Incript2(string userfile)
        {
            textToConvert = userfile;
            textToConvert = textToConvert.Replace('ç', '⁂').Replace('ã', '⌕').Replace('é', '⍣').Replace('ê', '⏢');
            textToConvert = textToConvert.Replace(' ', '☺').Replace('.', '⟁').Replace(',', '⦚').Replace('?', '⏚');

            for (int i = 0; i <= 25; i++)
            {
                textToConvert = textToConvert.Replace(alfabet[i], characters[i]);
            }

            incodedText = textToConvert.Insert(0, "<INT2>");

            return incodedText;
        }

        public static string Incript3(string userfile)
        {
            textToConvert = userfile;
            textToConvert = textToConvert.Replace(' ', '☺').Replace('.', '⟁').Replace(',', '⦚').Replace('?', '⏚');

            int j = 25;
            for (int i = 0; i <= 25; i++)
            {
                textToConvert = textToConvert.Replace(alfabet[i], characters[j]);
                j--;
            }
            
            incodedText = textToConvert.Insert(0, "<INT3>");

            return incodedText;
        }
    }
}
