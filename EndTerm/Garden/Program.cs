namespace Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden(new List<Parcel> { new Parcel(), new Parcel(), new Parcel() });
            garden.Plant(Potato.GetInstance(), 0, 3);
            garden.Plant(Onion.GetInstance(), 1, 1);
            garden.Plant(Rose.GetInstance(), 2, 1);

            foreach (int i in garden.canHarvest(6)) {
                Console.WriteLine(i);
            }
        }
    }
}
