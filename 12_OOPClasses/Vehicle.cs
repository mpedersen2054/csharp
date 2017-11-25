
namespace ConsoleApplication
{
    public class Vehicle
    {
        // Accessibility of variables is defaulted to internal
        // so we must add the public keyword to anything we
        // want to allow outside access to.
        public int numPassengers = 2;
        public double distance = 0.0;

        // CONSTRUCTOR
        // Notice the Constructor function doesn't need a return type or the static keyword
        public Vehicle(int passengers = 0)
        {
            numPassengers = passengers;
        }

        // overloading - The second for preowned with milage already
        public Vehicle(int val, double odo)
        {
            numPassengers = val;
            distance = odo;
        }

        public int Move(double miles)
        {
            distance += miles;
            return (int)distance;
        }
        // Method Overloading is the process of building multiple methods with the same name, but
        // different expected parameters. Based on what you pass the method when
        // you call it the system can figure out which version to run.
        public int Move(double miles, bool km)
        {
            // Convert the KM measurement to miles
            if (km == true)
            {
                miles = miles * 0.62;
            }
            return Move(miles);
        }
    }
}