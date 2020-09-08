using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples
{
    class StringOperations
    {
        public static string ReverseSentence(string sentence)
        {
            string word = "";

            Stack<string> st = new Stack<string>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    st.Push(word);
                    word = "";
                }
                else
                {
                    word += sentence[i];
                }

                if (i == sentence.Length - 1)
                {
                    st.Push(word);
                }
            }

            StringBuilder sb = new StringBuilder();

            int stl = st.Count;

            for (int i = 0; i < stl; i++)
            {
                sb.Append(st.Pop());
                sb.Append(' ');
            }

            return sb.ToString();
        }
    }
}
