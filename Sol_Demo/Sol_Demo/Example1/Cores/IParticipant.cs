using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Example1.Cores
{
    public interface IParticipant
    {
        Task SendAsync(String message);

        Task ReceiveAsync(string message);
    }
}