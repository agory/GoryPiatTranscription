using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transposition
{
    public class Transcription
    {
        private String cleartext; // Decrypted text
        private String cyphertext; // Encrypted Text
        private String myKey; //Key chosen by the user
        private int[] transpoSequence; // Sequence of transposition
        private static char[] ALPHABET = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                      'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'}; //Alphabet to compare

        public static int[] computeTranspoSequence(String myKey)
        {
            int nbChar = 0;
            int sizeTab = myKey.Length;
            int[] myTranspoSequence = new int[sizeTab];
            char currentAlphaChar;
            char currentKeyChar;

            for (int i = 0; i < ALPHABET.Length; ++i)
            {
                currentAlphaChar=ALPHABET[i];
                for (int j = 0; j < myKey.Length; ++j)
                {
                    currentKeyChar = myKey[j];
                    if (currentKeyChar.Equals(currentAlphaChar))
                    {
                        myTranspoSequence[i] = j;
                        nbChar++;
                    }
                }
            }
            return myTranspoSequence;
        }
        /*
        public static int findIndexOfKey(String myKey){
            int index = -1;
            
            return index;
        }
         * */




    }
}
