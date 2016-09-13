namespace _04_Pig_Latin
{
    internal class Translator
    {
        public string Translate(string s)
        {
            string[] a = s.Split(' ');
            int i = 0;
            string res = "";
            foreach (string item in a)
            {

                if (item.Contains("qu"))
                {
                    i = CheckForQu(item);
                }
                else
                {
                    i = CheckForCharsBeforeVowel(item);
                }

                if (i == 0)
                {
                    res = res + " " + item + "ay";
                }
                else
                {
                    res = res + " " + item.Substring(i) + item.Substring(0, i) + "ay";
                }
            }

            return res.TrimStart();

        }

        public int CheckForQu(string s)
        {
            int i = 1;
            foreach (char c in s)
            {
                if (c == 'u')
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }

        public int CheckForCharsBeforeVowel(string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                bool isVowel = "aeiouAEIOU".IndexOf(c) >= 0;
                if (isVowel)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }

    }
}