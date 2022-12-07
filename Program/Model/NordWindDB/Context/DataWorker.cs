using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program.Model.NordWindDB
{
    internal static class DataWorker
    {
        internal static IEnumerable<Category> GetCategories()
        {

            using (NorthWindPsql db = new NorthWindPsql())
            {
                List<Category> retval = db.Categories.ToList();

                return retval;
            }

        }
    }
}