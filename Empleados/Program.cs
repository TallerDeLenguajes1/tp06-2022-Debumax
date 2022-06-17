

DateTime fecha_ing=new DateTime(2000,11,05);
DateTime fecha_nac=new DateTime(1991,11,05);
class_Empleados emp1 = new class_Empleados("Debu", "Marcial",fecha_nac,'s' ,'m' ,fecha_ing , 250.20, 0);
emp1.Mostrar_Empleado();
Console.WriteLine($"Antiguedad : {emp1.Antiguedad()}");
Console.WriteLine($"Edad: {emp1.Edad()}");
Console.WriteLine($"Anios para jubilarse: {emp1.anios_jubilacion()}");
