using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace API_Champions_Manager.HyperMedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
