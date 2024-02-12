namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;

public class InvalidStringIdExc(string value, Exception childExc) : BaseExc(value, childExc);