using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Caixa
    {
        public int Salvar(DateTime dia, DateTime hora, decimal saldo_inicial, bool situacao)
        {
            try
            {
                using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Caixa (DIA, HORA, SALDO_INICIAL, SITUACAO)
                    VALUES (@Dia, @Hora, @SaldoInicial, @Situacao)

                    SELECT SCOPE_IDENTITY()
                """;

                using SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.Add("@Dia", SqlDbType.Date).Value = dia.Date;
                cmd.Parameters.Add("@Hora", SqlDbType.Time).Value = hora.TimeOfDay;
                cmd.Parameters.Add("@Situacao", SqlDbType.Bit).Value = situacao;

                var valor = cmd.Parameters.Add("@SaldoInicial", SqlDbType.Decimal);
                valor.Precision = 12;
                valor.Scale = 2;
                valor.Value = saldo_inicial;

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int SalvarTransacao(int idCaixa, decimal valor, string movimento, string tipoPagamento)
        {
            try
            {
                movimento = movimento.ToUpper();
                movimento = movimento.Substring(0, 1);
                tipoPagamento = tipoPagamento.ToUpper();

                using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Transacao_Caixa (ID_CAIXA, VALOR, MOVIMENTO, TIPO_PAGAMENTO)
                    VALUES (@IdCaixa, @Valor, @Movimento, @TipoPagamento)

                    SELECT SCOPE_IDENTITY()
                """;

                using SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.Add("@IdCaixa", SqlDbType.Int).Value = idCaixa;
                cmd.Parameters.Add("@Movimento", SqlDbType.Char, 1).Value = movimento;
                cmd.Parameters.Add("@TipoPagamento", SqlDbType.VarChar, 20).Value = tipoPagamento;

                var paramValor = cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                paramValor.Precision = 12;
                paramValor.Scale = 2;
                paramValor.Value = valor;

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
