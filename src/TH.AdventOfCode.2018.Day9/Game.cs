using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day9
{
    public class Game
    {
        private readonly LinkedList<Player> _players;
        private readonly int _lastMarbleValue;
        private readonly Circle _circle;

        private int _nextMarbleValue;
        private LinkedListNode<Player> _nextPlayer;
        
        public Game(IEnumerable<Player> players, int lastMarbleValue)
        {
            _players = new LinkedList<Player>(players);
            _lastMarbleValue = lastMarbleValue;
            _circle = new Circle();
            _nextMarbleValue = 0;
            _nextPlayer = _players.First;
        }

        public void Play()
        {
            while (_nextMarbleValue <= _lastMarbleValue)
            {
                PlayNext();
            }
        }
        
        private void PlayNext()
        {            
            var marble = new Marble(_nextMarbleValue++);
            _circle.AddMarble(marble, out var scoreToAdd);
            _nextPlayer.Value.AddScore(scoreToAdd);
            _nextPlayer = _nextPlayer.Next();
        }

        public Player Winner => _players.OrderByDescending(p => p.Score).First();
    }
}