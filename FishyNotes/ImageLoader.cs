using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FishyNotes
{
    class ImageLoader : IModel
    {
        //IList<String> _imageNames = new List<string>();

        IDictionary<string, Image> _imageNames = new Dictionary<string, Image>();

        public ImageLoader()
        {
            
        }

        public Image getImage(string key, int frameWidth, int frameHeight)
        {
            return Image.FromFile(key);
        }

        public IList<string> load(IList<string> pathfilenames)
        {
            string[] fileList = Directory.GetFiles("FishAssets");

            Image test = Image.FromFile("test");
            test.getpr

            return fileList.ToList<String>();
        }
    }
}
