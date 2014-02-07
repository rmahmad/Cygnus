/*
 * The UART class is responsible for opening a serial communication port 
 */

import jssc.*;
import java.io.*;

public class UART {
	public static final int FRONT_LEFT = 8;
	public static final int FRONT_RIGHT = 7;
	public static final int BACK_LEFT = 15;
	public static final int BACK_RIGHT = 0;

	public static void main(String[] args) throws InterruptedException, SerialPortException {
		// TODO Auto-generated method stub

		SerialPort serialPort = initSerialPort("/dev/ttyUSB0");

		initRobot(serialPort);
		speedUp(serialPort);
		moveForward(serialPort);
		Thread.sleep(5000);
		stop(serialPort);
		
		closeSerialPort(serialPort);
	}

	private static SerialPort initSerialPort(String wantedPortName)
	{
		// Instantiate a serial port with desired name i.e "/dev/ttyUSB0"
		SerialPort serialPort = new SerialPort(wantedPortName);

		// The serial port should be opened with the following parameters:
		// Baud Rate: 2400
		// Data Bits: 8
		// Stop Bits: 1
		// Parity: None
		try {
			serialPort.openPort();
			serialPort.setParams(2400, 8, 1, 0);

		} catch (SerialPortException ex) {
			System.out.println(ex);
		}
		
		return serialPort;
	}

	public static void closeSerialPort(SerialPort port) throws SerialPortException {
		port.closePort();
	}

	public static void sendString(PrintStream os, String sendMe) throws InterruptedException
	{
		char[] sendArray = sendMe.toCharArray();

		for(int i = 0; i < sendMe.length(); i++)
		{
			os.print(sendArray[i]);
			Thread.sleep(10);
		}
	}	

	public static void moveForward(SerialPort port) throws SerialPortException {
		port.writeInt(70);
		port.writeInt(8);
		port.writeInt(66);
		port.writeInt(13);
	}
	
	public static void moveBackward(SerialPort port) throws SerialPortException {
		port.writeInt(70);
		//Thread.sleep(10);
		port.writeInt(13);
		//Thread.sleep(10);
		port.writeInt(66);
		//Thread.sleep(10);
		port.writeInt(8);
		//Thread.sleep(10);
	}

	public static void initRobot(SerialPort port) throws SerialPortException {
		port.writeInt(90);
	}

	public static void speedUp(SerialPort port) throws SerialPortException {
		port.writeInt(85);
	}

	public static void speedDown(SerialPort port) throws SerialPortException {
		port.writeInt(68);
	}

	public static void stop(SerialPort port) throws SerialPortException {
		port.writeInt(83);
		port.writeInt(8);
		port.writeInt(83);
		port.writeInt(13);
	}

	/*public void stop(int pinNumber)
	{
		os.write('S');
		Thread.sleep(10);
		os.write(pinNumber);
		Thread.sleep(10);
	}*/
}
