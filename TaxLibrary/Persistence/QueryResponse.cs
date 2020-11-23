using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Entities;

namespace TaxLibrary.Persistence
{
    public class QueryResponse<T> where T : IBusinessEntity
    {
        private readonly List<T> data;
        private readonly long count;

        public List<T> Data { get; private set; }
        public long Count { get; private set; }

        public class Build<T> where T : IBusinessEntity
        {
            private List<T> data;
            private long count;

            public Build<T> WithData(List<T> data)
            {
                this.data = data;
                return this;
            }

            public Build<T> WithCount(long count)
            {
                this.count = count;
                return this;
            }

            public QueryResponse<T> BuildObject()
            {
                QueryResponse<T> dataResponse = new QueryResponse<T>
                {
                    Count = count,
                    Data = data
                };
                return dataResponse;
            }
        }
    }
}
