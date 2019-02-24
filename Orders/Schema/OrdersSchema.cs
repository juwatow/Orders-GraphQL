using GraphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Schema
{
    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(OrdersQuery ordersQuery, IDependencyResolver dependencyResolver)
        {
            Query = ordersQuery;
            DependencyResolver = dependencyResolver;
        }
    }
}
