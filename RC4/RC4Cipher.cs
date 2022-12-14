using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4
{
    internal class RC4Cipher
    {
        int[] S = new int[256];
        int x = 0;
        int y = 0;
        public RC4Cipher(char[] key)
        {
            init(key);
        }
        private void Swap(int index1, int index2)
        {
            int temp = S[index1];
            S[index1] = S[index2];
            S[index2] = temp;
        }
        private void init(char[] key)
        {
            int keyLength = key.Length;

            for (int i = 0; i < 256; i++)
            {
                S[i] = (int)i;
            }

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + (int)key[i % keyLength]) % 256;
                Swap(i, j);
            }
        }
        private int keyItem()
        {
            x = (x + 1) % 256;
            y = (y + S[x]) % 256;

            Swap(x, y);

            return S[(S[x] + S[y]) % 256];
        }
        public char[] Encode(char[] dataB, int size)
        {
            char[] data = dataB.Take(size).ToArray();

            char[] cipher = new char[data.Length];

              for (int m = 0; m < data.Length; m++)
              {       
                cipher[m] = (char)((int)data[m] ^ keyItem());
              }

              return cipher;
        }
    }
}
