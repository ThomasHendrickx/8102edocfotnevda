using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day9
{
    public class Circle : LinkedList<Marble>
    {
        public LinkedListNode<Marble> CurrentMarble { get; private set; }

        public void AddMarble(Marble marble, out long scoreToAdd)
        {
            if (marble.Id != 0 && marble.Id % 23 == 0)
            {
                HandleScoringMarble(marble, out scoreToAdd);
            }
            else
            {
                scoreToAdd = 0;
                AddMarble(marble);
            }
        }

        private void HandleScoringMarble(Marble marble, out long score)
        {
            var marbleToDelete = CurrentMarble.Previous().Previous().Previous().Previous().Previous().Previous().Previous();
            CurrentMarble = marbleToDelete.Next();
            score = marbleToDelete.Value.Id + marble.Id;
            Remove(marbleToDelete);
        }
        
        private void AddMarble(Marble marble)
        {
            var node = new LinkedListNode<Marble>(marble);
            if (Count == 0)
            {
                AddFirst(node);
            }
            else if(CurrentMarble.Next() == null)
            {
                AddAfter(CurrentMarble, node);
                
            }
            else
            {
                AddAfter(CurrentMarble.Next(), node);
            }

            CurrentMarble = node;
        }
    }
}