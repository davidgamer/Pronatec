using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysPronatec.Model;
using System.Data;

namespace SysPronatec.Data
{
    class CandidatoData
    {

        private SysPronatecEntities db;



           public List<Candidato> todosCandidatos()
        {
        
        var lista =  from p in db.Candidato    
            select p;
            return lista.ToList();
        
        }


        public string adicionarCandidatos(Candidato candidato) 
        {
            string erro = null;
            try
            {
                db.Candidato.Add (candidato);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        
        }


	    public string editarPessoa(Pessoa p) 
	        {
	            string erro = null;
	            try{

	               db.Entry(p).State = EntityState.Modified;
                   db.SaveChanges();
	            }
	            catch (Exception ex)
	            {
	                erro = ex.Message;
	            }
	            return erro;
	        
	        	        
	        
	        }


        public string excluirPessoa(Pessoa p){
        
        
             string erro = null;
            try
            {
				db.Pessoa.Remove(p);
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
