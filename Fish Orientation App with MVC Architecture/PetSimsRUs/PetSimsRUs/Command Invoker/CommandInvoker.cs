using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: 
/// DATE: 
/// </summary>
namespace PetSimsRUs
{
    /// <summary>
    /// The command invoker for the command pattern
    /// </summary>
    public class CommandInvoker : ICommandInvoker
    {
        /// <summary>
        /// Executes commands.
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(ICommand command)
        {
            // EXECUTE command:
            command.Execute();
        }

    }

}
   