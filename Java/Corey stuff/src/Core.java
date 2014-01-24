import java.util.ArrayList;


public class Core {
	
	// Configuration Module Components
	ArrayList<Motor> motors = new ArrayList<Motor>();
	ArrayList<Sensor> sensors = new ArrayList<Sensor>();
	ConfigurationModule myRobot;
	
	void init()
	{
		// create motors
		motors.add(new Motor(false,true,orientation.counterclockwise,0));
		motors.add(new Motor(false,true,orientation.clockwise,8));
		motors.add(new Motor(false,true,orientation.counterclockwise,15));
		motors.add(new Motor(false,true,orientation.clockwise,7));
		
		// create sensors
		sensors.add(new Sensor(sensorType.sonar,90));
		
		// create config module
		myRobot = new ConfigurationModule(motors,sensors);
	}
	
	public void translate(String command)
	{
		/* What commands will I be getting? */ 
		
		// TODO: Parse command into function name and parameters
		String functName = "";
		String params = "";
		
		// EXAMPLE
		switch(functName)
		{
			case "forward": myRobot.Forward();
			case "backward": myRobot.Backward();
			case "turn": myRobot.Turn(params);		
		}
	}
}