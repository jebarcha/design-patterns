using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Demo2
{
    public class HomePage
    {
        private IWorkoutPlan workoutPlan;
        private IMealPlan mealPlan;

        public void SetGoal(IGoalFactory goalFactory)
        {
            workoutPlan = goalFactory.createWorkoutPlan();
            mealPlan = goalFactory.createMealPlan();

            Console.WriteLine(workoutPlan);
            Console.WriteLine(mealPlan);
        }
        //public void SetGoal(Goal goal)
        //{
        //    if (goal == Goal.BUILD_MUSCLE)
        //    {
        //        workoutPlan = new BuildMuscleWorkout();
        //        mealPlan = new BuildMuscleMealPlan();
        //    }
        //    else if (goal == Goal.WEIGHT_LOSS)
        //    {
        //        workoutPlan = new WeightLossWorkout();
        //        mealPlan = new WeighLossMealPlan();
        //    }
        //    Console.WriteLine(workoutPlan);
        //    Console.WriteLine(mealPlan);
        //}
    }
}
