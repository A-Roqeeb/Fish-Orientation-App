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
    /// Interface for invoking a command, for command pattern
    /// </summary>
    public interface ICommandInvoker
    {
        /// <summary>
        /// Executes commands
        /// </summary>
        /// <param name="command"></param>
        void ExecuteCommand(ICommand command);
    }
}
