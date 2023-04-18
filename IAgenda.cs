using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    public interface IAgenda
    {
        public void AdicionarContato();
        public void RemoverContato();
        public void ListarContatos();
        public void EditarContato();
    }
}
