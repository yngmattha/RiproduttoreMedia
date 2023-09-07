using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiproduttoreMedia
{
    internal class Song : Content
    {
        public Song()
        {
            _tipologia = "Song";
        }
        

        public static void ToString(List<Song> a)
        {
            foreach(Song song in a) 
            {
                Console.WriteLine(song._nome);
            }

        } 
    }
}
