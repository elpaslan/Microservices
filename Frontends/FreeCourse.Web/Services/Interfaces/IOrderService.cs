using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models.Orders;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Senkron iletişim - direk order microservice istek yapılacak
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput);

        /// <summary>
        /// Asenkron iletişim - sipariş bilgileri rabbitMQ'ya gönderilecek
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task<OrderSuspendViewModel> SuspendOrder(CheckoutInfoInput checkoutInfoInput);

        Task<List<OrderViewModel>> GetOrder();
    }
}
