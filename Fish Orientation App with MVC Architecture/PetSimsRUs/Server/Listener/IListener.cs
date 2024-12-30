using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace Controller
{
    /// <summary>
    /// INTERFACE for classes that make use of listener methods
    /// </summary>
    public interface IListener
    {
        /// <summary>
        /// METHOD to listen to broadcasts
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        void Update(object source, MyArgs args);
    }
}

