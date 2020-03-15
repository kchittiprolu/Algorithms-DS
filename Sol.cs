using System.Collections.Generic;
using System;
public class Sol
{
public int NumTreasureTruckPops(int rows, int columns, int[,] grid)
{
    int count = 0;
    int[] d = {0, 1, 0, -1, 0};
    Queue<int[]> queue = new Queue<int[]>();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++) {
            if (grid[i, j] != 1) continue;
            queue.Enqueue(new int[2] { i, j });
            while (queue.Count != 0) {
                int[] ij = queue.Dequeue();
                for (int k = 0; k < 4; k++) {
                    int I = ij[0] + d[k], J = ij[1] + d[k+1];
                    if ((uint)I < rows && (uint)J < columns && grid[I, J] == 1) {
                        grid[I, J] = 2;
                        queue.Enqueue(new int[2] { I, J });
                    }
                }
            }
            count++;
        }
    return count;
}  
}