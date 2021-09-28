using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_17_09_2021
{
    class Participante
    {
        private string email;
        private string nome;

        public string Email {
            get { return email; }
            set { email = value; }
        }


        public string Nome { get => nome; set => nome = value; }

        public Participante(string email, string nome)
        {
            this.email = email;
            this.nome = nome;
        }

        public Participante()
                : this( "", "")
        {

        }

        public bool podeInscrever(Eventos e)
        {
            bool pode = false;
            if (e.OsEventos != null)
                pode = true;
            int ev = 0;
            int i = 0;
            Participante p = new Participante(this.email, this.nome);
            while (i < 6)
            {
                int j = 0;
                while (j < e.OsEventos[i].QtdeMaxParticipantes)
                {
                    if (e.OsEventos[i].Participantes[j].Equals(p))
                        ev++;
                    j++;
                }
                i++;
            }

            if (ev >= 2)
                pode = false;
            else
                pode = true;
            return pode;
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Participante)obj).email);
        }


        public override string ToString()
        {
            return "Nome:"+this.nome + " - Email:"  + this.email + "\n";
        }
    }
}
