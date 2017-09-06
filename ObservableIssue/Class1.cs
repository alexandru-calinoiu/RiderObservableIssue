using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace ObservableIssue
{
    public class Class1
    {
        public void Main()
        {
            Observable.FromAsync(_ => new Task<int>(() => 42));
            Login().SelectMany(_ => Observable.Empty<ResponseClass>());
        }

        private IObservable<ResponseClass> Login()
        {
            return new List<ResponseClass> { new ResponseClass(), new ResponseClass() }.ToObservable();
        }

        class ResponseClass
        {
            public string Body { get; set; }
        }
    }
}