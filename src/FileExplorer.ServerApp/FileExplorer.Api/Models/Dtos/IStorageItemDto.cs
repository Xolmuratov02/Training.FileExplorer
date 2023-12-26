using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.Api.Models.Dtos;

public interface IStorageItemDto
{
    string Path { get; set; }

    StorageEntryType EntryType { get; set; }
}