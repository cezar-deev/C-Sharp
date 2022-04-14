namespace Balta.ContentContext
{
    public abstract class Content // Class pai abstarad, pois nao deixa instanciar
    { 
        public Content() // Construtor
        {
            id = Guid.NewGuid(); // Guid já constroe o id para todas sa classes
        }
        public Guid id { get ; set;}
        public int Title { get ; set;}
        public int url { get ; set;}
    }
}