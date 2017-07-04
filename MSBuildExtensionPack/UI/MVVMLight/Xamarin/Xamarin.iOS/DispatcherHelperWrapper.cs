using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.iOS
{
    public class DispatcherHelperWrapper : Framework.Xaml.IDispatcherHelperWrapper
    {
        public void CheckBeginInvokeOnUI(Action action)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(action);
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            DispatcherHelper.Reset();

        }
    }
}

