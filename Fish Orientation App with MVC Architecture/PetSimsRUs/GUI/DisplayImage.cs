using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Controller;

/// <summary>
/// Author: ARO
/// Date: 05/12/2021
/// 
/// 
/// </summary>
namespace View
{
    /// <summary>
    /// DisplayImage class - makes chages to the DisplayImage instace
    /// </summary>
    public partial class DisplayImage : Form
    {
        #region VARIABLE
        // DECLARE a variable of type CollectionView, call it _collection:
        private CollectionView _collection;

        // DECLARE variable of type String to store path to fish image, call it _filePath:
        private String _filePath;

        // DECLARE a variable of type ImageHandler to pass file path data, call it _imageData:
        private ImageHandler _imageData;

        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// CONSTRUCTOR: a constructor for the DisplayImage to initialise functions
        /// </summary>
        public DisplayImage()
        {
            InitializeComponent();

            // INSTANTIATE CollectionView and assign to _collection
            _collection = new CollectionView();

            // REFERENCE the _collection in CollectionView and assign to _filePath
            _filePath = _collection.OpenImage;
            
            try
            {
                // INITIALISE new DisplayImage, store it in _displayData
                _imageData = new ImageHandler(_filePath);
            }
            catch (FileNotFoundException e)
            {
                // SEND e.Message to debug console:
                Debug.WriteLine(e.Message);

                // INSTANTIATE _imageHandler with default contructor:
                this._imageData = new ImageHandler();
            }

            // ASSIGN fish image to MinimiseMaximise button
            this.PngImage.Image = this._imageData.Image;

            #region Set the SizeMode
            // Modified from https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.picturebox.sizemode?view=windowsdesktop-6.0 and attributed to Microsoft Doc
           
            // Set the SizeMode to center the image.
            this.PngImage.SizeMode = PictureBoxSizeMode.CenterImage;
            #endregion
        }
        #endregion

        #region Rotates the image when button is clicked
        // Modified from https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.rotateflip?redirectedfrom=MSDN&view=dotnet-plat-ext-6.0#definition and attributed to Microsoft Doc
     
        /// <summary>
        /// METHOD: rotates the image when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateImage_Click(object sender, EventArgs e)
        {
            // ROTATE the image by 90 degrees
            this.PngImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            // DISPLAY the new image on screen
            this.PngImage.Refresh(); 
        }
        #endregion

        #region Flips the image horizontally when button is clicked
        // Modified from https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.rotateflip?redirectedfrom=MSDN&view=dotnet-plat-ext-6.0#definition and attributed to Microsoft Doc
      
        /// <summary>
        /// METHOD: flips the image horizontally when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipImageH_Click(object sender, EventArgs e)
        {
            // FLIP the x axis of the image
            this.PngImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            // DISPLAY the new image on screen
            this.PngImage.Refresh();
        }
        #endregion

        #region Flips the image vertically when button is clicked
        // Modified from https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.rotateflip?redirectedfrom=MSDN&view=dotnet-plat-ext-6.0#definition and attributed to Microsoft Doc
    
        /// <summary>
        /// METHOD: flips the image vertically when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipImageV_Click(object sender, EventArgs e)
        {
            // FLIP the y axis of the image
            this.PngImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            // DISPLAY the new image on screen
            this.PngImage.Refresh();
        }
        #endregion

        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void DisplayImage_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void DisplayImage_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void DisplayImage_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }


        #endregion

        #region Event that deletes a DisplayImage from screen
        /// <summary>
        /// Event that deletes a DisplayImage when users clicks the delete(X) button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteImage_Click(object sender, EventArgs e)
        {
            // DESTROY the FishyNote
            this.Dispose();
        }
        #endregion

    }
}

