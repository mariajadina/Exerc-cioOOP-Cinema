using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class ClienteVirtual : ClienteFisico
    {
        //Atributos
        private string nome;
        //private int idade; fazer como método depois e chegar na idade por meio da data de nascimento
        private string dataNascimento;
        private string cpf;
        private string telefone;
        private string email;
        //ver como herdar o beneficio do cliente fisico;

        //Acessadores get e set
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Valor inválido para nome.");
                }
            }
        }
        public string DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    dataNascimento = value;
                }
                else
                {
                    throw new Exception("Valor inválido para data de nascimento.");
                }
            }
        }
        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    cpf = value;
                }
                else
                {
                    throw new Exception("Valor inválido para CPF.");
                }
            }
        }
        
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    telefone = value;
                }
                else
                {
                    throw new Exception("Valor inválido para telefone.");
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("valor inválido para email.");
                }
            }
        }
        public ClienteVirtual(string nome = null, string dataNascimento = null, string cpf = null, string telefone = null, string email = null)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                this.nome = nome;
            }
            if (!string.IsNullOrEmpty(dataNascimento))
            {
                this.dataNascimento = dataNascimento;
            }
            if (!string.IsNullOrEmpty(cpf))
            {
                this.cpf = cpf;
            }
            if (!string.IsNullOrEmpty(telefone))
            {
                this.telefone = telefone;
            }
            if (!string.IsNullOrEmpty(email))
            {
                this.email = email;
            }
        }
    }
}
