
using CliWrap;
/// <summary>
/// Отправитель команды
/// </summary>
class Sender
{
    CommandOne _commandone;
    CommandTwo _commandtwo;

    // Команда на выполнение запроса адреса видео и считывание данных видео
    public void SetCommandOne(CommandOne command)
    {
        _commandone = command;
    }
    // Команда на выполнение запроса адреса видео и загрузка видео
    public void SetCommandTwo(CommandTwo command)
    {
        _commandtwo = command;
    }

    // Выполнить первую команду
    public void ReceiveInfoVideo()
    {
        
        _commandone.ReceiveInfoVideo();
    }

    // Выполнить вторую команду
    public void DownloadVideo()
    {
        _commandtwo.DownloadVideo();
    }
}
