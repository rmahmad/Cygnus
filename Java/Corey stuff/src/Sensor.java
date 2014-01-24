
public class Sensor {
	
	private int orientationDegree; // where is the sensor facing? 0 = right, 90 = front...
	private sensorType type;
	
	private static final double sonar2cm = 1.296;
	
	Sensor(sensorType type, int orientationDegree)
	{
		this.type = type;
		this.orientationDegree = orientationDegree;
	}

	/*************************************
	 * INSERT CODE TO CONTROL SENSOR HERE
	 ************************************/
	public int pollDistance()
	{
		
	}
}
