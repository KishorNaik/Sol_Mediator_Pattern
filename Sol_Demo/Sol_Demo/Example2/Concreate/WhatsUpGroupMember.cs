using Sol_Demo.Example2.Cores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example2.Concreate
{
    public sealed class WhatsUpGroupMember : IWhatsUpGroupMember
    {
        private readonly IWhatsUpGroupMediator whatsUpGroupMediator = null;

        public WhatsUpGroupMember(IWhatsUpGroupMediator whatsUpGroupMediator)
        {
            this.whatsUpGroupMediator = whatsUpGroupMediator;
        }

        string IWhatsUpGroupMember.FullName { get; set; }

        Task IWhatsUpGroupMember.ReceiveAsync(string message)
        {
            return Task.Run(() => Console.WriteLine($"{((IWhatsUpGroupMember)this).FullName} : Received Message=  {message}"));
        }

        async Task IWhatsUpGroupMember.SendAsync(string message)
        {
            Console.WriteLine($"{((IWhatsUpGroupMember)this).FullName} : Sending Message=  {message}  \n");
            await whatsUpGroupMediator?.BroadCastAsync(message, this);
        }
    }
}