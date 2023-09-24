using System.Collections;

namespace N38_C.Models;

public class FilesContainer : IEnumerable<FileInfo>
{
    private readonly List<FileInfo> _files;
    public FilesContainer(string directoryPath)
    {
        var directory = new DirectoryInfo(directoryPath);
        _files = directory.GetFiles("*cs" ).ToList();
    }

    public IEnumerator<FileInfo> GetEnumerator()
    {
        return _files.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}