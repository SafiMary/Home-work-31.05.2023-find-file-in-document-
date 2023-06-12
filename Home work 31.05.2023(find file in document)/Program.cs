using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_31._05._2023_find_file_in_document_
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            
            FileSearch fileSearch = new FileSearch();
            fileSearch.File_Search(fileSearch);

        }
    }
}
