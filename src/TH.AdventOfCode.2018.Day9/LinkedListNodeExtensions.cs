using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day9
{
    public static class LinkedListNodeExtensions
    {
        public static LinkedListNode<T> Next<T>(this LinkedListNode<T> self)
        {
            return self.Next ?? self.List.First;
        }

        public static LinkedListNode<T> Previous<T>(this LinkedListNode<T> self)
        {
            return self.Previous ?? self.List.Last;
        }
    }
}