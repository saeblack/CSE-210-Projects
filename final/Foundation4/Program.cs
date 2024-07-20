using System;
using System.Collections.Generic;

namespace ExerciseTrackingApp
{
    class Program
    {
        static void Main()
        {
            // Create activities
            var _activities = new List<_Activity>();

            var _runningActivity = new _Running(new DateTime(2024, 7, 10), 30, 3.0);
            var _cyclingActivity = new _StationaryBicycles(new DateTime(2024, 7, 12), 45, 20);
            var _swimmingActivity = new _Swimming(new DateTime(2024, 7, 15), 60, 15);

            _activities.Add(_runningActivity);
            _activities.Add(_cyclingActivity);
            _activities.Add(_swimmingActivity);

            // Display activity summaries
            foreach (var _activity in _activities)
            {
                Console.WriteLine(_activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}
