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

        public static string Incript1(string userfile)
        {
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
