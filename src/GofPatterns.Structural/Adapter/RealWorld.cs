using GofPatterns.Structural.Adapter.Adapter;
using System;

namespace GofPatterns.Structural.Adapter
{
    public class RealWorld
    {
        public static void Run()
        {
            var richCompound = new RichCompound("benzene");
            richCompound.Display();
        }
    }
}
