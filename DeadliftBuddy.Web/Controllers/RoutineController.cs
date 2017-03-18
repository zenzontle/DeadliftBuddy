﻿using DeadliftBuddy.Web.Models;
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
            routine.Id = 1;
            routine.Name = "Push Pull Legs";
            routine.Exercises = new List<Exercise>();

            Exercise exercise = new Exercise();
            exercise.Description = "Bench Press 2x8";
            exercise.CurrentWeight = 80;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Chest Flyes 3x8";
            exercise.CurrentWeight = 60;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Shoulder Seated Press 3x5";
            exercise.CurrentWeight = 65;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Lateral Raise 2x8";
            exercise.CurrentWeight = 30;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Triceps 2x8";
            exercise.CurrentWeight = 57.5M;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Squat 2x8";
            exercise.CurrentWeight = 95;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Lunges 2x8";
            exercise.CurrentWeight = 60;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Leg Curl 2x10";
            exercise.CurrentWeight = 140;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Stiff Legged Deadlift 2x12";
            exercise.CurrentWeight = 90;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Calf Raise 2x10";
            exercise.CurrentWeight = 150;
            routine.Exercises.Add(exercise);

            routines.Add(routine);

            routine = new Routine();
            routine.Id = 2;
            routine.Name = "Texas Method";
            routine.Exercises = new List<Exercise>();

            exercise = new Exercise();
            exercise.Description = "Squat 3x5";
            exercise.CurrentWeight = 130;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Bench Press 3x5";
            exercise.CurrentWeight = 90;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "SDSL 3x5";
            exercise.CurrentWeight = 47.5M;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Incline Chest Flyes/Press";
            exercise.CurrentWeight = 55;
            routine.Exercises.Add(exercise);

            routines.Add(routine);

            routines.Add(new Routine() { Id = 3, Name = "Test1" });
            routines.Add(new Routine() { Id = 3, Name = "Test2" });
            routines.Add(new Routine() { Id = 3, Name = "Test3" });
            routines.Add(new Routine() { Id = 3, Name = "Test4" });

            return routines;
        }
        public Routine GetRoutine(int id)
        {
            Routine routine = new Routine();
            routine.Id = id;
            routine.Name = "Push Pull Legs";
            routine.Exercises = new List<Exercise>();

            Exercise exercise = new Exercise();
            exercise.Description = "Squat 2x8";
            exercise.CurrentWeight = 95;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Lunges 2x8";
            exercise.CurrentWeight = 60;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Leg Curl 2x10";
            exercise.CurrentWeight = 140;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Stiff Legged Deadlift 2x12";
            exercise.CurrentWeight = 90;
            routine.Exercises.Add(exercise);

            exercise = new Exercise();
            exercise.Description = "Calf Raise 2x10";
            exercise.CurrentWeight = 150;
            routine.Exercises.Add(exercise);

            return routine;
        }
    }
}