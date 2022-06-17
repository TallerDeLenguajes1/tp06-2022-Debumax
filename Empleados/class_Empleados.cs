class class_Empleados
{
    private string Nombre ;
    private string Apellido;
    private DateTime Fecha_Nac;
    private char Estado_Civil;
    private char Genero;
    private DateTime Fecha_Ingreso;
    private double Sueldo_Basico;
    private Cargos Cargo;

    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime Fecha_Nac1 { get => Fecha_Nac; set => Fecha_Nac = value; }
    public char Estado_Civil1 { get => Estado_Civil; set => Estado_Civil = value; }
    public char Genero1 { get => Genero; set => Genero = value; }
    public DateTime Fecha_Ingreso1 { get => Fecha_Ingreso; set => Fecha_Ingreso = value; }
    public double Sueldo_Basico1 { get => Sueldo_Basico; set => Sueldo_Basico = value; }
    public Cargos Cargo1 { get => Cargo; set => Cargo = value; }



    public class_Empleados (string _Nombre,string _Apellido,DateTime _Fecha_Nac,char _Estado_Civil,
                            char _Genero, DateTime _Fecha_Ingreso,double _Sueldo_Basico,Cargos _Cargo){
        
        this.Nombre=_Nombre;
        this.Apellido=_Apellido;
        this.Fecha_Nac=_Fecha_Nac;
        this.Estado_Civil=_Estado_Civil;
        this.Genero=_Genero;
        this.Fecha_Ingreso=_Fecha_Ingreso;
        this.Sueldo_Basico=_Sueldo_Basico;
        this.Cargo=_Cargo;

    }

    public void Mostrar_Empleado(){
        Console.WriteLine($"Nombre: {Nombre1}");
        Console.WriteLine($"Apellido: {Apellido1}");
        Console.WriteLine($"Fecha de nacimiento: {Fecha_Nac1}");
        Console.WriteLine($"Estado Civil: {Estado_Civil1}");
        Console.WriteLine($"Genero: {Genero1}");
        Console.WriteLine($"Fecha de Ingreso: {Fecha_Ingreso1}");
        Console.WriteLine($"Sueldo Basico: {Sueldo_Basico1}");
        Console.WriteLine($"Cargo: {Cargo1}");
    }
    public int Antiguedad()
    {   DateTime fecha_actual= DateTime.Today;
        int Antiguedad= fecha_actual.Year - Fecha_Ingreso1.Year ;
        return Antiguedad;
    }
    public int Edad()
    {   DateTime fecha_actual= DateTime.Today;
        int edad= fecha_actual.Year - Fecha_Nac1.Year ;
        return edad;
    }
    public int anios_jubilacion(){//años para jubilarse
        int anios;

        if(Genero1=='m'){
            anios=60 - Edad() ;
            return anios;
        }
        if(Genero1=='v')
        {
            anios=65-Edad();
            return anios;
        }
        Console.WriteLine("algo ocurrio");
        return 0;
    }
    public double Salario(){
        double salario;
        
        return 0;
    }








}



public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}