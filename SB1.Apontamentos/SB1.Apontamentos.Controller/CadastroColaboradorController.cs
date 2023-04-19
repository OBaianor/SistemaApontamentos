using SB1.Apontamentos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB1.Apontamentos.Controller
{
    public class CadastroColaboradorController
    {
        public static bool GravarColaborador(CadastroColaborador colaborador)
        {
            Contexto contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (colaborador.Gravar(contexto))
                        {
                            transacao.Commit();
                            return true;

                        }
                    }
                }
                transacao.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public static BindingSource ConsultarColab(int? Id, string Usuario)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return CadastroColaborador.Consultar(Id, Usuario, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static bool Excluir(CadastroColaborador cadastro)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (cadastro.Excluir(contexto))
                        {
                            contexto.SaveChanges();
                            transacao.Commit();
                            return true;
                        }
                    }
                }
                transacao.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw new Exception(ex.Message);
            }
        }

    }
}
