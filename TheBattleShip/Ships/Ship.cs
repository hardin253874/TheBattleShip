using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShip.Requests;
using TheBattleShip.Responses;

namespace TheBattleShip.Ships
{
    public class Ship
    {
        public ShipType ShipType { get; private set; }
        public string ShipName { get { return ShipType.ToString(); } }
        public Coordinate[] BoardPositions { get; set; }
        private int _lifeRemaining;
        public bool IsSunk { get { return _lifeRemaining == 0; } }

        public Ship(ShipType shipType, int numberOfSlots)
        {
            ShipType = shipType;
            _lifeRemaining = numberOfSlots;
            BoardPositions = new Coordinate[numberOfSlots];
        }

        public ShotStatus FireAtShip(Coordinate position)
        {
            if (BoardPositions.Contains(position)) {
                _lifeRemaining--;

                if (_lifeRemaining == 0)
                    return ShotStatus.HitAndSunk;

                return ShotStatus.Hit;
            }

            return ShotStatus.Miss;
        }
    }
}
