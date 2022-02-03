using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase
{
    public class HypothesisData
    {
        public HypothesisData(
            int id,
            string text,
            int thinkingId,
            DateTime date)
        {
            Id = id;
            Text = text;
            ThinkingId = thinkingId;
            Date = date;
        }
        public int Id { get;  }
        public string Text { get; }
        public int ThinkingId { get; }
        public DateTime Date { get;  }
    }
}
