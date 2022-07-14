using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace WeakReferenceMessengerTest
{
    public partial class NestedViewModel:ObservableObject
    {
        [ObservableProperty]
        private string enteredMessage;

        [RelayCommand]
        void SendMessage()
        {
            WeakReferenceMessenger.Default.Send(enteredMessage);
        }
    }
}
