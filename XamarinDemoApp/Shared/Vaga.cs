using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Vaga
    {
        #region Propriedades
        public int Id { get; set; }
        public string Funcao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Descricao { get; set; }
        #endregion

        public static List<Vaga> GetAll()
        {
            var vagas = new List<Vaga>
            {
                new Vaga { Id = 1, Cidade = "Curitiba", Estado = "PR", Descricao = "Vender produtos de RH", Funcao = "Vendedor" },
                new Vaga { Id = 2, Cidade = "Curitiba", Estado = "PR", Descricao = "Desenvolver sistemas com .NET", Funcao = "Programador" },
                new Vaga { Id = 3, Cidade = "Castro", Estado = "PR", Descricao = "Vender produtos de RH", Funcao = "Vendedor Interno" },
                new Vaga { Id = 4, Cidade = "Colombo", Estado = "PR", Descricao = "Primeira a quarta série", Funcao = "Professor" },

            };

            return vagas;
        }


    }
}
