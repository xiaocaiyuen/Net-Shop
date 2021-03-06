using System.Collections.Generic;

namespace Shop.Module.Catalog.Abstractions.ViewModels
{
    public class ProductAttributeGroupArrayResult
    {
        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public IList<ProductAttributeResult> ProductAttributes { get; set; }
    }
}
