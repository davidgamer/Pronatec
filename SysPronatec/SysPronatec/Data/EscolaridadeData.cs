using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysPronatec.Model;
using System.Data.Entity.Core.Objects;
using SysPronatec.Data;


namespace SysPronatec.Data
{
    class EscolaridadeData
    {

		private SysPronatecEntities db = new SysPronatecEntities();

		private  ObjectSet<Escolaridade> escolaridades;


		public List<Escolaridade> todasEscolaridades(){
		
		
			return escolaridades.ToList ();
		
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








    }
}
