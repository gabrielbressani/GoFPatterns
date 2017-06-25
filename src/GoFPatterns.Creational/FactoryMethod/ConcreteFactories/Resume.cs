using System;
using GoFPatterns.Creational.FactoryMethod.AbstractFactories;
using GoFPatterns.Creational.FactoryMethod.ConcreteEntites;

namespace GoFPatterns.Creational.FactoryMethod.ConcreteFactories
{
    /// <summary>
    /// Work like a Concrete Creator.
    /// </summary>
    public class Resume : Document
    {
        public override void CreatePagesFactory()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
