using Sol_Demo.Example1.Cores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example1.ConcreateColleague
{
    public class Participant2 : IParticipant
    {
        private readonly IMediator mediator = null;

        public Participant2(IMediator mediator)
        {
            this.mediator = mediator;
        }

        Task IParticipant.ReceiveAsync(string message)
        {
            return Task.Run(() => Console.WriteLine($" Participant 2 Received Message : {message}"));
        }

        async Task IParticipant.SendAsync(string message)
        {
            Console.WriteLine($" Participant 2 Send Message : {message}");
            await mediator?.BroadcastAsync(message, this);
        }
    }
}