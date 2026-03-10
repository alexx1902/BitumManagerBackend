using Bitum.Contracts;
using Bitum.Domain;
using FluentValidation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitum.Application.Containers
{
    public class ContainersService
    {
        
        private readonly IMaterialUnitsRepository _containersRepository;
        private readonly ILogger _logger;
        private readonly IValidator<CreateContainerDTO> _validator;
        public ContainersService(IMaterialUnitsRepository containersRepository, ILogger<ContainersService> logger)
        {
            _containersRepository = containersRepository;
            _logger = logger;
        }
         
        public async Task Create(CreateContainerDTO containerDTO , CancellationToken cancellationToken)
        {
            // проверка_валидности
            var validationResult = await _validator.ValidateAsync(containerDTO);
            //валидация входных данных
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
             //валидация бизнес логики
             
            // создание_контейнера

            // сохранение_в_бд

            // логгирование_об_создании
            var containerId = Guid.NewGuid();
            var container = new Container()
            {
                Id = containerId,
                Capacity = containerDTO.Capacity,
                Number = containerDTO.Number
            };

            //await _containersRepository.AddAsync(container, cancellationToken);
            _logger.LogInformation($"Container created with id {container}", container);
        }
  
        public async Task GetAll( GetContainerDTO getContainerDTO, CancellationToken cancellationToken)
        {
            
        }

     
        public async Task GetById( Guid containerId, CancellationToken cancellationToken)
        {
            
        }

        
        public async Task Update( Guid containerId,  UpdateContainerDTO updateDTO, CancellationToken cancellationToken)
        {
            
        }

       
        public async Task Delete( Guid containerId, CancellationToken cancellationToken)
        {
            
        }

        
        public async Task GetFullContainers( Guid containerId, CancellationToken cancellationToken)
        {

           
        }


    }
}
