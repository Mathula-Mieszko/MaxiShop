using MaxiShop.Application.InputModels;
using MaxiShop.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.Services.Interface
{
    public interface IPaginationService<T,S> where T:class
    {
        PaginationViewModel<T> GetPagination(List<S> source, PaginationInputModel pagination);
    }
}
