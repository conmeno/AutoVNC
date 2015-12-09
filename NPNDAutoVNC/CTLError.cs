﻿using System;
using System.IO;

namespace NPNDAutoVNC
{
    class CtlError
    {
        public static string _path=Environment.CurrentDirectory;
        public static bool WriteError(string file_name,string Title,string ex)
        {
            try
            {
                FileInfo fileInfo=new FileInfo(Path.Combine(_path,file_name));
                if (!fileInfo.Exists)
                    fileInfo.Create();
                FileStream fileStream=new FileStream(fileInfo.FullName,FileMode.Append);
                StreamWriter writer=new StreamWriter(fileStream);
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("-------------------------"+DateTime.Now+"---------------------------------");
                writer.WriteLine(Title);
                writer.WriteLine(ex);
                writer.Dispose();
                writer.Close();
                fileStream.Dispose();
                fileStream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
        }
        public static bool WriteError(string title, string ex)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(Path.Combine(_path, "ErrorLog"));
                if (!fileInfo.Exists)
                    fileInfo.Create();
                FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Append);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("-------------------------" + DateTime.Now + "---------------------------------");
                writer.WriteLine("Có vấn đề sảy ra tại " + title);
                writer.WriteLine(ex);
                writer.Dispose();
                writer.Close();
                fileStream.Dispose();
                fileStream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
