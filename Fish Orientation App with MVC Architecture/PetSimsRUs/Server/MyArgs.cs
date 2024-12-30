using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// CLASS to store messages to be broadcasted 
    /// </summary>
    public class MyArgs : EventArgs
    {
        // DECLARE a string to store a message, call it _message
        private String _message;

        /// <summary>
        /// CONSTRUCTOR for the MyArgs class
        /// </summary>
        public MyArgs(String message)
        {
            // INSTANTIATE _message;
            _message = message;
        }
    }

}

