using System;

namespace BikeTraining
{
    public class Workout
    {
        public string Notes;
        public DateTime Date { get; }
        public TimeSpan Duration { get; set; }
        public double AverageHeartRate { get; set; }

        public Workout(DateTime date, TimeSpan duration, double averageHeartRate, string notes)
        {
            Date = date;
            Duration = duration;
            AverageHeartRate = averageHeartRate;
            Notes = notes;
        }
    }
}
