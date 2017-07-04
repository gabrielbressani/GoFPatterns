using GofPatterns.Structural.Adapter.Adapter;
using System;

namespace GofPatterns.Structural.Adapter
{
    public class RealWord
    {
        public static void Run()
        {
            var richCompound = new RichCompound("benzene");
            richCompound.Display();
        }
    }
}
