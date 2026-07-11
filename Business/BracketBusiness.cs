using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Business
{
    public class BracketBusiness
    {
        public void AvanzarGanador(int idPartido)
        {
            try
            {
                using (var trx = new TransactionScope())
                {

                    trx.Complete();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al avanzar el ganador: " + e.Message);
            }
        }

    }
}
