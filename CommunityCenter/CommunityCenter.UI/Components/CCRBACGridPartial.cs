using Microsoft.AspNetCore.Components;
namespace CommunityCenter.UI.Components
{
    public partial class CCRBACGrid<TItem> where TItem : class
    {
        [Parameter] public TItem FakeObject { get; set; }
    }
}
