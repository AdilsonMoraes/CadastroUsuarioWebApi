using CadastraUsuario.Data.Repositories;
using CadastroUsuario.Data.Persistence.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        CadastroUsuarioEntities entities = new CadastroUsuarioEntities();

        public usuario Create(usuario Usuario)
        {
            return entities.usuario.Add(Usuario);
        }

        public bool Delete(int id)
        {
            usuario usuarioRemover = entities.usuario.Where(n => n.id == id).FirstOrDefault();
            var teste = entities.usuario.Remove(usuarioRemover);

            if (teste != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public usuario GetById(int id)
        {
            return entities.usuario.Where(n => n.id == id).FirstOrDefault();
        }

        public IEnumerable<usuario> List(usuario filter)
        {
            return entities.usuario.Where(n => n.id == filter.id);
        }

        public bool Update(usuario Usuario)
        {
            //usuario usuarioRemover = entities.usuario.Where(n => n.id == Usuario.id).FirstOrDefault();
            ////usuarioRemover = Usuario;
            //entities.usuario = Usuario;
            //var teste = entities.SaveChanges();
            return true;
        }
    }
}
