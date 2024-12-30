using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: ARO
/// Date: 05/12/21
/// 
/// CLASS for FileNotFoundException
/// </summary>
namespace Controller
{
    /// <summary>
    /// FileNotFoundException class.
    /// This exception should be thrown whenever a file/image can not be located/displayed.
    /// </summary>
    public class FileNotFoundException : Exception
    {
        // Modified from COMP3404 Session6 code and attributed to Marc Price
        #region Default constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public FileNotFoundException()
        {
        }
        #endregion

        #region Recommended constructor
        /// <summary>
        /// Recommended constructor.
        /// </summary>
        /// <param name="message">String containing the message to the user</param>
        public FileNotFoundException(string message)
            : base(message)
        {
        }
        #endregion
    }
}
