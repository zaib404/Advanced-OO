using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FishyNotes
{
    class Model : IModel
    {
        //IList<String> _imageNames = new List<string>();

        IDictionary<string, Image> _imageNames = new Dictionary<string, Image>();

        public Model()
        {
            
        }

        public Image getImage(string key, int frameWidth, int frameHeight)
        {
            return _imageNames[key];
        }

        public IList<string> load(IList<string> pathfilenames)
        {
            foreach (var path in pathfilenames)
            {
                _imageNames.Add(path, Image.FromFile(path));
            }

            return pathfilenames;
        }
    }
}
