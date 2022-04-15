// Classe Conteudo

namespace Balta.ContentContext
{
    // Class pai é abstrata, pois nao deixa instanciar
    public abstract class Content 
    {   
        public Content(string title, string url) 
        {
            Id = Guid.NewGuid(); // Guid já constroe o id para todas sa classes
            Title = title ;  
            Url = url ;


        }
        public Guid Id { get ; set;}
        public string Title { get ; set;}
        public string Url { get ; set;}
    }
}