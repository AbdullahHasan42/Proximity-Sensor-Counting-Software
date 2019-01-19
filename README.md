## Description

This application acts as a GUI between an Arduino Mega micro-controller and a PC.  It enables orders for a counting system using a 
proximity sensor to be sent over the serial COM ports. 

It saves a log after a run is completed containing Part Name, Part Number, Count 
reached over Target Count, as well as the total time taken for the run.

<p align="center"> 
	<img src="ProximitySensorCountingSoftware\PSCS.png" width="600px" title="PSCS">  
</p>

### Updated

- Renamed variable names to be more consistent.
- Updated the UI style.
- Organized parts of the code.
- Enabled logger to detect if a similar name exists, to prevent overwriting.
- Fixed issue with Restart button sometimes not working.
- Added a validation method to PartName, to accept valid file name characters.

### TODO

- Add a pause button
- Extend the pause feature to arduino
- Allow PSCS to increment counter using a substring from the arduino serial