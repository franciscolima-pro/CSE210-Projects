using System;



    public class Assignment
    {
        private string _student;
        private string _topic;
        public Assignment(string student, string topic)
        {
            _student = student;
            _topic = topic;
        }
        public string GetSummary()
        {
            return $"Student: {_student}, Topic: {_topic}";
        }
        public string GetName()
        {
            return $"{_student}";
        }
    
    }

