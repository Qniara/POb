using System;

namespace Delegate
{
	internal class Program
	{
		public delegate void NotithicationHandler(string message);

		public class EmailNotifier
		{
			public void SendEmail(string message)
			{
				Console.WriteLine($"Email wysłany: {message}");
			}
		}

		public class SMSNotifier
		{
			public void SendSMS(string message)
			{
				Console.WriteLine($"SMS wysłany: {message}");

			}
		}

		public class PushNotifier
		{
			public void SendPushNotifier(string message)
			{
				Console.WriteLine($"Powiadomienie push wysłany: {message}");
			}
		}

		public class NotifiacationManager
		{
			public NotithicationHandler Notify;

			public void AddNotificationMethod(NotithicationHandler handler)
			{
				Notify += handler;
			}

			public void RemoveNotificationMethod(NotithicationHandler handler)
			{
				Notify -= handler;
			}

			public void SendNotification(string message)
			{
				if(Notify == null)
				{
					Console.WriteLine("Brak dostepnym metod powiadomien.");
				}
				Notify?.Invoke(message);
			}
			public static void ShowMenu()
			{
				Console.WriteLine("Menu");
				Console.WriteLine("1. Dodaj powiadomienie email");
				Console.WriteLine("2. Dodaj powiadomienie SMS");
				Console.WriteLine("3. Dodaj powiadomienie Push");
				Console.WriteLine("4. Usun powiadomienie email");
				Console.WriteLine("5. Usun powiadomienie SMS");
				Console.WriteLine("6. Usun powiadomienie Push");
				Console.WriteLine("7. Wyslij powiadomienie");
				Console.WriteLine("8. Wyjdz");
				Console.Write("Wybierz opcje: ");

			}
			static void Main(string[] args)
			{
				var emailNotifier = new EmailNotifier();
				var smsNotifier = new SMSNotifier();
				var pushNotifier = new PushNotifier();

				var notificationManager = new NotifiacationManager();

				//notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
				//notificationManager.AddNotificationMethod(smsNotifier.SendSMS);
				//notificationManager.AddNotificationMethod(pushNotifier.SendPushNotifier);

				//notificationManager.SendNotification("Pierwsza wiadomość.");
				//Console.WriteLine();

				//notificationManager.RemoveNotificationMethod(smsNotifier.SendSMS);
				//notificationManager.SendNotification("Druga wiadomość.");

				while (true)
				{
					try
					{
						ShowMenu();
						var choice = int.Parse(Console.ReadLine());
						switch (choice)
						{
							case 1:
								notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
								Console.WriteLine("Dodano powiadomienie email");
								break;
							case 2:
								notificationManager.AddNotificationMethod(smsNotifier.SendSMS);
								Console.WriteLine("Dodano powiadomienie SMS");
								break;
							case 3:
								notificationManager.AddNotificationMethod(pushNotifier.SendPushNotifier);
								Console.WriteLine("Dodano powiadomienie Push");
								break;
							case 4:
								notificationManager.RemoveNotificationMethod(emailNotifier.SendEmail);
								Console.WriteLine("Usuieto powiadomienie email");
								break;
							case 5:
								notificationManager.RemoveNotificationMethod(smsNotifier.SendSMS);
								Console.WriteLine("Usuieto powiadomienie SMS");
								break;
							case 6:
								notificationManager.RemoveNotificationMethod(pushNotifier.SendPushNotifier);
								Console.WriteLine("Usuieto powiadomienie Push");
								break;
							case 7:
								Console.Write("Wpisz wiadomosc do wyslania: ");
								var message = Console.ReadLine();
								notificationManager.SendNotification(message);
								break;
							case 8:
								Console.WriteLine("Koniec programu");
								break;
							default:
								Console.WriteLine("Podano niepoprawna wartosc");
								break;
						}
					}
					catch(Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
		}
	}
}
