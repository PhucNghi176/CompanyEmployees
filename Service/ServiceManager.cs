using AutoMapper;
using CompanyEmployees.Extensions;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IEmployeeService> _employeeService;
        private readonly Lazy<ICompanyService> _companyService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
logger)
        {

            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, logger));
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger));

        }
        public IEmployeeService EmployeeService => _employeeService.Value;
        public ICompanyService CompanyService => _companyService.Value;
    }
}
