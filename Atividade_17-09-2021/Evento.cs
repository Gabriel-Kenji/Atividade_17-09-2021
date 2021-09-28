using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_17_09_2021
{
    class Evento
    {

        private int id;                                        
        private string descricao;                              
        private int qtdeMaxParticipantes;                      
        private Participante[] participantes;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int QtdeMaxParticipantes { get => qtdeMaxParticipantes; set => qtdeMaxParticipantes = value; }
        public Participante[] Participantes { get => participantes; set => participantes = value; }

        public Evento(int id, string descricao, int qtdeMaxParticipantes)
        {
            this.id = id;
            this.descricao = descricao;
            this.qtdeMaxParticipantes = qtdeMaxParticipantes;
            this.participantes = new Participante[this.qtdeMaxParticipantes];
            for (int i = 0; i < this.qtdeMaxParticipantes; i++)
            {
                this.participantes[i] = new Participante();
            }
        }

        public Evento()
            : this(0, "",0)
        {

        }

        public int inscreverParticipante(Participante p, Eventos e)
        {
            int a = -1;
            if(p.podeInscrever(e))
            {
                if (this.qtdeParticipantes() == this.qtdeMaxParticipantes)
                {
                    a = 1;
                }
                else
                {
                    this.participantes[this.qtdeParticipantes()] = p;
                    a = 0;
                }
            }
            else
            {
                a = 2;
            }
            
            return a;
        }

        public int qtdeParticipantes()
        {
            int par = this.qtdeMaxParticipantes;
            Participante p = new Participante();
            int i = 0;
            while (i < this.qtdeMaxParticipantes)
            {
                if (this.participantes[i].Equals(p))
                    par--;
                i++;
            }
            return par;
        }

        public string listaParticipantes()
        {
            string dados = "";
            foreach (Participante p in this.participantes)
                dados += p.ToString();
            dados += "-----------------------";
            return dados;
        }


        public override bool Equals(object obj)
        {
            return this.id.Equals(((Evento)obj).id);
        }

        public override string ToString()
        {
            return "Id:" + this.id + " -  Descrição:" + this.descricao + " - QtdeMax:" + this.qtdeMaxParticipantes + "\nParticipantes:\n" + listaParticipantes() + "\n" ;
        }
    }
}
