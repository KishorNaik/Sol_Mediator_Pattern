using Sol_Demo.Example1.Cores;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example1.Concreate
{
    public class MediatorConcrete : IMediator
    {
        private readonly ConcurrentBag<IParticipant> participantBag = new ConcurrentBag<IParticipant>();

        Task IMediator.RegisterAsync(IParticipant participant)
        {
            return Task.Run(() => participantBag.Add(participant));
        }

        async Task IMediator.BroadcastAsync(string message, IParticipant participant)
        {
            foreach (var participantObj in participantBag?.ToList())
            {
                if (participantObj != participant)
                {
                    await participantObj?.ReceiveAsync(message);
                }
            }
        }
    }
}