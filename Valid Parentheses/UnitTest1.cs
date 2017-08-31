using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Valid_Parentheses
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Parentheses.ValidParentheses(")(((("));
        }
    }
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            var stack = new Stack<int>();
            foreach (var c in input)
            {
                if (c == '(')
                    stack.Push(1);
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    stack.Pop();
                }
            } 
            return !stack.Any();
        }
    }
}
