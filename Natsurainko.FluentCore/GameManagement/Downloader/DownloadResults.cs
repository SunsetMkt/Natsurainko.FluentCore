﻿using System;
using System.Collections.Generic;

namespace Nrk.FluentCore.GameManagement.Downloader;

public enum DownloadResultType
{
    Successful,
    Cancelled,
    Failed
}

public class DownloadResult
{
    public DownloadResultType Type { get; init; }

    public Exception? Exception { get; init; } // not null when Type is Failed

    public DownloadResult(DownloadResultType type)
    {
        Type = type;
    }
}

public class GroupDownloadResult
{
    public required IReadOnlyList<(DownloadRequest, DownloadResult)> Failed { get; init; }
    public required DownloadResultType Type { get; init; }
}