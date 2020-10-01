using ByProject.Domain.Core.Events;
using FluentValidation.Results;
using MediatR;
using System;

namespace ByProject.Domain.Core.Commands
{
    public abstract class Command : Message, IRequest<bool>
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
