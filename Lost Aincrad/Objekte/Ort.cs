using LOST_Aincrad__experimental_;

namespace Lost_Aincrad.Objekte
{
    internal class Ort
    {
        public object Name { get; internal set; }

        internal Ort GetLocationInDirection(string? direction)
        {
            throw new NotImplementedException();
        }

        internal void Interact(Player player)
        {
            throw new NotImplementedException();
        }

        internal void OnPlayerArrived(Player player)
        {
            throw new NotImplementedException();
        }

        internal void ShowAvailableDirections()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Ort(ObjectMenu v)
        {
            throw new NotImplementedException();
        }
    }
}