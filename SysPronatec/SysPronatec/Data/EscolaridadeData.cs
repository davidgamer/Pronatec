using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysPronatec.Model;
using System.Data.Entity.Core.Objects;


namespace SysPronatec.Data
{
    class EscolaridadeData
    {

		private SysPronatecEntities db = new SysPronatecEntities();

		private  ObjectSet<Escolaridade> escolaridades;


		public List<Escolaridade> todasEscolaridades(){
		
		
			var lista = from es in db.Escolaridade
			            select es;
			return lista.ToList ();
		
		
		}

		public string adicionarEscolaridade(Escolaridade es){
		
				string erro = null;
				try{

					db.Escolaridade.Add(es);
					db.SaveChanges();

				}catch(Exception ex){

				erro = ex.Message;


				}
			
		
		
		}




    }
}
