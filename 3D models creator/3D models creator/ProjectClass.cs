using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_models_creator
{
    class ProjectClass
    {
        public DateTime CreationDate;
        public string Name;
        public List<Figure> Figures;

        public ProjectClass(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;
            Figures = new List<Figure>();
        }
        // Empty constructor for XML-(de)serializer
        private ProjectClass()
        {

        }
    }
}
