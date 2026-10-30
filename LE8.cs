namespace COMPSCI221;

public static class LE8
{
	private static void Main() 
	{
		object[] devices = [
			new Smartphone("7732025862"),
			new Computer2("UWW-LIBRARY-PC"),
			new Phone("2624721992"),
			new Pager(1234),
			new Computer2("UWW-OFFICE-MAC"),
			new Computer2("UWW-OFFICE-PC"),
			new Pager(5678),
			new Phone("2624721666"),
			new Smartphone("7082222222"),
			new Smartphone("8005882300"),
			new Pager(9999),
		];

		Console.WriteLine("Testing phone services...");
		// Iterate over all devices
		// If the device is an ICallReceiver, call the ReceiveCall method with the number 2624721234

		for (int i = 0; i < devices.Length; i++)
		{
			if (devices[i] is ICallReceiver c)
			{
                c.ReceiveCall("2624721234");
			}
		}

		Console.WriteLine("\nTesting email services...");
        // Iterate over all devices
        // If the device is an IEmailReceiver, call the ReceiveEmail method with the email address "alerts@uww.edu" and subject "System Test"

        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i] is IEmailReceiver e)
            {
                e.ReceiveEmail("alerts@uww.edu", "System Test");
            }
        }

        Console.WriteLine("\nTesting text services...");
        // Iterate over all devices
        // If the device is an ITextReceiver, call the ReceiveText method with the message "r u receiving?"

        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i] is ITextReceiver t)
            {
                t.ReceiveText("r u receiving?");
            }
        }
    }
}