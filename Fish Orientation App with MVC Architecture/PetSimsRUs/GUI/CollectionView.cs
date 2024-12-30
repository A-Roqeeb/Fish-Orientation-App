using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Author: ARO
/// Date: 05/12/2021
/// 
/// 
/// </summary>
namespace View

{
    /// <summary>
    /// CollectionView class - responsible for helping locate image in memory/disk.
    /// </summary>
    public partial class CollectionView : Form
    {
        #region VARIABLE
        // DECLARE variable of type Form, Call it _addDisplayImage:
        private Form _addDisplayImage;

        // DECLARE an OpenFileDialog to open the image file, call it _getFilePath:
        private OpenFileDialog _getFilePath;

        // DECLARE a String to store the file path, call it _pathToFile:
        private String _pathToFile;

        // DECLARE a String to get path to the fish folder
        private String _path = Path.GetFullPath("FishAssets");


        // DECLARE an Action<ICommand> for invoking commands, call it _invokeCommand:
        private Action<ICommand> _invokeCommand;

        // DECLARE an ICommand for adding a new note, call it _addNoteCommand:
        private ICommand _addNoteCommand;

        // DECLARE variable of type Form, Call it _addNote
        private Action _addNote;

        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// CONSTRUCTOR for the windows form CollectionView to initialise functions
        /// </summary>
        public CollectionView()
        {
            InitializeComponent();

            #region OpenFileDialog Setup
            // Modified from https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0 and attributed to Microsoft Doc
          
            // INSTATIATE OpenFileDialog and store it in _getFilePath 
            _getFilePath = new OpenFileDialog();

            // SET initial directory file to be opened
            _getFilePath.InitialDirectory = Path.GetFullPath(Environment.CurrentDirectory + @"..\..\..\FishAssets");

            // RESTRICT the image file type to just PNG images.
            _getFilePath.Filter = "PNG Image|*.png";
            #endregion
        }
        #endregion

        #region Runs when the Select Image button is clicked
        /// <summary>
        /// METHOD: runs when the Select Image button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectImage_Click(object sender, EventArgs e)
        {
            // IF an image is selected, open an instance of DisplayImage on screen
            if (_getFilePath.ShowDialog() == DialogResult.OK)
            {                
                // INSTANTIATE new DisplayImage, Store it in _addDisplayImage
                _addDisplayImage = new DisplayImage();

                // DISPLAY DisplayImage instace on screen
                _addDisplayImage.Show();                
            }           
        }
        #endregion

        #region Checks if an image has been selected and get the file path
        // Modified from https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0 and attributed to Microsoft Doc
      
        /// <summary>
        /// METHOD: checks if an image has been selected and get the file path
        /// </summary>
        /// <returns></returns>
        private String FilePath()
        {
            // IF an image is selected, get the file path and return it to FilePath()
            if (_getFilePath.ShowDialog() == DialogResult.OK)
            {
                // GET the file path name for the DisplayImage to reference.
                _pathToFile = _getFilePath.FileName;
            }
            return _pathToFile;
        }
        #endregion

        #region Gets the file path string 
        /// <summary>
        /// Gets the file path string 
        /// </summary>
        public String OpenImage { get => FilePath();}

        #endregion

    }
}
