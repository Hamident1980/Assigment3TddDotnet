using System.Text;

namespace Assignment3Dotnet
{
    public class StringCompressor
    {
        
        public string Compress(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            StringBuilder compressed = new StringBuilder();
            int count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    compressed.Append(str[i - 1]).Append(count);
                    count = 1;
                }
            }
            compressed.Append(str[^1]).Append(count);

            return compressed.Length < str.Length ? compressed.ToString() : str;
        }

        
        public string Decompress(string compressedStr)
        {
            if (string.IsNullOrEmpty(compressedStr)) return compressedStr;

            StringBuilder decompressed = new StringBuilder();
            for (int i = 0; i < compressedStr.Length; i++)
            {
                char ch = compressedStr[i];

              
                if (i + 1 < compressedStr.Length && char.IsDigit(compressedStr[i + 1]))
                {
                    int j = i + 1;
                    StringBuilder countStr = new StringBuilder();

                   
                    while (j < compressedStr.Length && char.IsDigit(compressedStr[j]))
                    {
                        countStr.Append(compressedStr[j]);
                        j++;
                    }

                    int count = int.Parse(countStr.ToString());
                    decompressed.Append(ch, count);
                    i = j - 1; 
                }
                else
                {
                    
                    decompressed.Append(ch);
                }
            }
            return decompressed.ToString();
        }
    }
}


