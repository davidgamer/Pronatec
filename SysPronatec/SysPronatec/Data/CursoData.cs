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
        private SysPronatecEntities db = new SysPronatecEntities();


        public List<Curso> todosCursos() {

            var lista = from cu in db.Curso
                        select cu;
            return lista.ToList();
        
        
        
        }






    }
}
