using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAndUI
{
    public class IniNg
    {
        public event EventHandler<IniEventArgs> OnIniEvent;

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
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {

                var args = new IniEventArgs();
                args.IsOk = false;
                args.ItemName = "IniOk.B";

                OnIniEvent?.Invoke(this, args);
            }           
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
