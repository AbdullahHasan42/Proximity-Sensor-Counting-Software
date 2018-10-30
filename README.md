##Description

This application acts as an interface between an Arduino Mega micro-controller and a PC.

It enables orders for a counting system to be sent over the serial COM ports.

###Updated:
	- Renamed variable names to be more consistent
	- Updated the UI style
	- Organized some parts of the code
###TODO:
	- Enable logger to detect if a similar name exists, to prevent overwriting.
	- Add a validation method to PartName, to be accepting only alphanumerics.
	- Revise code for RESTART button, as the feature often fails to execute.