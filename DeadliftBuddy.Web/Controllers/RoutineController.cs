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
        public IEnumerable<Routine> GetRoutines()
        {
            List<Routine> routines = new List<Routine>();

            Routine routine = new Routine();
            routine.Name = "Push Pull Legs";
            routine.Exercises = new List<Exercise>();

            Exercise exercise = new Exercise();
            exercise.Description = "Bench Press 2x8 80";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Chest Flyes 3x8 60";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Shoulder Seated Press 3x5 65";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Lateral Raise 2x8 30";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Triceps 2x8 57.5";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
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

            routines.Add(routine);

            routine = new Routine();
            routine.Name = "Texas Method";
            routine.Exercises = new List<Exercise>();

            exercise = new Exercise();
            exercise.Description = "Squat 3x5 130";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Bench Press 3x5 90";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "SDSL 3x5 47.5";
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Incline Chest Flyes/Press 55";
            routine.Exercises.Add(exercise);

            routines.Add(routine);

            return routines;
        }
        public string GetRoutine(int id)
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