using GoFPatterns.Creational.FactoryMethod.AbstractFactories;
using GoFPatterns.Creational.FactoryMethod.ConcreteEntites;
using System;

namespace GoFPatterns.Creational.FactoryMethod.ConcreteFactories
{
    /// <summary>
    /// Work like a Concrete Creator.
    /// </summary>
    public class Report : Document
    {
        public override void CreatePagesFactory()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
