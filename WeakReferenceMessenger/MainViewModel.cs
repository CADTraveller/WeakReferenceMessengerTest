using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;


namespace WeakReferenceMessengerTest
{
    public partial class MainViewModel:ObservableObject
    {
        public MainViewModel()
        {
            NestedVM = new();
            WeakReferenceMessenger.Default.Register<string>(this, (r, m) =>
            {
                ReceivedMessage = $"Received:{m}";
            });
        }

        [ObservableProperty]
        private string receivedMessage;

        [ObservableProperty]
        private NestedViewModel nestedVM;
    }
}
