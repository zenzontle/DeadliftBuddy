using DeadliftBuddy.Web.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DeadliftBuddy.Web.Controllers
{
    [EnableCors("*", "*", "*")]
    public class RoutineController : ApiController
    {
        public string GetRoutine()
        {
            Routine routine = new Routine();
            routine.Name = "Push Pull Legs";
            routine.Exercises = new List<Exercise>();

            Exercise exercise = new Exercise();
            exercise.Description = "Squat 2x8 95";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Lunges 2x8 60";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Leg Curl 2x10 140";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Stiff Legged Deadlift 2x12 90";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Calf Raise 2x10 150";
            routine.Exercises.Add(exercise);

            return JsonConvert.SerializeObject(routine);
        }
    }
}