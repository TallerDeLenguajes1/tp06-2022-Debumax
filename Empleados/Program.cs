

DateTime fecha_ing=new DateTime(2000,11,05);
DateTime fecha_nac=new DateTime(1991,11,05);
class_Empleados emp1 = new class_Empleados("Debu", "Marcial",fecha_nac,'c' ,'m' ,fecha_ing , 250.20, Cargos.Ingeniero);
emp1.Mostrar_Empleado();
Console.WriteLine($"Antiguedad : {emp1.Antiguedad()}");
Console.WriteLine($"Edad: {emp1.Edad()}");
Console.WriteLine($"Anios para jubilarse: {emp1.anios_jubilacion()}");
Console.WriteLine($"Salario: {emp1.Salario()}");

class_Empleados emp2 = new class_Empleados("Debu", "Marcial",fecha_nac,'c' ,'m' ,fecha_ing , 250.20, Cargos.Ingeniero);
emp1.Mostrar_Empleado();
class_Empleados emp3 = new class_Empleados("Debu", "Marcial",fecha_nac,'c' ,'m' ,fecha_ing , 250.20, Cargos.Ingeniero);
emp1.Mostrar_Empleado();
List<class_Empleados> listaempleados= new List<class_Empleados>();
listaempleados.Add(emp1);
listaempleados.Add(emp2);
listaempleados.Add(emp3);

double saldoTotal=0;
foreach (class_Empleados empl in listaempleados)
{
    
    saldoTotal=saldoTotal + empl.Salario();
}

Console.WriteLine($"Salario total: {saldoTotal}");





