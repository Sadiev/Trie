using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie();
            trie.insert("cat");
            trie.insert("can");

            Console.WriteLine(trie.contains("ca"));
        }
    }
}
