namespace GithubEmojis;

public interface IGithubEmojiService
{
    Task<IList<Emoji>> GetEmojis();
    IList<Emoji> GetEmojisFrom(string content);
}