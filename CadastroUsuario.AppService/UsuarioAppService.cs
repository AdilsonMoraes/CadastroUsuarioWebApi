using CadastraUsuario.Data.Repositories;
using CadastroUsuario.Data.Persistence.DataSet;
using CadastroUsuario.Data.Repositories;
using System;
using System.Collections.Generic;

namespace CadastroUsuario.AppService
{
    public class UsuarioAppService : IUsuarioRepository
    {
        UsuarioRepository data = new UsuarioRepository();

        public usuario Create(usuario Usuario)
        {
            return data.Create(Usuario);
        }

        public bool Delete(int id)
        {
            return data.Delete(id);
        }

        public usuario GetById(int id)
        {
            return data.GetById(id);
        }

        public IEnumerable<usuario> List(usuario filter)
        {
            return data.List(filter);
        }

        public bool Update(usuario Usuario)
        {
            return data.Update(Usuario);
        }
    }
}
