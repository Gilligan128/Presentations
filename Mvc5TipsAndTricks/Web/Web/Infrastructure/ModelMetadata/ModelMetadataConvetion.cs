using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDemo.Infrastructure.ModelMetadata
{
    public interface ModelMetadataConvention 
    {
        void Apply(System.Web.Mvc.ModelMetadata metadata);
    }
}
