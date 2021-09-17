using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_GetListFromWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReferenceGetListStudent.Service1Client myService = new ServiceReferenceGetListStudent.Service1Client();
            var lists = myService.Get_ListSinhVien();
            foreach( var m in lists)
            {
                Console.WriteLine("ID: {0} | Name : {1} ",m.Id,m.Name);
            }
            Console.ReadLine();
        }
    }
}
