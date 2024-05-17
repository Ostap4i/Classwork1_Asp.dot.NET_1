using asp.dot.net.Repositoriy;
using asp.dot.net.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.dot.net.Service
{
    class AcauntService
    {
        private AcauntRepositoriy acauntRepositoriy = new AcauntRepositoriy();
        public List<Acaunt> getAllAcaunts()
        {
            return acauntRepositoriy.getAllAcaunts();
        }

    }
}
