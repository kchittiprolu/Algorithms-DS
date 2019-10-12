using System;
using System.Collections.Generic;

namespace Algorithms_DS.Arrays
{
//#region Problem
        // Given an array of integers, return indices of the two numbers from array so that they add up to a given integer.
        // You are not allwed to use same number twice.
        //For Execution: (copy past below code in Main method)
        // var twoSum = new TwoSum();
        // var result = twoSum.TwoSumProblem(new int[] {2,7,11,15},9); or var result = twoSum.TwoSumProblem(9,new int[] {2,7,11,15});
        // Console.WriteLine("Indeces of two numbers: [{0}] ", string.Join(",",result));
//#endregion
    public class TwoSum
    {

      public int[] TwoSumProblem(int target,int[] nums) 
      {

          var numbers = new Dictionary<int,int>();
          for(int i=0; i<nums.Length;i++)
          {
              if(numbers.ContainsKey(target - nums[i])){
                  return new int[]{ numbers.GetValueOrDefault(target - nums[i]),i};
              }
              else{
                  numbers.Add(nums[i],i);
              }
          }
          throw new ArgumentException("No two numbers that sum to target");
      }

     //Time complexity is O(n2)
      public int[] TwoSumProblem(int[] nums, int target) 
      {
            for(int i =0; i<nums.Length;i++)
            {
                for(int j = i+1; j<nums.Length;j++)
                {
                    if(nums[j]  == target - nums[i]){
                    return new int[]{i,j};
                    }
                }
            }
            
            throw new ArgumentException("No two numbers that sum to target");
        }
    }
}

