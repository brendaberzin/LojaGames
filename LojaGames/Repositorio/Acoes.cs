using LojaGames.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaGames.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        //Funcionario
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            string data_sistema = Convert.ToDateTime(funcionario.FuncDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@FuncCod,@FuncNome,@FuncCpf,@FuncRg,@FuncDtNasc,@FuncEnd,@FuncCel,@FuncEmail,@FuncCargo)", con.ConectarBD());
            cmd.Parameters.Add("FuncCod", MySqlDbType.Int32).Value = funcionario.FuncCod;
            cmd.Parameters.Add("FuncNome", MySqlDbType.VarChar).Value = funcionario.FuncNome;
            cmd.Parameters.Add("FuncCpf", MySqlDbType.VarChar).Value = funcionario.FuncCpf;
            cmd.Parameters.Add("FuncRg", MySqlDbType.VarChar).Value = funcionario.FuncRg;
            cmd.Parameters.Add("FuncDtNasc", MySqlDbType.Date).Value = data_sistema;
            cmd.Parameters.Add("FuncEnd", MySqlDbType.VarChar).Value = funcionario.FuncEnd;
            cmd.Parameters.Add("FuncCel", MySqlDbType.Double).Value = funcionario.FuncCel;
            cmd.Parameters.Add("FuncEmail", MySqlDbType.VarChar).Value = funcionario.FuncEmail;
            cmd.Parameters.Add("FuncCargo", MySqlDbType.VarChar).Value = funcionario.FuncCargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbFuncionario", con.ConectarBD());
            var DadosFuncionarios = cmd.ExecuteReader();
            return ListarTodosFuncionarios(DadosFuncionarios);
        }

        public List<Funcionario> ListarTodosFuncionarios(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    FuncCod = ushort.Parse(dt["FuncCod"].ToString()),
                    FuncNome = dt["FuncNome"].ToString(),
                    FuncCpf = dt["FuncCpf"].ToString(),
                    FuncRg = dt["FuncRg"].ToString(),
                    FuncDtNasc = DateTime.Parse(dt["FuncDtNasc"].ToString()),
                    FuncEnd = dt["FuncEnd"].ToString(),
                    FuncCel = dt["FuncCel"].ToString(),
                    FuncEmail = dt["FuncEmail"].ToString(),
                    FuncCargo = dt["FuncCargo"].ToString()
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;
        }
        //Funcionario

        //Cliente
        public void CadastrarCliente(Cliente cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.CliDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@CliNome,@CliCpf,CliDtNasc,@CliEmail,@CliCel,@CliEnd)", con.ConectarBD());
            cmd.Parameters.Add("CliNome", MySqlDbType.VarChar).Value = cliente.CliNome;
            cmd.Parameters.Add("CliCpf", MySqlDbType.VarChar).Value = cliente.CliCpf;
            cmd.Parameters.Add("CliDtNasc", MySqlDbType.Date).Value = data_sistema;
            cmd.Parameters.Add("CliEmail", MySqlDbType.VarChar).Value = cliente.CliEmail;
            cmd.Parameters.Add("CliCel", MySqlDbType.Double).Value = cliente.CliCel;
            cmd.Parameters.Add("CliEnd", MySqlDbType.VarChar).Value = cliente.CliEnd;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbCliente", con.ConectarBD());
            var DadosClientes = cmd.ExecuteReader();
            return ListarTodosClientes(DadosClientes);
        }

        public List<Cliente> ListarTodosClientes(MySqlDataReader dt)
        {
            var TodosClientes = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    CliNome = dt["CliNome"].ToString(),
                    CliCpf = dt["CliCpf"].ToString(),
                    CliDtNasc = DateTime.Parse(dt["CliDtNasc"].ToString()),
                    CliEmail = dt["CliEmail"].ToString(),
                    CliCel = dt["CliCel"].ToString(),
                    CliEnd = dt["CliEnd"].ToString(),
                };
                TodosClientes.Add(ClienteTemp);
            }
            dt.Close();
            return TodosClientes;
        }
        //Cliente

        public void CadastrarJogo(Jogo jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@JogoCod,@JogoNome,@JogoVersao,@JogoDev,@JogoGen,@JogoFxEt,@JogoPlat,@JogoAnoLanc,@JogoSin)", con.ConectarBD());
            cmd.Parameters.Add("JogoCod", MySqlDbType.Int32).Value = jogo.JogoCod;
            cmd.Parameters.Add("JogoNome", MySqlDbType.VarChar).Value = jogo.JogoNome;
            cmd.Parameters.Add("JogoVersao", MySqlDbType.VarChar).Value = jogo.JogoVersao;
            cmd.Parameters.Add("JogoDev", MySqlDbType.VarChar).Value = jogo.JogoDev;
            cmd.Parameters.Add("JogoGen", MySqlDbType.VarChar).Value = jogo.JogoGen;
            cmd.Parameters.Add("JogoFxEt", MySqlDbType.VarChar).Value = jogo.JogoFxEt;
            cmd.Parameters.Add("JogoPlat", MySqlDbType.VarChar).Value = jogo.JogoPlat;
            cmd.Parameters.Add("JogoAnoLanc", MySqlDbType.VarChar).Value = jogo.JogoAnoLanc;
            cmd.Parameters.Add("JogoSin", MySqlDbType.VarChar).Value = jogo.JogoSin;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public List<Jogo> ListarJogo()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbJogo", con.ConectarBD());
            var DadosJogos = cmd.ExecuteReader();
            return ListarTodosJogos(DadosJogos);
        }

        public List<Jogo> ListarTodosJogos(MySqlDataReader dt)
        {
            var TodosJogos = new List<Jogo>();
            while (dt.Read())
            {
                var JogoTemp = new Jogo()
                {
                    JogoCod = ushort.Parse(dt["JogoCod"].ToString()),
                    JogoNome = dt["JogoNome"].ToString(),
                    JogoVersao = dt["JogoVersao"].ToString(),
                    JogoDev = dt["JogoDev"].ToString(),
                    JogoGen = dt["JogoGen"].ToString(),
                    JogoFxEt = dt["JogoFxEt"].ToString(),
                    JogoPlat = dt["JogoPlat"].ToString(),
                    JogoAnoLanc = dt["JogoAnoLanc"].ToString(),
                };
                TodosJogos.Add(JogoTemp);
            }
            dt.Close();
            return TodosJogos;
        }
        //Jogo
    }
}