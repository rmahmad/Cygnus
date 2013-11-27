import com.phidgets.*;

public class SonarSensor {
	public static void main(String[] args) throws InterruptedException, PhidgetException {
		InterfaceKitPhidget phidget = new InterfaceKitPhidget();

		phidget.open(327977);
		phidget.waitForAttachment();
		
		while(true) {
			System.out.println(phidget.getSensorValue(2)*1.296 + " cm");
			Thread.sleep(1000);
		}
		
		
		
	}
}
