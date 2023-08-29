using System;

namespace FishMovement
{
    class Fish : IReservoirs
    {
        protected string _name;
        protected string _size;

        public virtual void DisplayInfo(Fish fish)
        {
            fish.Info(_name, _size);
        }
        
        public virtual void Info(string name, string size)
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Размер: {size}");
        }

        public virtual void Reservoirs(IReservoirs reservoirs) {  }
    }
}
