using System;

public class GalacticTravelAgency
{
    public static void Main(string[] args)
    {
        string passengerName = "Zara";
        int passengerAge = 29;
        string ticketType = "First Class";
        string preferredPlanet = "Mars";
        string passengerAgeString = Convert.ToString(passengerAge);
        double passengerAgeDouble2 = passengerAge;
        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAge);
        Console.WriteLine(ticketType);
        Console.WriteLine(preferredPlanet);
        Console.WriteLine(passengerAgeDouble2);
        Console.WriteLine(passengerAgeString);
    }
}
