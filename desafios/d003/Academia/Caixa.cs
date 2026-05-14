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
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Caixa (DIA, HORA, SALDO_INICIAL, SITUACAO)
                    VALUES (@Dia, @Hora, @SaldoInicial, @Situacao)

                    SELECT SCOPE_IDENTITY()
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@Dia", SqlDbType.Date).Value = dia.Date;
                cmd.Parameters.Add("@Hora", SqlDbType.Time).Value = hora.TimeOfDay;
                cmd.Parameters.Add("@Situacao", SqlDbType.Bit).Value = situacao;

                var valor = cmd.Parameters.Add("@SaldoInicial", SqlDbType.Decimal);
                valor.Precision = 12;
                valor.Scale = 2;
                valor.Value = saldo_inicial;

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar caixa", ex);
            }
        }

        public void AlterarSituacao(int idCaixa, bool situacao)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    UPDATE Caixa
                    SET SITUACAO = @situacao             
                    WHERE ID_CAIXA = @idCaixa;
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idCaixa", SqlDbType.Int).Value = idCaixa;
                cmd.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void SalvarTransacao(int idCaixa, decimal valor, string movimento, string tipoPagamento, string tipoMovimento)
        {
            try
            {
                movimento = movimento.ToUpper();
                movimento = movimento.Substring(0, 1);
                tipoPagamento = tipoPagamento.ToUpper();
                tipoMovimento = tipoMovimento.ToUpper();

                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Transacao_Caixa (ID_CAIXA, VALOR, MOVIMENTO, TIPO_PAGAMENTO, DATA_TRANSACAO, TIPO_MOVIMENTO)
                    VALUES (@IdCaixa, @Valor, @Movimento, @TipoPagamento, GETDATE(), @TipoMovimento)
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@IdCaixa", SqlDbType.Int).Value = idCaixa;
                cmd.Parameters.Add("@Movimento", SqlDbType.Char, 1).Value = movimento;
                cmd.Parameters.Add("@TipoPagamento", SqlDbType.VarChar, 20).Value = tipoPagamento;
                cmd.Parameters.Add("@TipoMovimento", SqlDbType.VarChar, 20).Value = tipoMovimento;

                var paramValor = cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                paramValor.Precision = 12;
                paramValor.Scale = 2;
                paramValor.Value = valor;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar transação no caixa", ex);
            }
        }

        public DataTable Listar()
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT * FROM Caixa
                    ORDER BY DIA DESC, HORA DESC
                """;

                using SqlCommand cmd = new(sql, conexao);

                DataTable dadosTabela = new();

                using SqlDataReader leitor = cmd.ExecuteReader();
                dadosTabela.Load(leitor);

                return dadosTabela;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao salvar transação no caixa", ex);
            }
        }

        public DataTable ListaTransacao(int idCaixa)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 
                        VALOR,
                        DATA_TRANSACAO,
                        TIPO_PAGAMENTO,
                        TIPO_MOVIMENTO
                    FROM Transacao_Caixa
                    WHERE ID_CAIXA = @idCaixa
                    ORDER BY ID_TRANSACAO DESC;
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idCaixa", SqlDbType.Int).Value = idCaixa;

                DataTable dadosTabela = new();

                using SqlDataReader leitor = cmd.ExecuteReader();
                dadosTabela.Load(leitor);

                return dadosTabela;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar transação do caixa", ex);
            }
        }

        // Obtém valores totais de entrada, retirada e saldo atual considerando o saldo inicial
        public (decimal entrada, decimal retirada, decimal saldo) ObterTotal(decimal saldoInicial, int idCaixa)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 
                        SUM(CASE WHEN MOVIMENTO = 'E' THEN VALOR ELSE 0 END) AS TOTAL_ENTRADA,
                        SUM(CASE WHEN MOVIMENTO = 'S' THEN VALOR ELSE 0 END) AS TOTAL_RETIRADA,
                        SUM(
                            CASE 
                                WHEN MOVIMENTO = 'E' THEN VALOR
                                WHEN MOVIMENTO = 'S' THEN -VALOR
                            END
                        ) + @saldoInicial AS SALDO
                    FROM Transacao_Caixa
                    WHERE ID_CAIXA = @idCaixa;
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@saldoInicial", SqlDbType.Decimal).Value = saldoInicial;
                cmd.Parameters.Add("@idCaixa", SqlDbType.Int).Value = idCaixa;
                // Validação para evitar valores nulos retornados pela consulta
                using SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.Read())
                {
                    return (
                        leitor.IsDBNull(0) ? 0 : leitor.GetDecimal(0),
                        leitor.IsDBNull(1) ? 0 : leitor.GetDecimal(1),
                        leitor.IsDBNull(2) ? 0 : leitor.GetDecimal(2)
                    );
                }

                return (0, 0, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarMovimento(string tipoMovimento)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 
                        VALOR,
                        DATA_TRANSACAO,
                        TIPO_PAGAMENTO,
                        TIPO_MOVIMENTO
                    FROM Transacao_Caixa
                    WHERE MOVIMENTO = @tipoMovimento
                    ORDER BY ID_TRANSACAO DESC; 
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@tipoMovimento", SqlDbType.VarChar, 20).Value = tipoMovimento;

                DataTable dadosTabela = new();

                using SqlDataReader leitor = cmd.ExecuteReader();
                dadosTabela.Load(leitor);

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar movimento", ex);
            }
        }

        public void PesquisarPagamento(string tipoPagamento)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 
                        VALOR,
                        DATA_TRANSACAO,
                        TIPO_PAGAMENTO,
                        TIPO_MOVIMENTO
                    FROM Transacao_Caixa
                    WHERE TIPO_PAGAMENTO = @tipoPagamento
                    ORDER BY ID_TRANSACAO DESC;
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@tipoPagamento", SqlDbType.VarChar, 20).Value = tipoPagamento;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar pagamento", ex);
            }
        }

        public void PesquisarData(DateTime dataPagamento)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                dataPagamento = dataPagamento.Date; // Garante que a hora seja ignorada na comparação

                string sql = """
                    SELECT 
                        VALOR,
                        DATA_TRANSACAO,
                        TIPO_PAGAMENTO,
                        TIPO_MOVIMENTO
                    FROM Transacao_Caixa
                    WHERE CAST(DATA_TRANSACAO AS DATE) = CAST(@data AS DATE)
                    ORDER BY ID_TRANSACAO DESC;
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@data", SqlDbType.Date).Value = dataPagamento;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar pesquisar data", ex);
            }
        }

        // Retorna os tipos de filtro disponíveis para pesquisa
        public Dictionary<string, string> FiltroMovimento()
        {
            return new Dictionary<string, string>
            {
                { "Todos", "T" },
                { "Entrada", "E" },
                { "Retirada", "S" },
            };
        }
    }
}
