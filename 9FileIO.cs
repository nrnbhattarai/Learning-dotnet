using System.IO;

class FileIO
{
    
    public void CreateFile()
    {
    //     string folderPath =@"C:\Users\TOSHIBA\Desktop\dotnet";
    //     string fileName="abc.txt";
    //    string fullPath = @$"{folderPath}\{fileName}";
    //     File.Create(fullPath);

    // alternative


         
        string folderPath =@"C:\Users\TOSHIBA\Desktop\dotnet";
        string fullFilePath=@$"{folderPath}\abcd.txt";
       
        File.WriteAllText(fullFilePath,"This is the first file created");


    }
    public void CreateDirectory()
    {
        
        string newFolderPath = @"C:\Users\TOSHIBA\Desktop\dotnet" +@"\abc";//nullify escape sequence
        Directory.CreateDirectory(newFolderPath);
    }

    //Creaate five folders inside same root folder
    public void CreateDirectoriesAndFiles()
    { 
        string newFolders = @"C:\Users\TOSHIBA\Desktop\dotnet" + "\\dotlearn";
        Directory.CreateDirectory(newFolders);
        
    
        

       



    }
}