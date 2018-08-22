using System;

namespace TowerDefense
{
    class PowerfulTower : Tower
    {        
        public override int Power{ get;} = 2;
                        
        public PowerfulTower(MapLocation location) : base(location)
        {}        
    
    }   
}