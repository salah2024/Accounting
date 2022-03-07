namespace Accounting.Common.Dto
{
    public class ResultWithValidationDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<ValidatorCheck> Errors { get; set; }
    }

    public class ResultWithValidationDto<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<ValidatorCheck> Errors { get; set; }
    }
}
