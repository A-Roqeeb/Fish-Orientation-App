using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimsRUs
{

    /// <summary>
    /// The ICommand interface
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute the Command
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// ICommand interface for actions with zero parameters'
    /// </summary>
    public interface ICommandZeroParam : ICommand
    {
        /// <summary>
        /// For setting the action to require callback
        /// </summary>
        Action SetAction { set; }
    }
}
