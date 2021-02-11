using hurb_sap.Models;

namespace hurb_sap.Domain.Services.Payments
{
    public interface IPaymentsService
    {
        ResponseModel Add(PaymentsModel payment);
        ResponseModel Read(int id);
    }
}
