
namespace AdminProvider.Domain.Models;


public class ResponseResult<T> : ResponseResult //Får via denna valmöjligheten att ange en type(någon typ av data) när jag ska använda ResponseResult när jag senare i programmet vill använda response result för andra områden. Kan välja att sätta en type eller inte.
{
    public T? Data { get; set; }
}
public class ResponseResult
{
    public bool Success { get; set; }

    public int StatusCode { get; set; }

    public string? Message { get; set; }


}