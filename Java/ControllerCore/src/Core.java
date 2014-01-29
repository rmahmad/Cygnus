//import javax.comm.*;
import gnu.io.*;
import java.util.*;
import java.io.*;

import com.phidgets.*;

class SonarSensor implements Runnable {
	Thread t;
	PrintStream os;
	
	public SonarSensor(PrintStream stream) {
		t = new Thread(this, "Sensor Thread");
		os = stream;
		System.out.println("Sensor Thread running");
		t.start();
	}
	
	public void run() {
		try {
			pollSensors(1000);
		} catch (PhidgetException e) {
			e.printStackTrace();
		} catch (InterruptedException e) {
			e.printStackTrace();
		} 
	}
	
	public void pollSensors(int msec) throws PhidgetException, InterruptedException {
		InterfaceKitPhidget phidget = new InterfaceKitPhidget();
		phidget.open(327977);
		phidget.waitForAttachment();
		
		while(true) {
			System.out.println("Sensor 2: " + phidget.getSensorValue(2)*1.296 + " cm");
			if(phidget.getSensorValue(2)*1.296 < 18) {
				sendStop();
			}
			Thread.sleep(1000);
		}
	}
	
	public void sendStop() throws InterruptedException {
		Core.stop(os);
	} 
	
}

public class Core {
	public static final int FRONT_LEFT = 8;
	public static final int FRONT_RIGHT = 7;
	public static final int BACK_LEFT = 15;
	public static final int BACK_RIGHT = 0;

	public static void main(String[] args) throws InterruptedException, IOException {
		SerialPort port = initSerialPort("/dev/ttyUSB0");
		PrintStream os = new PrintStream(port.getOutputStream(), true);
		
		new SonarSensor(os);
		
		try {
			System.out.println("Motor controller thread running");
			initRobot(os);
			speedUp(os);
			moveForward(os);
			Thread.sleep(5000);
			turnRight(os);
			Thread.sleep(1000);
			turnLeft(os);
			Thread.sleep(1000);
			moveBackward(os);
			Thread.sleep(2000);
			
			stop(os);

			if (os != null) os.close();
			if (port != null) port.close();
		}
		catch(InterruptedException e) {
			e.printStackTrace();
		}
	}
	
	private static SerialPort initSerialPort(String wantedPortName) throws IOException, InterruptedException
	{
		// Get an enumeration of all ports known to JavaComm
		Enumeration portIdentifiers = CommPortIdentifier.getPortIdentifiers();
		
		// Check each port identifier if 
		//   (a) it indicates a serial (not a parallel) port, and
		//   (b) matches the desired name.
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

		// Use port identifier for acquiring the port
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
		
		// Now we are granted exclusive access to the particular serial
		// port. We can configure it and obtain input and output streams.
		// Set all the params.  
		// This may need to go in a try/catch block which throws UnsupportedCommOperationException
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
		
		return port;
	}
	
	public static void moveForward(PrintStream os) throws InterruptedException {
		System.out.println("moving robot forward");
		os.write('F');
		Thread.sleep(10);
		os.write(BACK_LEFT);
		Thread.sleep(10);
		os.write('B');
		Thread.sleep(10);
		os.write(BACK_RIGHT);
		Thread.sleep(10);
	}
	
	public static void moveBackward(PrintStream os) throws InterruptedException {
		System.out.println("moving robot backward");
		os.write('B');
		Thread.sleep(10);
		os.write(BACK_LEFT);
		Thread.sleep(10);
		os.write('F');
		Thread.sleep(10);
		os.write(BACK_RIGHT);
		Thread.sleep(10);
	}
	
	public static void initRobot(PrintStream os) throws InterruptedException {
		os.write('Z');
	}
	
	public static void speedUp(PrintStream os) throws InterruptedException {
		os.write('U');
	}
	
	public static void speedDown(PrintStream os) throws InterruptedException {
		os.write('D');
	}
	
	public static void stop(PrintStream os) throws InterruptedException {
		os.write('S');
		Thread.sleep(10);
		os.write(BACK_LEFT);
		Thread.sleep(10);
		os.write('S');
		Thread.sleep(10);
		os.write(BACK_RIGHT);
		Thread.sleep(10);
	}
	
	public static void turnRight(PrintStream os) throws InterruptedException {
		os.write('F');
		Thread.sleep(10);
		os.write(BACK_LEFT);
		Thread.sleep(10);
		os.write('F');
		Thread.sleep(10);
		os.write(BACK_RIGHT);
		Thread.sleep(10);
	}
	
	public static void turnLeft(PrintStream os) throws InterruptedException {
		os.write('B');
		Thread.sleep(10);
		os.write(BACK_LEFT);
		Thread.sleep(10);
		os.write('B');
		Thread.sleep(10);
		os.write(BACK_RIGHT);
		Thread.sleep(10);
	}
}
