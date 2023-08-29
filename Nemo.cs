using System;

namespace FishMovement
{
    class Nemo : Fish
    {
        public Nemo()
        {
            _name = "Nemo";
            _size = "S";
        }

        public override void DisplayInfo(Fish fish)
        {
            base.DisplayInfo(fish);
        }

        public override void Reservoirs(IReservoirs reservoirs)
        {
            Console.WriteLine($"Рыба {_name} перемещен в Резервуар #5");
        }
    }
}
