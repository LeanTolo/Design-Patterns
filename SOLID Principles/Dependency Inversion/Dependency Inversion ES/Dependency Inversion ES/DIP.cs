using System;

namespace Dependency_Inversion_ES
{
    //La solución es invertir los controles y trabajar con la abstracción en vez de la implementación
    //En este caso, dando uso a las interfaces
    class DIP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check the comments to understand the example");
        }
    }

    public interface IMailService
    {
        void Send();
    }

    public class MailServiceDIP : IMailService
    {
        public void Send()
        {
            // TODO: código para enviar el correo
        }
    }

    public class SendService : IMailService
    {
        public void Send()
        {
            // TODO: código para enviar el correo
        }
    }

    public class OrderService
    {
        public readonly IMailService _mailService;

        public OrderService(IMailService mailService)
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

    //Gracias a la implementacion de IMailService, cualquier proveedor puede enviar data sin necesidad de cambiar referencias
    //Y al no tener dependencia hacia la clase, hacemos uso de la inversion de dependencia

}
