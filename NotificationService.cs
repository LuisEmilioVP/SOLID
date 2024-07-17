// Principio de Inversión de Dependencias (DIP):

/*
  Usaremos la interfaz INotificationService para desacoplar las implementaciones específicas de los servicios de notificaciones.
*/

public class EmailNotificationService : INotificationService
{
  public void SendNotification(string message)
  {
    Console.WriteLine("Sending Email: " + message);
  }
}

public class SmsNotificationService : INotificationService
{
  public void SendNotification(string message)
  {
    Console.WriteLine("Sending SMS: " + message);
  }
}
