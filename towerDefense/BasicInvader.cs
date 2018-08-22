namespace TowerDefense
{
   class BasicInvader : Invader
   {
     
        //protected override int StepSize { get; } = 2;
     
        public override int Health { get; protected set; } = 2;
     
        public BasicInvader (Path path) : base(path)
        {}
   }
}