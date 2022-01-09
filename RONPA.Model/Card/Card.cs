﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Model
{
    public class Card
    {
        public Card(int id,  string text)
        {
            Id = id;
            Text = text;
        }
        public int Id { get; }
        public string Text { get; private set; }

        public void EditText(string text)
        {
            Text = text;
        }
    }
}
