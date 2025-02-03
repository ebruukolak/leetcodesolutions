using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    /// <summary>
    /// Given a string s containing just the characters
    /// '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// 
    /// An input string is valid if:
    /// 
    /// 1.Open brackets must be closed by the same type of brackets.
    /// 2.Open brackets must be closed in the correct order.
    /// 3.Every close bracket has a corresponding open bracket of the same type.
    /// 
    /// </summary>
    public class ValidParentheses
    {

        public bool IsValid(string s)
        {

            var parantheses = s.ToCharArray();

            var paranthesePairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var openParantheses = new List<char> { '(', '{', '[' };
            var closeParantheses = new List<char> { ')', '}', ']' };

            var bracekets = new List<char>();
            bool isValid = false;

            for (int i = 0; i < parantheses.Length; i++)
            {
                if (openParantheses.Contains(parantheses[i]))
                {
                    bracekets.Add(parantheses[i]);
                }

                if (closeParantheses.Contains(parantheses[i]))
                {
                    if (bracekets.Count > 0)
                    {
                        if (paranthesePairs.ContainsKey(bracekets[bracekets.Count - 1]))
                        {
                            var value = paranthesePairs[bracekets[bracekets.Count - 1]];
                            if (value == parantheses[i])
                            {

                                bracekets.RemoveAt(bracekets.Count - 1);
                                isValid = true;
                            }
                            else
                            {
                                isValid = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if (bracekets.Count > 0)
            {
                isValid = false;
            }
            return isValid;
        }



        public bool IsValidWithStack(string s)
        {
            var stack = new Stack<char>();

            var paranthesePairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (var ch in s)
            {
                if (paranthesePairs.ContainsKey(ch))
                {
                    stack.Push(ch);
                }
                else if (paranthesePairs.ContainsValue(ch))
                {
                    if (stack.Count == 0 || paranthesePairs[stack.Pop()] != ch)
                        return false;
                }
            }


            return stack.Count == 0;
        }
    }
}
