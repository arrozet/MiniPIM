using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPIM.Account
{
    internal class FileManager
    {
        private Cuenta cuenta;
        private string path;
        public FileManager(Cuenta cuenta, string path)
        {
            this.cuenta = cuenta;
            this.path = path;
        }

    }
}
