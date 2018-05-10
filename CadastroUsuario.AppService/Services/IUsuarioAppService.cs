using CadastroUsuario.Data.Persistence.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.AppService.Services
{
    interface IUsuarioAppService
    {
        usuario Create(usuario Usuario);
        IEnumerable<usuario> List(usuario filter);
        usuario GetById(int id);
        bool Update(usuario Usuario);
        bool Delete(int id);
    }
}
