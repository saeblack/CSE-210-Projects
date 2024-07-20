using System;
using System.Collections.Generic;

namespace ExerciseTrackingApp
{
    class Program
    {
        static void Main()
        {
            // Create events
            var _events = new List<_Event>();

            var _lecture = new _Lecture("Introduction to C# Programming", "Learn the basics of C# programming language", new DateTime(2024, 7, 20), "10:00 AM", new _Address("123 Main St", "Anytown", "CA", "USA"), "John Doe", 100);
            var _reception = new _Reception("Company Anniversary Party", "Celebrate our successful year with food and drinks", new DateTime(2024, 7, 25), "7:00 PM", new _Address("456 Oak Ave", "Sometown", "NY", "USA"), "rsvp@example.com");
            var _outdoorGathering = new _OutdoorGathering("Summer Picnic", "Enjoy outdoor activities and BBQ", new DateTime(2024, 8, 5), "12:00 PM", new _Address("789 Maple Blvd", "Anyplace", "TX", "USA"), "Sunny with a chance of showers");

            _events.Add(_lecture);
            _events.Add(_reception);
            _events.Add(_outdoorGathering);

            // Display event details
            foreach (var _event in _events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(_event.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                Console.WriteLine(_event.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(_event.GetShortDescription());
                Console.WriteLine();
            }
        }
    }
}
