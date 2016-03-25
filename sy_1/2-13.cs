using System;
using System.IO;
public class test {
	public static void Main()
	{

        FileSystemWatcher watcher = new FileSystemWatcher(@"C:\");
        watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;
        watcher.Changed += new FileSystemEventHandler(OnChanged);
        watcher.Created += new FileSystemEventHandler(OnChanged);
        watcher.Deleted += new FileSystemEventHandler(OnChanged);
        watcher.Renamed += new RenamedEventHandler(OnRenamed);
        watcher.Error += new ErrorEventHandler(OnError);
        watcher.EnableRaisingEvents = true;
        Console.WriteLine("Press 'Enter to Exit...'");
        Console.ReadLine();
    }
     private static void OnChanged(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes changeType = e.ChangeType;
            Console.WriteLine("The file {0} {1}", e.FullPath, e.ChangeType.ToString());
        }

    private static void OnRenamed(object source, RenamedEventArgs e)
    {
        WatcherChangeTypes changeType = e.ChangeType;
        Console.WriteLine("The file {0} {2} to {1}", e.OldFullPath, 
            e.FullPath, e.ChangeType.ToString());
    }

    private static void OnError(object source, ErrorEventArgs e)
    {
        Console.WriteLine("An error has occurred");
    }
        
}