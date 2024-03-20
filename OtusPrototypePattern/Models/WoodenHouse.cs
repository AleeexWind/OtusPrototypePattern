namespace OtusPrototypePattern.Models
{
    public class WoodenHouse : House, ICloneable
    {
        public int MaxFloor { get; set; }
        public override void GettingOld()
        {
            if (NumberOfResidents >= 2)
            {
                Condition -= 5;
            }
            else
            {
                Condition -= 2;
            }
            Console.WriteLine($"The codition of the WoodenHouse: {Condition}");
        }
        public override object Clone()
        {
            return MyClone();
        }
        public override Building MyClone()
        {
            return new WoodenHouse()
            {
                Address = this.Address,
                Cost = this.Cost,
                Condition = this.Condition,
                NumberOfResidents = this.NumberOfResidents,
                MaxFloor = this.MaxFloor
            };
        }
    }
}
