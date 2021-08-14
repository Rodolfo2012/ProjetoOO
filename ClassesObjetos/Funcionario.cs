using System;

namespace Projeto_Cadrastro_Funcionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string nomeDoPai { get; set; }
        public string nomeDaMae { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string endereço { get; set; }
        public string logradouro { get; set; }
        public int dataDeNascimento { get; set; }
        public int cpf { get; set; }
        public int salario { get; set; }
    }
}