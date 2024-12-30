using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// INTERFACE to be used by classes that make use of publish methods
    /// </summary>
    public interface IPublisher
    {


        /// <summary>
        /// METHOD to broadcast events
        /// </summary>
        /// <param name="listener"></param>
        void Subscribe(EventHandler<MyArgs> listener);


    }
}