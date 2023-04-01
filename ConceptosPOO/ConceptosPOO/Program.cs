
using ConceptosOOP.Logic;

#region Tipos de Datos Basico

//Console.WriteLine("Bienvenido a los Tipos de Datos en POO");

//int myInt = 7;

//// Valores decimales
//float myFloat = 0.75821145f;
//double myDouble = 4856996.36663;
//decimal myDecimal = 252236.36M;

//// String
//string myString = "Johnny Martinez";

//// Boolean
//bool myBooleans = true;

//Console.WriteLine($"En valor entero es.: {myInt,15}");
//Console.WriteLine($"En valor float es..: {myFloat,15}");
//Console.WriteLine($"En valor double es.: {myDouble,15}");
//Console.WriteLine($"En valor decimal es: {myDecimal,15}");
//Console.WriteLine($"En valor string es.: {myString}");
//Console.WriteLine($"En valor boleano es: {(myBooleans ? "Si" : "No")}");

#endregion

#region Conceptos POO

//Console.WriteLine("");
//Console.WriteLine("POO Concepts");
//Console.WriteLine("**==****==**");
//Console.WriteLine("");

//Employee employee1 = new SalaryEmployee()
//{
//    Id = 10001,
//    FirstName = "Maria",
//    LastName = "Parra",
//    BirthDate = new Date(15, 7, 2000),
//    HiringDate = new Date(27, 6, 2015),
//    IsActive = true,
//    Salary = 5263.65M,
//};
////Console.WriteLine(employee1);
////Console.WriteLine("");

//Employee employee2 = new CommissionEmployee()
//{
//    Id = 10002,
//    FirstName = "Juana",
//    LastName = "Acosta",
//    BirthDate = new Date(24, 12, 1986),
//    HiringDate = new Date(22, 6, 2020),
//    IsActive = true,
//    Sales = 2500,
//    CommissionPercentaje = 0.03F
//};
////Console.WriteLine(employee2);
////Console.WriteLine("");

//Employee employee3 = new HourlyEmployee()
//{
//    Id = 10002,
//    FirstName = "Pedro",
//    LastName = "Martinez",
//    BirthDate = new Date(24, 12, 1986),
//    HiringDate = new Date(22, 6, 2020),
//    IsActive = true,
//    HoursValue = 35M,
//    Hours = 8.0F,
//};
////Console.WriteLine(employee3);
////Console.WriteLine("");

//Employee employee4 = new BaseCommissionEmployee()
//{
//    Id = 10002,
//    FirstName = "Tereza",
//    LastName = "Gonzalez",
//    BirthDate = new Date(24, 12, 1999),
//    HiringDate = new Date(10, 7, 2021),
//    IsActive = true,
//    Base = 150,
//    Sales = 1200,
//    CommissionPercentaje = 0.015F
//};
////Console.WriteLine(employee4);
////Console.WriteLine("");


//ICollection<Employee> employees = new List<Employee>()
//{
//    employee1, employee2, employee3, employee4
//};

//decimal payroll = 0;

//foreach (Employee employee in employees)
//{
//    payroll += employee.GetValueToPay();
//    Console.WriteLine(employee.ToString());
//    Console.WriteLine("");
//}

//Console.WriteLine("                               ===============");
//Console.WriteLine($"Total nomina:                  {$"{payroll:C2}",15}");


//Console.WriteLine("");
//Console.WriteLine("Detalle de Facturas emitidas");
//Console.WriteLine("============================");
//Console.WriteLine("");
//Invoice invoce1 = new Invoice()
//{
//    Description = "iPhon 14",
//    Id = 10023,
//    Price = 1450M,
//    Quantity = 6,

//};

//Invoice invoce2 = new Invoice()
//{
//    Description = "Posta Premium",
//    Id = 40050,
//    Price = 9.58M,
//    Quantity = 15.63F,

//};

//Console.WriteLine(invoce1);
//Console.WriteLine(invoce2);
//Console.ReadLine();

#endregion

#region Implementando Clase Date
try
{
    //Pendiente con el orden al momento de pasar las propiedades. estamos creando el objeto y asignado las propiedades
    //Debes seguir el orden Año, mes, dia
    var date1 = new Date() { Year = 1974, Month = 3, Day = 22 };
    var date2 = new Date() { Year = 2024, Month = 2, Day = 29 };

    Console.WriteLine(date1);
    Console.WriteLine(date2);

    // En este caso no es necesario el orden, ya que en el constructor se evalua.
    Console.WriteLine(new Date(day: 29, month: 2, year: 2025));

    Console.WriteLine(new Date(30, 19, 2022));
    Console.WriteLine(new Date(5, 8, 1974));

    Console.WriteLine("Hasta aquí todas las fechas son correctas");

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}

#endregion

