using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Game
    {
        public Frame[] frames { get; set; }

        public int score(int[] rolls)
        {
            int total = 0;
            int strikes = 0;
            for (int i = 0; i < rolls.Length; i++)
            {   
                if (rolls[i] == 10)
                {
                    strikes++;
                    total += rolls[i + 1] + rolls[i+2];
                }
                else if ((i > 0 && (i % 2 == 1 && strikes % 2 == 0)) || 
                    (i > 0 && (i % 2 == 0 && strikes % 2 == 1)))
                {
                    if (rolls[i-1] + rolls[i] == 10 && i + 1 < rolls.Length )
                    {
                        total += rolls[i + 1];
                    }
                }
                total += rolls[i];
            }

            return total;
        }
    }
}