using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public delegate void Notify(string message);

    public class Notifications
    {
        public void EmailNotification(string message)
        {
            Console.WriteLine("Email Notification: " + message);
        }

        public void SMSNotification(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }

        public void PushNotification(string message)
        {
            Console.WriteLine("Push Notification: " + message);
        }
    }

    public class ChainInvocation
    {
        public Notify CreateAndExecuteNotifyChain()
        {
            Notifications notifications = new Notifications();

            // Create instances of the delegate
            Notify notify1 = notifications.EmailNotification;
            Notify notify2 = notifications.SMSNotification;
            Notify notify3 = notifications.PushNotification;

            // Combine delegates
            //Notify allNotifications = notify1 + notify2;
            Notify allNotifications = (Notify)Delegate.Combine(notify1, notify2);
            allNotifications += notify3;
            allNotifications += notify1;

            // Invoke the multicast delegate – Chain Invocation – Delegates are immutable
            allNotifications("You have a new message!");

            Console.WriteLine($"------------------------------------");
            var notifyList = allNotifications.GetInvocationList();
            foreach (Notify notify in notifyList)
            {
                Console.WriteLine($"{notify.Target} : {notify.Method}");
            }

            Console.WriteLine($"------------------------------------");
            // Remove a method from the delegate
            allNotifications -= notify1;

            // Invoke the multicast delegate again
            allNotifications("Another message!");

            Console.WriteLine($"------------------------------------");
            notifyList = allNotifications.GetInvocationList();
            foreach (Notify notify in notifyList)
            {
                Console.WriteLine($"{notify.Target} : {notify.Method}");
            }
            return allNotifications;           
        }
        
    }
}
