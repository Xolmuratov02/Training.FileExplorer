﻿using FileExplorer.Application.Common.Models.Filtering;
using FileExplorer.Application.FileStorage.Models.Filtering;
using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.Application.FileStorage.Services;

public interface IFileService
{
    ValueTask<IList<StorageFile>> GetFilesByPathAsync(IEnumerable<string> filesPath);

    ValueTask<StorageFile> GetFileByPathAsync(string filePath);

    IEnumerable<StorageFilesSummary> GetFilesSummary(IEnumerable<StorageFile> files);

    StorageFileType GetFileType(string filePath);
}