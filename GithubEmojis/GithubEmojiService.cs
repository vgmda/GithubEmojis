using System;
namespace GithubEmojis;

public class GithubEmojiService
{
    const string GithubEmojiUrl = "https://api.github.com/emojis";
    private readonly HttpClient _httpClient;
    private IList<Emoji> _emojis;

    public GithubEmojiService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "vgmda-github-emojis");
    }

    public async Task<IList<Emoji>> GetEmojis()
    {
        if (_emojis == null || _emojis.Count <= 0)
        {
            var emojiStr = await _httpClient.GetStringAsync(GithubEmojiUrl);
            try
            {
                // TODO - GetEmojisFrom() method
                _emojis = GetEmojisFrom(emojiStr);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"error: {ex.ToString()}");
            }

        }


        return _emojis;
    }

}

