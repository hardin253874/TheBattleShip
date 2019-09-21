﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShip.Ships;

namespace TheBattleShip.Requests
{
    public class PlaceShipRequest
    {
        public Coordinate Coordinate { get; set; }
        public ShipDirection Direction { get; set; }
        public ShipType ShipType { get; set; }
    }
}
