using AutoMapper;
using FileExplorer.Api.Models.Dtos;
using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.Api.Common.MapperProfiles;

public class DirectoryProfile : Profile
{
    public DirectoryProfile()
    {
        CreateMap<StorageDirectory, StorageDirectoryDto>();
        CreateMap<StorageDirectoryDto, StorageDirectory>();
    }
}