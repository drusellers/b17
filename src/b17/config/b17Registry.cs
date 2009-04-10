namespace b17.config
{
    using Db4objects.Db4o;
    using domain;
    using persistance;
    using StructureMap.Configuration.DSL;

    public class b17Registry : 
        Registry
    {
        public b17Registry()
        {
            this.ForRequestedType<IObjectContainer>().AsSingletons().TheDefault.Is.ConstructedBy(cxt => Db4oFactory.OpenFile("b17.db"));
            this.ForRequestedType<Repository>().TheDefaultIsConcreteType<db4oRepository>();
        }
    }
}