using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Objects;
using SysPronatec.Model;
using System.Data.Entity;
using System.Data;


namespace SysPronatec.Data
{
    class AtendimentoData
    {



        private SysPronatecEntities db;

      

        public List<Atendimento> todosAtendimentios()
        {
        
        var lista = from at in db.Atendimento
            select at;
            return lista.ToList();
        
        }


        public string adicionarAtendimento(Atendimento at) 
        {
            string erro = null;
            try
            {
                db.Atendimento.Add (at);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        
        }

        public Atendimento obterAtendimento  (int numeroAtendimento ) 
        {

            var lista = from at in db.Pessoa
                        where at.NumeroAtendimento == numeroAtendimento
                        select at;
            return lista.ToList().FirstOrDefault();
        
        
        
        
        }

	    public string editarAtendimento (Atendimento at) 
	        {
	            string erro = null;
	            try{

	               db.Atendimento.Attach(at); 
                   
	            }
	            catch (Exception ex)
	            {
	                erro = ex.Message;
	            }


                db.SaveChanges();
	            return erro;
	        
	        	        
	        
	        }


        public string excluirPessoa(Atendimento at){
        
        
             string erro = null;
            try
            {
				db.Pessoa.Remove(at);
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
