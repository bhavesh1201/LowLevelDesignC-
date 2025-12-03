using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.StatergyPattern.FlexiTextFormatterApplication
{
    internal class PlainText : ITextFormatter
    {
        public string formattext(string input)
        {
            return input;
        }
    }
}
