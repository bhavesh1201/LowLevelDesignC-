using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.StatergyPattern.FlexiTextFormatterApplication.FormatterService
{
    internal class FormatterServuce
    {
        public ITextFormatter frm;
        public string text;

        public void SetText(string txt)
        {
            text = txt;
        }
        public void SetTextFormat(ITextFormatter fmt)
        {
            frm = fmt;
        }
        public void Formattext()
        {
         //   frm.formattext(text);
            Console.WriteLine(frm.formattext(text));
        }
    }
}
