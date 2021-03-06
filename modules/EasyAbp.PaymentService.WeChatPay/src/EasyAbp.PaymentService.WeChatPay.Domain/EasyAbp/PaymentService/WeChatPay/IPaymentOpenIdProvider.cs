using System;
using System.Threading.Tasks;

namespace EasyAbp.PaymentService.WeChatPay
{
    public interface IPaymentOpenIdProvider
    {
        Task<string> FindUserOpenIdAsync(string appId, Guid userId);
    }
}