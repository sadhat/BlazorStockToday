using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace StockToday.BlazorDb
{
    public class BlazorDbInterop
    {
        public static Task SetItem(string key, string value)
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorDbSetItem", key, value);
        }

        public static Task<string> GetItem(string key)
        {
            return JSRuntime.Current.InvokeAsync<string>("blazorDbGetItem", key);
        }

        public static Task RemoveItem(string key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDB.blazorDBInterop.RemoveItem", key);
        }

        public static Task Clear()
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDB.blazorDBInterop.Clear");
        }
    }
}