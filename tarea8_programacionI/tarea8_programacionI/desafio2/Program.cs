class Program
{
    static void Main()
    {
        NotificacionEmail email = new NotificacionEmail();
        email.direccionCorreo = "sofia.lopez@gmail.com";

        NotificacionWhatsap whatsapp = new NotificacionWhatsap();
        whatsapp.numeroTelefono = "12345678";

        NotificacionSMS sms = new NotificacionSMS();
        sms.numeroTelefono = "87654321";

        Console.WriteLine("Email:");
        email.Notifica("Hola desde Email");

        Console.WriteLine("\nWhatsApp:");
        whatsapp.Notifica("Hola desde WhatsApp");

        Console.WriteLine("\nSMS:");
        sms.Notifica("Hola desde SMS");
    }
}

interface INotificable
{
    void Notifica(string mensaje);
}

class NotificacionEmail : INotificable
{
    public string direccionCorreo;

    public void Notifica(string mensaje)
    {
        Console.WriteLine("Email a " + direccionCorreo + ": " + mensaje);
    }
}

class NotificacionWhatsap : INotificable
{
    public string numeroTelefono;

    public void Notifica(string mensaje)
    {
        Console.WriteLine("WhatsApp a " + numeroTelefono + ": " + mensaje);
    }
}

class NotificacionSMS : INotificable
{
    public string numeroTelefono;

    public void Notifica(string mensaje)
    {
        Console.WriteLine("SMS a " + numeroTelefono + ": " + mensaje);
    }
}