using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example2.Cores
{
    public interface IWhatsUpGroupMember
    {
        String FullName { get; set; }

        Task SendAsync(string message);

        Task ReceiveAsync(string message);
    }
}