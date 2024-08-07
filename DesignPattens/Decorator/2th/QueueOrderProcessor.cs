using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Decorator._2th
{
    public class QueueOrderProcessor : IOrderProcessor
    {
        private Queue<Order> _queue= new();
        public IOrderProcessor orderProcessor;

        public QueueOrderProcessor(IOrderProcessor orderProcessor)
        {
            this.orderProcessor = orderProcessor;
        }

        public void Process(Order order)
        {
            _queue.Enqueue(order);
            Console.WriteLine("order has Added In Queu System");
        }
    }
}
