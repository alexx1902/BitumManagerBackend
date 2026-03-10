using Bitum.Application.MaterialUnits;
using Bitum.Contracts;
using Bitum.Domain;
using FluentValidation;
using Microsoft.Extensions.Logging;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bitum.Application.Containers
{
    public class MaterialUnitsService
    {
        
        private readonly IMaterialUnitsRepository _materialUnitsRepository;
        private readonly ILogger _logger;
        private readonly IValidator<MaterialUnit> _validator;
        private readonly IQrCodeGenerator _qrCodeGenerator;
        public MaterialUnitsService(IMaterialUnitsRepository materialUnitsRepository, ILogger<MaterialUnitsService> logger, IQrCodeGenerator qrCodeGenerator)
        {
            _materialUnitsRepository = materialUnitsRepository;
            _logger = logger;
            _qrCodeGenerator = qrCodeGenerator;
        }
         
        public async Task<byte[]> Create(MaterialUnit materialUnit,CancellationToken cancellationToken)
        {
            // проверка_валидности
            //var validationResult = await _validator.ValidateAsync(materialUnit);
            //валидация входных данных
            //if (!validationResult.IsValid)
            //{
            //    throw new ValidationException(validationResult.Errors);
            //}
             //ваЫлидация бизнес логики
             
            // создание_контейнера

            // сохранение_в_бд

            // логгирование_об_создании
            var materialUnitId = Guid.NewGuid();
            
            //var QrCode = QRCoder.QRCodeGenerator.GenerateQrCode();

            //var materialUnit = new Bitum.Domain.MaterialUnit();
            materialUnit = new MaterialUnit // 1. Указываем имя класса вместо фигурных скобок
            {
                Id = materialUnitId,
                ManufactureDate = DateTime.Now,
                Weight = 12.5, // 2. Обязательно задаем все required свойства
                               // Если значение пока неизвестно, можно использовать заглушку,
                               // но лучше спроектировать логику так, чтобы вес был известен сразу.

                // Остальные свойства (Note, Recept и т.д.) не являются required,
                // поэтому их можно не указывать при инициализации. 
            };
            var jsonSerialize = JsonSerializer.Serialize(materialUnit);

            var qrCodeBytes = _qrCodeGenerator.Generate(jsonSerialize);

            await _materialUnitsRepository.AddAsync(materialUnit, cancellationToken);

            return qrCodeBytes;

            //_logger.LogInformation($"Container created with id {container}", container);
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
