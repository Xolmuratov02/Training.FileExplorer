using AutoMapper;
using FileExplorer.Api.Models.Dtos;
using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.Api.Common.MapperProfiles;

public class StorageItemProfile : Profile
{
    public StorageItemProfile()
    {
        CreateMap<IStorageEntry, IStorageItemDto>();
        CreateMap<IStorageItemDto, IStorageEntry>();
    }
}