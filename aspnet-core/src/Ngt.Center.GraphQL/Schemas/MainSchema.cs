using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using Ngt.Center.Queries.Container;

namespace Ngt.Center.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}