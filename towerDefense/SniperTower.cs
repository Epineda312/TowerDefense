namespace TowerDefense
{
     class SniperTower : Tower
    {
        protected override int Range { get; } = 2;
        
        protected override double Accuracy { get; } = .75;
        
        public SniperTower(MapLocation location) : base(location)
        {}
    }
}
