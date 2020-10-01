using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example1.Cores
{
    public interface IMediator
    {
        Task RegisterAsync(IParticipant participant);

        Task BroadcastAsync(string message, IParticipant participant);
    }
}