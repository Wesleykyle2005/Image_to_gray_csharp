using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToGray
{
    public interface IImageRepository
    {
        Task<string[]> GetImageAsync();
        Task ProcessImageAsync(List<string> imagePaths);

    }
}
