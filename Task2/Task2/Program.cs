internal class Program
{
    private static void Main(string[] args)
    {
        // создадим отправителя
        var sender = new Sender();

        // создадим получателя
        var receiver = new Receiver();

        // создадим команду 1
        var CommandReceiveInfoVideo = new CommandReceiveInfoVideo(receiver);
        // создадим команду 2
        var CommandDownloadVideo = new CommandDownloadVideo(receiver);

        // инициализация команды 1
        sender.SetCommandOne(CommandReceiveInfoVideo);
        // инициализация команды 2
        sender.SetCommandTwo(CommandDownloadVideo);
       
        //  выполнение 1
        sender.ReceiveInfoVideo();
        //  выполнение 2
        sender.DownloadVideo();
    }
}
