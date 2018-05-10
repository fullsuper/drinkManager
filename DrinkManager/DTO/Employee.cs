using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Employee
    {
        private int id;
        private String name;
        private DateTime hiredate;
        private String typeservice;
        private long phone;
        private long salary;

        public Employee(DataRow row)
        {
            id = Convert.ToInt16(row["eid"]);
            name = row["name"].ToString();
            hiredate = Convert.ToDateTime(row["hiredate"]);
            typeservice = row["tserviceid"].ToString();
            phone = Convert.ToInt64(row["phone"]);
            salary = Convert.ToInt64(row["salary"]);
  
        }

        public Employee(string name, DateTime hiredate, string typeservice, long phone, long salary)
        {
            this.name = name;
            this.hiredate = hiredate;
            this.typeservice = typeservice;
            this.phone = phone;
            this.salary = salary;
        }

        public Employee(int id, string name, DateTime hiredate, string typeservice, long phone, long salary)
        {
            this.id = id;
            this.name = name;
            this.hiredate = hiredate;
            this.typeservice = typeservice;
            this.phone = phone;
            this.salary = salary;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Hiredate { get => hiredate; set => hiredate = value; }
        public string Typeservice { get => typeservice; set => typeservice = value; }
        public long Phone { get => phone; set => phone = value; }
        public long Salary { get => salary; set => salary = value; }
    }
}
