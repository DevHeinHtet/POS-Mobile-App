namespace POSMobileApp.ViewModels
{
    public class OperationResult<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T Data { get; set; }

        public static OperationResult<T> Success(T data)
            => new() { IsSuccess = true, Data = data };

        public static OperationResult<T> Failure(string errorMessage)
            => new() { IsSuccess = false, ErrorMessage = errorMessage };
    }
}
