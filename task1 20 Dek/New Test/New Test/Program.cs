using System;

namespace New_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DeathStar death = new DeathStar();
            death.FireLaser();
        }
    }

    #region HomeWork
    abstract class SpaceStation
    {
        public abstract void FireLaser();
    }
    class DeathStar : SpaceStation
    {
        public override void FireLaser()
        {
            Console.WriteLine("Pew Pew");
        }
    }
}
    #endregion


     