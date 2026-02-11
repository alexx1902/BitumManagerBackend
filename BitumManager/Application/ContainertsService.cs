using Bitum.Contracts;
using Bitum.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ContainersService
    {
        
        private readonly IContainersRepository _containersRepository;

        public ContainersService(IContainersRepository containersRepository)
        {
            _containersRepository = containersRepository;
        }

        public async Task Create(CreateContainerDTO containerDTO , CancellationToken cancellationToken)
        {
            // проверка_валидности

            // создание_контейнера

            // сохранение_в_бд

            // логгирование_об_создании

            var container = new Container()
            {
                Id = containerDTO.Id,
                Capacity = containerDTO.Capacity,
                Number = containerDTO.Number
            };

            await _containersRepository
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
