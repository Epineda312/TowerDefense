namespace TowerDefense
{
  interface IMappable
  {
    MapLocation Location { get; }
  }
  
  interface IMovable
  {
    void Move();
  }
  
  interface IInvader : IMappable, IMovable
  {
                  
        bool HasScored { get; }
        
        int Health { get; }
        
        bool IsNeutralized { get; }
        
        bool IsActive { get; }
                
        void Move(); 
        
        void DecreaseHealth(int factor);
              
   }
 }
