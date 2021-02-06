using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Incripter1._1
{
    /// <summary>
    /// Script which decodes the encrypted text file
    /// </summary>

    class Decript
    {
        private static string textToConvert;
        private static string decodedText;

        private static char[] alfabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static char[] characters = new char[] { '☥', '⁋', '☭', '♢', '©', '⚐', '⍾', '⟰', '☪', '₿', '⊜', '⅊', '☽', '☨', '☃', '☮', '♔', '☢', '☼', '♜', '⚸', '∀', '☸', '⁜', '☯', '∻' };


        public static string CheckIncript(string userFile)
        {
            //another way of finding the incripted code by the end of the text
            //if (userFile.EndsWith("<INT1>"))
            if (userFile.StartsWith("<INT1>"))
            {
                decodedText = Decript1(userFile);
            }
            if (userFile.StartsWith("<INT2>"))
            {
                decodedText = Decript2(userFile);
            }
            if (userFile.StartsWith("<INT3>"))
            {
                decodedText = Decript3(userFile);
            }

            return decodedText;
        }

        public static string Decript1(string userFile)
        {
            textToConvert = userFile;

            textToConvert = textToConvert.Replace("<INT1>", "");
            
            for (int i = 24; i >= 0; i--)
            {
                textToConvert = textToConvert.Replace(alfabet[i], alfabet[i + 1]);
            }

            decodedText = textToConvert.Replace('§', 'a').Replace('£', ' ');

            return decodedText;
        }

        public static string Decript2(string userFile)
        {
            textToConvert = userFile;

            textToConvert = textToConvert.Replace("<INT2>", "");
            
            for (int i = 0; i <= 25; i++)
            {
                textToConvert = textToConvert.Replace(characters[i], alfabet[i]);
            }

            textToConvert = textToConvert.Replace('⁂', 'ç').Replace('⌕', 'ã').Replace('⍣', 'é').Replace('⏢', 'ê');
            decodedText = textToConvert.Replace('☺', ' ').Replace('⟁', '.').Replace('⦚', ',').Replace('⏚', '?');

            return decodedText;
        }

        public static string Decript3(string userFile)
        {
            textToConvert = userFile;

            textToConvert = textToConvert.Replace("<INT3>", "");

            int j = 0;
            for (int i = 25; i >= 0; i--)
            {
                textToConvert = textToConvert.Replace(characters[j], alfabet[i]);
                j++;
            }

            decodedText = textToConvert.Replace('☺', ' ').Replace('⟁', '.').Replace('⦚', ',').Replace('⏚', '?');

            return decodedText;
        }
    }
}
