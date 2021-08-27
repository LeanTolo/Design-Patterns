using System;

namespace Interface_Segregation_ES
{
    class ISP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ISP!");
        }
    }

    //En NOT_ISP, vemos que hemos creado una interfaz base que
    //tiene las propiedades comunes de todos los empleados. Luego, creamos
    //dos interfaces más que implementan la interfaz base y estas interfaces
    //son para el empleado a tiempo completo y contratado, respectivamente.
    //Solo contienen propiedades y métodos para el tipo particular de empleado.
    //Finalmente, en nuestras clases para el empleado a tiempo completo y contratado,
    //solo implementamos la interfaz requerida (tiempo completo o contrato).
    //No se requiere ningún método o propiedad adicional.
    public interface IBaseWorker
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }

    }

    public interface IFullTimeWorkerSalary : IBaseWorker
    {
        float Salary { get; set; }
        float CalculateNetSalary();
    }

    public interface IContractWorkerSalary : IBaseWorker
    {
        float HoursInMonth { get; set; }
        float CalaculateWorkedSalary();
    }

    public class FullTimeEmployeeFixed : IFullTimeWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
        public float CalculateNetSalary() => Salary ;
    }

    public class ContractEmployeeFixed : IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HoursInMonth { get; set; }
        public float CalaculateWorkedSalary() => HoursInMonth;
    }
}
