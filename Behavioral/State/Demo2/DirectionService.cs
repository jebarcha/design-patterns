using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Demo2
{
    public class DirectionService
    {
        private ITravelMode _travelMode;

        public DirectionService(ITravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public Object GetEta()
        {
            return _travelMode.GetEta();
        }

        public Object GetDirection()
        {
            return _travelMode.GetDirection();
        }

        public ITravelMode GetTravelMode()
        {
            return _travelMode;
        }

        public void SetTravelMode(ITravelMode travelMode)
        {
            _travelMode = travelMode;
        }
    }
}
