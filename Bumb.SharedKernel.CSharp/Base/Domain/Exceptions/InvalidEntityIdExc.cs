namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;

public class InvalidEntityIdExc(Guid value, Exception childExc) : BaseExc(value, childExc);