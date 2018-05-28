using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.DataStructures.trie
{
    public class Trie
    {
        const char HEAD_CHARACTER = '*';
        public TrieNode Head { get; set; }
        public Trie ()
        {
            Head = new TrieNode(HEAD_CHARACTER);
        }

        public void AddWord(string word)
        {
            var characters = word.ToCharArray();
            var currentNode = Head;
            for (var charIndex = 0; charIndex < characters.Length; charIndex += 1)
            {
                var isComplete = charIndex == characters.Length - 1;
                currentNode = currentNode.AddChild(characters[charIndex], isComplete);
            }
        }

        public List<char> SuggestNextCharacters(string word)
        {
            var lastCharacter = GetLastCharacterNode(word);

            if (lastCharacter == null)
            {
                return null;
            }

            return lastCharacter.suggestChildren();
        }

        public bool DoesWordExist(string word)
        {
            return GetLastCharacterNode(word) == null;
        }

        public TrieNode GetLastCharacterNode(string word)
        {
            var characters = word.ToCharArray();
            var currentNode = Head;
            for (var charIndex = 0; charIndex < characters.Length; charIndex += 1)
            {
                if (!currentNode.HasChild(characters[charIndex]))
                {
                    return null;
                }
                currentNode = currentNode.GetChild(characters[charIndex]);
            }

            return currentNode;
        }
    }
}
