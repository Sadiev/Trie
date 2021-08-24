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
            trie.traverse();
            Console.WriteLine(trie.contains("ca"));
        }
    }
}
