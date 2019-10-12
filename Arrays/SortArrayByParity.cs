namespace Algorithms_DS.Arrays
{
    #region Problem
    // Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.
    // You may return any answer array that satisfies this condition.
    //  Example:Input: [3,1,2,4]
    // Output: [2,4,3,1]
    // The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
    #endregion
    public class SortArrayByParity
    {
        #region Complexity
            //Time: O(N)
            //Space: O(N)
        #endregion
        public int[] SortArrayByParityProblem(int[] A) 
        {
            var B = new int[A.Length];
            int left = 0;
            int right = A.Length - 1;
                for(int i=0; i<A.Length; i++)
                {
                    if(A[i]%2 != 0)
                    {
                        B[right] = A[i];
                        right--;
                    }
                    else
                    {
                        B[left] = A[i];
                        left++;
                    }
                }
                return B;
            }

        public int[] SortArrayByParityOptimized(int[] A) 
        {
            int front = 0;
            int back = A.Length - 1;

            while(front < back)
            {
                if(A[front] % 2 > A[back] % 2)
                {
                    int temp = A[front];
                    A[front] = A[back];
                    A[back] = temp;
                }

                if(A[front] % 2 == 0)
                 front++;
                 if(A[back] % 2 == 1)
                 back--;
            }
            return A;
        }
    }
}