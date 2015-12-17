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

        public Transcription(String cleartext, String myKey)
        {
            this.cleartext = cleartext;
            this.myKey = myKey;
            this.cyphertext="";
        }

        //Compute the number of the columns on the tab.
        public Dictionary<int, int> computeTranspoSequence()
        {
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

        // To compute the tab of chars with number of columns
        public Dictionary<int, String> computeTab(){
            Dictionary<int, String> myTab = new Dictionary<int, String>();
            Dictionary<int, int> myTranspo = computeTranspoSequence();
            int[] orderSequence = new int[0];
            int sizeKey = myKey.Length;
            int sizeClearText = cleartext.Length;
            String oldText = "";
            
            for (int i = 0; i < myKey.Length; ++i)
            {
                myTab.Add((int)myTranspo[i], "");
            }

            for (int i = 0; i < myKey.Length; ++i)
            {
                for (int j = i; j < cleartext.Length; j+=sizeKey)
                {
                    oldText = myTab[myTranspo[i]];
                    myTab[myTranspo[i]] = oldText + cleartext[j]+"";
                }
            }
            return myTab;
        }

        //To compute the cyphertext thanks to the tab of chars computed above.
        //It takes the tab of chars and the key in input.
        public String computeCyphertext(Dictionary<int, String> myTab)
        {
            int sizeOfKey = myKey.Length;
            String cypherText = "";
            for(int i = 0; i < sizeOfKey; ++i)
            {
                cypherText += myTab[i];
            }

            return cypherText;
        }

        //Encryption of the cleartext on input, with the key. Returns a String.
        public String encrypt(){
            this.cyphertext = "";
            Dictionary<int, String> charTab = computeTab();
            this.cyphertext = computeCyphertext(charTab);
            return this.cyphertext;
        }
    }
}

