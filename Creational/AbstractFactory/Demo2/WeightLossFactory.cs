using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Demo2
{
    public class WeightLossFactory : IGoalFactory
    {
        public IMealPlan createMealPlan()
        {
            return new WeighLossMealPlan();
        }

        public IWorkoutPlan createWorkoutPlan()
        {
            return new WeightLossWorkout();
        }
    }
}
