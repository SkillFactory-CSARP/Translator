using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    public class TranslateService
    {
        public Dictionary<string, string> _translation;

        public TranslateService()
        {
            _translation = new Dictionary<string, string>();
            _translation.Add("dog", "собака");
            _translation.Add("cat", "кошка");
        }

        public void AddTranslation(string oneWord, string secondWord)
        {
            _translation.Add(oneWord, secondWord);
        }

        public string GetTranslation(string word)
        {
            return _translation[word];
        }
    }
}
