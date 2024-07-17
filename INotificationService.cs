// Principio de Responsabilidad Única (SRP): La clase INotificationService solo debería tener una razón de cambiar.

public interface INotificationService
{
  void SendNotification(string message);
}
