
using ConceptosPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("**==****==**");

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

Console.WriteLine(employee1);
Console.WriteLine(employee2);

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

