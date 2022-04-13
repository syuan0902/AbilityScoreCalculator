using System;

namespace AbilityScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreCalculator m_scoreCalculator = new ScoreCalculator();

            while(true)
            {

                m_scoreCalculator.m_rollResult = 
                    ReadInt(m_scoreCalculator.m_rollResult, "六面骰子擲4次並加總");

                m_scoreCalculator.m_divideBy = 
                    ReadDouble(m_scoreCalculator.m_divideBy, "將結果除以");
                
                m_scoreCalculator.m_addAmount = 
                    ReadInt(m_scoreCalculator.m_addAmount, "再加上");
          
                m_scoreCalculator.m_minimum = 
                    ReadInt(m_scoreCalculator.m_minimum, "最小值");

                m_scoreCalculator.CalculatorAbilityScore();

                Console.WriteLine("能力值: " + m_scoreCalculator.m_score);
                Console.WriteLine("按Q離開，或按其他鍵繼續。");

                char m_keyChar = Console.ReadKey(true).KeyChar;

                if ((m_keyChar == 'Q') || (m_keyChar == 'q')) return;

            }
        }

        static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " ["+ lastUsedValue + " ]:");
            string m_customInput = Console.ReadLine();
            if (double.TryParse(m_customInput, out double value))
            {
                Console.WriteLine("    使用輸入數值" + value);
                return value;
            }

            else
            {
                Console.WriteLine("    使用預設值" + lastUsedValue);
                return lastUsedValue;
            }
        }
        /// <summary>
        /// 寫入一個提示，並且從主控台讀取一個int值
        /// </summary>
        /// <param name="lastUsedValue">預設值</param>
        /// <param name="prompt">要印到主控台的提示</param>
        /// <returns>讀取的int值，或者當無法轉換時，使用預設值</returns>
        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string m_customInput = Console.ReadLine();
            if(int.TryParse(m_customInput, out int value))
            {
                Console.WriteLine("    使用輸入數值" + value);
                return value;
            }

            else
            {
                Console.WriteLine("    使用預設值" + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
