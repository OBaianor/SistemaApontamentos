using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SB1.Apontamentos.Model;

namespace Teste
{
    public class Class1
    {
        [Table("CadastroColaborador", Schema = "dbo")]
        public class CadastroColaborador
        {
            [Key]
            [Column("Id")]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Column("Nome")]
            public string Nome { get; set; }

            [Column("DtNascimento")]
            public DateTime DtNascimento { get; set; }

            [Column("TipoDoc")]
            public string TipoDoc { get; set; }

            [Column("TipoColaborador")]
            public string TipoColaborador { get; set; }

            [Column("Doc")]
            public string Doc { get; set; }

            [Column("DtInsercao")]
            public DateTime DtInsercao { get; set; }

            [Column("DtAtualizacao")]
            public DateTime DtAtualizacao { get; set; }

            [Column("Email")]
            public string Email { get; set; }

            [Column("Senha")]
            public string Senha { get; set; }

            [Column("Usuario")]
            public string Usuario { get; set; }

            [Column("Ativo")]
            public bool Ativo { get; set; }

            public bool Gravar(Contexto contexto)
            {
                try
                {
                    contexto.CadastroColaborador.Add(this);
                    contexto.Entry(this).State = Id > 0 ? Microsoft.EntityFrameworkCore.EntityState.Modified : Microsoft.EntityFrameworkCore.EntityState.Added;
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

            public static BindingSource Consultar(int id, string Usuario, Contexto contexto)
            {
                try
                {
                    BindingSource bsColab = new BindingSource();
                    using (contexto)
                    {
                        var bindingColaborador = from Colab in contexto.CadastroColaborador
                                                 where (Colab.Id == Id || Id == null) &&
                                                        (Colab.Usuario.Contains(Usuario)) || string.IsNullOrEmpty(Usuario)
                                                 /* (Colab.TipoColaborador.Contains(tipoColaborador)) || string.IsNullOrEmpty(tipoColaborador)*/
                                                 select Colab;
                        bsColab.DataSource = bindingColaborador.ToList();
                    }
                    return bsColab;


                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

            public bool Excluir(Contexto contexto)
            {
                try
                {
                    contexto.CadastroColaborador.Add(this);
                    contexto.Entry(this).State = EntityState.Deleted;
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}