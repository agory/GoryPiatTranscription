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
        public static Dictionary<int, int> computeTranspoSequence(String myKey)
        {
            myKey = "ISTIL";
            int sizeTab = myKey.Length;
            Dictionary<int, int> transpoSequence = new Dictionary<int, int>();
            int currentValueChar = 0;
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
        }

        public static Dictionary<int, String> computeTab(String clearText, String myKey){
            Dictionary<int, String> myTab = new Dictionary<int, String>();
            Dictionary<int, int> myTranspo = computeTranspoSequence(myKey);
            int[] orderSequence = new int[0];
            int sizeKey = myKey.Length;
            int sizeClearText = clearText.Length;
            String oldText = "";
            
            for (int i = 0; i < myKey.Length; ++i)
            {
                myTab.Add((int)myTranspo[i], "");
            }

            for (int i = 0; i < myKey.Length; ++i)
            {
                for (int j = i; j < clearText.Length; j+=sizeKey)
                {
                    oldText = myTab[myTranspo[i]];
                    myTab[myTranspo[i]] = oldText + clearText[j]+"";
                }
            }
                
                return myTab;
        }

        public static String computeCyphertext(Dictionary<int, String> myTab, String myKey)
        {
            int sizeOfKey = myKey.Length;
            String cypherText = "";
            for(int i = 0; i < sizeOfKey; ++i)
            {
                cypherText += myTab[i];
            }

            return cypherText;
        }

        public static String encrypt(String clearText, String myKey){
            String cypherText = "";
            Dictionary<int, String> charTab = computeTab(clearText, myKey);
            cypherText = computeCyphertext(charTab, myKey);
            return cypherText;
    }
    }
}
