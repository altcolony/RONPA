using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain
{
    public class Thinking:IMemo
    {
        public Thinking(ThinkingId id,string text)
        {
            Id = id;
            Text = text;
        }
        public ThinkingId Id { get; }
        public string Text { get;private set; }
       
        public void ChangeText(string newText)
        {
            if (newText.Length > 300) throw new Exception($"300文字以内で入力して下さい。");
            Text = newText;
        }
        public bool IsNotSame(ThinkingId other)
        {
            return this.Id.Value == other.Value ? throw new Exception("同一の思考は紐づけられません") : true;
        }
    }
}
