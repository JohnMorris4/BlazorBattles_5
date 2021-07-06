using Microsoft.AspNetCore.Components;

namespace BlazorBattles_net5.Client.Pages
{
    public partial class Counter : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
