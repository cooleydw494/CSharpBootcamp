using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DBLab01LINQ
{
    [Table(Name = "EMP")]
    public class Employee
    {
        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public string EMPNO { get; set; }

        [Column]
        public string FIRSTNME { get; set; }

        [Column]
        public char MIDINIT { get; set; }

        [Column]
        public string LASTNAME { get; set; }

        [Column]
        public string WORKDEPT { get; set; }

        [Column]
        public string PHONENO { get; set; }

        [Column]
        public DateTime? HIREDATE { get; set; }

        [Column]
        public string JOB { get; set; }

        [Column]
        public  Int16 EDLEVEL { get; set; }

        [Column]
        public char SEX { get; set; }

        [Column]
        public DateTime? BIRTHDATE { get; set; }

        [Column]
        public decimal SALARY { get; set; }

        [Column]
        public decimal BONUS { get; set; }

        [Column]
        public decimal COMM { get; set; }
    }
}
