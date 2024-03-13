using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class lonelyinteger
    {
        //public static int lonely_integer(List<int> a)
        //{
        //    var aSorted = a.OrderBy(x => x).ToList();
        //    if (aSorted.Count == 1)
        //    {
        //        return aSorted[0];
        //    }
        //    else if (aSorted.Count == 2)
        //    {
        //        return 0;
        //    }
        //    Stack myStack = new Stack();
        //    var top = 0;
        //    myStack.Push(a[0]);
        //    for (int i = 1; i < aSorted.Count; i++)
        //    {
        //        if (myStack.Count>0)
        //        {
        //             top = (int)myStack.Peek();

        //        }
        //        else
        //        {
        //            myStack.Push(aSorted[i]);
        //            top = (int)myStack.Peek();
        //            continue;
        //        }
        //        if (top == aSorted[i])
        //        {
        //            myStack.Pop();

        //        }
        //        else
        //        {
        //            myStack.Push(aSorted[i]);

        //        }

        //    }
        //    if (myStack.Count!=0)
        //    {
        //        return (int)myStack.Peek();
        //    }
        //    return 0;
        //}
        
    }
}
