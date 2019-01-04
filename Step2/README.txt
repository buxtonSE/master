Overview: This project is gaining internationl success and we would like to reuse the components in other areas of code.

Todo: Extract the logic from STEP 1 into an interface with a concrete implementation that you completed in step1. Create a separate implementation that writes all requests to a "logfile.txt". The format of the log file should be
1/1/1900 3:18:23 PM - foobar --> [o,o,a]
1/1/1900 3:18:27 PM - test --> [e]
1/1/1900 3:18:36 PM - aeiou --> [a,e,i,o,u]
1/1/1900 3:18:52 PM - aayl  iiizzz --> [a,a,i,i,i]
1/1/1900 3:19:31 PM - --> invalid_operation

After this is completed there should be 2 implemeations of this top secret interface. 

Note: This project is of the wrong type. Change this project from a console application to a reusable class libary.