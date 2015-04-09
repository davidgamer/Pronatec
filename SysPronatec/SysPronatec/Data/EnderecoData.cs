using System;
using System.Collections.Generic;
using System.Linq;
using SysPronatec.Model;

namespace SysPronatec.Data
{
    class EnderecoData
    {


        private SysPronatecEntities db = new SysPronatecEntities();


        public List<Endereço> todosEnderecos()
        {


            var lista = from ed in db.Endereço
                        select ed;
            return lista.ToList();

        }

        public string adicionarEnderecos(Endereço ed)
        {

            string erro = null;
            try
            {

                db.Endereço.Add(ed);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                erro = ex.Message;


            }

            return erro;



        }

        public Escolaridade obterEndereco(int IdEndereco)
        {


            var lista = from ed in db.Escolaridade
                        where ed.IdEscolaridade == IdEndereco
                        select ed;
            return lista.ToList().FirstOrDefault();


        }

        public string editarEndereco(Endereço ed)
        {

            string erro = null;

            try
            {
                db.Endereço.Attach(ed);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                erro = ex.Message;
            }





            return erro;
        }

        public string excluirEndereco(Endereço ed)
        {
            string erro = null;
            try
            {
                db.Endereço.Remove(ed);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }




    }
}
