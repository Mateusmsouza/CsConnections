using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Time.LoadFile { 
    public class FileLoaded
    {
	    public static List<String> Initial()
	    {
            //string path = @"C:/Users/Jefferson/source/repos/NewRepo/CsConnections/Connections.txt";
            //string path = @"C:\Users\Matheus\AppData\Roaming\TeamViewer\Connections.txt";
            #if DEBUG
                string path = @"C:\Users\jose c\source\repos\CsConnections\CsConnections\Connections.txt";
            #else
                string username = Environment.UserName;
                string path = @"C:\Users\replace\source\repos\CsConnections\CsConnections\Connections.txt".Replace("replace",username);
            #endif
            //string path = @"C:\Users\jose c\source\repos\CsConnections\CsConnections\Connections.txt";
            
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
            else
            {
                MessageBox.Show("Arquivo não localizado. Verifique o caminho configurado.");
            }

            return toReturn;
	    }
    }
}
