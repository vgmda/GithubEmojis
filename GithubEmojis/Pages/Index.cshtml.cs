using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GithubEmojis.Pages;

public class IndexModel : PageModel
{
    private IGithubEmojiService _emojiService;

    public IndexModel(IGithubEmojiService emojiSvc)
    {
        _emojiService = emojiSvc;
    }

    // Create property
    public IList<Emoji> Emojis { get; set; }

    public async Task OnGet()
    {
        Emojis = await _emojiService.GetEmojis();
    }
}

