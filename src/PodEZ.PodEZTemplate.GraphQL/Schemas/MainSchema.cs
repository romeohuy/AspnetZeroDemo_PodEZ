using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using PodEZ.PodEZTemplate.Queries.Container;

namespace PodEZ.PodEZTemplate.Schemas
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