using Sol_Demo.Example1.Concreate;
using Sol_Demo.Example1.ConcreateColleague;
using Sol_Demo.Example1.Cores;
using Sol_Demo.Example2.Concreate;
using Sol_Demo.Example2.Cores;
using Sol_Demo.Example2.Mediators;
using System;
using System.Threading.Tasks;

namespace Sol_Demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Example1 - Communication Between Two Seperate Classs

            //IMediator mediator = new MediatorConcrete();

            //IParticipant participant1Obj = new Participant1(mediator);
            //IParticipant participant2Obj = new Participant2(mediator);

            //await mediator.RegisterAsync(participant1Obj);
            //await mediator.RegisterAsync(participant2Obj);

            //await participant1Obj.SendAsync("Hello.");

            //await participant2Obj.SendAsync("Hi");

            #endregion Example1 - Communication Between Two Seperate Classs

            #region Example 2 - Communication between Multiple class Object

            IWhatsUpGroupMediator whatsUpGroupMediator = new WhatsUpGroupMediator();

            IWhatsUpGroupMember kishorObj = new WhatsUpGroupMember(whatsUpGroupMediator);
            kishorObj.FullName = "Kishor Naik";

            IWhatsUpGroupMember yangaiObj = new WhatsUpGroupMember(whatsUpGroupMediator);
            yangaiObj.FullName = "Yangai Nagi";

            IWhatsUpGroupMember kosteObj = new WhatsUpGroupMember(whatsUpGroupMediator);
            kosteObj.FullName = "Koste Buidnoski";

            // Register
            await whatsUpGroupMediator?.RegisterAsync(kishorObj);
            await whatsUpGroupMediator?.RegisterAsync(yangaiObj);
            await whatsUpGroupMediator?.RegisterAsync(kosteObj);

            await kishorObj.SendAsync("Hello Friends..");

            await yangaiObj.SendAsync("Welcome friends");

            await kosteObj.SendAsync("Whats up");

            #endregion Example 2 - Communication between Multiple class Object
        }
    }
}