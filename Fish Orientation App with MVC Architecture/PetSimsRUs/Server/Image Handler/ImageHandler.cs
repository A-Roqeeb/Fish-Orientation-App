using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

/// <summary>
/// Author: ARO
/// Date: 05/12/2021
/// 
/// This exception should be thrown whenever a String instance is unexpectedly empty (ie: "").
/// </summary>
namespace Controller
{
    /// <summary>
    /// Class for handling image(s)
    /// </summary>
    public class ImageHandler : IImageHandler
    {
        #region VARIABLES
        // DECLARE variable of type Image to store the note image, call it _image
        private Image _image;

        // DECLARE a String to store file path and name for default image, call it _imageNotFound:
        private String _imageNotFound = "..\\..\\..\\Server\\image-not-found.png";
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// CONSTRUCTOR loads image on construction
        /// </summary>
        /// <param name="pImagePath"></param>
        public ImageHandler(String pImagePath)
        {
            try
            {
                // LOAD _image:
                this._image = Bitmap.FromFile(Path.GetFullPath(pImagePath));
            }
            // IF the filename is invalid, throw FileNotFoundException
            catch (FileNotFoundException e)
            {
                // LOAD _imageNotFound:
                this._image = Bitmap.FromFile(Path.GetFullPath(_imageNotFound));   
                
            }
            catch
            {
                // Throw an InvalidStringException:
                throw new FileNotFoundException("ImageHandler: invalid path/filename for image");               
            }

        }

        public ImageHandler()
        {
            try
            {
                // LOAD _imageNotFound:
                this._image = Bitmap.FromFile(Path.GetFullPath(_imageNotFound));
            }
            catch (FileNotFoundException e)
            {
                // SEND e.Message to debug console:
                Debug.WriteLine(e.Message);
                // SEND e.Message to output console
                Console.WriteLine(e.Message);

            }
        }
        #endregion

        #region Public property for _image to access the member variable
        /// <summary>
        /// DECLARE public property for _image to access the member variable, call it Image, Give just read access
        /// </summary>
        public Image Image { get => _image; }
        #endregion

        #region Disposes any elements that needs to be manually removed from memory
        // Modified from COMP3404 Session6 code and attributed to Marc Price

        /// <summary>
        /// Disposes any elements that needs to be manually removed from memory.
        /// </summary>
        public void Dispose()
        {
            // Dispose of _image:
            this._image.Dispose();
        }
        #endregion

    }
}
