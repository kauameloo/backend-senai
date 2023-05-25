using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fixaçao_mvc.Model;
using fixaçao_mvc.View;

namespace fixaçao_mvc.Controller
{
    public class EventoController
    {
        EventoModel eventoModel = new EventoModel();
        EventoView eventoView = new EventoView();
        public void CadastrarEvento()
        {
            eventoModel.Inserir(eventoView.Cadastrar());
        }

        public void ListarEvento()
        {
            List<EventoModel> eventos = eventoModel.Ler();
            eventoView.Listar(eventos);
        }

        public void MenuMostrar()
        {
            eventoView.Menu();
        }
    }
}