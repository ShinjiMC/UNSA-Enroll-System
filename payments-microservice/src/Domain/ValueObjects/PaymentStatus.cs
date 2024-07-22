namespace PaymentsMicroservice.Domain.ValueObjects
{
    public class PaymentStatus
    {
        public string Status { get; }

        public PaymentStatus(string status)
        {
            Status = status;
        }
    }
}
