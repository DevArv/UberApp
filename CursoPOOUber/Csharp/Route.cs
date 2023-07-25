using System;
using System.Collections;

namespace RouteNS
{
    public class Route
    {
        public int Id { get; set; }
        public int[]? Start { get; set; }
        public int[]? End { get; set; }

        public void DataPrintRoute()
        {
           Console.WriteLine("");
        }
    }
}