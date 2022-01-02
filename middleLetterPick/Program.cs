using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// 프로그래머스 코딩테스트 연습
// 가운데 글자 가져오기

namespace middleLetterPick
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Solution(string s)
            {
                string answer = "";
                if (s.Length % 2 != 0) // Odd
                {
                    int oddIndex = s.Length / 2;
                    answer += s[oddIndex];
                }
                else // Even
                {
                    int evenIndex = s.Length / 2 - 1;
                    for (int i = 0; i < 2; i++)
                    {
                        answer += s[evenIndex + 1];
                    }
                }
                return answer;
            }

            // Test
            Console.WriteLine(Solution("abcde"));
            Console.WriteLine(Solution("qwer"));
        }
    }
}