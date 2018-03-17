using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    class Calculator
    {
        private int _result = 0;
        public List<int> ToAdd{get; set; }

        public int Add
        {
            get{
                foreach (var number in ToAdd)
                    _result = _result + number;
                return _result;
            }
        }
    }
}
