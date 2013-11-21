import javax.comm.*;

import java.util.*;
import java.io.*;

public class UART {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		try {
		init("COM5");
		}
		catch(IOException e)
		{
			System.err.println(e);
		}
	}
	
	private static void init(String wantedPortName) throws IOException, InterruptedException
	{
		//////String wantedPortName = "/dev/ttya";
		 
		//SerialPort test = null;
		//
		// Get an enumeration of all ports known to JavaComm
		//
		Enumeration portIdentifiers = CommPortIdentifier.getPortIdentifiers();
		//
		// Check each port identifier if 
		//   (a) it indicates a serial (not a parallel) port, and
		//   (b) matches the desired name.
		//
		CommPortIdentifier portId = null;  // will be set if port found
		while (portIdentifiers.hasMoreElements())
		{
		    CommPortIdentifier pid = (CommPortIdentifier) portIdentifiers.nextElement();
		    if(pid.getPortType() == CommPortIdentifier.PORT_SERIAL &&
		       pid.getName().equals(wantedPortName)) 
		    {
		        portId = pid;
		        break;
		    }
		}
		if(portId == null)
		{
		    System.err.println("Could not find serial port " + wantedPortName);
		    System.exit(1);
		}
		//
		// Use port identifier for acquiring the port
		//
		SerialPort port = null;
		try {
		    port = (SerialPort) portId.open(
		        "name", // Name of the application asking for the port 
		        10000   // Wait max. 10 sec. to acquire port
		    );
		} catch(PortInUseException e) {
		    System.err.println("Port already in use: " + e);
		    System.exit(1);
		}
		//
		// Now we are granted exclusive access to the particular serial
		// port. We can configure it and obtain input and output streams.
		//
		//
		// Set all the params.  
		// This may need to go in a try/catch block which throws UnsupportedCommOperationException
		//
		try{
			port.setSerialPortParams(
				    2400,
				    SerialPort.DATABITS_8,
				    SerialPort.STOPBITS_1,
				    SerialPort.PARITY_NONE);
		}
		catch(UnsupportedCommOperationException e)
		{
			System.err.println(e);
		}
		

		//
		// Open the input Reader and output stream. The choice of a
		// Reader and Stream are arbitrary and need to be adapted to
		// the actual application. Typically one would use Streams in
		// both directions, since they allow for binary data transfer,
		// not only character data transfer.
		//
		BufferedReader is = null;  // for demo purposes only. A stream would be more typical.
		PrintStream    os = null;

		try {
		  is = new BufferedReader(new InputStreamReader(port.getInputStream()));
		} catch (IOException e) {
		  System.err.println("Can't open input stream: write-only");
		  is = null;
		}

		//
		// New Linux systems rely on Unicode, so it might be necessary to
		// specify the encoding scheme to be used. Typically this should
		// be US-ASCII (7 bit communication), or ISO Latin 1 (8 bit
		// communication), as there is likely no modem out there accepting
		// Unicode for its commands. An example to specify the encoding
		// would look like:
		//
//		     os = new PrintStream(port.getOutputStream(), true, "ISO-8859-1");
		//
		os = new PrintStream(port.getOutputStream(), true);

		sendString(os);
		
		OutputStream output = port.getOutputStream();
		  
		//
		// Actual data communication would happen here
		// performReadWriteCode();
		//

		//
		// It is very important to close input and output streams as well
		// as the port. Otherwise Java, driver and OS resources are not released.
		//
		if (is != null) is.close();
		if (os != null) os.close();
		if (port != null) port.close();
	}

	public static void sendString(PrintStream os) throws InterruptedException
	{
		//os.print("!SCPSD\r\r");
		//os.print(new char[]{'!', 'S', 'C', 'P', 'E', '\r', '\r'});
		/*os.print('!');
		Thread.sleep(10);
		os.print('S');
		Thread.sleep(10);
		os.print('C');
		Thread.sleep(10);
		os.print('P');
		Thread.sleep(10);
		os.print('S');
		Thread.sleep(10);
		os.print('D');
		Thread.sleep(10);
		os.print('\r');
		Thread.sleep(10);
		os.print('\r');
		Thread.sleep(10);
		os.print('!');
		Thread.sleep(10);
		os.print('S');
		Thread.sleep(10);
		os.print('C');
		Thread.sleep(10);
		os.print('P');
		Thread.sleep(10);
		os.print('S');
		Thread.sleep(10);
		os.print('D');
		Thread.sleep(10);
		os.print('\r');
		Thread.sleep(10);
		os.print('\r');
		/*os.print('!');
		os.print('S');
		os.print('C');
		os.print('P');
		os.print('S');
		os.print('D');
		os.print('\r');
		os.print('\r');*/
		
		os.write(13);
		Thread.sleep(10);
		os.write(13);
	}
}
