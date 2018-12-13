using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day12
{
    public static class LinkedListNodePotsExtensions
    {
        public static bool TwoLeftHasPlant(this LinkedListNode<Pot> self)
        {
            return self.Previous?.Previous?.Value.HasPlant ?? false;
        }

        public static bool OneLeftHasPlant(this LinkedListNode<Pot> self)
        {
            return self.Previous?.Value.HasPlant ?? false;
        }

        public static bool OneRightHasPlant(this LinkedListNode<Pot> self)
        {
            return self.Next?.Value.HasPlant ?? false;
        }

        public static bool TwoRightHasPlant(this LinkedListNode<Pot> self)
        {
            return self.Next?.Next?.Value.HasPlant ?? false;
        }
    }
}