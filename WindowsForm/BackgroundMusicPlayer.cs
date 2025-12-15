using NAudio.Wave;
using System;
using System.Threading.Tasks;

public class BackgroundMusicPlayer : IDisposable
{
    private AudioFileReader audioFile;
    private WaveOutEvent outputDevice;
    private bool isLooping = false;
    private float volume = 0.5f;

    // Загрузить и воспроизвести файл на фоне
    public async Task PlayBackgroundMusicAsync(string filePath, bool loop = false, float volume = 0.5f)
    {
        await Task.Run(() =>
        {
            try
            {
                Stop();

                audioFile = new AudioFileReader(filePath);
                audioFile.Volume = volume;
                this.volume = volume;
                this.isLooping = loop;

                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);

                if (loop)
                {
                    outputDevice.PlaybackStopped += OnPlaybackStoppedForLoop;
                }

                outputDevice.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка воспроизведения: {ex.Message}");
                DisposeResources();
            }
        });
    }

    // Воспроизвести несколько треков последовательно
    public async Task PlayPlaylistAsync(string[] filePaths, bool loopPlaylist = false)
    {
        await Task.Run(async () =>
        {
            int currentIndex = 0;

            while (currentIndex < filePaths.Length)
            {
                var filePath = filePaths[currentIndex];

                await PlayBackgroundMusicAsync(filePath, false, volume);

                // Ждем окончания трека
                while (outputDevice?.PlaybackState == PlaybackState.Playing)
                {
                    await Task.Delay(100);
                }

                currentIndex++;

                // Зацикливание плейлиста
                if (loopPlaylist && currentIndex >= filePaths.Length)
                {
                    currentIndex = 0;
                }
            }
        });
    }

    // Простой метод - просто запустить музыку в фоне
    public void PlaySimple(string filePath)
    {
        Task.Run(() =>
        {
            try
            {
                audioFile = new AudioFileReader(filePath);
                audioFile.Volume = 0.3f;

                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
            catch { }
        });
    }

    // Пауза
    public void Pause()
    {
        outputDevice?.Pause();
    }

    // Продолжить
    public void Resume()
    {
        outputDevice?.Play();
    }

    // Остановить
    public void Stop()
    {
        if (outputDevice != null)
        {
            outputDevice.PlaybackStopped -= OnPlaybackStoppedForLoop;
            outputDevice.Stop();
        }
        DisposeResources();
    }

    // Получить текущее состояние
    public PlaybackState? GetPlaybackState()
    {
        return outputDevice?.PlaybackState;
    }

    // Зацикливание при окончании трека
    private void OnPlaybackStoppedForLoop(object sender, StoppedEventArgs e)
    {
        if (isLooping && audioFile != null)
        {
            audioFile.Position = 0;
            outputDevice?.Play();
        }
    }

    // Освобождение ресурсов
    private void DisposeResources()
    {
        audioFile?.Dispose();
        audioFile = null;
        outputDevice?.Dispose();
        outputDevice = null;
    }

    public void Dispose()
    {
        Stop();
        DisposeResources();
    }
}