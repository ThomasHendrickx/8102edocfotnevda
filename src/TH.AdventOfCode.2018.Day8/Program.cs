using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Input.Value.Split(' ').Select(int.Parse).ToList();
            var trunk = ExtractNode(input, out _);
            Console.WriteLine($"Metadata sum = {trunk.MetadataSum}");
            Console.WriteLine($"Node Value = {trunk.NodeValue}");
        }

        private static Node ExtractNode(List<int> input, out List<int> left)
        {
            //Console.WriteLine($"Processing {string.Join(' ', input)}");
            var numberOfChildren = input[0];
            var numberOfMetdata = input[1];
            var rest = input.GetRange(2, input.Count - 2);
            var children = new List<Node>();
            
            for (var i = 0; i < numberOfChildren; i++)
            {
                children.Add(ExtractNode(rest, out rest));
            }

            var metadata = rest.GetRange(0, numberOfMetdata);
            left = rest.GetRange(numberOfMetdata, rest.Count - numberOfMetdata);

            return new Node
            {
                Children = children,
                Metadata = metadata
            };
        }
        
        
    }

    class Node
    {
        public List<Node> Children { get; set; }
        public List<int> Metadata { get; set; }

        public int MetadataSum => Children.Select(c => c.MetadataSum).Sum() + Metadata.Sum();

        public int NodeValue
        {
            get
            {
                if (Children.Count == 0) return Metadata.Sum();

                var sum = 0;
                foreach (var metadata in Metadata)
                {
                    if(metadata == 0 || metadata > Children.Count) continue;

                    sum += Children[metadata - 1].NodeValue;
                }

                return sum;
            }
        }
    }
}