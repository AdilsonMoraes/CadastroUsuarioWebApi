using CadastroUsuario.AppService;
using CadastroUsuario.Data.Persistence.DataSet;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {

        //implementar Injeção de dependência 
        ///https://viniciusmussak.net/2015/04/09/implementando-simple-injector/comment-page-1/

        //

        // GET api/usuario   RETORNA LISTA
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public IEnumerable<usuario> Get([FromBody]usuario usuarioFiltro)
        {
            return appServices.List(usuarioFiltro);
        }

        // GET api/usuario/5    RETORNA PELO ID
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{id}")]
        public usuario Get(int id)
        {
            return appServices.GetById(id);
        }

        // POST api/usuario     CRIA UM NOVO
        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public usuario Post([FromBody]usuario Usuario)
        {
            return appServices.Create(Usuario);
        }

        // PUT api/usuario/5    UPDATE - ALTERA UM REGISTRO
        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public bool Put([FromBody]usuario Usuario)
        {
            return appServices.Update(Usuario);
        }

        // DELETE api/usuario/5  DELETA PELO ID
        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{id}")]
        public bool Delete(int id)
        {
            return appServices.Delete(id);
        }

    }
}
