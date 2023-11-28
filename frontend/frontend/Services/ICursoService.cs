using frontend.Models;

namespace frontend.Services;

public interface ICursoService
{
   IEnumerable<CursoInfo> GetCursos();
}
