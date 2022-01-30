using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain
{
    public interface IMemo
    {
        public string Text { get; }
        public void ChangeText(string newText);
    }
}
