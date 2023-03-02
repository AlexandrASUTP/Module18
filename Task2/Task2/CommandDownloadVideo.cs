
using YoutubeExplode;
using YoutubeExplode.Converter;
/// <summary>
/// Конкретная реализация команды загрузки видео.
/// </summary>
class CommandDownloadVideo : CommandTwo
{
    Receiver receiver;
    public CommandDownloadVideo(Receiver receiver)
    {
        this.receiver = receiver;
    }

    // Выполнить
    public override async void DownloadVideo()
    {
        //Запрашиваем адрес видео
        var inputvideoURL = new InputVideoURL();
        string videoUrl = inputvideoURL.Input();
        receiver.OperationOne();

        //Создем обьект Youtube-клиена
        var youtube = new YoutubeClient();

        //Загружаем видео по указанному адресу, в формате .мр4
        await youtube.Videos.DownloadAsync(videoUrl, "video.mp4",builder => builder.SetPreset(ConversionPreset.UltraFast));;

        receiver.OperationFour();
    }
}