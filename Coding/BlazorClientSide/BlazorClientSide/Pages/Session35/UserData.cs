using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorClientSide.Pages.Session35
{
    public class UserData
    {
        private List<string> _userData = new List<string>();

        public UserData(List<string> userData)
        {
            _userData = userData;
        }

        [JSInvokable]
        public async Task<List<string>> LoadUserDataAsync()
        {
            return await Task.FromResult(_userData);
        }
    }
}
