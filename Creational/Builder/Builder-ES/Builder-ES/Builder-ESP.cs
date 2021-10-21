using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_ES
{
    // La interfaz nos especifica las distintas partes de nuestro objeto a crear
    
    public interface IBuilder
    {
        void ProductPart1();

        void ProductPart2();

        void ProductPart3();
    }

    //Las clases concretas de Builder proporcionan ciertas implementaciones para los pasos de construccion
    //Podemos implementar distintos builders, segun nuestro objetivo final

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        // Usamos un constructor en blanco
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void ProductPart1()
        {
            this._product.Add("Parte 1 del Producto");
        }
 
        public void ProductPart2()
        {
            this._product.Add("Parte 2 del Producto");
        }

        public void ProductPart3()
        {
            this._product.Add("Parte 3 del Producto");
        }

        // Es buena practica el reinicio de los constructores de manera explicita para que la instancia este lista nuevamente para producir otro producto
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

    // Builder es utilizado para productos complejos que requieran una configuracion extensa

    // Por lo que tambien nos permite producir productos (en este caso) no relacionados

    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }

    // En este caso, designamos al Responsable para la ejecucion de pasos de construccion secuencial, para respetar el orden//configuracion de nuestro constructor
    public class Responsable
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // Distintas construcciones usando el mismo contructor
        public void ProductVariationA()
        {
            this._builder.ProductPart1();
        }

        public void ProductVariationB()
        {
            this._builder.ProductPart1();
            this._builder.ProductPart2();
            this._builder.ProductPart3();
        }
    }

    class Program
    {
        //Nuestro main se encarga de crear un objeto constructor y designar al responsable para comenzar a implementar builder

        static void Main(string[] args)
        {
            
            var responsable = new Responsable();
            var builder = new ConcreteBuilder();
            responsable.Builder = builder;

            Console.WriteLine("Variable 1:");
            responsable.ProductVariationA();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Variable 2, completa:");
            responsable.ProductVariationB();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Ejemplo de implementacion de builder sin un responsable
            Console.WriteLine("Custom product:");
            builder.ProductPart1();
            builder.ProductPart3();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}

