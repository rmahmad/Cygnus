import java.util.ArrayList;


public class ConfigurationModule {
	
	private ArrayList<Motor> motors = new ArrayList<Motor>();
	private ArrayList<Sensor> sensors = new ArrayList<Sensor>();
	public UART comms = new UART();
	
	ConfigurationModule(ArrayList<Motor> motors, ArrayList<Sensor> sensors)
	{
		this.motors = motors;
		this.sensors = sensors;
		init();
	}
	
	private void init()
	{
		// initialize motors
		comms.sendString("!SCPE/r/r");
		
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Stop()); // stops the motors after initialization
		}

		// initialize sensors
		
	}
		
	public void Forward()
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Forward());
		}
	}
	
	public void Backward()
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			comms.sendString(motors.get(i).Backward());
		}
	}
	
	public void Turn(String direction)
	{
		for(int i = 0; motors.get(i) != null; i++)
		{
			if(direction.toLowerCase() == "right")
			{
				comms.sendString(motors.get(i).Right());
			}
			else
			{
				comms.sendString(motors.get(i).Left());
			}
		}
	}
}
