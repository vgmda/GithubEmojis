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


    public void OnGet()
    {

    }
}

