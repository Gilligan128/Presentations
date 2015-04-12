using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Metadata;

namespace WebDemo.Infrastructure.ModelMetadata
{
    public class IdDisplayNameConvention : ModelMetadataConvention
    {
        public void Apply(System.Web.Mvc.ModelMetadata metadata)
        {
            if (metadata.PropertyName != "Id")
                return;

            metadata.DisplayName = "Conventional Display Name";
        }
    }
}