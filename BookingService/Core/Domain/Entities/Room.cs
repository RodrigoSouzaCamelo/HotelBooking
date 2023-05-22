namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool InMaintenance { get; set; }

        public bool IsAvailable()
        {
            return !(this.InMaintenance || this.HasGuest());
        }

        public bool HasGuest()
        {
            //TODO: Verificar se existem bookings abertos para este quarto
            return true;
        }
    }
}
