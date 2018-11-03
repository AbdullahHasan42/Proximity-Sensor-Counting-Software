## Description

This application acts as an GUI between an Arduino Mega micro-controller and a PC.  It enables orders for a counting system using a 
proximity sensor to be sent over the serial COM ports. 

It saves a log after a run is completed containing Part Name, Part Number, Count 
reached over Target Count, as well as the total time taken for the run.

### Updated:
	- Renamed variable names to be more consistent.
	- Updated the UI style.
	- Organized parts of the code.
	- Enabled logger to detect if a similar name exists, to prevent overwriting.
	- Fixed issue with Restart button sometimes not working.
	- Added a validation method to PartName, to be accepting valid characters for a file name.
	
### TODO:
	- Add an Interrupt Stop button
