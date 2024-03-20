namespace OtusPrototypePattern.Models
{
    public class BrickHouse : House, ICloneable
    {
        public int MaxFloor { get; set; }
        public override void GettingOld()
        {
            if (NumberOfResidents >= 5)
            {
                Condition -= 3;
            }
            else
            {
                Condition -= 1;
            }
            Console.WriteLine($"The codition of the BrickHouse: {Condition}");
        }
        public override object Clone()
        {
            return MyClone();
        }
        public override Building MyClone()
        {
            return new BrickHouse()
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
