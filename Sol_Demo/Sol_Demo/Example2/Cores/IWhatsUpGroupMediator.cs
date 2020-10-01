using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example2.Cores
{
    public interface IWhatsUpGroupMediator
    {
        Task RegisterAsync(IWhatsUpGroupMember whatsUpGroupMember);

        Task BroadCastAsync(string message, IWhatsUpGroupMember whatsUpGroupMember);
    }
}