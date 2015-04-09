using SysPronatec.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;



namespace SysPronatec.Data
{
    class TelefoneData
    {

        private SysPronatecEntities db;

		



		public List<Telefone> todosTelefones()
		{

			var lista =  from t in db.Telefone    
				select t;
			return lista.ToList();

		}


		public string adicionarTelefone(Telefone t) 
		{
			string erro = null;
			try

			{


				db.Telefone.Add (t);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				erro = ex.Message;
			}
			return erro;

		}

		public Telefone obterTelefone(int IDTelefone) 
		{

			var lista = from t in db.Telefone
					where t.IDTelefone == IDTelefone
				select t;
			return lista.ToList().FirstOrDefault();




		}

          public string editarPessoa(Telefone t) 
			        {
			            string erro = null;
			            try
			            {
                            db.Entry(t).State = EntityState.Modified;
                            db.SaveChanges();


			            }
			            catch (Exception ex)
			            {
			                erro = ex.Message;
			            }
			            return erro;
			        
			        
			        
			        
			        }

		public string excluirTelefone(Telefone t){


			string erro = null;
			try
			{
				db.Telefone.Remove(t);
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
