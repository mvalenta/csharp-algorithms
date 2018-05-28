using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgorithms.DataStructures.trie
{
    public class TrieNode
    {
        public char Character { get; set; }
        public bool IsCompletedWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }

        public TrieNode(char c, bool isCompletedWord = false)
        {
            Character = c;
            IsCompletedWord = isCompletedWord;
            Children = new Dictionary<char, TrieNode>();
        }

        public TrieNode GetChild(char character)
        {
            if (!Children.ContainsKey(character))
            {
                return null;
            }

            return Children[character];
        }

        public TrieNode AddChild(char character, bool isCompleteWord = false)
        {
            if (!Children.ContainsKey(character))
            {
                Children[character] = new TrieNode(character, isCompleteWord);
            }

            return Children[character];
        }

        public bool HasChild(char character)
        {
            return Children.ContainsKey(character);
        }

        public List<char> suggestChildren()
        {
            return Children.Select(x => x.Key).ToList();
        }

        public override string ToString()
        {
            var childrenAsString = string.Join(",", Children.Select(x => x.Key.ToString()).ToArray());
            var IsCompleteString = IsCompletedWord ? "*" : "";
            //c:a,o
            return $"{Character.ToString()}{IsCompleteString}:{childrenAsString}";
        }
    }
}
