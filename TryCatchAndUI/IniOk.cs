using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAndUI
{
    public class IniOk
    {
        public event EventHandler<IniEventArgs> OnIniEvent;

        public IniOk()
        {
            
        }

        public void GoIni()
        {
            ShowA();
            ShowB();
            ShowC();
        }

        private void ShowC()
        {
            var args = new IniEventArgs();
            args.IsOk = true;
            args.ItemName = "IniOk.C";

            OnIniEvent?.Invoke(this, args);
        }

        private void ShowB()
        {
            var args = new IniEventArgs();
            args.IsOk = true;
            args.ItemName = "IniOk.B";

            OnIniEvent?.Invoke(this, args);
        }

        private void ShowA()
        {
            var args = new IniEventArgs();
            args.IsOk = true;
            args.ItemName = "IniOk.A";

            OnIniEvent?.Invoke(this, args);
        }
    }
}
