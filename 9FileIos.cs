//Creaate ten folders inside same root folder

// each file must contain a file with text " i am in folder n", n being number of folders
using System.IO;
class FileIOLoop
{


    public void CreateDirectoriesFiles()
    // {

    //     string path = @"C:\Users\TOSHIBA\Desktop\dotnet\Basics";
    //     for (int a = 1; a <= 10; a++)
    //     {

    //         string fileFolder = path + "\\dotnetlearn Folder" + a;
    //         Directory.CreateDirectory(fileFolder);
    //     }
    // }

{
for (int count=1; count <=10; count++)
    {
       var  folderPathCreation = @$"C:\Users\TOSHIBA\Desktop\dotnet\Basics\folder {count}";
        Directory .CreateDirectory(folderPathCreation);
        string fullFilePath=@$"{folderPathCreation}\folder {count}.txt";
        File.WriteAllText(fullFilePath, $"hello i am in file folder {count}");

        // DirectoryInfo.Equals.......
    }

    // public void GetFileMetaData()
    // {
    //     FileInfo info = new FileInfo(@"C:\Users\TOSHIBA\Desktop\dotnet\Basics\folder 4\4.m");
      
    //     var size = info.Length / 1024 +"KB";
    // }
}} 