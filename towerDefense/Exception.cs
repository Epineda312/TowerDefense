namespace TowerDefense
{
    class TowerDefense : System.Exception
    {
        public TowerDefenseException()
        {
        }
        
        public TowerDefenseException(string message) : base(message)
        {
        }
    }
    
    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
