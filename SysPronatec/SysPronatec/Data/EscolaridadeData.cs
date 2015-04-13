using System;
using System.Collections.Generic;
using System.Linq;
using SysPronatec.Model;
using System.Data.Objects;


namespace SysPronatec.Data
{
    class EscolaridadeData
    {

		private SysPronatecEntities db = new SysPronatecEntities();

	


		public List<Escolaridade> todasEscolaridades(){


            var lista = from es in db.Escolaridade
                        select es;
            return lista.ToList();
		
		}

		public string adicionarEscolaridade(Escolaridade es){
		
				string erro = null;
				try{

					db.Escolaridade.Add(es);
					db.SaveChanges();

				}catch(Exception ex){

				erro = ex.Message;


				}

			return erro;
			
		
		
		}

		public Escolaridade obterEscolaridade(int IdEscolaridade){


			var lista = from es in db.Escolaridade
					where es.IdEscolaridade == IdEscolaridade
					select es;
				return lista.ToList().FirstOrDefault();


		}

		public string editarEscolaridade(Escolaridade es){
		
			string erro = null;

			try{
			db.Escolaridade.Attach (es);
				db.SaveChanges();
			}catch(Exception ex) {
			
				erro =	ex.Message;
			}




		
			return erro;
		}

        public string excluirEscolaridade(Escolaridade es)
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
