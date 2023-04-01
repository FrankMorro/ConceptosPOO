
using ConceptosPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("**==****==**");
Console.WriteLine("");

Employee employee1 = new SalaryEmployee()
{
    Id = 10001,
    FirstName = "Maria",
    LastName = "Parra",
    BirthDate = new Date(15, 7, 2000),
    HiringDate = new Date(27, 6, 2015),
    IsActive = true,
    Salary = 5263.65M,
};
//Console.WriteLine(employee1);
//Console.WriteLine("");

Employee employee2 = new CommissionEmployee()
{
    Id = 10002,
    FirstName = "Juana",
    LastName = "Acosta",
    BirthDate = new Date(24, 12, 1986),
    HiringDate = new Date(22, 6, 2020),
    IsActive = true,
    Sales = 2500,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);
//Console.WriteLine("");

Employee employee3 = new HourlyEmployee()
{
    Id = 10002,
    FirstName = "Pedro",
    LastName = "Martinez",
    BirthDate = new Date(24, 12, 1986),
    HiringDate = new Date(22, 6, 2020),
    IsActive = true,
    HoursValue = 35M,
    Hours = 8.0F,
};
//Console.WriteLine(employee3);
//Console.WriteLine("");

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 10002,
    FirstName = "Tereza",
    LastName = "Gonzalez",
    BirthDate = new Date(24, 12, 1999),
    HiringDate = new Date(10, 7, 2021),
    IsActive = true,
    Base = 150,
    Sales = 1200,
    CommissionPercentaje = 0.015F
};
//Console.WriteLine(employee4);
//Console.WriteLine("");


ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    payroll += employee.GetValueToPay();
    Console.WriteLine(employee.ToString());
    Console.WriteLine("");
}

Console.WriteLine("                               ===============");
Console.WriteLine($"Total nomina:                  {$"{payroll:C2}",15}");


Console.WriteLine("");
Console.WriteLine("Detalle de Facturas emitidas");
Console.WriteLine("============================");
Console.WriteLine("");
Invoice invoce1 = new Invoice()
{
    Description = "iPhon 14",
    Id = 10023,
    Price = 1450M,
    Quantity = 6,

};

Invoice invoce2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 40050,
    Price = 9.58M,
    Quantity = 15.63F,

};

Console.WriteLine(invoce1);
Console.WriteLine(invoce2);
Console.ReadLine();

//try
//{
//    Console.WriteLine(new Date(29, 2, 2024));
//    Console.WriteLine(new Date(30, 9, 2022));
//    Console.WriteLine(new Date(5, 8, 1974));
//    Console.WriteLine("Hasta aquí todas las fechas son correctas");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

