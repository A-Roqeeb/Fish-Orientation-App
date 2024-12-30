using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Controller;

/// <summary>
/// Author: ARO
/// Date: 06/12/2021
/// 
/// 
/// </summary>
namespace ImageCollectionTest
{
     
    /// <summary>
    /// Unit Testing Class 
    /// </summary>
    [TestClass]
    public class ImageHandlingTest
    {
        #region Test method FileNotFoundException is thrown
        // Modified from https://stackoverflow.com/questions/19108107/expectedexception-attribute-usage/19108260 and attributed to user Mick
        
        /// <summary>
        /// METHOD: Test method FileNotFoundException is thrown
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImageHandlingTestException()
        {
            #region ARRANGE
            ImageHandling _image = new ImageHandling();
            String _Path = @"C:\Users\roqee\JavaFish.png";
            #endregion

            #region ACT
            // Test FileNotFoundException is being thrown
            _image.LoadImage(_Path);

            #endregion
        }
        #endregion

        #region Test that correct message is sent
        // Modified from https://stackoverflow.com/questions/19108107/expectedexception-attribute-usage/19108260 and attributed to user Mick
       
        /// <summary>
        /// METHOD: test that correct message is sent
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImageHandlingTestExceptionMessage()
        {
            #region ARRANGE
            ImageHandling _image = new ImageHandling();
            String _path = @"C:\Users\roqee\JavaFish.png";

            #endregion

            #region ACT
            // Act
            try
            {
                // Test InvalidArgumentException is being thrown
                _image.LoadImage(_path);
            }
            catch (FileNotFoundException e)
            {
                Assert.AreEqual("ImageHandler: invalid path/filename for image", e.Message);
                throw;
            }

            #endregion           
        }
        #endregion

        #region Test normal file path
        // Modified from https://stackoverflow.com/questions/19108107/expectedexception-attribute-usage/19108260 and attributed to user Mick
       
        /// <summary>
        /// METHOD: test normal file path
        /// </summary>
        [TestMethod]
        public void ImageHandlingTestNormalPath()
        {
            #region ARRANGE
            ImageHandling _image = new ImageHandling();
            String _path = "..\\..\\..\\Server\\image-not-found.png";
            #endregion

            #region ACT
            _image.LoadImage(_path);
            #endregion
        }
        #endregion
    }
}
