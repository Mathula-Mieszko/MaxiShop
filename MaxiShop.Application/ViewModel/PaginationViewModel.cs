using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.ViewModel
{
    public class PaginationViewModel<T>
    {
        public int CurrentPage {  get; set; }
        public int PageCount { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public List<T> Items { get; set; }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalCount;

        public PaginationViewModel(int currentPage, int pageCount, int pageSize, int totalCount, List<T> items)
        {
            CurrentPage = currentPage;
            PageCount = pageCount;
            PageSize = pageSize;
            TotalCount = totalCount;
            Items = items;
        }
    }
}
