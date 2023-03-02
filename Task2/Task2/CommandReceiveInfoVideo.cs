
using YoutubeExplode;
/// <summary>
/// Конкретная реализация команды считывания данных.
/// </summary>
class CommandReceiveInfoVideo : CommandOne
{
    Receiver receiver;
    public CommandReceiveInfoVideo(Receiver receiver)
    {
        this.receiver = receiver;
    }

    // Выполнить 1
    public override async void ReceiveInfoVideo()
    {
        //Запрашиваем адрес видео
        var inputvideoURL = new InputVideoURL();
        string videoUrl = inputvideoURL.Input();

        //Создем обьект Youtube-клиена
        var youtube = new YoutubeClient();

        //Считываем данные видео
        var videoinfo = await youtube.Videos.GetAsync(videoUrl);

        
        receiver.OperationOne();

        //Считано название видео
        var title = videoinfo.Title;
        Console.WriteLine(title);
        receiver.OperationTwo();

        //Считано имя автора видео
        var author = videoinfo.Author.ChannelTitle;
        Console.WriteLine(author);
        receiver.OperationThree();

        //Считано время воспроизведения видео
        var duration = videoinfo.Author.ChannelTitle;
        Console.WriteLine(duration);
        
    }

}