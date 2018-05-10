using CadastraUsuario.Data.Repositories;
using CadastroUsuario.Data.Persistence.DataSet;
using CadastroUsuario.Data.Repositories;
using System;
using System.Collections.Generic;

namespace CadastroUsuario.AppService.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        //Inje de dependencia (Vai acessar a DATA ou DAL)
        private readonly IUsuarioRepository _repository;
        
        public UsuarioAppService(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        //fim

        public usuario Create(usuario Usuario)
        {
            return _repository.Create(Usuario);
        }

        public bool Delete(int id)
        {
           return  _repository.Delete(id);
        }

        public usuario GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<usuario> List(usuario filter)
        {
            return _repository.List(filter);
        }

        public bool Update(usuario Usuario)
        {
            return _repository.Update(Usuario);
        }
    }
}
