using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Time.LoadFile { 
    public class FileLoaded
    {
	    public static List<String> Initial()
	    {
            string path = @"Connections.txt";
            List<string> toReturn = new List<string>();

            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        String currentLine;

                        while ((currentLine = reader.ReadLine()) != null)
                        {
                            toReturn.Add(currentLine);
                        }
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            return toReturn;
	    }
    }
}
