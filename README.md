# IsEven.cs
Web-API for [isevenapi.xyz](https://isevenapi.xyz/) use isEven to tell if a number is even

## Example
```cs
using IsEvenApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new IsEven();
            string number = await api.CheckNumber(1);
            Console.WriteLine(number);
        }
    }
}
```
