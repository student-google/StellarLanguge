namespace Stellar_Language.api.Response;

public class ListResponse<T>
{
   public ResponseStatus Status { get; set; }
   public List<T>? Result { get; set; }
   public string Message { get; set; }
   private Tuple<ResponseStatus, string> _FullStatus;
   
   //-----
   public static ListResponse<T> Success(List<T> result)
   {
      return new ListResponse<T> { Status = ResponseStatus.Success,Result = result , Message = ""};
   }
   //-----
   public static ListResponse<T> Failed(ResponseStatus status)
   {
      return new ListResponse<T>() { Status = status, Result = null };
   }
   //-----
   public static ListResponse<T> Failed(ResponseStatus status, string message)
   {
      return new ListResponse<T> { Status = status,Result = null, Message = message};
   }
   //-----
   public static implicit operator ListResponse<T>(List<T> result)
   {
      return ListResponse<T>.Success(result);
   }
   public static implicit operator ListResponse<T>(ResponseStatus status)
   {
      return ListResponse<T>.Failed(status);
   }
   public static implicit operator ListResponse<T>(Tuple<ResponseStatus,string> v)
   {
      return new ListResponse<T> { Status = v.Item1, Message = v.Item2};
   }
}