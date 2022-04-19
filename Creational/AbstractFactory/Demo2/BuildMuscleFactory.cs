using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Demo2
{
    public class BuildMuscleFactory : IGoalFactory
    {
        public IMealPlan createMealPlan()
        {
            return new BuildMuscleMealPlan();
        }

        public IWorkoutPlan createWorkoutPlan()
        {
            return new BuildMuscleWorkout();
        }
    }
}
