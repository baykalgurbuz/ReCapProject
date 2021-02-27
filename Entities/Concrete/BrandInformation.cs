using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class BrandInformation :IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
