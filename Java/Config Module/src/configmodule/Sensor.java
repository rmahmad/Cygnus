package configmodule;
import javax.comm.*;

// TODO depending on the commonalities between the sensors, we can either make a polymorphic structure of sensors, make all separate classes for each
// 		type and ignore a parent class, or include them all in this class.  I don't care, but I dont know enough at this time to choose for us

public class Sensor implements Runnable {
	
	private int orientationDegree; // where is the sensor facing? 0 = right, 90 = front...
	private sensorType type;
	
	private static final double sonar2cm = 1.296;
	
	private int[] sensorData = new int[20]; // keeps track of the last 20 previous polls of sensor data in the event we need to reference to make
											// an informed decision about the surrounding environment
			
			
	Sensor(sensorType type, int orientationDegree)
	{
		this.type = type;
		this.orientationDegree = orientationDegree;
	}
	
	/*****************************************************
	 * Description:	Polls the sensor for its value
	 * 
	 * Returns:	The distance in ____ to nearest object // TODO choose distance measurement unit
	 ****************************************************/
	public int pollDistance()
	{
		if(this.type == sensorType.sonar) // sonar sensor
		{
			
		}
		else // reflective sensor
		{
			
		}
	}
	
	/*****************************************************
	 * Description:	Continuously polls the sensor for data
	 ****************************************************/
	public void run()
	{
		while (true)
		{
			for(int i = 0; i < 20; i++)
			{	
				this.sensorData[i] = pollDistance(); // using array due to the quick nature of the data type vs a linked list that takes lot of time to traverse
				Thread.sleep(100); // sleep thread for 100ms between data polling
			}
		}
	}
}
