using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace COMP3973_Lab9_A01045801_Michael_Green.Hubs
{
    public class DrawingHub : Hub
    {
        public async Task UpdateCanvas(int x, int y, string randomColour)
        {
            await Clients.All.SendAsync("updateDot", x, y, randomColour);
        }
        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }
}
