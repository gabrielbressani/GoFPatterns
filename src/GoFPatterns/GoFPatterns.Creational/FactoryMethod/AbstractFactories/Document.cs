using GoFPatterns.Creational.FactoryMethod.AbstractEntities;
using System.Collections.Generic;

namespace GoFPatterns.Creational.FactoryMethod.AbstractFactories
{

    /// <summary>
    /// Work like a Creator.
    /// Declares the factory method, which returns an object of type IPage. 
    /// </summary>
    public abstract class Document
    {
        public Document()
        {
            Pages = new List<IPage>();
            CreatePagesFactory();
        }

        public IList<IPage> Pages { get; set; }

        public abstract void CreatePagesFactory();
    }
}
