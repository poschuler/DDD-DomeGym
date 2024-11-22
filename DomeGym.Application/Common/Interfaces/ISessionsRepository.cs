using System;
using DomeGym.Domain.SessionAggregate;

namespace DomeGym.Domain.Common.Interfaces;

public interface ISessionsRepository
{
    Task AddSessionsAsync(Session session);
    Task UpdateSessionsAsync(Session session);
}
