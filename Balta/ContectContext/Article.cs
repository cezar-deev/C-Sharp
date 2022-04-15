//Classe Artigo

namespace Balta.ContentContext
{
    public class Article : Content  // Classe Article recebendo herança do construtor 
    {
        public Article(string title, string url)
            : base (title, url)
        {
            
        }
    }
}