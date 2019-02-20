using System;
using System.Collections.Generic;

namespace CollectionTesting
{
    public class MyStringCollection
    {
        private List<string> listops;


        public void Add(string word)
        {
            listops.Add(word);
        }

        public bool Contains(string word)
        {
            return listops.Contains(word);
        }

        public void Remove(string word)
        {
            listops.Remove(word);
        }

        public void RemoveEmpty()
        {
            while(listops.Contains(""))
            {
                listops.Remove("");
            }
        }

        public string ShowSentence()
        {
            string temp = "";
            foreach (var item in listops)
            {
                temp = temp + item;
            }
            return temp;
        }

    }
}
