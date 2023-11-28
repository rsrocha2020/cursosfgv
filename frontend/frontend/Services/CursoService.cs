using frontend.Models;

namespace frontend.Services;

public class CursoService : ICursoService
{
    public IEnumerable<CursoInfo> GetCursos()
    {
        var cursos = new List<CursoInfo>
        {
            new CursoInfo { CursoNome = "Análise de Sistemas", Descricao = "atividade que tem como finalidade a realização de estudos de processos a fim de encontrar o melhor caminho racional para que a informação possa ser processada", CursoPreco = 45.90M, EmFalta = "sim"},
            new CursoInfo { CursoNome = "Segurança da Informação", Descricao = "diretamente relacionada com proteção de um conjunto de informações, no sentido de preservar o valor que possuem para um indivíduo ou uma organização", CursoPreco = 75.50M, EmFalta = "não"},
            new CursoInfo { CursoNome = "Engenharia Civil", Descricao = "ramo da engenharia que planeja, projeta, executa e faz a gestão de obras de infraestrutura e empreendimentos", CursoPreco = 32.45M, EmFalta = "sim"},
            new CursoInfo { CursoNome = "Psicologia", Descricao = "área da ciência que estuda a mente e o comportamento humano e as suas interações com o ambiente físico e social", CursoPreco = 45.50M, EmFalta = "sim"},
            new CursoInfo { CursoNome = "Gestão de Projetos", Descricao = "processo de liderar o trabalho de uma equipe para atingir todos os objetivos de um projeto, dentro das restrições especificadas", CursoPreco = 35.99M, EmFalta = "não"},
            new CursoInfo { CursoNome = "Direito", Descricao = "sistema de normas que regula as condutas humanas por meio de direitos e deveres", CursoPreco = 40.75M, EmFalta = "sim"},
            new CursoInfo { CursoNome = "Administração Pública", Descricao = "define como o poder de gestão do Estado, no qual inclui o poder de legislar e tributar, fiscalizar e regulamentar, através de seus órgãos e outras instituições", CursoPreco = 51.50M, EmFalta = "sim"}
        };
        return cursos;
    }
}
