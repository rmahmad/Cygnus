void setup() {
  // put your setup code here, to run once:
  system("mount /dev/mmcblk0p1 /media/card");
  system("/media/card/wifi.sh > /media/card/wifiscript.txt");
  system("ping -c 5 google.com > /media/card/ping.txt");

}

void loop() {
  // put your main code here, to run repeatedly: 
  
}
