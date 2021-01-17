using MediatR;
using Salary.Dmoain.AggregatesModel.EmployeeAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Salary.API.Application.Commands
{
    public class UpdateSalaryCommandHandler : IRequestHandler<UpdateSalaryCommand, bool>
    {
        private readonly ISalaryRepository _Repository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;
        public UpdateSalaryCommandHandler(IMediator mediator, ISalaryRepository Repository)
        {
            _mediator = mediator;
            _Repository = Repository;
        }

        public async Task<bool> Handle(UpdateSalaryCommand request, CancellationToken cancellationToken)
        {
            var salaryInDb = await _Repository.GetAsync(request.Id);
            salaryInDb.UpdateSalary(request.Salary);

            _Repository.Update(salaryInDb);

            return await _Repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

        }

    }
}
