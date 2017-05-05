using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinIntermediario002.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _propriedadeTexto;

        public string PropriedadeTexto
        {
            get { return _propriedadeTexto; }
            set { SetProperty(ref _propriedadeTexto, value);    }
        }

    }
}
