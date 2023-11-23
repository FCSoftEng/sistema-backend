namespace plantaoUC9.Classes
{    
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj { get; set; }       

        public void Inserir(PessoaJuridica pj)
        {
            using (StreamWriter sw = new StreamWriter($"{pj.Nome}.txt"))
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.Cnpj}");
            }
        }
        
        public PessoaJuridica Ler(string nomeArquivo)
        {
            PessoaJuridica pj = new PessoaJuridica();

            using (StreamReader sr = new StreamReader($"{nomeArquivo}.txt"))
            {
                string[] atributos = sr.ReadLine()!.Split(",");

                pj.Nome = atributos[0];
                pj.Rendimento = float.Parse(atributos[1]);
                pj.Cnpj = atributos[2];
            }
            return pj; 
        }
    }
}
