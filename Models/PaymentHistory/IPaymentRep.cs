namespace CayThue.Models.PaymentHistory;

public interface IPaymentRep
{
    Payment GetPayment(string id);
    IEnumerable<Payment> GetAllPayments();
    Payment Add(Payment payment);
    Payment Update(Payment paymentChanges);
    Payment Delete(string id);
}