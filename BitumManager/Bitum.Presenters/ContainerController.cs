using Bitum.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Bitum.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContainerController : ControllerBase
    {

        public ContainerController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateContainerDTO containerDTO)
        {
            return Ok("Question created");
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetContainerDTO getContainerDTO, CancellationToken cancellationToken)
        {
            return Ok("container has been received");
        }

        [HttpGet("{containerId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid containerId, CancellationToken cancellationToken)
        {
            return Ok("container has been received");
        }

        [HttpPut("{containerId:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid containerId, [FromBody] UpdateContainerDTO updateDTO, CancellationToken cancellationToken)
        {
            return Ok("container has been updated");
        }

        [HttpDelete("{containerId:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid containerId, CancellationToken cancellationToken)
        {
            return Ok("container has been deleted");
        }

        [HttpGet("{containerId:guid}/full_container")]
        public async Task<IActionResult> GetFullContainers([FromRoute] Guid containerId, CancellationToken cancellationToken)
        {

            return Ok("Ok");
        }

       
    }
}
