using System;

namespace BikeTraining
{
    public class BikeWorkouts : DistanceWorkout
    {
        public WorkoutType Type { get; }

        public BikeWorkouts(WorkoutType type, double distance, DateTime datetime, TimeSpan duration, double rate, string notes)
            : base(distance, datetime, duration, rate, notes)
        {
            Type = type;
        }
    }
}
