namespace projeto_contatos
{
    public class ContatoComercial : Contato,IContatoComercial
    {
        public string CNPJ { get; set; }

        public bool ValidarCNPJ(string _cnpj)
        {
            CNPJ = _cnpj;
            if (Enumerable.Count(_cnpj) == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}