/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysPronatec.Model;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;*/

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
    class PessoaData
    {


        private SysPronatecEntities db = new SysPronatecEntities();
        private ObjectSet<Pessoa> pessoas;

        public PessoaData(SysPronatecEntities db)
        {

            this.db = db;
                       
        
        }


      

        public List<Pessoa> todasPessoas()
        {
        
        var lista =  from p in db.Pessoa    
            select p;
            return lista.ToList();
        
        }


        public string adicionarPessoa(Pessoa p) 
        {
            string erro = null;
            try
            {
                db.Pessoa.Add (p);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        
        }

        public Pessoa obterPessoa(int IDPessoa) 
        {

            var lista = from p in db.Pessoa
                        where p.IDPessoa == IDPessoa
                        select p;
            return lista.ToList().FirstOrDefault();
        
        
        
        
        }

	    public string editarPessoa(Pessoa p) 
	        {
	            string erro = null;
	            try{

	               db.Pessoa.Attach(p); 
                   
	            }
	            catch (Exception ex)
	            {
	                erro = ex.Message;
	            }


                db.SaveChanges();
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
