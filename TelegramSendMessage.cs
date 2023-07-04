using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Resume
{
    public static class TelegramSendMessage
    {
        public static void SendMessage(int id, string message)
        {

            var client = new TelegramBotClient(""); // secret token 

            client.StartReceiving(Update, Error);
            client.SendTextMessageAsync(id, message);
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

        private async static Task Update(ITelegramBotClient bot, Update update, CancellationToken token)
        {
            var message = update.Message;
        }
    }
}
