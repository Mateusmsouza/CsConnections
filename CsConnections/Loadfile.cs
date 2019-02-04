using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CsConnections;

namespace Time.LoadFile { 
    public class FileLoaded
    {
        string path { get; set; }
	    public static List<String> Initial(bool del=false)
	    {
            //string path = @"C:/Users/Jefferson/source/repos/NewRepo/CsConnections/Connections.txt";
            //string path = @"C:\Users\Matheus\AppData\Roaming\TeamViewer\Connections.txt";
#if DEBUG
            FileLoaded load = new FileLoaded();
            load.path = @"C:\Users\jose c\source\repos\CsConnections\CsConnections\Connections.txt";
#else
                string username = Environment.UserName;
                string path = @"C:\Users\replace\source\repos\CsConnections\CsConnections\Connections.txt".Replace("replace",username);
#endif
            //string path = @"C:\Users\jose c\source\repos\CsConnections\CsConnections\Connections.txt";

            List<string> toReturn = new List<string>();

            if (del)
            {
                File.WriteAllText(load.path, String.Empty);
                return toReturn;
            }

            
            if (File.Exists(load.path))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(load.path))
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
            else
            {
                MessageBox.Show("Arquivo não localizado. Verifique o caminho configurado.");
            }

            return toReturn;
	    }


    }
}
