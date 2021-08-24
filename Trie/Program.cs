using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie();
            trie.insert("cat");
            trie.insert("car");
            trie.insert("card");
            trie.insert("care");
            trie.insert("careful");
            trie.insert("egg");
            trie.insert("can");

            var words = trie.findWords("car");
            Console.WriteLine(String.Join(", ", words));
            //trie.traverse();
            //Console.WriteLine(trie.contains("ca"));
        }
    }
}
