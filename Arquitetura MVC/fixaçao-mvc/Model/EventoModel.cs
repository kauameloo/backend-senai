using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fixaçao_mvc.Model
{
    public class EventoModel
    {
        // propriedades
        // O evento deve ter Nome, Descrição e Data que o evento ocorrerá.
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }


        // caminho da pasta e do arquivo csv
        private const string PATH = "Database/Eventos.csv";

        // criar a lógica para gerar a pasta e o arquivo
        public EventoModel()
        {
            // obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            // verificar se no caminho já existe uma pasta
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(pasta);
            }

            // verificar se no caminho já existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        // método para preparar as linhas a serem inseridas no csv
        public List<EventoModel> Ler()
        {
            List<EventoModel> eventos = new List<EventoModel>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                EventoModel e = new EventoModel();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = DateTime.Parse(atributos [2]);

                eventos.Add(e);
            }

            return eventos;
        }

        // método para preparar as linhas a serem inseridas no csv
        public string PrepLinha(EventoModel e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }


        // método para inserir um produto na linha do csv
        public void Inserir(EventoModel e)
        {
            string[] linhas = {PrepLinha(e)};

            File.AppendAllLines(PATH, linhas);
        }

        public void Deletar(EventoModel e)
        {
            
        }
    }
}