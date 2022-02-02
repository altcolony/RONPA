using System;
using System.Collections.Generic;
using RONPA.Domain.Knowledges;
using RONPA.Domain.Thinkings;

namespace RONPA.Domain.Claims
{
    public class Claim:IMemo
    {
        public Claim(
            ClaimId id,
            string text,
            IList<KnowledgeId>knowledgeIds,
            ThinkingId thinkingId,
            DateTime date)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeIds??throw new Exception("null");
            ThinkingId = thinkingId??throw new Exception("null");
            Date = date;
        }
        public ClaimId Id { get; }
        public string Text { get; private set; }
        public IList<KnowledgeId> KnowledgeIds { get; }
        public ThinkingId ThinkingId { get; }
        public DateTime Date { get;private set; }

        public void ChangeText(string newText)
        {
            if (newText.Length > 1000) throw new Exception($"1000文字以内で入力して下さい。");
            Text = newText;
        }
        public void ChangeDate(DateTime newDate)
        {
            Date = newDate;
        }
        public bool IsGenerate()
        {
            if (KnowledgeIds.Count >= 1) return true;
            throw new Exception("知識は1つ以上必要です。");
            
        }
        public void RemoveKnowledge(KnowledgeId removeId)
        {
            KnowledgeIds.Remove(removeId);
            if (KnowledgeIds.Count == 0) throw new Exception("知識は1つ以上必要です。");
        }
        
        
    }
}
