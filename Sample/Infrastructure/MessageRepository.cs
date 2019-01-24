using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MessageRepository : IMessageRepository
    {
        public async Task<Message> getMessage()
        {
            Message message = new Message();
            await Task.Run(() => Thread.Sleep(2000));
            await Task.Run(() => message.text = "Hello World");

            return message;
        }

    }
}
