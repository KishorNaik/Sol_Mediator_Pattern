using Sol_Demo.Example1.Cores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example1.ConcreateColleague
{
    public sealed class Participant1 : IParticipant
    {
        private readonly IMediator mediator = null;

        public Participant1(IMediator mediator)
        {
            this.mediator = mediator;
        }

        Task IParticipant.ReceiveAsync(string message)
        {
            return Task.Run(() => Console.WriteLine($" Participant 1 Received Message : {message}"));
        }

        async Task IParticipant.SendAsync(string message)
        {
            Console.WriteLine($" Participant 1 Send Message : {message}");
            await mediator?.BroadcastAsync(message, this);
        }
    }
}