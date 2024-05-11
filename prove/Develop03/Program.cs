using System;
using System.Collections.Generic;

class Program
{
    public class Scripture
    {
        private List<ManageWord> _words = new List<ManageWord>();
        private Reference _reference;
        private List<int> _hiddenIndices = new List<int>();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            InitWords(text);
        }

        private void InitWords(string text)
        {
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                _words.Add(new ManageWord(word));
            }
        }

        public void HideRandomWord(int numberToHide)
        {
            Random random = new Random();
            while (_hiddenIndices.Count < numberToHide)
            {
                int index = random.Next(_words.Count);
                if (!_hiddenIndices.Contains(index))
                {
                    _hiddenIndices.Add(index);
                }
            }
        }

        public string GetDisplayText()
        {
            string displayText = $"{_reference.GetDisplayText()}\n";
            for (int i = 0; i < _words.Count; i++)
            {
                if (_hiddenIndices.Contains(i))
                {
                    displayText += new string('_', _words[i].Text.Length) + " ";
                }
                else
                {
                    displayText += _words[i].Text + " ";
                }
            }
            return displayText;
        }

        public bool CanHideWords(int numberToHide)
        {
            return _hiddenIndices.Count + numberToHide <= _words.Count;
        }

        public bool IscompletelyHidden()
        {
            return _hiddenIndices.Count == _words.Count;
        }

        public void ClearHiddenWords()
        {
            _hiddenIndices.Clear();
        }
    }

    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            if (_endVerse == 0)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
        }
    }

    public class ManageWord
    {
        public string Text { get; }
        public ManageWord(string text)
        {
            Text = text;
        }
    }

    static void Main(string[] args)
    {
        Reference reference = new Reference("Jhon", 3, 16);
        Scripture scripture = new Scripture(reference, "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.");

        const int wordsToHidePerTurn = 2;

        while (!scripture.IscompletelyHidden())
        {
            if (!scripture.CanHideWords(wordsToHidePerTurn))
            {
                break;
            }

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press 'Enter' to hide more words or 'quit' to exit!");
            string input = Console.ReadLine();

            scripture.HideRandomWord(wordsToHidePerTurn);
            Console.Clear();

            if (input.ToLower() == "quit")
            {
                break;
                //scripture.ClearHiddenWords(); // Limpa os índices de palavras ocultas para ocultar novas palavras
            }
            else
            {
                Console.WriteLine("Invalid Input, press 'Enter'");
            }
        }
    }
}