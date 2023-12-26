﻿using FileExplorer.Application.FileStorage.Models.Filtering;

namespace FileExplorer.Application.FileStorage.Models.Settings;

public class FileExtensionSettings
{
    public StorageFileType FileType { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public ICollection<string> Extensions { get; set; } = default!;
}

// Type - SourceCode
// Name - Source Code
// ImageUrl - wwwroot/images/source.code
// Extension - .cs, .css, .js