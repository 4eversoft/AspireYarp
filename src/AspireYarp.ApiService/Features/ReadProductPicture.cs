using Microsoft.AspNetCore.Http.HttpResults;

namespace AspireYarp.ApiService.Features
{
    public static class ReadProductPicture
    {
        internal static async Task<PhysicalFileHttpResult> Endpoint(int productId, IWebHostEnvironment environment)
        {
            var path = GetFullPath(environment.ContentRootPath, $"0{productId}.jpg");

            return TypedResults.PhysicalFile(path, 
                contentType: "image/jpeg", 
                lastModified: File.GetLastWriteTimeUtc(path));
        }

        public static string GetFullPath(string contentRootPath, string pictureFileName) =>
            Path.Combine(contentRootPath, "Pics", pictureFileName);
    }
}
