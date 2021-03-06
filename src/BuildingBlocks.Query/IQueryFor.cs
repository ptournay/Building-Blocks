using System.Collections.Generic;
using BuildingBlocks.Common;

namespace BuildingBlocks.Query
{
    public interface IQueryFor<TResult>
    {
        IQueryFor<TResult> With<TCriteria>(TCriteria criteria);
        TResult SingleOrDefault();
        IEnumerable<TResult> Enumerable();
        Page<TResult> Page();
    }
}