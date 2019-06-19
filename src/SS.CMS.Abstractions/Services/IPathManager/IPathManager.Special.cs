using SS.CMS.Models;

namespace SS.CMS.Services.IPathManager
{
    public partial interface IPathManager
    {
        string GetSpecialDirectoryPath(SiteInfo siteInfo, string url);

        string GetSpecialZipFilePath(string directoryPath);

        string GetSpecialSrcDirectoryPath(string directoryPath);
    }
}