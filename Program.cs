/*
  Principio de Abierto/Cerrado (OCP):
  La clase de notificación estará abierta para la extensión (podemos agregar nuevos servicios de notificaciones) pero cerrada para la modificación (no necesitamos cambiar el código existente).
*/

public class Notification
{
  private readonly INotificationService _notificationService;

  public Notification(INotificationService notificationService)
  {
    _notificationService = notificationService;
  }

  public void Send(string message)
  {
    _notificationService.SendNotification(message);
  }
}

/*
  Principio de Sustitución de Liskov (LSP):
  Podemos sustituir cualquier implementación de INotificationService por otra sin afectar el comportamiento de la clase Notification.
*/

class Program
{
  static void Main(string[] args)
  {
    // Usando el servicio de notificación por correo electrónico
    INotificationService emailService = new EmailNotificationService();
    Notification emailNotification = new Notification(emailService);
    emailNotification.Send("Hello via Email!");

    // Usando el servicio de notificación por SMS
    INotificationService smsService = new SmsNotificationService();
    Notification smsNotification = new Notification(smsService);
    smsNotification.Send("Hello via SMS!");
  }
}
