using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class ImageHandling
    {
        #region VARIABLES

        // DECLARE a private member variable of type DataElement, call it _data
        private ImageHandler _imageHandler;

        #endregion

        #region Get file path for testing
        /// <summary>
        /// METHOD: get file path for testing
        /// </summary>
        public void LoadImage(string filePathName)
        {
            try
            {
                // INSTANTIATE ImageHandler
                _imageHandler = new ImageHandler(filePathName);


            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("ImageHandler: invalid path/filename for image");
            }

        }
        #endregion
    }
}
