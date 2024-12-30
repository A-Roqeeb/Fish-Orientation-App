using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// CLASS to subscribe views to events
    /// </summary>
    class Controller
    {
        // DECLARE an instance of the IPublisher interface
        IPublisher _publisher;

        // DECLARE an instance of the IListener interface
        IListener _listener;

        /// <summary>
        /// CONSTRUCTOR for the Controller class
        /// </summary>
        public Controller()
        {
            // INSTANTIATE _publisher
            _publisher = new Publisher();

            // INSTANTIATE _listener
            _listener = new Listener();

        }
    }
}
