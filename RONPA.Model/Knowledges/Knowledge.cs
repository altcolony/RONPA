using System;
using System.Collections.Generic;
using System.Linq;

namespace RONPA.Domain.Knowledges
{
    public class Knowledge : IMemo
    {
        public Knowledge(
            KnowledgeId id,
            string text,
            IList<KnowledgeId>knowledgeIds,
            DateTime date)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeIds;
            Date = date;
        }
        public KnowledgeId Id { get; }
        public string Text { get; private set; }
        public IList<KnowledgeId> KnowledgeIds { get; private set; }

        public DateTime Date { get;private set; }

        public void ChangeText(string newText)
        {
            if (newText.Length > 100) throw new Exception($"100文字以内で入力して下さい。");
            Text = newText;
        }
        public void ChangeDate(DateTime newDate) 
        {
            Date = newDate;
        } 
        public bool IsNotSame(KnowledgeId other)
        {
            var tmpKnowledgeIds = new List<KnowledgeId>();
            tmpKnowledgeIds.Add(Id);
            tmpKnowledgeIds.AddRange(KnowledgeIds);
            
            return tmpKnowledgeIds.Any(x => x.Equals(other)) ? throw new Exception("同一の知識は紐づけられません") : true;
        }
        

        public void JoinKnowledge(KnowledgeId id)
        {
            if (KnowledgeIds == null) KnowledgeIds = new List<KnowledgeId>();
            KnowledgeIds.Add(id);
        }
    }
}
