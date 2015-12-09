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
        private int lineLenght = 0; // Size of the key
        private int[] transpoSequence; // Sequence of transposition

        public Transcription()
        {
            //Dictionary<int, int> transpo = computeTranspoSequence("ISTIL");
        }
        //public static int[] computeTranspoSequence(String myKey)
        public Dictionary<int, int> computeTranspoSequence(String myKey)
        {
            myKey = "ISTIL";
            int nbChar = 0;
            int sizeTab = myKey.Length;
            //int[] myTranspoSequence = new int[sizeTab];
            Dictionary<int, int> transpoSequence = new Dictionary<int, int>();
            char currentAlphaChar;
            char currentKeyChar;
            int currentValueChar = 0;
            int maxValueChar = 0;
            int minValueChar = 1000;
            int indexOfKey = 0;
            int rankOfKey = 0;

            for (int j = 0; j < myKey.Count(); ++j)
            {
                for (int i = 0; i < myKey.Count(); ++i)
                {
                    currentValueChar = Convert.ToInt16(myKey[i]);
                    if ((currentValueChar < minValueChar) && !transpoSequence.ContainsKey(i))
                    {
                        minValueChar = currentValueChar;
                        indexOfKey = i;
                    }
                }
                transpoSequence.Add(indexOfKey, rankOfKey);
                rankOfKey++;
                minValueChar = 1000;
            }
            return transpoSequence;




            /*for (int i = 0; i < ALPHABET.Length; ++i)
            {
                currentAlphaChar=ALPHABET[i];
                for (int j = 0; j < myKey.Length; ++j)
                {
                    currentKeyChar = myKey[j];
                    if (currentKeyChar.Equals(currentAlphaChar)&&(nbChar==0))
                    {
                        myTranspoSequence[j] = i;
                        nbChar++;
                    }
                    else if (currentKeyChar.Equals(currentAlphaChar))
                    {
                        myTranspoSequence[j] = i+1;
                    }
                }
            }*/
            //return myTranspoSequence;
        }
        /*
        public static int findIndexOfKey(String myKey){
            int index = -1;
            
            return index;
        }
         * */




    }
}
