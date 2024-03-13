using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Frog_Jump
    {
        //public static int Frog_Jump()
        //{
        //    int[] leaves = { 1, 3, 1, 4, 2, 5 }; // Example array representing leaves in the river
        //    int distance = 7; // Distance to cross the river
        //    int minJumps = MinJumpsToCrossRiver(leaves, distance);
        //    return minJumps;
        //}






        //static int MinJumpsToCrossRiver(int[] leaves, int distance)
        //{
        //    int currentPosition = 0; // Current position of the frog
        //    int jumps = 0; // Number of jumps

        //    while (currentPosition < distance)
        //    {
        //        int fibJump = Fibonacci(jumps + 1); // Calculate the next Fibonacci jump

        //        int nextPosition = currentPosition + fibJump;

        //        // If the next position is beyond the river, frog has reached the other side
        //        if (nextPosition >= distance)
        //        {
        //            return jumps + 1;
        //        }

        //        // Find the farthest reachable leaf within the next Fibonacci jump
        //        int maxReach = Math.Min(nextPosition + leaves[nextPosition], distance - 1);
        //        for (int i = nextPosition + 1; i <= maxReach; i++)
        //        {
        //            if (leaves[i] > leaves[nextPosition])
        //            {
        //                nextPosition = i;
        //            }
        //        }

        //        // If no suitable leaf is found, it's impossible to reach the other side
        //        if (nextPosition == currentPosition)
        //        {
        //            return -1;
        //        }

        //        currentPosition = nextPosition;
        //        jumps++;
        //    }

        //    return jumps;
        //}

        //static int Fibonacci(int n)
        //{
        //    if (n <= 1)
        //    {
        //        return n;
        //    }

        //    int a = 0, b = 1;
        //    for (int i = 2; i <= n; i++)
        //    {
        //        int temp = a + b;
        //        a = b;
        //        b = temp;
        //    }

        //    return b;
        //}
    }

}
