using System;

namespace ClassLibraryProject
{
    internal class Photo
    {
        public Photo()
        {
        }

        public string name { get; set; }
        public string Name { get; internal set; }
        public double size { get; set; }
        public string path { get; set; }
        public string format { get; set; }
        public DateTime date { get; set; }
    }
}