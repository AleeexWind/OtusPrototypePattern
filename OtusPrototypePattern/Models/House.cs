namespace OtusPrototypePattern.Models
{
    public class House : Building, ICloneable
    {
        public int NumberOfResidents { get; set; }

        public virtual object Clone()
        {
            return MyClone();
        }

        public override void GettingOld()
        {
            if (NumberOfResidents >= 3)
            {
                Condition -= 3;
            }
            else
            {
                Condition -= 1;
            }
            Console.WriteLine($"The codition of the House: {Condition}");
        }

        public override Building MyClone()
        {
            return new House()
            {
                Address = this.Address,
                Cost = this.Cost,
                Condition = this.Condition,
                NumberOfResidents = this.NumberOfResidents
            };
        }
    }
}
