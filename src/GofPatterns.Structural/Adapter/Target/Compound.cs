using System;

namespace GofPatterns.Structural.Adapter.Target
{
    /// <summary>
    /// Defines the domain-specific interface that Client uses.
    /// </summary>
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound(string chemical)
        {
            _chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nCompound: { _chemical } ------ ");
        }
    }
}
