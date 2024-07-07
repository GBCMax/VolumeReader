using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeReader
{
  internal class Reader
  {
    public static long GetDirVolume(string _url, long _volume)
    {
      try
      {
        var dirInfo = new DirectoryInfo(_url);

        var files = dirInfo.GetFiles();

        if(files != null)
        {
          foreach(var file in files)
          {
            _volume += file.Length;
          }
          var dirs = dirInfo.GetDirectories();

          if (dirs != null)
          {
            foreach (var dir in dirs)
            {
              _volume = GetDirVolume(dir.FullName, _volume);
            }
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return _volume;
    }
  }
}
