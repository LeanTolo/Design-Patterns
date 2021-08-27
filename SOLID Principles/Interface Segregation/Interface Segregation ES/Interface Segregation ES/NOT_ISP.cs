using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_ES
{
    //El Principio de Segregación de Interfaces (ISP) establece que una clase no debe tener
    //que implementar ningún elemento de interfaz que no sea requerido por la clase en particular.
    //Esto asegurará que la clase y, en última instancia, toda la aplicación sea muy robusta y fácil de mantener y expandir si es necesario.

    //En el ejemplo a continuacion, no se respeta el ISP
    //ya que la clase FullTimeEmployee no necesita implementar la función CalculateWorkedSalary
    //y la clase ContractEmployee no necesita implementar la función CalculateNetSalary.

    class NOT_ISP
    {
    }
    public interface IWorker
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        float Salary { get; set; }
        float HoursInMonth { get; set; }
        float CalculateNetSalary();
        float CalaculateWorkedSalary();
    }

    public class FullTimeEmployee : IWorker
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateNetSalary() => Salary;
        public float CalaculateWorkedSalary() => throw new NotImplementedException();
    }

    public class ContractEmployee : IWorker
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateNetSalary() => throw new NotImplementedException();
        public float CalaculateWorkedSalary() => HoursInMonth;
    }
}
