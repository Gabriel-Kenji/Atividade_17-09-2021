using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_17_09_2021
{
    class Eventos
    {
        private Evento[] osEventos;

        public Evento[] OsEventos { get => osEventos; set => osEventos = value; }


        public Eventos()
        {
            this.osEventos = new Evento[6];
            for (int i = 0; i < 6; i++)
            {
                this.osEventos[i] = new Evento();
            }
        }

        public void adicionarEvento(Evento e, int dia)
        {
            this.osEventos[dia - 1] = e;
        }

        public string pesquisarParticipante(Participante p)
        {
            string ev = "";
            string a = "";
            int i = 0;
            bool l = true;
            string dias = "";
            int res = 0;
            bool evs = false;
            while (i<6)
            {
                
                int j = 0;
                while (j < osEventos[i].QtdeMaxParticipantes)
                {
                    if(osEventos[i].Participantes[j].Equals(p))
                    {
                        if(evs)
                        {
                            ev = "\n\nEventos:";
                            evs = true;
                        }
                        res = i;
                        if (res == 0) { dias = "SEG."; }
                        if (res == 1) { dias = "TER."; }
                        if (res == 2) { dias = "QUA."; }
                        if (res == 3) { dias = "QUI."; }
                        if (res == 4) { dias = "SEX."; }
                        if (res == 5) { dias = "SAB."; }
                        ev += "Dia: " + (res + 1) + "-" + dias + " - Id:" + osEventos[i].Id + " - Descrição:" + osEventos[i].Descricao + " - QtdeMax:" + osEventos[i].QtdeMaxParticipantes + " - Quantidade de participantes:" + osEventos[i].qtdeParticipantes() + "\n";
                        a = osEventos[i].Participantes[j].ToString();
                    }
                    j++;
                }
                i++;
            }
               
            
            return a+ev;
            
            
        }

        public int qtdeParticipantes()
        {
            int total = 0;
            foreach (Evento e in this.osEventos)
            {
                total += e.qtdeParticipantes();
            }

            return total;
        }

        public string listaEventos()
        {
            string dados = "";
            int res = 0;
            string dias = "";
            foreach (Evento e in this.osEventos)
            {

                if (res == 0) { dias = "SEG."; }
                if (res == 1) { dias = "TER."; }
                if (res == 2) { dias = "QUA."; }
                if (res == 3) { dias = "QUI."; }
                if (res == 4) { dias = "SEX."; }
                if (res == 5) { dias = "SAB."; }

                dados += "Dia: " + (res+1)+ "-" + dias + " - Id:" + e.Id + " - Descrição:" + e.Descricao + " - QtdeMax:" + e.QtdeMaxParticipantes + " - Quantidade de participantes:" + e.qtdeParticipantes() + "\n";
                res++;
            }
            dados += "-----------------------";
            return dados;
        }   
    }
}
