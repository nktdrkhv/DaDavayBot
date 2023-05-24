using Telegram.Bot.Types;
using TelegramUpdater.FilterAttributes.Attributes;
using TelegramUpdater.UpdateContainer;
using TelegramUpdater.UpdateHandlers.Scoped.ReadyToUse;

namespace DaDavay.UpdateHandlers.Messages;

[Command(command: "start"), Private]
internal class StartCommand : MessageHandler
{
    protected override async Task HandleAsync(IContainer<Message> cntr)
    {
        cntr.
        await ResponseAsync("Started from TelegramUpdater");
    }
}