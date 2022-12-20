using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public interface TextInt
    {
        string Text { get; set; }
    }
    public class Class1 : TextInt
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private Class1Clone original = new Class1Clone();
        public Class1Clone Original
        {
            get { return original; }
            set { original = value; }
        }
        public void Revert()
        {
            this.Text = Original.Text;
        }
        public Boolean IsModified()
        {
            return !(this.Text.Equals(Original.Text));
        }
    }

    public class Class1Clone : TextInt
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
