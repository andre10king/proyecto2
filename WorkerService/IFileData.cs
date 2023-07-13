using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService
{
 public  interface IFileData
    {
        public Task Create(string Path);
    }
}
