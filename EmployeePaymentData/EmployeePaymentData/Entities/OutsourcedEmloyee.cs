namespace EmployeePaymentData.Entities
{
    public class OutsourcedEmloyee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmloyee() { }

        public OutsourcedEmloyee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}