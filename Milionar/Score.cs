﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionar
{
    class Score
    {
        public int RightAnswers { get; set; }
        public int Money { get; set; }
        public string Name { get; set; }

        public Score(int rightAnswes, int money)
        {
            this.Money = money;
            this.RightAnswers = rightAnswes;
        }
    }
}
