using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Application.Common.Mappings;
using ECommerce.Domain.Entities.ValueObjects;

namespace ECommerce.Application.Product.Queries.GetProductList
{
    public class ProductBriefDto : IMapFrom<ECommerce.Domain.Entities.Product>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public Money DefaultPrice { get; set; }
    }
}