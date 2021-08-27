using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_ES
{
    //El Principio de sustitución de Liskov se basa en que
    //Cada clase que hereda de otra puede usarse como su padre sin necesidad de conocer las diferencias entre ellas.


    //En el siguiente ejemplo observaran Apple como clase base y Green_NOT_SLP como secundaria,
    //existiendo una relacion padre e hijo, podemos almacenar el objeto secundario en referencia a la clase principal
    //es decir, Apple apple = new Green_NOT_SLP(); y cuando llamamos a apple.GetColor(), entonces obtenemos el color de Green_NOT_SLP,
    //no el color de Apple. Eso significa que una vez que se reemplaza el objeto secundario, es decir,
    //que Apple almacena el objeto Green_NOT_SLP, cambiando tambien el comportamiento. Yendo en contra del principio LSP.

    class Not_LSP
    {
        //static void Main(string[] args)
        //{
            Apple apple = new Green_NOT_SLP();
           // Console.WriteLine(apple.GetColor());
       // }
    }
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Green_NOT_SLP : Apple
    {
        public override string GetColor()
        {
            return "Green_NOT_SLP";
        }
    }
}
