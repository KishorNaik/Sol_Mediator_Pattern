using Sol_Demo.Example2.Cores;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example2.Mediators
{
    public sealed class WhatsUpGroupMediator : IWhatsUpGroupMediator
    {
        private readonly ConcurrentBag<IWhatsUpGroupMember> whatsUpGroupMembersBag = new ConcurrentBag<IWhatsUpGroupMember>();

        Task IWhatsUpGroupMediator.RegisterAsync(IWhatsUpGroupMember whatsUpGroupMember)
        {
            return Task.Run(() => whatsUpGroupMembersBag.Add(whatsUpGroupMember));
        }

        async Task IWhatsUpGroupMediator.BroadCastAsync(string message, IWhatsUpGroupMember whatsUpGroupMember)
        {
            foreach (var whatsupGroupMemberObj in whatsUpGroupMembersBag?.ToList())
            {
                if (whatsupGroupMemberObj != whatsUpGroupMember)
                {
                    await whatsupGroupMemberObj?.ReceiveAsync(message);
                }
            }
        }
    }
}