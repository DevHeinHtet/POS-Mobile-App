namespace POSMobileApp.ViewModels
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        public PagedResult() { }

        public PagedResult(IEnumerable<T> items, int count, int pageIndex, int pageSize)
        {
            CurrentPage = pageIndex;
            PageSize = pageSize;
            TotalCount = count;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            if (TotalPages == 0) TotalPages = 1;

            Items = items;
        }
    }
}
