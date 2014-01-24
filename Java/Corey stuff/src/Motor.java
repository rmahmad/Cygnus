
public class Motor {
		
	private boolean drive; // used to drive forward/back?
	private boolean turn; // used to turn?
	private orientation oriented;
	public int pinNumber; // ERROR may not need
	
	Motor(boolean drive, boolean turn, orientation oriented, int pinNumber)
	{
		this.drive = drive;
		this.turn = turn;
		this.oriented = oriented;
		this.pinNumber = pinNumber;
	}
	
	public String Forward()
	{
		if (drive) // this motor helps drive forward
		{
			if (oriented == orientation.clockwise)
			{
				return ("F" + this.pinNumber);
			}
			else
			{
				return ("B" + this.pinNumber);
			}
		}
		else // do nothing for driving forward
		{
			return (null);
		}
	}
	
	public String Backward()
	{
		if (drive) // this motor helps drive backward
		{
			if (oriented == orientation.clockwise)
			{
				return ("B" + this.pinNumber);
			}
			else
			{
				return ("F" + this.pinNumber);
			}
		}
		else // do nothing for driving backward
		{
			return (null);
		}
	}
	
	public String Right()
	{
		if (turn) // this motor helps turn right
		{
			if (oriented == orientation.clockwise)
			{
				return ("F" + this.pinNumber);
			}
			else
			{
				return ("B" + this.pinNumber);
			}
		}
		else // do nothing for turning right
		{
			return (null);
		}
		
	}
	
	public String Left()
	{
		if (turn) // this motor helps turn left
		{
			if (oriented == orientation.clockwise)
			{
				return ("B" + this.pinNumber);
			}
			else
			{
				return ("F" + this.pinNumber);
			}
		}
		else // do nothing for turning left
		{
			return(null);
		}
	}
	
	public String Stop()
	{
		return ("S" + this.pinNumber);
	}
}
