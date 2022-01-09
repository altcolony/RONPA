using System;
using System.Collections.Generic;

namespace RONPA.Model
{
    public class Claim
    {
        public Claim(
            int id,
            string text,
            IList<Card>cards,
            IList<Remark>remarks)
        {
            Id = id;
            Text = text;
            Cards = cards;
            Remarks = remarks;
        }
        public int Id { get; }
        public string Text { get; }
        public IList<Card> Cards { get; }
        public IList<Remark> Remarks { get;  }
    }
}
