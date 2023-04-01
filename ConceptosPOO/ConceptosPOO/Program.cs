
using ConceptosPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Date date1 = new Date(22, 3, 1974);


try
{
    Console.WriteLine(new Date(29, 2, 2024));
    Console.WriteLine(new Date(31, 9, 2022));
    Console.WriteLine(new Date(5, 8, 1974));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

