namespace cs31_paskaita_Interface
{
    public class BmwCar : AbstractCar
    {
        // (2) Sukurkite klasę BmwCar, kuri paveldės iš klasės Car ir turės savo property Bool IsXdrive.
        public bool IsXdrive { get; set; }

        public BmwCar(bool isXdrive, string model, int fuel) : base(model, fuel)
        {
            IsXdrive = isXdrive;
        }
    }
}
