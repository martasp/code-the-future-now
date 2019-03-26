// namespace CodeTheFutureNowBad
// {
//     using System;
//     using System.Collections.Generic;
//     using System.Linq;
//     using System.Threading.Tasks;
//     using NServiceBus;

//     public class Order
//     {
//         public void Submit()
//         {
//             var weekTotal = this.allOrders.Where(o =>
//                 o.CustomerId == this.CustomerId &&
//                 o.Timestamp >= this.Timestamp.AddDays(-7))
//               .Sum(o => o.Total);

//             var discount = weekTotal >= 100
//               ? 10
//               : 0;

//             // more stuff...
//         }

//         // more stuff...
//     }

//     public class Batch
//     {
//         public void Run()
//         {
//             foreach (var c in customers)
//             {
//                 if (orders
// 					.Where(o =>
// 						o.CustomerId = c.Id &&
// 						o.Timestamp >= this.Timestamp.AddDays(-7))
// 					.Sum(o => o.Value) >= 100)
//                 {
//                   	c.Discount = 10;
//                 }
//                 else
//                 {
//                   	c.Discount = 0;
//                 }
//             }
//         }
//     }
// }
