
using Balta.ContentContext;
    // criando lista de Artigos
    var articles = new List<Article>();
    articles.Add(new Article ("Artigo sobre OOP", "Orientaoa-obj"));
    articles.Add(new Article ("Artigo sobre C#", "csharpe"));
    articles.Add(new Article ("Artigo sobre dotnet", ".NET"));

   foreach (var Article in articles)
   {
       Console.WriteLine(Article.Id);
       Console.WriteLine(Article.Title);
       Console.WriteLine(Article.Url);
   }
    
    // criando lista de cursos
    var courses = new List<Course>();
    var courseOOP = new Course("Fundamentos OOP", "OOP");
    var courseCsharp = new Course("Fundamentos C#", "csarpe");
    var courseDotnet = new Course("Fundamentos >NET", "dotnet");
    courses.Add(courseOOP);
    courses.Add(courseCsharp);
    courses.Add(courseDotnet);

    // crindo uma nova carreira

    var career = new Career("Especialista Dotnet", "Dotnet");




