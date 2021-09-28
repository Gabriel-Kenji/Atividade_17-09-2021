using System;

namespace Atividade_17_09_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Participante p = new Participante("a", "b"); 
            Participante p2 = new Participante("a2", "b2");


            Console.WriteLine(p.ToString());

            
            Evento ev2 = new Evento(1, "bb", 11);
            Evento ev3 = new Evento(3, "cc", 9);

            
            Evento ev1 = new Evento(2, "aa", 10);
            evs.adicionarEvento(ev1, 1);
            

            

            
            evs.adicionarEvento(ev2, 2);
            evs.adicionarEvento(ev3, 3);
            Console.WriteLine("p ev3:" + ev3.inscreverParticipante(p, evs));
            Console.WriteLine("qtde ev1:" + ev1.qtdeParticipantes());

            Console.WriteLine("p ev1: " + ev1.inscreverParticipante(p, evs));
            Console.WriteLine("p ev2: " + ev2.inscreverParticipante(p, evs));
            Console.WriteLine("qtde ev1:" + ev1.qtdeParticipantes());
            Console.WriteLine("p2 ev1: " + ev1.inscreverParticipante(p2, evs));
            Console.WriteLine("qtde ev1:" + ev1.qtdeParticipantes());
            Console.WriteLine("lista ev1: \n"+ev1.listaParticipantes());


            Console.WriteLine("\n \n" + evs.pesquisarParticipante(p) + "aaaaaa");
            

            Console.WriteLine(p.podeInscrever(evs));
            Console.WriteLine(evs.listaEventos());*/
            Eventos evs = new Eventos();
            int i = -1;
            while(i!=0)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Menu\n");

                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Adicionar evento");
                Console.WriteLine("2.Pesquisar evento");
                Console.WriteLine("3.Listar eventos");
                Console.WriteLine("4.Adicionar participante");
                Console.WriteLine("5.Pesquisar participante");
                Console.WriteLine("6.Informar quantidade total de participantes nos eventos da semana");
                Console.WriteLine("--------------------------------------------------------------------------");
                int k = 0;
                while (k == 0)
                {
                    Console.Write("\nDigite o numero da opção desejada:");
                    string confi = Console.ReadLine();
                    if (!string.IsNullOrEmpty(confi))
                    {
                        bool result = int.TryParse(confi, out i);
                        if (result)
                        {
                            k++;
                        }
                        else
                        {
                            Console.WriteLine("Erro! Digite um valor valido.");
                        }
                        
                    }   
                    else
                    {
                        Console.WriteLine("Erro! Digite um valor valido.");
                    }
                }
                
                switch (i)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("\nPrograma finalizado!\n\n");
                        break;
                    case 1:

                        Console.WriteLine("--------------------------------------------------------------------------\nAdicionar evento:");
                        int j = 0;
                        int a = 0;
                        int pro = 0;
                        bool ex = false;
                        int id = 0;
                        string desc = "";
                        int qtdemax = 0;
                        int dia = 0;
                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do evento:"); 
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            Evento ev = new Evento(id, "aa", 0);
                            while (j < 6 )
                            {
                                
                                if (evs.OsEventos[j].Equals(ev))
                                    ex = true;
                                j++;
                            }
                            if (!ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado ja está em uso, digite um valido.\n");
                        }
                        Console.Write("Digite uma descrição para o evento:");
                        desc = Console.ReadLine();

                        k = 0;
                        while (k == 0)
                        {
                            Console.Write("Digite a quantidade maxima de pessoas no evento:");
                            string confi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(confi))
                            {
                                bool result = int.TryParse(confi, out qtdemax);
                                if (result)
                                {
                                    k++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Erro! Digite um valor valido.");
                            }
                        }
                        a = 0;
                        while (a==0)
                        {
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o numero correspondente ao dia do evento (1=SEG, 2=TER, 3=QUA, 4=QUI, 5=SEX, 6=SAB):");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out dia);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            if(dia>0 && dia<7)
                            {
                                a++;
                            }
                        }
                        k = 0;
                        while (k == 0)
                        {
                            Console.Write("\n\nCaso ja exista um evento cadastrado no dia cadatrado ele sera substituido pelo atual\nDeseja prosseguir?(1-Sim 0-Não):");
                            string confi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(confi))
                            {
                                bool result = int.TryParse(confi, out pro);
                                if (result)
                                {
                                    k++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Erro! Digite um valor valido.");
                            }
                        }
                        if (pro == 1)
                        {
                            Evento ev = new Evento(id, desc, qtdemax);
                            evs.adicionarEvento(ev, dia);
                        }
                        else 
                        {
                            Console.WriteLine("Cadastro de evento cancelado!");
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("--------------------------------------------------------------------------\nPesquisar evento:");
                        a = 0;
                        int res = -1;
                        string dias = "";
                        k = 0;
                        id = 0;
                        while (k == 0)
                        {
                            Console.Write("\nDigite o Id do Evento procurado:");
                            string confi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(confi))
                            {
                                bool result = int.TryParse(confi, out id);
                                if (result)
                                {
                                    k++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Erro! Digite um valor valido.");
                            }
                        }

                        Evento v = new Evento(id, "", 0);
                        while (a < 6)
                        {
                            
                            if (evs.OsEventos[a].Equals(v))
                            {
                                res = a;
                            }
                            
                            a++;
                        }
                        if(res != -1)
                        {
                            if (res == 0)
                                dias = "SEG.";
                            if (res == 1)
                                dias = "TER.";
                            if (res == 2)
                                dias = "QUA.";
                            if (res == 3)
                                dias = "QUI.";
                            if (res == 4)
                                dias = "SEX.";
                            if (res == 5)
                                dias = "SAB.";
                            string dados = "Dia: " + dias + " - " + evs.OsEventos[res].ToString();
                            Console.WriteLine(dados);
                        }
                        else
                        {
                            Console.WriteLine("Evento não encontrado");
                        }


                       


                        

                        break;
                    case 3:
                        Console.WriteLine(evs.listaEventos()); 
                        break;
                    case 4:

                        Console.WriteLine("--------------------------------------------------------------------------\nAdicionar participante:");
                        k = 0;
                        dia = 0;
                        while (k == 0)
                        {
                            Console.Write("\n\nEscolha em qual evento deseja cadastrar o usuario:\n"+evs.listaEventos()+"\n Digite o dia da semana do evento:");
                            string confi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(confi))
                            {
                                bool result = int.TryParse(confi, out dia);
                                if (result && dia>0 && dia<7)
                                {
                                    k++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Erro! Digite um valor valido.");
                            }
                        }
                        string email = "";
                        a = 0;
                        while (a == 0)
                        {
                            Console.Write("\nDigite o email do usuario:");
                            email = Console.ReadLine();
                            if (!string.IsNullOrEmpty(email))
                            {
                                
                                a++;
                            }
                            else
                            {
                                Console.WriteLine("Digite um email valido");
                            }
                        }
                        string nome = "";
                        a = 0;
                        while (a == 0)
                        {
                            Console.Write("\nDigite o nome do usuario:");
                            nome = Console.ReadLine();
                            if (!string.IsNullOrEmpty(nome))
                            {

                                a++;
                            }
                            else
                            {
                                Console.WriteLine("Digite um nome valido");
                            }
                        }
                        Participante p = new Participante(email,nome);
                        int m = 0;
                        bool ok = false;
                        int codigo = -1;
                        while (m< evs.OsEventos[dia - 1].QtdeMaxParticipantes)
                        {
                            if (evs.OsEventos[dia - 1].Participantes[m].Equals(p))
                            {
                                ok  = true;
                            }
                            m++;
                        }
                        if(!ok)
                        {
                            codigo = evs.OsEventos[dia - 1].inscreverParticipante(p, evs);
                        }
                        else
                        {
                            
                            Console.WriteLine("Usuario já cadastrado nesse evento");
                        }
                        

                        if(codigo == 0)
                        {
                            Console.WriteLine("Inscrição efetuada");
                        }
                        else if (codigo == 1)
                        {
                            Console.WriteLine("Evento lotado");
                        }
                        else if (codigo == 2)
                        {
                            Console.WriteLine("Excedido limite de inscrições para o participante");
                        }
                            break;
                    case 5:
                        Console.WriteLine("--------------------------------------------------------------------------\nPesquisar participante:");
                        email = "";
                        a = 0;
                        while (a == 0)
                        {
                            Console.Write("\nDigite o email do usuario:");
                            email = Console.ReadLine();
                            if (!string.IsNullOrEmpty(email))
                            {

                                a++;
                            }
                            else
                            {
                                Console.WriteLine("Digite um email valido");
                            }
                        }
                        Participante p1 = new Participante(email, "");
                        Console.WriteLine("\n \n" + evs.pesquisarParticipante(p1) );
                        break;
                    case 6:
                        Console.WriteLine("--------------------------------------------------------------------------\nInformar quantidade total de participantes nos eventos da semana:");

                        Console.WriteLine("\nQuatidade de participantes:"+ evs.qtdeParticipantes());
                        break;
                }
            }

        }
    }
}
