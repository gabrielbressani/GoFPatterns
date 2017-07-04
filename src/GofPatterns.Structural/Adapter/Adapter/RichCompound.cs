using GofPatterns.Structural.Adapter.Adaptee;
using GofPatterns.Structural.Adapter.Target;
using System;

namespace GofPatterns.Structural.Adapter.Adapter
{
    /// <summary>
    /// Adapts the interface Adaptee to the Target interface.
    /// </summary>
    public class RichCompound : Compound
    {
        private ChemicalDatabank _chemicalDatabank;

        public RichCompound(string name)
            : base(name)
        {
        }

        public override void Display()
        {
            _chemicalDatabank = new ChemicalDatabank();

            _boilingPoint = _chemicalDatabank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _chemicalDatabank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _chemicalDatabank.GetMolecularWeight(_chemical);
            _molecularFormula = _chemicalDatabank.GetMolecularStructure(_chemical);

            base.Display();

            Console.WriteLine($" Formula: { _molecularFormula }");
            Console.WriteLine($" Weight : { _molecularWeight }");
            Console.WriteLine($" Melting Pt: { _meltingPoint }");
            Console.WriteLine($" Boiling Pt: { _boilingPoint }");
        }
    }
}
