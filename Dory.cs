using System;

namespace FishMovement
{
    class Dory : Fish
    {
        public Dory()
        {
            _name = "Dory";
            _size = "M";
        }

        public override void DisplayInfo(Fish fish)
        {
            base.DisplayInfo(fish);
        }

        public override void Reservoirs(IReservoirs reservoirs)
        {
            Console.WriteLine($"Рыба {_name} перемещен в Резервуар #7");
        }
    }
}
