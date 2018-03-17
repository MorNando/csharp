using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    class indexer
    {
        private readonly Dictionary<string, string> _dic = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return _dic[key]; }
            set { _dic[key] = value; }
        }

        public indexer(string name, string value)
        {
            _dic[name] = value;

        }


            
    }
}
