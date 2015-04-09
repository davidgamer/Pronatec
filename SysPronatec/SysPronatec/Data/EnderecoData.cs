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

        public Escolaridade obterEndereco(int IdEscolaridade)
        {


            var lista = from es in db.Escolaridade
                        where es.IdEscolaridade == IdEscolaridade
                        select es;
            return lista.ToList().FirstOrDefault();


        }

        public string editarEndereco(Escolaridade es)
        {

            string erro = null;

            try
            {
                db.Escolaridade.Attach(es);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                erro = ex.Message;
            }





            return erro;
        }

        public string excluirEndereco(Escolaridade es)
        {
            string erro = null;
            try
            {
                db.Escolaridade.Remove(es);
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
