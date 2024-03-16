namespace Bumb.SharedKernel.CSharp.Base.Drivings.Requests;

public interface ICommandRequest<TBody> where TBody : notnull
{
    public TBody Body { get; init; }
}