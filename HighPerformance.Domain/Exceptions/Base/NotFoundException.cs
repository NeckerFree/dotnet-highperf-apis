using System;

namespace HighPerformance.Domain.Exceptions.Base
{
    public class NotFoundException(string message): Exception( message)
    {
    }
}
