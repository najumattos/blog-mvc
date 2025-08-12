using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogAna.Models;

namespace BlogAna.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Olá Mundo";


        Categoria tecnologia = new()
        {
            Id = 1,
            Nome = "Tecnologia"
        };

        Categoria literatura = new(2, "Literatura");

        List<Postagem> postagens = [
            new(){
                Id = 1,
                Nome = "Avanços em Chips de IA: ",                
                Categoria = tecnologia,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Novidades",
                Texto = "Grandes empresas de tecnologia estão investindo pesado em chips especializados para inteligência artificial, que prometem acelerar ainda mais o processamento de dados e o treinamento de modelos de IA, impulsionando a próxima geração de aplicações.",
                Thumbnail = "/img/tb1.png",
                Foto = "/img/1.png"
            },
            new(){
                Id = 2,
                Nome = "Sustentabilidade na Mineração de Criptomoedas: ",                
                Categoria = tecnologia,
                DataPostagem = DateTime.Parse("10/06/2023"),
                Descricao = "Meio Ambiente",
                Texto = " Há um movimento crescente para tornar a mineração de criptomoedas mais sustentável. Novas tecnologias e iniciativas estão surgindo para reduzir o consumo de energia e a pegada de carbono, o que é um tema importante para o futuro da blockchain.",
                Thumbnail = "/img/tb2.png",
                Foto = "/img/2.png"
            },
             new(){
                Id = 3,
                Nome = "Sustentabilidade na Mineração de Criptomoedas: ",                
                Categoria = tecnologia,
                DataPostagem = DateTime.Parse("10/08/2025"),
                Descricao = "Novidade",
                Texto = "Há um movimento crescente para tornar a mineração de criptomoedas mais sustentável. Novas tecnologias e iniciativas estão surgindo para reduzir o consumo de energia e a pegada de carbono, o que é um tema importante para o futuro da blockchain.",
                Thumbnail = "/img/tb3.png",
                Foto = "/img/3.png"
            },
            new(){
                Id = 4,
                Nome = "Cibersegurança em Foco com Ataques Ransomware",                
                Categoria = tecnologia,
                DataPostagem = DateTime.Parse("01/08/2025"),
                Descricao = "Segurança",
                Texto = "Há um movimento crescente para tornar a mineração de criptomoedas mais sustentável. Novas tecnologias e iniciativas estão surgindo para reduzir o consumo de energia e a pegada de carbono, o que é um tema importante para o futuro da blockchain.",
                Thumbnail = "/img/tb4.png",
                Foto = "/img/4.png"
            },
            new(){
                Id = 5,
                Nome = "Programação Low-Code e No-Code Ganhando Espaço",                
                Categoria = tecnologia,
                DataPostagem = DateTime.Parse("10/09/2024"),
                Descricao = "Low Code",
                Texto = "Ferramentas de desenvolvimento low-code e no-code estão se popularizando, permitindo que pessoas com menos experiência em programação criem aplicativos e sistemas. ",
                Thumbnail = "/img/tb5.png",
                Foto = "/img/5.png"
            },
            new(){
                Id = 6,
                Nome = "Audiobooks e Podcasts Literários em Ascensão:",                
                Categoria = literatura,
                DataPostagem = DateTime.Parse("11/09/2024"),
                Descricao = "Ouvir Livro",
                Texto = "O consumo de literatura em formato de áudio continua a crescer exponencialmente. Plataformas de audiobooks e podcasts dedicados a resenhas, discussões e leitura de obras literárias estão popularizando o acesso a histórias e expandindo o alcance dos autores.",
                Thumbnail = "/img/tb6.png",
                Foto = "/img/6.png"
            },
            new(){
                Id = 7,
                Nome = "Realidade Aumentada em Livros Infantis",                
                Categoria = literatura,
                DataPostagem = DateTime.Parse("11/10/2024"),
                Descricao = "IA para baixinhos",
                Texto = " Editoras estão explorando a Realidade Aumentada (RA) para criar experiências de leitura mais imersivas, especialmente para crianças. Livros impressos que ganham vida com animações e elementos interativos através de um smartphone ou tablet estão se tornando uma tendência.",
                Thumbnail = "/img/tb7.png",
                Foto = "/img/7.png"
            },
            new(){
                Id = 8,
                Nome = "Preservação Digital de Obras Raras: ",                
                Categoria = literatura,
                DataPostagem = DateTime.Parse("07/09/2024"),
                Descricao = "História",
                Texto = "Projetos de digitalização em larga escala estão usando tecnologia avançada para preservar manuscritos antigos e obras literárias raras. Bibliotecas e instituições culturais estão tornando esses tesouros acessíveis globalmente, garantindo sua sobrevivência para futuras gerações de leitores e pesquisadores",
                Thumbnail = "/img/tb8.png",
                Foto = "/img/8.png"
            },
            new(){
                Id = 9,
                Nome = "Plataformas de Leitura Social e Interativa:",                
                Categoria = literatura,
                DataPostagem = DateTime.Parse("07/09/2024"),
                Descricao = "Comunidade",
                Texto = "Novas plataformas online estão surgindo para criar comunidades de leitores, permitindo discussões, marcações colaborativas e até mesmo a criação de histórias interativas onde o leitor escolhe o rumo da narrativa. Isso transforma a leitura em uma experiência mais engajadora e social.",
                Thumbnail = "/img/tb9.png",
                Foto = "/img/9.png"
            }
        ];

        
        return View(postagens);
    }
    public IActionResult Postagem(){
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
