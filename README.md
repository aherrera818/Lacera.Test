# Lacera.Test
A simple CSV Parcer , built with c#

public Employee { 
      Has Main properties of an Employee.
      Name, dob , salary, etc
    }
public EmployeeRecord : Employee {
      The EmployeeRecord inherits from the Employee class, but has some additional properties, those being some validation booleans,
      I made a child class for the Employee class , only to make things a little more neat.
}

public static CsvParser {
      A container to hold my "Parser" method. 
      This method takes a string "file" parameter, and an output parmeter being a "invalid list"
      It utilizes some VB classes, and creates an instance of a "TextFieldParser", 
      the "TextFieldParser" is a class , that comes with some straightforward properties, that basically set up rules for my parser instance to listen too.
      Once it gets to the while loop , what it does is that it creates an instance of the an Employee Record , and match up with the fields being
      read, with the matching Employee properties. Then it goes through some validation that utilizes the EmployeeRecord boolean properties to see if any of the fields
      are invalid and or valid.
      Once the reader has gone through all fields , and populated the employee object, it runs through another validation if statement where it appends said object
      to either the Valid and or Invalid list.
      }

Improvements:
Minor Cosmetic UI on the Web app, that'll get too, was to focused on functionality .
Set up "File.Exists()" inside of parser method.
Console App needs some string formatting.

