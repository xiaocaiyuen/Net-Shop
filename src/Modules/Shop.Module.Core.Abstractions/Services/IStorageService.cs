using Shop.Module.Core.Abstractions.Entities;
using System.IO;
using System.Threading.Tasks;

namespace Shop.Module.Core.Abstractions.Services
{
    public interface IStorageService
    {
        Task<string> GetMediaUrl(string fileName);

        //Task<string> SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null);

        Task DeleteMediaAsync(string fileName);

        Task<Media> SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null);
    }
}
