using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimsRUs
{
    /// <summary>
    /// CLASS to request input from the user
    /// </summary>
    public class Command : ICommandZeroParam
    {
        // DECLARE an Action to be executed by this command, call it _action:
        private Action _action;

        /// <summary>
        /// SET the action to the required callback.
        /// </summary>
        public Action SetAction { set { _action = value; } }

        /// <summary>
        /// EXECUTE the command
        /// </summary>
        public void Execute()
        {
          _action();
        }
 

    }
}
