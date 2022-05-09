using SuperMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    
        public class Operation
        {
            SuperMarketContext dbcontext = new SuperMarketContext();


            public List<EmployeeDetails> EmployeeList = new List<EmployeeDetails>();
            //constructor
            public Operation()
            {
                //EmployeeDetails Employee1 = new EmployeeDetails()
                //{
                //    Id = 1,
                //    Name = "sus",
                //    Age = 25,
                //    Phone = "1234567891",
                //    EmailId ="Susmithasundar31@gmail.com",
                //};

                //EmployeeList.Add(Employee1);



            }



            public void AddEmployee()
            {
                Console.WriteLine("Enter the employee ID");
                int EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the employee Name");
                String Empname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the employee Age");
                int EmpAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the employee phone no");
                string EmpPh = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the employee EmailId");
                string EmpEmailID = Convert.ToString(Console.ReadLine());
                EmployeeDetails employeedetails = new EmployeeDetails()
                {
                    Id = EmpID,
                    Name = Empname,
                    Age = EmpAge,
                    EmailId = EmpEmailID,
                    Phone = EmpPh,
                };
                //to add employee details into table / db
                dbcontext.EmployeeDetails.Add(employeedetails);
                //to save the changes
                dbcontext.SaveChanges();

            }
            public void Update()
            {
                Console.WriteLine("Enter the Employeeid Which u want to update");
                int Updateid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the new name that u want to change");
                string Updatename = Convert.ToString(Console.ReadLine());
                // foreach (EmployeeDetails details in EmployeeList)
                //{
                //    if (details.Id == Updateid)
                //        details.Name = Updatename;

                //}
                var result = dbcontext.EmployeeDetails.FirstOrDefault(s => s.Id == Updateid);
                if (result != null)
                {
                    result.Name = Updatename;
                    dbcontext.SaveChanges();

                }


            }
            public void Delete()
            {
                Console.WriteLine("enter the employee id which u want to delete");
                int Deleteid = Convert.ToInt32(Console.ReadLine());
                //EmployeeList.RemoveAll(s=> s.Id== Deleteid);

                var result = dbcontext.EmployeeDetails.FirstOrDefault(s => s.Id == Deleteid);
                if (result != null)
                {
                    dbcontext.EmployeeDetails.Remove(result);
                    dbcontext.SaveChanges();

                }
            }
            public void View()
            {
                var a = dbcontext.EmployeeDetails.ToList();


                Console.WriteLine(" ID   | Name   |  Age      | Phone   |EmailID");
                foreach (var employees in a)
                {
                    Console.WriteLine(employees.Id + "   |   " + employees.Name + "   |   " + employees.Age + "   |   " + employees.Phone + "   |   " + employees.EmailId);
                }
            }

        }
    }
