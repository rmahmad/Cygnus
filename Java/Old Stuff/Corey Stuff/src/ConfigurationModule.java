import java.io.File;
import java.io.IOException;
import java.util.Scanner;
import java.util.ArrayList;


public class ConfigurationModule {
	
	private ArrayList<Motor> motors = new ArrayList<Motor>();
	private ArrayList<Sensor> sensors = new ArrayList<Sensor>();
	private UART comms = new UART();
	
	/*******************************************************************************
	*	Constructor for Robot.  Call this from the interpreter
	*******************************************************************************/
	ConfigurationModule(ArrayList<Motor> motors, ArrayList<Sensor> sensors)
	{
		this.motors = motors;
		this.sensors = sensors;
		init();
	}

//******************************************** FILE I/O SECTION ***********************************************************
	// TODO Corey will complete the fileIO section by Fridays meeting with an example file. Not necessary for right now
	/***************************************************
	*	Constructor for creating from file
	***************************************************/
	ConfigurationModule(String filepath) throws IOException
	{	
		Scanner scan = new Scanner(new File(filepath)); // delimiter is newline char
		boolean motor = false; 
		boolean sensor = false;
		
		// parse line by line
		while(scan.hasNext()) // still has lines to read from file
		{
			String parseMe = scan.next(); // string to parse from file
			
			// setting the flags for parsing
			if(parseMe.contains("motors:")) // motor data is coming next line
			{
				sensor = false; // just in case.  The motor data should always be first
				motor = true;
			}
			else if(parseMe.contains("sensors:")) // sensor data is coming next line
			{
				motor = false;
				sensor = true;
			}
			
			// create a motor
			if(motor)
			{
				// parse drive
				int index = parseMe.indexOf('\t');
				String drive = parseMe.substring(0,index);
				parseMe = parseMe.substring(index+1);
				
				// parse turn
				index = parseMe.indexOf('\t');
				String turn = parseMe.substring(0,index);
				parseMe = parseMe.substring(index+1);
				
				// parse oriented
				index = parseMe.indexOf('\t');
				String oriented = parseMe.substring(0,index);
				
				// parse pinNumber
				String pinNumber = parseMe.substring(index).trim();
				
				// convert the strings to the correct data types
				boolean Drive = Boolean.valueOf(drive);
				boolean Turn = Boolean.valueOf(turn);
				int PinNumber = Integer.valueOf(pinNumber);
				orientation Orient = orientation.valueOf(oriented);
				
				// add motor to ArrayList for ConfigModule 
				this.motors.add(new Motor(Drive,Turn,Orient,PinNumber));
			}
				
			else if(sensor) // creating sensors
			{
				// TODO once sensor objects are decided, create them from file here
			}			
		}
	}
	
	/*********************************************************************************
	 * 	Description:	Saves the ConfigurationModule to file
	 * 
	 * 	Parameters: 	filepath - the path including filename where the configuration
	 * 					file is to be saved
	 *********************************************************************************/
	
	
	public void SaveConfiguration(String filepath)
	{
				
	}
	
//************************************************************ FILE I/O END ***********************************************
	
	
	/***************************************************
	*	Initializes the ConfigurationModule
	***************************************************/
	private void init()
	{
		// initialize motors
		comms.sendString("!SCPE/r/r");
		
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Stop()); // stops the motors after initialization
		}

		// initialize sensors TODO
		
	}
	
	/***************************************************************
	*	Description: Moves the robot forward indefinitely
	***************************************************************/
	public void Forward()
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Forward());
		}
	}
	
	/***************************************************************
	*	Description: Moves the robot forward a specified distance 
	***************************************************************/
	public void Forward(int distance) // TODO how do we want distance measured?
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Forward());
		}
		
		// TODO use the sensor data to detect condition to stop
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Stop());
		}
	}
	
	/***************************************************************
	*	Description: Moves the robot forward a specified distance or
	*				 time
	***************************************************************/
	public void Forward(int length, boolean time) // TODO how do we want distance or time measured?
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Forward());
		}
		
		if(time) // if measured by time
		{
			// TODO use the sensor data to detect condition to stop
			for(int i = 0; motors.get(i) != null; i++)
			{
				comms.sendString(motors.get(i).Stop());
			}
		}
		else // measured by distance
		{
			// TODO use the sensor data to detect condition to stop
			for(int i = 0; motors.get(i) != null; i++)
			{
				comms.sendString(motors.get(i).Stop());
			}
		}
	}
	
	/***************************************************************
	*	Description: Moves the robot backward indefinitely
	***************************************************************/
	public void Backward()
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Backward());
		}
	}
	
	/***************************************************************
	*	Description: Moves the robot backward by a provided distance
	*				 or time
	***************************************************************/
	public void Backward(int length, boolean time)
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Backward());
		}
		
		if(time) // if measured by time
		{
			// TODO use the sensor data to detect condition to stop
			for(int i = 0; motors.get(i) != null; i++)
			{
				comms.sendString(motors.get(i).Stop());
			}
		}
		else // measured by distance
		{
			// TODO use the sensor data to detect condition to stop
			for(int i = 0; motors.get(i) != null; i++)
			{
				comms.sendString(motors.get(i).Stop());
			}
		}
	}
	
	// TODO this may need to change how it works depending on what is needed
	//      This scheme was used to provide more accurate functionality in 
	//		case that is desired. 
	/***************************************************************
	*	Params: int degrees - provide number between 0 and 360
	*
	*	Description: Turns the robot a specified number of degrees 
	*				 corresponding to the coordinate plane
	*
	*	Notes:	Imagine the robot on the origin of a coordinate plane
	*			facing the y axis at 90 degrees.  To turn 90 degrees 
	*			to the right, supply a value of '0' or '360' for 
	*			parameter 'degrees'
	***************************************************************/
	public void Turn(int degrees)
	{
		// deciding which direction the wheels need to turn
		if(degrees > 90) 
		{
			if(degrees > 270) // turn robot clockwise
			{
				for(int i = 0; motors.get(i) != null; i++)
				{					
					comms.sendString(motors.get(i).Right()); // TODO note: i use both clockwise wording and right/left wording to see which the group likes better and needs to be standardized
				}
			}
			else // turn robot counterclockwise
			{
				for(int i = 0; motors.get(i) != null; i++)
				{
					comms.sendString(motors.get(i).Left());
				}
			}
		}
		else // degrees < 90 so turn clockwise
		{
			for(int i = 0; motors.get(i) != null; i++)
			{
				comms.sendString(motors.get(i).Right());
			}
		}
		
		// TODO use sensors to calculate condition to stop the motors
		
	}
}
