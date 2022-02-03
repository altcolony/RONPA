using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase
{
    public class KnowledgeData
    {
        public KnowledgeData(
            int id,
            string text,
            IList<int>knowledgeids,
            DateTime date)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeids;
            Date = date;
        }
        public int Id { get; }
        public string Text { get; }
        public IList<int> KnowledgeIds { get; }
        public DateTime Date { get; }
    }
}
