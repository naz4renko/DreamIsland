using DreamIsland.Logic;
using System;

namespace DreamIsland.WPF
{
    public class ClientAuthorisedEventArgs: EventArgs
    {
        public Client CurrentClient { get; set; }
    }
}