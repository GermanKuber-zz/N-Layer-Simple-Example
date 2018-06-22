using System;

namespace NLayer.Domain.Core.Invitations
{
    public class Room
    {
        public Guid Id { get; protected set; }
        public string Name { get; set; }
        public int MaxCapacity { get; protected set; } = 10;
        public int Capacity { get; set; }

        public void AddGuest(Action callBack)
        {
            if (Capacity < MaxCapacity)
            {
                callBack();
                ++Capacity;
            }
            else
            {
            }
        }
    }
}
