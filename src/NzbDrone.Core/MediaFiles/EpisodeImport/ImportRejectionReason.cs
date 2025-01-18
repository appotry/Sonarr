namespace NzbDrone.Core.MediaFiles.EpisodeImport;

public enum ImportRejectionReason
{
    Unknown,
    FileLocked,
    UnknownSeries,
    DangerousFile,
    ExecutableFile,
    ArchiveFile,
    SeriesFolder,
    InvalidFilePath,
    UnsupportedExtension,
    PartialSeason,
    SeasonExtra,
    InvalidSeasonOrEpisode,
    UnableToParse,
    Error,
    DecisionError,
    NoEpisodes,
    MissingAbsoluteEpisodeNumber,
    EpisodeAlreadyImported,
    TitleMissing,
    TitleTba,
    MinimumFreeSpace,
    FullSeason,
    NoAudio,
    EpisodeUnexpected,
    EpisodeNotFoundInRelease,
    Sample,
    SampleIndeterminate,
    Unpacking,
    ExistingFileHasMoreEpisodes,
    SplitEpisode,
    UnverifiedSceneMapping,
    NotQualityUpgrade,
    NotRevisionUpgrade,
    NotCustomFormatUpgrade
}
