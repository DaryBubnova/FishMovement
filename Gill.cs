using System;

namespace FishMovement
{
    class Gill : Fish
    {
        public Gill()
        {
            _name = "Gill";
            _size = "M";
        }

        public override void DisplayInfo(Fish fish)
        {
            base.DisplayInfo(fish);
        }

        public override void Reservoirs(IReservoirs reservoirs)
        {
            Console.WriteLine($"Рыба {_name} перемещен в Резервуар #9");
        }
    }
}
