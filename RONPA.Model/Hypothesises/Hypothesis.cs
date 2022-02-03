using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.Domain.Hypothesises
{
    public class Hypothesis:IMemo
    {
        public Hypothesis(
            HypothesisId id,
            string text,
            ThinkingId thinkingId,
            DateTime date)
        {
            Id = id;
            Text =text.Length > 500? throw new Exception($"500文字以内で入力して下さい。"):text;
            ThinkingId = thinkingId??throw new Exception("仮説には思考が必須です");
            Date = date;
        }
        public HypothesisId Id { get;  }
        public ThinkingId ThinkingId { get; }
        public string Text { get;private set; }
        public DateTime Date { get;private set; }
        public void ChangeText(string newText)
        {
            if (newText.Length > 500) throw new Exception($"500文字以内で入力して下さい。");
            Text = newText;
        }
        public void ChangeDate(DateTime newDate)
        {
            Date = newDate;
        }
    }
}
