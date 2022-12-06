using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program.Model.NordWindDB
{
    internal class Product
    {
        internal int ProductID {get; set; }

        internal string ProductName {get; set; } = null!;

        internal decimal UnitPrice { get; set; }

        internal int UnitsInStock { get; set; }

        internal bool Discontinued { get; set; }


        internal int CategoryID { get; set; }

        internal virtual Category Category { get; set; } = null!;
    }
}