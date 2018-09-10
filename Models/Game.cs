using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketToRide.Models.Map;

namespace TicketToRide.Models
{
    class Game
    {
        enum PlayerColor { Red, Green, Blue, Yellow, Black};
        enum TrainColor { }
        private List<City> _cities = new List<City>() {};

        public List<City> Cities { get { return _cities; } }

    }
}
