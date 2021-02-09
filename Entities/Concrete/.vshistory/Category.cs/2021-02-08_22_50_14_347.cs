using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Category: IEntity
    {
        public int ProductId { get; set; }
        public int MyProperty { get; set; }
    }
}
