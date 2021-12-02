using System.Collections.Generic;

namespace API_Champions_Manager.Data.Converter.Contract
{
    public interface IParser<O, D> // O - Origem / D - Destino
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
