using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

    public class MathAssignment :  Assignment
    {
        private string _textBookSection = "";

        private string _problems = "";

        public MathAssignment(string name, string topic, string section, string probs) 
            : base(name, topic)
        {

            _textBookSection = section;
            _problems = probs;
        }

        public string GetHomeworkList()
        {
            return $"Section: {_textBookSection} \nProblems: {_problems}";
        }
    }
