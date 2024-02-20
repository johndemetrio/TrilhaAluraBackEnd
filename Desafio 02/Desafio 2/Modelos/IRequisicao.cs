using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public interface IRequisicao
    {
        void Requisicao(){
            ObjetoJson data = new ObjetoJson();
            using HttpClient client = new HttpClient();
        }
    }
}