using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysPronatec.Model;

namespace SysPronatec.Data
{
    class CursoData
    {
        private SysPronatecEntities db;
     


        public List<Curso> todosCursos() {

            var lista = from cu in db.Curso
                        select cu;
            return lista.ToList();
        
        
        
        }

        public string adicionarCurso(Curso curso) 
        {

            string erro = null;
            try
            {



                if (curso.IdCurso == 0)
                {
                    db.Curso.Add(curso);
                  
                }
                else
                {

                    
                   db.Curso.Attach(curso);
                }


            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            db.SaveChanges();
            return erro;
        
        
        
        }

        public Curso obterCurso(int IdCurso) {

            var lista = from cu in db.Curso
                        where cu.IdCurso == IdCurso
                        select cu;
            return lista.ToList().FirstOrDefault();
        
        
        
        }

        public string excluiCurso(Curso curso)
        
        {

            string erro = null;
            try
            {
                db.Curso.Remove(curso);
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
