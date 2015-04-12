using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Infrastructure.ModelMetadata
{
    public class ConventionalModelMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        ModelMetadataConvention[] _conventions;

        public ConventionalModelMetadataProvider(ModelMetadataConvention[] conventions) {
            _conventions = conventions;
        }

        protected override System.Web.Mvc.ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            var metadata = base.CreateMetadata(attributes, containerType, modelAccessor, modelType, propertyName);

            foreach (var convention in _conventions)
                convention.Apply(metadata);

            return metadata;
        }
    }
}