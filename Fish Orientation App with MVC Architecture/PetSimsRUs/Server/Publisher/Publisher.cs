using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// CLASS to publish events
    /// </summary>
    class Publisher : IPublisher
    {
        // DECLARE an event of type EventHandler<MyArgs>, call it NewMessage
        public event EventHandler<MyArgs> NewMessage;

        /// <summary>
        /// METHOD to broadcast events
        /// </summary>
        /// <param name="listener"></param>
        public void Subscribe(EventHandler<MyArgs> listener)
        {
            // ADD event listener:
            NewMessage += listener;
        }

        /// <summary>
        /// METHOD to publish an event
        /// </summary>
        /// <param name="message"></param>
        private void OnDataChanged(String message)
        {
            // DECLARE an instance of the MyArgs class
            MyArgs args = new MyArgs(message);

            // INSTANTIATE the NewMessage event
            NewMessage(this, args);
        }
    }
}
