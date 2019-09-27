using System;
using System.Collections;

namespace Algorithms_DS.Strings
{
    #region Problem
     //Evaluate given mathematical expression in string format. 
     //Calculate total value of the expression based on the depth of the Parenthesis "(" multipy the numbers in parenthesis with its depth of occurrence of "("  in the expression.
     //Example 1: (12(34)(5)(6)(()))
     // It should evaluate to (1+2) * 1 = 3, (3+4) * 2 = 14, 5 * 2 = 10, 6 * 2 = 12 and the total = 3+14+10+12 = 39
     //Example 2: (2 3 (4 5 1) (6) ((1))  ()). It should evaluate to (2+3) * 1 = 5, (4+5+1) * 2 = 20, 6 * 2 = 12, 1 * 3 = 3 and the total = 5+20+12+3 =40
     //For execution: (copy and paste below code in Main method)
    // var exp = new EvaluateMathematicalExpression();
    // Console.WriteLine("Total Sum: {0}", exp.EvaluateExpression("(23(451)(6)((1))())"));
    // var twoSum = new TwoSum();
    // var result = twoSum.TwoSumProblem(9,new int[] {2,7,11,15});
    // Console.WriteLine("Indeces of two numbers: [{0}] ", string.Join(",",result));
    // // solutionsum("(2 3 (4 5 1) (6) ((1))  ())")
    #endregion
    public class EvaluateMathematicalExpression
    {
        public int EvaluateExpression(string exp)
        {
            Stack stack = new Stack();
            int totalSum = 0;
            int depth = 0;
            foreach(char c in exp){
                if(c == '('){
                    totalSum = GetTotal(totalSum,stack,depth);
                    depth++;
                }
                else if(c == ')'){
                    int tempSum = 0;
                    while(stack.Count > 0){
                         char n = (char)stack.Pop();
                        tempSum += Convert.ToInt32(Char.GetNumericValue(n));
                    }
                    tempSum = tempSum * depth;
                    totalSum += tempSum;
                    depth--;
                }
                else
                    stack.Push(c);
            }
            return totalSum;
        }
        
        public int GetTotal(int totalSum, Stack stack, int depth)
        {
            int tempSum = 0;
            while(stack.Count > 0){
                char n = (char)stack.Pop();
                tempSum += Convert.ToInt32(Char.GetNumericValue(n));
            }
            tempSum = tempSum * depth;
            totalSum += tempSum;
            return totalSum;
        }
    }
}