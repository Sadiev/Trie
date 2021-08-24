using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace Trie
{
    class Trie
    {
        public const int ALPHABET_SIZE= 26;
        private class Node {
            public Node(char value)
            {
                Value = value;
            }
            public char Value { get; set; }
            public Dictionary<char, Node> children { get; set; } = new Dictionary<char, Node>();
            public bool isEndOfWord { get; set; }
        }

        private Node Root { get; set; } = new Node(' ');

        public void insert(string word) {
            var current = Root;
            foreach (char ch in word)
            {
                if (!current.children.ContainsKey(ch))
                {
                    current.children[ch] = new Node(ch);
                }
                current = current.children[ch];
            }
            current.isEndOfWord = true;
        }

        public bool contains(string word) {
            if (String.IsNullOrEmpty(word))
            {
                return false;
            }
            var current = Root;
            foreach (var ch in word)
            {
                if (!current.children.ContainsKey(ch))
                    return false;
                current = current.children[ch];
            }
            return current.isEndOfWord;
        }
    }
}
