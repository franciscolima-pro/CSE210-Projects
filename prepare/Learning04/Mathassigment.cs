using System;


    class mathAssignment
    {
        private string _textBook;
        private string _problems;
        public mathAssignment(string textBook, string problems)
        {
            _textBook = textBook;
            _problems = problems;
        }
        public string GetWorkHomeList()
        {
            return $"Section: {_textBook} Problems: {_problems}";
        }
    }
