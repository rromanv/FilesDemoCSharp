using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

// string winPath = @"C:\temp";
// string linuxOrMacPath = @"/home/rromanv";

string rootPath = Directory.GetCurrentDirectory();

// string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

List<string> dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories).ToList();

// dirs.ForEach(dir => Console.WriteLine(dir));

List<string> files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories).ToList();

// files.ForEach(file => Console.WriteLine(file));

files.ForEach(file =>
{
  // Console.WriteLine(Path.GetFileName(file));
  // Console.WriteLine(Path.GetFileNameWithoutExtension(file));
  // Console.WriteLine($"File {Path.GetFileName(file)} is located in {Path.GetDirectoryName(file)}");
  FileInfo fInfo = new(file);
  // Console.WriteLine($"File {Path.GetFileName(file)} is {fInfo.Length} size in bytes");

});

string dataPath = @"/home/rromanv/projects/STC/CITP4350/11-FileIO/FilesDemo/data";

// dirsSearch.ForEach(d => Console.WriteLine(d));

// bool dataDirExists = Directory.Exists(dataPath);

// if (dataDirExists)
// {
//   Console.WriteLine("Data already there");
// }
// else
// {
//   Console.WriteLine("Data directory not there");
//   System.Console.WriteLine("Creating Directory...");
Directory.CreateDirectory($"{dataPath}/subdirectory");

// File.Copy($"{dataPath}/test-file.txt", $"{dataPath}/copied-file.txt", true);


string[] lines = { "First line", "Second line", "Third line" };

var theFile = Path.Combine(dataPath, "created-in-csharp.txt");

File.WriteAllLines(theFile, lines);

// Console.ReadKey();

string[] extraLines = { "Another Line", "And another" };
File.AppendAllLines(theFile, extraLines);

StreamReader sr = File.OpenText(theFile);

// string line = null;

// while ((line = sr.ReadLine()) is not null)
// {
//   Console.WriteLine(line);
// }



// using (StreamReader sr = File.OpenText(theFile))
// {
//   string line = null;
//   while ((line = sr.ReadLine()) is not null)
//   {
//     Console.WriteLine(line);
//   }
// }


// }

List<string> document = sr.ReadToEnd().Split("\n").ToList();
sr.Close();

document.ForEach(line => Console.WriteLine(line));

System.Console.WriteLine(document[2]);