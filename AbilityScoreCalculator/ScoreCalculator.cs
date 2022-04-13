using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreCalculator
{
    class ScoreCalculator
    {
        public int m_rollResult = 14;
        public double m_divideBy = 1.75;
        public int m_addAmount = 2;
        public int m_minimum = 3;
        public int m_score;

        public void CalculatorAbilityScore()
        {
            double m_divided = m_rollResult / m_divideBy;
            /*int m_added = ( m_addAmount = m_addAmount + (int)m_divided);
              也可以寫成: int m_added = m_addAmount += (int)m_divided;
              m_addAmount 也會被賦值為: m_addAmount + (int)m_divided
             這不是我們要的結果，所以要把等號刪掉 */
            int m_added = m_addAmount + (int)m_divided;

            if(m_added < m_minimum)
            {
                m_score = m_minimum;
            }

            else
            {
                m_score = m_added;
            }
        }

    }
}
