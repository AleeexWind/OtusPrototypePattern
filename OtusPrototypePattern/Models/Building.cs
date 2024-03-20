namespace OtusPrototypePattern.Models
{
    public abstract class Building : IMyCloneable<Building>
    {
        public string Address { get; set; } = string.Empty;
        public double Cost { get; set; }
        public double Condition { get; protected set; } = 100.0;

        public abstract void GettingOld();

        public abstract Building MyClone();
    }
}
