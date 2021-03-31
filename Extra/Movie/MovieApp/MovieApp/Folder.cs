using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieApp
{
    class Folder
    {

        string _mainfoldername;
        string _foldername;
        FIle _file;
        StringBuilder _folderaddress = new StringBuilder();
        public Folder(string foldername)
        {
            this._foldername = foldername;
        }


        public void CreteInitialFolder(Folder name)
        {
            _mainfoldername = name.GetFoldername;
            DirectoryInfo dir = new DirectoryInfo(@"C:\NewSwabhav\" + _mainfoldername);
            try
            {
                if (dir.Exists) { }
                else { dir.Create(); }
            }
            catch (Exception e) { }
            Console.WriteLine("Initial folder Created");
        }
        public StringBuilder Addfolder(Folder name)
        {
            StringBuilder filename = new StringBuilder();
            filename.Append("C:\\NewSwabhav\\");
            filename.Append(_mainfoldername + "\\");
            filename.Append(name.GetFoldername);
            _folderaddress = filename;



            DirectoryInfo dir = new DirectoryInfo(filename.ToString());
            try
            {
                if (dir.Exists) { }
                else { dir.Create(); }
            }
            catch (Exception e) { }
            return filename;

        }

        public void Addfile(StringBuilder address,FIle file)
        {   
            StringBuilder writetofile = new StringBuilder();
            writetofile.Append("Movie:" + file.GetName + "." + file.GetExtension + "\n");
            writetofile.Append("Size:" + file.GetSize);
            address.Append("\\" + file.GetName + "." + file.GetExtension);
            File.WriteAllText(address.ToString(), writetofile.ToString());
            Console.WriteLine(file.GetName+" added");

        }

        public string GetFoldername { get { return _foldername; } }
        public StringBuilder getfolderaddress { get { return this._folderaddress; } }

    }
}





/*

string _mainfoldername;
string _foldername;
FIle _file;
StringBuilder folderaddress = new StringBuilder();
public Folder(string foldername)
{
    this._foldername = foldername;
}


public void CreteInitialFolder(Folder name)
{
    _mainfoldername = name.GetFoldername;
    DirectoryInfo dir = new DirectoryInfo(@"C:\NewSwabhav\" + _mainfoldername);
    try
    {
        if (dir.Exists) { }
        else { dir.Create(); }
    }
    catch (Exception e) { }
    Console.WriteLine("Initial folder Created");
}
public void Addfolder(Folder name)
{
    StringBuilder filename = new StringBuilder();
    filename.Append("C:\\NewSwabhav\\");
    filename.Append(_mainfoldername + "\\");
    filename.Append(name.GetFoldername);
    folderaddress = filename;



    DirectoryInfo dir = new DirectoryInfo(filename.ToString());
    try
    {
        if (dir.Exists) { }
        else { dir.Create(); }
    }
    catch (Exception e) { }

}

public void Addfile(FIle file)
{
    StringBuilder writetofile = new StringBuilder();
    writetofile.Append("Movie:" + file.GetName + "." + file.GetExtension + "\n");
    writetofile.Append("Size:" + file.GetSize);
    File.WriteAllText(folderaddress.ToString(), writetofile.ToString());
    Console.WriteLine("File added");

}

public string GetFoldername { get { return _foldername; } }
*/