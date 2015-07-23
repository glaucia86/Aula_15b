using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Persistence
{
    public class ClienteDal
    {
        //Método para gravar na base de dados: Cliente e Endereco:
        public void Save(Cliente c, Endereco e)
        {
            try
            {
                using (Conexao Con = new Conexao())
                {
                    Con.Cliente.Add(c);
                    Con.Endereco.Add(e);
                    Con.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar cliente.......: " + ex.Message);
            }
        }
    }
}
