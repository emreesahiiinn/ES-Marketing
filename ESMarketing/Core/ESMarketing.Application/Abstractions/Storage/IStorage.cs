using Microsoft.AspNetCore.Http;

namespace ESMarketing.Application.Abstractions.Storage;

public interface IStorage
{
    List<string> GetFiles(string pathOrContainerName);

    Task<List<(string fileName, string path)>> UploadAsync(string pathOrContainerName,
        IFormFileCollection formFileCollection);

    Task DeleteAsync(string pathOrContainerName, string fileName);

    bool HasFile(string pathOrContainerName, string fileName);
}