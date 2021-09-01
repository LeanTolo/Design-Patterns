using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_ES
{
    //El principio de inversión de dependencia (DIP) establece que los módulos / clases de alto nivel no deben
    //depender de módulos / clases de bajo nivel. Ambos deberían depender de abstracciones.
    //En segundo lugar, las abstracciones no deberían depender de los detalles. Los detalles deben depender de abstracciones.

    //El punto más importante que debe recordar al desarrollar aplicaciones en tiempo real,
    //siempre para tratar de mantener el módulo de alto nivel y el módulo de bajo nivel lo más débilmente posible.

    //Cuando una clase conoce el diseño y la implementación de otra clase,
    //aumenta el riesgo de que, si hacemos algún cambio en una clase, se rompa la otra.
    //Por lo tanto, debemos mantener estos módulos / clases de alto y bajo nivel acoplados de manera flexible tanto como sea posible.
    //Para hacer eso, debemos hacer que ambos dependan de abstracciones en lugar de conocerse.


    //Supongamos que luego de crear una orden de compra necesitamos enviar un correo electrónico
    //a nuestro cliente para confirmar su orden y el envío de correo será a traves de MailService.

    class Not_DIP
    {
    }
    public class MailService
    {
        public void Send()
        {
            // TODO: código para enviar el correo
        }
    }

    public class OrderServiceNotDip
    {
        public readonly MailService _mailService;

        public OrderServiceNotDip(MailService mailService)
        {
            _mailService = mailService;
        }

        public void Create(string order)
        {
            // TODO: código para crear la orden

            // Enviar notificación de la orden creada
            _mailService.Send();
        }
    }

    //Nuestro proveedor actualmente es MailService,
    //pero si cambiamos de proveedor a futuro, tendremos que cambiar todas las referencias
    //que tenemos a MailService
}
