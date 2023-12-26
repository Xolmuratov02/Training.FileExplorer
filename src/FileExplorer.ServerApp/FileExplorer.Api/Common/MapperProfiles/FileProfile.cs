using AutoMapper;
using FileExplorer.Api.Models.Dtos;
using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.Api.Common.MapperProfiles;

public class FileProfile : Profile
{
    public FileProfile()
    {
        CreateMap<StorageFile, StorageFileDto>();
        CreateMap<StorageFileDto, StorageFile>();
    }
}