using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.datatypes;

namespace TaxLibrary.App.Business.Entities
{
    public interface IMutableBusinessEntity : IMutableEntity
    {
        void SetId(Id primaryKey)
        {
        }

        void SetMasterId(MasterId masterId)
        {
        }
    }

}
