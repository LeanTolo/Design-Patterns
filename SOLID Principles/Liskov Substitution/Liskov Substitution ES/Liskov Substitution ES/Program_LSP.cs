using System;

namespace Liskov_Substitution_ES
{
    //LSP establece que incluso el objeto hijo se reemplaza con el padre sin cambiar el comportamiento.
    //Si obtenemos el color de Apple en lugar de Green, entonces sigue LSP.
    //Modifiquemos el ejemplo NOT_LSP para seguir el principio de sustitución de Liskov.
    //Aquí, primero, necesitamos una clase base genérica como Fruit, que será la clase base
    //tanto para Applee como para Green. Ahora puede reemplazar el objeto de la clase Fruit
    //con sus subtipos, ya sea Applee y Green, y se comportará correctamente. Ahora, puede ver
    //en el siguiente código, creamos la clase super Fruit como una clase abstracta con el método
    //abstracto GetColor y luego las clases Applee y Green heredadas de la clase Fruit e implementamos el método GetColor.
    //Respetando ahora el LSP

    class Program_LSP
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Green();
            Console.WriteLine(fruit.GetColor());
            fruit = new Applee();
            Console.WriteLine(fruit.GetColor());
        }
    }
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Applee : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Green : Fruit
    {
        public override string GetColor()
        {
            return "Green";
        }
    }
}
