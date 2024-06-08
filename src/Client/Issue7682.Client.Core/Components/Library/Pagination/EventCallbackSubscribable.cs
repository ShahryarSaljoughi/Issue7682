using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobhOmid.Client.Core.Components.Library.Pagination;
public class EventCallbackSubscribable<T>
{
    private readonly List<Func<T, Task>> _callbacks = new();

    public void Subscribe(Func<T, Task> callback)
    {
        if (!_callbacks.Contains(callback))
        {
            _callbacks.Add(callback);
        }
    }

    public void Unsubscribe(Func<T, Task> callback)
    {
        if (_callbacks.Contains(callback))
        {
            _callbacks.Remove(callback);
        }
    }

    public async Task InvokeCallbacksAsync(T eventArg)
    {
        foreach (var callback in _callbacks)
        {
            await callback(eventArg);
        }
    }
}
