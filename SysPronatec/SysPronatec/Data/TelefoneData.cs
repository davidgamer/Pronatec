using SysPronatec.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;


namespace SysPronatec.Data
{
    class TelefoneData
    {

		private SysPronatecEntities db = new SysPronatecEntities();

		private ObjectSet<Telefone> telefones;

		public List<Telefone> todasPessoas()
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
			                if (t.EntityState == System.Data.EntityState.Detached)
			                {
			                    db.Telefone.Attach(t);
			                }
			                db.ObjectStateManager.ChangeObjectState(t, System.Data.EntityState.Modified);
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
