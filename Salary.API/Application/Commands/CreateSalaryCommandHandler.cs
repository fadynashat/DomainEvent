using MediatR;
using Salary.Dmoain.AggregatesModel.EmployeeAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Salary.API.Application.Commands
{
    public class CreateSalaryCommandHandler : IRequestHandler<CreateSalaryCommand, bool>
    {
        private readonly ISalaryRepository _Repository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;
        public CreateSalaryCommandHandler(IMediator mediator, ISalaryRepository Repository)
        {
            _mediator = mediator;
            _Repository = Repository;
        }

        public async Task<bool> Handle(CreateSalaryCommand request, CancellationToken cancellationToken)
        {



            var salary = new Dmoain.AggregatesModel.EmployeeAggregate.Salary(request.EmpId,request.Salary);
            _Repository.Add(salary);

            return await _Repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

        }

    }
}
