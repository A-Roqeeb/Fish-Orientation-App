using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

/// <summary>
/// Author: ARO
/// Date: 05/12/21
/// 
/// INTERFACE for ImageHandler
/// </summary>
namespace Controller
{
    /// <summary>
    /// INTERFACE for ImageHandler 
    /// </summary>
    interface IImageHandler
    {        
        /// <summary>
        /// DECLARE public property for _image to access the member variable, call it Image, Give just read access
        /// </summary>
        Image Image { get; }
    }
}
