using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace DBLab01LINQ
{
    class SqlLab : DataContext
    {
        public Table<Employee> EMP;

        public SqlLab(string connectionInfo)
            :base(connectionInfo)
        {
        }
    }
}
