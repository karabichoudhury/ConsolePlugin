# ConsolePlugin

This solution aims at providing a console screen aimed at running commands.
Angularjs is used to create the front end.User can type in commands in the console screen.Apart for some commands, most of the commands are passed to server. 
The backend has a WCF rest service , which has a method exposed to recieve commands.
Angularjs will call this service to execute the commands.

How to run

1) Run the WCFRestfulService
2) Browse Index.html from WebApp.
3) Press Ctrl. This will show the console.
4) Click on the console.
5) Commands - CREATE,UPDATE,DELETE,READ - This can be followed by anything
eg: delete something
6) CLS - for clearing the screen
7) EXIT - for closing the console
