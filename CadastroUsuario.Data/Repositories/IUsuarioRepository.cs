using CadastroUsuario.Data.Persistence.DataSet;
using System.Collections.Generic;

namespace CadastraUsuario.Data.Repositories
{
    public interface IUsuarioRepository
    {
        usuario Create(usuario Usuario);
        IEnumerable<usuario> List(usuario filter);
        usuario GetById(int id);
        bool Update(usuario Usuario);
        bool Delete(int id);
    }
}