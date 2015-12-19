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

        public Transcription(String myKey)
        {
            this.cleartext = "";
            this.myKey = myKey;
            this.cyphertext="";
        }

        //Compute the number of the columns on the tab.
        private Dictionary<int, int> computeTranspoSequence()
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
        private Dictionary<int, String> computeTab(){
            Dictionary<int, String> myTab = new Dictionary<int, String>();
            Dictionary<int, int> myTranspo = computeTranspoSequence();
            int[] orderSequence = new int[0];
            int sizeKey = myKey.Length;
            int sizeClearText = cleartext.Length;
            String oldText = "";
            

            for (int i = 0; i < myKey.Length; ++i)
            {
                myTab.Add((int)myTranspo[i], "");
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
        private String computeCyphertext(Dictionary<int, String> myTab)
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
        public String encrypt(String cleartext)
        {
            this.cleartext = cleartext;
            this.cyphertext = "";
            Dictionary<int, String> charTab = computeTab();
            this.cyphertext = computeCyphertext(charTab);
            return this.cyphertext;
        }

        //Encryption of the cleartext on input, with the key. Returns a String.
        public String decrypt(String cyphertext)
        {
            this.cleartext = "";
            this.cyphertext = cyphertext;
            Dictionary<int, String> charTab = computeDecryptionTab();
            this.cleartext = computeCleartext(charTab);
            return this.cleartext;
        }
        // To compute the tab of chars with number of columns
        private Dictionary<int, String> computeDecryptionTab()
        {
            Dictionary<int, String> myTab = new Dictionary<int, String>();
            Dictionary<int, int> myTranspo = computeTranspoSequence();
            int[] orderSequence = new int[0];
            int addchar = cyphertext.Length % myKey.Length;
            if(addchar > 0) { 
            for (int i =0; i < addchar; i++) {
                cyphertext += ' ';
            }
            }
            int sizeTab = sizeTab = cyphertext.Length / myKey.Length;           
            
            int index = 0;
            for (int i = 0; i < myTranspo.Count; i++)
            {
                myTab.Add((int)myTranspo[index], "");
                for (int i2 = i* sizeTab; (i2 < (i+1)*sizeTab && i2 < cyphertext.Length);i2++) {
                    myTab[myTranspo[index]] += cyphertext[i2];
                }
                index++;
            }
            return myTab;
        }
        //To compute the cyphertext thanks to the tab of chars computed above.
        //It takes the tab of chars and the key in input.
        private String computeCleartext(Dictionary<int, String> myTab)
        {
            int sizeTab = 0;
            if (cyphertext.Length % myKey.Length == 0)
            {
                sizeTab = cyphertext.Length / myKey.Length;
            }
            else
            {
                sizeTab = (int)Math.Ceiling((decimal)(cyphertext.Length / myKey.Length)) + 1;
            }
            int sizeOfKey = myKey.Length;
            String clearText = "";

            for (int i = 0; i < sizeTab; ++i)
            {
                for (int i2 = 0; i2 < sizeOfKey; ++i2)
                {
                    clearText += myTab[i2][i];                  
                }                    
            }
            return clearText;
        }
    }

}