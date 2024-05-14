using System;



    public class WritingAssignment
    {
        private string _title;
        public WritingAssignment(string title)
        {
            _title = title;
        }
        public string GetInfo()
        {
            return $"{_title}";
        }
    }
