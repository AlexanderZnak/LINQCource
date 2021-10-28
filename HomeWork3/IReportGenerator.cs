using System.Collections.Generic;

namespace HomeWork3
{
    public interface IReportGenerator
    {
        public void SortEntities<T>(ref List<T> entities) where T : User;
    }
}